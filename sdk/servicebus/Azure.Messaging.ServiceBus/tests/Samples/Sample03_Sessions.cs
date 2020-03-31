﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Messaging.ServiceBus.Tests.Samples
{
    public class Sample03_Sessions : ServiceBusLiveTestBase
    {
        [Test]
        public async Task SendAndReceiveSessionMessage()
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: true))
            {
                string connectionString = TestEnvironment.ServiceBusConnectionString;
                string queueName = scope.QueueName;
                #region Snippet:ServiceBusSendAndReceiveSessionMessage
                //@@ string connectionString = "<connection_string>";
                //@@ string queueName = "<queue_name>";
                // since ServiceBusClient implements IAsyncDisposable we create it with "await using"
                await using var client = new ServiceBusClient(connectionString);

                // get the sender
                ServiceBusSender sender = client.GetSender(queueName);

                // create a session message that we can send
                ServiceBusMessage message = new ServiceBusMessage(Encoding.Default.GetBytes("Hello world!"))
                {
                    SessionId = "mySessionId"
                };

                // send the message
                await sender.SendAsync(message);

                // Get a session receiver that we can use to receive the message. Since we don't specify a
                // particular session, we will get the next available session from the service.
                ServiceBusSessionReceiver receiver = await client.GetSessionReceiverAsync(queueName);

                // the received message is a different type as it contains some service set properties
                ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveAsync();
                Console.WriteLine(receivedMessage.SessionId);

                // we can also set arbitrary session state using this receiver
                // the state is specific to the session, and not any particular message
                await receiver.SetSessionStateAsync(Encoding.Default.GetBytes("some state"));

                // the state can be retrieved for the session as well
                byte[] state = await receiver.GetSessionStateAsync();

                #endregion
                Assert.AreEqual(Encoding.Default.GetBytes("Hello world!"), receivedMessage.Body.ToArray());
                Assert.AreEqual("mySessionId", receivedMessage.SessionId);
                Assert.AreEqual(Encoding.Default.GetBytes("some state"), state);
            }
        }

        [Test]
        public async Task ReceiveFromSpecificSession()
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(enablePartitioning: false, enableSession: true))
            {
                string connectionString = TestEnvironment.ServiceBusConnectionString;
                string queueName = scope.QueueName;
                #region Snippet:ServiceBusReceiveFromSpecificSession
                //@@ string connectionString = "<connection_string>";
                //@@ string queueName = "<queue_name>";
                // since ServiceBusClient implements IAsyncDisposable we create it with "await using"
                await using var client = new ServiceBusClient(connectionString);

                // get the sender
                ServiceBusSender sender = client.GetSender(queueName);

                // create a message batch that we can send
                ServiceBusMessageBatch messageBatch = await sender.CreateBatchAsync();
                messageBatch.TryAdd(
                    new ServiceBusMessage(Encoding.UTF8.GetBytes("First"))
                    {
                        SessionId = "Session1"
                    });
                messageBatch.TryAdd(
                    new ServiceBusMessage(Encoding.UTF8.GetBytes("Second"))
                    {
                        SessionId = "Session2"
                    });

                // send the message batch
                await sender.SendBatchAsync(messageBatch);

                // Get a receiver specifying a particular session
                ServiceBusSessionReceiver receiver = await client.GetSessionReceiverAsync(
                    queueName,
                    sessionId: "Session2");

                // the received message is a different type as it contains some service set properties
                ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveAsync();
                Console.WriteLine(receivedMessage.SessionId);

                #endregion
                Assert.AreEqual(Encoding.Default.GetBytes("Second"), receivedMessage.Body.ToArray());
                Assert.AreEqual("Session2", receivedMessage.SessionId);
            }
        }
    }
}

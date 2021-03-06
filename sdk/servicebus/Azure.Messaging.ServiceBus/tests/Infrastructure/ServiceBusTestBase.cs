﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Moq;
using NUnit.Framework;

namespace Azure.Messaging.ServiceBus.Tests
{
    public class ServiceBusTestBase
    {
        protected IEnumerable<ServiceBusMessage> GetMessages(int count, string sessionId = null, string partitionKey = null)
        {
            var messages = new List<ServiceBusMessage>();
            for (int i = 0; i < count; i++)
            {
                messages.Add(GetMessage(sessionId, partitionKey));
            }
            return messages;
        }

        protected ServiceBusMessageBatch AddMessages(ServiceBusMessageBatch batch, int count, string sessionId = null, string partitionKey = null)
        {
            for (int i = 0; i < count; i++)
            {
                Assert.That(() => batch.TryAdd(GetMessage(sessionId, partitionKey)), Is.True, "A message was rejected by the batch; all messages should be accepted.");
            }

            return batch;
        }

        protected Task ExceptionHandler(ProcessErrorEventArgs eventArgs)
        {
            Assert.Fail(eventArgs.Exception.ToString());
            return Task.CompletedTask;
        }

        protected ServiceBusMessage GetMessage(string sessionId = null, string partitionKey = null)
        {
            var msg = new ServiceBusMessage(GetRandomBuffer(100))
            {
                Label = $"test-{Guid.NewGuid()}",
                MessageId = Guid.NewGuid().ToString()
            };
            if (sessionId != null)
            {
                msg.SessionId = sessionId;
            }
            if (partitionKey != null)
            {
                msg.PartitionKey = partitionKey;
            }
            return msg;
        }

        protected byte[] GetRandomBuffer(long size)
        {
            var chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

            var csp = new RNGCryptoServiceProvider();
            var bytes = new byte[4];
            csp.GetBytes(bytes);
            var random = new Random(BitConverter.ToInt32(bytes, 0));
            var buffer = new byte[size];
            random.NextBytes(buffer);
            var text = new byte[size];
            for (int i = 0; i < size; i++)
            {
                var idx = buffer[i] % chars.Length;
                text[i] = (byte)chars[idx];
            }
            return text;
        }

        protected TokenCredential GetTokenCredential() =>
        new ClientSecretCredential(
            TestEnvironment.ServiceBusTenant,
            TestEnvironment.ServiceBusClient,
            TestEnvironment.ServiceBusSecret);

        protected ServiceBusClient GetNoRetryClient()
        {
            var options =
                new ServiceBusClientOptions
                {
                    RetryOptions = new ServiceBusRetryOptions
                    {
                        TryTimeout = TimeSpan.FromSeconds(5),
                        MaximumRetries = 0
                    }
                };
            return new ServiceBusClient(
                TestEnvironment.ServiceBusConnectionString,
                options);
        }

        internal ServiceBusConnection GetMockedConnection()
        {
            var mockConnection = new Mock<ServiceBusConnection>();

            mockConnection
                .Setup(connection => connection.RetryOptions)
                .Returns(new ServiceBusRetryOptions());
            return mockConnection.Object;
        }

        protected ServiceBusClient GetClient(int tryTimeout = 10)
        {
            var retryOptions = new ServiceBusRetryOptions();
            if (tryTimeout != default)
            {
                retryOptions.TryTimeout = TimeSpan.FromSeconds(tryTimeout);
            }
            return new ServiceBusClient(
                TestEnvironment.ServiceBusConnectionString,
                new ServiceBusClientOptions
                {
                    RetryOptions = retryOptions
                });
        }
    }
}

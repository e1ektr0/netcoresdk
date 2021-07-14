﻿using Oddin.OddinSdk.SDK.AMQP.Mapping.Abstractions;
using Oddin.OddinSdk.SDK.API.Entities.Abstractions;
using System.Collections.Generic;

namespace Oddin.OddinSdk.SDK.AMQP.Mapping
{
    internal class BetCancel<T> : MarketMessage<IMarketCancel, T>, IBetCancel<T> where T : ISportEvent
    {
        public long? StartTime { get; }

        public long? EndTime { get; }

        public string SupersededBy { get; }

        public BetCancel(IMessageTimestamp timestamp, IProducer producer, T @event, long? requestId, long? startTime, long? endTime, string supersededBy, IEnumerable<IMarketCancel> markets, byte[] rawMessage)
            : base(producer, timestamp, @event, requestId, rawMessage, markets)
        {
            StartTime = startTime;
            EndTime = endTime;
            SupersededBy = supersededBy;
        }
    }
}

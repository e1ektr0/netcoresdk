﻿using Oddin.OddinSdk.SDK.API.Entities.Abstractions;

namespace Oddin.OddinSdk.SDK.AMQP.Abstractions
{
    /// <summary>
    /// Defines a contract implemented by all messages associated with sport events
    /// </summary>
    /// <typeparam name="T">A <see cref="ISportEvent"/> derived type used to describe the sport event associated with the fixture change</typeparam>
    public interface IEventMessage<out T> : IMessage where T : ISportEvent
    {
        /// <summary>
        /// Gets a <see cref="ISportEvent"/> derived instance representing the sport event associated with the current message
        /// </summary>
        T Event { get; }

        /// <summary>
        /// Get the id of the request which triggered the current <see cref="IEventMessage{T}"/> message or a null reference if
        /// no requestId was provided to the request
        /// </summary>
        long? RequestId { get; }

        /// <summary>
        /// Gets the raw message
        /// </summary>
        /// <value>The raw message</value>
        byte[] RawMessage { get; }
    }
}

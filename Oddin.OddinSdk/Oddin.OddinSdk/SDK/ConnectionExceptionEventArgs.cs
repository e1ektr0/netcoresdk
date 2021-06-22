﻿using System;
using System.Collections.Generic;

namespace Oddin.OddinSdk.SDK
{
    public class ConnectionExceptionEventArgs: EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionExceptionEventArgs"/> class
        /// </summary>
        /// <param name="exception">The exception that caused an error</param>
        /// <param name="detail">Details about the error</param>
        public ConnectionExceptionEventArgs(Exception exception, IDictionary<string, object> detail)
        {
            Exception = exception;
            Detail = detail;
        }

        /// <summary>
        /// The exception that caused an error
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// Details about the error
        /// </summary>
        public IDictionary<string, object> Detail { get; }
    }
}

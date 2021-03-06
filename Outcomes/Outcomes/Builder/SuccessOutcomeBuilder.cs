﻿using System;
using System.Collections.Generic;

namespace Ether.Outcomes.Builder
{
    public class SuccessOutcomeBuilder<T> : OutcomeResult<T>
    {
        internal SuccessOutcomeBuilder(bool success) : base(success)
        {
        }

        /// <summary>
        /// Add a string to the end of the outcome's message collection.
        /// </summary>
        /// <param name="message">String to add.</param>
        /// <returns></returns>
        public SuccessOutcomeBuilder<T> WithMessage(string message)
        {
            base.Messages.Add(message);
            return this;
        }

        /// <summary>
        /// Append a list of strings to the end of the outcome's message collection.
        /// </summary>
        /// <param name="messages">The strings to add.</param>
        /// <returns></returns>
        public SuccessOutcomeBuilder<T> WithMessage(IEnumerable<string> messages)
        {
            if (messages == null)
                return this;

            base.Messages.AddRange(messages);
            return this;
        }

        /// <summary>
        /// Sets the value for a success outcome. The outcome object is really just a wrapper for the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public SuccessOutcomeBuilder<T> WithValue(T value)
        {
            base.Value = value;
            return this; 
        } 
    }
}

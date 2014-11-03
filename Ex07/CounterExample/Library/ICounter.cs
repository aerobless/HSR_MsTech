using System;

namespace Library
{
    /// <summary>
    /// Event handler (callback) definition for counter value changed events.
    /// </summary>
    /// <param name="sender">The counter instance whose count value has been changed.</param>
    /// <param name="e">The event argument containing the former and new count value.</param>
    public delegate void CountChangedEventHandler(ICounter sender, CountChangedEventArgs e);

    /// <summary>
    /// Event argument containing the former and new count value.
    /// Included in <see cref="ICounter.CountChanged"/> events.
    /// </summary>
    public class CountChangedEventArgs : EventArgs
    {
        private int mOldValue;
        private int mNewValue;

        public CountChangedEventArgs(int oldValue, int newValue)
        {
            mOldValue = oldValue;
            mNewValue = newValue;
        }

        public int OldValue
        {
            get { return mOldValue; }
        }

        public int NewValue
        {
            get { return mNewValue; }
        }
    }

    /// <summary>
    /// This interface describes a counter which provides increment and decrement functionality on an
    /// integer value.
    /// Clients (such as a GUI) can register themselves to the <see cref="CountChanged"/> event
    /// to receive notifications whenever the current <see cref="Count"/> value has changed in response
    /// to a counter operation.
    /// </summary>
    public interface ICounter
    {
        /// <summary>
        /// This event is fired whenever the <see cref="Count"/> property has been
        /// changed by using one of the following methods:
        /// <list type="bullet">
        /// <see cref="Increment"/>
        /// <see cref="Decrement"/>
        /// <see cref="Reset"/>
        /// </list>
        /// </summary>
        event CountChangedEventHandler CountChanged;

        /// <summary>
        /// Gets the current count value.
        /// </summary>
        int Count { get; set; }

        /// <summary>
        /// Increments the <see cref="Count"/> value by 1.
        /// </summary>
        void Increment();

        /// <summary>
        /// Decrements the <see cref="Count"/> value by 1.
        /// </summary>
        void Decrement();

        /// <summary>
        /// Resets the <see cref="Count"/> value to 0.
        /// </summary>
        void Reset();
    }
}
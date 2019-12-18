// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Framework.Bindables
{
    /// <summary>
    /// An event fired when a <see cref="Bindable{T}.Default"/> changes.
    /// </summary>
    /// <typeparam name="T">The type of bindable.</typeparam>
    public class DefaultChangedEvent<T>
    {
        /// <summary>
        /// The old value.
        /// </summary>
        public readonly T OldValue;

        /// <summary>
        /// The new (and current) value.
        /// </summary>
        public readonly T NewValue;

        public DefaultChangedEvent(T oldValue, T newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}

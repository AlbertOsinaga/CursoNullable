using System;

namespace Nullable
{
    public struct MiNullable<T> where T : struct
    {
        private readonly T value;
        private readonly bool hasValue;
        public MiNullable(T value)
        {
            this.value = value;
            this.hasValue = true;
        }
        public bool HasValue { get { return hasValue; } }
        public T Value
        {
            get
            {
                if(!hasValue)
                {
                    throw new InvalidOperationException();
                }
                return value;
            }
        }
    }

}

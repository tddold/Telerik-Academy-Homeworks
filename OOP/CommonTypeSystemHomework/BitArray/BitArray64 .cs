namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>, IEnumerator<int>
    {
        private const int BitArrayCapacity = 64;
        private ulong bitArray;
        private int position = -1;

        public BitArray64(ulong number = 0)
        {
            this.BitArray = number;
        }

        public ulong BitArray
        {
            get
            {
                return this.bitArray;
            }

            set
            {
                this.bitArray = value;
            }
        }

        public int Current
        {
            get
            {
                return this.GetBitOnCurrentPosition(this.position);
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.GetBitOnCurrentPosition(this.position);
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= BitArrayCapacity)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.GetBitOnCurrentPosition(index);
            }

            set
            {
                if (index < 0 || index >= BitArrayCapacity)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException();
                }

                this.SetBitOnCurrentPosition(index, value);
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < BitArrayCapacity; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Dispose()
        {
            this.Reset();
        }

        public bool MoveNext()
        {
            this.position++;

            return this.position < BitArrayCapacity;
        }

        public void Reset()
        {
            this.position = -1;
        }

        public override bool Equals(object obj)
        {
            var currentValue = obj as BitArray64;

            if ((object)currentValue == null)
            {
                return false;
            }

            return this.BitArray == currentValue.BitArray;
        }

        public override int GetHashCode()
        {
            return this.BitArray.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder bitArrayToString = new StringBuilder();

            for (int i = BitArrayCapacity - 1; i >= 0; i--)
            {
                bitArrayToString.Append(this[i]);
            }

            return bitArrayToString.ToString();
        }

        private int GetBitOnCurrentPosition(int index)
        {
            ulong mask = ((ulong)1) << index;
            ulong bitOnCurrentPosition = (this.BitArray & mask) >> index;

            return (int)bitOnCurrentPosition;
        }

        private void SetBitOnCurrentPosition(int index, int bitValue)
        {
            ulong mask = ((ulong)1) << index;

            if (bitValue == 1)
            {
                this.BitArray = this.BitArray | mask;
            }
            else
            {
                mask = ~mask;
                this.BitArray = this.BitArray & mask;
            }
        }
    }
}

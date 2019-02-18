using System;

namespace PROFINET_STEP_7
{
    internal class BitArray
    {
        internal int Length;
        private int[] v;
        private int v1;

        public BitArray(int v1)
        {
            this.v1 = v1;
        }

        public BitArray(int[] v)
        {
            this.v = v;
        }

    }
}
using System;

namespace Alberto.Models
{
    internal class StringLenghtAttribute : Attribute
    {
        private int v;

        public StringLenghtAttribute(int v, int MinimumLength)
        {
            this.v = v;
            this.MinimumLength = MinimumLength;
        }

        public int MinimumLength { get; set; }
    }
}
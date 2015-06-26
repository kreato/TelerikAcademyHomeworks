namespace RangeExceptions
{
    using System;
    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string msg, T start, T end)
            : base(msg)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start 
        { 
            get 
            { 
                return this.start; 
            } 
            private set
            { 
                this.start = value; 
            } 
        }

        public T End
        {
            get
            {
                return this.end;
            }
            private set
            {
                this.end = value;
            }
        }
    }
}

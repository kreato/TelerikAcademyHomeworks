namespace StringBuilderSubstring
{
    using System;
    public static class StringBuilder
    {
        public static System.Text.StringBuilder Substring(this System.Text.StringBuilder sb, int index, int length)
        {
            if (index < 0 || index > sb.Length)
            {
                throw new IndexOutOfRangeException("The given index is out of range");
            }
            if (length < 0 || index > sb.Length - length)
            {
                throw new ArgumentOutOfRangeException("Not a valid length");
            }
            if (length == 0)
            {
                return sb.Clear();
            }
            if (index == 0 && length == sb.Length)
            {
                return sb;
            }
            return new System.Text.StringBuilder(sb.ToString().Substring(index, length));
        }
    }
}
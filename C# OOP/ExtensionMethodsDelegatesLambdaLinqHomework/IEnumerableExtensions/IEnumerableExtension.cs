namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public static class IEnumerableExtension
    {
        public static T Min<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            T min = elements.ElementAtOrDefault(0);
            foreach (var item in elements)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static dynamic Max<T>(this IEnumerable<T> elements) where T : IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            T max = elements.ElementAtOrDefault(0);
            foreach (var item in elements)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static dynamic Sum<T>(this IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            dynamic sum = default(T);
            foreach (var item in elements)
            {
                sum += item;
            }
            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            dynamic product = 1;
            foreach (var item in elements)
            {
                product *= item;
            }
            return product;
        }

        public static dynamic Average<T>(this IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            dynamic sum = default(T);
            int counter = 0;
            foreach (var item in elements)
            {
                sum += item;
                counter++;
            }
            return sum / counter;
        }
    }
}
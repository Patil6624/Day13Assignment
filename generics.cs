using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13PracticeProblem
{
    public class GenericMax<T> where T : IComparable
    {
        public T first, second, third;

        public GenericMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static int Maxnum(int first, int second, int third)
        {

            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) >= 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) >= 0)
            {
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) >= 0 && second.CompareTo(third) > 0 ||
                second.CompareTo(first) > 0 && second.CompareTo(third) >= 0)
            {
                return second;
            }

            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) >= 0 && third.CompareTo(second) > 0 ||
                third.CompareTo(first) > 0 && third.CompareTo(second) >= 0)
            {
                return third;
            }

            return first;

        }


    }

}
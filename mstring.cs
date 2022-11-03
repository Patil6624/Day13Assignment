﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13PracticeProblem
{
    public class maxstring<T> where T : IComparable
    {

        public T first, second, third;

        public maxstring(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }

        public static string Maxnum(string first, string second, string third)
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
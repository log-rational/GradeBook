﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0.0;
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };

            foreach (var grade in grades)
            {
                result += grade;
            }
            result /= grades.Count;

        }
    }
}

﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
namespace HackerRankSolution.Search
{
    class Pairs
    {
        static int pairs(int k, int[] arr)
        {
            Array.Sort(arr);
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] - arr[i] > k)
                    {
                        break;
                    }
                    else if (arr[j] - arr[i] == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    string[] nk = Console.ReadLine().Split(' ');

        //    int n = Convert.ToInt32(nk[0]);

        //    int k = Convert.ToInt32(nk[1]);

        //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        //    ;
        //    int result = pairs(k, arr);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}

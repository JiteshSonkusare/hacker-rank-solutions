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

namespace HackerRankSolution
{
    class SockMerchant
    {
        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;
            List<int> countList = new List<int>();

            countList  = ar.GroupBy(i => i).Select(x=>x.Count()).ToList();
            count = countList.Select(x => x / 2).Sum(x => x);

            return count;
        }

        //static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        //    ;
        //    int result = sockMerchant(n, ar);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}

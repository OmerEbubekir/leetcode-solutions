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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        arr.Sort();
        long positive=0;
        long negative=0;
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i]>0)
            {
                positive++;
            }
            else if (arr[i]<0)
            {
                negative++;
            }
        }
        System.Console.WriteLine((positive / (double)arr.Count).ToString("F6"));
        System.Console.WriteLine((negative / (double)arr.Count).ToString("F6"));
        System.Console.WriteLine(((arr.Count-(positive+negative)) / (double)arr.Count).ToString("F6"));
   
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

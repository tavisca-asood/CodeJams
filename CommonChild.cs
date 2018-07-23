using System.CodeDom.Compiler;
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

class Solution {

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2) {
    int l1=s1.Length;
    int l2=s2.Length;
    int[ , ] large= new int[l1+1,l2+1];
        for(int i=0;i<l1+1;i++)
            large[i,0]=0;
        for(int i=0;i<l1+1;i++)
            large[0,i]=0;
   for (int i=1; i<=l1; i++)
   {
     for (int j=1; j<=l2; j++)
     {
       if (s1[i-1] == s2[j-1])
         large[i,j] = large[i-1,j-1] + 1;
  
       else
         large[i,j] = large[i-1,j]>large[i,j-1]?large[i-1,j]:large[i,j-1];
     }
   }
   return large[l1,l2];
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = commonChild(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

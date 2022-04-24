using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassWork_21._04._2022.Models
{
     static class Extencion
    {
        public static bool isEven(this int a)
        {
            return a % 2 == 0;
        }
        public static int[] GetValueIndexes(this int[] Arr,int[] Arresult, int Num)
        {
            
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == Num)
                {

                    int IndexArr = Array.IndexOf(Arr, Num,i);
                    Array.Resize(ref Arresult, Arresult.Length + 1);
                    Arresult[Arresult.Length - 1] = IndexArr;
                  
                }
            }
            return Arresult;

        }
        public static bool IsContainsDigit(this string Str)
        {
            bool check = false; 

            foreach (char item in Str)
            {

                if (char.IsDigit(item))
                {
                    check = true;
                }
            }
                return check;
        }
        public static int [] GetValueIndexes(this string Name,  int [] arr, char symbol)
        {
            
            for (int i = 0; i < Name.Length; i++)
            {
                if(symbol == i)
                {
                    int NameIndex = Name.IndexOf(symbol,i);
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = NameIndex;
                   
                }

            }

            return arr;
        } 
        public static bool IsOdd(this int test)
        {
            return test % 2 != 0;


           
        }






    }
}

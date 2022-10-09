// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;

//Question 1 Attempt:

namespace BIO_Question1
{
    class Program
    {   
        static int IISBN(string ISBN)
        {
            int Total = 0;int Counter = 0;int Output = 0;int index = 0;var ISBN_LIST = ISBN.ToList();
 
            foreach (char number in ISBN_LIST)
            {   
                if (number == '?')
                {
                    index = ISBN_LIST.IndexOf(number);
                }
                else if (number == 'X')
                {
                    Total = Total + 10 * (10 - Counter);
                }
                else
                {
                    Total = Total + (Convert.ToInt32(number)-48)*(10-Counter);
                }
                Counter++;
                
            }
            while ((Total + (Output * (10 - index))) % 11 != 0)
            {
                Output++;
            }

            
            return Output;
            
            
        }

//Question 3 Attempt
        static List<char> SwapChars(List<char> input ,int index1, int index2)
        {
            char temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
            return input;
        }

        static List<string> SwappedISBN(string ISBN)
        {   
           List<string> output = new List<string>();
           var ISBN_LIST = ISBN.ToList();
            for (int i = 0; i < ISBN_LIST.Count; i++)
            {
                for (int s = 0; s < ISBN_LIST.Count; s++)
                {
                    ISBN_LIST = ISBN.ToList();
                    var swapped_ISBN = String.Join("", SwapChars(ISBN_LIST, i, s));
                    if (IISBN(swapped_ISBN) == 0)
                    {
                        output.Add(swapped_ISBN);
                    }
                }
                    
            }

            
           return output.Distinct().ToList();
            
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(IISBN("4201014525"));
            foreach (string ISBN in SwappedISBN("3201014525"))
            {
                Console.WriteLine(ISBN);
            }
        }
    }
}

//Question 2:
// 0972311900 and 013674409X are invalid
// 3540678654 and 9514451570 are valid

//Question 3:
// I have written a code that takes any ISBN code and outputs all the possible original code. Below are the results of running the code.
// 2301014525
// 0201314525
// 3401012525
// 3200114525




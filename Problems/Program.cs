using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        String Prefix(string input)
        {
            bool whitespace = false;
            int wordcount = 0;
            int charcount = 0;
            int iLength = input.Length;
            while(charcount < iLength)
            {   
                if((charcount == 0) && (input[charcount] != ' '))
                {
                    charcount++;
                    wordcount++;
                }
                if(whitespace == true)
                {
                    if(input[charcount] == ' ')
                    {
                        charcount++;
                    }
                    else
                    {
                        wordcount++;
                        charcount++;
                        whitespace = false;
                    }
                }
                else
                {
                    if(input[charcount] == ' ')
                    {
                        whitespace = true;
                    }
                    charcount++;
                }
                
            }
            return (charcount.ToString() + "," + wordcount.ToString() + ":" + input);
        }
    }
}

using System;
using System.Text;

namespace MM_logo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                throw new InvalidOperationException("The entered numbur must be odd!");
            }
            if(number<3 || number > 10000)
            {
                throw new InvalidOperationException("The entered numbur must be between 2 and 10000");
            }
           
            int height = (number+1)/2;


            int outerDashes = number;
            int stars = number;
            int midDashes = number;

            char star = '*';
            char dash = '-';

            //upper Part
            for (int h = 1; h <=height; h++)
            {
                for (int i = 0; i <2; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(returnSymbols(dash, outerDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, midDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, outerDashes));

                        
                        stars += 2;
                        midDashes -= 2;
                        outerDashes--;
                        Console.WriteLine();
                    }
                    else if (i == 0)
                    {
                        Console.Write(returnSymbols(dash, outerDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, midDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, outerDashes));
                    }


                }

            }
            //lower part
            stars = number;
            int innerStars = (number*2)-1;
            int innerDashes = 1;

            for (int h = 1; h <= height; h++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 1)
                    {
                        Console.Write(returnSymbols(dash, outerDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, innerDashes));
                        Console.Write(returnSymbols(star, innerStars));
                        Console.Write(returnSymbols(dash, innerDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, outerDashes));

                        outerDashes--;
                        innerDashes += 2;
                        innerStars -= 2;

                        Console.WriteLine();
                    }
                    else if (i == 0)
                    {
                        Console.Write(returnSymbols(dash, outerDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, innerDashes));
                        Console.Write(returnSymbols(star, innerStars));
                        Console.Write(returnSymbols(dash, innerDashes));
                        Console.Write(returnSymbols(star, stars));
                        Console.Write(returnSymbols(dash, outerDashes));
                    }


                }

            }

        }


        public static string returnSymbols(char symbol , int num)
        {
            if (num <= 0)
            {
                return "";
            }
            var sb = new StringBuilder(num);
            for (int i = 0; i < num; i++)
            {
                sb.Append(symbol);
            }
            return sb.ToString();
        }
    }
}

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            /*
            int n = 5;
            for(int i = 0;i < n;i++)
            {
                for(int x = 0;x < n;x++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
            
            //answer 2
            int n1 = 0;
            for(int i = 5; i > n1;i--)
            {
                for(int x = 5;x > n1;x--)
                {
                    Console.Write(i % 2);
                }
                Console.WriteLine();
            }
            //answer 3
            int n2 = 5;
            for(int i = 0;i < 5; i++)
            {
                for(int x = 0;x < 5;x++)
                {
                    Console.Write(x % 2);
                }
                Console.WriteLine();
            }
            //answer 4
            int n3 = 3;
            Console.WriteLine("11111");
            for(int i = 1;i <= n3;i++)
            {
                for(int x = 1;x <= 5;x++)
                {
                    if (x == 1 || x == 5)
                        Console.Write(x % 2);
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine("11111");
            
            //answer 5
            int n4 = 5;
            for(int i = 1;i <= n4; i++)
            {
                if (i % 2 == 1) 
                {
                    for (int x = 1; x <= n4; x++)
                        Console.Write(x % 2);
                }
                else
                {
                    for (int x = 0; x < n4; x++)
                        Console.Write(x % 2);
                }
                Console.WriteLine();
            }
            //answer 6
            int n5 = 5;
            for (int i = 1;i <= n5;i++)
            {
                for(int x = 1;x <= 5;x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //answer 7
            int n6 = 5;
            for(int i = 0;i <= n6; i++)
            {
                for(int x = 1;x <= n6;x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }*/

            //answer 8
            /*
            int n7 = 5;
            int x = 1;
            for (int i = 1; i <= n7; i++)
            {
                Console.Write(i);
                x++;
                for (int m = x; m < x+4; m++)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }
            //answer 9
            int n8 = 5;
            int m = 0;
            for(int i = 1;i <= 21;i = i+n8)
            {
                Console.Write(i);
                m = i + 1;
                for(int x = m;x < m + 4;x++)
                {
                    Console.Write($" {x} ");
                }
                Console.WriteLine();
            }

            //answer 10
            int m = 1;
            for(int i = 1;i <= 5; i++)
            {
                Console.Write(i);
                m++;
                for(int x = 1;x < i;x++)
                {
                    //int a = i--;
                    //Console.Write(i);
                    Console.Write(m);
                }
                Console.WriteLine();
            }

            //answer 12
            for (int i = 1; i <= 5; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //answer 13
            for (int i = 5; i >= 1; i--)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //answer 14
            for (int i = 1; i <= 5 ; i++)
            {
                for (int x = 5; x >= i; x--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //answer 15
            for (int i = 5; i >= 1; i--)
            {
                for (int x = 6; x > i; x--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            //answer 16
            int m = 0;
            for(int i = 1;i <= 5;i++)
            {
                m++;
                for(int x = 1;x <= m;x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }

            //answer 17
            int m = 6;
            for (int i = 1; i <= 5; i++)
            {
                m--;
                for (int x = 1; x <= m; x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }*/

            //answer 18
            int m = 1;
            for(int i = 1;i <= 5; i++)
            {
                Console.Write(i);
                m++;
                for(int x = 1;x < i;x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            /*
            //answer 21
            int m = 6;
            for (int i = 1; i <= 5; i++)
            {
                m--;
                for (int x = 5; x >= m; x--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            //answer 22
            int m = 0;
            for (int i = 1; i <= 5; i++)
            {
                m++;
                for (int x = 5; x >= m; x--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
            
         //answer 23
         int n22 = 5;
         int x = 1;
         for (int i = 1; i <= n7; i++)
         {
             Console.Write(i);
             x++;
             for (int m = x; m <= n7; m++)
             {
                 Console.Write(m);
              }
              Console.WriteLine();
          }*/

            Console.ReadLine();
        }
    }
}

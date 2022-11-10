using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //answer 1
            for(int i = 0;i < 5;i++)
            {
                for(int x = 0;x < 5;x++)
                {
                    Console.Write("1");
                }
                Console.WriteLine();
            }
            
            //answer 2
            for(int i = 5; i > 0;i--)
            {
                for(int x = 5;x > 0;x--)
                {
                    Console.Write(i % 2);
                }
                Console.WriteLine();
            }
            //answer 3
            for(int i = 0;i < 5; i++)
            {
                for(int x = 0;x < 5;x++)
                {
                    Console.Write(x % 2);
                }
                Console.WriteLine();
            }
            //answer 4
            for (int i = 0; i < 5; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (i == 0|| x == 0|| i == n3-1 || x == n3-1)
                        Console.Write(1);
                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
            
            //answer 5
            for(int i = 1;i <= 5; i++)
            {
                if (i % 2 == 1) 
                {
                    for (int x = 1; x <= 5; x++)
                        Console.Write(x % 2);
                }
                else
                {
                    for (int x = 0; x < 5; x++)
                        Console.Write(x % 2);
                }
                Console.WriteLine();
            }
            //answer 6
            for (int i = 1;i <= 5;i++)
            {
                for(int x = 1;x <= 5;x++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            //answer 7
            for(int i = 0;i <= 5; i++)
            {
                for(int x = 1;x <= 5;x++)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }

            //answer 8
            int x = 1;
            for (int i = 1; i <= 5; i++)
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
            int m = 0;
            for(int i = 1;i <= 21;i = i+5)
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
            for(int i = 5;i >= 1;i--)
            {
                for(int x = 5; x >= 1;x--)
                {
                    if (i >= x)
                        Console.Write(i);
                    else
                        Console.Write(x);
                }
                Console.WriteLine();
            }

            //answer 11
            int x = 1;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(i);
                x++;
                for (int m = x; m < x + 4; m++)
                {
                    if (m >= 5)
                        Console.Write(5);
                    else
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
            }

            //answer 18
            int m = 0;
            for(int i = 1;i <= 5;i++)
            {
                m = i;
                for(int x = 1;x <= i; x++)
                {
                    Console.Write(m);
                    m--;
                }
                Console.WriteLine();
            }
            //answer 19
            int m = 0;
            for(int i = 5;i >= 1;i--)
            {
                m = i;
                for(int x = 1;x <= i; x++)
                {
                    Console.Write(m);
                    m--;
                }
                Console.WriteLine();
            }
                
            //answer 20
            for (int i = 5; i >= 1; i--)
            {
                for (int x = 5; x >= i; x--)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }

            //answer 21
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
            
            //answer 22
            int a;
            for (int i = 5; i >= 1; i--)
            {
                a = i;
                for (int m = 5; m >= i; m--)
                {
                    if (i == m)
                        Console.Write(5);
                    else
                        Console.Write(a);

                    a++;
                }
                Console.WriteLine();
            }
            
         //answer 23
            int a;
            for (int i = 1; i <= 5; i++)
            {
                a = i;
                for (int m = 5; m >= i; m--)
                {
                    Console.Write(a);
                    a++;
                }
                 Console.WriteLine();
            }
            
            //answer 24
            int a;
            for(int i = 1;i <= 5;i++)
            {
                a = i;
                for(int x = 1;x <= i;x++)
                {
                    Console.Write(a);
                    a++;
                }
                Console.WriteLine();
            }
            
            //answer 25
            int a;
            for(int i = 5;i >= 1;i--)
            {
                a = i;
                for(int x = 1;x <= i;x++)
                {
                    Console.Write(a);
                    a++;
                }
                Console.WriteLine();
            }
            
            //answer 26
            int a = 1;
            for(int i = 5;i >= 1;i--)
            {
                for(int x = a;x <= 9;x++)
                {
                    if (x % 2 == 1)
                    {
                        Console.Write(x);
                    }
                }
                a += 2;
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

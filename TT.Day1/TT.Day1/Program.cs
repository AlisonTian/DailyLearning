using System;

namespace TT.Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //a = a + 1;
            //int c = 3;
            //string b = "田甜天下第一程序猿";
            //int d = a * c;
            //float e = 1.5f;
            //decimal u = (decimal)3.6;
            //DateTime currentTime = DateTime.Now;
            //Console.WriteLine(u * c);
            ////Console.WriteLine(b);
            //bool result = true;
            //int chu = c / 1;
            //int yu = c % 1;
            //Console.WriteLine(currentTime);
            //Console.WriteLine(chu);
            //Console.WriteLine(yu);

            //bool isTrue = true;
            //int a = 8;

            //if (a > 10)
            //{
            //    Console.WriteLine("是");
            //}
            //else if (a > 5 && a < 10)
            //{
            //    Console.WriteLine("5");
            //}
            //else if (a > 3 && a < 5)
            //{

            //}


            //while (a > 0)
            //{
            //    Console.WriteLine(a);
            //    a--; //a = a - 1;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(SumOfFiveDay(0));
            //Console.WriteLine(SumOf100());
            一到100();
            Console.ReadKey();
        }

        public static int SumOfFiveDay(int a)
        {
            int result;
            result = 5 * a + 10;
            result = a + a + 1 + a + 2 + a + 3 + a + 4;

            //for (int i=a+1;i<99;i++)
            //{
            //    Console.WriteLine(i);
            //}
            return result;
        }

        public static int SumOf100()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        public static int 从1加到5()
        {
            // 0
            // 第一遍: 0 + 1 = 1
            // 第二遍: 1 + 2 = 3
            // 第三遍: 3 + 3 = 6
            // 第四遍: 6 + 4 = 10
            // 第五遍: 10+ 5 = 15

            int result = 0;
            for (int i = 1; i <= 5; i++)
            {
                int num = i;
                result = result + num;
            }
            return result;
        }

        public static double 算100五年一共还多少钱()
        {
            // 0
            // 第一遍: 0 + 1 = 1
            // 第二遍: 1 + 2 = 3
            // 第三遍: 3 + 3 = 6
            // 第四遍: 6 + 4 = 10
            // 第五遍: 10+ 5 = 15
            int ori = 100;
            double rate = (double)0.01;

            double result = 0;
            for (int i = 1; i <= 5; i++)
            {
                result = result * (1 + 0.01);
            }
            return result;
        }

        public static void 数数字(int time)
        {
            Console.WriteLine(time);
        }

        public static void 数到5If()
        {
            int time = 1;
            数五以下的(time);
            time = time + 1;

            数五以下的(time);
            time = time + 1;

            数五以下的(time);
            time = time + 1;

            数五以下的(time);
            time = time + 1;

            数五以下的(time);
            time = time + 1;
            数五以下的(time);
            time = time + 1;
            数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1; 数五以下的(time);
            time = time + 1;
        }

        public static int 数五以下的(int time)
        {
            if (time <= 5)
            {
                Console.WriteLine(time);
            }
            return time;
        }


        public static void 一到100()
        {
            //   Console.WriteLine("T"); 能整除3
            //   Console.WriteLine("F"); 能整除5
            //   Console.WriteLine("TF"); 既能整除3又能整除5
            //int a = 5 % 3;

            for (int i = 1; i <= 100; i++)
            {
                int a = i % 3; int b = i % 5;
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("TF");
                }
                if (a == 0 && b > 0)
                {
                    Console.WriteLine("T");
                }
                if (a > 0 && b == 0)
                {
                    Console.WriteLine("F");
                }
                if (a > 0 && b > 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("TF");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("T");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
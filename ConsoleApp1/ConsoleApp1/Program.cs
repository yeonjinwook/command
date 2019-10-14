using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //두 수를 입력
            int a, b;
            Console.WriteLine("첫 번째 수:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 수:");
            b = int.Parse(Console.ReadLine());
            //큰 수와 작은 수를 판별
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int sum = 0;
            for (int i = a; i <= b; i++)//반복( i를 작은수에서 큰 수까지 순차적 증가)
            {
                if ((i % 5) == 0)
                {
                    sum = sum + i;//합계에 i를 더한다.

                }

            }
            Console.WriteLine(sum);
        }
    }
}
    

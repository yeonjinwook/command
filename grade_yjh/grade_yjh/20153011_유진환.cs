 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_yjh
{
    class Program
    {
        static void Main(string[] args)
        {
            int score, average=0, i=0, sum=0;
            char grade;
            string answer;

            first:

            Console.Write("점수를 입력해주세요. : ");
            score = int.Parse(Console.ReadLine());
            if (score > 100 || score < 0)
            {
                Console.Write("잘못된 입력입니다.\n");
                goto first;
            }

            switch (average)
            {
                case 10:
                    grade = 'A';
                    break;
                case 9:
                    grade = 'A';
                    break;
                case 8:
                    grade = 'B';
                    break;
                case 7:
                    grade = 'C';
                    break;
                case 6:
                    grade = 'D';
                    break;
                default:
                    grade = 'F';
                    break;
            }

            Console.WriteLine("당신의 학점은 {0}입니다.", grade);

            Console.Write("계속 하시겠습니까?\ny/n\n");
            answer = Console.ReadLine();
            if(answer == "y")
            {
                goto first;
            }
            else
            {
                return;
            }

           

        }
    }
}

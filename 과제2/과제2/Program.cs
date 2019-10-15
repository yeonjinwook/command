using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제1
{
    class Program
    {

        static void Main(string[] args)
        {
            int scorea, scoreb, scorec, total;
            double average;
            char grade;
            string yn = "y";

        first:

            while (true)
            {
            
                Console.Write("첫번째 과목 점수 : ");
                scorea = int.Parse(Console.ReadLine());
                if (scorea < 0 || scorea > 100)
                {
                    Console.WriteLine("잘못된 값을 넣었습니다.");
                    goto first;//반복문을 리셋하세요(반복문의 처음 위치로 이동)
                }

            
            second: 
                
                Console.Write("두번째 과목 점수 : ");
                scoreb = int.Parse(Console.ReadLine());

                if (scoreb < 0 || scoreb > 100)
                {
                    Console.WriteLine("잘못된 값을 넣었습니다.");
                    goto second;//지정된 label statement로 이동
                }

                third:

                Console.Write("세번째 과목 점수 : ");
                scorec = int.Parse(Console.ReadLine());

                if (scorec < 0 || scorec > 100)
                {
                    Console.WriteLine("잘못된 값을 넣었습니다.");
                    goto third;//지정된 label statement로 이동
                }



                total = scorea + scoreb + scorec;
                average = (double)total / 3;

                switch ((int)average / 10)
                {
                    case 10:

                    case 9:
                        grade = 'A'; break;
                    case 8:
                        grade = 'B'; break;
                    case 7:
                        grade = 'C'; break;
                    case 6:
                        grade = 'D'; break;
                    default:
                        grade = 'F'; break;
                }
                Console.WriteLine(
                     "총점수 : {0}\n평균 : {1}\n학점 : {2}", total, average, grade);
                Console.Write("더 하시겠습니까 (y / n) ? ");
                yn = Console.ReadLine();
                if (!yn.Equals("y", StringComparison.OrdinalIgnoreCase))
                    break;//반복문을 즉시 종료하세요
            }

        }
    }
}

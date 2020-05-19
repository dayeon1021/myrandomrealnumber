using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int ran = r.Next(1, 100);
            int num = 0;

            while(num != ran)
            {
                Console.Write("숫자를 입력해주세요 : ");
                num = int.Parse(Console.ReadLine());
                if (num == ran)
                {
                    break;
                }
                else if (num > ran)
                {
                    Console.WriteLine("\n" + num + "보다는 작은 숫자입니다.");
                }
                else if( num < ran)
                {
                    Console.WriteLine("\n" + num + "보다는 큰 숫자입니다.");
                }
            }

            Console.WriteLine("정답입니다!");

        }
    }
}

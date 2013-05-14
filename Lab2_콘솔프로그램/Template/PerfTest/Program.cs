using System;
using System.Diagnostics;
using System.Threading;

namespace PerfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // 스톱워치 객체 생성 (Stopwatch)            

            // 스톱워치 측정 시작            

            // 본 작업 실행
            Console.WriteLine("Task Running...");
            int result = Calc();

            // 스톱워치 측정 중지            

            // 결과 출력
            Console.WriteLine("Result: {0}", result);            

            // 측정시간 출력
            // Console.WriteLine(...);
        }

        static int Calc()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
                Thread.Sleep(100);                
            }
            return sum;
        }
    }
}

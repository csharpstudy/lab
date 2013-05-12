using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileProcessingConsoleApp
{
    class Program
    {
        /// <summary>
        /// 실행예 : FileProcessingConsoleApp.EXE input.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // 입력 아큐먼드 처리
            if (args.Length != 1)
            {
                throw new ArgumentException();
            }
            string input = args[0];

            int sum = 0;
            int count = 0;
            int avg;

            // TODO: 입력파일이 존재하는지 체크
            

            // TODO: 입력 파일을 한 라인씩 읽어
            //       합계 및 학생수를 계산


            // TODO: 합계 및 평균을 계산 출력한다.

            Console.WriteLine("합계: {0}", sum);
            Console.WriteLine("평균: {0}", avg);
        }
    }
}

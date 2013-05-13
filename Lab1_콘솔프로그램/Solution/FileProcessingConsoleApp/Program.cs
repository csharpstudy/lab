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
        /// 실행예 : C> FileProcessingConsoleApp.EXE input.txt
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
            double avg;

            // 입력파일이 존재하는지 체크
            if (!File.Exists(input))
            {                
                throw new FileNotFoundException("파일명 " + input + "이 존재하지 않습니다");
            }

            // 입력 파일을 한 라인씩 읽어
            // 합계 및 학생수를 계산
            // 입력데이타 예 : 1, 100
            using (StreamReader reader = new StreamReader(input))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(',');
                    string id = data[0];
                    int score = int.Parse(data[1]);
                    sum += score;
                    count++;
                }
            }
            avg = (double)sum / (double)count;

            // TODO: 합계 및 평균을 계산 출력한다.

            Console.WriteLine("합계: {0}", sum);
            Console.WriteLine("평균: {0}", avg);
        }
    }
}

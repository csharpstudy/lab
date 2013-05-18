using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileRW
{
    class Program
    {
        //
        // 실행방식:  C> FileRW.exe input.txt output.txt
        //
        static void Main(string[] args)
        {
            // 입력 아규먼트 처리
            if (args.Length != 2)
            {
                throw new ArgumentException();
            }

            // 입출력 파일명 아규먼트에서 구함
            string input = args[0];
            string output = args[1];

            // 입력파일이 존재하는지 체크
            if (!File.Exists(input))
            {
                throw new FileNotFoundException("파일명 " + input + "이 존재하지 않습니다");
            }

            // 입출력 Stream 객체 생성
            using (var reader = new StreamReader(input))
            using (var writer = new StreamWriter(output))
            {
                // 입력파일 마지막 체크
                while (reader.Peek() != -1)
                {
                    // 입력파일 행 읽기
                    string line = reader.ReadLine();

                    // 섭씨 입력 데이타
                    double degreeC = double.Parse(line);

                    // 화씨로 변환
                    double degreeF = DegreeConverter.CelsiusToFahrenheit(degreeC);

                    // 출력파일에 '섭씨,화씨' 형식으로 출력
                    writer.WriteLine("{0},{1}", degreeC, degreeF);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace FileCompress
{
    class Program
    {
        //
        // 실행방식 : C> FileCompress.exe input.txt
        //
        static void Main(string[] args)
        {
            // 입력 아큐먼드 처리
            if (args.Length != 1)
            {
                throw new ArgumentException();
            }
            string input = args[0];
            string output = input + ".zip";

            // 입출력파일이 존재하는지 체크
            if (!File.Exists(input))
            {
                throw new FileNotFoundException("파일명 " + input + "이 존재하지 않습니다");
            }
            if (File.Exists(output))
            {
                throw new FileNotFoundException("파일명 " + output + "이 이미 존재합니다");
            }

            // 참조: C#의 using을 사용하여 자동 파일 닫기를 
            // 하는 것이 권장 사항이다. 

            // 츨력 .zip 파일 생성
            FileStream fsOutput = File.Create(output);

            // 압축 GZipStream 클래스 객체 생성
            var gzip = new GZipStream(fsOutput, CompressionMode.Compress);

            // 입력 파일 객체
            FileStream fsInput = File.OpenRead(input);

            // 파일 내용 읽으면서 압축
            for (int i = 0; i < fsInput.Length; i++)
            {
                byte val = (byte)fsInput.ReadByte();
                gzip.WriteByte(val);
            }

            // 파일 핸들 닫기
            fsInput.Close();
            gzip.Close();
            fsOutput.Close();
        }
    }
}

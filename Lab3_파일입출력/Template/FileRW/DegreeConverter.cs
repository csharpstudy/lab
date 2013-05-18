using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRW
{
    // 화씨를 섭씨로 변환하는 공식
    //    °C = 5⁄9 (°F – 32)    
    class DegreeConverter
    {
        public static double CelsiusToFahrenheit(double c)
        {
            double f = c * 9 / 5 + 32;
            return f;
        }

        public static double FahrenheitToCelsius(double f)
        {
            double c = 0;
            // 변환 연습
            
            return c;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_BMI
{
    internal class BMI
    {
        static void Main(string[] args)
        {
            double height, weight;
            string blank;

            Console.Write("키(cm) : ");
            height = double.Parse(Console.ReadLine());

            Console.Write("체중(kg) : ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height / 100 * height / 100);

            //Console.WriteLine("BMI = " +  bmi + "입니다.");
            Console.WriteLine("BMI = {0}입니다.", bmi);
            //문자열 + 숫자 => 문자열
            //문자열 + 문자열 => 문자열
            Console.WriteLine("아무키나 입력하세요");
            blank = Console.ReadLine();
        }
    }
}

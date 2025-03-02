﻿using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 놀이동산 입장권
            // 사용자로부터 나이, 군인 할인, 연관 회원 여부를 입력 받아서 입장 요금을 계산합니다.
            // 무료입장 조건
            // 1. 나이가 3세 이하
            // 2. 나이가 65세 이상
            // 3. 연간 회원

            // 할인 적용
            // 1. 군인일 경우 -> 30% 할인

            // 일반 요금
            // 성인(19~64세) : 10000원
            // 청소년(13~18세) : 8000원
            // 어린이(4~12세) : 5000원

            // 출력 예시
            // 나이를 입력 하세요 : 20
            // 군인인가요? (네/아니요) : 네
            // 연간 회원인가요? (네/아니요) : 아니요
            // 입장료는 7000원입니다.

            // 나이를 입력 하세요 : 20
            // 군인인가요? (네/아니요) : 네
            // 연간 회원인가요? (네/아니요) : 네
            // 무료입장입니다.
            int price = 10000; 
            Console.Write("나이를 입력하세요. : ");
            string ageInput = Console.ReadLine();
            int value = int.Parse(ageInput);
            Console.Write("군인인가요? (네/아니요) : ");
            string army = Console.ReadLine();
            Console.Write("연간 회원인가요? (네/아니요) : ");
            string vip = Console.ReadLine();

            if (value >= 4 && value <= 12)
            {
                price = 5000;
            }
            else if (value >= 13 && value <= 18)
            {
                price = 8000;
            }
            else if (value >= 19 && value <= 64)
            {
                price = 10000;
            }
            else
            {
                Console.WriteLine("무료입장입니다.");
            }
            Console.WriteLine(price);
        }
    }
}
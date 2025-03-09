using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 구구단
            // 2부터 9까지의 숫자 중 하나를 입력받아, 해당하는 구구단을 출력하세요

            // 출력 예시
            // 구구단을 출력할 숫자를 입력하세요 (2~9): 7
            // 구구단 7단:
            // 7 x 1 = 7
            // 7 x 2 = 14
            // 7 x 3 = 21
            // 7 x 4 = 28
            // 7 x 5 = 35
            // 7 x 6 = 42
            // 7 x 7 = 49
            // 7 x 8 = 56
            // 7 x 9 = 63

            /*
            Console.Write("구구단을 출력할 숫자를 입력하세요 (2~9): ");
            String input = Console.ReadLine();
            int inputValue = int.Parse(input);
            Console.WriteLine($"구구단 {inputValue}단: ");
            // 구구단 구현 로직
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{inputValue} x {i} = {inputValue * i}");
            }
            */

            // * 찍는 문제
            // 문제 1 : 왼쪽 정렬된 직각 삼각형
            /*
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i +1 ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            // 문제 1-1 : 왼쪽 정렬된 상하 반전의 직각 삼각형
            for (int i = 5; i > 0; i--)
           {
               for(int j = 0; j < i; j++)
               {
                   Console.Write("*");
               }
               Console.WriteLine(" ");
           }
            // 문제 2 : 오른쪽 정렬된 직각 삼각형

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5 -i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            // 문제 3 : 피라미드(중앙 정렬)
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i +1; k++)
                {
                    Console.Write("*");
                }
                for(int l = 5; l > 5 -i; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            // 문제 4 : 다이아몬드 
            for (int i = 0; i < 5; i+=2)
            {
                for (int j = 5; j > i; j-=2)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            for (int l = 3; l > 0; l-=2)
            {
                for (int m = 5; m >= l; m-=2)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n < l; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            */
            // 다이아몬드 심화
            Console.Write("숫자를 입력해주세요 (홀수): ");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < num; i += 2)
            {
                for (int j = num; j > i; j -= 2)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int l = num - 2; l > 0; l -= 2)
            {
                for (int m = num; m >= l; m -= 2)
                {
                    Console.Write(" ");
                }
                for (int n = 0; n < l; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
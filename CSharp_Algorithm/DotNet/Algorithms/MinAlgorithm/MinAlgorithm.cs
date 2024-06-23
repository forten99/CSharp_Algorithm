//[?]  주어진 데이터 중에서 가장 작은 [짝수] 값
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinAlgorithm
{
    static void Main()
    {
        //[1] Initialize
        int min = Int32.MaxValue; // 정수 형식의 데이터 중 가장 큰 값으로 초기화

        //[2] Input: 이진수로 표현 + 숫자 구분자
        //int[] numbers = { 2, 5, 3, 7, 1 };
        int[] numbers = { 0b0010, 0B_0101, 0b0011, 0B_0111, 0b0000_0001 };  

        //[3] Process : MIN
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min && numbers[i] % 2 == 0)
            {
                min = numbers[i];   // MIN : 더 작은 값으로 할당
            }
        }

        //[4] Output
        Console.WriteLine($"짝수 최솟값(식): {numbers.Where(n => n % 2 == 0).Min()}");
        Console.WriteLine($"짝수 최솟값(문): {min}");
    }
}

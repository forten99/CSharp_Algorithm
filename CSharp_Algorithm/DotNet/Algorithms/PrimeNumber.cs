﻿// [?] 특정 수를 입력받아서, 소수인지 아닌지 판별하는 프로그램
//  - 5는 소수: 1과 5만을 약수로 가짐
//  - 6은 소수가 아님: 1과 6만이 아닌 추가로 2와 3을 약수로 가짐
//  - 2부터 해당 수까지 나머지값을 구해서 나머지값이 0일 때 나눈 수가 해당 수라면 소수
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 소수(Prime Number): 자연수 중에서 1과 자기 자신만을 약수로 가지는 자연수
/// </summary>
class PrimeNumber
{
    static void Main(string[] args)
    {
        //[1] Input
        var number = 0;
        Console.Write("수 입력: _\b");
        number = Convert.ToInt32(Console.ReadLine());

        //[2] Process: Prime Number: 2부터 n까지 나누어 떨어지는 수가 발생할 때까지 반복
        var i = 1;
        do
        {
            i = i + 1;  // 2부터 n까지 비교
            Console.WriteLine($"{number} % {i} == {number % i}");
        } while (number % i != 0);

        //[3] Output
        if (number == i)
        {
            Console.WriteLine("소수임");
        }
        else
        {
            Console.WriteLine("소수 아님");
        }
    }
}

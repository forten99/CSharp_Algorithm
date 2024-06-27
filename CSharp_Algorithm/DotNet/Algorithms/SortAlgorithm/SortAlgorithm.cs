//[?] 무작위 데이터를 순서대로[오름차순|내림차순] 정렬
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 정렬 알고리즘(Sort Algorithm): 가장 [작은|큰] 데이터를 왼쪽으로 순서대로 이동
/// </summary>
class SortAlgorithm
{
    static void Main()
    {
        //[1] Input: Data Structure(Array, List, Stack, Queue, Tree, DB, ...)
        int[] data = { 3, 1, 2, 4, 5 };
        int N = data.Length;    // 의사코드(슈도코드) 형태로 알고리즘을 표현하기 위함

        //[2] Process: Selection Sort(선택 정렬) 알고리즘
        for (int i = 0; i < N - 1; i++) // i = 0 to N - 1
        {
            for (int j = i + 1; j < N; j++) // j = i + 1 to 
            {
                if (data[i] > data[j])  // 부등호 방향: 오름차순(>), 내림차순(<)
                {
                    // SWAP
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                }
            }
        }
        
        //[3] Output: Console, Desktop, Web, Mobile, ...
        for (int i = 0; i < N; i++)
        {
            Console.Write($"{data[i]}\t");
        }

        Console.WriteLine();
    }
}

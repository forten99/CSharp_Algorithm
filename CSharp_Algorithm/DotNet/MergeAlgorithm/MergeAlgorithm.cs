//[?] 2개의 정수 배열 합치기: 단, 2개의 배열은 오름차순으로 정렬되어 있다고 가정
using System;
using System.Linq;

/// <summary>
/// 병합 알고리즘(Algorithm): 오름차순으로 정렬되어 있는 정수 배열을 하나로 병합
/// </summary>
class MergeAlgorithm
{
    static void Main()
    {
        //[1] Input
        int[] first = { 1, 3, 5 };      // 오름차순 정렬됨
        int[] second = { 2, 4 };        // 오름차순 정렬됨
        int M = first.Length;           // M:N 관행
        int N = second.Length;
        int[] merge = new int[M + N];   // 병합된 배열 담을 그릇
        int i = 0;                      // i, j, k 관행
        int j = 0;
        int k = 0;

        //[2] Process: MERGE
        while (i < M && j < N)          // 둘 중 하나라도 배열의 끝에 도달할 때까지
        {
            if (first[i] <= second[j])  // 더 작은 값을 merge 배열에 저장
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }
        }
        while (i < M)  // 첫 번째 배열이 끝까지 도달할 때까지
        {
            merge[k++] = first[i++];
        }
        while (j < N)  // 두 번째 배열이 끝까지 도달할 때까지
        {
            merge[k++] = second[j++];
        }

        //[3] Output
        foreach (var m in merge)
        {
            Console.Write($"{m}\t");
        }
        Console.WriteLine();
    }
}

//int[] first = { 1, 3, 5 };
//int[] secod = { 2, 4 };
//int[] merge = (from o in first select o).Union(from t in secod select t).OrderBy(m => m).ToArray();

//int[] merge = first.Union(secod).OrderBy(m => m).ToArray();

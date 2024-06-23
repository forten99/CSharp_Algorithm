//[?] 최댓값과 최솟값을 제외한 나머지의 평균값을 구하는 프로그램
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

// 최댓값과 최솟값을 제외한 평균값 구하기
class AverageExceptMaxAndMin
{
    static void Main()
    {
        //[1] Input
        int[] scores = { 10, 20, 30, 40, 50 };  // 30
        var sum = 0;                            // SUM
        var max = Int32.MinValue;               // 해당 범위에서 가장 작은 값으로 초기화
        var min = Int32.MaxValue;               // 해당 범위에서 가장 큰 값으로 초기화
        var avg = 0.0;                          // AVERAGE

        //[2] Process
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];       // SUM
            if (scores[i] > max)
            {
                max = scores[i];    // MAX
            }
            if (scores[i] < min)
            {
                min = scores[i];    // MIN
            }
        }

        //[!] 최댓값과 최솟값을 제외한 평균값 구하기
        avg = (sum - max - min) / (double)(scores.Length - 2);

        //[3] Output
        Console.WriteLine($"합계: {sum}, 최댓값: {max}, 최솟값: {min}");
        Console.WriteLine($"최댓값과 최솟값을 제외한 평균값: {avg}");
        Console.WriteLine($"최댓값과 최솟값을 제외한 평균값(식): {scores.Where(n => n!= scores.Max() || n!= scores.Min()).Average()}");

    }
}

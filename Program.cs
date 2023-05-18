using System;

class Program
{
    static void Main(string[] args)
    {
        // อ่านข้อมูลจากอาร์กิวเมนต์
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        // อ่านจำนวนประชากรในถนนแต่ละช่วง
        int[] population = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // คำนวณจำนวนประชากรรวมสูงสุดที่เป็นไปได้
        int maxPopulation = GetMaxPopulation(population, N, K);

        // แสดงผลลัพธ์
        Console.WriteLine(maxPopulation);
    }

    static int GetMaxPopulation(int[] population, int N, int K)
    {
        int maxPopulation = 0;

        // หาผลรวมของประชากรในช่วงถนน K ช่วงแรก
        for (int i = 0; i < K; i++)
        {
            maxPopulation += population[i];
        }

        int currentPopulation = maxPopulation;

        // หาผลรวมของประชากรในช่วงถนนที่เกิน K ช่วง
        for (int i = K; i < N; i++)
        {
            currentPopulation = currentPopulation + population[i] - population[i - K];
            maxPopulation = Math.Max(maxPopulation, currentPopulation);
        }

        return maxPopulation;
    }
}






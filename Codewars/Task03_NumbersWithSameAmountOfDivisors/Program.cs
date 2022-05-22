/* The integers 14 and 15, are contiguous (1 the difference between them, obvious) and have the same number of divisors.

14 ----> 1, 2, 7, 14 (4 divisors)
15 ----> 1, 3, 5, 15 (4 divisors)
The next pair of contiguous integers with this property is 21 and 22.

21 -----> 1, 3, 7, 21 (4 divisors)
22 -----> 1, 2, 11, 22 (4 divisors)
We have 8 pairs of integers below 50 having this property, they are:

"[[2, 3], [14, 15], [21, 22], [26, 27], [33, 34], [34, 35], [38, 39], [44, 45]]"
Let's see now the integers that have a difference of 3 between them. There are seven pairs below 100:/* Let's name, diff, the difference between two integers, next and prev, (diff = next - prev) and nMax, an upper bound of the range.

We need a special function, count_pairsInt(), that receives two arguments, diff and nMax and outputs the amount of pairs of integers that fulfill this property, all of them being smaller (not smaller or equal) than nMax.

Let's see it more clearly with examples.

count_pairsInt(1, 50) -----> 8 (See case above)
count_pairsInt(3, 100) -----> 7 (See case above) */

void AllDivisors(long n)
{
    for (int j = 1; j * j <= n; j++)
    {
        if (n % j == 0)
        {
            System.Console.WriteLine(j);
            if (j != n / j) System.Console.WriteLine(n / j);
        }
    }
}

int CountPairsInt(int diff, long nMax)
{
    int[] arr = new int[nMax];
    for (int i = 1; i < nMax; i++)
    {
        int k = 0;
        for (int j = 1; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                k++;
                if (j != i / j) k++;

            }
        }
        arr[i] = k;
    }
    int count = 0;
    for (int i = 0; i < arr.Length-diff; i++)
    {
        if (arr[i] - arr[i+diff] == 0) count++;
    }
    return count;
}

var startTime = System.Diagnostics.Stopwatch.StartNew();

//AllDivisors(2);
System.Console.WriteLine(CountPairsInt(1, 50));
System.Console.WriteLine(CountPairsInt(3, 100));
System.Console.WriteLine(CountPairsInt(3, 200));
System.Console.WriteLine(CountPairsInt(6, 350));
System.Console.WriteLine(CountPairsInt(6, 1000));
System.Console.WriteLine(CountPairsInt(7, 1500));
System.Console.WriteLine(CountPairsInt(7, 3000));
System.Console.WriteLine(CountPairsInt(9, 4000));
System.Console.WriteLine(CountPairsInt(9, 5000));
System.Console.WriteLine(CountPairsInt(11, 5000));
startTime.Stop();
var resultTime = startTime.Elapsed;
// elapsedTime - строка, которая будет содержать значение затраченного времени
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
    resultTime.Hours,
    resultTime.Minutes,
    resultTime.Seconds,
    resultTime.Milliseconds);
System.Console.WriteLine(elapsedTime);
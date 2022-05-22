// Your task is to give the number of total values for the odd terms of the sequence up to the n-th term (included). (The number n (of n-th term) will be given as a positive integer)

long CountOddPentaFib(long n)
{
    long[] arr = new long[n + 1];
    if (n < 5) return 1;
    arr[0] = 0; arr[1] = 1; arr[2] = 1; arr[3] = 2; arr[4] = 4;
    int count = 1;
    for (int i = 5; i <= n; i++)
    {
        for (int j = i; j >= i-5 ; j--)
        {
            arr[i] += arr[j];
        }
        System.Console.WriteLine(arr[i]);
        if (arr[i] % 2 != 0) count++;
    }
    return count;
}

System.Console.WriteLine(CountOddPentaFib(15));
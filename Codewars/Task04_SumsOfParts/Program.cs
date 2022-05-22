/* ls = [0, 1, 3, 6, 10]
ls = [1, 3, 6, 10]
ls = [3, 6, 10]
ls = [6, 10]
ls = [10]
ls = []
The corresponding sums are (put together in a list): [20, 20, 19, 16, 10, 0]

The function parts_sums (or its variants in other languages) will take as parameter a list ls and return a list of the sums of its parts as defined above.

Other Examples:
ls = [1, 2, 3, 4, 5, 6] 
parts_sums(ls) -> [21, 20, 18, 15, 11, 6, 0]

ls = [744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358]
parts_sums(ls) -> [10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0] */

int[] PartsSums(int[] ls)
{
    int[] arr = new int[ls.Length+1];
    int sum = ls.Sum();
    arr[0] = sum;
    for (int i = 0; i < ls.Length; i++)
    {
        arr[i+1] = arr[i] - ls[i];
    }
    return arr;
}

//int[] ls = {1,2,3,4,5,6};
int[] ls = {744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358};

var startTime = System.Diagnostics.Stopwatch.StartNew();

int[] arr = PartsSums(ls);
System.Console.WriteLine(String.Join(",",arr));

startTime.Stop();
var resultTime = startTime.Elapsed;
// elapsedTime - строка, которая будет содержать значение затраченного времени
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
    resultTime.Hours,
    resultTime.Minutes,
    resultTime.Seconds,
    resultTime.Milliseconds);
System.Console.WriteLine(elapsedTime);

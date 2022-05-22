/* Bob is bored during his physics lessons so he's built himself a toy box to help pass the time. The box is special because it has the ability to change gravity.

There are some columns of toy cubes in the box arranged in a line. The i-th column contains a_i cubes. 
At first, the gravity in the box is pulling the cubes downwards. When Bob switches the gravity, 
it begins to pull all the cubes to a certain side of the box, d, which can be either 'L' or 'R' (left or right). 
Below is an example of what a box of cubes might look like before and after switching gravity.
*/

int[] Flip(char dir, int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }

    int[] arr2 = new int[arr.Length];
    for (int i = 0; i <= max; i++)
    {
        int count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] > i) count++;
        }

        for (int k = 0; k < count; k++)
        {
            if (dir == 'L') arr2[k] += 1;
            if (dir == 'R') arr2[arr.Length - k - 1] += 1;
        }
    }
    return arr2;
}

void PrintArr(int[] arr)
{
    System.Console.WriteLine(String.Join(",", arr));
}

int[] arr = { 3, 2, 1, 2 };
int[] arr2 = Flip('R', arr);
PrintArr(arr2);

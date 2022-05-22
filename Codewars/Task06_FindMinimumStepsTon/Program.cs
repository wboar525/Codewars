/* Summary:
Given a number, num, return the shortest amount of steps it would take from 1, to land exactly on that number.

Description:
A step is defined as either:

Adding 1 to the number: num += 1
Doubling the number: num *= 2
You will always start from the number 1 and you will have to return the shortest count of steps it would take to land exactly on that number.

1 <= num <= 10000 */

    int ShortestStepsToNum(int num)
    {
      if (num <= 1) return 0;
      int step = 0;
      int e = num;
      while(e>1)
      {
            if (e % 2 == 0) 
            {
                e = e / 2;
            }
            else
            {
                e--;
            }
            step++;
      }
      return step;
    }
    
    System.Console.WriteLine(ShortestStepsToNum(71));

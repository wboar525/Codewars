/* A perfect power is a classification of positive integers:

In mathematics, a perfect power is a positive integer that can be expressed as an integer power of another positive integer. More formally, n is a perfect power if there exist natural numbers m > 1, and k > 1 such that mk = n.
Your task is to check wheter a given integer is a perfect power. If it is a perfect power, return a pair m and k with mk = n as a proof. Otherwise return Nothing, Nil, null, NULL, None or your language's equivalent.

Note: For a perfect power, there might be several pairs. For example 81 = 3^4 = 9^2, so (3,4) and (9,2) are valid solutions. However, the tests take care of this, so if a number is a perfect power, return any pair that proves it. */

double BinaryPower(double b, int e)
{
    double v = 1d;
    while (e != 0)
    {
        if ((e & 1) != 0)
        {
            v *= b;
        }
        b *= b;
        e >>= 1;
    }
    return v;
}

int[] IsPerfectPower(int n)
{
    int[] power = new int[2];
    double res = n;
    for (int i = 2; i < 1000; i++)
    {
        double loga = Math.Log(n,i);
//        System.Console.WriteLine(i+" "+loga+" "+Math.Ceiling(loga)+" "+Math.Floor(loga));
        if (loga > 0 && Math.Round(loga,8) == (int) loga) 
        {
            power[0] = i;
            power[1] = (int)loga;
            return power;
        }
    }
    return null;
}

/*    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (BinaryPower(i, 2) == res)
        {
            power[0] = i;
            power[1] = 2;
            return power;
        }
        
        for (int j = 3; j <= n/2; j+=2)
        {
        if (BinaryPower(i, j) == res)
        {
            power[0] = i;
            power[1] = j;
            return power;
        }
        }
    } */


int[] test = { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
foreach (var i in test)
{
    int[] power = IsPerfectPower(i);
    System.Console.WriteLine(i+"->"+String.Join(",", power));
}
//double n = Math.Log(125,5);
//System.Console.WriteLine(n);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 9999;
int b1 = 2345;
int c1 = 123;

int a2 = 43;
int b2 = 234;
int c2 = 4325;

int a3 = 4356;
int b3 = 4567;
int c3 = 1243;

int max1 = Max(a1, b1,c1);

int max2 = Max(a2, b2, c2);

int max3 = Max(a3,b3,c3);

int overMax = Max(max1, max2, max3);

System.Console.WriteLine(overMax);

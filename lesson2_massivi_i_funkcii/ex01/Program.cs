// нахождение максимума из 9 чисел
int Max(int arg1, int arg2, int arg3) // записали функцию
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}



int a1 = 15;
int b1 = 63;
int c1 = 32;
int a2 = 21;
int b2 = 3;
int c2 = 6666;
int a3 = 6;
int b3 = 9;
int c3 = 11;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3); 


System.Console.WriteLine(max);


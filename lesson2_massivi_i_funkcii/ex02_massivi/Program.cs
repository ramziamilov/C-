// нахождение максимума из 9 чисел путем массива
int Max(int arg1, int arg2, int arg3) // записали функцию
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 1, 23, 31, 489, 5, 65, 757, 88, 49 };



int max= Max (
    Max(array[0], array[1], array[2]), // вызов функции
  Max(array[3], array[4], array[5]),
   Max(array[6], array[7], array[8])
   );


System.Console.WriteLine(max);


﻿// Найти максимум из 9-ти чисел используя функции

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8
int [] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
//array [0] = 12; обращаемся к массиву и записываем в него значение
//Console.WriteLine(array[0]); обращаемя к массиву и получаем значение соот-го элемента

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);
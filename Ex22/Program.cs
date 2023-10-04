// Найти максимум из 9-ти точек

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

// int a1 = 15;  Вместо введения переменных по одной используем массив
// int b1 = 97;
// int c1 = 12;
// int a2 = 25;
// int b2 = 27;
// int c2 = 42;
// int a3 = 45;
// int b3 = 77;
// int c3 = 32;  

//   index   =   0   1   2   3   4   5   6   7   8
int [] array = {15, 97, 12, 25, 27, 42, 45, 77, 32};


// array[0] = 17;
// Console.WriteLine(array[4]);

int max = Max (
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );
Console.WriteLine(max);

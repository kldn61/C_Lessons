﻿// Задача с гирями

int a = 3;
int b = 1;
int c = 8;
int d = 5;
int f = 6;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

Console.Write("MAX = ");
Console.WriteLine(max);

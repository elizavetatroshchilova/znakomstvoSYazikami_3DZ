﻿// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("ВВедите координаты х1, у1, z1 для первой точки");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("ВВедите координаты х2, у2, z2 для второй точки");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

int result = (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между введенными точками равно {result}");
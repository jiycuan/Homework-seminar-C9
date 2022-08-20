// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные кратные трём числа в промежутке от M до N.

void Zadacha64(int M, int N)
{
    if (M == N + 1) 
    {
        return;
    }
    if (M % 3 == 0 && M > 2)
    {
        Console.Write(M + "," + "   ");
    }
    M++;
    Zadacha64(M, N);
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Zadacha66(int M, int N, int sum = 0)
{
    if (M == N + 1)
    {
        Console.WriteLine(sum);
        return;
    }
    else
    {
        sum = sum + M;
        M++;  
        Zadacha66(M, N, sum); 
    }
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

static uint Zadacha68(uint n, uint m)
{
  if (n == 0) return m + 1;
  else if ((n != 0) && (m == 0)) return Zadacha68(n - 1, 1);
  else return Zadacha68(n - 1, Zadacha68(n, m - 1));
}

//Zadacha64(13, 20);
//Zadacha66(1, 15);
//Zadacha68(2, 3);
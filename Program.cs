// 3 вар, лёгкий 
Console.Write("Введите А:");
double A = double.Parse(Console.ReadLine());

Console.Write("Введите N:");
double N = double.Parse(Console.ReadLine());

double result = 1;
for (int i = 0; i < N; i++)
{
    result *= N;
}

Console.WriteLine(result);
// See https://aka.ms/new-console-template for more information
//task1
//Random rnd=new Random();
//int[] arr=new int[10];
//for(int i=0; i<arr.Length; i++)
//{
//    arr[i] = rnd.Next(0, 5);
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write("{0,4}", arr[i]);
//}
//Console.WriteLine();
//int[] res=new int[arr.Length];
//int count = 0;
//for (int i=0; i<arr.Length; i++)
//{
//    if (arr[i] != 0)
//    {
//        res[count]=arr[i];
//        count++;
//    }
//}
//for (int i = 0; i < res.Length; i++)
//{
//    if (res[i] == 0)
//    {
//        res[i] = -1;
//    }
//}
//for (int i = 0; i < res.Length; i++)
//{
//    Console.Write("{0,4}", res[i]);
//}

//task2
//int n = 5;
//int[,] arr = new int[n, n];

//int num = 1;
//int row = n / 2;
//int col = n / 2;
//arr[row, col] = num;
//num++;

//int step = 1;
//while (num <= n * n)
//{
//    for (int i = 0; i < step && num <= n * n; i++)
//    {
//        arr[--row, col] = num++;
//    }
//    for (int i = 0; i < step && num <= n * n; i++)
//    {
//        arr[row, --col] = num++;
//    }
//    step++;
//    for (int i = 0; i < step && num <= n * n; i++)
//    {
//        arr[++row, col] = num++;
//    }
//    for (int i = 0; i < step && num <= n * n; i++)
//    {
//        arr[row, ++col] = num++;
//    }
//    step++;
//}
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write("{0,4}", arr[i, j]);
//    }
//    Console.WriteLine();
//}
//task3
int N = 4; 
int M = 5; 
int[,] matrix = new int[N, M];
Random random = new Random();


for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        matrix[i, j] = random.Next(0, 101);
    }
}

Console.WriteLine("Исходный массив:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(matrix[i, j].ToString("D2") + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество столбцов для сдвига: ");
int shift = int.Parse(Console.ReadLine()) % M;

Console.Write("Введите направление сдвига (влево или вправо): ");
string direction = Console.ReadLine()?.ToLower();

int[,] result = new int[N, M]; 


for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        int newCol = direction == "вправо" ? (j + shift) % M : (j - shift + M) % M;
        result[i, newCol] = matrix[i, j];
    }
}

Console.WriteLine("Массив после сдвига:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(result[i, j].ToString("D2") + " ");
    }
    Console.WriteLine();
}
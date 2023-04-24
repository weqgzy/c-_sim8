int [,] arr = new int [3,4];

GetArray(arr);
PrintArray(arr);

int min = Int32.MaxValue;
int index = 0;


for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i,j];
    }
    if(sum < min){
            min = sum;
            index++;
    }
}

System.Console.WriteLine();
System.Console.WriteLine($"минимальная строка - {index}, с суммой - {min}");

void GetArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = new Random().Next(1,9);
        }
    }
}

void PrintArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array [i,j] + " ");
        }
        System.Console.WriteLine("");
    }
}
int [,] arr = new int [3,4];
GetArray(arr);
PrintArray(arr);
  
  
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < arr.GetLength(1) - 1; z++)
            {
                if(arr[i,z] < arr[i , z + 1]){
                    int temp = 0;
                    temp = arr[i , z];
                    arr[i,z] = arr[i , z + 1];
                    arr[i , z + 1] = temp;              
                }
            }
        }
    }


Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями: ");
PrintArray(arr);

void GetArray (int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i,j] = new Random().Next(1,9);
    }
    System.Console.WriteLine("");
}
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i , j] + " ");
        }
        System.Console.WriteLine("");
    }
}







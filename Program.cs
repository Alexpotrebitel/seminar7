// See https://aka.ms/new-console-template for more information
/*
int [,] CreateRandomedArray()
{
    Console.WriteLine("введите колличество строк");
 int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("колличество столбцов");
 int colums=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("минимальное значение");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальное значение");
 int maxValue=Convert.ToInt32(Console.ReadLine());
    
int [,] array= new int[rows,colums];
for (int i=0;i<rows;i++)

for (int j=0;j<colums;j++)

    array[i,j] =new Random().Next(minValue,maxValue+1);


return array;

}

void show2darray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
for(int j=0;j<array.GetLength(1);j++)

    Console.Write(array[i,j]+"\t");
    
      Console.WriteLine();  
    }

}

int[,] newArray=CreateRandomedArray();
show2darray(newArray);
*/
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int [,] Create2dArray()
{
    Console.WriteLine("введите колличество строк");
 int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("колличество столбцов");
 int colums=Convert.ToInt32(Console.ReadLine());

    
int [,] array= new int[rows,colums];
for (int i=0;i<rows;i++)

for (int j=0;j<colums;j++)

    array[i,j] =i+j;


return array;

}

void show2darray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
for(int j=0;j<array.GetLength(1);j++)

    Console.Write(array[i,j]+"\t");
    
      Console.WriteLine();  
    }

}

int[,] newArray=Create2dArray();
show2darray(newArray);
*/
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int [,] CreateRandomedArray(int rows,int colums,int minValue, int maxValue)
{
        
int [,] array= new int[rows,colums];
for ( int i=0;i<rows;i++)
    {
for (int  j=0;j<colums;j++)
        {
array[i,j] =new Random().Next(minValue,maxValue+1);
    
        }
    }
return array;

}

int[,] Chek(int[,] array)
{
    for ( int i=0;i<array.GetLength(0);i=i+2)
    {
for (int  j=0;j<array.GetLength(1);j=j+2)
        {
if (i%2==0 && j%2==0)
            {    
    array[i,j]=array[i,j]*array[i,j];

            }
        }

    }
    return array;

}
void show2darray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
for(int j=0;j<array.GetLength(1);j++)

    Console.Write(array[i,j]+"\t");
    
      Console.WriteLine();  
    }



}
Console.WriteLine("введите колличество строк");
 int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("колличество столбцов");
 int colums=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("минимальное значение");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальное значение");
 int maxValue=Convert.ToInt32(Console.ReadLine());

int[,] newArray=CreateRandomedArray( rows, colums, minValue,  maxValue);
show2darray(newArray);
Console.WriteLine();
Chek(newArray);
show2darray(newArray);
*/
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int [,] CreateRandomedArray()
{
    Console.WriteLine("введите колличество строк");
 int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("колличество столбцов");
 int colums=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("минимальное значение");
int minValue=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("максимальное значение");
 int maxValue=Convert.ToInt32(Console.ReadLine());
    
int [,] array= new int[rows,colums];
for (int i=0;i<rows;i++)

for (int j=0;j<colums;j++)

    array[i,j] =new Random().Next(minValue,maxValue+1);


return array;

}

void show2darray(int[,]array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
for(int j=0;j<array.GetLength(1);j++)

    Console.Write(array[i,j]+"\t");
    
      Console.WriteLine();  
    }

}

int Sumel(int[,] array)
{
    int sum=0; 
    for (int i=0;i<array.GetLength(0)&&i <array.GetLength(1);i++)
    {
     
 sum+=array[i,i];
     }
return sum;
}

int[,] newArray=CreateRandomedArray();
show2darray(newArray);
int sum=Sumel(newArray);
Console.WriteLine(sum);

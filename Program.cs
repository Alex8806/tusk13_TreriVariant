// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.Write("Введите число с тремя и более цифрами ");


int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int h = 10;
int j = 1;
while (number / h != 0)
{
    h *= 10;
    j++;
}
System.Console.WriteLine("длина числа :" + j);

if (j < 3)
{
    System.Console.WriteLine("третей цифры нет");
}
else
{

int k = 0;
int t =1;
int[]arr= new int[j-1];

   while ( j>0)
    {
        int b = 1;
        for (int s = 0; s < (j-1); s++)
        {
            b *= 10;
        }
         t = number / b;
        number -= (t*b);
      
       //arr[k] = t;

       j--;
       k++;
        System.Console.WriteLine (t);
        

    }

     System.Console.WriteLine(arr);
 System.Console.WriteLine(arr[3]);

}

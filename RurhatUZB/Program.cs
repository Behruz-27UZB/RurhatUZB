//int 
//for(int i = 7; i >= 1; i-=2)
//{
//    for(int a = i;a >= 1; a--)
//    {
//        if (a == 1)
//        Console.Write(" * ");
//        else
//        {
//            Console.Write(" * ");
//        }

//    }
//    Console.WriteLine(      );
//}
char[,] tuplam = new char[9, 7];

for (int i = 0;i < 9; i++)
{
    for (int j = i; j < 7; j ++)
    {
        tuplam[j] = ("*");
    }
}
Console.WriteLine(tuplam[j]);
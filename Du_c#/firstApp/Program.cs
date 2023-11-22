using System;

class Program
{
    static void Main (string[] args)
    {
        Console.Write("mine");
        Console.Clear();//efface le terminal
        Console.WriteLine("\t Hello, World!");//:tabulation
        Console.Write("are you ok ?\n");
        //Console.Write("good");
        //Console.Beep();//met un beep
        Console.Title = "MY first Program ";
        
Console.WriteLine("vueiller entrer votre nombre :");
int x = Console.Read();
Console.WriteLine("vueiller entrer votre nombre :");
int y = Console.Read();
Sum(x ,y);  

/*
        int nombre2 = 123; 
        
        Console.WriteLine (nombre2);

        string chaine = "azreekf";
        bool resultat ;

        resultat = (chaine =="azeeekf") ? true : false;
          

          int i;

          for ( i = 0 ; i < 5 ; i++)
          {
            Console.WriteLine(i);
          }
          int j = 0;
          while  (j < 3)
          {
             Console.WriteLine(j);
             j++;
          }


          do
          {
            Console.WriteLine(nombre2);
          }
          while(j == 0);
*/

/*int c = Console.Read();
Console.WriteLine(c);
ConsoleKeyInfo ck = Console.ReadKey();
Console.WriteLine(ck.KeyChar);*/

static int Sum(int  a,int b)
{
    return  a + b;
}


  }
}


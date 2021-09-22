using System;

class Program {
 public static void Main(string[] commandLineArguments)
    {
      char [] lettersFirst = {'a', 'b', 'c', 'd', 'e'};

      char [] lettersSecond = {'f', 'g', 'h', 'i', 'j'};
      
       char [] lettersFirstSecond = new char [10];

      lettersFirst.CopyTo(lettersFirstSecond, 0);

      lettersSecond.CopyTo(lettersFirstSecond, 5);

      Console.WriteLine ("Tableau 1 : \n");
      foreach (char letter1 in lettersFirst)
      {
        Console.WriteLine("Letter = {0}", letter1);
      }

      Console.WriteLine ("\nTableau 2 : \n");
      foreach (char letter2 in lettersSecond)
      {
        Console.WriteLine("Letter = {0}", letter2);
      }

      Console.WriteLine ("\nTableau 3 : \n");
      foreach (char letter3 in lettersFirstSecond)
      {
        Console.WriteLine("Letter = {0}", letter3);
      }

    }
    
}

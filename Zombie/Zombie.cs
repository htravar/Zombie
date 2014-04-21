//created by Heather Travar on 4/1/14
//This program asks user how well they expect certain people to survive a zombie apocalypse and displays the results

using System;
   class Zombie
   {
      public string Relations {get; set;}//auto implemented properties
      public string RelativeName {get; set;}

      public Zombie(string name, string relationship)//constructor(must have same name as class)
      {
         RelativeName = name;
         Relations = relationship;
      }

      public void DisplayInfo()
      {
         Console.WriteLine("The relative you feel most likelyto survive a zombie");
         Console.WriteLine("apocalypse is {0}, your {1}.", RelativeName, Relations);
      }      
      
      
   }//end class Zombie

   class ZombieTest
   {
      static void Main(string[] args)
      {
         string nameOfRelative;
         Console.WriteLine("Will anyone in your family survive the zombie apocalypse?");
         Console.WriteLine("Enter the name of the one MOST likely to survive.");
         nameOfRelative = Console.ReadLine();

         Console.WriteLine();

        string relationtoRelative;
        Console.WriteLine("Enter this person's relationship to this you.");
        relationtoRelative = Console.ReadLine();

         Console.WriteLine();

         Zombie survivor = new Zombie(nameOfRelative,relationtoRelative);//local variables as arguments
         survivor.DisplayInfo();

         Console.ReadKey();
      }//end Main method
   }//end class ZombieTest

   //
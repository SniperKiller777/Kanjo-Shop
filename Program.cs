using KanjoInOsakaTuning_ching_ching.KanjoTuning;
using System;
namespace KanjoInOsakaTuning_ching_ching
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Menu menu = new Menu();
                menu.ShowMainMenu();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
   

}

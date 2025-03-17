namespace KanjoInOsakaTuning_ching_ching.KanjoTuning
{
    
        public class Menu
        {
            public void ShowMainMenu()
            {
                Console.WriteLine("=== Welcome to Kanjo Car Tuning - Osaka ===");
                Console.WriteLine("1. Internal Upgrades");
                Console.WriteLine("2. External Upgrades");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InternalUpgrades internalUpgrades = new InternalUpgrades();
                        internalUpgrades.ShowInternalMenu();
                        break;
                    case "2":
                        ExternalUpgrades externalUpgrades = new ExternalUpgrades();
                        externalUpgrades.ShowExternalMenu();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for visiting Kanjo!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        ShowMainMenu();
                        break;
                }
            }
        }
    

}
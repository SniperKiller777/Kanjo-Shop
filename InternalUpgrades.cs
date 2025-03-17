namespace KanjoInOsakaTuning_ching_ching.KanjoTuning
{


    
    
        public class InternalUpgrades
        {
            private List<string> availableParts = new List<string> { "Turbocharger", "Performance ECU", "Sport Exhaust" };
            private Car car = new Car();
            private InstallationService installer = new InstallationService();

            public void ShowInternalMenu()
            {
                Console.WriteLine("=== Internal Upgrades ===");
                Console.WriteLine("1. View Available Parts");
                Console.WriteLine("2. View Installed Internal Upgrades");
                Console.WriteLine("3. Install a Part");
                Console.WriteLine("4. Back to Main Menu");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewInventory();
                        ShowInternalMenu();
                        break;
                    case "2":
                        car.ViewInternalUpgrades();
                        ShowInternalMenu();
                        break;
                    case "3":
                        InstallPart();
                        ShowInternalMenu();
                        break;
                    case "4":
                        Menu menu = new Menu();
                        menu.ShowMainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        ShowInternalMenu();
                        break;
                }
            }

            private void ViewInventory()
            {
                Console.WriteLine("Available Internal Parts:");
                foreach (var part in availableParts)
                {
                    Console.WriteLine($"- {part}");
                }
            }

            private void InstallPart()
            {
                Console.WriteLine("Enter the name of the part to install:");
                string partName = Console.ReadLine();

                if (availableParts.Contains(partName))
                {
                    installer.InstallInternalPart(car, partName);
                }
                else
                {
                    Console.WriteLine("Part not found in inventory.");
                }
            }
        }
   

}
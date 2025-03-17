namespace KanjoInOsakaTuning_ching_ching.KanjoTuning
{
   
    
        public class ExternalUpgrades
        {
            private Car car = new Car();
            private InstallationService installer = new InstallationService();

            public void ShowExternalMenu()
            {
                Console.WriteLine("=== External Upgrades ===");
                Console.WriteLine("1. Paint the Car");
                Console.WriteLine("2. View External Upgrades");
                Console.WriteLine("3. Back to Main Menu");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PaintCar();
                        ShowExternalMenu();
                        break;
                    case "2":
                        car.ViewExternalUpgrades();
                        ShowExternalMenu();
                        break;
                    case "3":
                        Menu menu = new Menu();
                        menu.ShowMainMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        ShowExternalMenu();
                        break;
                }
            }

            private void PaintCar()
            {
                Console.WriteLine("Enter the color you want to paint the car:");
                string color = Console.ReadLine();

                installer.PaintCar(car, color);
            }
        }
   

}
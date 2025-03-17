namespace KanjoInOsakaTuning_ching_ching.KanjoTuning
{
    
    
        public class Car
        {
            public string Model { get; set; }
            public string Color { get; set; } = "Unpainted";
            public List<string> InternalUpgrades { get; private set; } = new List<string>();
            public List<string> ExternalUpgrades { get; private set; } = new List<string>();

            public Car(string model = "Generic Kanjo Car")
            {
                Model = model;
            }

            public void AddInternalUpgrade(string upgrade)
            {
                InternalUpgrades.Add(upgrade);
                Console.WriteLine($"Installed internal upgrade: {upgrade}");
            }

            public void AddExternalUpgrade(string upgrade)
            {
                ExternalUpgrades.Add(upgrade);
                Console.WriteLine($"Applied external upgrade: {upgrade}");
            }

            public void ViewInternalUpgrades()
            {
                Console.WriteLine("Installed Internal Upgrades:");
                if (InternalUpgrades.Count == 0)
                    Console.WriteLine("None");
                else
                    InternalUpgrades.ForEach(upgrade => Console.WriteLine($"- {upgrade}"));
            }

            public void ViewExternalUpgrades()
            {
                Console.WriteLine($"Car Color: {Color}");
                Console.WriteLine("Installed External Upgrades:");
                if (ExternalUpgrades.Count == 0)
                    Console.WriteLine("None");
                else
                    ExternalUpgrades.ForEach(upgrade => Console.WriteLine($"- {upgrade}"));
            }
        }
    

}
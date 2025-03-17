namespace KanjoInOsakaTuning_ching_ching.KanjoTuning
{
   
   
        public class InstallationService
        {
            public void InstallInternalPart(Car car, string part)
            {
                car.AddInternalUpgrade(part);
                Console.WriteLine($"Successfully installed {part} on {car.Model}.");
            }

            public void PaintCar(Car car, string color)
            {
                car.Color = color;
                car.AddExternalUpgrade($"Painted {color}");
                Console.WriteLine($"Car painted {color} successfully.");
            }
        }
    

}
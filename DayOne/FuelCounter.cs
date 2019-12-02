using System.IO;

namespace adventofcode2019.DayOne
{
    public class FuelCounter
    {
        public int TotalFuelFromFile(string path)
        {
            var lines = File.ReadAllLines(path);
            var total = 0;
            foreach (var line in lines)
            {
                var massFromFile = int.Parse(line);
                var module = new SpacecraftModule(massFromFile);
                total += module.CalculateFuelRequired();
            }

            return total;
        }
    }
}
namespace adventofcode2019.DayOne
{
    public class SpacecraftModule
    {
        private readonly int _mass;

        public SpacecraftModule(int mass)
        {
            _mass = mass;
        }

        public int CalculateFuelRequired()
        {
            return (_mass / 3) - 2;
        }
    }
}
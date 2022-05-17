namespace ProjetoPOO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.HealtPoint = 250;
            this.MagicPoint = 50;
        }
    }
}
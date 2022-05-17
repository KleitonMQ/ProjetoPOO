namespace ProjetoPOO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.HealtPoint = 150;
            this.MagicPoint = 150;
        }
        public override string Attack()
        {
            return "Lançou shuriken.";
        }

    }
}
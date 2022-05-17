namespace ProjetoPOO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.HealtPoint = 50;
            this.MagicPoint = 200;
        }
        public override string Attack()
        {
            return "Lançou magia.";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.name} Lançou magia crítica";
            }
            else
            {
                return $"{this.name} Lançou magia boostada.";
            }

        }
    }
}
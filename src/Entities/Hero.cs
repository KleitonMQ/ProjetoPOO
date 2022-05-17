namespace ProjetoPOO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;

        }
        public string name;
        public int level;
        public string heroType;

        public int MagicPoint;
        public int HealtPoint;


        public override string ToString()
        {
            return $"Status: {this.name} Level: {this.level} Classe: {this.heroType} MP: {this.MagicPoint} HP: {this.HealtPoint}";
        }

        public virtual string Attack()
        {
            return $"{this.name} Atacou com a espada.";
            //precisamos dizer que uma método é vitual sempre que ele precisar ser sobrescrito em alguma classe filha.
        }
    }
}

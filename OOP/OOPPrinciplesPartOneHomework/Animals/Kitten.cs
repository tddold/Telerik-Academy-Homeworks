namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.Female)
        {
        }

        public override string ProduceSound()
        {
            return base.ProduceSound();
        }
    }
}

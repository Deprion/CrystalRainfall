public class Crystal : Item
{
    public Global.TypeOfCrystal TypeOfCrystal { get; private set; }

    public Crystal(Global.TypeOfItem type, Global.TypeOfCrystal crystal) : base(type)
    {
        TypeOfCrystal = crystal;
    }
}

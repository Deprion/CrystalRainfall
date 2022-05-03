public abstract class Item
{
    public Global.TypeOfItem TypeOfItem { get; private set; }

    public Item(Global.TypeOfItem type)
    {
        TypeOfItem = type;
    }
}

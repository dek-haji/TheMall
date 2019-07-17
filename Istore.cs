namespace TheMall
{
    public interface Istore<Titem>
    {
        void AddToInventory(string name, Titem item);
        Titem GetFromInventory(string name);
    }
}
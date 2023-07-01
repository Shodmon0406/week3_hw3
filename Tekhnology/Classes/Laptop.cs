namespace Tekhnology.Classes;

public class Laptop : Computer
{
    double _weight;

    public Laptop(int ram, int storage, string keyboard, double weight) : base(ram, storage, keyboard)
    {
        _weight = weight;
    }

    public bool WeightChek()
    {
        if (_weight > 1.75)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

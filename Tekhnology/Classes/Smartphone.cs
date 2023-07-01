namespace Tekhnology.Classes;

public class Smartphone : Computer
{
    int numberOfSelfies = 0;

    public Smartphone(int ram, int storage, string keyboard) : base(ram, storage, keyboard)
    {
    }

    public void TakeSelfies()
    {
        numberOfSelfies++;
    }
    public int GetNumberOfSelfies()
    {
        return numberOfSelfies;
    }
}
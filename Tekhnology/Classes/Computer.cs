namespace Tekhnology.Classes;

public abstract class Computer
{
    int _ram;
    int _storage;
    string _keyboard;
    public Computer(int ram, int storage, string keyboard)
    {
        _ram = ram;
        _storage = storage;
        _keyboard = keyboard;
    }
    public void AddRam(int ram)
    {
        _ram += ram;
    }
    public void AddStorage(int storage)
    {
        _storage += storage;
    }
    public string ToString()
    {
        return $"Ram: {_ram}gb Storage: {_storage}gb Keyboard: {_keyboard}";
    }
}

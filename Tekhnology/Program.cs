using Tekhnology.Classes;

var laptop = new Laptop(16, 1024, "rus&eng", 1.5);
System.Console.WriteLine(laptop.ToString());
System.Console.WriteLine($"Heavy: {laptop.WeightChek()}");
var smartphone = new Smartphone(8, 128, "rus");
System.Console.WriteLine(smartphone.ToString());
smartphone.TakeSelfies();
smartphone.TakeSelfies();
System.Console.WriteLine($"Number of selfies: {smartphone.GetNumberOfSelfies()}");
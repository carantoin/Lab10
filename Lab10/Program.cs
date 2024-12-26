using System;
using System.Data;

public class Year
{
    public int YearOfRelease { get; set; }
    public Year(int yearOfRelease)
    {
        YearOfRelease = yearOfRelease;
    }
    public int GetYear()
    {
        return DataSetDateTime.Now.Year;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите год выпуска товара:");
        double y = double.Parse(Console.ReadLine());
        Year year = new Year();
    }
}

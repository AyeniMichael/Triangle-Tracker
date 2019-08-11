using System;
using System.Collections.Generic;

class Triangle
{
    public int FirstSide;
    public int SecondSide;
    public int ThirdSide;

    public Triangle(int firstSide, int secondSide, int thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public void TriangleType(int firstSide, int secondSide, int thirdSide)
    {
        if (FirstSide > (SecondSide+ThirdSide) || SecondSide > (FirstSide+ThirdSide) || ThirdSide > (FirstSide+SecondSide))
        {
            Console.WriteLine("Sorry, This is not a Triangle");
        }
        else if (FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide)
        {
            Console.WriteLine("This is an Equilateral Triangle");
        }
        else if (FirstSide == SecondSide || FirstSide == ThirdSide || SecondSide == ThirdSide) 
        {
            Console.WriteLine("This is an Isosceles Triangle");
        }
        else if (!(FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide))
        {
            Console.WriteLine("This is a Scalene Triangle");
        }
        
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Triangle Tracker");
        Console.WriteLine("Enter the length of the first side");
        string inputSide1 = Console.ReadLine();
        Console.WriteLine("Enter the length of the second side");
        string inputSide2 = Console.ReadLine();
        Console.WriteLine("Enter the length of the third side");
        string inputSide3 = Console.ReadLine();

        int side1 = int.Parse(inputSide1);
        int side2 = int.Parse(inputSide2);
        int side3 = int.Parse(inputSide3);

        Triangle myTriangle  = new Triangle(side1, side2, side3);

        myTriangle.TriangleType(side1, side2, side3);

    }
}
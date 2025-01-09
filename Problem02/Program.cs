


using System;



class Rectangle

{

    private double sideA;

    private double sideB;



    // Конструктор

    public Rectangle(double sideA, double sideB)

    {

        this.sideA = sideA;

        this.sideB = sideB;

    }



    // Метод для вычисления площади

    private double CalculateArea()

    {

        return sideA * sideB;

    }



    // Метод для вычисления периметра

    private double CalculatePerimeter()

    {

        return 2 * (sideA + sideB);

    }



    // Свойство для доступа к площади

    public double Area

    {

        get { return CalculateArea(); }

    }



    // Свойство для доступа к периметру

    public double Perimeter

    {

        get { return CalculatePerimeter(); }

    }

}



class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Введите длину стороны A:");

        double sideA = double.Parse(Console.ReadLine());



        Console.WriteLine("Введите длину стороны B:");

        double sideB = double.Parse(Console.ReadLine());



        Rectangle rectangle = new Rectangle(sideA, sideB);



        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");

        Console.WriteLine($"Периметр прямоугольника: {re
using System;



class Rectangle

{

    private double sideA;

    private double sideB;



    // Конструктор

    public Rectangle(double sideA, double sideB)

    {

        this.sideA = sideA;

        this.sideB = sideB;

    }



    // Метод для вычисления площади

    private double CalculateArea()

    {

        return sideA * sideB;

    }



    // Метод для вычисления периметра

    private double CalculatePerimeter()

    {

        return 2 * (sideA + sideB);

    }



    // Свойство для доступа к площади

    public double Area

    {

        get { return CalculateArea(); }

    }



    // Свойство для доступа к периметру

    public double Perimeter

    {

        get { return CalculatePerimeter(); }

    }

}



class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Введите длину стороны A:");

        double sideA = double.Parse(Console.ReadLine());



        Console.WriteLine("Введите длину стороны B:");

        double sideB = double.Parse(Console.ReadLine());



        Rectangle rectangle = new Rectangle(sideA, sideB);



        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");

        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");

    }

}

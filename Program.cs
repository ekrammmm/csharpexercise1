
abstract class shape
{
    public abstract void getarea();


    public abstract void getperimeter();


}
class circle : shape
{
    const double pi = 3.14;
    double area, p;
    public double radius;

    public override void getarea()
    {
        area = pi * this.radius * this.radius;
        Console.WriteLine(area);
    }

    public override void getperimeter()
    {
        p = 2 * pi * radius;
        Console.WriteLine(p);
    }
}
class square : shape
{
    public double length, area, p;

    public override void getarea()
    {
        area = this.length * this.length;
        Console.WriteLine(area);
    }

    public override void getperimeter()
    {
        p = 4 * length;
        Console.WriteLine(p);
    }
}
class triangle : shape
{
    public double height, width, basee;
    double area, p;

    public override void getarea()
    {
        area = 0.5 * height * width;
        Console.WriteLine(area);
    }

    public override void getperimeter()
    {
        p = height + width + basee;
        Console.WriteLine(p);
    }
}
class program
{
    public static void Main(string[] args)
    {
        char z = 'y';
        while (z is 'y' or 'Y')
        {
            circle c = new circle();
            square s = new square();
            triangle t = new triangle();
            Console.WriteLine("This program calculates Area and perimeter of a shape\n" +
                              "Please choose your desired shape\n" +
                              "1.Circle\n2.Square\n3.Triangle");
            int x = int.Parse(Console.ReadLine());
            int y;
            if (x == 1)
            {
                Console.WriteLine("Please choose your desired calculation\n" +
                    "1.Area\n2.Perimeter");
                y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    Console.WriteLine("Please enter the radius of a circle");
                    c.radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is");
                    c.getarea();
                }
                else if (y == 2)
                {
                    Console.WriteLine("Please enter the radius of a circle");
                    c.radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter is");
                    c.getperimeter();

                }
                else
                {
                    Console.WriteLine("Error: Please choose a valid shape");
                }

            }
            else if (x == 2)
            {
                Console.WriteLine("Please choose your desired calculation\n" +
                    "1.Area\n2.Perimeter");
                y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    Console.WriteLine("Please Enter the length of a square");
                    s.length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is ");
                    s.getarea();
                }
                else if (y == 2)
                {
                    Console.WriteLine("Please Enter the length of a square");
                    s.length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter is");
                    s.getperimeter();

                }
                else
                {
                    Console.WriteLine("Error: Please choose a valid shape");
                }
           
}
            else if (x == 3)
            {
                Console.WriteLine("Please choose your desired calculation\n" +
                    "1.Area\n2.Perimeter");
                y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    Console.WriteLine("Please Enter the height and width of a triangle respectfully");
                    t.height = double.Parse(Console.ReadLine());
                    t.width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Area is");
                    t.getarea();
                }
                else if (y == 2)
                {
                    Console.WriteLine("Please Enter the base1,base2 and base3 of a triangle respectfully");
                    t.height = double.Parse(Console.ReadLine());
                    t.width = double.Parse(Console.ReadLine());
                    t.basee = double.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter is");
                    t.getperimeter();

                }
                else
                {
                    Console.WriteLine("Error: Please choose a valid shape");
                }

            }
            else
            {
                Console.WriteLine("Error: Please choose a valid shape");
            }
            Console.WriteLine("Do you want to continue(y/n)?");
            z = char.Parse(Console.ReadLine());
            if (z is 'y' or 'Y')
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("See you next time!!!");
            }
        }



    }
}

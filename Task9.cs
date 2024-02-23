/*
1. WITH REF PARAMETERS
*/
using System;
using System.Threading.Channels;

public class QuadraticEquationSolver
{
    public static int i=0;
    public static void SolveQuadraticEquation(double a, double b, double c, ref double x1, ref double x2)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots. You can have complex roots.");
        }
        else if (discriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
            i++;
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            i++;
        }
    }

    public static void Main(string[] args)
    {
        double a = 5, b = -3, c = 2;
        double x1 = 0, x2 = 0;

        SolveQuadraticEquation(a, b, c, ref x1, ref x2);
        if (i != 0)
        {
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }

    }
}



/*
2. USING TUPLE
 
using System;

public class QuadraticEquationSolver
{
    public static (double?, double?) SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        double? x1 = null;
        double? x2 = null;

        if (discriminant < 0)
        {
            // No real roots exist
            // Return null for both roots
        }
        else if (discriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }

        return (x1, x2);
    }

    public static void Main(string[] args)
    {
        double a = 1, b = -3, c = 2;

        var roots = SolveQuadraticEquation(a, b, c);

        if (roots.Item1 != null && roots.Item2 != null)
        {
            Console.WriteLine($"x1 = {roots.Item1}, x2 = {roots.Item2}");
        }
        else
        {
            Console.WriteLine("No real roots exist.");
        }
    }
}
*/






/*
3. WITH ARRAY 
 
 using System;

public class QuadraticEquationSolver
{
    public static double[] SolveQuadraticEquation(double a, double b, double c)
    {
        double[] roots = new double[2];
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (discriminant == 0)
        {
            roots[0] = roots[1] = -b / (2 * a);
        }
        else
        {
            roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }

        return roots;
    }

    public static void Main(string[] args)
    {
        double a = 1, b = -3, c = 2;

        double[] roots = SolveQuadraticEquation(a, b, c);

        Console.WriteLine($"x1 = {roots[0]}, x2 = {roots[1]}");
    }
}*/


/*
4. DECONSTRUCTING IN CLASS 
 
using System;

public class QuadraticEquationSolver
{
    private readonly double a, b, c;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public bool Solve(out double x1, out double x2)
    {
        double discriminant = b * b - 4 * a * c;
        bool hasRealRoots = true;

        if (discriminant < 0)
        {
            // No real roots exist
            x1 = x2 = 0; // Assigning arbitrary values, could be NaN or anything indicating no real roots
            hasRealRoots = false;
        }
        else if (discriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
        }
        else
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }

        return hasRealRoots;
    }

    public static void Main(string[] args)
    {
        double a = 1, b = -3, c = 2;

        QuadraticEquationSolver solver = new QuadraticEquationSolver(a, b, c);
        bool hasRealRoots = solver.Solve(out double x1, out double x2);

        if (hasRealRoots)
        {
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else
        {
            Console.WriteLine("No real roots exist.");
        }
    }
}
*/



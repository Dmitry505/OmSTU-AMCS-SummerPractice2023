﻿namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {        
        const double E = 0.000000001;

        if (Math.Abs(a) < E)
            throw new System.ArgumentException();

        foreach (double x in new double[] {a, b, c})
        {
            if (double.IsNaN(x) || double.IsInfinity(x))
                throw new System.ArgumentException();
        }

        double D = b*b - 4*a*c;        
        if (Math.Sign(D) < 0 && !(Math.Abs(D) < E))
            return new double[0];

        double x1 = -(b + Math.Sign(b)*Math.Sqrt(D))/2;
        double x2 = c/x1;

        if (D < E)
            return new double[] {x1};
        
        return new double[] {x1, x2};   
    }
}
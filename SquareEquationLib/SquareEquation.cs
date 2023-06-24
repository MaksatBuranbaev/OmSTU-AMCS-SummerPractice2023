namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {

        double[] roots;
        double eps = 0.000000001;
        
        if (Math.Abs(a) < eps)
        {
            throw new System.ArgumentException();
        }

        foreach (double x in new double[] { a, b, c })
        {
            if (double.IsNaN(x) || double.IsInfinity(x))
            {
                throw new System.ArgumentException();
            }
        }

        double d = Math.Pow(b, 2) - 4 * a * c;
        
        if (d < 0 && !(Math.Abs(d) < eps))
        {
            roots = new double[0];
        }
        
        else if (d < eps)
        {   
            roots = new double[1];
            roots[0] = -(b + Math.Sign(b) * Math.Sqrt(d)) / 2;
        }
        
        else
        {
            roots = new double[2];
            roots[0] = -(b + Math.Sign(b) * Math.Sqrt(d)) / 2;
            roots[1] = c / roots[0];
        }
        
        return roots;
    }
}

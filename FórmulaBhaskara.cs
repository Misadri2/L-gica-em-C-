using System;

class FórmulaBhaskara {

static void Main(string[] args) { 

double a, b, c, delta, r1, r2;
        
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    c = double.Parse(Console.ReadLine());
    delta = Math.Pow(b,2.0) - 4*a*c;
            
    if(a == 0 || delta < 0.0){
        Console.WriteLine("Impossível calcular");
        } else {
            r1 = (-b + Math.Sqrt(delta))/ (2.0 * a);
            r2 = (-b - Math.Sqrt(delta))/ (2.0 * a);
            Console.WriteLine(" R1 = " + r1.ToString("F5"));
            Console.WriteLine(" R2 = " + r2.ToString("F5"));
            }
    }
}
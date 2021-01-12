using System; 

class URI {

    static void Main(string[] args) { 
//Fazer um programa para ler as medidas da base e altura de um retângulo. Em
//seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
//casas decimais, conforme exemplo.

        
        double a, b, area, perimetro, diagonal;

             
        b = double.Parse(Console.ReadLine());
        a = double.Parse(Console.ReadLine());
        area = b * a;
        perimetro = b + a + b + a;
        diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0)); 
        
        Console.WriteLine("AREA = " + area.ToString("F4"));
        Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));
        Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"));
        
       
    }

}
using System;
using System.Globalization;
    namespace curso {
        class Program {
        static void Main(string[] args){
            // Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular 
            //com uma casa decimal bem como o valor do metro quadrado do terreno com duas casas decimais,
            // Em seguida o programa deve mostrar o valor da área do terreno bem como o valor do preço do terreno ambos.
            
            double largura, comprimento, PrecoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine());
            comprimento = double.Parse(Console.ReadLine());
            PrecoMetroQuadrado = double.Parse(Console.ReadLine());           

            area = largura * comprimento;
            preco = area * PrecoMetroQuadrado;

            Console.WriteLine("Área do terreno: " + area.ToString("F2",CultureInfo.InvariantCulture)); 
            Console.WriteLine("Preço do terreno: " + preco.ToString("F2",CultureInfo.InvariantCulture)); 
            
            Console.ReadLine();
           
        }
    }
}
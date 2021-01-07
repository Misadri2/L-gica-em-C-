using System;

    namespace curso {
        class Program {
        static void Main(string[] args){
            Console.WriteLine("Qual é seu nome?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Seu nome é: " + name);
            Console.WriteLine("Qual a sua idade?: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Você tem: " + age );
           


        }
    }
}
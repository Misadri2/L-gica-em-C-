using System;

class ContaDeTelefone {

static void Main(string[] args) {

    int minutos;
    double conta;

    conta = 50.0;
    minutos= int.Parse(Console.ReadLine());

    if (minutos > 100){
        conta += (minutos-100) * 2.00;
        }

    Console.WriteLine( "Valor da conta: R$ " + conta.ToString("F2"));
    
    }

}
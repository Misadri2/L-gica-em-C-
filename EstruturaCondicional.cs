using System; 

class EstruturaCondicional {

    static void Main(string[] args) { 

int hora;
Console.WriteLine("Que horas são?");
hora = int.Parse(Console.ReadLine());
Console.WriteLine("São " + hora + " horas");

if(hora < 12){
    Console.WriteLine("Bom dia!!");
}else if(hora<18){
    Console.WriteLine("Boa Tarde!!");
    }else{
    Console.WriteLine("Boa Noite!!");
     }
  }
}
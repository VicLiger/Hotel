using System;

namespace Explorando_C_.Models
{
    public class Reserva
    {
        public int Dias { get; set; }
        public decimal ValorDiaria { get; set; }
        public int DiasPermanecidos { get; set; } // Declarando a propriedade DiasPermanecidos

        public Reserva()
        {
        }

        public int ReservaHospede()
        {
            int diasPermanecidos;
            Console.WriteLine("Quantos dias o senhor(a) deseja ficar?");
            int.TryParse(Console.ReadLine(), out diasPermanecidos);

            DiasPermanecidos = diasPermanecidos; // Atribuindo o valor à propriedade DiasPermanecidos

            return diasPermanecidos;
        }

        public void ValorPago()
        {
            Suite quartoEscolhido = new Suite();
            string escolha = quartoEscolhido.EscolhaQuarto();

            decimal ValorPago,valorTotal,ValorDesconto;
            switch (escolha)
            {
                case "Presidencial":
                    ValorPago = 100;
                    valorTotal = ValorPago * DiasPermanecidos;
                    if(DiasPermanecidos > 10){
                        ValorDesconto = (valorTotal / 100)* 10;
                        valorTotal = valorTotal - ValorDesconto;
                        Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }else{
                    Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }
                    break;

                case "Premium":
                    ValorPago = 75;
                    valorTotal = ValorPago * DiasPermanecidos;
                    if(DiasPermanecidos > 10){
                        ValorDesconto = (valorTotal / 100)* 10;
                        valorTotal = valorTotal - ValorDesconto;
                        Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }else{
                    Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }
                    break;

                case "NormalF":
                    ValorPago = 50;
                    valorTotal = ValorPago * DiasPermanecidos;
                    if(DiasPermanecidos > 10){
                        ValorDesconto = (valorTotal / 100)* 10;
                        valorTotal = valorTotal - ValorDesconto;
                        Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }else{
                    Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }
                    break;

                case "NormalC":
                    ValorPago = 35;
                    valorTotal = ValorPago * DiasPermanecidos;
                    if(DiasPermanecidos > 10){
                        ValorDesconto = (valorTotal / 100)* 10;
                        valorTotal = valorTotal - ValorDesconto;
                        Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }else{
                    Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }
                    break;

                case "NormalS":
                    ValorPago = 20;
                    valorTotal = ValorPago * DiasPermanecidos;
                    if(DiasPermanecidos > 10){
                        ValorDesconto = (valorTotal / 100)* 10;
                        valorTotal = valorTotal - ValorDesconto;
                        Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }else{
                    Console.WriteLine("Você irá pagar um valor de "+valorTotal);
                    }
                    break;
               
            }
        }
    }
}
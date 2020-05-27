using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
             Celular lg = new Celular();
            lg.modelo = "LGK10";
            lg.cor = "Cor preta";
            lg.tamanho = "Tamanho médio";
            lg.ligado = true;
         

            Console.WriteLine(lg.modelo);
            Console.WriteLine(lg.cor);
            Console.WriteLine(lg.tamanho);

            Console.WriteLine("Deseja ligar o celular");
            lg.ligado = lg.Ligar(Console.ReadLine());

            ///
            /// tomada de decisão
            /// 
            Console.WriteLine("Escolha uma das opções: Enviar Mensagem(M),Fazer ligação(L), Desligar(D)");
            string resposta = Console.ReadLine();
            switch(resposta){
                case "D":
                Console.WriteLine("Desligando...");
                break;
                case "L":
                if(lg.ligado == true){
                    Console.WriteLine("Chamando...");
                }else{
                    Console.WriteLine("Não foi possivel realizar a chamada. Certifique-se se seu Telefone está ligado.");
                }
                break;
                case "M":
                if(lg.ligado == true){
                     Console.WriteLine("Digite sua mensagem:");
                     string respostaMensagem = Console.ReadLine();
                }else{
                    Console.WriteLine("Não foi possivel mandar mensagem. Certifique-se se seu Telefone está ligado");
                }
                break;
                default:
                Console.WriteLine("Opção não encontrada");
                break;
            }   
        }
    }
}

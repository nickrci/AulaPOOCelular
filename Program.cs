using System;

namespace AulaPOOCelular
{
    class Program
    {

        static void Main(string[] args)
        {

            Celular celular = new Celular();

            string ligando;
            string sistema = "";
            string msg;
            string lig;
            string inf;
            bool condição = false;




            Console.WriteLine("Deseja ligar o celular? s/n");
            ligando = Console.ReadLine();

            if (ligando == "s")
            {

                Console.WriteLine("\nLigando Celular...");

                do
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write($@"

|=============================|
|    {DateTime.Now}     |
|_____________________________|  
|                             |
|       Celular Ligado        |
|_____________________________| 
|                             |
|        Tela inicial         |
|                             |
|   1 - Mandar mensagem       |
|                             |
|   2 - Ligar                 |
|                             |
|   3 - Informações do Celular|
|                             |
|   4 - Deligar               |
|                             |
|                             |
|                             |
|=============================|
");
                    Console.ForegroundColor = ConsoleColor.White;
                    sistema = Console.ReadLine();

                    switch (sistema)
                    {
                        case "1":


                            Console.WriteLine("Digite sua mensagem: ");
                            msg = Console.ReadLine();

                            Console.WriteLine("Enviado!");
                            celular.ligar();
                            break;

                        case "2":
                            // Console.WriteLine("  Ligando... Sem Sinal!!!");
                            // celular.ligar();
                            // break;


                            Console.WriteLine("Disque o numero: ");
                            lig = Console.ReadLine();

                            Console.WriteLine("Ligando...");
                            Console.WriteLine("infelizmente está sem sinal, tente novamente mais tarde!!!");

                            break;

                        case "3":


                            Console.WriteLine($"Nome: {celular.nome}");
                            Console.WriteLine($"Modelo: {celular.modelo}");
                            Console.WriteLine($"Cor: {celular.cor}");
                            Console.WriteLine($"Tamanho da tela: {celular.tela}");

                            Console.WriteLine("\nAperte para continuar \n");
                            inf = Console.ReadLine();


                            break;

                        case "4":

                            Console.ForegroundColor = ConsoleColor.DarkBlue;

                            Console.Write($@"

|=============================|
|    {DateTime.Now}     |
|_____________________________|  
|                             |
|      Celular desligado      |
|_____________________________| 
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|                             |
|=============================|
");
                            condição = true;
                            break;

                        default:
                            break;
                    }


                } while (!condição);
            }
            else
            {

                Console.WriteLine("Ok.");
                celular.desligado();

            }



            celular.desligado();
        }





    }
    
}




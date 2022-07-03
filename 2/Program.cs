using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2 – Fazer um programa para que mostre uma lista de cidades para o usuário 
            e que ele informe o código da cidade escolhida. Em seguida pedir uma data para o usuário. 
            Ao final deve ser apresentada em tela a data completa em formato extenso longo, juntamente com a cidade escolhida. 
            Exemplo: Bragança Paulista, 29 de junho de 2022.

            A relação das cidades é a seguinte:

            1 – Atibaia 2 – Bragança Paulista  3 – Mairiporã 4 – Nazaré 5 – Terra Preta 6 – Extrema 7 – Vargem

            Requisitos: Criar uma função para converter a data em extenso. */

            int cidade, dia, mes, ano;
            string cidadeextenso, mesextenso;
            bool status;


            Console.Write("Lista de cidades: \n1. Atibaia \n2. Bragança Paulista \n3. Mairiporã \n4.Nazaré \n5.Terra Preta \n6. Extrema \n7. Vargem \nEscolha a cidade digitando um número de 1 a 7: ");
            cidade = int.Parse(Console.ReadLine());
            cidadeextenso = null;
            status = false;


            switch (cidade)
            {
                case 1:
                    cidadeextenso = "Atibaia";
                    status = true;
                    break;
                case 2:
                    cidadeextenso = "Bragança Paulista";
                    status = true;
                    break;
                case 3:
                    cidadeextenso = "Mairiporã";
                    status = true;
                    break;
                case 4:
                    cidadeextenso = "Nazaré";
                    status = true;
                    break;
                case 5:
                    cidadeextenso = "Terra Preta";
                    status = true;
                    break;
                case 6:
                    cidadeextenso = "Extrema";
                    status = true;
                    break;
                case 7:
                    cidadeextenso = "Vargem";
                    status = true;
                    break;
                default:
                    Console.WriteLine("Este valor não é válido.");
                    status = false;
                    break;
            }

            if (status == true)
            {



                Console.Write("Digite uma data no formato DD/MM/AAAA: ");
                var data = Convert.ToDateTime(Console.ReadLine());
                dia = data.Day;
                mes = data.Month;
                ano = data.Year;
                mesextenso = null;


                switch (mes)
                {
                    case 01:
                        mesextenso = "Janeiro";

                        break;
                    case 02:
                        mesextenso = "Fevereiro";

                        break;
                    case 03:
                        mesextenso = "Março";

                        break;
                    case 04:
                        mesextenso = "Abril";

                        break;
                    case 05:
                        mesextenso = "Maio";

                        break;
                    case 06:
                        mesextenso = "Junho";

                        break;
                    case 07:
                        mesextenso = "Julho";

                        break;
                    case 08:
                        mesextenso = "Agosto";

                        break;
                    case 09:
                        mesextenso = "Setembro";

                        break;
                    case 10:
                        mesextenso = "Outubro";

                        break;
                    case 11:
                        mesextenso = "Novembro";
                        break;
                    case 12:
                        mesextenso = "Dezembro";
                        break;
                    default:
                        Console.WriteLine("O mês não é válido.");
                        break;
                }

                Console.WriteLine(cidadeextenso + ", " + dia + " de " + mesextenso + " de " + ano + ".");
                Console.ReadKey();

            }
            else
            {
                Console.ReadKey();
            }

        }
    }
}

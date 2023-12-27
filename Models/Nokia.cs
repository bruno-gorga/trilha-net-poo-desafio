using System.Threading;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }



        public override void InstalarAplicativo(string nomeApp)
        {

            
            

            for (int i = 60; i != 0; i--)
            {
                Console.Clear();
                Console.WriteLine("=================================================");
                Console.WriteLine($"INSTALANDO APLICATIVO {nomeApp}...");
                Console.WriteLine("");
                Console.WriteLine("                Tempo Restante:  " + i.ToString() + "s");
                Console.WriteLine("");
                Console.WriteLine("=================================================");
                Thread.Sleep(500);
            }
            Console.WriteLine($"O aplicativo '{nomeApp}' foi instalado com sucesso!");
        }
    }
}
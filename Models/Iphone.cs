using System.Threading;


namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {

        public Iphone (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {

                string barraDeCarregamento = "***";
                for(int i = 0; i <= 100; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"INSTALANDO APLICATIVO {nomeApp}");
                    Console.WriteLine(barraDeCarregamento);
                    Console.WriteLine(barraDeCarregamento);
                    Console.WriteLine($"{i} % CONCLUÍDO...");
                    if (i % 10 == 0)
                    {
                    barraDeCarregamento = barraDeCarregamento + "*****";
                    }
                    Thread.Sleep(350);
                }
            
                Console.WriteLine($"O aplicativo '{nomeApp}' foi instalado com sucesso!");
        }
    }
}
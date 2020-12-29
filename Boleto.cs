using System;

namespace Abstração_9_12
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        private DateTime dataDoPagamento;

        public void Registrar(){
            
            Console.WriteLine("Registrado");
        }

        public override string Desconto(int valor)
        {
            return "";
        }

    
    }
}
using System;

namespace Abstração_9_12
{
    public  abstract class Pagamento
    {
        // Atributos
        private DateTime data;

        protected float valor; 
        private DateTime vencimento;
       
        // Métodos
        public string Cancelar(){
            return "";
        }

        // Obrigatório abstract
        public  abstract string Desconto(int valor);
        
        
        

        
    }
}
using System;

namespace OOP
{
    // Poli-Morfismo
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) : base(nome, voltagem) { }

        public CafeteiraEspressa() : base(nome: "Padrão", voltagem: 220) { }

        private static void AquecerAgua() { }
        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            //ETC...
        }

        public override void Testar()
        {
            //Testar a cafeteira
        }

        public override void Ligar()
        {
            //Verificar recipiente de agua
        }
        
         public override void Desligar()
        {
            //Resfriar aquecedor
        }
    }
}
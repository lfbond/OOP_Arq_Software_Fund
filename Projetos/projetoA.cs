using System.Reflection;
using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ProjetoB")] // ao usar esse comando algumas das classes se tornam acessiveis de outro projeto completo 
namespace ProjetoA
{
    //casses

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    public sealed class Selada { } //so pode ser instanciada e nunca herdada
    class Privada { }
    internal class Interna { }

    abstract class Abstrata { }


    //testes
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido(); //tem que herdar para pode chamar
            //publica.TestePrivadoProtegido(); //tem que herdar para pode chamar ou chamar interno
            //publica.TestePrivado(); //só pode chamar interno
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            var publica = new Publica();

            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado(); // somente metodo interno consegue chamar
        }
    }
}
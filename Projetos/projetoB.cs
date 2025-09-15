using ProjetoA;

namespace ProjetoB
{
    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            //var privada = new Privada();
            //var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            //publica.TesteInternal();
            //publica.TesteProtegidoInterno();
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
            TesteProtegido();
            TesteProtegidoInterno();
            //TesteInternal();
            //TestePrivadoProtegido();
            //TestePrivado(); // somente metodo interno consegue chamar
        }
    }
}
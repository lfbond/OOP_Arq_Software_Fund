namespace OOP
{
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            //adicionar itens
        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            //adicionar itens
        }
    }

    public class UsoImplementacao //caso tenha alguma modificação na interface o código aqui quebra
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao //caso tenha alguma modificação na interface o código aqui NÃO quebra
    {
        private readonly IRepositorio _repositorio;
        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }

}
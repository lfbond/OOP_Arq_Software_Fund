using System;
using Microsoft.VisualBasic;
using ProjetoA;

namespace OOP
{
    //CASO 1
    public class PessoaFisica : Pessoa //herança
    {
        public string? Cpf { get; set; }
    }

    public class PessoaFisica2 //composição
    {
        public Pessoa? Pessoa { get; set; }
        public string? Cpf { get; set; }
    }

    public class TestesHerancaCompsicao
    {
        public TestesHerancaCompsicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "João",
                DataNascimento = DateTime.Now,
                Cpf = "32165498722"
            };


            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "João",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "32165498722"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }

    }

    //CASO 2
    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }
        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TestesHerancaCompsicao2
    {
        public TestesHerancaCompsicao2()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());
        }
    }
}
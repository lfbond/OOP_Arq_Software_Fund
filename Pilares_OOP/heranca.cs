using System;

namespace OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string? Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var Funcionario = new Funcionario()
            {
                Nome = "João da Silva",
                DataNascimento = Convert.ToDateTime(value: "1990/01/02"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };
        }
    }
}
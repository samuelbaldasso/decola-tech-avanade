using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public abstract class ContaBancaria
    {
        public int NumeroConta { get; init; }
        public int DigitoVerificador { get; init; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataAbertura { get; private set; }
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }

        public ContaBancaria(Cliente cliente)
        {
            this.Cliente = cliente ?? throw new Exception();
            Random r = new Random();
            NumeroConta = r.Next(50000, 100000);
            DigitoVerificador = r.Next(0, 9);

            Situacao = SituacaoConta.Criada;
        }
        public void Abrir(string senha)
        {
            SetaSenha(senha);
            Situacao = SituacaoConta.Aberta;
            DataAbertura = DateTime.Now;
        }
        public virtual void Sacar(decimal valor, string senha) 
        {
            if (Senha != senha) 
            {
                throw new Exception("Senha invalida");
            }
            if (Saldo < valor) 
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }
        public void Depositar(decimal valor) 
        {
            if (valor <= 0) 
            {
                throw new Exception("Valor para deposito deve ser maior que 0!");
            }
            Saldo += valor;
        }
        public void SetaSenha(string senha)
        {
            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))
            {
                throw new Exception("Senha invalida");
            }
            Senha = senha;
        }
    }
}

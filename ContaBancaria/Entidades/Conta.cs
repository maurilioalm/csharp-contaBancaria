using ContaBancaria.Entidades.Exceptions;

namespace ContaBancaria.Entidades
{
    class Conta
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Conta()
        {
        }

        public Conta(int numeroConta, string nome, double saldo, double limiteDeSaque)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Saque(double valor)
        {
            if (Saldo > valor && valor <= LimiteDeSaque)
            {
                Saldo -= valor;
            }
            else if (Saldo < valor)
            {
                throw new DomainException("Sem saldo suficiente");
            }
            else
            {
                throw new DomainException("Limite de saque excedido");
            }
        }

    }
}

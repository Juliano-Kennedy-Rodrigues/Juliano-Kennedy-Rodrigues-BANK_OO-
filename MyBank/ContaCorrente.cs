public class ContaCorrente
{
		public string Titular { get; set; }
		public int Agencia { get; set; }
		public int Conta { get; set; }

		public static int TotaldeContasCriadas { get; set; } //static: atrelado a classe e nao ao objeto
		public static double TotaldeComissao {get; set; }

		private double _saldo;
		public double Saldo { 
			get
			{
				return this._saldo;
			}
			set
			{
				if(value >= 0)
				{
					this._saldo = value;
				}
			}
		}


	public ContaCorrente() {}

	public ContaCorrente(string titular, int agencia, double saldo, Funcionario funcionario)
	{
			this.Titular = titular;
			this.Agencia = agencia;
			this.Saldo = saldo;

			TotaldeContasCriadas ++;
			TotaldeComissao += saldo*0.01;
			funcionario.Comissao += saldo*0.01;
	}

	public bool Sacar(double valor)
	{
		if(this.Saldo < valor)
		{
			return false;
		}
		else
		{
			this.Saldo -= valor;
			return true;
		}
	}
	
	public void Depositar(double valor)
	{
		this.Saldo += valor;
	}

	public bool Transferir(double valor, ContaCorrente contaDestino)
	{
		if(this.Saldo < valor)
		{
			return false;
		}
		else
		{
			this.Sacar(valor);
			contaDestino.Depositar(valor);
			return true;
		}
	}
}
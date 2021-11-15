public abstract class Funcionario : PessoaFisica{

    public double Salario {get; set; }

    public double Comissao {get; set; }

    public string Nome {get; set; }

    public string CPF {get; set; }

    protected double _bonificacao;

    public virtual double Bonificacao{
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += Salario *0.01;
        }
    }

    public abstract int CalcularFerias();

    public double RemuneracaoTotal(double Salario){
        return Salario * 12 + Salario; //td mes mais decimo terceiro
    }

    public double RemuneracaoTotal(double Salario, double Bonificacao){
        return Salario * 12 + Salario + Bonificacao;
    }
    
}
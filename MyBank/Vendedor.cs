public class Vendedor : Funcionario{
    public int ClientesAtendidos { get; set; } 

    public override double Bonificacao{
        get
        {
            return _bonificacao;
        }
        set
        {
            _bonificacao += value * 0.02;
        }
    }

    public override int CalcularFerias(){
        var dias_ferias = 20+ClientesAtendidos *1                                    ;
        return dias_ferias;
    }
}
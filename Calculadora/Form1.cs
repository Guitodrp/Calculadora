namespace Calculadora;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    #region Enum
    private enum Operacao
    {
        Subtracao,
        Divisao,
        Multiplicacao,
        Soma
    }

    #endregion

    #region Campos

    private Operacao Operador { get; set; }
    public decimal Resultado { get; set; }
    public decimal Valor { get; set; }

    #endregion

    #region Operações
    private void Porcentagem_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(console.Text))
        {
            decimal valorAtual = Convert.ToDecimal(console.Text);
            console.Text = (Valor * valorAtual / 100).ToString();
        }
        console.Text = string.Empty;
        operacaoAtual.Text = "%";

    }
    private void Divisao_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(console.Text))
        {
            Operador = Operacao.Divisao;
            Valor = Convert.ToDecimal(console.Text);
            console.Text = string.Empty;
            operacaoAtual.Text = "/";
        }
    }
    private void Multiplicacao_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(console.Text))
        {
            Operador = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(console.Text);
            console.Text = string.Empty;
            operacaoAtual.Text = "x";
        }
    }
    private void Subtracao_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(console.Text))
        {
            Operador = Operacao.Subtracao;
            Valor = Convert.ToDecimal(console.Text);
            console.Text = string.Empty;
            operacaoAtual.Text = "-";
        }
    }
    private void Soma_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(console.Text))
        {
            Operador = Operacao.Soma;
            Valor = Convert.ToDecimal(console.Text);
            console.Text = string.Empty;
            operacaoAtual.Text = "+";
        }
    }

    #endregion

    #region Funcionalidades

    private void Igual_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(console.Text))
        {
            decimal valorAtual = Convert.ToDecimal(console.Text);

            switch (Operador)
            {
                case Operacao.Soma:
                    Resultado = Valor + valorAtual;
                    break;
                case Operacao.Divisao:
                    if (valorAtual != 0)
                        Resultado = Valor / valorAtual;
                    else
                        console.Text = string.Empty;
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * valorAtual;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - valorAtual;
                    break;
            }
            console.Text = Resultado.ToString();
            operacaoAtual.Text = "=";
        }
    }
    private void Clean_Click(object sender, EventArgs e)
    {
        console.Text = string.Empty;
        operacaoAtual.Text = string.Empty;
    }

    #endregion

    #region Números
    private void Zerozero_Click(object sender, EventArgs e)
    {
        console.Text += "00";
    }
    private void Zero_Click(object sender, EventArgs e)
    {
        console.Text += "0";

    }
    private void Um_Click(object sender, EventArgs e)
    {
        console.Text += "1";

    }
    private void Dois_Click(object sender, EventArgs e)
    {
        console.Text += "2";

    }
    private void Tres_Click(object sender, EventArgs e)
    {
        console.Text += "3";

    }
    private void Quatro_Click(object sender, EventArgs e)
    {
        console.Text += "4";

    }
    private void Cinco_Click(object sender, EventArgs e)
    {
        console.Text += "5";

    }
    private void Seis_Click(object sender, EventArgs e)
    {
        console.Text += "6";

    }
    private void Sete_Click(object sender, EventArgs e)
    {
        console.Text += "7";

    }
    private void Oito_Click(object sender, EventArgs e)
    {
        console.Text += "8";

    }
    private void Nove_Click(object sender, EventArgs e)
    {
        console.Text += "9";

    }
    private void Virgula_Click(object sender, EventArgs e)
    {
        if (console.Text.Length > 0 && !console.Text.Contains(','))
            console.Text += ",";
    }

    #endregion
}

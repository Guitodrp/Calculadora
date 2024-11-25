namespace Calculadora;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    #region Operações
    private void porcentagem_Click(object sender, EventArgs e)
    {

    }

    private void divisao_Click(object sender, EventArgs e)
    {

    }

    private void multiplicacao_Click(object sender, EventArgs e)
    {

    }


    private void subtracao_Click(object sender, EventArgs e)
    {

    }

    private void soma_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region Funcionalidades

    private void igual_Click(object sender, EventArgs e)
    {

    }

    private void clean_Click(object sender, EventArgs e)
    {
        console.Text = string.Empty;
    }

    private void console_TextChanged(object sender, EventArgs e)
    {

    }

    #endregion

    #region Números
    private void zerozero_Click(object sender, EventArgs e)
    {
        console.Text += "00";
    }
    private void zero_Click(object sender, EventArgs e)
    {
        console.Text += "0";

    }

    private void um_Click(object sender, EventArgs e)
    {
        console.Text += "1";

    }

    private void dois_Click(object sender, EventArgs e)
    {
        console.Text += "2";

    }

    private void tres_Click(object sender, EventArgs e)
    {
        console.Text += "3";

    }

    private void quatro_Click(object sender, EventArgs e)
    {
        console.Text += "4";

    }

    private void cinco_Click(object sender, EventArgs e)
    {
        console.Text += "5";

    }

    private void seis_Click(object sender, EventArgs e)
    {
        console.Text += "6";

    }
    private void sete_Click(object sender, EventArgs e)
    {
        console.Text += "7";

    }

    private void oito_Click(object sender, EventArgs e)
    {
        console.Text += "8";

    }

    private void nove_Click(object sender, EventArgs e)
    {
        console.Text += "9";

    }
    private void virgula_Click(object sender, EventArgs e)
    {
        console.Text += ",";

    }

    #endregion

}

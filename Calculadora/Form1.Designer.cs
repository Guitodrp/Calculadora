namespace Calculadora;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        porcentagem = new Button();
        console = new TextBox();
        clean = new Button();
        divisao = new Button();
        nove = new Button();
        oito = new Button();
        sete = new Button();
        multiplicacao = new Button();
        seis = new Button();
        cinco = new Button();
        quatro = new Button();
        igual = new Button();
        soma = new Button();
        tres = new Button();
        dois = new Button();
        um = new Button();
        subtracao = new Button();
        zerozero = new Button();
        zero = new Button();
        virgula = new Button();
        SuspendLayout();
        // 
        // porcentagem
        // 
        porcentagem.Location = new Point(12, 122);
        porcentagem.Name = "porcentagem";
        porcentagem.Size = new Size(68, 67);
        porcentagem.TabIndex = 0;
        porcentagem.Text = "%";
        porcentagem.UseVisualStyleBackColor = true;
        porcentagem.Click += porcentagem_Click;
        // 
        // console
        // 
        console.Location = new Point(13, 12);
        console.Name = "console";
        console.Size = new Size(289, 23);
        console.TabIndex = 3;
        console.TextChanged += console_TextChanged;
        // 
        // clean
        // 
        clean.Location = new Point(234, 122);
        clean.Name = "clean";
        clean.Size = new Size(68, 67);
        clean.TabIndex = 4;
        clean.Text = "c";
        clean.UseVisualStyleBackColor = true;
        clean.Click += clean_Click;
        // 
        // divisao
        // 
        divisao.Location = new Point(86, 122);
        divisao.Name = "divisao";
        divisao.Size = new Size(68, 67);
        divisao.TabIndex = 9;
        divisao.Text = "/";
        divisao.UseVisualStyleBackColor = true;
        divisao.Click += divisao_Click;
        // 
        // nove
        // 
        nove.Location = new Point(160, 195);
        nove.Name = "nove";
        nove.Size = new Size(68, 67);
        nove.TabIndex = 8;
        nove.Text = "9";
        nove.UseVisualStyleBackColor = true;
        nove.Click += nove_Click;
        // 
        // oito
        // 
        oito.Location = new Point(85, 195);
        oito.Name = "oito";
        oito.Size = new Size(68, 67);
        oito.TabIndex = 7;
        oito.Text = "8";
        oito.UseVisualStyleBackColor = true;
        oito.Click += oito_Click;
        // 
        // sete
        // 
        sete.Location = new Point(11, 195);
        sete.Name = "sete";
        sete.Size = new Size(68, 67);
        sete.TabIndex = 6;
        sete.Text = "7";
        sete.UseVisualStyleBackColor = true;
        sete.Click += sete_Click;
        // 
        // multiplicacao
        // 
        multiplicacao.Location = new Point(159, 122);
        multiplicacao.Name = "multiplicacao";
        multiplicacao.Size = new Size(68, 67);
        multiplicacao.TabIndex = 14;
        multiplicacao.Text = "x";
        multiplicacao.UseVisualStyleBackColor = true;
        multiplicacao.Click += multiplicacao_Click;
        // 
        // seis
        // 
        seis.Location = new Point(160, 268);
        seis.Name = "seis";
        seis.Size = new Size(68, 67);
        seis.TabIndex = 13;
        seis.Text = "6";
        seis.UseVisualStyleBackColor = true;
        seis.Click += seis_Click;
        // 
        // cinco
        // 
        cinco.Location = new Point(86, 268);
        cinco.Name = "cinco";
        cinco.Size = new Size(68, 67);
        cinco.TabIndex = 12;
        cinco.Text = "5";
        cinco.UseVisualStyleBackColor = true;
        cinco.Click += cinco_Click;
        // 
        // quatro
        // 
        quatro.Location = new Point(12, 268);
        quatro.Name = "quatro";
        quatro.Size = new Size(68, 67);
        quatro.TabIndex = 11;
        quatro.Text = "4";
        quatro.UseVisualStyleBackColor = true;
        quatro.Click += quatro_Click;
        // 
        // igual
        // 
        igual.Location = new Point(234, 341);
        igual.Name = "igual";
        igual.Size = new Size(68, 140);
        igual.TabIndex = 20;
        igual.Text = "=";
        igual.UseVisualStyleBackColor = true;
        igual.Click += igual_Click;
        // 
        // soma
        // 
        soma.Location = new Point(233, 268);
        soma.Name = "soma";
        soma.Size = new Size(68, 67);
        soma.TabIndex = 19;
        soma.Text = "+";
        soma.UseVisualStyleBackColor = true;
        soma.Click += soma_Click;
        // 
        // tres
        // 
        tres.Location = new Point(159, 341);
        tres.Name = "tres";
        tres.Size = new Size(68, 67);
        tres.TabIndex = 18;
        tres.Text = "3";
        tres.UseVisualStyleBackColor = true;
        tres.Click += tres_Click;
        // 
        // dois
        // 
        dois.Location = new Point(85, 341);
        dois.Name = "dois";
        dois.Size = new Size(68, 67);
        dois.TabIndex = 17;
        dois.Text = "2";
        dois.UseVisualStyleBackColor = true;
        dois.Click += dois_Click;
        // 
        // um
        // 
        um.Location = new Point(11, 341);
        um.Name = "um";
        um.Size = new Size(68, 67);
        um.TabIndex = 16;
        um.Text = "1";
        um.UseVisualStyleBackColor = true;
        um.Click += um_Click;
        // 
        // subtracao
        // 
        subtracao.Location = new Point(234, 195);
        subtracao.Name = "subtracao";
        subtracao.Size = new Size(68, 67);
        subtracao.TabIndex = 24;
        subtracao.Text = "-";
        subtracao.UseVisualStyleBackColor = true;
        subtracao.Click += subtracao_Click;
        // 
        // zerozero
        // 
        zerozero.Location = new Point(159, 414);
        zerozero.Name = "zerozero";
        zerozero.Size = new Size(68, 67);
        zerozero.TabIndex = 23;
        zerozero.Text = "00";
        zerozero.UseVisualStyleBackColor = true;
        zerozero.Click += zerozero_Click;
        // 
        // zero
        // 
        zero.Location = new Point(85, 414);
        zero.Name = "zero";
        zero.Size = new Size(68, 67);
        zero.TabIndex = 22;
        zero.Text = "0";
        zero.UseVisualStyleBackColor = true;
        zero.Click += zero_Click;
        // 
        // virgula
        // 
        virgula.Location = new Point(11, 414);
        virgula.Name = "virgula";
        virgula.Size = new Size(68, 67);
        virgula.TabIndex = 21;
        virgula.Text = ",";
        virgula.UseVisualStyleBackColor = true;
        virgula.Click += virgula_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(316, 500);
        Controls.Add(subtracao);
        Controls.Add(zerozero);
        Controls.Add(zero);
        Controls.Add(virgula);
        Controls.Add(igual);
        Controls.Add(soma);
        Controls.Add(tres);
        Controls.Add(dois);
        Controls.Add(um);
        Controls.Add(multiplicacao);
        Controls.Add(seis);
        Controls.Add(cinco);
        Controls.Add(quatro);
        Controls.Add(divisao);
        Controls.Add(nove);
        Controls.Add(oito);
        Controls.Add(sete);
        Controls.Add(clean);
        Controls.Add(console);
        Controls.Add(porcentagem);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button porcentagem;
    private TextBox console;
    private Button clean;
    private Button divisao;
    private Button nove;
    private Button oito;
    private Button sete;
    private Button multiplicacao;
    private Button seis;
    private Button cinco;
    private Button quatro;
    private Button igual;
    private Button soma;
    private Button tres;
    private Button dois;
    private Button um;
    private Button subtracao;
    private Button zerozero;
    private Button zero;
    private Button virgula;
}

namespace InimigoDaTiaDeMatematica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOpcao = new System.Windows.Forms.Label();
            this.cmbBxOpcao = new System.Windows.Forms.ComboBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.txtBxValor1 = new System.Windows.Forms.TextBox();
            this.txtBxValor2 = new System.Windows.Forms.TextBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.txtBxValor3 = new System.Windows.Forms.TextBox();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFormula = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblBaskara = new System.Windows.Forms.Label();
            this.lblXLinha = new System.Windows.Forms.Label();
            this.lblXDuasLinha = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // lblOpcao
            // 
            this.lblOpcao.AutoSize = true;
            this.lblOpcao.Location = new System.Drawing.Point(13, 13);
            this.lblOpcao.Name = "lblOpcao";
            this.lblOpcao.Size = new System.Drawing.Size(114, 13);
            this.lblOpcao.TabIndex = 0;
            this.lblOpcao.Text = "Escolha uma Formula !";
            // 
            // cmbBxOpcao
            // 
            this.cmbBxOpcao.FormattingEnabled = true;
            this.cmbBxOpcao.Items.AddRange(new object[] {
            "Equação Do Primeiro Grau",
            "Equação Do Segundo Grau",
            "Pitagoras Hipotenusa",
            "Pitagoras Cateto Oposto",
            "Pitagoras Cateto Adjacente",
            "Porcentagem",
            "Velocidade Media Espaço Inicial - Final",
            "Velocidade Media Tempo Inicial - Final",
            "Velocidade Media Tempo / Espaço",
            "Aceleração",
            "Conversão de Fahrenheit para Celsius",
            "Conversão de Celsius para Fahrenheit",
            "Hidrostatica - Pressão",
            "Hidrostarica - Densidade",
            "Matematica Financeira - Juros Simples",
            "Matematica Financeira - Juros Compostos",
            "Matematica Financeira - Montente"});
            this.cmbBxOpcao.Location = new System.Drawing.Point(13, 30);
            this.cmbBxOpcao.Name = "cmbBxOpcao";
            this.cmbBxOpcao.Size = new System.Drawing.Size(185, 21);
            this.cmbBxOpcao.TabIndex = 1;
            this.cmbBxOpcao.SelectedIndexChanged += new System.EventHandler(this.cmbBxOpcao_SelectedIndexChanged);
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(13, 92);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(43, 13);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Valor 1:";
            this.lblValor1.Visible = false;
            // 
            // txtBxValor1
            // 
            this.txtBxValor1.Location = new System.Drawing.Point(16, 109);
            this.txtBxValor1.Name = "txtBxValor1";
            this.txtBxValor1.Size = new System.Drawing.Size(111, 20);
            this.txtBxValor1.TabIndex = 3;
            this.txtBxValor1.Visible = false;
            // 
            // txtBxValor2
            // 
            this.txtBxValor2.Location = new System.Drawing.Point(16, 157);
            this.txtBxValor2.Name = "txtBxValor2";
            this.txtBxValor2.Size = new System.Drawing.Size(111, 20);
            this.txtBxValor2.TabIndex = 5;
            this.txtBxValor2.Visible = false;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(13, 141);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(43, 13);
            this.lblValor2.TabIndex = 4;
            this.lblValor2.Text = "Valor 2:";
            this.lblValor2.Visible = false;
            // 
            // txtBxValor3
            // 
            this.txtBxValor3.Location = new System.Drawing.Point(16, 203);
            this.txtBxValor3.Name = "txtBxValor3";
            this.txtBxValor3.Size = new System.Drawing.Size(111, 20);
            this.txtBxValor3.TabIndex = 7;
            this.txtBxValor3.Visible = false;
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(13, 186);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(43, 13);
            this.lblValor3.TabIndex = 6;
            this.lblValor3.Text = "Valor 3:";
            this.lblValor3.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFormula
            // 
            this.lblFormula.AutoSize = true;
            this.lblFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormula.Location = new System.Drawing.Point(562, 13);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(207, 31);
            this.lblFormula.TabIndex = 9;
            this.lblFormula.Text = "Formula Padrão";
            this.lblFormula.Visible = false;
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCalculo.Location = new System.Drawing.Point(583, 80);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(84, 25);
            this.lblCalculo.TabIndex = 10;
            this.lblCalculo.Text = "Calculo";
            this.lblCalculo.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblResultado.Location = new System.Drawing.Point(583, 129);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(109, 25);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            // 
            // lblBaskara
            // 
            this.lblBaskara.AutoSize = true;
            this.lblBaskara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblBaskara.Location = new System.Drawing.Point(583, 186);
            this.lblBaskara.Name = "lblBaskara";
            this.lblBaskara.Size = new System.Drawing.Size(91, 25);
            this.lblBaskara.TabIndex = 12;
            this.lblBaskara.Text = "Baskara";
            this.lblBaskara.Visible = false;
            // 
            // lblXLinha
            // 
            this.lblXLinha.AutoSize = true;
            this.lblXLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblXLinha.Location = new System.Drawing.Point(583, 236);
            this.lblXLinha.Name = "lblXLinha";
            this.lblXLinha.Size = new System.Drawing.Size(33, 25);
            this.lblXLinha.TabIndex = 13;
            this.lblXLinha.Text = "X¹";
            this.lblXLinha.Visible = false;
            // 
            // lblXDuasLinha
            // 
            this.lblXDuasLinha.AutoSize = true;
            this.lblXDuasLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblXDuasLinha.Location = new System.Drawing.Point(583, 278);
            this.lblXDuasLinha.Name = "lblXDuasLinha";
            this.lblXDuasLinha.Size = new System.Drawing.Size(40, 25);
            this.lblXDuasLinha.TabIndex = 14;
            this.lblXDuasLinha.Text = "X¹¹";
            this.lblXDuasLinha.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 389);
            this.Controls.Add(this.lblXDuasLinha);
            this.Controls.Add(this.lblXLinha);
            this.Controls.Add(this.lblBaskara);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBxValor3);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.txtBxValor2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.txtBxValor1);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.cmbBxOpcao);
            this.Controls.Add(this.lblOpcao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.ComboBox cmbBxOpcao;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.TextBox txtBxValor1;
        private System.Windows.Forms.TextBox txtBxValor2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtBxValor3;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblBaskara;
        private System.Windows.Forms.Label lblXLinha;
        private System.Windows.Forms.Label lblXDuasLinha;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}


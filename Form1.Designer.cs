namespace Horizzon3REnergySysPDFtoXML
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GerarDados = new System.Windows.Forms.Button();
            this.btnExtrair = new System.Windows.Forms.Button();
            this.btnGerarXML = new System.Windows.Forms.Button();
            this.AlarmeBranco = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCompVazao = new System.Windows.Forms.TextBox();
            this.txtCodInstalacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEstimado = new System.Windows.Forms.Button();
            this.txtAG = new System.Windows.Forms.TextBox();
            this.txtInstalacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.CbxPeroa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbxReconcavo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFicha = new System.Windows.Forms.Button();
            this.btnBSW = new System.Windows.Forms.Button();
            this.txtBSW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxValido = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAbertura = new System.Windows.Forms.Button();
            this.btnFechamento = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPocoDataX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXSS = new System.Windows.Forms.Button();
            this.cbxPocoAbre = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Horizzon3REnergySysPDFtoXML.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GerarDados
            // 
            this.GerarDados.Location = new System.Drawing.Point(12, 130);
            this.GerarDados.Name = "GerarDados";
            this.GerarDados.Size = new System.Drawing.Size(47, 35);
            this.GerarDados.TabIndex = 1;
            this.GerarDados.Text = "Gerar Dados";
            this.GerarDados.UseVisualStyleBackColor = true;
            this.GerarDados.Visible = true;
            this.GerarDados.Click += new System.EventHandler(this.GerarDados_Click);
            // 
            // btnExtrair
            // 
            this.btnExtrair.Location = new System.Drawing.Point(65, 96);
            this.btnExtrair.Name = "btnExtrair";
            this.btnExtrair.Size = new System.Drawing.Size(38, 35);
            this.btnExtrair.TabIndex = 2;
            this.btnExtrair.Text = "Extrair";
            this.btnExtrair.UseVisualStyleBackColor = true;
            this.btnExtrair.Visible = true;
            this.btnExtrair.Click += new System.EventHandler(this.btnExtrair_Click);
            // 
            // btnGerarXML
            // 
            this.btnGerarXML.Location = new System.Drawing.Point(12, 96);
            this.btnGerarXML.Name = "btnGerarXML";
            this.btnGerarXML.Size = new System.Drawing.Size(47, 35);
            this.btnGerarXML.TabIndex = 3;
            this.btnGerarXML.Text = "Gerar XML";
            this.btnGerarXML.UseVisualStyleBackColor = true;
            this.btnGerarXML.Visible = true;
            this.btnGerarXML.Click += new System.EventHandler(this.btnGerarXML_Click);
            // 
            // AlarmeBranco
            // 
            this.AlarmeBranco.Location = new System.Drawing.Point(3, 106);
            this.AlarmeBranco.Name = "AlarmeBranco";
            this.AlarmeBranco.Size = new System.Drawing.Size(227, 35);
            this.AlarmeBranco.TabIndex = 4;
            this.AlarmeBranco.Text = "Gerar Alarme e Evento Em Branco";
            this.AlarmeBranco.UseVisualStyleBackColor = true;
            this.AlarmeBranco.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(186, 12);
            this.monthCalendar1.MaxSelectionCount = 365;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 54);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gerar Alarmes e Eventos Unificado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCompVazao
            // 
            this.txtCompVazao.Location = new System.Drawing.Point(94, 54);
            this.txtCompVazao.Name = "txtCompVazao";
            this.txtCompVazao.Size = new System.Drawing.Size(132, 20);
            this.txtCompVazao.TabIndex = 7;
            // 
            // txtCodInstalacao
            // 
            this.txtCodInstalacao.Location = new System.Drawing.Point(94, 80);
            this.txtCodInstalacao.Name = "txtCodInstalacao";
            this.txtCodInstalacao.Size = new System.Drawing.Size(132, 20);
            this.txtCodInstalacao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cod do CV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cod da Instalação:";
            // 
            // btnEstimado
            // 
            this.btnEstimado.Location = new System.Drawing.Point(10, 167);
            this.btnEstimado.Name = "btnEstimado";
            this.btnEstimado.Size = new System.Drawing.Size(271, 35);
            this.btnEstimado.TabIndex = 11;
            this.btnEstimado.Text = "Estimado";
            this.btnEstimado.UseVisualStyleBackColor = true;
            this.btnEstimado.Click += new System.EventHandler(this.btnEstimado_Click);
            // 
            // txtAG
            // 
            this.txtAG.Location = new System.Drawing.Point(91, 89);
            this.txtAG.Name = "txtAG";
            this.txtAG.Size = new System.Drawing.Size(190, 20);
            this.txtAG.TabIndex = 12;
            this.txtAG.Text = "EST-3138.00-CONS_UDM";
            // 
            // txtInstalacao
            // 
            this.txtInstalacao.Location = new System.Drawing.Point(91, 115);
            this.txtInstalacao.Name = "txtInstalacao";
            this.txtInstalacao.Size = new System.Drawing.Size(190, 20);
            this.txtInstalacao.TabIndex = 13;
            this.txtInstalacao.Text = "00000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "AG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Instalação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Produção:";
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(91, 141);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(190, 20);
            this.txtProducao.TabIndex = 16;
            this.txtProducao.Text = "0,000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Estimados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Alarmes:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.CbxPeroa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CbxReconcavo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnEstimado);
            this.panel1.Controls.Add(this.txtAG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtInstalacao);
            this.panel1.Controls.Add(this.txtProducao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 218);
            this.panel1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Peroa:";
            // 
            // CbxPeroa
            // 
            this.CbxPeroa.FormattingEnabled = true;
            this.CbxPeroa.Location = new System.Drawing.Point(91, 60);
            this.CbxPeroa.Name = "CbxPeroa";
            this.CbxPeroa.Size = new System.Drawing.Size(190, 21);
            this.CbxPeroa.TabIndex = 26;
            this.CbxPeroa.SelectedIndexChanged += new System.EventHandler(this.CbxPeroa_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Reconcavo:";
            // 
            // CbxReconcavo
            // 
            this.CbxReconcavo.FormattingEnabled = true;
            this.CbxReconcavo.Location = new System.Drawing.Point(91, 33);
            this.CbxReconcavo.Name = "CbxReconcavo";
            this.CbxReconcavo.Size = new System.Drawing.Size(190, 21);
            this.CbxReconcavo.TabIndex = 24;
            this.CbxReconcavo.SelectedIndexChanged += new System.EventHandler(this.CbxReconcavo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AlarmeBranco);
            this.panel2.Controls.Add(this.txtCompVazao);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCodInstalacao);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(315, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 158);
            this.panel2.TabIndex = 21;
            // 
            // btnFicha
            // 
            this.btnFicha.Location = new System.Drawing.Point(9, 112);
            this.btnFicha.Name = "btnFicha";
            this.btnFicha.Size = new System.Drawing.Size(134, 52);
            this.btnFicha.TabIndex = 22;
            this.btnFicha.Text = "Teste de Poço";
            this.btnFicha.UseVisualStyleBackColor = true;
            this.btnFicha.Click += new System.EventHandler(this.btnFicha_Click);
            // 
            // btnXSS
            // 
            this.btnXSS.Location = new System.Drawing.Point(633, 326);
            this.btnXSS.Name = "btnXSS";
            this.btnXSS.Size = new System.Drawing.Size(134, 52);
            this.btnXSS.TabIndex = 36;
            this.btnXSS.Text = "TP - Cangoa";
            this.btnXSS.UseVisualStyleBackColor = true;
            this.btnXSS.Click += new System.EventHandler(this.btnXSS_Click);
            // 
            // btnBSW
            // 
            this.btnBSW.Location = new System.Drawing.Point(483, 96);
            this.btnBSW.Name = "btnBSW";
            this.btnBSW.Size = new System.Drawing.Size(134, 52);
            this.btnBSW.TabIndex = 23;
            this.btnBSW.Text = "BSW";
            this.btnBSW.UseVisualStyleBackColor = true;
            this.btnBSW.Click += new System.EventHandler(this.btnBSW_Click);
            // 
            // txtBSW
            // 
            this.txtBSW.Location = new System.Drawing.Point(483, 76);
            this.txtBSW.Name = "txtBSW";
            this.txtBSW.Size = new System.Drawing.Size(46, 20);
            this.txtBSW.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "BSW:";
            // 
            // cbxValido
            // 
            this.cbxValido.FormattingEnabled = true;
            this.cbxValido.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxValido.Location = new System.Drawing.Point(9, 22);
            this.cbxValido.Name = "cbxValido";
            this.cbxValido.Size = new System.Drawing.Size(134, 21);
            this.cbxValido.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Valido:";
            // 
            // btnAbertura
            // 
            this.btnAbertura.Location = new System.Drawing.Point(9, 112);
            this.btnAbertura.Name = "btnAbertura";
            this.btnAbertura.Size = new System.Drawing.Size(134, 52);
            this.btnAbertura.TabIndex = 30;
            this.btnAbertura.Text = "Abertura Poço";
            this.btnAbertura.UseVisualStyleBackColor = true;
            this.btnAbertura.Click += new System.EventHandler(this.btnAbertura_Click);
            // 
            // btnFechamento
            // 
            this.btnFechamento.Location = new System.Drawing.Point(9, 172);
            this.btnFechamento.Name = "btnFechamento";
            this.btnFechamento.Size = new System.Drawing.Size(134, 52);
            this.btnFechamento.TabIndex = 31;
            this.btnFechamento.Text = "Fechamento Poço";
            this.btnFechamento.UseVisualStyleBackColor = true;
            this.btnFechamento.Click += new System.EventHandler(this.btnFechamento_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Poço:";
            // 
            // txtPocoDataX
            // 
            this.txtPocoDataX.Location = new System.Drawing.Point(9, 78);
            this.txtPocoDataX.Name = "txtPocoDataX";
            this.txtPocoDataX.Size = new System.Drawing.Size(134, 20);
            this.txtPocoDataX.TabIndex = 35;
            this.txtPocoDataX.Text = "2024-01-01 00:00:00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Data:";
            // 
            // cbxPocoAbre
            // 
            this.cbxPocoAbre.FormattingEnabled = true;
            this.cbxPocoAbre.Location = new System.Drawing.Point(9, 22);
            this.cbxPocoAbre.Name = "cbxPocoAbre";
            this.cbxPocoAbre.Size = new System.Drawing.Size(134, 21);
            this.cbxPocoAbre.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbxPocoAbre);
            this.panel3.Controls.Add(this.txtPocoDataX);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnFechamento);
            this.panel3.Controls.Add(this.btnAbertura);
            this.panel3.Location = new System.Drawing.Point(788, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 244);
            this.panel3.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cbxValido);
            this.panel4.Controls.Add(this.btnFicha);
            this.panel4.Controls.Add(this.btnXSS);
            this.panel4.Location = new System.Drawing.Point(633, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 244);
            this.panel4.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "CNPJ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "02857854000114", //3R PETROLEUM OFFSHORE S.A.
            "03605739000115", //3R PESCADA S.A.
            "23018639000108", //3R CANDEIAS S.A.
            "52127214000127", //3R AREIA BRANCA S.A.
            "3609399100141"; //3R FAZENDA BELÉM S.A.
            "33443860000159", //3R MACAU S.A.
            "35156290000141"; //3R RIO VENTURA S.A.
            "44186763000144"}); //3R POTIGUAR S.A.
            this.comboBox1.Location = new System.Drawing.Point(483, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 412);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            //this.Controls.Add(this.btnXSS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBSW);
            this.Controls.Add(this.btnBSW);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnGerarXML);
            this.Controls.Add(this.btnExtrair);
            this.Controls.Add(this.GerarDados);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Horizzon: 3R Petroleum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form1_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GerarDados;
        private System.Windows.Forms.Button btnExtrair;
        private System.Windows.Forms.Button btnGerarXML;
        private System.Windows.Forms.Button AlarmeBranco;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCompVazao;
        private System.Windows.Forms.TextBox txtCodInstalacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstimado;
        private System.Windows.Forms.TextBox txtAG;
        private System.Windows.Forms.TextBox txtInstalacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFicha;
        private System.Windows.Forms.Button btnBSW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbxReconcavo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbxPeroa;
        private System.Windows.Forms.TextBox txtBSW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxValido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAbertura;
        private System.Windows.Forms.Button btnFechamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPocoDataX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXSS;
        private System.Windows.Forms.ComboBox cbxPocoAbre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


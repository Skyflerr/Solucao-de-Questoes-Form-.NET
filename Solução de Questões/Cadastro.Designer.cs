namespace Solução_de_Questões
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.DisciplinaSwitch = new System.Windows.Forms.ComboBox();
            this.DificuldadeSwitch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Enunciado = new System.Windows.Forms.TextBox();
            this.AlternativaBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GabaritoBox = new System.Windows.Forms.GroupBox();
            this.ButtonE = new System.Windows.Forms.RadioButton();
            this.ButtonD = new System.Windows.Forms.RadioButton();
            this.ButtonC = new System.Windows.Forms.RadioButton();
            this.ButtonB = new System.Windows.Forms.RadioButton();
            this.ButtonA = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Resolucao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.AlternativaBox.SuspendLayout();
            this.GabaritoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina";
            // 
            // DisciplinaSwitch
            // 
            this.DisciplinaSwitch.FormattingEnabled = true;
            this.DisciplinaSwitch.Items.AddRange(new object[] {
            "Engenharia de Software",
            "Banco de Dados",
            "Linguagem de Programacao IV",
            "Linguagem de Programacao III"});
            this.DisciplinaSwitch.Location = new System.Drawing.Point(92, 27);
            this.DisciplinaSwitch.Name = "DisciplinaSwitch";
            this.DisciplinaSwitch.Size = new System.Drawing.Size(192, 21);
            this.DisciplinaSwitch.TabIndex = 1;
            // 
            // DificuldadeSwitch
            // 
            this.DificuldadeSwitch.FormattingEnabled = true;
            this.DificuldadeSwitch.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.DificuldadeSwitch.Location = new System.Drawing.Point(418, 27);
            this.DificuldadeSwitch.Name = "DificuldadeSwitch";
            this.DificuldadeSwitch.Size = new System.Drawing.Size(162, 21);
            this.DificuldadeSwitch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enunciado";
            // 
            // Enunciado
            // 
            this.Enunciado.Location = new System.Drawing.Point(13, 92);
            this.Enunciado.Multiline = true;
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(543, 87);
            this.Enunciado.TabIndex = 4;
            // 
            // AlternativaBox
            // 
            this.AlternativaBox.Controls.Add(this.label7);
            this.AlternativaBox.Controls.Add(this.label6);
            this.AlternativaBox.Controls.Add(this.TextBoxE);
            this.AlternativaBox.Controls.Add(this.TextBoxD);
            this.AlternativaBox.Controls.Add(this.TextBoxC);
            this.AlternativaBox.Controls.Add(this.TextBoxB);
            this.AlternativaBox.Controls.Add(this.TextBoxA);
            this.AlternativaBox.Controls.Add(this.label5);
            this.AlternativaBox.Controls.Add(this.label4);
            this.AlternativaBox.Controls.Add(this.label3);
            this.AlternativaBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternativaBox.Location = new System.Drawing.Point(13, 200);
            this.AlternativaBox.Name = "AlternativaBox";
            this.AlternativaBox.Size = new System.Drawing.Size(543, 233);
            this.AlternativaBox.TabIndex = 5;
            this.AlternativaBox.TabStop = false;
            this.AlternativaBox.Text = "Alternativas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "E";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "D";
            // 
            // TextBoxE
            // 
            this.TextBoxE.Location = new System.Drawing.Point(26, 187);
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.Size = new System.Drawing.Size(490, 27);
            this.TextBoxE.TabIndex = 4;
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(27, 148);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(490, 27);
            this.TextBoxD.TabIndex = 4;
            // 
            // TextBoxC
            // 
            this.TextBoxC.Location = new System.Drawing.Point(26, 112);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(490, 27);
            this.TextBoxC.TabIndex = 4;
            // 
            // TextBoxB
            // 
            this.TextBoxB.Location = new System.Drawing.Point(26, 80);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(490, 27);
            this.TextBoxB.TabIndex = 4;
            // 
            // TextBoxA
            // 
            this.TextBoxA.Location = new System.Drawing.Point(26, 41);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(490, 27);
            this.TextBoxA.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "A";
            // 
            // GabaritoBox
            // 
            this.GabaritoBox.Controls.Add(this.ButtonE);
            this.GabaritoBox.Controls.Add(this.ButtonD);
            this.GabaritoBox.Controls.Add(this.ButtonC);
            this.GabaritoBox.Controls.Add(this.ButtonB);
            this.GabaritoBox.Controls.Add(this.ButtonA);
            this.GabaritoBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GabaritoBox.Location = new System.Drawing.Point(13, 454);
            this.GabaritoBox.Name = "GabaritoBox";
            this.GabaritoBox.Size = new System.Drawing.Size(543, 130);
            this.GabaritoBox.TabIndex = 6;
            this.GabaritoBox.TabStop = false;
            this.GabaritoBox.Text = "Alternativa Correta";
            // 
            // ButtonE
            // 
            this.ButtonE.AutoSize = true;
            this.ButtonE.Location = new System.Drawing.Point(410, 58);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(35, 24);
            this.ButtonE.TabIndex = 0;
            this.ButtonE.TabStop = true;
            this.ButtonE.Text = "E";
            this.ButtonE.UseVisualStyleBackColor = true;
            // 
            // ButtonD
            // 
            this.ButtonD.AutoSize = true;
            this.ButtonD.Location = new System.Drawing.Point(319, 58);
            this.ButtonD.Name = "ButtonD";
            this.ButtonD.Size = new System.Drawing.Size(38, 24);
            this.ButtonD.TabIndex = 0;
            this.ButtonD.TabStop = true;
            this.ButtonD.Text = "D";
            this.ButtonD.UseVisualStyleBackColor = true;
            // 
            // ButtonC
            // 
            this.ButtonC.AutoSize = true;
            this.ButtonC.Location = new System.Drawing.Point(218, 58);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(37, 24);
            this.ButtonC.TabIndex = 0;
            this.ButtonC.TabStop = true;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = true;
            // 
            // ButtonB
            // 
            this.ButtonB.AutoSize = true;
            this.ButtonB.Location = new System.Drawing.Point(127, 58);
            this.ButtonB.Name = "ButtonB";
            this.ButtonB.Size = new System.Drawing.Size(36, 24);
            this.ButtonB.TabIndex = 0;
            this.ButtonB.TabStop = true;
            this.ButtonB.Text = "B";
            this.ButtonB.UseVisualStyleBackColor = true;
            // 
            // ButtonA
            // 
            this.ButtonA.AutoSize = true;
            this.ButtonA.Location = new System.Drawing.Point(36, 58);
            this.ButtonA.Name = "ButtonA";
            this.ButtonA.Size = new System.Drawing.Size(38, 24);
            this.ButtonA.TabIndex = 0;
            this.ButtonA.TabStop = true;
            this.ButtonA.Text = "A";
            this.ButtonA.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Resolução";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 1067);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "label2";
            // 
            // Resolucao
            // 
            this.Resolucao.Location = new System.Drawing.Point(14, 625);
            this.Resolucao.Multiline = true;
            this.Resolucao.Name = "Resolucao";
            this.Resolucao.Size = new System.Drawing.Size(543, 87);
            this.Resolucao.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Dificuldade";
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(185, 729);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(217, 43);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Pronto";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 784);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GabaritoBox);
            this.Controls.Add(this.AlternativaBox);
            this.Controls.Add(this.Resolucao);
            this.Controls.Add(this.Enunciado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DificuldadeSwitch);
            this.Controls.Add(this.DisciplinaSwitch);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.AlternativaBox.ResumeLayout(false);
            this.AlternativaBox.PerformLayout();
            this.GabaritoBox.ResumeLayout(false);
            this.GabaritoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DisciplinaSwitch;
        private System.Windows.Forms.ComboBox DificuldadeSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Enunciado;
        private System.Windows.Forms.GroupBox AlternativaBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxE;
        private System.Windows.Forms.TextBox TextBoxD;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GabaritoBox;
        private System.Windows.Forms.RadioButton ButtonE;
        private System.Windows.Forms.RadioButton ButtonD;
        private System.Windows.Forms.RadioButton ButtonC;
        private System.Windows.Forms.RadioButton ButtonB;
        private System.Windows.Forms.RadioButton ButtonA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Resolucao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SendButton;
    }
}
namespace Solução_de_Questões
{
    partial class Resolucao
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
            this.label11 = new System.Windows.Forms.Label();
            this.DificuldadeSwitch = new System.Windows.Forms.ComboBox();
            this.DisciplinaSwitch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnunciadoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlternativaBox = new System.Windows.Forms.GroupBox();
            this.LabelE = new System.Windows.Forms.Label();
            this.LabelD = new System.Windows.Forms.Label();
            this.LabelC = new System.Windows.Forms.Label();
            this.LabelB = new System.Windows.Forms.Label();
            this.LabelA = new System.Windows.Forms.Label();
            this.E = new System.Windows.Forms.RadioButton();
            this.D = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.A = new System.Windows.Forms.RadioButton();
            this.ResolucaoBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ResponderButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.AlternativaCorretaLabel = new System.Windows.Forms.Label();
            this.AlternativaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(488, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Dificuldade";
            // 
            // DificuldadeSwitch
            // 
            this.DificuldadeSwitch.FormattingEnabled = true;
            this.DificuldadeSwitch.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.DificuldadeSwitch.Location = new System.Drawing.Point(585, 33);
            this.DificuldadeSwitch.Name = "DificuldadeSwitch";
            this.DificuldadeSwitch.Size = new System.Drawing.Size(162, 21);
            this.DificuldadeSwitch.TabIndex = 11;
            // 
            // DisciplinaSwitch
            // 
            this.DisciplinaSwitch.Items.AddRange(new object[] {
            "Engenharia de Software",
            "Banco de Dados",
            "Linguagem de Programacao IV",
            "Linguagem de Programacao III"});
            this.DisciplinaSwitch.Location = new System.Drawing.Point(278, 34);
            this.DisciplinaSwitch.Name = "DisciplinaSwitch";
            this.DisciplinaSwitch.Size = new System.Drawing.Size(192, 21);
            this.DisciplinaSwitch.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Disciplina";
            // 
            // EnunciadoBox
            // 
            this.EnunciadoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnunciadoBox.Location = new System.Drawing.Point(20, 84);
            this.EnunciadoBox.Multiline = true;
            this.EnunciadoBox.Name = "EnunciadoBox";
            this.EnunciadoBox.Size = new System.Drawing.Size(893, 87);
            this.EnunciadoBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enunciado";
            // 
            // AlternativaBox
            // 
            this.AlternativaBox.Controls.Add(this.LabelE);
            this.AlternativaBox.Controls.Add(this.LabelD);
            this.AlternativaBox.Controls.Add(this.LabelC);
            this.AlternativaBox.Controls.Add(this.LabelB);
            this.AlternativaBox.Controls.Add(this.LabelA);
            this.AlternativaBox.Controls.Add(this.E);
            this.AlternativaBox.Controls.Add(this.D);
            this.AlternativaBox.Controls.Add(this.C);
            this.AlternativaBox.Controls.Add(this.B);
            this.AlternativaBox.Controls.Add(this.A);
            this.AlternativaBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternativaBox.Location = new System.Drawing.Point(21, 190);
            this.AlternativaBox.Name = "AlternativaBox";
            this.AlternativaBox.Size = new System.Drawing.Size(892, 263);
            this.AlternativaBox.TabIndex = 15;
            this.AlternativaBox.TabStop = false;
            this.AlternativaBox.Text = "Alternativas";
            // 
            // LabelE
            // 
            this.LabelE.AutoSize = true;
            this.LabelE.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelE.Location = new System.Drawing.Point(57, 205);
            this.LabelE.Name = "LabelE";
            this.LabelE.Size = new System.Drawing.Size(0, 19);
            this.LabelE.TabIndex = 6;
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelD.Location = new System.Drawing.Point(57, 161);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(0, 19);
            this.LabelD.TabIndex = 6;
            // 
            // LabelC
            // 
            this.LabelC.AutoSize = true;
            this.LabelC.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelC.Location = new System.Drawing.Point(57, 119);
            this.LabelC.Name = "LabelC";
            this.LabelC.Size = new System.Drawing.Size(0, 19);
            this.LabelC.TabIndex = 6;
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelB.Location = new System.Drawing.Point(57, 80);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(0, 19);
            this.LabelB.TabIndex = 6;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelA.Location = new System.Drawing.Point(57, 39);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(0, 19);
            this.LabelA.TabIndex = 6;
            // 
            // E
            // 
            this.E.AutoSize = true;
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E.Location = new System.Drawing.Point(6, 205);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(35, 20);
            this.E.TabIndex = 1;
            this.E.TabStop = true;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D.Location = new System.Drawing.Point(6, 161);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(36, 20);
            this.D.TabIndex = 2;
            this.D.TabStop = true;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(6, 120);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(35, 20);
            this.C.TabIndex = 3;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.Location = new System.Drawing.Point(6, 81);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(35, 20);
            this.B.TabIndex = 4;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A.Location = new System.Drawing.Point(6, 40);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(35, 20);
            this.A.TabIndex = 5;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // ResolucaoBox
            // 
            this.ResolucaoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResolucaoBox.Location = new System.Drawing.Point(183, 510);
            this.ResolucaoBox.Multiline = true;
            this.ResolucaoBox.Name = "ResolucaoBox";
            this.ResolucaoBox.Size = new System.Drawing.Size(564, 87);
            this.ResolucaoBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Resolução";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(183, 614);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(287, 49);
            this.StartButton.TabIndex = 18;
            this.StartButton.Text = "Gerar uma questão";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResponderButton
            // 
            this.ResponderButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponderButton.Location = new System.Drawing.Point(476, 614);
            this.ResponderButton.Name = "ResponderButton";
            this.ResponderButton.Size = new System.Drawing.Size(271, 49);
            this.ResponderButton.TabIndex = 18;
            this.ResponderButton.Text = "Responder";
            this.ResponderButton.UseVisualStyleBackColor = true;
            this.ResponderButton.Click += new System.EventHandler(this.ResponderButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(183, 683);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // AlternativaCorretaLabel
            // 
            this.AlternativaCorretaLabel.AutoSize = true;
            this.AlternativaCorretaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlternativaCorretaLabel.Location = new System.Drawing.Point(294, 455);
            this.AlternativaCorretaLabel.Name = "AlternativaCorretaLabel";
            this.AlternativaCorretaLabel.Size = new System.Drawing.Size(0, 25);
            this.AlternativaCorretaLabel.TabIndex = 22;
            // 
            // Resolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 733);
            this.Controls.Add(this.AlternativaCorretaLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ResponderButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ResolucaoBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AlternativaBox);
            this.Controls.Add(this.EnunciadoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DificuldadeSwitch);
            this.Controls.Add(this.DisciplinaSwitch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Resolucao";
            this.ShowIcon = false;
            this.AlternativaBox.ResumeLayout(false);
            this.AlternativaBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DificuldadeSwitch;
        private System.Windows.Forms.ComboBox DisciplinaSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnunciadoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox AlternativaBox;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.RadioButton E;
        private System.Windows.Forms.RadioButton D;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.Label LabelE;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.Label LabelC;
        private System.Windows.Forms.Label LabelB;
        private System.Windows.Forms.TextBox ResolucaoBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ResponderButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label AlternativaCorretaLabel;
    }
}
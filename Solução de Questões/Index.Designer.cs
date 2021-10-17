namespace Solução_de_Questões
{
    partial class Index
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
            this.MenuLabel = new System.Windows.Forms.Label();
            this.SelectionBox = new System.Windows.Forms.GroupBox();
            this.ResponderButton = new System.Windows.Forms.Button();
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.ModesBox = new System.Windows.Forms.GroupBox();
            this.RandomButton = new System.Windows.Forms.Button();
            this.PalaceButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.SelectionBox.SuspendLayout();
            this.ModesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.Location = new System.Drawing.Point(221, 72);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(122, 46);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "Menu";
            // 
            // SelectionBox
            // 
            this.SelectionBox.Controls.Add(this.ResponderButton);
            this.SelectionBox.Controls.Add(this.CadastrarButton);
            this.SelectionBox.Location = new System.Drawing.Point(25, 121);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(514, 202);
            this.SelectionBox.TabIndex = 1;
            this.SelectionBox.TabStop = false;
            this.SelectionBox.Text = "Seleção";
            // 
            // ResponderButton
            // 
            this.ResponderButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResponderButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponderButton.Location = new System.Drawing.Point(150, 114);
            this.ResponderButton.Name = "ResponderButton";
            this.ResponderButton.Size = new System.Drawing.Size(213, 48);
            this.ResponderButton.TabIndex = 1;
            this.ResponderButton.Text = "Responder";
            this.ResponderButton.UseVisualStyleBackColor = false;
            this.ResponderButton.Click += new System.EventHandler(this.ResponderButton_Click);
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CadastrarButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarButton.Location = new System.Drawing.Point(150, 31);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(213, 48);
            this.CadastrarButton.TabIndex = 0;
            this.CadastrarButton.Text = "Cadastrar ";
            this.CadastrarButton.UseVisualStyleBackColor = false;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // ModesBox
            // 
            this.ModesBox.Controls.Add(this.RandomButton);
            this.ModesBox.Controls.Add(this.PalaceButton);
            this.ModesBox.Controls.Add(this.TimeButton);
            this.ModesBox.Location = new System.Drawing.Point(25, 339);
            this.ModesBox.Name = "ModesBox";
            this.ModesBox.Size = new System.Drawing.Size(514, 168);
            this.ModesBox.TabIndex = 2;
            this.ModesBox.TabStop = false;
            this.ModesBox.Text = "Modos";
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RandomButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomButton.Location = new System.Drawing.Point(354, 58);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(148, 56);
            this.RandomButton.TabIndex = 0;
            this.RandomButton.Text = "Pergunta Aleatoria";
            this.RandomButton.UseVisualStyleBackColor = false;
            // 
            // PalaceButton
            // 
            this.PalaceButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PalaceButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalaceButton.Location = new System.Drawing.Point(181, 58);
            this.PalaceButton.Name = "PalaceButton";
            this.PalaceButton.Size = new System.Drawing.Size(148, 56);
            this.PalaceButton.TabIndex = 0;
            this.PalaceButton.Text = "Q.I Palace";
            this.PalaceButton.UseVisualStyleBackColor = false;
            // 
            // TimeButton
            // 
            this.TimeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TimeButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeButton.Location = new System.Drawing.Point(12, 58);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(148, 56);
            this.TimeButton.TabIndex = 0;
            this.TimeButton.Text = "Time Trial";
            this.TimeButton.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 571);
            this.Controls.Add(this.ModesBox);
            this.Controls.Add(this.SelectionBox);
            this.Controls.Add(this.MenuLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Index";
            this.Opacity = 0.91D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.SelectionBox.ResumeLayout(false);
            this.ModesBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.GroupBox SelectionBox;
        private System.Windows.Forms.Button ResponderButton;
        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.GroupBox ModesBox;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button PalaceButton;
    }
}
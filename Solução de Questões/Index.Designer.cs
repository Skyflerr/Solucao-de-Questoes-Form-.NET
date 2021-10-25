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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.MenuLabel = new System.Windows.Forms.Label();
            this.PalaceButton = new System.Windows.Forms.Button();
            this.ResponderButton = new System.Windows.Forms.Button();
            this.CadastrarButton = new System.Windows.Forms.Button();
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
            // PalaceButton
            // 
            this.PalaceButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PalaceButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PalaceButton.Location = new System.Drawing.Point(176, 309);
            this.PalaceButton.Name = "PalaceButton";
            this.PalaceButton.Size = new System.Drawing.Size(213, 48);
            this.PalaceButton.TabIndex = 0;
            this.PalaceButton.Text = "Q.I Palace";
            this.PalaceButton.UseVisualStyleBackColor = false;
            this.PalaceButton.Click += new System.EventHandler(this.PalaceButton_Click);
            // 
            // ResponderButton
            // 
            this.ResponderButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResponderButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponderButton.Location = new System.Drawing.Point(176, 219);
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
            this.CadastrarButton.Location = new System.Drawing.Point(176, 152);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(213, 48);
            this.CadastrarButton.TabIndex = 0;
            this.CadastrarButton.Text = "Cadastrar ";
            this.CadastrarButton.UseVisualStyleBackColor = false;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.PalaceButton);
            this.Controls.Add(this.ResponderButton);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.CadastrarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Index";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button ResponderButton;
        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.Button PalaceButton;
    }
}
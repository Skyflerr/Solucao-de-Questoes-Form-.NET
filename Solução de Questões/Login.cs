using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Solução_de_Questões
{
    public partial class Login : Form
    {
        Index y = new Index();

        public Login()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines(Global.GetUsersPath()).ToList().IndexOf(UsernameTextbox.Text) == File.ReadAllLines(Global.GetPasswordsPath()).ToList().IndexOf(PasswordTextbox.Text) && File.ReadAllLines(Global.GetUsersPath()).ToList().Contains(UsernameTextbox.Text))
            {
                Global._GlobalRankedName = UsernameTextbox.Text;
                MessageBox.Show("Logado :D");
                this.Hide();
                y.ShowDialog();
            }

            if (File.ReadAllLines(Global.GetUsersPath()).ToList().IndexOf(UsernameTextbox.Text) != File.ReadAllLines(Global.GetPasswordsPath()).ToList().IndexOf(PasswordTextbox.Text) || !File.ReadAllLines(Global.GetUsersPath()).ToList().Contains(UsernameTextbox.Text))
            {
                MessageBox.Show("Algo deu errado, Cheque as senhas :/");
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
                
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            if (File.ReadAllText(Global.GetUsersPath()).ToString().Contains(UsernameTextbox.Text) == true)
            {
                MessageBox.Show("Opa Já usaram esse nome, vamos precisar de mais criatividade");
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
            
            else if (File.ReadAllText(Global.GetUsersPath()).ToString().Contains(UsernameTextbox.Text) == false)
            {
                File.AppendAllText(Global.GetUsersPath(), "\n" + UsernameTextbox.Text);
                File.AppendAllText(Global.GetPasswordsPath(), "\n" + PasswordTextbox.Text);
                MessageBox.Show("Pronto :D");
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextbox.PasswordChar = '*';
        }
    }
}

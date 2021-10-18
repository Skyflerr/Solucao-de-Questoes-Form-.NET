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

        string BackupStringNames = File.ReadAllText(GetUsersPath()).ToString();
        string BackupStringPasswords = File.ReadAllText(GetPasswordsPath()).ToString();

        public Login()
        {
            InitializeComponent();
        }

        public static string GetUsersPath()
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            return CurrentDirectory.Remove(72) + @"\Source\Users\Users.txt";
        }
        
        public static string GetPasswordsPath()
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            return CurrentDirectory.Remove(72) + @"\Source\Users\Passwords.txt";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            if (File.ReadAllText(GetUsersPath()).ToString().Contains(UsernameTextbox.Text) == true)
            {
                MessageBox.Show("Opa Já usaram esse nome, vamos precisar de mais criatividade");
                UsernameTextbox.Text = "";
                PasswordTextbox.Text = "";
            }
            
            else if (File.ReadAllText(GetUsersPath()).ToString().Contains(UsernameTextbox.Text) == false)
            {
                File.AppendAllText(GetUsersPath(), "\n" + UsernameTextbox.Text);
                File.AppendAllText(GetPasswordsPath(), "\n" + PasswordTextbox.Text);
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

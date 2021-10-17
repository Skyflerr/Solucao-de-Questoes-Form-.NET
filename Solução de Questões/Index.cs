using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solução_de_Questões
{
    public partial class Index : Form
    {
        Cadastro y = new Cadastro();
        Resolucao x = new Resolucao();
        public Index()
        {
            InitializeComponent();
        }


        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            y.ShowDialog();
        }

        private void ResponderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            x.ShowDialog();
        }
    }
}

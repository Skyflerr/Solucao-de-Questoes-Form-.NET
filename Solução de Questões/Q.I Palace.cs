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
    public partial class Q : Form
    {
        public Q()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo x = new DirectoryInfo(Global.GetHardDifficulty(Global.RandomizeSubject()));
            FileInfo[] files = x.GetFiles("*.txt");
            string FileAux = "";
            foreach (FileInfo File in files)
                FileAux = FileAux + ", " + File.Name;

            Random rnd = new Random();
            List<string> Data = File.ReadAllLines(Global.GetHardDifficulty(Global.RandomizeSubject()) + @"\00" + rnd.Next(1, int.Parse(Global.ReverseString(FileAux)[4].ToString()) + 1).ToString() + ".txt").ToList();

            EnunciadoBox.Text = Data[0];
            A.Text = Data[1];
            B.Text = Data[2];
            C.Text = Data[3];
            D.Text = Data[4];
            E.Text = Data[5];
            Global._GlobalResolucao = Data[6];
            Global._GlobalAltCorreta = Data[7];
        }

        private void ResponderButton_Click(object sender, EventArgs e)
        {
            string AlternativaMarcada = "";

            if (A.Checked == true)
            {
                AlternativaMarcada = A.Name;
                A.Checked = false;
            }


            if (B.Checked == true)
            {
                AlternativaMarcada = B.Name;
                B.Checked = false;
            }

            if (C.Checked == true)
            {
                AlternativaMarcada = C.Name;
                C.Checked = false;
            }

            if (D.Checked == true)
            {
                AlternativaMarcada = D.Name;
                D.Checked = false;
            }

            if (E.Checked == true)
            {
                AlternativaMarcada = E.Name;
                E.Checked = false;
            }

            ResolucaoBox.Text = Global._GlobalResolucao;

            if (AlternativaMarcada == Global._GlobalAltCorreta)
            {
                Global._GlobalAcertos++;
                MessageBox.Show("Alternativa Correta");
                progressBar1.Value += 10;

                if (progressBar1.Value == 100)
                {
                    MessageBox.Show("O Palacio chegou ao fim \n Sera reconhecido como o grande " + Global._GlobalRankedName + "\n com um total de " + Global._GlobalAcertos + "  Acertos");
                }

                DirectoryInfo x = new DirectoryInfo(Global.GetHardDifficulty(Global.RandomizeSubject()));
                FileInfo[] files = x.GetFiles("*.txt");
                string FileAux = "";
                foreach (FileInfo File in files)
                    FileAux = FileAux + ", " + File.Name;
                Random rnd = new Random();
                string subkeep = Global.RandomizeSubject();

                List<string> Data = File.ReadAllLines(Global.GetHardDifficulty(Global.RandomizeSubject()) + @"\00" + rnd.Next(1, int.Parse(Global.ReverseString(FileAux)[4].ToString()) + 1).ToString() + ".txt").ToList();

                EnunciadoBox.Text = Data[0];
                A.Text = Data[1];
                B.Text = Data[2];
                C.Text = Data[3];
                D.Text = Data[4];
                E.Text = Data[5];
                Global._GlobalResolucao = Data[6];
                Global._GlobalAltCorreta = Data[7];
                ResolucaoBox.Text = "";

            }
            else if (AlternativaMarcada != Global._GlobalAltCorreta)
            {
                int LifeSpam = int.Parse(LifeSpamCount.Text);
                LifeSpam--;
                LifeSpamCount.Text = LifeSpam.ToString();

                if (LifeSpam == 0)
                {
                    MessageBox.Show("O Palacio chegou ao fim \n Sera reconhecido como o grande " + Global._GlobalRankedName + "\n com um total de " + Global._GlobalAcertos + "  Acertos");
                    Index a = new Index();
                    this.Hide();
                    a.ShowDialog();
                }
                MessageBox.Show("Alternativa Errada");

                if (progressBar1.Value == 100)
                {
                    MessageBox.Show("O Palacio chegou ao fim \n Sera reconhecido como o grande " + Global._GlobalRankedName + "\n com um total de " + Global._GlobalAcertos + "  Acertos");
                }

                DirectoryInfo x = new DirectoryInfo(Global.GetHardDifficulty(Global.RandomizeSubject()));
                FileInfo[] files = x.GetFiles("*.txt");
                string FileAux = "";
                foreach (FileInfo File in files)
                    FileAux = FileAux + ", " + File.Name;
                Random rnd = new Random();
                string subkeep = Global.RandomizeSubject();

                List<string> Data = File.ReadAllLines(Global.GetHardDifficulty(Global.RandomizeSubject()) + @"\00" + rnd.Next(1, int.Parse(Global.ReverseString(FileAux)[4].ToString()) + 1).ToString() + ".txt").ToList();

                EnunciadoBox.Text = Data[0];
                A.Text = Data[1];
                B.Text = Data[2];
                C.Text = Data[3];
                D.Text = Data[4];
                E.Text = Data[5];
                Global._GlobalResolucao = Data[6];
                Global._GlobalAltCorreta = Data[7];
                ResolucaoBox.Text = "";

            }
        }
    }
}

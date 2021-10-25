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
    public partial class Resolucao : Form
    {
        public Resolucao()
        {
            InitializeComponent();
        }

        public static string GetEasyDifficulty(string Disciplina)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            string EasyDifficulty = CurrentDirectory.Remove(72) + @"\Source\" + Disciplina + @"\Facil";
            return EasyDifficulty;
        }

        public static string GetMediumDifficulty(string Disciplina)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            string MediumDifficulty = CurrentDirectory.Remove(72) + @"\Source\" + Disciplina + @"\Medio";
            return MediumDifficulty;
        }

        public static string GetHardDifficulty(string Disciplina)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            string HardDifficulty = CurrentDirectory.Remove(72) + @"\Source\" + Disciplina + @"\Dificil";
            return HardDifficulty;
        }

        public static string ReverseString(string CommunString)
        {
            char[] ReverseStringArray = CommunString.ToCharArray();
            Array.Reverse(ReverseStringArray);

            string ReversedString = "";

            foreach (char x in ReverseStringArray)
                ReversedString += x;

            return ReversedString;
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            ResolucaoBox.Text = "";
            AlternativaCorretaLabel.Text = "";
            switch (DificuldadeSwitch.Text)
            {
                case "Facil":
                    {
                        DirectoryInfo x = new DirectoryInfo(GetEasyDifficulty(DisciplinaSwitch.Text));
                        FileInfo[] files = x.GetFiles("*.txt");
                        string FileAux = "";
                        foreach (FileInfo File in files)
                            FileAux = FileAux + ", " + File.Name;

                        Random rnd = new Random(); 
                        List<string> Data = File.ReadAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + rnd.Next(1, int.Parse(ReverseString(FileAux)[4].ToString()) + 1).ToString() + ".txt").ToList();

                        EnunciadoBox.Text = Data[0];
                        A.Text = Data[1];
                        B.Text = Data[2];
                        C.Text = Data[3];
                        D.Text = Data[4];
                        E.Text = Data[5];
                        Global._GlobalResolucao = Data[6];
                        Global._GlobalAltCorreta = Data[7];
                        break;
                    }

                case "Medio":
                    {
                        DirectoryInfo x = new DirectoryInfo(GetMediumDifficulty(DisciplinaSwitch.Text));
                        FileInfo[] files = x.GetFiles("*.txt");
                        string FileAux = "";
                        foreach (FileInfo File in files)
                            FileAux = FileAux + ", " + File.Name;

                        Random rnd = new Random();
                        List<string> Data = File.ReadAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + rnd.Next(1, int.Parse(ReverseString(FileAux)[4].ToString()) + 1).ToString() + ".txt").ToList();

                        EnunciadoBox.Text = Data[0];
                        A.Text = Data[1];
                        B.Text = Data[2];
                        C.Text = Data[3];
                        D.Text = Data[4];
                        E.Text = Data[5];
                        Global._GlobalResolucao = Data[6];
                        Global._GlobalAltCorreta = Data[7];
                        break;
                    }

                case "Dificil":
                    {
                        DirectoryInfo x = new DirectoryInfo(GetHardDifficulty(DisciplinaSwitch.Text));
                        FileInfo[] files = x.GetFiles("*.txt");
                        string FileAux = "";
                        foreach (FileInfo File in files)
                            FileAux = FileAux + ", " + File.Name;

                        Random rnd = new Random();
                        List<string> Data = File.ReadAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + rnd.Next(1, int.Parse(ReverseString(FileAux)[4].ToString()) + 1).ToString() + ".txt").ToList();

                        EnunciadoBox.Text = Data[0];
                        A.Text = Data[1];
                        B.Text = Data[2];
                        C.Text = Data[3];
                        D.Text = Data[4];
                        E.Text = Data[5];
                        Global._GlobalResolucao = Data[6];
                        Global._GlobalAltCorreta = Data[7];
                        break;
                    }
            }
        }

        private void ResponderButton_Click(object sender, EventArgs e)
        {
            string AlternativaMarcada = "";

            if (A.Checked == true) {
                AlternativaMarcada = A.Name;
                A.Checked = false;
            }
                

            if (B.Checked == true) { 
                AlternativaMarcada = B.Name;
                B.Checked = false;
            }

            if (C.Checked == true) {
                AlternativaMarcada = C.Name;
                C.Checked = false;
            }

            if (D.Checked == true) { 
                AlternativaMarcada = D.Name;
                D.Checked = false;
            }

            if (E.Checked == true) {
                AlternativaMarcada = E.Name;
                E.Checked = false;
            }

            AlternativaCorretaLabel.Text = "A alternativa Correta é a " + Global._GlobalAltCorreta;
            ResolucaoBox.Text = Global._GlobalResolucao;

            if (AlternativaMarcada == Global._GlobalAltCorreta)
            {
                MessageBox.Show("Alternativa Correta");
                progressBar1.Value += 10;
            }

            else
            {
                MessageBox.Show("Alternativa Errada");
            }

            if (progressBar1.Value == 100)
            {
                MessageBox.Show("Completaste todas as perguntas possivel, és um genio");
                EnunciadoBox.Text = A.Text = B.Text = C.Text = D.Text = E.Text = ResolucaoBox.Text = "";
                Index x = new Index();
                x.ShowDialog();
            }
        }

    }
}

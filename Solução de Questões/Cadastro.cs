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
    public partial class Cadastro : Form
    {
        public Cadastro()
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

        private void SendButton_Click(object sender, EventArgs e)
        {
            string AltCorreta = "";

            foreach (Control x in GabaritoBox.Controls)
            {
                if (((RadioButton)x).Checked)
                    AltCorreta = x.Text;
            }

            string[] Data = { Enunciado.Text, TextBoxA.Text, TextBoxB.Text, TextBoxC.Text, TextBoxD.Text, TextBoxE.Text, Resolucao.Text, AltCorreta};
            int Lp4CountEasy = 1;


            // CADASTRO DE ENGENHARIA DE SOFTWARE POR DIFICULDADE

            if (DisciplinaSwitch.Text == "Engenharia de Software" && DificuldadeSwitch.Text == "Facil")
            {
                int EsCountEasy = 1;
                if (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt") == true)
                {
                    while(File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt") == true)
                    {
                        EsCountEasy++;
                    }

                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt") == true)
                {
                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }


            if (DisciplinaSwitch.Text == "Engenharia de Software" && DificuldadeSwitch.Text == "Medio")
            {
                int EsCountMedium = 1;
                if (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt") == true)
                    {
                        EsCountMedium++;
                    }

                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt") == true)
                {
                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }


            if (DisciplinaSwitch.Text == "Engenharia de Software" && DificuldadeSwitch.Text == "Dificil")
            {
                int EsCountHard = 1;
                if (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt") == true)
                    {
                        EsCountHard++;
                    }

                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt") == true)
                {
                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + EsCountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            // CADASTRO DE BANCO DE DADOS POR DIFICULADE 

            if (DisciplinaSwitch.Text == "Banco de Dados" && DificuldadeSwitch.Text == "Facil")
            {
                int BdCountEasy = 1;
                if (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt") == true)
                    {
                        BdCountEasy++;
                    }

                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt") == true)
                {
                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            if (DisciplinaSwitch.Text == "Banco de Dados" && DificuldadeSwitch.Text == "Medio")
            {
                int BdCountMedium = 1;
                if (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt") == true)
                    {
                        BdCountMedium++;
                    }

                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt") == true)
                {
                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            if (DisciplinaSwitch.Text == "Banco de Dados" && DificuldadeSwitch.Text == "Dificil")
            {
                int BdCountHard = 1;
                if (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt") == true)
                    {
                        BdCountHard++;
                    }

                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt") == true)
                {
                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + BdCountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            // CADASTRO DE LINGUAGEM DE PROGRAMAÇÃO III POR DIFICULDADE

            if (DisciplinaSwitch.Text == "Linguagem de Programacao III" && DificuldadeSwitch.Text == "Facil")
            {
                int LpCountEasy = 1;
                if (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt") == true)
                    {
                        LpCountEasy++;
                    }

                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt") == true)
                {
                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            if (DisciplinaSwitch.Text == "Linguagem de Programacao III" && DificuldadeSwitch.Text == "Medio")
            {
                int LpCountMedium = 1;
                if (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt") == true)
                    {
                        LpCountMedium++;
                    }

                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt") == true)
                {
                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            if (DisciplinaSwitch.Text == "Linguagem de Programacao III" && DificuldadeSwitch.Text == "Dificil")
            {
                int LpCountHard = 1;
                if (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt") == true)
                    {
                        LpCountHard++;
                    }

                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt") == true)
                {
                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + LpCountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            // CADASTRO DE LINGUAGEM DE PROGRAMAÇÃO IV POR DIFICULDADE

            if (DisciplinaSwitch.Text == "Linguagem de Programacao IV" && DificuldadeSwitch.Text == "Facil")
            {
                if (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt") == true)
                    {
                        Lp4CountEasy++;
                    }

                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
                else if (!File.Exists(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt") == true)
                {
                    File.Create(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt").Close();
                    File.WriteAllLines(GetEasyDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountEasy.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            if (DisciplinaSwitch.Text == "Linguagem de Programacao IV" && DificuldadeSwitch.Text == "Medio")
            {
                int Lp4CountMedium = 1;
                if (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt") == true)
                    {
                        Lp4CountMedium++;
                    }

                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt") == true)
                {
                    File.Create(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt").Close();
                    File.WriteAllLines(GetMediumDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountMedium.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }

            if (DisciplinaSwitch.Text == "Linguagem de Programacao IV" && DificuldadeSwitch.Text == "Dificil")
            {
                int Lp4CountHard = 1;
                if (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt") == true)
                {
                    while (File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt") == true)
                    {
                        Lp4CountHard++;
                    }

                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }

                else if (!File.Exists(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt") == true)
                {
                    File.Create(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt").Close();
                    File.WriteAllLines(GetHardDifficulty(DisciplinaSwitch.Text) + @"\00" + Lp4CountHard.ToString() + ".txt", Data);
                    DisciplinaSwitch.Text = DificuldadeSwitch.Text = Enunciado.Text = TextBoxA.Text = TextBoxB.Text = TextBoxC.Text = TextBoxD.Text = TextBoxE.Text = Resolucao.Text = "";
                    MessageBox.Show("Cadastrado :D");
                }
            }
        }
    }
}
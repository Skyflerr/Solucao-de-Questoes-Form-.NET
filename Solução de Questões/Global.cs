using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solução_de_Questões
{
    class Global
    {
        private static string _AltCorreta = "";
        private static string _Resolucao = "";
        private static string QiPalaceRankedNames = "";
        private static int Acertos = 0;

        public static int _GlobalAcertos
        {
            get { return Acertos; }
            set { Acertos = value; }
        }

        public static string _GlobalRankedName
        {
            get { return QiPalaceRankedNames; }
            set { QiPalaceRankedNames = value; }
        }
        public static string _GlobalAltCorreta
        {
            get { return _AltCorreta; }
            set { _AltCorreta = value; }
        }

        public static string _GlobalResolucao
        {
            get { return _Resolucao; }
            set { _Resolucao = value; }
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

        public static string ReverseString(string CommunString)
        {
            char[] ReverseStringArray = CommunString.ToCharArray();
            Array.Reverse(ReverseStringArray);

            string ReversedString = "";

            foreach (char x in ReverseStringArray)
                ReversedString += x;

            return ReversedString;
        }

        public static string RandomizeSubject()
        {
            Random Subject = new Random();
            int RandomSubject = Subject.Next(1, 5);

            switch (RandomSubject)
            {
                case 1:
                    return "Engenharia de Software";
                case 2:
                    return "Banco de Dados";
                case 3:
                    return "Linguagem de Programacao IV";
                case 4:
                    return "Linguagem de Programacao III";
            }
            return null;
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
    }
}

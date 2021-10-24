using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solução_de_Questões
{
    class Global
    {
        private static string _AltCorreta = "";
        private static string _Resolucao = "";

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulaOneDLL.dto
{
    public class circuitCard
    {
        private string date;
        private string codNaz;
        private string nameNaz;
        private string nameGranP;
        private string imgCircuit;

        public circuitCard(string date, string codNaz, string nameNaz, string nameGranP, string imgCircuit)
        {
            Date = date;
            ImgNaz = codNaz;
            NameNaz = nameNaz;
            NameGranP = nameGranP;
            ImgCircuit = imgCircuit;
        }

        public string Date { get => date; set => date = value; }
        public string ImgNaz { get => codNaz; set => codNaz = value; }
        public string NameNaz { get => nameNaz; set => nameNaz = value; }
        public string NameGranP { get => nameGranP; set => nameGranP = value; }
        public string ImgCircuit { get => imgCircuit; set => imgCircuit = value; }
    }
}

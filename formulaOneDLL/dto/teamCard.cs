using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulaOneDLL.dto
{
    public class teamCard
    {
        private int _teamId;
        private string _teamName;
        private string _imgLogo;
        private string _imgCar;
        private string _firstDriverName;
        private string _secondDriverName;

        public teamCard(int teamId, string teamName, string imgLogo, string imgCar, string firstDriverName, string secondDriverName)
        {
            TeamId = teamId;
            TeamName = teamName;
            ImgLogo = imgLogo;
            ImgCar = imgCar;
            FirstDriverName = firstDriverName;
            SecondDriverName = secondDriverName;
        }

        public int TeamId { get => _teamId; set => _teamId = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }
        public string ImgLogo { get => _imgLogo; set => _imgLogo = value; }
        public string ImgCar { get => _imgCar; set => _imgCar = value; }
        public string FirstDriverName { get => _firstDriverName; set => _firstDriverName = value; }
        public string SecondDriverName { get => _secondDriverName; set => _secondDriverName = value; }
    }
}

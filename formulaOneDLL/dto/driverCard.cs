using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulaOneDLL
{
    public class DriverCard
    {
        // PRIVATE CON UNDERSCORE DAVANTI
        // CTRL+.
        // INCAPSULA I CAMPI (e usa proprietà)
        private int _driverId;
        private string _driverFirstName;
        private string _driverLastName;
        private string _teamName;
        private string _countryCode;
        private string _countryFlag;
        private string _driverImage;
        private int _teamId;

        public DriverCard()
        {
        }

        public DriverCard(int driverId, string driverFirstName, string driverLastName, string teamName, string countryCode, string countryFlag, string driverImage, int teamId)
        {
            DriverId = driverId;
            DriverFirstName = driverFirstName;
            DriverLastName = driverLastName;
            TeamName = teamName;
            CountryCode = countryCode;
            CountryFlag = countryFlag;
            DriverImage = driverImage;
            TeamId = teamId;
        }

        public int DriverId { get => _driverId; set => _driverId = value; }
        public string DriverFirstName { get => _driverFirstName; set => _driverFirstName = value; }
        public string DriverLastName { get => _driverLastName; set => _driverLastName = value; }
        public string TeamName { get => _teamName; set => _teamName = value; }
        public string CountryCode { get => _countryCode; set => _countryCode = value; }
        public string CountryFlag { get => _countryFlag; set => _countryFlag = value; }
        public string DriverImage { get => _driverImage; set => _driverImage = value; }
        public int TeamId { get => _teamId; set => _teamId = value; }
    }
}

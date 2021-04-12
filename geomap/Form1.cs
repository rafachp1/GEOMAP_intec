using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geomap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            keyValues["CN"] = 102056;
            keyValues["US"] = 31197873;
            keyValues["IT"] = 3769814;
            keyValues["ES"] = 3347512;
            keyValues["IR"] = 2070141;
            keyValues["FR"] = 5119585;
            keyValues["GB"] = 4384610;
            keyValues["CA"] = 1067764;
            keyValues["PK"] = 725602;
            keyValues["IN"] = 13527717;
            keyValues["DO"] = 257698;
            keyValues["MX"] = 2280213;
            keyValues["BR"] = 13482023;
            keyValues["DE"] = 3012158;
            keyValues["PT"] = 827494;
            keyValues["JP"] = 506237;
            keyValues["AE"] = 483747;
            keyValues["AF"] = 57160;
            keyValues["AR"] = 2532562;
            keyValues["PE"] = 1647694;
            keyValues["CL"] = 1076499;
            keyValues["CO"] = 2536198;
            keyValues["RU"] = 4589209;
            keyValues["BO"] = 282095;
            keyValues["VE"] = 174887;
            keyValues["GY"] = 11149;
            keyValues["CU"] = 86531;
            keyValues["PA"] = 358611;
            keyValues["EC"] = 346817;
            keyValues["HN"] = 195780;
            keyValues["SV"] = 66489;
            keyValues["UY"] = 144642;
            keyValues["CR"] = 222544;
            keyValues["GT"] = 203071;
            keyValues["NI"] = 6727;
            keyValues["PY"] = 235292;
            keyValues["AU"] = 577007;
            keyValues["PH"] = 864868;
            keyValues["NZ"] = 2583;
            keyValues["PG"] = 8442;
            keyValues["MN"] = 15014;
            keyValues["KR"] = 110146;
            keyValues["KZ"] = 323207;
            keyValues["NO"] = 103621;
            keyValues["SE"] = 857401;
            keyValues["FI"] = 82053;
            keyValues["PL"] = 2574631;
            keyValues["RO"] = 1006167;
            keyValues["yf"] = 642208;
            keyValues["RY"] = 5357;
            keyValues["ZA"] = 1558458;
            keyValues["ZW"] = 37288;
            keyValues["SA"] = 398435;
            keyValues["OM"] = 171549;
            keyValues["NL"] = 1374451;
            keyValues["MM"] = 142576;
            keyValues["TH"] = 32625;
            keyValues["AM"] = 202817;
            keyValues["LY"] = 167825;
            keyValues["EG"] = 210489;
            keyValues["DK"] = 238484;
            keyValues["TR"] = 3849011;
            keyValues["SY"] = 20226;
            keyValues["UG"] = 41140;
            keyValues["NE"] = 5074;
            keyValues["NG"] = 163799;
            keyValues["NP"] = 280028;
            keyValues["SO"] = 12406;
            keyValues["SR"] = 9302;
            keyValues["TD"] = 4636;
            keyValues["ZM"] = 90029;
            keyValues["AO"] = 23457;
            keyValues["TZ"] = 509;
            keyValues["KE"] = 145670;
            keyValues["ET"] = 22996;
            keyValues["MG"] = 28063;
            keyValues["MZ"] = 68758;
            keyValues["SD"] = 31833;
            keyValues["UZ"] = 84922;
            keyValues["GW"] = 3680;
            keyValues["EE"] = 114174;
            keyValues["CM"] = 61731;
            keyValues["DZ"] = 118516;
            keyValues["ZR"] = 28542;
            keyValues["CF"] = 5491;
            keyValues["BW"] = 42674;
            keyValues["NA"] = 45527;
            keyValues["MA"] = 502102;
            keyValues["ML"] = 11844;
            keyValues["MR"] = 18022;
            keyValues["ER"] = 3447;
            keyValues["ID"] = 1566995;
            keyValues["IQ"] = 924946;
            keyValues["GN"] = 20949;
            keyValues["LT"] = 39431;
            keyValues["BG"] = 358611;
            keyValues["BI"] = 358611;
            keyValues["BJ"] = 577007;
            keyValues["BF"] = 358611;
            keyValues["BD"] = 358611;
            keyValues["QA"] = 358611;
            keyValues["RW"] = 358611;
            keyValues["-994"] = 358611;
            keyValues["SK"] = 358611;
            keyValues["SI"] = 358611;
            keyValues["TG"] = 358611;
            keyValues["TP"] = 358611;
            keyValues["-995"] = 358611;
            keyValues["BE"] = 358611;
            keyValues["GR"] = 358611;
            keyValues["BY"] = 358611;
            keyValues["UA"] = 358611;
  


            geoMap.HeatMap = keyValues;

            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
        }
    }
}

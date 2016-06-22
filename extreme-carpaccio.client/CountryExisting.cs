using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xCarpaccio.client
{
    class CountryExisting
    {
        public string[] TabCountry { get; set; }
        public decimal[] TabTax { get; set; }
        public CountryExisting()
        {
            //Création du tableau des Country
            this.TabCountry = new string[28];

            TabCountry[0] = "MT";
            TabCountry[1] = "DE";
            TabCountry[2] = "UK";
            TabCountry[3] = "FR";
            TabCountry[4] = "IT";
            TabCountry[5] = "ES";
            TabCountry[6] = "PL";
            TabCountry[7] = "RO";
            TabCountry[8] = "NL";
            TabCountry[9] = "BE";
            TabCountry[10] = "EL";
            TabCountry[11] = "CZ";
            TabCountry[12] = "PT";
            TabCountry[13] = "HU";
            TabCountry[14] = "SE";
            TabCountry[15] = "AT";
            TabCountry[16] = "BG";
            TabCountry[17] = "DK";
            TabCountry[18] = "FI";
            TabCountry[19] = "SK";
            TabCountry[20] = "IE";
            TabCountry[21] = "HR";
            TabCountry[22] = "LT";
            TabCountry[23] = "SI";
            TabCountry[24] = "LV";
            TabCountry[25] = "EE";
            TabCountry[26] = "CY";
            TabCountry[27] = "LU";

            //Création du tableau des Tax
            this.TabTax = new decimal[28];

            TabTax[0] = 0.2m;
            TabTax[1] = 0.2m;
            TabTax[2] = 0.21m;
            TabTax[3] = 0.2m;
            TabTax[4] = 0.25m;
            TabTax[5] = 0.19m;
            TabTax[6] = 0.21m;
            TabTax[7] = 0.2m;
            TabTax[8] = 0.2m;
            TabTax[9] = 0.24m;
            TabTax[10] = 0.2m;
            TabTax[11] = 0.19m;
            TabTax[12] = 0.23m;
            TabTax[13] = 0.27m;
            TabTax[14] = 0.23m;
            TabTax[15] = 0.22m;
            TabTax[16] = 0.21m;
            TabTax[17] = 0.21m;
            TabTax[18] = 0.17m;
            TabTax[19] = 0.18m;
            TabTax[20] = 0.21m;
            TabTax[21] = 0.23m;
            TabTax[22] = 0.23m;
            TabTax[23] = 0.24m;
            TabTax[24] = 0.2m;
            TabTax[25] = 0.22m;
            TabTax[26] = 0.21m;
            TabTax[27] = 0.25m;
            

            
        }
        
    }
}

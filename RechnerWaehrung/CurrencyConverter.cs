using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RechnerWaehrung
{
     class CurrencyConverter
    {

        public static float GetCurrencyRateInCHF(string currency)
        {
            float exchangeRate = 1;



            // Get current Rates at floatrates.com in XML Format 
            XmlDocument xmlDcoument = new XmlDocument();
            xmlDcoument.Load(@"https://www.floatrates.com/daily/chf.xml");


            XmlNodeList xmlNodeList = xmlDcoument.DocumentElement.SelectNodes("/channel/item");

            foreach (XmlNode xmlNode in xmlNodeList)
            {



                if (xmlNode.SelectSingleNode("targetCurrency").InnerText.ToString() == currency)

                {                
                    exchangeRate = float.Parse(xmlNode.SelectSingleNode("exchangeRate").InnerText);

                }


            }


            return exchangeRate;

        }


        /// Get The Exchange Rate Between 2 Currencies
        public static float GetExchangeRate(string from, string to, float amount = 1)
        {

            // Convert CHF to CHF
            if (from.ToLower() == "CHF" && to.ToLower() == "CHF")
                return amount;

            try
            {
                // First Get the exchange rate of both currencies in chf
                float toRate = GetCurrencyRateInCHF(to);
                float fromRate = GetCurrencyRateInCHF(from);

                // Convert Between CHF to Other Currency
                if (from.ToLower() == "CHF")
                {
                    return (amount * toRate);
                }
                else if (to.ToLower() == "CHF")
                {
                    return (amount / fromRate);
                }
                else
                {
                    // Calculate non EURO exchange rates From A to B
                    return (amount * toRate) / fromRate;
                }
            }
            catch { return 0; }
        }



    }





}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimariTasarim
{
    internal class Seyahat
    {
        string[] flightsName = { "Manisa-İzmir", "Manisa-İstanbul", "İstanbul-İzmir", "İzmir-İstanbul" };
        string[] flightsDay = { "10", "11", "10", "12" };
        string[] flightsMonth = { "5", "5", "5", "5" };
        public static int[] flightsEmpty = { 3, 8, 0, 1 };
        string[] flightsPrice = { "250", "550", "450", "450" };

        string[] busName = { "Manisa-Eskişehir", "Manisa-Ankara", "İstanbul-Ankara", "İzmir-Ankara" };
        string[] busDay = { "13", "12", "9", "14" };
        string[] busMonth = { "5", "5", "5", "5" };
        public static int[] busEmpty = { 4, 0, 2, 5 };
        string[] busPrice = { "150", "300", "250", "250" };

        string[] otelName = { "Manisa Otel", "İstanbul Otel", "İzmir Otel", "Eskişehir Otel" };
        string[] otelDay = { "7", "9", "11","13" };
        string[] otelMonth = { "5", "5", "5", "5" };
        public static int[] otelEmpty = { 2, 3, 6, 0 };
        string[] otelPrice = { "150", "400", "300", "250" };

        string[] cadirName = { "Manisa Çadır", "İstanbul Çadır", "İzmir Çadır", "Eskişhir Çadır" };
        string[] cadirDay = { "14", "15", "10", "9" };
        string[] cadirMonth = { "5", "5", "5", "5" };
        public static int[] cadirEmpty = { 2, 6, 2, 7 };
        string[] cadirPrice = { "100", "200", "150", "150" };

        public static string ulasimChoice = "default";
        public static string konaklamaChoice = "default";
        public static int type = 0;
        public static int selectedCombo = 0;


        public string getflightName(int id) { return flightsName[id]; }
        public string getflightDay(int id) { return flightsDay[id]; }
        public string getflightMonth(int id) { return flightsMonth[id]; }
        public int getflightEmpty(int id) { return flightsEmpty[id]; }
        public string getflightPrice(int id) { return flightsPrice[id]; }
        public int getmaxFlight() { return flightsName.Length; }

        public void setFlightEmptyBuy(int id) { flightsEmpty[id] -= 1; }
        public void setBusEmptyBuy(int id) { busEmpty[id] -= 1; }
        public void setCadirEmptyBuy(int id) { cadirEmpty[id] -= 1; }
        public void setHotelEmptyBuy(int id) { otelEmpty[id] -= 1; }

        public string getbusName(int id) { return busName[id]; }
        public string getbusDay(int id) { return busDay[id]; }
        public string getbusMonth(int id) { return busMonth[id]; }
        public int getbusEmpty(int id) { return busEmpty[id]; }
        public string getbusPrice(int id) { return busPrice[id]; }
        public int getmaxBus() { return busName.Length; }

        public string getotelName(int id) { return otelName[id]; }
        public string getotelDay(int id) { return otelDay[id]; }
        public string getotelMonth(int id) { return otelMonth[id]; }
        public int getotelEmpty(int id) { return otelEmpty[id]; }
        public string getotelPrice(int id) { return otelPrice[id]; }
        public int getmaxOtel() { return otelName.Length; }

        public string getcadirName(int id) { return cadirName[id]; }
        public string getcadirDay(int id) { return cadirDay[id]; }
        public string getcadirMonth(int id) { return cadirMonth[id]; }
        public int getcadirEmpty(int id) { return cadirEmpty[id]; }
        public string getcadirPrice(int id) { return cadirPrice[id]; }
        public int getmaxCadir() { return cadirName.Length; }

        public void setUChoice(string choicee) { ulasimChoice = choicee; }
        public string getUchoice() { return ulasimChoice; }

        public void setKChoice(string choicee) { konaklamaChoice = choicee; }
        public string getKchoice() { return konaklamaChoice; }

        public void setType(int typee) { type = typee; }
        public int getType() { return type; }

        public void setCombo(int commbo) { selectedCombo = commbo; }
        public int getcombo() { return selectedCombo; }



    }
}

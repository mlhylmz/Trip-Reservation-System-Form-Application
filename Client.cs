using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimariTasarim
{
    public class clientData
    {
        public static string[] names = { "melih", "nur", "baver", "", "", "", "", "", "", "" };
        public static string[] pass = { "123", "123", "123", "", "", "", "", "", "", "" };
        int[] id = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public static int[] cash = { 400, 400, 400, 0, 0, 0, 0, 0, 0, 0 };
        public static int tempId = -1;
        public static int IdCounter = 3;
        public static int truefalse = 0;

        public int getTempId() { return tempId; }
        public string getNames(int id) { return names[id]; }
        public void setNames(string name , int id) { names[id] = name; }

        public string getPass(int id) { return pass[id]; }
        public void setPass(string passs, int id) { pass[id] = passs; }

        public int getCash(int id) { return cash[id];}
        public void setCash(int cashh, int id) { cash[id] = cashh; }
        public void setAfterBuyCash(int cashh) { cash[tempId] = cash[tempId] - cashh; }

        public int setNewClient(string namee,string passs,int cashh)
        {
            int asd = IdFounder(namee, passs);
            if(asd == -1)
            {
                names[IdCounter] = namee;
                cash[IdCounter] = cashh;
                pass[IdCounter] = passs;
                truefalse = 1;
                IdCounterPlus();
            }
            else if(asd != -1)
            {
                truefalse = 0;
            }
            return truefalse;
        }
        public int IdFounder(string nameee , string passs)
        {
            for(int i=0;i< 10; i++)
            {
                if(nameee == names[i])
                {
                    if (passs == pass[i])
                    {
                        tempId = i;
                        break;
                    }
                    else
                    {
                        tempId = -2;
                    }
                    break;
                }
                else
                {
                    tempId = -1;
                }
            }
            return tempId;
        }

        public void IdCounterPlus()
        {
            IdCounter++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimMimariTasarim
{
    public class clientData
    {
        //KULLANICI VERİLERİ
        public static string[] names = { "melih", "nur", "baver", "", "", "", "", "", "", "" };// İsimler
        public static string[] pass = { "123", "123", "123", "", "", "", "", "", "", "" };//Şifreler
        int[] id = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//ID'ler
        public static int[] cash = { 400, 400, 400, 0, 0, 0, 0, 0, 0, 0 };//Bakiye
        
        // ID ve Giriş ile ilgili
        public static int tempId = -1; // Kullanıcı giriş tipi (şifre yanlış , giriş doğru , ikisi de yanlış vs.)
        public static int IdCounter = 3; //Her kayıtta bir artar
        public static int truefalse = 0; // Giriş serbest

        // GETTER SETTER
        public int getTempId() { return tempId; }
        public string getNames(int id) { return names[id]; }
        public void setNames(string name , int id) { names[id] = name; }

        public string getPass(int id) { return pass[id]; }
        public void setPass(string passs, int id) { pass[id] = passs; }

        public int getCash(int id) { return cash[id];}
        public void setCash(int cashh, int id) { cash[id] = cashh; }
        public void setAfterBuyCash(int cashh) { cash[tempId] = cash[tempId] - cashh; }

        // KULLANICI KAYIT FONKSİYONU
        public int setNewClient(string namee,string passs,int cashh)
        {
            int asd = IdFounder(namee, passs);
            if(asd == -1) //Eğer böyle bir kullanıcı yoksa
            {
                // Kayıt işlemi
                names[IdCounter] = namee;
                cash[IdCounter] = cashh;
                pass[IdCounter] = passs;
                truefalse = 1;
                IdCounterPlus();
            }
            else if(asd != -1) // Kullanıcı zaten mevcutsa
            {
                truefalse = 0;
            }
            return truefalse;
        }

        // GİRİLEN KİŞİNİN ID'SİNİ BULMA FONKSİYONU
        public int IdFounder(string nameee , string passs)
        {
            for(int i=0;i< 10; i++)
            {
                if(nameee == names[i])
                {
                    if (passs == pass[i])// İsim ve şifre eşleşti
                    {
                        tempId = i;
                        break;
                    }
                    else // İsim eşleşti fakat şifre yanlış
                    {
                        tempId = -2;
                    }
                    break;
                }
                else // Eşleşme yok
                {
                    tempId = -1;
                }
            }
            return tempId;
        }

        // IDCOUNTER ARTTIRMA
        public void IdCounterPlus()
        {
            IdCounter++;
        }
    }
}

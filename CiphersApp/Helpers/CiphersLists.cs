using CiphersApp.Ciphers;
using CiphersApp.Model;
using EncryptionApp.Ciphers.C_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp.Helpers
{
    public class CiphersLists
    {
        public List<CipherMenuModel> MenuModels;
        public CiphersLists()
        {
            MenuModels = new List<CipherMenuModel>();

            CipherMenuModel cipherMenu_0 = new CipherMenuModel();
            CipherMenuModel cipherMenu_1 = new CipherMenuModel();
            CipherMenuModel cipherMenu_2 = new CipherMenuModel();
            CipherMenuModel cipherMenu_3 = new CipherMenuModel();
            CipherMenuModel cipherMenu_4 = new CipherMenuModel();
            CipherMenuModel cipherMenu_5 = new CipherMenuModel();
            CipherMenuModel cipherMenu_6 = new CipherMenuModel();
            CipherMenuModel cipherMenu_7 = new CipherMenuModel();
            CipherMenuModel cipherMenu_8 = new CipherMenuModel();

            cipherMenu_0.Id = 0;
            cipherMenu_0.Name = "Quit app";
            cipherMenu_0.Start = HelperClass.LeaveApp;
            MenuModels.Add(cipherMenu_0);

            Amc a = new Amc();
            cipherMenu_1.Id = a.Id;
            cipherMenu_1.Name = a.Name;
            cipherMenu_1.Start = a.WriteInfo;
            MenuModels.Add(cipherMenu_1);

            Base64 B = new Base64();
            cipherMenu_2.Id = B.Id;
            cipherMenu_2.Name = B.Name;
            cipherMenu_2.Start = B.WriteInfo;
            MenuModels.Add(cipherMenu_2);

            Base91 B91 = new Base91();
            cipherMenu_3.Id = B91.Id;
            cipherMenu_3.Name = B91.Name;
            cipherMenu_3.Start = B91.WriteInfo;
            MenuModels.Add(cipherMenu_3);

            Caesar C = new Caesar();
            cipherMenu_4.Id = C.Id;
            cipherMenu_4.Name = C.Name;
            cipherMenu_4.Start = C.WriteInfo;
            MenuModels.Add(cipherMenu_4);

            CaesarVariation CV = new CaesarVariation();
            cipherMenu_5.Id = CV.Id;
            cipherMenu_5.Name = CV.Name;
            cipherMenu_5.Start =CV.WriteInfo;
            MenuModels.Add(cipherMenu_5);

            Condi ci = new Condi();
            cipherMenu_6.Id = ci.Id;
            cipherMenu_6.Name = ci.Name;
            cipherMenu_6.Start = ci.WriteInfo;
            MenuModels.Add(cipherMenu_6);

            RailFenceCipher Fc = new RailFenceCipher();
            cipherMenu_7.Id = Fc.Id;
            cipherMenu_7.Name = Fc.Name;
            cipherMenu_7.Start = Fc.WriteInfo;
            MenuModels.Add(cipherMenu_7);

            Scytale S = new Scytale();
            cipherMenu_8.Id = S.Id;
            cipherMenu_8.Name = S.Name;
            cipherMenu_8.Start = S.WriteInfo;
            MenuModels.Add(cipherMenu_8);

        }
    }
}

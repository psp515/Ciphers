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
            cipherMenu_0.Name = "LeaveApp";
            MenuModels.Add(cipherMenu_0);

            Amc a = new Amc();
            cipherMenu_1.Id = a.Id;
            cipherMenu_1.Name = a.Name;
            MenuModels.Add(cipherMenu_1);

            Base64 B = new Base64();
            cipherMenu_2.Id = B.Id;
            cipherMenu_2.Name = B.Name;
            MenuModels.Add(cipherMenu_2);

            Base91 B91 = new Base91();
            cipherMenu_3.Id = B91.Id;
            cipherMenu_3.Name = B91.Name;
            MenuModels.Add(cipherMenu_3);

            Cesar C = new Cesar();
            cipherMenu_4.Id = C.Id;
            cipherMenu_4.Name = C.Name;
            MenuModels.Add(cipherMenu_4);

            CesarVariation CV = new CesarVariation();
            cipherMenu_5.Id = CV.Id;
            cipherMenu_5.Name = CV.Name;
            MenuModels.Add(cipherMenu_5);

            Condi ci = new Condi();
            cipherMenu_6.Id = ci.Id;
            cipherMenu_6.Name = ci.Name;
            MenuModels.Add(cipherMenu_6);

            FenceCipher Fc = new FenceCipher();
            cipherMenu_7.Id = Fc.Id;
            cipherMenu_7.Name = Fc.Name;
            MenuModels.Add(cipherMenu_7);

            Scytale S = new Scytale();
            cipherMenu_8.Id = S.Id;
            cipherMenu_8.Name = S.Name;
            MenuModels.Add(cipherMenu_8);

        }
    }
}

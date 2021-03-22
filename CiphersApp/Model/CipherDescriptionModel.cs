using CiphersApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp.Ciphers
{
    public  class CipherModel : CipherDescription
    {
        public virtual int CipherNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortDescription { get; set; }

    }
}

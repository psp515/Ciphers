using System;
using System.Collections.Generic;
using System.Text;

namespace CiphersApp.Ciphers
{
    public abstract class CipherClass
    {
        public virtual int Id { get; set; } = 0;
        public virtual string Name { get; set; } = "No name";
        public virtual string ShortDescription { get; set; } = "No Description";
        public virtual string WikipediHttps { get; set; } = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";

    }
}

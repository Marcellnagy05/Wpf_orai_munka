using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNepesseg.Model
{
    //"Megye kód";"KSH kód";Megye;Település;"Település típusa";"Állandó férfi lakosság összesen";"Állandó női lakosság összesen"
    //Alt + Enter a barátunk
    public class Telepules
    {
        //mezők (más néven attribútumok)
        String megye;
        String telepulesNev;
        String telepulesTipus; //község, nagyközség, város, ...
        int ferfiLakosokSzama;
        int noiLakosokSzama;

        //Konstruktor
        public Telepules(string megye,
                         string telepulesNev,
                         string telepulesTipus,
                         int ferfiLakosokSzama,
                         int noiLakosokSzama)
        {
            this.megye = megye;
            this.telepulesNev = telepulesNev;
            this.telepulesTipus = telepulesTipus;
            this.ferfiLakosokSzama = ferfiLakosokSzama;
            this.noiLakosokSzama = noiLakosokSzama;
        }
        //tulajdonságok (properties)
        public string Megye { get => megye; }
        public string TelepulesNev { get => telepulesNev; }
        public string TelepulesTipus { get => telepulesTipus; }
        public int FerfiLakosokSzama { get => ferfiLakosokSzama; }
        public int NoiLakosokSzama { get => noiLakosokSzama; }

        public int LakosokSzama()
        {
            return this.ferfiLakosokSzama + this.NoiLakosokSzama;
        }

        //public int LakosokSzamaEgyutt { get => this.ferfiLakosokSzama + this.NoiLakosokSzama; }

        //todo Készítsen egy EzVaros logikai típusú property-t, ami megadja, hogy városnak számít-e a település!
        //public bool EzVaros { get=> ■}

        public bool EzVaros { get => this.EzVaros; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Show
    {
        public int ID { get; set; }
        private String gen;
        private String titlu;
        private String regia;
        private String distributia;
        private DateTime dataPremierei;
        private int numarBilete;

        public Show() { }

        public Show(String gen, String titlu, String regia, String distributia, DateTime dataPremierei, int numarBilete)
        {
            this.gen = gen;
            this.titlu = titlu;
            this.regia = regia;
            this.distributia = distributia;
            this.dataPremierei = dataPremierei;
            this.numarBilete = numarBilete;
        }

        public Show(int ID, String gen, String titlu, String regia, String distributia, DateTime dataPremierei, int numarBilete)
        {
            this.ID = ID;
            this.gen = gen;
            this.titlu = titlu;
            this.regia = regia;
            this.distributia = distributia;
            this.dataPremierei = dataPremierei;
            this.numarBilete = numarBilete;
        }

        public String Gen
        {
            get { return gen; }
            set { gen = value; }
        }

        public String Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public String Regia
        {
            get { return regia; }
            set { regia = value; }
        }

        public String Distributia
        {
            get { return distributia; }
            set { distributia = value; }
        }

        public DateTime DataPremierei
        {
            get { return dataPremierei; }
            set { dataPremierei = value; }
        }

        public int NumarBilete
        {
            get { return numarBilete; }
            set { numarBilete = value; }
        }
    }
}

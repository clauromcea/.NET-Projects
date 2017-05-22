using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
    {
        public int ID { get; set; }
        private String spectacol;
        private String rand;
        private int loc;

        public Ticket() { }

        public Ticket(String spectacol, String rand, int loc)
        {
            this.spectacol = spectacol;
            this.rand = rand;
            this.loc = loc;
        }

        public Ticket(int ID, String spectacol, String rand, int loc)
        {
            this.ID = ID; 
            this.spectacol = spectacol;
            this.rand = rand;
            this.loc = loc;
        }    

        public String Spectacol
        {
            get { return spectacol; }
            set { spectacol = value; }
        }

        public String Rand
        {
            get { return rand; }
            set { rand = value; }
        }

        public int Loc
        {
            get { return loc; }
            set { loc = value; }
        }
    }
}

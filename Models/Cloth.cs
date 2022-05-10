using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Cloth
    {
        public string gender { get; set; }
        public string type { get; set; }

        public string size { get; set; }

        public string quantity { get; set; }

        public override string ToString()
        {
            return this.size + " " + this.type + " " + this.gender + " " + this.quantity;
        }

    }


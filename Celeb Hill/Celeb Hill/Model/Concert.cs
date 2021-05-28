using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celeb_Hill.Model
{
    public class Concert
    {
        public int id { get; set; }
        public string concert { get; set; }
        public string phoneNumber { get; set; }
        public float priceUSD { get; set; }
        public float courseOfUSD { get; set; }
        public float priceBYN { get; set; }


        public Concert(int id, string concert, string phoneNumber, float priceUSD, float courseOfUSD, float priceBYN)
        {
            this.id = id;
            this.concert = concert;
            this.phoneNumber = phoneNumber;
            this.priceUSD = priceUSD;
            this.courseOfUSD = courseOfUSD;
            this.priceBYN = priceBYN;
        }


        public Concert ()
        {
            this.id = 0;
            this.concert = "";
            this.phoneNumber = "";
            this.priceUSD = 0.0f;
            this.courseOfUSD = 0.0f;
            this.priceBYN = 0.0f;
        }

    }

    


}




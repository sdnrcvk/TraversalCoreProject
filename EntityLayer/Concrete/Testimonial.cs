using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Client { get;}
        public string Comment { get;}
        public string ClientImage { get;}
        public bool Status { get; set; }
    }
}

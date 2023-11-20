using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAPP.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Order> Orders { get; set; }
        public List<Support> SupportList { get; set; }
    }
}

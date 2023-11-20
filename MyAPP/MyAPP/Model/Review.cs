using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP.Model
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }
        [NotMapped]
        public string UserLogin
        {
            get
            {
                return DataWorker.GetLoginById(UserId);
            }
        }
    }
}

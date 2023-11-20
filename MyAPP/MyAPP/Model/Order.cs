using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Notebook Notebook    { get;set;}
        public int NotebookId { get; set; }
        public User User{ get; set; }
        public int UserId { get; set; }
        public Notebook notebook
        {
            get
            {
                return DataWorker.GetNotebookById(NotebookId);
            }
        }
    }
}

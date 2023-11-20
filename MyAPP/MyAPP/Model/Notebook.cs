using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyAPP.Model
{
    public class Notebook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int ImageId { get; set; }
        public Image? NotebookImage { get; set; }
        [NotMapped]
        public Image NoteImage
        {
            get
            {
                return DataWorker.GetImageById(ImageId);
            }
        }
    }
}

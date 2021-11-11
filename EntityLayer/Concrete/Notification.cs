using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Notification
    {
        [Key]
        public int NotID { get; set; }
        public string NotType { get; set; }
        public string NotTypeSymbol { get; set; }
        public string NotColor { get; set; }
        public string NotDetail { get; set; }
        public DateTime NotDate { get; set; }
        public bool NotStatus { get; set; }
    }
}

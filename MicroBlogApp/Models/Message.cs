using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroBlogApp.Models
{
    public class Message
    {
       public int MessageId { get; set; }

       [Display(Name = "名前")]
       [Required]
       public string Comment { get; set; }

       [Display(Name = "投稿者")]
       public int PersonKey { get; set; }
       

        [ForeignKey("PersonKey")]
        public Person Person { get; set; }
    }
}

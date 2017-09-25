using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Commercial.Model.Models
{
    [Table("Posts")]
   public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get;}

        [Required]
        public int PostCategoryID { set; get; }
        [MaxLength(256)]
        public  string Images { set; get; }
        [Required]
        public  decimal Price { set; get; }

        [MaxLength(500)]
        public string Descripttion { set; get; }
        public string Content { set; get; }

        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int ViewCount { set; get; }

        [ForeignKey("PostCategoryID")]
        public virtual PostCategories PostCategory { set; get; }
     //   public virtual IEnumerable<PostTag> PostTag { set; get; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT_Commercial.Model.Abstracts
{
   public interface IAuditable
    {
        DateTime CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }

        [MaxLength(256)]
         string MetaKeyword { set; get; }
        [MaxLength(256)]
        string MetaDescription { set; get; }

        bool Status { set; get; }

    }
}

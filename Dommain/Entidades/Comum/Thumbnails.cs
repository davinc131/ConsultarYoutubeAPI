using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.Comum
{
  public class Thumbnails
  {
    [Key]
    public Guid ID { get; set; }

    public Guid DefaultID { get; set; }
    public Guid MediumID { get; set; }
    public Guid HighID { get; set; }
    public virtual Default @default { get; set; }
    public virtual Medium medium { get; set; }
    public virtual High high { get; set; }
  }
}

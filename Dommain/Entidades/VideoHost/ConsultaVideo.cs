using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.VideoHost
{
  public class ConsultaVideo
  {
    [Key]
    public Guid ID { get; set; }
    public string TermoConsulta { get; set; }

    public Guid VideoRootID { get; set; }
    public virtual VideoRoot VideoRoot { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.CanalHost
{
  public class ConsultaCanal
  {
    [Key]
    public Guid ID { get; set; }
    [Required]
    public string TermoConsulta { get; set; }

    public Guid CanalRootID { get; set; }
    public virtual CanalRoot CanalRoot { get; set; }
  }
}

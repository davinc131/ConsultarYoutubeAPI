using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.Comum
{
  public class Default
  {
    [Key]
    public Guid ID { get; set; }
    public string url
    {
      get; set;
    }
    public int width
    {
      get; set;
    }
    public int height
    {
      get; set;
    }
   }
}

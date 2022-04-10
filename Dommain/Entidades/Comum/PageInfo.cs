using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.Comum
{
  public class PageInfo
  {
    [Key]
    public Guid ID { get; set; }
    public int totalResults { get; set; }
    public int resultsPerPage { get; set; }
  }
}

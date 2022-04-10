using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.Comum
{
  public class Id
  {
    [Key]
    public Guid ID { get; set; }
    public string kind { get; set; }
    public string channelId { get; set; }
    public string videoId { get; set; }
  }
}

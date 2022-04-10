using Dommain.Entidades.Comum;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.VideoHost
{
  public class VideoRoot
  {
    [Key]
    public Guid ID { get; set; }
    public string TermoConsulta { get; set; }
    public string kind { get; set; }
    public string etag { get; set; }
    public string nextPageToken { get; set; }
    public string regionCode { get; set; }
    public List<Item> items { get; set; }

    public Guid PageInfoID { get; set; }
    public virtual PageInfo pageInfo { get; set; }
  }
}

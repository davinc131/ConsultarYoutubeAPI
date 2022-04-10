using Dommain.Entidades.CanalHost;
using Dommain.Entidades.VideoHost;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.Comum
{
  public class Item
  {
    [Key]
    public Guid ID { get; set; }
    public string kind { get; set; }
    public string etag { get; set; }

    public Guid IdID { get; set; }
    public Guid? CanalRootID { get; set; }
    public Guid? VideoRootID { get; set; }
    public Guid SnippetID { get; set; }

    public virtual CanalRoot CanalRoot { get; set; }
    public virtual VideoRoot VideoRoot { get; set; }
    public virtual Snippet snippet { get; set; }
    public virtual Id id { get; set; }
  }
}

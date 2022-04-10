using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dommain.Entidades.Comum
{
  public class Snippet
  {
    [Key]
    public Guid ID { get; set; }
    public DateTime publishedAt { get; set; }
    public string channelId { get; set; }
    public string title { get; set; }
    public string description { get; set; }    
    public string channelTitle { get; set; }
    public string liveBroadcastContent { get; set; }
    public DateTime publishTime { get; set; }

    public Guid ThumbnailsID { get; set; }
    public virtual Thumbnails thumbnails { get; set; }
  }
}

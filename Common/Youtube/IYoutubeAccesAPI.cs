using Dommain.Entidades.CanalHost;
using Dommain.Entidades.VideoHost;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Youtube
{
  public interface IYoutubeAccesAPI
  {
    VideoRoot ConsultarVideo(string pConsulta);
    CanalRoot ConsultarCanal(string pConsulta);
  }
}

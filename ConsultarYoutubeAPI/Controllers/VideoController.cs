using Common.Youtube;

using Dommain.Entidades.VideoHost;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultarYoutubeAPI.Controllers
{
  public class VideoController : Controller
  {
    private readonly IYoutubeAccesAPI _youtubeAccesAPI;
    private readonly Context _Context;

    public VideoController(IYoutubeAccesAPI youtubeAccesAPI, Context pContext)
    {
      _youtubeAccesAPI = youtubeAccesAPI;
      _Context = pContext;
    }
    // GET: VideoController
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ConsultaVideo pVideo)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var VideoBD = (from c in _Context.Set<ConsultaVideo>()
                         join root in _Context.Set<VideoRoot>()
                         on c.VideoRootID equals root.ID
                         select new ConsultaVideo()
                         {
                           ID = c.ID,
                           TermoConsulta = c.TermoConsulta,
                           VideoRootID = c.VideoRootID,
                           VideoRoot = root
                         }).Where(c => c.TermoConsulta == pVideo.TermoConsulta).FirstOrDefault();

          if (VideoBD == null)
          {
            var result = _youtubeAccesAPI.ConsultarVideo(pVideo.TermoConsulta);
            pVideo.VideoRoot = result;

            _Context.Videos.Add(pVideo);
            await _Context.SaveChangesAsync();

            return View(pVideo);
          }
          else
          {
            var itens = _Context.Item.Where(i => i.VideoRootID == VideoBD.VideoRootID).Include(i => i.snippet).Include(i => i.id).Include(i => i.snippet.thumbnails).Include(i => i.snippet.thumbnails.high).ToListAsync().Result;
            VideoBD.VideoRoot.items = itens;
            return View(VideoBD);
          }
        }
        else
        {
          return BadRequest("O termo de consulta não pode ser vazio");
        }
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}

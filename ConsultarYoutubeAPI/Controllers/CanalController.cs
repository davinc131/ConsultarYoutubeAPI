using Common.Youtube;

using Dommain.Entidades.CanalHost;
using Dommain.Entidades.Comum;

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
  public class CanalController : Controller
  {
    private readonly IYoutubeAccesAPI _youtubeAccesAPI;
    private readonly Context _Context;

    public CanalController(IYoutubeAccesAPI youtubeAccesAPI, Context pContext)
    {
      _youtubeAccesAPI = youtubeAccesAPI;
      _Context = pContext;
    }
    // GET: CanalController
    [HttpGet]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ConsultaCanal pCanal)
    {
      try
      {
        if (ModelState.IsValid)
        {
          var canalBD = (from c in _Context.Set<ConsultaCanal>()
                         join root in _Context.Set<CanalRoot>()
                         on c.CanalRootID equals root.ID                                                
                         select new ConsultaCanal()
                         {
                           ID = c.ID,
                           TermoConsulta = c.TermoConsulta,
                           CanalRootID = c.CanalRootID,
                           CanalRoot = root
                         }).Where(c => c.TermoConsulta == pCanal.TermoConsulta).FirstOrDefault();

          if (canalBD == null)
          {
            var result = _youtubeAccesAPI.ConsultarCanal(pCanal.TermoConsulta);
            pCanal.CanalRoot = result;

            _Context.Canais.Add(pCanal);
            await _Context.SaveChangesAsync();

            return View(pCanal);
          }
          else
          {
            var itens = _Context.Item.Where(i => i.CanalRootID == canalBD.CanalRootID).Include(i => i.snippet).Include(i => i.id).Include(i => i.snippet.thumbnails).Include(i => i.snippet.thumbnails.high).ToListAsync().Result;
            canalBD.CanalRoot.items = itens;
            return View(canalBD);
          }          
        }
        else
        {
          return BadRequest("O termo de consulta não pode ser vazio");
        }
      }
      catch(Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}

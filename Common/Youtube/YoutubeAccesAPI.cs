using Dommain.Entidades.CanalHost;
using Dommain.Entidades.VideoHost;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Youtube
{
  public class YoutubeAccesAPI : IYoutubeAccesAPI
  {
    protected string API_KEY = "AIzaSyB0nHVz7LHGnRLhJ5dTMyZ8yoJ70Nf3IF4";
    protected int maxResults = 30;

    public CanalRoot ConsultarCanal(string pConsulta)
    {
      try
      {
        var url = "https://www.googleapis.com/youtube/v3/search?key=" + API_KEY + "&type=channel&part=snippet&maxResults=" + maxResults + "&q=" + pConsulta;
        var client = new RestClient(url);
        var request = new RestRequest();
        var response = client.Get(request);

        if (response.IsSuccessful)
        {
          CanalRoot canalSearch = JsonConvert.DeserializeObject<CanalRoot>(response.Content);

          return canalSearch;
        }
        else
        {
          return null;
        }
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }

    public VideoRoot ConsultarVideo(string pConsulta)
    {
      try
      {
        var url = "https://www.googleapis.com/youtube/v3/search?key=" + API_KEY + "&type=video&part=snippet&maxResults=" + maxResults + "&q=" + pConsulta;
        var client = new RestClient(url);
        var request = new RestRequest();
        var response = client.Get(request);

        if (response.IsSuccessful)
        {
          VideoRoot videoSearch = JsonConvert.DeserializeObject<VideoRoot>(response.Content);

          return videoSearch;
        }
        else
        {
          return null;
        }
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }
  }
}

using NUnit.Framework;
using Common;
using Dommain;
using Common.Youtube;

namespace ConsultarYoutubeAPITeste
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestConsultarCanal()
    {
      YoutubeAccesAPI youtubeAccesAPI = new YoutubeAccesAPI();
      var response = youtubeAccesAPI.ConsultarCanal("microsoft word");
      Assert.IsNotNull(response);
    }

    [Test]
    public void TestConsultarVideo()
    {
      YoutubeAccesAPI youtubeAccesAPI = new YoutubeAccesAPI();
      var response = youtubeAccesAPI.ConsultarVideo("microsoft word");
      Assert.IsNotNull(response);
    }
  }
}
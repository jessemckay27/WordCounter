using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace RepeatCountersView
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/count"] = _ =>
      {
        RepeatCounter findWord = new RepeatCounter(Request.Form["sentence"],Request.Form["word"]);
        return View["result.cshtml", findWord];
      };
    }
  }
}

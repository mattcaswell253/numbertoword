using Nancy;
using System.Collections.Generic;
using NumbersApp.Objects;


namespace NumbersApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
        }
    }
}

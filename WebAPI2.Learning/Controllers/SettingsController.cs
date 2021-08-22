using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI2.Learning.Controllers
{
   // [EnableCors(origins: "http://localhost:50524" ,headers:"*",methods:"PUT,GET,OPTIONS",SupportsCredentials =true)]
    public class SettingsController : ApiController
    {

        private static List<string> _settings = new List<string>() { "Setting1", "Setting2" };
        //[Route("api/settings")]
        
        public IEnumerable<string> GetSettings()
        {
            throw new Exception("Hey I am an exception");
            return _settings;
        }

        [HttpPut]
        public IEnumerable<string> Put([FromBody] List<string> setting)
        {
            _settings.AddRange(setting);

            return _settings;
        }
        [HttpOptions]

        public string Options() =>  string.Empty;
      
    }
}

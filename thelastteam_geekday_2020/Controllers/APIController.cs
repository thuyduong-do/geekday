using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using thelastteam_geekday_2020.Logic;
using thelastteam_geekday_2020.Models;

namespace thelastteam_geekday_2020.Controllers
{
    public class APIController : ApiController
    {
        PlayerLogic logic;

        public APIController()
        {
            logic = new PlayerLogic();
        }
       
        [ActionName("ufo")]
        [HttpPost]
        public IEnumerable<Player> Ufo(Data data)
        {
            logic.addData(data);
            return logic.PlayerMove();
        }

    }
}

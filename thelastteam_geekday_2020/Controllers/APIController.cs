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
        public Player[] UfoKill(Enemy enemy)
        {
            if(enemy.UnitId == 1)
            {
                //logic...
            }

            return new Player[]
            {
                new Player()
                {
                    ID=1,
                    Action="MoveE"
                },
                new Player()
                {
                    ID=2,
                    Action="MoveE"
                },
                new Player()
                {
                    ID=3,
                    Action="MoveE"
                },

            };
        }
    }
}

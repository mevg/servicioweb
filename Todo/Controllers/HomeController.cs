using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Todo.Controllers
{
    public class HomeController : ApiController
    {
        private List<Models.Todo> list = new List<Models.Todo>();

        public HomeController()
        {
            list.Add(new Models.Todo()
            {
                id = 1,
                name = "compra caguamas"
            });
            list.Add(new Models.Todo()
            {
                id = 2,
                name = "compra mas caguamas"
            });
        }
        public IHttpActionResult Get()
        {
            //buscar clientes
            //buscar otra cosa
            //    mandar json con las dos variables
            return Ok(list);
        }

        public IHttpActionResult Get(int num)
        {
            //Created( un reporte de nose que qcosa)
            return Ok($"tu numero gay es {num}");
        }
    }
}
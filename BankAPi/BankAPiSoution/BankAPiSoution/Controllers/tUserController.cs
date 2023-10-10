using BankAPiSoution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace BankAPiSoution.Controllers
{
    public class tUserController : ApiController
    {
        BankEntities db = new BankEntities();
        [HttpGet]
        public IHttpActionResult GetAccUsers()
        {
            List<tUser> users = db.tUsers.ToList();
            return Ok(users);
        }
        [HttpGet]
        public IHttpActionResult GetAccUsers(int id)
        {
            var user = db.tUsers.Where(x=>x.AccountNumber==id);
            return Ok(user);
        }
    }
}

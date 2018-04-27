using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AngulaestApi.Models;
namespace AngulaestApi.Controllers
{
    public class LoginController : ApiController
    {
        // GET: Login
        [ResponseType(typeof(User))]
        public object PostProduct1q(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (user.UserName.Equals("lijo"))
                return true;
            else
                return false;
        }
    }
}
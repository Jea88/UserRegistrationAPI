using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserRegistrationAPI.Models;

namespace UserRegistrationAPI.Controllers
{
    public class AccountsController : ApiController
    {
        public IHttpActionResult UserRegForm(Register rg)
        {
            WebAPI_UserEntities db = new WebAPI_UserEntities();
            db.tbl_Register.Add(new tbl_Register()
            {
                FirstName = rg.FirstName,
                LastName = rg.LastName,
                Email = rg.Email,
                Pwd = rg.Pwd,
                ConPwd = rg.ConPwd
            });
            db.SaveChanges();
            return Ok();
        }
        public IHttpActionResult PostLogin(Login login)
        {
            WebAPI_UserEntities db = new WebAPI_UserEntities();
            var rec = db.tbl_Register.Where(a => a.Email == login.Email && a.Pwd == login.Pwd).FirstOrDefault();
            return Ok();
        }
    }
}

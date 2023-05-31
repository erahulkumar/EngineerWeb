using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO;
using BLL;
namespace UI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserBLL userbll = new UserBLL();
        // GET: Admin/Login
        public ActionResult Index()
        {
            UserDTO dto = new UserDTO();
            return View(dto);
        }
        [HttpPost]
        public ActionResult Index(UserDTO model)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = userbll.GetUserWithUsernameAndPassword(model);
                if(user.Username==model.Username)
                {
                    return RedirectToAction("Index", "Post");
                }
                else
                    return View(model);
            }
            else
                return View(model);
            
        }
    }
}
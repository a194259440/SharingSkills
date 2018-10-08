using SharingSkills_Model.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharingSkills.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            //Post请求时,验证信息
            if (HttpContext.Request.RequestType == "POST")
            {
                ReturnMsg rmsg = new ReturnMsg();
                string uid = Request["uid"];
                string pwd = Request["pwd"];
                if (string.IsNullOrWhiteSpace(uid) || string.IsNullOrWhiteSpace(pwd))
                {
                    rmsg.Status = 1;
                    rmsg.msg = "您的账户或密码输入为空";
                    return Json(rmsg);
                }
                Models.EFDbContext db = new Models.EFDbContext();
                if(db.UserInfo.Select(a => a.userId == uid && a.userPwd == pwd).Count()==0)
                {
                    rmsg.Status = 1;
                    rmsg.msg = "账户或密码输入错误";
                    return Json(rmsg);
                }
                rmsg.Status = 0;
                rmsg.msg = "登陆成功";
                return Json(rmsg);
            }
            //Get请求时,返回页面
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
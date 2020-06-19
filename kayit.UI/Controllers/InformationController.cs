using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kayit.UI.Models;
using kayit.BLL.Repository;
using kayit.BLL.Service;
using kayit.DAL.DB;
using System.IO;

namespace kayit.UI.Controllers
{
    public class InformationController : Controller
    {
        protected EntityService service = new EntityService();
        // GET: Information


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Complete()
        {
            return View();
        }

        public ActionResult Incomplete()
        {
            return View();
        }

        public string st = "";
        public ActionResult CheckMail(string Email)
        {
            
            if (Email == null | Email == st)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }


            var bulunan = service.UserService.CheckEmail(Email);
            if (bulunan == true)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

        }

        [HttpPost]
        public ActionResult Kaydet(InsertInfoVM gelen, HttpPostedFileBase resim)
        {
            if (ModelState.IsValid)
            {

                string uzanti = Path.GetExtension(resim.FileName);
                string resimAdi = Guid.NewGuid() + uzanti;

                resim.SaveAs(Server.MapPath("/Images/Galeri/" + resimAdi));


                User usr = new User()
                {
                    Email = gelen.Email,
                    Password = gelen.UserIPassword,
                };


                service.UserService.Insert(usr);
                Market mrk = new Market()
                {
                    N11MarketName = gelen.N11MarketName,
                    N11ApiPassword = gelen.N11Password,
                    N11ApiUsername = gelen.N11UserName,
                    HbMerchantID = gelen.HBMerchantId,
                    HbMarketName = gelen.HBMarketName,
                    TyApiUsername = gelen.TYUserName,
                    TyApiPassword = gelen.TYPassword,
                    TyMarketName = gelen.TYMarketName,
                    TyMID = gelen.TYMerchantId,
                    GgApiKey = gelen.GGApiKey,
                    GgApiSecret = gelen.GGApiSecret,
                    GgMarketName = gelen.GGMarketName,
                    GgRoleName = gelen.GGRolName,
                    GgRolePass = gelen.GGRolName,
                    XmlUrl = gelen.XmlUrl,
                    UserID = usr.ID,
                };



                Company comp = new Company()
                {
                    CompanyName = gelen.CompanyName,
                    Address = gelen.CompanyAddress,
                    Phone = gelen.Phone,
                    ManagerName = gelen.ManagerName,
                    ManagerEmail = gelen.ManagerEmail,
                    UserID = usr.ID,
                    LogoUrl = "Images/Galeri/" + resimAdi,



                };

                service.CompanyService.Insert(comp);
                service.MarketService.Insert(mrk);

            }
            else
            {
                return Redirect("/Information/Incomplete");
            }

            return Redirect("/Information/complete");

        }




    }
}

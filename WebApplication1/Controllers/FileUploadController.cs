using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Post(UploadFileModel photos)
        {
            var success = false;
            var directory = @"D:\";
            if (!ModelState.IsValid)
            {
                var errorMsg = new StringBuilder();
                ModelState.Values.ToList().ForEach(x =>
                {
                    x.Errors.ToList().ForEach(y => { errorMsg.AppendLine(y.ErrorMessage); });
                });
                foreach (var item in ModelState.Values)
                {

                }

                return Content("<h1>error</h1>");
            }

            //if (photos.File != null && photos.File.ContentLength > 0)
            //{
            //    var fileName = Path.GetFileName(photo.FileName);
            //    photo.SaveAs(Path.Combine(directory, fileName));
            //    success = true;
            //}

            return Content("<h1>upload success!</h1>");

        }


        //public ActionResult Post(IEnumerable<HttpPostedFileBase> photos)
        //{
        //    var success = false;
        //    var directory = @"D:\";
        //    //HttpPostedFileBase photo = Request.Files["photo"];
        //    var errorMsg = new StringBuilder();
        //    foreach (var photo in photos)
        //    {
        //        if (photo == null)
        //        {
        //            errorMsg.AppendLine("No files were uploaded ");
        //            break;
        //        }
        //        errorMsg.Clear();
        //        if (photo.ContentLength > 10240)
        //        {
        //            errorMsg.AppendLine("Photo should not be execeed 10KB ");
        //            break;
        //        }
        //        var extensionName = Path.GetExtension(photo.FileName).Substring(1);
        //        var supportedTypes = new[] { "jpg", "jpeg", "png" };

        //        if (!supportedTypes.Contains(extensionName))
        //        {
        //            errorMsg.AppendLine("Not support this file type");
        //            break;
        //        }

        //        if (photo != null && photo.ContentLength > 0)
        //        {
        //            var fileName = Path.GetFileName(photo.FileName);
        //            photo.SaveAs(Path.Combine(directory, fileName));
        //            success = true;
        //        }


        //    }

        //    return success ? Content("<h1>upload success!</h1>") : Content($"<h1>{errorMsg}</h1>");

        //}
    }
}
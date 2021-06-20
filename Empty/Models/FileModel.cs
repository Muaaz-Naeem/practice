using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Empty.Models
{
    public class FileModel
    {
        public HttpPostedFileBase ImageFile { get; set; }
    public string ImagePath { get; set; }

        public  void Upload(FileModel Model)
        {
            string FileName = Path.GetFileNameWithoutExtension(Model.ImageFile.FileName);

            string FileExtension = Path.GetExtension(Model.ImageFile.FileName);

            FileName = DateTime.Now.ToString("yyyyMMdd") + "-" + FileName.Trim() + FileExtension;

            string path = Path.Combine(HttpContext.Current.Server.MapPath("~/Files"), Path.GetFileName(FileName));

            Model.ImagePath = FileName;
            Model.ImageFile.SaveAs(path);
        }
    }
}
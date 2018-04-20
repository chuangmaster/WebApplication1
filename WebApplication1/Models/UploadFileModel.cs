using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Attribute;

namespace WebApplication1.Models
{
    public class UploadFileModel
    {
        [FileSize(10240)]
        [FileTypes("jpg,jpeg,png")]
        public string File { get; set; }
    }
}
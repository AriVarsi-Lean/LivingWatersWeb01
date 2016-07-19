using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Living_Waters
{
    public class ApplicantModel:Model_SystemUser
    {
       
       
        [Display(Name = "UploadCV space")]
        public string savedcv { get; set; }

    }
}
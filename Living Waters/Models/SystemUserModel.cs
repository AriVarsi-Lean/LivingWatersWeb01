using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Living_Waters
{
    public class Model_SystemUser
    {
        [Required]
        [Display(Name = "UserID")]
        public Guid UserID { get; set; }

        // viewModel.MembershipAPIUserID,
        [Required]
        [Display(Name = "MembershipAPIUserID")]
        public int MembershipAPIUserID { get; set; }

        //[Required]/*
        //[Display(Name = "Android Phone AppID")]
        //public string AndroidPhoneAppID { get; set; }

        [Required]
        [Display(Name = "ID Number")]
        public string IDNumber { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        // public string DOB { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Casual User Picture")]
        public string CasualUserPictureLink { get; set; }

        [Display(Name = "Casual User Picture")]
        public HttpPostedFileBase CasualUserPicture { get; set; }

        //[Required]
        //[Display(Name = "Casual User Picture")]
        //public string CasualUserPicture { get; set; }

        //[Required]
        [Display(Name = "Date Employed")]
        public DateTime DateEmployed { get; set; }
        //   public string DateEmployed { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
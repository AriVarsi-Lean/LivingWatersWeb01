using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Living_Waters
{
   

    namespace OnlineRetailSystem.Models
    {
        public static class Param_Employee
        {
            public static string imageFolder = System.IO.Path.Combine("BusinessImage", "Employee");
            public static string imageFolderView = "BusinessImage/Employee/";
        }

        public class Model_Employee : Model_SystemUser
        {
            [Required]
            [Display(Name = "Employee Hierarchy ID")]
            public byte EmployeeHierarchyID { get; set; }

            [Required]
            [Display(Name = "Work Site ID")]
            public byte OfficeID { get; set; }

            //[Required]
            [Display(Name = "Date Time Last Acess")]
            //public DateTime DateTimeLastAcess { get; set; }
            public DateTime DateTimeLastAcess { get; set; }

            [Required]
            [Display(Name = "Has System Access")]
            public bool HasSystemAccess { get; set; }

            [Display(Name = "Professional Employee Pic")]
            public string ProfEmployeePicLink { get; set; }

            [Display(Name = "Professional Employee Pic")]
            public /* HttpPostedFile */  HttpPostedFileBase ProfessionalEmployeePic { get; set; }

        }
        /*
        public class Methods_Employee
        {
            // Create & Update Functions ==========================================================================================================
            public static bool Employee_Creation(Model_Employee viewModel)
            {
                //viewModel.UserID = Guid.NewGuid();
                //viewModel.ProfEmployeePicLink = "";
                //viewModel.CasualUserPictureLink = "";
                viewModel.AndroidPhoneAppID = " Not yet";
                DateTime DateEmployed = viewModel.DateEmployed;
                DateTime DOB = viewModel.DOB;


                int ret = EmployeeAccess.Employees_Creation(viewModel.UserID, viewModel.EmployeeHierarchyID, viewModel.WorkSiteID,
                    viewModel.HasSystemAccess, viewModel.ProfEmployeePicLink, DateEmployed, viewModel.MembershipAPIUserID,/*viewModel.UserID,*/
        /*  viewModel.AndroidPhoneAppID,
                    viewModel.IDNumber, DOB, viewModel.Name, viewModel.Surname, viewModel.Gender.ToString(), viewModel.CasualUserPictureLink,
                     DateEmployed, viewModel.Email, viewModel.PhoneNumber);

                 if (ret == 0)
                 {
                     return false;
                 }
                 return true;

             }


             public static Model_Employee ModelDetail(Guid UserID)
             {
                 cp_Employee_Single_Given_EmployeeID_Result cp = Methods_Employee.Details_View(UserID);
                 Model_Employee res = new Model_Employee();

                 res.UserID = cp.Emp_EmployeeID;
                 res.WorkSiteID = cp.Emp_WorkSiteID;
                 res.MembershipAPIUserID = cp.User_MembershipAPIUserID;
                 res.HasSystemAccess = cp.Emp_HasSystemAccess;
                 res.EmployeeHierarchyID = cp.Emp_EmployeeHierarchyID;
                 res.DateTimeLastAcess = cp.Emp_DateTimeLastAccess.HasValue ? cp.Emp_DateTimeLastAccess.Value : new DateTime();
                 res.AndroidPhoneAppID = cp.User_AndroidPhoneAppID;
                 res.DOB = cp.User_DOB.HasValue ? cp.User_DOB.Value : new DateTime();
                 res.DateEmployed = cp.User_DateRegistered;
                 res.IDNumber = cp.User_IDNumber;
                 res.Surname = cp.User_Surname;
                 res.Name = cp.User_Name;
                 res.Email = cp.User_Email;
                 res.PhoneNumber = cp.User_PhoneNumber;
                 res.Gender = cp.User_Gender;
                 res.ProfEmployeePicLink = cp.Emp_ProfessionalEmployeePic;
                 res.CasualUserPictureLink = cp.User_CasualUserPicture;

                 return res;
             }

             public static bool Employee_Update(Model_Employee viewModel)
             {


                 int ret = EmployeeAccess.Employee_Update(viewModel.UserID, viewModel.EmployeeHierarchyID, viewModel.WorkSiteID,
                       viewModel.HasSystemAccess, viewModel.ProfEmployeePicLink, viewModel.DateEmployed, viewModel.MembershipAPIUserID, viewModel.AndroidPhoneAppID,
                       viewModel.IDNumber, viewModel.DOB, viewModel.Name, viewModel.Surname, viewModel.Gender.ToString(), viewModel.CasualUserPictureLink,
                       viewModel.DateEmployed, viewModel.Email, viewModel.PhoneNumber);

                 if (ret == 0)
                 {
                     return false;
                 }
                 return true;
             }

             // List Functions ==========================================================================================================
             public static IEnumerable<cp_Employee_List_Result> List(byte SiteID = (byte)0)
             {
                 if (SiteID == 0)
                 {
                     return EmployeeAccess.Employee_List();
                 }
                 else
                 {
                     /*
                      * optimising on lists from database and using comparison validation to chose required results
                      * */
        /* IEnumerable<cp_Employee_List_Result> enumRes = EmployeeAccess.Employee_List();
         List<cp_Employee_List_Result> listRes = enumRes.ToList<cp_Employee_List_Result>();
         List<cp_Employee_List_Result> res = new List<cp_Employee_List_Result>();

         foreach (cp_Employee_List_Result item in listRes)
         {
             if (item.Emp_WorkSiteID == SiteID)
             {
                 res.Add(item);
             }
         }
         return res;
     }

 }
 /**
        public static IEnumerable<cp_Employee_List_Given_SiteID_Result> ListGivenSiteID(byte workSiteID)
        {
            return EmployeeAccess.Employee_ListGivenSiteID(workSiteID);
            //return true;        
        }*/

        // Details Functions ==========================================================================================================
        /*  public static cp_Employee_Single_Given_EmployeeID_Result Details_View(Guid userID)
          {
              IEnumerable<cp_Employee_Single_Given_EmployeeID_Result> EnumRes = EmployeeAccess.Employee_Details_View(userID);
              List<cp_Employee_Single_Given_EmployeeID_Result> ListRes = EnumRes.ToList<cp_Employee_Single_Given_EmployeeID_Result>();

              return ListRes.FirstOrDefault();
              // return true;

          }

          //using web API ID
          public static cp_Employee_Single_Given_EmployeeID_Result Details_View(int memAPIid)
          {
              IEnumerable<cp_Employee_Single_Given_EmployeeID_Result> EnumRes = EmployeeAccess.Employee_Details_GivenAPIID(memAPIid);
              List<cp_Employee_Single_Given_EmployeeID_Result> ListRes = EnumRes.ToList<cp_Employee_Single_Given_EmployeeID_Result>();

              return ListRes.FirstOrDefault();
              // return true;

          }
          public static void Employee_Deletion(Guid userID)
          {
              EmployeeAccess.Employee_Delete(userID);
              //return true;
          }

      } */
    }
}
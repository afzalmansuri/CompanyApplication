using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyApp.Models
{
   public class vEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }

        public string Email { get; set; }


        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string Experience { get; set; }
        public DateTime JoiningDate { get; set; }


        public string Status { get; set; }
       
        public string  BusinessUnitName { get; set; }

        public vEmployee()
        {

        }
    }
}

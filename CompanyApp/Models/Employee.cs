using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyApp.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey(nameof(BusinessUnit))]
        public int BusinessUnitId { get; set; }


        public Employee(string ename,string mobile,string email,string gender,string qua,string experience,DateTime joining,string status,int businessid )
        {
            this.Name = ename;
            this.MobileNumber = mobile;
            this.Email = email;
            
            this.Gender = gender;
            this.Qualification = qua;
            this.Experience = experience;
            this.JoiningDate = joining;
            this.Status = status;
            this.BusinessUnitId = businessid;


        }

        public Employee()
        {

        }
    }
}

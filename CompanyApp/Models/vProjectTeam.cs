using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyApp.Models
{
   public  class vProjectTeam
    {
        [Key]
        public int ProjectTeamId { get; set; }

        public string ProjectName { get; set; }
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        
        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }
        public string Designation { get; set; }
        public string BusinessUnitName { get; set; }


    }
}

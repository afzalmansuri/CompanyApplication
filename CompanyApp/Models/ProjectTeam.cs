using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyApp.Models
{
   public class ProjectTeam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProjectTeamId { get; set; }

        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public string Designation { get; set; }

        public ProjectTeam(int projectid,int empid,string desg)
        {
            this.ProjectId = projectid;
            this.EmployeeId = empid;
            this.Designation = desg;

        }
        public ProjectTeam()
        {

        }
    }
}

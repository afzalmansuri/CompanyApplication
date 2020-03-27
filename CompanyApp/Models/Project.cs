
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyApp.Models
{
   public  class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        [ForeignKey(nameof(BusinessUnit))]
        public int BusinessUnitId { get; set; }

        public Project(string projectname,int businessid)
        {
            this.ProjectName = projectname;
            this.BusinessUnitId = businessid;

        }

        public Project()
        {

        }

    }
}

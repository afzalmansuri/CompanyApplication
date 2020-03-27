using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyApp.Models
{
   public class vProject
    {
        [Key]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

       
        public string BusinessUnitName { get; set; }

        public vProject()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CompanyApp.Models
{
    public class BusinessUnit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }

        public BusinessUnit(string unitname)
        {
            this.BusinessUnitName = unitname;
        }

        public BusinessUnit()
        {

        }
    }
}

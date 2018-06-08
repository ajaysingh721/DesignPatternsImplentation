﻿namespace Implementation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string JobDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }

        public decimal HourlyPay { get; set; }

        public decimal Bonus { get; set; }

        public int EmployeeTypeID { get; set; }

        public virtual Employee_Type Employee_Type { get; set; }
    }
}
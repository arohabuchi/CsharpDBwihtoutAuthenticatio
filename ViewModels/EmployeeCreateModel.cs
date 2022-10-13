using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using EmlpoyeeMgt.Models;


namespace EmlpoyeeMgt.ViewModels
{
    public class EmployeeCreateModel
    {
         [Required]
        [MaxLength(50, ErrorMessage="Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage="Invalid Email Format")]
        // to use a different display name add
        // [Display(Name="Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept Department { get; set; }
        
        public IFormFile Photo { get; set; }
    }
}
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLogo.Core.Models;

public class Project : BaseEntity  
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
    
    public string ImageUrl { get; set; }
    [NotMapped]
    public IFormFile ImageFile { get; set; }

   
}

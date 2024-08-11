using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShamiEmployeeMangement.Models;

public partial class Signup
{
   
    public string Username { get; set; } = null!;
  
    public string? Password { get; set; }
   
    public string? Confirmpassword { get; set; }
}

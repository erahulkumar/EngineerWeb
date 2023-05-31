using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DTO
{
    public class UserDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid Password")]
        public string Password { get; set; }
        public string Emali { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public bool isAdmin { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace D16EF02Task.Entities
{
    public class ManagerLoginKitchen
    {
        [Key]
        [MaxLength(30)]
        [Unicode]
        public required String Username { get; set; }
        [MaxLength(30)]
        [Unicode]
        public required String Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppAccount
    {
        public int Id { get; set; }

        public List<AppUser> Users {get; set;}
    }
}
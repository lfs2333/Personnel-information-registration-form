using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personnel_information_registration_form.Models;

namespace Personnel_information_registration_form.Data
{
    public class Personnel_information_registration_formContext : DbContext
    {
        public Personnel_information_registration_formContext (DbContextOptions<Personnel_information_registration_formContext> options)
            : base(options)
        {
        }

        public DbSet<Personnel_information_registration_form.Models.student> student { get; set; }
    }
}

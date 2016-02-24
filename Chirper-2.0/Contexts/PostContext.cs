using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper_2._0.Models;

namespace Chirper_2._0.Contexts
{
    class PostContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}

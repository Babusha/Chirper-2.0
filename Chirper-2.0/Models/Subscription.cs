using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chirper_2._0.Models
{
    public class Subscription
    {
        [Key] public int Id { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{

    public class Demo
    {
        public int userId { get; set; }
        public int UserName { get; set; }
    }
}
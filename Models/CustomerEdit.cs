using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneralStoreAPI.Models
{
    public class CustomerEdit
    {
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
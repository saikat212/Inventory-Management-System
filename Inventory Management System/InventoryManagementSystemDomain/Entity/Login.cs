using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.InventoryManagementSystemDomain.Entity
{
    public class Login
    {

        public Login() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SHOPRITE_INVENTORY_SYSTEM
{
    internal class Inventory
    {
        public MySqlConnection cn;
        public void Connect()
        {
            cn = new MySqlConnection("Datasource = 127.0.0.1;username = root;password = LIVERPOOL; database = shoprite_inventory;");
    ;    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOrders
{
    public static class ConfigDB
    {
        private const string HOST = "localhost";
        private const string USERNAME = "postgres";
        private const string PASSWORD = "0000";
        private const string DATABASE = "auto";

        public static string CON_STR => $"Host={HOST};Username={USERNAME};Password={PASSWORD};Database={DATABASE}";
    }

}

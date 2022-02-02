using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using App.v2.Models;

namespace App.Models
{
    public static class SteamClient
    {
        public static DataStorage dataStorage = new DataStorage(Path.GetFullPath(Path.Combine(Path.Combine(AppContext.BaseDirectory, "..\\..\\") ,"Saves")));
        public static Account CurrentAccount { get; set; }

        public static AccountManager accountManager = new AccountManager();
    }
}

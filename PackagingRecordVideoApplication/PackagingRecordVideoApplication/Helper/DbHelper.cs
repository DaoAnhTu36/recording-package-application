using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace PackagingRecordVideoApplication.Helper
{
    public class DbHelper
    {
        //private string connStr = "Server=localhost;Database=package_recording_db;Uid=root;Pwd=123456;";
        private string connStr = "Server=42.112.110.59;Database=taphoagi_package_recording_db;Uid=taphoagi_admin;Pwd=Daoanhtu020996@@#;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}
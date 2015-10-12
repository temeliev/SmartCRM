namespace SmartCRM.BOL
{
    using System;
    using System.IO;

    using SmartCRM.DAL;

    public class DbManager
    {
        private static string format = "Database={0}; Server={1}; port={2}; User Id={3}; Password={4}; charset=utf8; AllowUserVariables=True";
        private static string connectionString;

        static DbManager()
        {
            if (!File.Exists("conn.txt"))
            {
                throw new ApplicationException("Няма conn.txt!");
            }

            string host = string.Empty;
            int port = 3306;
            string[] file = File.ReadAllLines("conn.txt");
            foreach (string line in file)
            {
                if (line.StartsWith("Host"))
                {
                    host = line.Remove(0, 5);
                }
                else if (line.StartsWith("Port"))
                {
                    port = Convert.ToInt32(line.Remove(0, 5));
                }
            }

            connectionString = string.Format(format, "smart_crm", host, port, "root", "root");
        }

        public static SmartCRMEntitiesModel CreateInstance()
        {
            return new SmartCRMEntitiesModel(connectionString);
        }
    }
}

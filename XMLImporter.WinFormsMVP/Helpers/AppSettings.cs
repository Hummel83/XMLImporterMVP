using System.Configuration;

namespace XMLImporter.WinFormsMVP.Helpers
{
    public class AppSettings
    {
        public static string FileName
        {
            get
            {
                return ConfigurationManager.AppSettings["fileName"];
            }
        }
    }
}

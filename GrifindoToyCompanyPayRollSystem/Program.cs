using System.Data.SqlClient;
using System.Data;

using static GrifindoToyCompanyPayRollSystem.GrifindoComponents;

namespace GrifindoToyCompanyPayRollSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsTheTableExists(adminTable))
                Application.Run(new GrindoLogin());
            else
                Application.Run(new GrindoSignup());


        }
    }
        
    }
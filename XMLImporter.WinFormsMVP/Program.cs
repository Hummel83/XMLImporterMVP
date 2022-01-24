using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLImporter.WinFormsMVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Add handler for UI thread exceptions and force all errors to go through handler
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //Configure DI
            ConfigDI();

            //Run
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Configure Dependency Injection
        /// </summary>
        private static void ConfigDI()
        {
            Infrastructure.DI.CompositionRoot.Wire(new Infrastructure.DI.NinjectBindingsModule());
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether
        // or not they wish to abort execution.
        private static void UIThreadException(object sender, ThreadExceptionEventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowExceptionDialog("Unbehandelte Fehler.", e.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Error", "Fatal Windows Forms Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Displays Exception message.
        /// </summary>
        /// <param name="title">The text to display in the title bar of the message box</param>
        /// <param name="ex">Exception</param>
        /// <returns>DialogResult enum</returns>
        private static DialogResult ShowExceptionDialog(string title, Exception ex)
        {
            string errorMsg = $"Ein Fehler ist aufgetreten.\n\n";
            errorMsg = $"{errorMsg} Fehler Information: \n - {ex.Message} \n\n";
            errorMsg = $"{errorMsg} Stack Trace: \n - {ex.StackTrace} \n\n";
            errorMsg = $"{errorMsg} \n\n Möchten Sie die Anwendung beenden?";

            return MessageBox.Show(errorMsg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }
    }
}

using proje.Forms;

namespace proje
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // BURAYI DEÐÝÞTÝRÝYORUZ:
            Application.Run(new login());
        }
    }
}
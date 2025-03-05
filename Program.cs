using System.Windows.Forms;

namespace OgrenciOdevKontrolListesi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new KilitEkranı());
            ApplicationConfiguration.Initialize();

            KilitEkranı form = new KilitEkranı();

            var cevap = form.ShowDialog();//bloklanýyor ve cevap bekleniyor

            if (cevap == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
    }
}
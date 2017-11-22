namespace RentalCars.UI
{
    using System;
    using System.Runtime.Remoting.Channels;
    using System.Windows.Forms;

    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.ApplicationExit += (sender, e) =>
            {
                Customer.SaveToStorage();
                Employee.SaveToStorage();
                Car.SaveToStorage();               
            };
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Initialize();
            Application.Run(new Main());
        }

        private static void Initialize()
        {
            // CarYard.Instance.Seed();
        }
    }
}

namespace Projeto_Tabacaria
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyAppContext(new LoginScreen()));
        }
        public class MyAppContext : ApplicationContext
        {
            public MyAppContext(Form startingForm)
            {
                startingForm.Show();
                Application.Idle += Application_Idle;
            }

            private void Application_Idle(object sender, EventArgs e)
                {
                if (Application.OpenForms.Count == 0)
                {
                    Application.Exit();
                }
            }

        }
    }
}
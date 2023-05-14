using IS_5.Controler;
using IS_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_5
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new OrganizationView());
            OrganizationView view = new OrganizationView();
            view.Visible = false;
            var organizations = new List<Organization>
            {
                new Organization("1213", "123", "123", "1234", TypeOrganizations.first, TypeOfPred.second)
            };
            var controller = new OrganizationController(view, organizations);
            controller.LoadView();
            view.ShowDialog();
        }

    }
}

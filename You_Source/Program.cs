﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace You_Source
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
            Application.Run(new frmMain());

            //View view = new View();
            //Model model = new Model();
            //Controller controller = new Controller(view,model);
            //controller.setString(form2.getStringValue());
            //controller.setSortingMethod(form2.getSortingMethod());
            //controller.updateView();
            //Console.WriteLine("TEST");
        }
    }
}

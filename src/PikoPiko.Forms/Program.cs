﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PikoPiko.Forms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GameView(new GameContext("Maider", "Jorge", "Roberto", "Sara", "David", "Iratxe")));

            //Application.Run(new WinnerView(new GameContext("Maider", "Jorge", "Roberto", "Sara", "David", "Iratxe")));
            Application.Run(new MainMenu());
        }
    }
}

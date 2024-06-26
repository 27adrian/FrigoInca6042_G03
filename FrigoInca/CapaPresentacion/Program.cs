﻿using CapaPresentacion;
using FrigoInca;
using System;
using System.Windows.Forms;
using Menu = CapaPresentacion.Menu;

namespace SistemaVentasUPN
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
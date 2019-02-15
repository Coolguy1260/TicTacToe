using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TicTacToe
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
            MessageBoxManager.Yes = "Singleplayer";
            MessageBoxManager.No = "Multiplayer";
            MessageBoxManager.Cancel = "Exit";
            MessageBoxManager.OK = "Restart";
            MessageBoxManager.Register();
            while (true)
            {
                var result = MessageBox.Show("Choose your mode!", "Welcome!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Application.Run(new TicTacToeTwoPlayer());
                }
                else if (result == DialogResult.Yes)
                {
                    Application.Run(new TicTacToeOnePlayer());
                }
                else
                {
                    break;
                }
            }
            MessageBoxManager.Unregister();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MywindowApp
{
    class MainApp : Form
    {
        public MainApp(string title)
        {
            this.Text = title; 
            
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event App")); 
        }
    }

    
}

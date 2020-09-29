using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Dave_Menu
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Child> children = new List<Child>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(children));

           
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dave_Menu
{
    public partial class NameNext : Form
    {
        List<Child> childList = new List<Child>();
        public NameNext(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void NameNext_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGenerateName;

            Random rnd = new Random();
            int month = rnd.Next(1, 13);

            if (txtNewName.Text == "")
                txtNewName.Text = "New Name";
        }

        private void btnGenerateName_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int length = r.Next(1, 9);
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; 
            while (b < length)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }
            txtNewName.Text = Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

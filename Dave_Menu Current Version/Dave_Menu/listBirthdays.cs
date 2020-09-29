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
    public partial class listBirthdays : Form
    {
        List<Child> childList = new List<Child>();
        public listBirthdays(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void listBirthdays_Load(object sender, EventArgs e)
        {
            listViewBirthdays.View = View.Details;
            listViewBirthdays.Columns.Add("Name", 150);
            listViewBirthdays.Columns.Add("Date of Birth", 150);
            listViewBirthdays.Columns.Add("Description", 150);

            childList.Sort(new Child.CompareAge());
            DateTime today = DateTime.Now.Date;
            DateTime weekCheck = DateTime.Now.AddDays(7);

            foreach (Child child in childList)
            {
                if (child.DoB.Day >= today.Day && child.DoB.Day <= weekCheck.Day && child.DoB.Month == today.Month)
                {
                    String[] birthdaysArr = new String[3];
                    birthdaysArr[0] = child.Name;
                    birthdaysArr[1] = child.DoB.ToString("d");
                    birthdaysArr[2] = child.Description;
                    ListViewItem itm;
                    itm = new ListViewItem(birthdaysArr);
                    listViewBirthdays.Items.Add(itm);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

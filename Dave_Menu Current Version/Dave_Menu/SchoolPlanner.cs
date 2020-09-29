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
    public partial class SchoolPlanner : Form
    {
        List<Child> childList = new List<Child>();
        public SchoolPlanner(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SchoolPlanner_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listPlanner.Clear();
            int inputtedYear = Convert.ToInt32(txtYear.Text);

            listPlanner.View = View.Details;
            listPlanner.Columns.Add("Name", 150);
            listPlanner.Columns.Add("Milestone", 150);

            childList.Sort(new Child.CompareAge());

            DateTime septCheck = new DateTime(inputtedYear, 9, 1);

            for (int i = 0; i < childList.Count; i++)
            {
                int ageinDays = Convert.ToInt32((septCheck - childList[i].DoB).TotalDays);
                int age = ageinDays / 365;

                if (age < 5 && age > 0)
                {
                    String[] schoolPreschool = new String[3];
                    schoolPreschool[0] = childList[i].Name;
                    schoolPreschool[1] = "Pre-School";
                    ListViewItem itm;
                    itm = new ListViewItem(schoolPreschool);
                    listPlanner.Items.Add(itm);
                }
                else if (age >= 5 && age <= 13)
                {
                    String[] schoolPrimary = new String[3];
                    schoolPrimary[0] = childList[i].Name;
                    schoolPrimary[1] = "Primary School";
                    ListViewItem itm;
                    itm = new ListViewItem(schoolPrimary);
                    listPlanner.Items.Add(itm);
                }
                else if (age > 13 && age <= 19)
                {
                    String[] schoolSecondary = new String[3];
                    schoolSecondary[0] = childList[i].Name;
                    schoolSecondary[1] = "Secondary School";
                    ListViewItem itm;
                    itm = new ListViewItem(schoolSecondary);
                    listPlanner.Items.Add(itm);
                }
                else if (age > 19 && age <= 23)
                {
                    String[] schoolThird = new String[3];
                    schoolThird[0] = childList[i].Name;
                    schoolThird[1] = "Third Level";
                    ListViewItem itm;
                    itm = new ListViewItem(schoolThird);
                    listPlanner.Items.Add(itm);
                }
                else if (age > 23)
                {
                    String[] schoolFinished = new String[3];
                    schoolFinished[0] = childList[i].Name;
                    schoolFinished[1] = "Finished";
                    ListViewItem itm;
                    itm = new ListViewItem(schoolFinished);
                    listPlanner.Items.Add(itm);
                }
            }

            txtYear.Text = null;

        }
    }
}
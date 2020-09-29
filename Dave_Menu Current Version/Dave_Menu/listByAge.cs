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
    public partial class listByAge : Form
    {
        List<Child> childList = new List<Child>();
        public listByAge(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        
        private void listByAge_Load(object sender, EventArgs e)
        {
            listViewAge.View = View.Details;
            listViewAge.Columns.Add("Name", 150);
            listViewAge.Columns.Add("Date of Birth", 150);
            listViewAge.Columns.Add("Description", 150);
            
            childList.Sort(new Child.CompareAge());

            foreach(Child child in childList)
            {
                String[] sortByAgeArr = new String[3];
                sortByAgeArr[0] = child.Name;
                sortByAgeArr[1] = child.DoB.ToString("d");
                sortByAgeArr[2] = child.Description;
                ListViewItem itm;
                itm = new ListViewItem(sortByAgeArr);
                listViewAge.Items.Add(itm);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

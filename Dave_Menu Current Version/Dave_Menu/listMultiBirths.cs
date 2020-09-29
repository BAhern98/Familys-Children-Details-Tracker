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
    public partial class listMultiBirths : Form
    {
        List<Child> childList = new List<Child>();
        public listMultiBirths(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listMultiBirths_Load_1(object sender, EventArgs e)
        {
            listMultiples.View = View.Details;
            listMultiples.Columns.Add("Name", 150);
            listMultiples.Columns.Add("Date of Birth", 150);
            listMultiples.Columns.Add("Description", 150);
            listMultiples.Columns.Add("Type", 150);

            childList.Sort(new Child.CompareAge());

            int matchCount = 0;
            for (int i = 0; i < childList.Count; i++)
            {
                matchCount = 0;
                foreach (Child c in childList)
                {
                    if (childList[i].DoB == c.DoB)
                        matchCount++;
                }

                if (matchCount == 2)
                {
                    String[] arrTwins = new String[4];
                    arrTwins[0] = childList[i].Name;
                    arrTwins[1] = childList[i].DoB.ToString("d");
                    arrTwins[2] = childList[i].Description;
                    arrTwins[3] = "Twins";
                    ListViewItem itm;
                    itm = new ListViewItem(arrTwins);
                    listMultiples.Items.Add(itm);
                }

                else if (matchCount == 3)
                {

                    String[] arrTriplets = new String[4];
                    arrTriplets[0] = childList[i].Name;
                    arrTriplets[1] = childList[i].DoB.ToString("d");
                    arrTriplets[2] = childList[i].Description;
                    arrTriplets[3] = "Triplets";
                    ListViewItem itm;
                    itm = new ListViewItem(arrTriplets);
                    listMultiples.Items.Add(itm);
                }

                else if (matchCount == 4)
                {
                    String[] arrQuads = new String[4];
                    arrQuads[0] = childList[i].Name;
                    arrQuads[1] = childList[i].DoB.ToString("d");
                    arrQuads[2] = childList[i].Description;
                    arrQuads[3] = "Quadroplet";
                    ListViewItem itm;
                    itm = new ListViewItem(arrQuads);
                    listMultiples.Items.Add(itm);
                }
            }
        }
    }
}

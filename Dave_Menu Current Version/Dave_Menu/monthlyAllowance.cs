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
    public partial class monthlyAllowance : Form
    {
        List<Child> childList = new List<Child>();
        public monthlyAllowance(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }
        private void monthlyAllowance_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
                double allowence = 0, basecost = 140;
                int repeatbirth = 1;
                DateTime previousBirth = new DateTime();
                int year = DateTime.Today.Year;
                int month = DateTime.Today.Month;

                DateTime StartDay = new DateTime(year, month, 1);
                DateTime SecondDay = new DateTime(year - 18, month, 1);


                childList.Sort(new Child.CompareAge());
                foreach (Child c in childList)
                {
                    if (c.DoB < StartDay && c.DoB >= SecondDay)
                    {
                        allowence += basecost;

                        if (c.DoB == previousBirth)
                        {

                            if (repeatbirth == 1)
                                allowence += basecost;
                            else if (repeatbirth == 2)
                                allowence += basecost * 2;
                            else if (repeatbirth > 2)
                                allowence += basecost;
                            repeatbirth++;
                        }
                        else
                        {
                            repeatbirth = 1;

                        }
                        previousBirth = c.DoB;


                    }

                }
                txtDisplay.Text = allowence.ToString("c");
            }
    }
}
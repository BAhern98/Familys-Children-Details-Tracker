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
    public partial class Infographic : Form
    {
        List<Child> childList = new List<Child>();
        public Infographic(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Infographic_Load(object sender, EventArgs e)
        {
            int count = 0, singles = 0, twins = 0, triplets = 0;


            for (int i = 0; i < childList.Count; i++)
            {
                foreach(Child child in childList)
                {
                    if (childList[i].DoB == child.DoB)
                        count++;
                }

                if (count == 1)
                {
                    singles++;
                }
                else if (count == 2)
                {
                    twins++;
                }
                else if (count == 3)
                {
                    triplets++;
                }
                count = 0;
            }
            chartMultiBirths.Series["MultiBirths"].Points.AddY(singles);
            chartMultiBirths.Series["MultiBirths"].Points.AddY(twins);
            chartMultiBirths.Series["MultiBirths"].Points.AddY(triplets);

            chartMultiBirths.Series["MultiBirths"].Points[0].LegendText = "Single Births";
            chartMultiBirths.Series["MultiBirths"].Points[1].LegendText = "Twins";
            chartMultiBirths.Series["MultiBirths"].Points[2].LegendText = "Triplets";


            for (int i = 0; i < childList.Count; i++)
            {
                int age = DateTime.Now.Year - childList[i].DoB.Year;
                chartAges.Series["Age"].Points.AddXY(childList[i].Name, age);
            }
            chartAges.Series["Age"]["PixelPointWidth"] = "7";
            chartAges.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chartAges.ChartAreas["ChartArea1"].AxisY.Interval = 2;
            chartAges.Series["Age"].LegendText = "Age of Children";


            int inputtedYear = 2018;
            int preSchool = 0, primarySchool = 0, secondarySchool = 0, thirdLevel = 0, finished = 0;

            childList.Sort(new Child.CompareAge());

            DateTime septCheck = new DateTime(inputtedYear, 9, 1);

            for (int i = 0; i < childList.Count; i++)
            {
                int ageinDays = Convert.ToInt32((septCheck - childList[i].DoB).TotalDays);
                int age = ageinDays / 365;

                if (age < 5 && age > 0)
                {
                    preSchool++;
                }
                else if (age >= 5 && age <= 13)
                {
                    primarySchool++;
                }
                else if (age > 13 && age <= 19)
                {
                    secondarySchool++;
                }
                else if (age > 19 && age <= 23)
                {
                    thirdLevel++;
                }
                else if (age > 23)
                {
                    finished++;
                }
            }
            chartPlanner.Series["School Planner"].Points.AddY(preSchool);
            chartPlanner.Series["School Planner"].Points.AddY(primarySchool);
            chartPlanner.Series["School Planner"].Points.AddY(secondarySchool);
            chartPlanner.Series["School Planner"].Points.AddY(thirdLevel);
            chartPlanner.Series["School Planner"].Points.AddY(finished);


            chartPlanner.Series["School Planner"].Points[0].LegendText = "Pre-School";
            chartPlanner.Series["School Planner"].Points[1].LegendText = "Primary School";
            chartPlanner.Series["School Planner"].Points[2].LegendText = "Secondary School";
            chartPlanner.Series["School Planner"].Points[3].LegendText = "Third Level";
            chartPlanner.Series["School Planner"].Points[4].LegendText = "Finished";


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Dave_Menu
{

    public partial class Form1 : Form
    {
        List<Child> childList = new List<Child>();
        public Form1(List<Child> children)
        {
            childList = children;
            InitializeComponent();
        }

        private void btnMultiBirths_Click(object sender, EventArgs e)
        {
            listMultiBirths displayMultiBirths = new listMultiBirths(childList);
            displayMultiBirths.ShowDialog();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
            string xmlPath = @"../../childData.xml";
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader xmlIn = XmlReader.Create(xmlPath, settings);

            if (xmlIn.ReadToDescendant("child"))
            {
                do
                {
                    Child child = new Child();
                    xmlIn.ReadStartElement("child");
                    child.Name = xmlIn.ReadElementContentAsString();
                    child.DoB = DateTime.Parse(xmlIn.ReadElementContentAsString());
                    child.Description = xmlIn.ReadElementContentAsString();
                    childList.Add(child);
                }
                while (xmlIn.ReadToNextSibling("child"));
            }
            xmlIn.Close();
            foreach (Child child in childList)
            {               
                results.Items.Add(child.Name + " - " + child.DoB.ToString("d") + " - " + child.Description);
            }

            btnUpload.Enabled = false;
            btnRefresh.Enabled = true;
        }

        private void btnBirthdays_Click(object sender, EventArgs e)
        {
            listBirthdays displayBirthdays = new listBirthdays(childList);
            displayBirthdays.ShowDialog();
        }

        private void btnListByAge_Click(object sender, EventArgs e)
        {
            listByAge displayByAge = new listByAge(childList);
            displayByAge.ShowDialog();

        }

        private void btnAlphabetical_Click(object sender, EventArgs e)
        {
            listByName displayByName = new listByName(childList);
            displayByName.ShowDialog();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            AddChild displayAddChild = new AddChild(childList);           
            displayAddChild.ShowDialog();
        }

        private void btnNameNext_Click(object sender, EventArgs e)
        {
            NameNext displayNameNext = new NameNext(childList);
            displayNameNext.ShowDialog();
        }

        private void btnMonthlyAllowance_Click(object sender, EventArgs e)
        {
            monthlyAllowance displayAnnual = new monthlyAllowance(childList);
            displayAnnual.ShowDialog();
        }

        private void btnAnnualAllowance_Click(object sender, EventArgs e)
        {
            annualAllowance displayMonthly = new annualAllowance(childList);
            displayMonthly.ShowDialog();
        }
        private void btnSchoolTimes_Click(object sender, EventArgs e)
        {
            SchoolPlanner displayPlanner = new SchoolPlanner(childList);
            displayPlanner.ShowDialog();
        }

        private void btnInfoGraphic_Click(object sender, EventArgs e)
        {
            Infographic displayInfographic = new Infographic(childList);
            displayInfographic.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            results.Items.Clear();

            foreach (Child child in childList)
            {
                results.Items.Add(child.Name + " - " + child.DoB.ToString("d") + " - " + child.Description);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

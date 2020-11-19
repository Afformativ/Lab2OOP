using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Xml.Xsl;

namespace EventsDota
{
    public partial class Form1 : Form
    {
        private string path = @"D:\Proga\EventsDota\EventsDota\bin\Debug\EventsDataBase.xml";
        private string pathXsl = @"D:\Proga\EventsDota\EventsDota\bin\Debug\DataBase.xsl";
        private List<Events> events;
        public Form1()
        {
            InitializeComponent();
            buildBox();
            comboBoxRunnerUp.Enabled = false;
            comboBoxPrizePool.Enabled = false;
            comboBoxEndDate.Enabled = false;
            comboBoxCity.Enabled = false;
            comboBoxCountry.Enabled = false;
            comboBoxDPCPoints.Enabled = false;
            comboBoxStartDate.Enabled = false;
            comboBoxName.Enabled = false;
            comboBoxNumberOfTeams.Enabled = false;
            comboBoxValue.Enabled = false;
            comboBoxWinner.Enabled = false;
            radioLINQ.Checked = true;
            btnOpenHTML.Enabled = false;
        }
        public void buildBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement Xpath = doc.DocumentElement;
            XmlNodeList childNodes = Xpath.SelectNodes("Event");
            for(int i = 0; i < childNodes.Count; i++)
            {
                XmlNode n = childNodes.Item(i);
                addItems(n);
            }
            comboBoxValue.Text = comboBoxValue.Items[0].ToString();
            comboBoxName.Text = comboBoxName.Items[0].ToString();
            comboBoxStartDate.Text = comboBoxStartDate.Items[0].ToString();
            comboBoxEndDate.Text = comboBoxEndDate.Items[0].ToString();
            comboBoxCountry.Text = comboBoxCountry.Items[0].ToString();
            comboBoxCity.Text = comboBoxCity.Items[0].ToString();
            comboBoxPrizePool.Text = comboBoxPrizePool.Items[0].ToString();
            comboBoxDPCPoints.Text = comboBoxDPCPoints.Items[0].ToString();
            comboBoxWinner.Text = comboBoxWinner.Items[0].ToString();
            comboBoxRunnerUp.Text = comboBoxRunnerUp.Items[0].ToString();
            comboBoxNumberOfTeams.Text = comboBoxNumberOfTeams.Items[0].ToString();

        }
        void addItems(XmlNode n)
        {
            if (!comboBoxValue.Items.Contains(n.SelectSingleNode("@VALUE").Value))
            {
                comboBoxValue.Items.Add(n.SelectSingleNode("@VALUE").Value);
            }
            if (!comboBoxName.Items.Contains(n.SelectSingleNode("@NAME").Value))
            {
                comboBoxName.Items.Add(n.SelectSingleNode("@NAME").Value);
            }
            if (!comboBoxStartDate.Items.Contains(n.SelectSingleNode("@START").Value))
            {
                comboBoxStartDate.Items.Add(n.SelectSingleNode("@START").Value);
            }
            if (!comboBoxEndDate.Items.Contains(n.SelectSingleNode("@END").Value))
            {
                comboBoxEndDate.Items.Add(n.SelectSingleNode("@END").Value);
            }
            if (!comboBoxCountry.Items.Contains(n.SelectSingleNode("@COUNTRY").Value))
            {
                comboBoxCountry.Items.Add(n.SelectSingleNode("@COUNTRY").Value);
            }
            if (!comboBoxCity.Items.Contains(n.SelectSingleNode("@CITY").Value))
            {
                comboBoxCity.Items.Add(n.SelectSingleNode("@CITY").Value);
            }
            if (!comboBoxPrizePool.Items.Contains(n.SelectSingleNode("@PRIZEPOOL").Value))
            {
                comboBoxPrizePool.Items.Add(n.SelectSingleNode("@PRIZEPOOL").Value);
            }
            if (!comboBoxDPCPoints.Items.Contains(n.SelectSingleNode("@DPC").Value))
            {
                comboBoxDPCPoints.Items.Add(n.SelectSingleNode("@DPC").Value);
            }
            if (!comboBoxWinner.Items.Contains(n.SelectSingleNode("@WINNER").Value))
            {
                comboBoxWinner.Items.Add(n.SelectSingleNode("@WINNER").Value);
            }
            if (!comboBoxRunnerUp.Items.Contains(n.SelectSingleNode("@RUNNERUP").Value))
            {
                comboBoxRunnerUp.Items.Add(n.SelectSingleNode("@RUNNERUP").Value);
            }
            if (!comboBoxNumberOfTeams.Items.Contains(n.SelectSingleNode("@NUMBEROFTEAMS").Value))
            {
                comboBoxNumberOfTeams.Items.Add(n.SelectSingleNode("@NUMBEROFTEAMS").Value);
            }
        }

       

        private void IntoHTML()
        {
            XslCompiledTransform xsl = new XslCompiledTransform();
            xsl.Load(@"D:\Proga\EventsDota\EventsDota\bin\Debug\DataBase.xsl");
            string input = @"D:\Proga\EventsDota\EventsDota\bin\Debug\Transform.xml";
            string result = @"D:\Proga\EventsDota\EventsDota\bin\Debug\HTML.html";
            xsl.Transform(@"D:\Proga\EventsDota\EventsDota\bin\Debug\Transform.xml", @"D:\Proga\EventsDota\EventsDota\bin\Debug\HTML.html");
            MessageBox.Show("Виконано!");
        }
        private void Clear()
        {
            richTextBox1.Clear();
            radioDOM.Checked = false;
            radioLINQ.Checked = false;
            radioSAX.Checked = false;
            comboBoxCountry.Text = null;
            comboBoxCity.Text = null;
            comboBoxDPCPoints.Text = null;
            comboBoxEndDate.Text = null;
            comboBoxName.Text = null;
            comboBoxNumberOfTeams.Text = null;
            comboBoxPrizePool.Text = null;
            comboBoxRunnerUp.Text = null;
            comboBoxStartDate.Text = null;
            comboBoxValue.Text = null;
            comboBoxWinner.Text = null;
            checkBoxCity.Checked = false;
            checkBoxCountry.Checked = false;
            checkBoxDPCPoints.Checked = false;
            checkBoxEndDate.Checked = false;
            checkBoxName.Checked = false;
            checkBoxNumberOfTeams.Checked = false;
            checkBoxPrizePool.Checked = false;
            checkBoxRunnerUp.Checked = false;
            checkBoxStartDate.Checked = false;
            checkBoxValue.Checked = false;
            checkBoxWinner.Checked = false;
        }
        private void Help()
        {
            MessageBox.Show("1. Оберіть критерії пошуку.\n" +
                "2. Оберіть метод пошуку ( За замовчуванням LINQ).\n" +
                "3. Натисніть кнопку Search.\n" +
                "4. Якщо ви бажаєте перевести файл у HTML натисніть Transform to HTML та Open HTML.\n" +
                "5. Щоб очистити поля та виконати новий пошук, натисніть Clear", "Help!", MessageBoxButtons.OK);
        }
        private void OpenHTML()
        {
            btnOpenHTML.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            richTextBox1.Text="";
            ClearXML();
            Events events = new Events();
            if (checkBoxValue.Checked)
            {
                events.Value = comboBoxValue.SelectedItem.ToString();
            }
            if (checkBoxName.Checked)
            {
                events.Name = comboBoxName.SelectedItem.ToString();
            }
            if (checkBoxStartDate.Checked)
            {
                events.StartDate = comboBoxStartDate.SelectedItem.ToString();
            }
            if (checkBoxEndDate.Checked)
            {
                events.EndDate = comboBoxEndDate.SelectedItem.ToString();
            }
            if (checkBoxCountry.Checked)
            {
                events.Country = comboBoxCountry.SelectedItem.ToString();
            }
            if (checkBoxCity.Checked)
            {
                events.City = comboBoxCity.SelectedItem.ToString();
            }
            if (checkBoxPrizePool.Checked)
            {
                events.PrizePool = comboBoxPrizePool.SelectedItem.ToString();
            }
            if (checkBoxDPCPoints.Checked)
            {
                events.DpcPoints = comboBoxDPCPoints.SelectedItem.ToString();
            }
            if (checkBoxWinner.Checked)
            {
                events.Winner = comboBoxWinner.SelectedItem.ToString();
            }
            if (checkBoxRunnerUp.Checked)
            {
                events.RunnerUp = comboBoxRunnerUp.SelectedItem.ToString();
            }
            if (checkBoxNumberOfTeams.Checked)
            {
                events.NumberOfTeams = comboBoxNumberOfTeams.SelectedItem.ToString();
            }


            IStrategy parser = new LinqToXML();

            if (radioSAX.Checked)
            {
                parser = new SAX();
            }
            else if (radioDOM.Checked)
            {
                parser = new DOM();
            }
            else if (radioLINQ.Checked)
            {
                parser = new LinqToXML();    
            }
            Searcher search = new Searcher(parser, events);
            List<Events> res = search.SearcherAlgorithm();
            foreach(Events n in res)
            {
                AddToXML(n);
                richTextBox1.AppendText("Value:" + n.Value + "\n");
                richTextBox1.AppendText("Name:" + n.Name + "\n");
                richTextBox1.AppendText("Start Date:" + n.StartDate + "\n");
                richTextBox1.AppendText("End Date:" + n.EndDate + "\n");
                richTextBox1.AppendText("Country:" + n.Country + "\n");
                richTextBox1.AppendText("City:" + n.City + "\n");
                richTextBox1.AppendText("PrizePool:" + n.PrizePool + "\n");
                richTextBox1.AppendText("DPC Points:" + n.DpcPoints + "\n");
                richTextBox1.AppendText("Winner:" + n.Winner + "\n");
                richTextBox1.AppendText("Runner-Up:" + n.RunnerUp + "\n");
                richTextBox1.AppendText("Number of teams:" + n.NumberOfTeams + "\n");
                richTextBox1.AppendText("---------------------------------------\n");
            }
            EndXML();
            if(richTextBox1.Text=="")
            {
                richTextBox1.Text = "Жодних результатів =(";
            }
        }
        void AddToXML(Events events)
        {
            StreamWriter resFile = new StreamWriter(@"D:\Proga\EventsDota\EventsDota\bin\Debug\Transform.xml",true);
            resFile.WriteLine("<Event");
            resFile.WriteLine("VALUE = \"" + events.Value + "\"");
            resFile.WriteLine("NAME = \"" + events.Name + "\"");
            resFile.WriteLine("START = \"" + events.StartDate + "\"");
            resFile.WriteLine("END = \"" + events.EndDate + "\"");
            resFile.WriteLine("COUNTRY = \"" + events.Country + "\"");
            resFile.WriteLine("CITY = \"" + events.City + "\"");
            resFile.WriteLine("PRIZEPOOL = \"" + events.PrizePool + "\"");
            resFile.WriteLine("DPC = \"" + events.DpcPoints + "\"");
            resFile.WriteLine("WINNER = \"" + events.Winner + "\"");
            resFile.WriteLine("RUNNERUP = \"" + events.RunnerUp + "\"");
            resFile.WriteLine("NUMBEROFTEAMS = \"" + events.NumberOfTeams + "\">");
            resFile.WriteLine("</Event>");
            resFile.Close();
        }
        void ClearXML()
        {
            StreamWriter resultsFile = new StreamWriter(@"D:\Proga\EventsDota\EventsDota\bin\Debug\Transform.xml");
            resultsFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            resultsFile.WriteLine("<EventsDataBase>");
            resultsFile.Close();
        }
        void EndXML()
        {
            StreamWriter resultsFile = new StreamWriter(@"D:\Proga\EventsDota\EventsDota\bin\Debug\Transform.xml", true);
            resultsFile.WriteLine("</EventsDataBase>");
            resultsFile.Close();
        }

        private void btnTransToHTML_Click(object sender, EventArgs e)
        {
            IntoHTML();
            OpenHTML();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте закрити програму?", "Закриття", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void checkBoxValue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxValue.Checked) { comboBoxValue.Enabled = true; } else { comboBoxValue.Enabled = false; }
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked) { comboBoxName.Enabled = true; } else { comboBoxName.Enabled = false; }
        }

        private void checkBoxStartDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStartDate.Checked) { comboBoxStartDate.Enabled = true; } else { comboBoxStartDate.Enabled = false; }
        }

        private void checkBoxEndDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEndDate.Checked) { comboBoxEndDate.Enabled = true; } else { comboBoxEndDate.Enabled = false; }
        }

        private void checkBoxCountry_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCountry.Checked) { comboBoxCountry.Enabled = true; } else { comboBoxCountry.Enabled = false; }
        }

        private void checkBoxCity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCity.Checked) { comboBoxCity.Enabled = true; } else { comboBoxCity.Enabled = false; }
        }

        private void checkBoxPrizePool_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrizePool.Checked) { comboBoxPrizePool.Enabled = true; } else { comboBoxPrizePool.Enabled = false; }
        }

        private void checkBoxDPCPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDPCPoints.Checked) { comboBoxDPCPoints.Enabled = true; } else { comboBoxDPCPoints.Enabled = false; }
        }

        private void checkBoxWinner_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWinner.Checked) { comboBoxWinner.Enabled = true; } else { comboBoxWinner.Enabled = false; }
        }

        private void checkBoxRunnerUp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRunnerUp.Checked) { comboBoxRunnerUp.Enabled = true; } else { comboBoxRunnerUp.Enabled = false; }
        }

        private void checkBoxNumberOfTeams_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNumberOfTeams.Checked) { comboBoxNumberOfTeams.Enabled = true; } else { comboBoxNumberOfTeams.Enabled = false; }
        }

        private void btnOpenHTML_Click(object sender, EventArgs e)
        {
            var openHTML = System.Diagnostics.Process.Start(@"D:\Proga\EventsDota\EventsDota\bin\Debug\HTML.html");
        }
    }
}

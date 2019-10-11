using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinTV
{
    public partial class Form1 : Form
    {
        List<Channel> channels = new List<Channel>();

        public Form1()
        {
            InitializeComponent();
            ofdHTML.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            lblChannelCount.Text = "";
            lblDone.Text = "";
        }

        private void btnOpenHTML_Click(object sender, EventArgs e)
        {
            ofdHTML.ShowDialog();
        }

        private void btnOpenPython_Click(object sender, EventArgs e)
        {
            ofdPython.ShowDialog();
        }

        private void ofdHTML_FileOk(object sender, CancelEventArgs e)
        {
            if (!ofdHTML.CheckFileExists)
            {
                MessageBox.Show("Filen eksisterer ikke");
            }
            else
            {
                channels.Clear();

                Regex findElements = new Regex(@"javascript:changeChannel\('(http://[\w\-\.\/]*)',\s*(\d*)\);"">([\w\s]*)");

                string originalString = File.ReadAllText(ofdHTML.FileName);
                MatchCollection matches = findElements.Matches(originalString);

                int counter = 0;

                foreach (Match item in matches)
                {
                    channels.Add(new Channel(counter++, item.Groups[1].Value, item.Groups[3].Value));
                }

                lblChannelCount.Text = String.Format("{0} kanaler indlæst", channels.Count);
                btnOpenPython.Enabled = true;
            }
        }

        private void ofdPython_FileOk(object sender, CancelEventArgs e)
        {
            if (!ofdPython.CheckFileExists)
            {
                MessageBox.Show("Filen eksisterer ikke");
            }
            else
            {
                StringBuilder newFile = new StringBuilder();
                string[] oldFile = File.ReadAllLines(ofdPython.FileName);

                foreach (string line in oldFile)
                {
                    if (line.Contains("u = '{\"") && !line.Contains("#u = '{\""))
                    {
                        newFile.AppendLine(getPythonLine());
                    }
                    else
                    {
                        newFile.AppendLine(line);
                    }
                }

                File.WriteAllText(ofdPython.FileName, newFile.ToString());

                lblDone.Text = "Done!";
            }
        }

        private string getPythonLine()
        {
            string line = "\tu = '{";

            foreach (Channel channel in channels)
            {
                line += (channel.GetPythonString() + ",");
            }

            line = line.TrimEnd(',');

            line += "}'";

            return line;
        }
    }
}

class Channel
{
    public int Number { get; set; }
    public string URL { get; set; }
    public string Name { get; set; }

    public Channel(int Number, string URL, string Name)
    {
        this.Number = Number;
        this.URL = URL;
        this.Name = Name;
    }

    public string GetPythonString()
    {
        return String.Format(@"""{0}"":[""{1}"",""{2}""]", Number, URL, Name);
    }
}
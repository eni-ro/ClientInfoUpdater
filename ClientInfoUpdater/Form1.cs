using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ClientInfoUpdater
{
    public partial class Form1 : Form
    {
        private bool changed;
        public Form1()
        {
            InitializeComponent();
            ReadSettings();
            changed = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                WriteSettings();
            }
        }

        private void ReadSettings()
        {
            string file = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName + "\\ClientInfoUpdater.xml";
            try
            {
                XElement xml = XElement.Load(file);

                //入力設定以外
                bool tmp_checked;
                if (bool.TryParse(xml.XPathSelectElement("ClientInfoProtect").Value, out tmp_checked))
                {
                    textBoxClientInfo.ReadOnly = tmp_checked;
                }
                textBoxClientInfo.Text = xml.XPathSelectElement("ClientInfo").Value;

                if (bool.TryParse(xml.XPathSelectElement("DNSHostProtect").Value, out tmp_checked))
                {
                    textBoxDNSHost.ReadOnly = tmp_checked;
                }
                textBoxDNSHost.Text = xml.XPathSelectElement("DNSHost").Value;

                if (bool.TryParse(xml.XPathSelectElement("LocalHostProtect").Value, out tmp_checked))
                {
                    textBoxLocalHost.ReadOnly = tmp_checked;
                }
                textBoxLocalHost.Text = xml.XPathSelectElement("LocalHost").Value;


                if (bool.TryParse(xml.XPathSelectElement("IPProtect").Value, out tmp_checked))
                {
                    textBoxIP.ReadOnly = tmp_checked;
                }
                textBoxIP.Text = xml.XPathSelectElement("IP").Value;


                if (bool.TryParse(xml.XPathSelectElement("PortProtect").Value, out tmp_checked))
                {
                    textBoxPort.ReadOnly = tmp_checked;
                }
                textBoxPort.Text = xml.XPathSelectElement("Port").Value;
            }
            catch
            {
                textBoxClientInfo.Text = ".\\data\\clientinfo.xml";
                textBoxDNSHost.Text = "yourhostname.com";
                textBoxLocalHost.Text = "127.0.0.1";
                textBoxIP.Text = "192.168.11.2";
                textBoxPort.Text = "6900";
            }
        }

        private void WriteSettings()
        {
            System.Text.Encoding utf8encoding = new System.Text.UTF8Encoding(false);
            string file = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName + "\\ClientInfoUpdater.xml";
            StreamWriter fs = new StreamWriter(file, false, utf8encoding );

            XElement root = new XElement("root",
                new XElement("ClientInfoProtect", textBoxClientInfo.ReadOnly ),
                new XElement("ClientInfo", textBoxClientInfo.Text),
                new XElement("DNSHostProtect", textBoxDNSHost.ReadOnly),
                new XElement("DNSHost", textBoxDNSHost.Text),
                new XElement("LocalHostProtect", textBoxLocalHost.ReadOnly),
                new XElement("LocalHost", textBoxLocalHost.Text),
                new XElement("IPProtect", textBoxIP.ReadOnly),
                new XElement("IP", textBoxIP.Text),
                new XElement("PortProtect", textBoxPort.ReadOnly),
                new XElement("Port", textBoxPort.Text)
                );
            root.Save(fs);
            fs.Close();
            fs.Dispose();
        }
        private void buttonDNS_Click(object sender, EventArgs e)
        {
            try
            {
                ReplaceIP(textBoxClientInfo.Text, DNStoIP(textBoxDNSHost.Text));
                textBoxResult.Text = "更新成功";
            }
            catch(Exception ex)
            {
                textBoxResult.Text = ex.Message + Environment.NewLine;
                textBoxResult.Text += "更新失敗";
            }
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void buttonLocalHost_Click(object sender, EventArgs e)
        {
            try
            {
                ReplaceIP(textBoxClientInfo.Text, textBoxLocalHost.Text);
                textBoxResult.Text = "更新成功";
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.Message + Environment.NewLine;
                textBoxResult.Text += "更新失敗";
            }
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void buttonIP_Click(object sender, EventArgs e)
        {
            try
            {
                ReplaceIP(textBoxClientInfo.Text, textBoxIP.Text);
                textBoxResult.Text = "更新成功";
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.Message + Environment.NewLine;
                textBoxResult.Text += "更新失敗";
            }
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void buttonPort_Click(object sender, EventArgs e)
        {
            try
            {
                ReplacePort(textBoxClientInfo.Text, textBoxPort.Text);
                textBoxResult.Text = "更新成功";
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.Message + Environment.NewLine;
                textBoxResult.Text += "更新失敗";
            }
            System.Media.SystemSounds.Asterisk.Play();
        }

        private string DNStoIP( string HostName )
        {
            //IP取得
            IPAddress[] addresses = Dns.GetHostAddresses(HostName);

            return addresses[0].ToString();
        }
        private void ReplaceIP( string Path, string NewIP)
        {

            //ECU-KRエンコーディングはXDocument等でサポートしておらず読みだせないので、StreamReaderで読みだす
            string file = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName + "\\" + Path;
            StreamReader sr = new StreamReader(file);
            string buff = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();

            //IP置換
            Match match = Regex.Match(buff, "(?<=<address>).*(?=</address>)");
            if (!match.Success)
            {
                throw new Exception("addressノードが見つかりませんでした");
            }
            buff = buff.Replace(match.Value, NewIP);

            //書き込み
            StreamWriter sw = new StreamWriter(file);
            sw.Write(buff);
            sw.Close();
            sw.Dispose();
        }
        private void ReplacePort(string Path, string NewPort)
        {

            //ECU-KRエンコーディングはXDocument等でサポートしておらず読みだせないので、StreamReaderで読みだす
            string file = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName + "\\" + Path;
            StreamReader sr = new StreamReader(file);
            string buff = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();

            //Port置換
            Match match = Regex.Match(buff, "(?<=<port>).*(?=</port>)");
            if (!match.Success)
            {
                throw new Exception("portノードが見つかりませんでした");
            }
            buff = buff.Replace(match.Value, NewPort);

            //書き込み
            StreamWriter sw = new StreamWriter(file);
            sw.Write(buff);
            sw.Close();
            sw.Dispose();
        }

        private void textBoxClientInfo_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void textBoxDNSHost_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void textBoxLocalHost_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }
    }
}

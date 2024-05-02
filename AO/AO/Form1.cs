using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("\\\\192.168.2.177\\cga\\foto");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "http://gasur.ru/";
            Process.Start(url);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string url = "http://udmpobeda.ru/";
            Process.Start(url);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string url = "https://udmkorni.ru/";
            Process.Start(url);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string url = "https://udm4you.ru/";
            Process.Start(url);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string url = "https://фронтовикиудмуртии.рф/";
            Process.Start(url);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("\\\\192.168.2.177\\cga\\Documents\\ТЕЛЕФОННЫЙ СПРАВОЧНИК");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start("\\\\192.168.2.177\\cga\\Documents\\_ЭПМК");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("\\\\192.168.2.177\\cga\\Documents");
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
        Dictionary<string, string> departmentFolders = new Dictionary<string, string>()
        {
            { "Отдел НСА и НИР", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел АПС", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел Отдел ФАФ", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел ЭЦЖ", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел ОСиУД", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел ИиВР", "\\\\192.168.2.177\\cga\\Documents\\Отдел использования и выставочных работ" },
            { "Отдел ССФиФП", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел ОиАР", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
            { "Отдел по ЭиТО", "\\\\192.168.2.177\\cga\\Documents\\Отдел НСА" },
        };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = comboBox1.SelectedItem.ToString();
            if (departmentFolders.ContainsKey(selectedDepartment))
            {
                string selectedFolder = departmentFolders[selectedDepartment];
                Process.Start("explorer.exe", selectedFolder);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start("\\\\192.168.2.177\\cga\\Documents\\ОБЩИЙ ОТДЕЛ\\КОНТРАКТНАЯ СЛУЖБА");
        }
    }
}

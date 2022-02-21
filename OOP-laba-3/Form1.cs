using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace OOP_laba_3
{
    public partial class Form1 : Form
    {
        Stack<RailwayStation> stations;
        public Form1()
        {
            InitializeComponent();
            stations = new Stack<RailwayStation>();
            this.Icon = Properties.Resources.myIcon;
        }

        public void AddStation(RailwayStation station)
        {
            stations.Push(station);
            print();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            FormAddStation formAddStation = new FormAddStation(this);
            formAddStation.ShowDialog();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stations.Count == 0) return;
            stations.Pop();
            print();
        }

        private void print()
        {
            dataGridView1.Rows.Clear();
            foreach(var stat in stations)
            {
                dataGridView1.Rows.Add(
                    stat.Name,
                    stat.Director,
                    stat.SeatsNumber,
                    stat.WaysNumber,
                    stat.Area,
                    stat.PassagersAtStation,
                    stat.EmployeesAtStation
                );
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            TestSpeed testSpeed = new TestSpeed();
            listBox1.Items.Add("Вставка СТЕК: " + testSpeed.GetTimeInsertStack() + " мс");
            listBox1.Items.Add("Вставка МАССИВ: " + testSpeed.GetTimeInsertArr() + " мс");
            listBox1.Items.Add("Выборка СТЕК: " + testSpeed.GetTimeExtractStack() + " мс");
            listBox1.Items.Add("Вставка МАССИВ: " + testSpeed.GetTimeExtractArr() + " мс");
        }
    }
}

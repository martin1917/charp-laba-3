using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_laba_3
{
    public partial class FormAddStation : Form
    {
        private Form1 parent;
        public FormAddStation(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            StationDto stationDto = new StationDto(
                tbName.Text.Trim(),
                tbDirector.Text.Trim(),
                tbSeatsNumber.Text.Trim(),
                tbWaysNumber.Text.Trim(),
                tbArea.Text.Trim(),
                tbPassagersAtStation.Text.Trim(),
                tbEmployeesAtStation.Text.Trim()
            );

            RailwayStation station = null;
            try
            {
                station = stationDto.ToStation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }

            parent.AddStation(station);
            Close();
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

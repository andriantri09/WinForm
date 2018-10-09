using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LatihanWinForm
{
    public partial class FrmListMahasiswa : Form
    {
        public FrmListMahasiswa()
        {
            InitializeComponent();

            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwMahasiswa.View = System.Windows.Forms.View.Details;
            lvwMahasiswa.FullRowSelect = true;
            lvwMahasiswa.GridLines = true;

            lvwMahasiswa.Columns.Add("No.", 50, HorizontalAlignment.Center);
            lvwMahasiswa.Columns.Add("NPM", 80, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Jenis Kelamin", 100, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Tempat Lahir", 100, HorizontalAlignment.Left);
            lvwMahasiswa.Columns.Add("Tgl. Lahir", 100, HorizontalAlignment.Left);
        }
    }
}

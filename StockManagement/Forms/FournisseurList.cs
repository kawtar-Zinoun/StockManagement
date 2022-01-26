using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.Forms
{
    public partial class FournisseurList : Form
    {
        public FournisseurList()
        {
            InitializeComponent();
        }

        private void FournisseurList_Load(object sender, EventArgs e)
        {

            //better use in a specific class when we have real data

            FournisseurDataGrid.Rows.Add(5);

            FournisseurDataGrid.Rows[0].Cells[0].Value = "1";
            FournisseurDataGrid.Rows[0].Cells[1].Value = "Supply 1";
            FournisseurDataGrid.Rows[0].Cells[2].Value = "andu villa, duse road";
            FournisseurDataGrid.Rows[0].Cells[3].Value = "0602717264";
            FournisseurDataGrid.Rows[0].Cells[4].Value = "supply@gmail.com";

            FournisseurDataGrid.Rows[1].Cells[0].Value = "2";
            FournisseurDataGrid.Rows[1].Cells[1].Value = "Supply 2";
            FournisseurDataGrid.Rows[1].Cells[2].Value = "jutis lan,29 CDC";
            FournisseurDataGrid.Rows[1].Cells[3].Value = "0612346784";
            FournisseurDataGrid.Rows[1].Cells[4].Value = "supply@gmail.com";

            FournisseurDataGrid.Rows[2].Cells[0].Value = "3";
            FournisseurDataGrid.Rows[2].Cells[1].Value = "Supply 3";
            FournisseurDataGrid.Rows[2].Cells[2].Value = "halisa lan, 38 jalis";
            FournisseurDataGrid.Rows[2].Cells[3].Value = "0612346784";
            FournisseurDataGrid.Rows[2].Cells[4].Value = "supply@gmail.com";

            FournisseurDataGrid.Rows[3].Cells[0].Value = "4";
            FournisseurDataGrid.Rows[3].Cells[1].Value = "Supply 4";
            FournisseurDataGrid.Rows[3].Cells[2].Value = "67 down town";
            FournisseurDataGrid.Rows[3].Cells[3].Value = "3926423423";
            FournisseurDataGrid.Rows[3].Cells[4].Value = "supply@gmail.com";

            FournisseurDataGrid.Rows[4].Cells[0].Value = "5";
            FournisseurDataGrid.Rows[4].Cells[1].Value = "Supply 5";
            FournisseurDataGrid.Rows[4].Cells[2].Value = "molae road, tolada";
            FournisseurDataGrid.Rows[4].Cells[3].Value = "6536554617";
            FournisseurDataGrid.Rows[4].Cells[4].Value = "supply@gmail.com";

        }
    }
}

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
    public partial class SalesList : Form
    {
        public SalesList()
        {
            InitializeComponent();
        }

        private void SalesList_Load(object sender, EventArgs e)
        {
            SalesDataGrid.Rows.Add(4);

            SalesDataGrid.Rows[0].Cells[0].Value = "1";
            SalesDataGrid.Rows[0].Cells[1].Value = "Ahmed hamid";
            SalesDataGrid.Rows[0].Cells[2].Value = "27/01/22";
            SalesDataGrid.Rows[0].Cells[3].Value = "Virement bancaire";
            SalesDataGrid.Rows[0].Cells[4].Value = "30 pieces";
            SalesDataGrid.Rows[0].Cells[5].Value = "2000Dh";

            SalesDataGrid.Rows[1].Cells[0].Value = "2";
            SalesDataGrid.Rows[1].Cells[1].Value = "Ghita Ghita";
            SalesDataGrid.Rows[1].Cells[2].Value = "30/01/22";
            SalesDataGrid.Rows[1].Cells[3].Value = "Virement bancaire";
            SalesDataGrid.Rows[1].Cells[4].Value = "5 pieces";
            SalesDataGrid.Rows[1].Cells[5].Value = "1000Dh";

            SalesDataGrid.Rows[2].Cells[0].Value = "3";
            SalesDataGrid.Rows[2].Cells[1].Value = "Kawtar";
            SalesDataGrid.Rows[2].Cells[2].Value = "30/01/22";
            SalesDataGrid.Rows[2].Cells[3].Value = "Cheque";
            SalesDataGrid.Rows[2].Cells[4].Value = "10 pieces";
            SalesDataGrid.Rows[2].Cells[5].Value = "1500Dh";

            SalesDataGrid.Rows[3].Cells[0].Value = "4";
            SalesDataGrid.Rows[3].Cells[1].Value = "Zakaria";
            SalesDataGrid.Rows[3].Cells[2].Value = "10/01/22";
            SalesDataGrid.Rows[3].Cells[3].Value = "Cheque";
            SalesDataGrid.Rows[3].Cells[4].Value = "40 pieces";
            SalesDataGrid.Rows[3].Cells[5].Value = "4500Dh";
        }
    }
}

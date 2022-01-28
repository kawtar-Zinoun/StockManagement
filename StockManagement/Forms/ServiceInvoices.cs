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
    public partial class ServiceInvoices : Form
    {
        public ServiceInvoices()
        {
            InitializeComponent();
        }

        private void ServiceInvoices_Load(object sender, EventArgs e)
        {
            InvoiceDataGrid.Rows.Add(3);

            InvoiceDataGrid.Rows[0].Cells[0].Value = "43545";
            InvoiceDataGrid.Rows[0].Cells[1].Value = "Kawtar Zinoun";
            InvoiceDataGrid.Rows[0].Cells[2].Value = "Service 1";
            InvoiceDataGrid.Rows[0].Cells[3].Value = "1";
            InvoiceDataGrid.Rows[0].Cells[4].Value = "12/01/22";
            InvoiceDataGrid.Rows[0].Cells[5].Value = "300";

            InvoiceDataGrid.Rows[1].Cells[0].Value = "18743";
            InvoiceDataGrid.Rows[1].Cells[1].Value = "Soumia Soumia";
            InvoiceDataGrid.Rows[1].Cells[2].Value = "Service 2";
            InvoiceDataGrid.Rows[1].Cells[3].Value = "10";
            InvoiceDataGrid.Rows[1].Cells[4].Value = "10/02/22";
            InvoiceDataGrid.Rows[1].Cells[5].Value = "100";

            InvoiceDataGrid.Rows[2].Cells[0].Value = "96217";
            InvoiceDataGrid.Rows[2].Cells[1].Value = "Ahmed Amed";
            InvoiceDataGrid.Rows[2].Cells[2].Value = "Service 3";
            InvoiceDataGrid.Rows[2].Cells[3].Value = "4";
            InvoiceDataGrid.Rows[2].Cells[4].Value = "15/01/22";
            InvoiceDataGrid.Rows[2].Cells[5].Value = "800";




        }
    }
}

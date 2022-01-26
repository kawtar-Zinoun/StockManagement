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
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            //better use in a specific class when we have real data
            
            ClientDataGrid.Rows.Add(5);
            ClientDataGrid.Rows[0].Cells[0].Value = "1";
            ClientDataGrid.Rows[0].Cells[1].Value = "Kawtar";
            ClientDataGrid.Rows[0].Cells[2].Value = "Zinoun";
            ClientDataGrid.Rows[0].Cells[3].Value = "0602717264";
            ClientDataGrid.Rows[0].Cells[4].Value = "kawzin45@gmail.com";

            ClientDataGrid.Rows[1].Cells[0].Value = "2";
            ClientDataGrid.Rows[1].Cells[1].Value = "John";
            ClientDataGrid.Rows[1].Cells[2].Value = "Doe";
            ClientDataGrid.Rows[1].Cells[3].Value = "0602743121";
            ClientDataGrid.Rows[1].Cells[4].Value = "johndoe@gmail.com";

            ClientDataGrid.Rows[2].Cells[0].Value = "3";
            ClientDataGrid.Rows[2].Cells[1].Value = "Dan";
            ClientDataGrid.Rows[2].Cells[2].Value = "Cooper";
            ClientDataGrid.Rows[2].Cells[3].Value = "0612346784";
            ClientDataGrid.Rows[2].Cells[4].Value = "DanCooper@gmail.com";

            ClientDataGrid.Rows[3].Cells[0].Value = "4";
            ClientDataGrid.Rows[3].Cells[1].Value = "Jane";
            ClientDataGrid.Rows[3].Cells[2].Value = "Cooper";
            ClientDataGrid.Rows[3].Cells[3].Value = "0645789011";
            ClientDataGrid.Rows[3].Cells[4].Value = "Janecooper@gmail.com";

            ClientDataGrid.Rows[4].Cells[0].Value = "5";
            ClientDataGrid.Rows[4].Cells[1].Value = "John";
            ClientDataGrid.Rows[4].Cells[2].Value = "Doe";
            ClientDataGrid.Rows[4].Cells[3].Value = "0602743121";
            ClientDataGrid.Rows[4].Cells[4].Value = "johndoe@gmail.com";



        }
    }
}

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
    public partial class ServiceList : Form
    {
        public ServiceList()
        {
            InitializeComponent();
        }

        private void ServiceList_Load(object sender, EventArgs e)
        {
            ServiceDataGrid.Rows.Add(3);

            ServiceDataGrid.Rows[0].Cells[0].Value = "Service 1";
            ServiceDataGrid.Rows[0].Cells[1].Value = "2000";
            ServiceDataGrid.Rows[0].Cells[2].Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dictum ex eu quam accumsan," +
                "non finibus urna finibus. Nam bibendum viverra euismod. Aliquam in sapien ut dui blandit rutrum.";

            ServiceDataGrid.Rows[1].Cells[0].Value = "Service 2";
            ServiceDataGrid.Rows[1].Cells[1].Value = "1000";
            ServiceDataGrid.Rows[1].Cells[2].Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dictum ex eu quam accumsan," +
                "non finibus urna finibus. Nam bibendum viverra euismod. Aliquam in sapien ut dui blandit rutrum.";

            ServiceDataGrid.Rows[2].Cells[0].Value = "Service 3";
            ServiceDataGrid.Rows[2].Cells[1].Value = "500";
            ServiceDataGrid.Rows[2].Cells[2].Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dictum ex eu quam accumsan," +
                "non finibus urna finibus. Nam bibendum viverra euismod. Aliquam in sapien ut dui blandit rutrum.";

        }
    }
}

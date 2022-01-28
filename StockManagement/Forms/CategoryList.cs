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
    public partial class CategoryList : Form
    {
        public CategoryList()
        {
            InitializeComponent();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            CategoryDataGrid.Rows.Add(3);

            CategoryDataGrid.Rows[0].Cells[0].Value = "Categorie 1";
            CategoryDataGrid.Rows[0].Cells[1].Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dictum ex eu quam accumsan," +
                "non finibus urna finibus. Nam bibendum viverra euismod. Aliquam in sapien ut dui blandit rutrum. ";

            CategoryDataGrid.Rows[1].Cells[0].Value = "Categorie 2";
            CategoryDataGrid.Rows[1].Cells[1].Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dictum ex eu quam accumsan," +
                "non finibus urna finibus. Nam bibendum viverra euismod. Aliquam in sapien ut dui blandit rutrum. ";

            CategoryDataGrid.Rows[2].Cells[0].Value = "Categorie 1";
            CategoryDataGrid.Rows[2].Cells[1].Value = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris dictum ex eu quam accumsan," +
                "non finibus urna finibus. Nam bibendum viverra euismod. Aliquam in sapien ut dui blandit rutrum. ";

        }
    }
}

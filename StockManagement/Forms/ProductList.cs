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
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            ProductDataGrid.Rows.Add(5);

            ProductDataGrid.Rows[0].Cells[0].Value = "1";
            ProductDataGrid.Rows[0].Cells[1].Value = "Produit 1";
            ProductDataGrid.Rows[0].Cells[2].Value = "Piece";
            ProductDataGrid.Rows[0].Cells[3].Value = "Categorie 1";
            ProductDataGrid.Rows[0].Cells[4].Value = "100Dh";

            ProductDataGrid.Rows[1].Cells[0].Value = "2";
            ProductDataGrid.Rows[1].Cells[1].Value = "Produit 2";
            ProductDataGrid.Rows[1].Cells[2].Value = "Cm";
            ProductDataGrid.Rows[1].Cells[3].Value = "Categorie 2";
            ProductDataGrid.Rows[1].Cells[4].Value = "10Dh";

            ProductDataGrid.Rows[2].Cells[0].Value = "3";
            ProductDataGrid.Rows[2].Cells[1].Value = "Produit 3";
            ProductDataGrid.Rows[2].Cells[2].Value = "Piece";
            ProductDataGrid.Rows[2].Cells[3].Value = "Categorie 1";
            ProductDataGrid.Rows[2].Cells[4].Value = "150Dh";

            ProductDataGrid.Rows[3].Cells[0].Value = "4";
            ProductDataGrid.Rows[3].Cells[1].Value = "Produit 4";
            ProductDataGrid.Rows[3].Cells[2].Value = "Cm";
            ProductDataGrid.Rows[3].Cells[3].Value = "Categorie 5";
            ProductDataGrid.Rows[3].Cells[4].Value = "500Dh";

            ProductDataGrid.Rows[4].Cells[0].Value = "5";
            ProductDataGrid.Rows[4].Cells[1].Value = "Produit 5";
            ProductDataGrid.Rows[4].Cells[2].Value = "Piece";
            ProductDataGrid.Rows[4].Cells[3].Value = "Categorie 2";
            ProductDataGrid.Rows[4].Cells[4].Value = "1050Dh";

        }
    }
}

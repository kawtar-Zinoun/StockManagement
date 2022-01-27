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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
         
        private void CustomizeDesign()
        {
            FournisseursSubMenu.Visible = false;
            SalesSubmenu.Visible = false;
            ProductsSubMenu.Visible = false;
            OpenChildForm(new Dashboard());

        }
        private void HideSubMenu()
        {
            if (ClientsSubMenu.Visible == true)
                ClientsSubMenu.Visible = false;
            else if (FournisseursSubMenu.Visible == true)
                FournisseursSubMenu.Visible = false;
            else if (ProductsSubMenu.Visible == true)
                ProductsSubMenu.Visible = false;
            else if (SalesSubmenu.Visible == true)
                SalesSubmenu.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ClientsSubMenu);
        }

        private void FournisseursButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(FournisseursSubMenu);
        }

        private void Ventes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SalesSubmenu);
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ProductsSubMenu);
        }

        private Form activeForm = null; 
        
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            this.Text = childForm.Text;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childContainer.Controls.Add(childForm);
            childContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddClient());
        }

        private void ClientList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientList());
        }

        private void FournisseurList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FournisseurList());
        }

        private void AddFournisseur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddFournisseur());
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }

        private void AddSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddSale());
        }

        private void SaleList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesList());
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddProduct());
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductList());
        }
    }
}

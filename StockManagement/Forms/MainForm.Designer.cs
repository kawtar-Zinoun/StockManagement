
namespace StockManagement.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SideMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductsSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.ProductList = new Guna.UI2.WinForms.Guna2Button();
            this.AddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.ProductButton = new Guna.UI2.WinForms.Guna2Button();
            this.SalesSubmenu = new Guna.UI2.WinForms.Guna2Panel();
            this.SaleList = new Guna.UI2.WinForms.Guna2Button();
            this.AddSale = new Guna.UI2.WinForms.Guna2Button();
            this.Ventes = new Guna.UI2.WinForms.Guna2Button();
            this.FournisseursSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.fournisseurList = new Guna.UI2.WinForms.Guna2Button();
            this.AddFournisseur = new Guna.UI2.WinForms.Guna2Button();
            this.FournisseursButton = new Guna.UI2.WinForms.Guna2Button();
            this.ClientsSubMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.ClientList = new Guna.UI2.WinForms.Guna2Button();
            this.AddClient = new Guna.UI2.WinForms.Guna2Button();
            this.ClientsButton = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.MyStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.childContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.SideMenu.SuspendLayout();
            this.ProductsSubMenu.SuspendLayout();
            this.SalesSubmenu.SuspendLayout();
            this.FournisseursSubMenu.SuspendLayout();
            this.ClientsSubMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.AutoScroll = true;
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.SideMenu.Controls.Add(this.ProductsSubMenu);
            this.SideMenu.Controls.Add(this.ProductButton);
            this.SideMenu.Controls.Add(this.SalesSubmenu);
            this.SideMenu.Controls.Add(this.Ventes);
            this.SideMenu.Controls.Add(this.FournisseursSubMenu);
            this.SideMenu.Controls.Add(this.FournisseursButton);
            this.SideMenu.Controls.Add(this.ClientsSubMenu);
            this.SideMenu.Controls.Add(this.ClientsButton);
            this.SideMenu.Controls.Add(this.DashboardButton);
            this.SideMenu.Controls.Add(this.guna2Panel1);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.ShadowDecoration.Parent = this.SideMenu;
            this.SideMenu.Size = new System.Drawing.Size(382, 789);
            this.SideMenu.TabIndex = 0;
            // 
            // ProductsSubMenu
            // 
            this.ProductsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.ProductsSubMenu.Controls.Add(this.ProductList);
            this.ProductsSubMenu.Controls.Add(this.AddProduct);
            this.ProductsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductsSubMenu.Location = new System.Drawing.Point(0, 849);
            this.ProductsSubMenu.Name = "ProductsSubMenu";
            this.ProductsSubMenu.ShadowDecoration.Parent = this.ProductsSubMenu;
            this.ProductsSubMenu.Size = new System.Drawing.Size(361, 111);
            this.ProductsSubMenu.TabIndex = 9;
            // 
            // ProductList
            // 
            this.ProductList.BackColor = System.Drawing.Color.DimGray;
            this.ProductList.CheckedState.Parent = this.ProductList;
            this.ProductList.CustomImages.Parent = this.ProductList;
            this.ProductList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProductList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProductList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProductList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProductList.DisabledState.Parent = this.ProductList;
            this.ProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.ProductList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductList.ForeColor = System.Drawing.Color.White;
            this.ProductList.HoverState.Parent = this.ProductList;
            this.ProductList.Location = new System.Drawing.Point(0, 53);
            this.ProductList.Name = "ProductList";
            this.ProductList.ShadowDecoration.Parent = this.ProductList;
            this.ProductList.Size = new System.Drawing.Size(361, 53);
            this.ProductList.TabIndex = 3;
            this.ProductList.Text = "Liste produits";
            this.ProductList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductList.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.DimGray;
            this.AddProduct.CheckedState.Parent = this.AddProduct;
            this.AddProduct.CustomImages.Parent = this.AddProduct;
            this.AddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddProduct.DisabledState.Parent = this.AddProduct;
            this.AddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.AddProduct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ForeColor = System.Drawing.Color.White;
            this.AddProduct.HoverState.Parent = this.AddProduct;
            this.AddProduct.Location = new System.Drawing.Point(0, 0);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.ShadowDecoration.Parent = this.AddProduct;
            this.AddProduct.Size = new System.Drawing.Size(361, 53);
            this.AddProduct.TabIndex = 2;
            this.AddProduct.Text = "Ajouter produit";
            this.AddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProduct.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // ProductButton
            // 
            this.ProductButton.BackColor = System.Drawing.Color.DimGray;
            this.ProductButton.CheckedState.Parent = this.ProductButton;
            this.ProductButton.CustomImages.Parent = this.ProductButton;
            this.ProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProductButton.DisabledState.Parent = this.ProductButton;
            this.ProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.ProductButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductButton.ForeColor = System.Drawing.Color.White;
            this.ProductButton.HoverState.Parent = this.ProductButton;
            this.ProductButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductButton.Image")));
            this.ProductButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ProductButton.Location = new System.Drawing.Point(0, 769);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.ShadowDecoration.Parent = this.ProductButton;
            this.ProductButton.Size = new System.Drawing.Size(361, 80);
            this.ProductButton.TabIndex = 8;
            this.ProductButton.Text = "Produits";
            this.ProductButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // SalesSubmenu
            // 
            this.SalesSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.SalesSubmenu.Controls.Add(this.SaleList);
            this.SalesSubmenu.Controls.Add(this.AddSale);
            this.SalesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesSubmenu.Location = new System.Drawing.Point(0, 658);
            this.SalesSubmenu.Name = "SalesSubmenu";
            this.SalesSubmenu.ShadowDecoration.Parent = this.SalesSubmenu;
            this.SalesSubmenu.Size = new System.Drawing.Size(361, 111);
            this.SalesSubmenu.TabIndex = 7;
            // 
            // SaleList
            // 
            this.SaleList.BackColor = System.Drawing.Color.DimGray;
            this.SaleList.CheckedState.Parent = this.SaleList;
            this.SaleList.CustomImages.Parent = this.SaleList;
            this.SaleList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaleList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaleList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaleList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaleList.DisabledState.Parent = this.SaleList;
            this.SaleList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaleList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.SaleList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleList.ForeColor = System.Drawing.Color.White;
            this.SaleList.HoverState.Parent = this.SaleList;
            this.SaleList.Location = new System.Drawing.Point(0, 53);
            this.SaleList.Name = "SaleList";
            this.SaleList.ShadowDecoration.Parent = this.SaleList;
            this.SaleList.Size = new System.Drawing.Size(361, 53);
            this.SaleList.TabIndex = 3;
            this.SaleList.Text = "Liste ventes";
            this.SaleList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SaleList.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // AddSale
            // 
            this.AddSale.BackColor = System.Drawing.Color.DimGray;
            this.AddSale.CheckedState.Parent = this.AddSale;
            this.AddSale.CustomImages.Parent = this.AddSale;
            this.AddSale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddSale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddSale.DisabledState.Parent = this.AddSale;
            this.AddSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddSale.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.AddSale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSale.ForeColor = System.Drawing.Color.White;
            this.AddSale.HoverState.Parent = this.AddSale;
            this.AddSale.Location = new System.Drawing.Point(0, 0);
            this.AddSale.Name = "AddSale";
            this.AddSale.ShadowDecoration.Parent = this.AddSale;
            this.AddSale.Size = new System.Drawing.Size(361, 53);
            this.AddSale.TabIndex = 2;
            this.AddSale.Text = "Nouvelle vente";
            this.AddSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddSale.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // Ventes
            // 
            this.Ventes.BackColor = System.Drawing.Color.DimGray;
            this.Ventes.CheckedState.Parent = this.Ventes;
            this.Ventes.CustomImages.Parent = this.Ventes;
            this.Ventes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Ventes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Ventes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Ventes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ventes.DisabledState.Parent = this.Ventes;
            this.Ventes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ventes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.Ventes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventes.ForeColor = System.Drawing.Color.White;
            this.Ventes.HoverState.Parent = this.Ventes;
            this.Ventes.Image = ((System.Drawing.Image)(resources.GetObject("Ventes.Image")));
            this.Ventes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Ventes.ImageSize = new System.Drawing.Size(30, 30);
            this.Ventes.Location = new System.Drawing.Point(0, 578);
            this.Ventes.Name = "Ventes";
            this.Ventes.ShadowDecoration.Parent = this.Ventes;
            this.Ventes.Size = new System.Drawing.Size(361, 80);
            this.Ventes.TabIndex = 6;
            this.Ventes.Text = "Ventes";
            this.Ventes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Ventes.Click += new System.EventHandler(this.Ventes_Click);
            // 
            // FournisseursSubMenu
            // 
            this.FournisseursSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.FournisseursSubMenu.Controls.Add(this.fournisseurList);
            this.FournisseursSubMenu.Controls.Add(this.AddFournisseur);
            this.FournisseursSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.FournisseursSubMenu.Location = new System.Drawing.Point(0, 467);
            this.FournisseursSubMenu.Name = "FournisseursSubMenu";
            this.FournisseursSubMenu.ShadowDecoration.Parent = this.FournisseursSubMenu;
            this.FournisseursSubMenu.Size = new System.Drawing.Size(361, 111);
            this.FournisseursSubMenu.TabIndex = 5;
            // 
            // fournisseurList
            // 
            this.fournisseurList.BackColor = System.Drawing.Color.DimGray;
            this.fournisseurList.CheckedState.Parent = this.fournisseurList;
            this.fournisseurList.CustomImages.Parent = this.fournisseurList;
            this.fournisseurList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fournisseurList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fournisseurList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fournisseurList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fournisseurList.DisabledState.Parent = this.fournisseurList;
            this.fournisseurList.Dock = System.Windows.Forms.DockStyle.Top;
            this.fournisseurList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.fournisseurList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournisseurList.ForeColor = System.Drawing.Color.White;
            this.fournisseurList.HoverState.Parent = this.fournisseurList;
            this.fournisseurList.Location = new System.Drawing.Point(0, 53);
            this.fournisseurList.Name = "fournisseurList";
            this.fournisseurList.ShadowDecoration.Parent = this.fournisseurList;
            this.fournisseurList.Size = new System.Drawing.Size(361, 53);
            this.fournisseurList.TabIndex = 3;
            this.fournisseurList.Text = "Liste fournisseurs";
            this.fournisseurList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fournisseurList.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // AddFournisseur
            // 
            this.AddFournisseur.BackColor = System.Drawing.Color.DimGray;
            this.AddFournisseur.CheckedState.Parent = this.AddFournisseur;
            this.AddFournisseur.CustomImages.Parent = this.AddFournisseur;
            this.AddFournisseur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddFournisseur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddFournisseur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddFournisseur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddFournisseur.DisabledState.Parent = this.AddFournisseur;
            this.AddFournisseur.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddFournisseur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.AddFournisseur.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFournisseur.ForeColor = System.Drawing.Color.White;
            this.AddFournisseur.HoverState.Parent = this.AddFournisseur;
            this.AddFournisseur.Location = new System.Drawing.Point(0, 0);
            this.AddFournisseur.Name = "AddFournisseur";
            this.AddFournisseur.ShadowDecoration.Parent = this.AddFournisseur;
            this.AddFournisseur.Size = new System.Drawing.Size(361, 53);
            this.AddFournisseur.TabIndex = 2;
            this.AddFournisseur.Text = "Ajouter fournisseur";
            this.AddFournisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddFournisseur.TextOffset = new System.Drawing.Point(40, 0);
            // 
            // FournisseursButton
            // 
            this.FournisseursButton.BackColor = System.Drawing.Color.DimGray;
            this.FournisseursButton.CheckedState.Parent = this.FournisseursButton;
            this.FournisseursButton.CustomImages.Parent = this.FournisseursButton;
            this.FournisseursButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FournisseursButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FournisseursButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FournisseursButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FournisseursButton.DisabledState.Parent = this.FournisseursButton;
            this.FournisseursButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FournisseursButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.FournisseursButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FournisseursButton.ForeColor = System.Drawing.Color.White;
            this.FournisseursButton.HoverState.Parent = this.FournisseursButton;
            this.FournisseursButton.Image = ((System.Drawing.Image)(resources.GetObject("FournisseursButton.Image")));
            this.FournisseursButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FournisseursButton.ImageSize = new System.Drawing.Size(30, 30);
            this.FournisseursButton.Location = new System.Drawing.Point(0, 387);
            this.FournisseursButton.Name = "FournisseursButton";
            this.FournisseursButton.ShadowDecoration.Parent = this.FournisseursButton;
            this.FournisseursButton.Size = new System.Drawing.Size(361, 80);
            this.FournisseursButton.TabIndex = 4;
            this.FournisseursButton.Text = "Fournisseurs";
            this.FournisseursButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FournisseursButton.Click += new System.EventHandler(this.FournisseursButton_Click);
            // 
            // ClientsSubMenu
            // 
            this.ClientsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.ClientsSubMenu.Controls.Add(this.ClientList);
            this.ClientsSubMenu.Controls.Add(this.AddClient);
            this.ClientsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsSubMenu.Location = new System.Drawing.Point(0, 276);
            this.ClientsSubMenu.Name = "ClientsSubMenu";
            this.ClientsSubMenu.ShadowDecoration.Parent = this.ClientsSubMenu;
            this.ClientsSubMenu.Size = new System.Drawing.Size(361, 111);
            this.ClientsSubMenu.TabIndex = 3;
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.DimGray;
            this.ClientList.CheckedState.Parent = this.ClientList;
            this.ClientList.CustomImages.Parent = this.ClientList;
            this.ClientList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientList.DisabledState.Parent = this.ClientList;
            this.ClientList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.ClientList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.ForeColor = System.Drawing.Color.White;
            this.ClientList.HoverState.Parent = this.ClientList;
            this.ClientList.Location = new System.Drawing.Point(0, 53);
            this.ClientList.Name = "ClientList";
            this.ClientList.ShadowDecoration.Parent = this.ClientList;
            this.ClientList.Size = new System.Drawing.Size(361, 53);
            this.ClientList.TabIndex = 3;
            this.ClientList.Text = "Liste clients";
            this.ClientList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientList.TextOffset = new System.Drawing.Point(40, 0);
            this.ClientList.Click += new System.EventHandler(this.ClientList_Click);
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.Color.DimGray;
            this.AddClient.CheckedState.Parent = this.AddClient;
            this.AddClient.CustomImages.Parent = this.AddClient;
            this.AddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddClient.DisabledState.Parent = this.AddClient;
            this.AddClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(89)))));
            this.AddClient.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClient.ForeColor = System.Drawing.Color.White;
            this.AddClient.HoverState.Parent = this.AddClient;
            this.AddClient.Location = new System.Drawing.Point(0, 0);
            this.AddClient.Name = "AddClient";
            this.AddClient.ShadowDecoration.Parent = this.AddClient;
            this.AddClient.Size = new System.Drawing.Size(361, 53);
            this.AddClient.TabIndex = 2;
            this.AddClient.Text = "Ajouter client";
            this.AddClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddClient.TextOffset = new System.Drawing.Point(40, 0);
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.Color.DimGray;
            this.ClientsButton.CheckedState.Parent = this.ClientsButton;
            this.ClientsButton.CustomImages.Parent = this.ClientsButton;
            this.ClientsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClientsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClientsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClientsButton.DisabledState.Parent = this.ClientsButton;
            this.ClientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.ClientsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.ForeColor = System.Drawing.Color.White;
            this.ClientsButton.HoverState.Parent = this.ClientsButton;
            this.ClientsButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientsButton.Image")));
            this.ClientsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientsButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ClientsButton.Location = new System.Drawing.Point(0, 196);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.ShadowDecoration.Parent = this.ClientsButton;
            this.ClientsButton.Size = new System.Drawing.Size(361, 80);
            this.ClientsButton.TabIndex = 2;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.DimGray;
            this.DashboardButton.CheckedState.Parent = this.DashboardButton;
            this.DashboardButton.CustomImages.Parent = this.DashboardButton;
            this.DashboardButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardButton.DisabledState.Parent = this.DashboardButton;
            this.DashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.DashboardButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.HoverState.Parent = this.DashboardButton;
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardButton.ImageSize = new System.Drawing.Size(30, 30);
            this.DashboardButton.Location = new System.Drawing.Point(0, 130);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.ShadowDecoration.Parent = this.DashboardButton;
            this.DashboardButton.Size = new System.Drawing.Size(361, 66);
            this.DashboardButton.TabIndex = 1;
            this.DashboardButton.Text = "Tableau de bord";
            this.DashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.MyStock);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(361, 130);
            this.guna2Panel1.TabIndex = 0;
            // 
            // MyStock
            // 
            this.MyStock.BackColor = System.Drawing.Color.Transparent;
            this.MyStock.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyStock.Location = new System.Drawing.Point(104, 44);
            this.MyStock.Name = "MyStock";
            this.MyStock.Size = new System.Drawing.Size(144, 55);
            this.MyStock.TabIndex = 0;
            this.MyStock.Text = "My Stock";
            // 
            // childContainer
            // 
            this.childContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childContainer.Location = new System.Drawing.Point(382, 0);
            this.childContainer.Name = "childContainer";
            this.childContainer.ShadowDecoration.Parent = this.childContainer;
            this.childContainer.Size = new System.Drawing.Size(960, 789);
            this.childContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 789);
            this.Controls.Add(this.childContainer);
            this.Controls.Add(this.SideMenu);
            this.Name = "MainForm";
            this.Text = "Tableau de bord";
            this.SideMenu.ResumeLayout(false);
            this.ProductsSubMenu.ResumeLayout(false);
            this.SalesSubmenu.ResumeLayout(false);
            this.FournisseursSubMenu.ResumeLayout(false);
            this.ClientsSubMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel SideMenu;
        private Guna.UI2.WinForms.Guna2Button DashboardButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel MyStock;
        private Guna.UI2.WinForms.Guna2Panel ClientsSubMenu;
        private Guna.UI2.WinForms.Guna2Button ClientList;
        private Guna.UI2.WinForms.Guna2Button AddClient;
        private Guna.UI2.WinForms.Guna2Button ClientsButton;
        private Guna.UI2.WinForms.Guna2Button FournisseursButton;
        private Guna.UI2.WinForms.Guna2Panel SalesSubmenu;
        private Guna.UI2.WinForms.Guna2Button SaleList;
        private Guna.UI2.WinForms.Guna2Button AddSale;
        private Guna.UI2.WinForms.Guna2Button Ventes;
        private Guna.UI2.WinForms.Guna2Panel FournisseursSubMenu;
        private Guna.UI2.WinForms.Guna2Button fournisseurList;
        private Guna.UI2.WinForms.Guna2Button AddFournisseur;
        private Guna.UI2.WinForms.Guna2Panel ProductsSubMenu;
        private Guna.UI2.WinForms.Guna2Button ProductList;
        private Guna.UI2.WinForms.Guna2Button AddProduct;
        private Guna.UI2.WinForms.Guna2Button ProductButton;
        private Guna.UI2.WinForms.Guna2Panel childContainer;
    }
}
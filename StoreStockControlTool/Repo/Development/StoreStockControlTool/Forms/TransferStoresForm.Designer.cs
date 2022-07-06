namespace Store_Management.Forms
{
    partial class TransferStoresForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferStoresForm));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.subTopPanelLeft = new System.Windows.Forms.Panel();
            this.groupGrid = new System.Windows.Forms.GroupBox();
            this.cfgProducts = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.c1ComboUser = new C1.Win.C1List.C1Combo();
            this.c1Date = new C1.Win.C1Input.C1DateEdit();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1ButtonSearch = new C1.Win.C1Input.C1Button();
            this.c1ButtonClear = new C1.Win.C1Input.C1Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.c1DTProductsProviders = new C1.Win.C1Command.C1DockingTab();
            this.c1DockStock = new C1.Win.C1Command.C1DockingTabPage();
            this.cfgProductsPStock = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1DockProviders = new C1.Win.C1Command.C1DockingTabPage();
            this.cfgTransfer = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panelBot = new System.Windows.Forms.Panel();
            this.c1Cancel = new C1.Win.C1Input.C1Button();
            this.c1Save = new C1.Win.C1Input.C1Button();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.subTopPanelLeft.SuspendLayout();
            this.groupGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgProducts)).BeginInit();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonClear)).BeginInit();
            this.panelFill.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DTProductsProviders)).BeginInit();
            this.c1DTProductsProviders.SuspendLayout();
            this.c1DockStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgProductsPStock)).BeginInit();
            this.c1DockProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgTransfer)).BeginInit();
            this.panelBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Save)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(VLStoreModel.Model.Products);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.92308F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.07692F));
            this.tableLayoutPanel1.Controls.Add(this.subTopPanelLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFill, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelBot, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.7971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.2029F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 588);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // subTopPanelLeft
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.subTopPanelLeft, 2);
            this.subTopPanelLeft.Controls.Add(this.groupGrid);
            this.subTopPanelLeft.Controls.Add(this.groupSearch);
            this.subTopPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTopPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.subTopPanelLeft.Name = "subTopPanelLeft";
            this.subTopPanelLeft.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.subTopPanelLeft.Size = new System.Drawing.Size(959, 300);
            this.subTopPanelLeft.TabIndex = 18;
            // 
            // groupGrid
            // 
            this.groupGrid.Controls.Add(this.cfgProducts);
            this.groupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGrid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupGrid.ForeColor = System.Drawing.Color.Navy;
            this.groupGrid.Location = new System.Drawing.Point(10, 83);
            this.groupGrid.Name = "groupGrid";
            this.groupGrid.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupGrid.Size = new System.Drawing.Size(949, 217);
            this.groupGrid.TabIndex = 35;
            this.groupGrid.TabStop = false;
            this.groupGrid.Text = "Products";
            // 
            // cfgProducts
            // 
            this.cfgProducts.AutoGenerateColumns = false;
            this.cfgProducts.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.cfgProducts.ColumnInfo = resources.GetString("cfgProducts.ColumnInfo");
            this.cfgProducts.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgProducts.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgProducts.ColumnPickerInfo.ShowToolButton = false;
            this.cfgProducts.DataSource = this.productsBindingSource;
            this.cfgProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgProducts.ExtendLastCol = true;
            this.cfgProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgProducts.Location = new System.Drawing.Point(3, 20);
            this.cfgProducts.Name = "cfgProducts";
            this.cfgProducts.Rows.Count = 1;
            this.cfgProducts.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgProducts.Size = new System.Drawing.Size(943, 194);
            this.cfgProducts.StyleInfo = resources.GetString("cfgProducts.StyleInfo");
            this.cfgProducts.TabIndex = 104;
            this.cfgProducts.UseCompatibleTextRendering = false;
            this.cfgProducts.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.c1ComboUser);
            this.groupSearch.Controls.Add(this.c1Date);
            this.groupSearch.Controls.Add(this.c1Label2);
            this.groupSearch.Controls.Add(this.c1Label1);
            this.groupSearch.Controls.Add(this.c1ButtonSearch);
            this.groupSearch.Controls.Add(this.c1ButtonClear);
            this.groupSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupSearch.ForeColor = System.Drawing.Color.Navy;
            this.groupSearch.Location = new System.Drawing.Point(10, 0);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(949, 83);
            this.groupSearch.TabIndex = 7;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search";
            // 
            // c1ComboUser
            // 
            this.c1ComboUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ComboUser.AutoCompletion = true;
            this.c1ComboUser.AutoSize = false;
            this.c1ComboUser.Caption = "";
            this.c1ComboUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.c1ComboUser.ContentHeight = 15;
            this.c1ComboUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1ComboUser.DisplayMember = "WorkingAreaName";
            this.c1ComboUser.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.c1ComboUser.DropDownWidth = 300;
            this.c1ComboUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1ComboUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ComboUser.Images.Add(((System.Drawing.Image)(resources.GetObject("c1ComboUser.Images"))));
            this.c1ComboUser.Location = new System.Drawing.Point(114, 37);
            this.c1ComboUser.MatchEntryTimeout = ((long)(2000));
            this.c1ComboUser.MaxDropDownItems = ((short)(5));
            this.c1ComboUser.MaxLength = 32767;
            this.c1ComboUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1ComboUser.Name = "c1ComboUser";
            this.c1ComboUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1ComboUser.Size = new System.Drawing.Size(717, 21);
            this.c1ComboUser.TabIndex = 101;
            this.c1ComboUser.ValueMember = "WorkingArea";
            this.c1ComboUser.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Silver;
            this.c1ComboUser.PropBag = resources.GetString("c1ComboUser.PropBag");
            // 
            // c1Date
            // 
            this.c1Date.AutoSize = false;
            this.c1Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1Date.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1Date.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1Date.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1Date.GapHeight = 0;
            this.c1Date.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1Date.Location = new System.Drawing.Point(9, 37);
            this.c1Date.Name = "c1Date";
            this.c1Date.Size = new System.Drawing.Size(99, 21);
            this.c1Date.TabIndex = 100;
            this.c1Date.Tag = null;
            this.c1Date.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1Date.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BackColor = System.Drawing.Color.Transparent;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label2.ForeColor = System.Drawing.Color.Navy;
            this.c1Label2.Location = new System.Drawing.Point(114, 23);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(30, 15);
            this.c1Label2.TabIndex = 104;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "User";
            this.c1Label2.TextDetached = true;
            this.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BackColor = System.Drawing.Color.Transparent;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label1.ForeColor = System.Drawing.Color.Navy;
            this.c1Label1.Location = new System.Drawing.Point(9, 23);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(31, 15);
            this.c1Label1.TabIndex = 103;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Date";
            this.c1Label1.TextDetached = true;
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1ButtonSearch
            // 
            this.c1ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonSearch.Image")));
            this.c1ButtonSearch.Location = new System.Drawing.Point(837, 24);
            this.c1ButtonSearch.Name = "c1ButtonSearch";
            this.c1ButtonSearch.Size = new System.Drawing.Size(106, 23);
            this.c1ButtonSearch.TabIndex = 102;
            this.c1ButtonSearch.Text = "Apply Filter";
            this.c1ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonSearch.UseVisualStyleBackColor = true;
            this.c1ButtonSearch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1ButtonClear
            // 
            this.c1ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonClear.Image")));
            this.c1ButtonClear.Location = new System.Drawing.Point(837, 54);
            this.c1ButtonClear.Name = "c1ButtonClear";
            this.c1ButtonClear.Size = new System.Drawing.Size(106, 23);
            this.c1ButtonClear.TabIndex = 103;
            this.c1ButtonClear.Text = "Reset Filter";
            this.c1ButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonClear.UseVisualStyleBackColor = true;
            this.c1ButtonClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // panelFill
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelFill, 2);
            this.panelFill.Controls.Add(this.groupBox4);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(3, 309);
            this.panelFill.Name = "panelFill";
            this.panelFill.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panelFill.Size = new System.Drawing.Size(959, 237);
            this.panelFill.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.c1DTProductsProviders);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(10, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(939, 237);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transfer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1071, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total Stock: ";
            // 
            // c1DTProductsProviders
            // 
            this.c1DTProductsProviders.Controls.Add(this.c1DockStock);
            this.c1DTProductsProviders.Controls.Add(this.c1DockProviders);
            this.c1DTProductsProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DTProductsProviders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1DTProductsProviders.Location = new System.Drawing.Point(3, 23);
            this.c1DTProductsProviders.Name = "c1DTProductsProviders";
            this.c1DTProductsProviders.SelectedIndex = 1;
            this.c1DTProductsProviders.Size = new System.Drawing.Size(933, 211);
            this.c1DTProductsProviders.TabIndex = 0;
            this.c1DTProductsProviders.TabsSpacing = 5;
            this.c1DTProductsProviders.TabTextAlignment = System.Drawing.StringAlignment.Near;
            this.c1DTProductsProviders.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            // 
            // c1DockStock
            // 
            this.c1DockStock.Controls.Add(this.cfgProductsPStock);
            this.c1DockStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1DockStock.Location = new System.Drawing.Point(1, 27);
            this.c1DockStock.Name = "c1DockStock";
            this.c1DockStock.Size = new System.Drawing.Size(931, 183);
            this.c1DockStock.TabIndex = 200;
            this.c1DockStock.Text = "Stock";
            // 
            // cfgProductsPStock
            // 
            this.cfgProductsPStock.ColumnInfo = resources.GetString("cfgProductsPStock.ColumnInfo");
            this.cfgProductsPStock.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgProductsPStock.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgProductsPStock.ColumnPickerInfo.ShowToolButton = false;
            this.cfgProductsPStock.DataSource = this.productsBindingSource;
            this.cfgProductsPStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgProductsPStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgProductsPStock.Location = new System.Drawing.Point(0, 0);
            this.cfgProductsPStock.Name = "cfgProductsPStock";
            this.cfgProductsPStock.Rows.Count = 1;
            this.cfgProductsPStock.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgProductsPStock.Size = new System.Drawing.Size(931, 183);
            this.cfgProductsPStock.StyleInfo = resources.GetString("cfgProductsPStock.StyleInfo");
            this.cfgProductsPStock.TabIndex = 0;
            this.cfgProductsPStock.UseCompatibleTextRendering = false;
            this.cfgProductsPStock.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // c1DockProviders
            // 
            this.c1DockProviders.Controls.Add(this.cfgTransfer);
            this.c1DockProviders.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1DockProviders.Location = new System.Drawing.Point(1, 27);
            this.c1DockProviders.Name = "c1DockProviders";
            this.c1DockProviders.Size = new System.Drawing.Size(931, 183);
            this.c1DockProviders.TabIndex = 201;
            this.c1DockProviders.Text = "Providers";
            // 
            // cfgTransfer
            // 
            this.cfgTransfer.AutoGenerateColumns = false;
            this.cfgTransfer.ColumnInfo = resources.GetString("cfgTransfer.ColumnInfo");
            this.cfgTransfer.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgTransfer.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgTransfer.ColumnPickerInfo.ShowToolButton = false;
            this.cfgTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgTransfer.ExtendLastCol = true;
            this.cfgTransfer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgTransfer.Location = new System.Drawing.Point(0, 0);
            this.cfgTransfer.Name = "cfgTransfer";
            this.cfgTransfer.Rows.Count = 1;
            this.cfgTransfer.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgTransfer.Size = new System.Drawing.Size(931, 183);
            this.cfgTransfer.StyleInfo = resources.GetString("cfgTransfer.StyleInfo");
            this.cfgTransfer.TabIndex = 23;
            this.cfgTransfer.UseCompatibleTextRendering = false;
            this.cfgTransfer.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // panelBot
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelBot, 2);
            this.panelBot.Controls.Add(this.c1Cancel);
            this.panelBot.Controls.Add(this.c1Save);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(3, 552);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(959, 33);
            this.panelBot.TabIndex = 1;
            // 
            // c1Cancel
            // 
            this.c1Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c1Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Cancel.Image = ((System.Drawing.Image)(resources.GetObject("c1Cancel.Image")));
            this.c1Cancel.Location = new System.Drawing.Point(112, 7);
            this.c1Cancel.Name = "c1Cancel";
            this.c1Cancel.Size = new System.Drawing.Size(96, 23);
            this.c1Cancel.TabIndex = 301;
            this.c1Cancel.Text = "Cancel";
            this.c1Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Cancel.UseVisualStyleBackColor = true;
            this.c1Cancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Save
            // 
            this.c1Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.c1Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Save.Image = ((System.Drawing.Image)(resources.GetObject("c1Save.Image")));
            this.c1Save.Location = new System.Drawing.Point(10, 7);
            this.c1Save.Name = "c1Save";
            this.c1Save.Size = new System.Drawing.Size(96, 23);
            this.c1Save.TabIndex = 300;
            this.c1Save.Text = "Save";
            this.c1Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Save.UseVisualStyleBackColor = true;
            this.c1Save.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(6, 2);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(933, 24);
            this.miniToolStrip.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(3, 23);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TransferStoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(961, 627);
            this.Name = "TransferStoresForm";
            this.Text = "Transfer Between Stores";
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.subTopPanelLeft.ResumeLayout(false);
            this.groupGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgProducts)).EndInit();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonClear)).EndInit();
            this.panelFill.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DTProductsProviders)).EndInit();
            this.c1DTProductsProviders.ResumeLayout(false);
            this.c1DockStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgProductsPStock)).EndInit();
            this.c1DockProviders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgTransfer)).EndInit();
            this.panelBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Save)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel subTopPanelLeft;
        private System.Windows.Forms.GroupBox groupGrid;
        private System.Windows.Forms.GroupBox groupSearch;
        private C1.Win.C1Input.C1Button c1ButtonSearch;
        private C1.Win.C1Input.C1Button c1ButtonClear;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelBot;
        private C1.Win.C1List.C1Combo c1ComboUser;
        private C1.Win.C1Input.C1DateEdit c1Date;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgProducts;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private C1.Win.C1Command.C1DockingTab c1DTProductsProviders;
        private C1.Win.C1Command.C1DockingTabPage c1DockStock;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgProductsPStock;
        private C1.Win.C1Command.C1DockingTabPage c1DockProviders;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgTransfer;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private C1.Win.C1Input.C1Button c1Cancel;
        private C1.Win.C1Input.C1Button c1Save;
    }
}
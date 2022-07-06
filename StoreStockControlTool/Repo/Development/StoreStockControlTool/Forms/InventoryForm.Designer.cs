namespace Store_Management.Forms
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.tableLayoutProducts = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.c1cbStores = new C1.Win.C1List.C1Combo();
            this.BSStores = new System.Windows.Forms.BindingSource(this.components);
            this.c1DateTo = new C1.Win.C1Input.C1DateEdit();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.c1ComboUser = new C1.Win.C1List.C1Combo();
            this.BSUsers = new System.Windows.Forms.BindingSource(this.components);
            this.c1DateFrom = new C1.Win.C1Input.C1DateEdit();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Label14 = new C1.Win.C1Input.C1Label();
            this.c1ButtonClear = new C1.Win.C1Input.C1Button();
            this.c1ButtonSearch = new C1.Win.C1Input.C1Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.groupFill = new System.Windows.Forms.GroupBox();
            this.BSInventory = new System.Windows.Forms.BindingSource(this.components);
            this.panelBot = new System.Windows.Forms.Panel();
            this.groupBoxLocations = new System.Windows.Forms.GroupBox();
            this.cfgProducts = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.vInventoryProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1ButtonImportWithStock = new C1.Win.C1Input.C1Button();
            this.c1buttonImportAll = new C1.Win.C1Input.C1Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.c1Cancel = new C1.Win.C1Input.C1Button();
            this.c1Save = new C1.Win.C1Input.C1Button();
            this.BSProducts = new System.Windows.Forms.BindingSource(this.components);
            this.cfgInventory = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tableLayoutProducts.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1cbStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonSearch)).BeginInit();
            this.panelFill.SuspendLayout();
            this.groupFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSInventory)).BeginInit();
            this.panelBot.SuspendLayout();
            this.groupBoxLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventoryProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonImportWithStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1buttonImportAll)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cfgInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutProducts
            // 
            this.tableLayoutProducts.ColumnCount = 2;
            this.tableLayoutProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.84656F));
            this.tableLayoutProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.15344F));
            this.tableLayoutProducts.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutProducts.Controls.Add(this.panelFill, 0, 1);
            this.tableLayoutProducts.Controls.Add(this.panelBot, 0, 2);
            this.tableLayoutProducts.Controls.Add(this.panelButtons, 0, 3);
            this.tableLayoutProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProducts.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutProducts.Name = "tableLayoutProducts";
            this.tableLayoutProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutProducts.RowCount = 4;
            this.tableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.45137F));
            this.tableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.54863F));
            this.tableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutProducts.Size = new System.Drawing.Size(974, 628);
            this.tableLayoutProducts.TabIndex = 10;
            // 
            // panelTop
            // 
            this.tableLayoutProducts.SetColumnSpan(this.panelTop, 2);
            this.panelTop.Controls.Add(this.groupSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(6, 6);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelTop.Size = new System.Drawing.Size(962, 72);
            this.panelTop.TabIndex = 9;
            // 
            // groupSearch
            // 
            this.groupSearch.Controls.Add(this.c1cbStores);
            this.groupSearch.Controls.Add(this.c1DateTo);
            this.groupSearch.Controls.Add(this.c1Label3);
            this.groupSearch.Controls.Add(this.c1ComboUser);
            this.groupSearch.Controls.Add(this.c1DateFrom);
            this.groupSearch.Controls.Add(this.c1Label2);
            this.groupSearch.Controls.Add(this.c1Label1);
            this.groupSearch.Controls.Add(this.c1Label14);
            this.groupSearch.Controls.Add(this.c1ButtonClear);
            this.groupSearch.Controls.Add(this.c1ButtonSearch);
            this.groupSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupSearch.ForeColor = System.Drawing.Color.Navy;
            this.groupSearch.Location = new System.Drawing.Point(0, 0);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Padding = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.groupSearch.Size = new System.Drawing.Size(942, 72);
            this.groupSearch.TabIndex = 29;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "Search";
            // 
            // c1cbStores
            // 
            this.c1cbStores.AllowDrag = true;
            this.c1cbStores.AutoCompletion = true;
            this.c1cbStores.AutoSize = false;
            this.c1cbStores.Caption = "";
            this.c1cbStores.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1cbStores.ColumnWidth = 100;
            this.c1cbStores.ContentHeight = 15;
            this.c1cbStores.DataSource = this.BSStores;
            this.c1cbStores.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1cbStores.DisplayMember = "StoreName";
            this.c1cbStores.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.c1cbStores.DropDownWidth = 300;
            this.c1cbStores.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1cbStores.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1cbStores.Images.Add(((System.Drawing.Image)(resources.GetObject("c1cbStores.Images"))));
            this.c1cbStores.Location = new System.Drawing.Point(6, 41);
            this.c1cbStores.MatchEntryTimeout = ((long)(2000));
            this.c1cbStores.MaxDropDownItems = ((short)(5));
            this.c1cbStores.MaxLength = 32767;
            this.c1cbStores.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1cbStores.Name = "c1cbStores";
            this.c1cbStores.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1cbStores.Size = new System.Drawing.Size(103, 21);
            this.c1cbStores.TabIndex = 100;
            this.c1cbStores.ValueMember = "IdStore";
            this.c1cbStores.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Silver;
            this.c1cbStores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1cbStores_KeyDown);
            this.c1cbStores.KeyUp += new System.Windows.Forms.KeyEventHandler(this.c1cbStores_KeyUp);
            this.c1cbStores.PropBag = resources.GetString("c1cbStores.PropBag");
            // 
            // BSStores
            // 
            this.BSStores.DataSource = typeof(VLStoreModel.Model.Stores);
            // 
            // c1DateTo
            // 
            this.c1DateTo.AutoSize = false;
            this.c1DateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateTo.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1DateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1DateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1DateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1DateTo.GapHeight = 0;
            this.c1DateTo.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateTo.Location = new System.Drawing.Point(233, 41);
            this.c1DateTo.Name = "c1DateTo";
            this.c1DateTo.Size = new System.Drawing.Size(119, 21);
            this.c1DateTo.TabIndex = 102;
            this.c1DateTo.Tag = null;
            this.c1DateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1DateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BackColor = System.Drawing.Color.Transparent;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label3.ForeColor = System.Drawing.Color.Navy;
            this.c1Label3.Location = new System.Drawing.Point(233, 27);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(45, 15);
            this.c1Label3.TabIndex = 106;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "Date to";
            this.c1Label3.TextDetached = true;
            this.c1Label3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1ComboUser
            // 
            this.c1ComboUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ComboUser.AutoCompletion = true;
            this.c1ComboUser.AutoSize = false;
            this.c1ComboUser.Caption = "";
            this.c1ComboUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1ComboUser.ColumnWidth = 100;
            this.c1ComboUser.ContentHeight = 15;
            this.c1ComboUser.DataSource = this.BSUsers;
            this.c1ComboUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1ComboUser.DisplayMember = "EmployeeName";
            this.c1ComboUser.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.c1ComboUser.DropDownWidth = 300;
            this.c1ComboUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1ComboUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ComboUser.Images.Add(((System.Drawing.Image)(resources.GetObject("c1ComboUser.Images"))));
            this.c1ComboUser.Location = new System.Drawing.Point(358, 41);
            this.c1ComboUser.MatchEntryTimeout = ((long)(2000));
            this.c1ComboUser.MaxDropDownItems = ((short)(5));
            this.c1ComboUser.MaxLength = 32767;
            this.c1ComboUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1ComboUser.Name = "c1ComboUser";
            this.c1ComboUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1ComboUser.Size = new System.Drawing.Size(466, 21);
            this.c1ComboUser.TabIndex = 103;
            this.c1ComboUser.ValueMember = "EmployeeCode";
            this.c1ComboUser.VisualStyle = C1.Win.C1List.VisualStyle.Office2010Silver;
            this.c1ComboUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1ComboUser_KeyDown);
            this.c1ComboUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.c1ComboUser_KeyUp);
            this.c1ComboUser.PropBag = resources.GetString("c1ComboUser.PropBag");
            // 
            // BSUsers
            // 
            this.BSUsers.DataSource = typeof(VLStoreModel.Model.Temp_Employees);
            // 
            // c1DateFrom
            // 
            this.c1DateFrom.AutoSize = false;
            this.c1DateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1DateFrom.Calendar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1DateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1DateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1DateFrom.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1DateFrom.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.c1DateFrom.EditFormat.CalendarType = C1.Win.C1Input.CalendarType.GregorianCalendar;
            this.c1DateFrom.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType | C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) 
            | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1DateFrom.EditFormat.TrimStart = true;
            this.c1DateFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1DateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1DateFrom.GapHeight = 0;
            this.c1DateFrom.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateFrom.Location = new System.Drawing.Point(115, 41);
            this.c1DateFrom.Name = "c1DateFrom";
            this.c1DateFrom.Size = new System.Drawing.Size(112, 21);
            this.c1DateFrom.TabIndex = 101;
            this.c1DateFrom.Tag = null;
            this.c1DateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1DateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BackColor = System.Drawing.Color.Transparent;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label2.ForeColor = System.Drawing.Color.Navy;
            this.c1Label2.Location = new System.Drawing.Point(358, 23);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(30, 15);
            this.c1Label2.TabIndex = 36;
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
            this.c1Label1.Location = new System.Drawing.Point(128, 27);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(60, 15);
            this.c1Label1.TabIndex = 35;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Date from";
            this.c1Label1.TextDetached = true;
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Label14
            // 
            this.c1Label14.AutoSize = true;
            this.c1Label14.BackColor = System.Drawing.Color.Transparent;
            this.c1Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label14.ForeColor = System.Drawing.Color.Navy;
            this.c1Label14.Location = new System.Drawing.Point(3, 27);
            this.c1Label14.Name = "c1Label14";
            this.c1Label14.Size = new System.Drawing.Size(34, 15);
            this.c1Label14.TabIndex = 34;
            this.c1Label14.Tag = null;
            this.c1Label14.Text = "Store";
            this.c1Label14.TextDetached = true;
            this.c1Label14.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1ButtonClear
            // 
            this.c1ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonClear.Image")));
            this.c1ButtonClear.Location = new System.Drawing.Point(830, 48);
            this.c1ButtonClear.Name = "c1ButtonClear";
            this.c1ButtonClear.Size = new System.Drawing.Size(106, 23);
            this.c1ButtonClear.TabIndex = 105;
            this.c1ButtonClear.Text = "Reset Filter";
            this.c1ButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonClear.UseVisualStyleBackColor = true;
            this.c1ButtonClear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonClear.Click += new System.EventHandler(this.c1ButtonClear_Click);
            // 
            // c1ButtonSearch
            // 
            this.c1ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonSearch.Image")));
            this.c1ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1ButtonSearch.Location = new System.Drawing.Point(830, 19);
            this.c1ButtonSearch.Name = "c1ButtonSearch";
            this.c1ButtonSearch.Size = new System.Drawing.Size(106, 23);
            this.c1ButtonSearch.TabIndex = 104;
            this.c1ButtonSearch.Text = "Apply Filter";
            this.c1ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1ButtonSearch.UseVisualStyleBackColor = true;
            this.c1ButtonSearch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.c1ButtonSearch.Click += new System.EventHandler(this.c1ButtonSearch_Click);
            // 
            // panelFill
            // 
            this.tableLayoutProducts.SetColumnSpan(this.panelFill, 2);
            this.panelFill.Controls.Add(this.groupFill);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(6, 84);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(962, 317);
            this.panelFill.TabIndex = 11;
            // 
            // groupFill
            // 
            this.groupFill.Controls.Add(this.cfgInventory);
            this.groupFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupFill.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupFill.ForeColor = System.Drawing.Color.Navy;
            this.groupFill.Location = new System.Drawing.Point(0, 0);
            this.groupFill.Name = "groupFill";
            this.groupFill.Size = new System.Drawing.Size(962, 317);
            this.groupFill.TabIndex = 9;
            this.groupFill.TabStop = false;
            this.groupFill.Text = "Inventory";
            // 
            // BSInventory
            // 
            this.BSInventory.DataSource = typeof(VLStoreModel.Model.Inventory);
            // 
            // panelBot
            // 
            this.tableLayoutProducts.SetColumnSpan(this.panelBot, 2);
            this.panelBot.Controls.Add(this.groupBoxLocations);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBot.Location = new System.Drawing.Point(6, 407);
            this.panelBot.Name = "panelBot";
            this.panelBot.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.panelBot.Size = new System.Drawing.Size(962, 180);
            this.panelBot.TabIndex = 10;
            // 
            // groupBoxLocations
            // 
            this.groupBoxLocations.Controls.Add(this.cfgProducts);
            this.groupBoxLocations.Controls.Add(this.c1ButtonImportWithStock);
            this.groupBoxLocations.Controls.Add(this.c1buttonImportAll);
            this.groupBoxLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLocations.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxLocations.ForeColor = System.Drawing.Color.Navy;
            this.groupBoxLocations.Location = new System.Drawing.Point(10, 15);
            this.groupBoxLocations.Name = "groupBoxLocations";
            this.groupBoxLocations.Size = new System.Drawing.Size(942, 155);
            this.groupBoxLocations.TabIndex = 11;
            this.groupBoxLocations.TabStop = false;
            this.groupBoxLocations.Text = "Products";
            // 
            // cfgProducts
            // 
            this.cfgProducts.ColumnInfo = resources.GetString("cfgProducts.ColumnInfo");
            this.cfgProducts.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgProducts.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgProducts.ColumnPickerInfo.ShowToolButton = false;
            this.cfgProducts.DataSource = this.vInventoryProductsBindingSource;
            this.cfgProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgProducts.ExtendLastCol = true;
            this.cfgProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgProducts.Location = new System.Drawing.Point(3, 23);
            this.cfgProducts.Name = "cfgProducts";
            this.cfgProducts.Rows.Count = 1;
            this.cfgProducts.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgProducts.Size = new System.Drawing.Size(936, 129);
            this.cfgProducts.StyleInfo = resources.GetString("cfgProducts.StyleInfo");
            this.cfgProducts.TabIndex = 300;
            this.cfgProducts.UseCompatibleTextRendering = false;
            this.cfgProducts.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            // 
            // vInventoryProductsBindingSource
            // 
            this.vInventoryProductsBindingSource.DataSource = typeof(VLStoreModel.Model.vInventoryProducts);
            // 
            // c1ButtonImportWithStock
            // 
            this.c1ButtonImportWithStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1ButtonImportWithStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1ButtonImportWithStock.Image = ((System.Drawing.Image)(resources.GetObject("c1ButtonImportWithStock.Image")));
            this.c1ButtonImportWithStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1ButtonImportWithStock.Location = new System.Drawing.Point(687, 132);
            this.c1ButtonImportWithStock.Name = "c1ButtonImportWithStock";
            this.c1ButtonImportWithStock.Size = new System.Drawing.Size(249, 23);
            this.c1ButtonImportWithStock.TabIndex = 302;
            this.c1ButtonImportWithStock.Text = "Import products with stock in store";
            this.c1ButtonImportWithStock.UseVisualStyleBackColor = true;
            this.c1ButtonImportWithStock.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1buttonImportAll
            // 
            this.c1buttonImportAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1buttonImportAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1buttonImportAll.Image = ((System.Drawing.Image)(resources.GetObject("c1buttonImportAll.Image")));
            this.c1buttonImportAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c1buttonImportAll.Location = new System.Drawing.Point(526, 132);
            this.c1buttonImportAll.Name = "c1buttonImportAll";
            this.c1buttonImportAll.Size = new System.Drawing.Size(155, 23);
            this.c1buttonImportAll.TabIndex = 301;
            this.c1buttonImportAll.Text = "Import all products";
            this.c1buttonImportAll.UseVisualStyleBackColor = true;
            this.c1buttonImportAll.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // panelButtons
            // 
            this.tableLayoutProducts.SetColumnSpan(this.panelButtons, 2);
            this.panelButtons.Controls.Add(this.c1Cancel);
            this.panelButtons.Controls.Add(this.c1Save);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(6, 593);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(962, 29);
            this.panelButtons.TabIndex = 12;
            // 
            // c1Cancel
            // 
            this.c1Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Cancel.Image = ((System.Drawing.Image)(resources.GetObject("c1Cancel.Image")));
            this.c1Cancel.Location = new System.Drawing.Point(115, 3);
            this.c1Cancel.Name = "c1Cancel";
            this.c1Cancel.Size = new System.Drawing.Size(96, 23);
            this.c1Cancel.TabIndex = 401;
            this.c1Cancel.Text = "Cancel";
            this.c1Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Cancel.UseVisualStyleBackColor = true;
            this.c1Cancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // c1Save
            // 
            this.c1Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1Save.Image = ((System.Drawing.Image)(resources.GetObject("c1Save.Image")));
            this.c1Save.Location = new System.Drawing.Point(13, 3);
            this.c1Save.Name = "c1Save";
            this.c1Save.Size = new System.Drawing.Size(96, 23);
            this.c1Save.TabIndex = 400;
            this.c1Save.Text = "Save";
            this.c1Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.c1Save.UseVisualStyleBackColor = true;
            this.c1Save.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            // 
            // BSProducts
            // 
            this.BSProducts.DataSource = typeof(VLStoreModel.Model.Products);
            // 
            // cfgInventory
            // 
            this.cfgInventory.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.cfgInventory.AllowEditing = false;
            this.cfgInventory.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn;
            this.cfgInventory.AutoGenerateColumns = false;
            this.cfgInventory.ColumnInfo = resources.GetString("cfgInventory.ColumnInfo");
            this.cfgInventory.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.cfgInventory.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.cfgInventory.ColumnPickerInfo.ShowToolButton = false;
            this.cfgInventory.DataSource = this.BSInventory;
            this.cfgInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cfgInventory.ExtendLastCol = true;
            this.cfgInventory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cfgInventory.Location = new System.Drawing.Point(3, 23);
            this.cfgInventory.Name = "cfgInventory";
            this.cfgInventory.Rows.Count = 1;
            this.cfgInventory.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.cfgInventory.Size = new System.Drawing.Size(956, 291);
            this.cfgInventory.StyleInfo = resources.GetString("cfgInventory.StyleInfo");
            this.cfgInventory.TabIndex = 200;
            this.cfgInventory.UseCompatibleTextRendering = false;
            this.cfgInventory.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Silver;
            this.cfgInventory.RowColChange += new System.EventHandler(this.cfgInventory_RowColChange);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(974, 628);
            this.Controls.Add(this.tableLayoutProducts);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.tableLayoutProducts.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1cbStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonSearch)).EndInit();
            this.panelFill.ResumeLayout(false);
            this.groupFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BSInventory)).EndInit();
            this.panelBot.ResumeLayout(false);
            this.groupBoxLocations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cfgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vInventoryProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ButtonImportWithStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1buttonImportAll)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cfgInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutProducts;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.GroupBox groupSearch;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Label c1Label14;
        private C1.Win.C1Input.C1Button c1ButtonClear;
        private C1.Win.C1Input.C1Button c1ButtonSearch;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.GroupBox groupBoxLocations;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.GroupBox groupFill;
        private C1.Win.C1List.C1Combo c1ComboUser;
        private C1.Win.C1Input.C1DateEdit c1DateFrom;
        private System.Windows.Forms.Panel panelButtons;
        private C1.Win.C1Input.C1Button c1Save;
        private C1.Win.C1Input.C1Button c1Cancel;
        private C1.Win.C1Input.C1Button c1ButtonImportWithStock;
        private C1.Win.C1Input.C1Button c1buttonImportAll;
        private C1.Win.C1Input.C1DateEdit c1DateTo;
        private C1.Win.C1Input.C1Label c1Label3;
        private C1.Win.C1List.C1Combo c1cbStores;
        private System.Windows.Forms.BindingSource BSStores;
        private System.Windows.Forms.BindingSource BSInventory;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgProducts;
        private System.Windows.Forms.BindingSource BSProducts;
        private System.Windows.Forms.BindingSource BSUsers;
        private System.Windows.Forms.BindingSource vInventoryProductsBindingSource;
        private C1.Win.C1FlexGrid.C1FlexGrid cfgInventory;
    }
}
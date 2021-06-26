namespace Library_MS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnDb = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddBook = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddRent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUserList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBookList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRentList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.header = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.addUser1 = new Library_MS.AddUser();
            this.addBook1 = new Library_MS.AddBook();
            this.addRent1 = new Library_MS.AddRent();
            this.userPanel1 = new Library_MS.UserPanel();
            this.bookPanel1 = new Library_MS.BookPanel();
            this.rentPanel1 = new Library_MS.RentPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.btnDb);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnAddRent);
            this.panel1.Controls.Add(this.btnUserList);
            this.panel1.Controls.Add(this.btnBookList);
            this.panel1.Controls.Add(this.btnRentList);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 522);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.GreenYellow;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(64, 486);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Can ASIK";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnDb
            // 
            this.btnDb.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDb.BorderRadius = 0;
            this.btnDb.ButtonText = "Database Settings";
            this.btnDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDb.DisabledColor = System.Drawing.Color.Gray;
            this.btnDb.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDb.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDb.Iconimage")));
            this.btnDb.Iconimage_right = null;
            this.btnDb.Iconimage_right_Selected = null;
            this.btnDb.Iconimage_Selected = null;
            this.btnDb.IconMarginLeft = 0;
            this.btnDb.IconMarginRight = 0;
            this.btnDb.IconRightVisible = true;
            this.btnDb.IconRightZoom = 0D;
            this.btnDb.IconVisible = true;
            this.btnDb.IconZoom = 50D;
            this.btnDb.IsTab = false;
            this.btnDb.Location = new System.Drawing.Point(0, 377);
            this.btnDb.Name = "btnDb";
            this.btnDb.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDb.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnDb.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDb.selected = false;
            this.btnDb.Size = new System.Drawing.Size(200, 48);
            this.btnDb.TabIndex = 3;
            this.btnDb.Text = "Database Settings";
            this.btnDb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDb.Textcolor = System.Drawing.Color.White;
            this.btnDb.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDb.Click += new System.EventHandler(this.btnDb_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 0;
            this.btnAddUser.ButtonText = "Add User";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Iconimage")));
            this.btnAddUser.Iconimage_right = null;
            this.btnAddUser.Iconimage_right_Selected = null;
            this.btnAddUser.Iconimage_Selected = null;
            this.btnAddUser.IconMarginLeft = 0;
            this.btnAddUser.IconMarginRight = 0;
            this.btnAddUser.IconRightVisible = true;
            this.btnAddUser.IconRightZoom = 0D;
            this.btnAddUser.IconVisible = true;
            this.btnAddUser.IconZoom = 50D;
            this.btnAddUser.IsTab = true;
            this.btnAddUser.Location = new System.Drawing.Point(0, 329);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAddUser.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddUser.selected = false;
            this.btnAddUser.Size = new System.Drawing.Size(200, 48);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Textcolor = System.Drawing.Color.White;
            this.btnAddUser.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddBook.BorderRadius = 0;
            this.btnAddBook.ButtonText = "Add Book";
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddBook.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddBook.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Iconimage")));
            this.btnAddBook.Iconimage_right = null;
            this.btnAddBook.Iconimage_right_Selected = null;
            this.btnAddBook.Iconimage_Selected = null;
            this.btnAddBook.IconMarginLeft = 0;
            this.btnAddBook.IconMarginRight = 0;
            this.btnAddBook.IconRightVisible = true;
            this.btnAddBook.IconRightZoom = 0D;
            this.btnAddBook.IconVisible = true;
            this.btnAddBook.IconZoom = 50D;
            this.btnAddBook.IsTab = true;
            this.btnAddBook.Location = new System.Drawing.Point(0, 281);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddBook.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAddBook.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddBook.selected = false;
            this.btnAddBook.Size = new System.Drawing.Size(200, 48);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddBook.Textcolor = System.Drawing.Color.White;
            this.btnAddBook.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddRent
            // 
            this.btnAddRent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAddRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRent.BorderRadius = 0;
            this.btnAddRent.ButtonText = "Add Rent";
            this.btnAddRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRent.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddRent.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddRent.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddRent.Iconimage")));
            this.btnAddRent.Iconimage_right = null;
            this.btnAddRent.Iconimage_right_Selected = null;
            this.btnAddRent.Iconimage_Selected = null;
            this.btnAddRent.IconMarginLeft = 0;
            this.btnAddRent.IconMarginRight = 0;
            this.btnAddRent.IconRightVisible = true;
            this.btnAddRent.IconRightZoom = 0D;
            this.btnAddRent.IconVisible = true;
            this.btnAddRent.IconZoom = 50D;
            this.btnAddRent.IsTab = true;
            this.btnAddRent.Location = new System.Drawing.Point(0, 233);
            this.btnAddRent.Name = "btnAddRent";
            this.btnAddRent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddRent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAddRent.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddRent.selected = false;
            this.btnAddRent.Size = new System.Drawing.Size(200, 48);
            this.btnAddRent.TabIndex = 3;
            this.btnAddRent.Text = "Add Rent";
            this.btnAddRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRent.Textcolor = System.Drawing.Color.White;
            this.btnAddRent.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRent.Click += new System.EventHandler(this.btnAddRent_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserList.BorderRadius = 0;
            this.btnUserList.ButtonText = "User List";
            this.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserList.DisabledColor = System.Drawing.Color.Gray;
            this.btnUserList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUserList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUserList.Iconimage")));
            this.btnUserList.Iconimage_right = null;
            this.btnUserList.Iconimage_right_Selected = null;
            this.btnUserList.Iconimage_Selected = null;
            this.btnUserList.IconMarginLeft = 0;
            this.btnUserList.IconMarginRight = 0;
            this.btnUserList.IconRightVisible = true;
            this.btnUserList.IconRightZoom = 0D;
            this.btnUserList.IconVisible = true;
            this.btnUserList.IconZoom = 50D;
            this.btnUserList.IsTab = true;
            this.btnUserList.Location = new System.Drawing.Point(0, 185);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnUserList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUserList.selected = false;
            this.btnUserList.Size = new System.Drawing.Size(200, 48);
            this.btnUserList.TabIndex = 3;
            this.btnUserList.Text = "User List";
            this.btnUserList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUserList.Textcolor = System.Drawing.Color.White;
            this.btnUserList.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // btnBookList
            // 
            this.btnBookList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBookList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookList.BorderRadius = 0;
            this.btnBookList.ButtonText = "Book List";
            this.btnBookList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookList.DisabledColor = System.Drawing.Color.Gray;
            this.btnBookList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBookList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBookList.Iconimage")));
            this.btnBookList.Iconimage_right = null;
            this.btnBookList.Iconimage_right_Selected = null;
            this.btnBookList.Iconimage_Selected = null;
            this.btnBookList.IconMarginLeft = 0;
            this.btnBookList.IconMarginRight = 0;
            this.btnBookList.IconRightVisible = true;
            this.btnBookList.IconRightZoom = 0D;
            this.btnBookList.IconVisible = true;
            this.btnBookList.IconZoom = 50D;
            this.btnBookList.IsTab = true;
            this.btnBookList.Location = new System.Drawing.Point(0, 137);
            this.btnBookList.Name = "btnBookList";
            this.btnBookList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBookList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnBookList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBookList.selected = false;
            this.btnBookList.Size = new System.Drawing.Size(200, 48);
            this.btnBookList.TabIndex = 3;
            this.btnBookList.Text = "Book List";
            this.btnBookList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBookList.Textcolor = System.Drawing.Color.White;
            this.btnBookList.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookList.Click += new System.EventHandler(this.btnBookList_Click);
            // 
            // btnRentList
            // 
            this.btnRentList.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnRentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnRentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRentList.BorderRadius = 0;
            this.btnRentList.ButtonText = "Rent List";
            this.btnRentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentList.DisabledColor = System.Drawing.Color.Gray;
            this.btnRentList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRentList.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRentList.Iconimage")));
            this.btnRentList.Iconimage_right = null;
            this.btnRentList.Iconimage_right_Selected = null;
            this.btnRentList.Iconimage_Selected = null;
            this.btnRentList.IconMarginLeft = 0;
            this.btnRentList.IconMarginRight = 0;
            this.btnRentList.IconRightVisible = true;
            this.btnRentList.IconRightZoom = 0D;
            this.btnRentList.IconVisible = true;
            this.btnRentList.IconZoom = 50D;
            this.btnRentList.IsTab = true;
            this.btnRentList.Location = new System.Drawing.Point(0, 89);
            this.btnRentList.Name = "btnRentList";
            this.btnRentList.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRentList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnRentList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRentList.selected = true;
            this.btnRentList.Size = new System.Drawing.Size(200, 48);
            this.btnRentList.TabIndex = 3;
            this.btnRentList.Text = "Rent List";
            this.btnRentList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRentList.Textcolor = System.Drawing.Color.White;
            this.btnRentList.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRentList.Click += new System.EventHandler(this.btnRentList_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(158, 21);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 41);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.header.Controls.Add(this.linkLabel1);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(784, 39);
            this.header.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(753, 11);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(19, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(195, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Library Management System";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addUser1);
            this.panel2.Controls.Add(this.addBook1);
            this.panel2.Controls.Add(this.addRent1);
            this.panel2.Controls.Add(this.userPanel1);
            this.panel2.Controls.Add(this.bookPanel1);
            this.panel2.Controls.Add(this.rentPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 522);
            this.panel2.TabIndex = 2;
            // 
            // addUser1
            // 
            this.addUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.addUser1.Location = new System.Drawing.Point(111, 37);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(382, 412);
            this.addUser1.TabIndex = 5;
            this.addUser1.Visible = false;
            // 
            // addBook1
            // 
            this.addBook1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.addBook1.Location = new System.Drawing.Point(109, 16);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(384, 483);
            this.addBook1.TabIndex = 4;
            this.addBook1.Visible = false;
            // 
            // addRent1
            // 
            this.addRent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.addRent1.Location = new System.Drawing.Point(179, 121);
            this.addRent1.Name = "addRent1";
            this.addRent1.Size = new System.Drawing.Size(224, 279);
            this.addRent1.TabIndex = 3;
            this.addRent1.Visible = false;
            // 
            // userPanel1
            // 
            this.userPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel1.Location = new System.Drawing.Point(0, 0);
            this.userPanel1.Name = "userPanel1";
            this.userPanel1.Size = new System.Drawing.Size(584, 522);
            this.userPanel1.TabIndex = 2;
            this.userPanel1.Visible = false;
            // 
            // bookPanel1
            // 
            this.bookPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookPanel1.Location = new System.Drawing.Point(0, 0);
            this.bookPanel1.Name = "bookPanel1";
            this.bookPanel1.Size = new System.Drawing.Size(584, 522);
            this.bookPanel1.TabIndex = 1;
            this.bookPanel1.Visible = false;
            // 
            // rentPanel1
            // 
            this.rentPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentPanel1.Location = new System.Drawing.Point(0, 0);
            this.rentPanel1.Name = "rentPanel1";
            this.rentPanel1.Size = new System.Drawing.Size(584, 522);
            this.rentPanel1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Library Managemenet System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDb;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddBook;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddRent;
        private Bunifu.Framework.UI.BunifuFlatButton btnUserList;
        private Bunifu.Framework.UI.BunifuFlatButton btnBookList;
        private Bunifu.Framework.UI.BunifuFlatButton btnRentList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private RentPanel rentPanel1;
        private BookPanel bookPanel1;
        private UserPanel userPanel1;
        private AddRent addRent1;
        private AddBook addBook1;
        private AddUser addUser1;
        private System.Windows.Forms.LinkLabel linkLabel2;


    }
}
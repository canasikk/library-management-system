namespace Library_MS
{
    partial class AddRent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbUser = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbBook = new Bunifu.Framework.UI.BunifuDropdown();
            this.dtDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 5);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Select User";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 73);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(86, 16);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Select Book";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 141);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(96, 16);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Delivery Date";
            // 
            // cmbUser
            // 
            this.cmbUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbUser.BorderRadius = 3;
            this.cmbUser.ContextMenuStrip = this.contextMenuStrip1;
            this.cmbUser.DisabledColor = System.Drawing.Color.Gray;
            this.cmbUser.ForeColor = System.Drawing.Color.White;
            this.cmbUser.Items = new string[0];
            this.cmbUser.Location = new System.Drawing.Point(3, 28);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.cmbUser.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.cmbUser.selectedIndex = -1;
            this.cmbUser.Size = new System.Drawing.Size(315, 35);
            this.cmbUser.TabIndex = 0;
            // 
            // cmbBook
            // 
            this.cmbBook.BackColor = System.Drawing.Color.Transparent;
            this.cmbBook.BorderRadius = 3;
            this.cmbBook.ContextMenuStrip = this.contextMenuStrip1;
            this.cmbBook.DisabledColor = System.Drawing.Color.Gray;
            this.cmbBook.ForeColor = System.Drawing.Color.White;
            this.cmbBook.Items = new string[0];
            this.cmbBook.Location = new System.Drawing.Point(3, 96);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.cmbBook.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.cmbBook.selectedIndex = -1;
            this.cmbBook.Size = new System.Drawing.Size(315, 35);
            this.cmbBook.TabIndex = 1;
            // 
            // dtDate
            // 
            this.dtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.dtDate.BorderRadius = 0;
            this.dtDate.ContextMenuStrip = this.contextMenuStrip1;
            this.dtDate.ForeColor = System.Drawing.Color.White;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.FormatCustom = "dd.MM.yyyy";
            this.dtDate.Location = new System.Drawing.Point(3, 164);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(315, 36);
            this.dtDate.TabIndex = 2;
            this.dtDate.Value = new System.DateTime(2021, 6, 25, 21, 30, 1, 223);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(94, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(237)))), ((int)(((byte)(59)))));
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(126, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // AddRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "AddRent";
            this.Size = new System.Drawing.Size(321, 279);
            this.Load += new System.EventHandler(this.AddRent_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown cmbUser;
        private Bunifu.Framework.UI.BunifuDropdown cmbBook;
        private Bunifu.Framework.UI.BunifuDatepicker dtDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

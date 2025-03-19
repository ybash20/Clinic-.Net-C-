namespace Project_SE
{
    partial class personl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.texno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txlname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txfname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.texphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comaddress = new System.Windows.Forms.ComboBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.text_one = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
          
            this.personlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.personlBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personlBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.personlDataGridView = new System.Windows.Forms.DataGridView();
            this.BTNedit = new System.Windows.Forms.Button();
            this.BTNdel = new System.Windows.Forms.Button();
            this.checkshow_hide = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Backup = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.personlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personlBindingNavigator)).BeginInit();
            this.personlBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personlDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // texno
            // 
            this.texno.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texno.Location = new System.Drawing.Point(27, 62);
            this.texno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texno.MaxLength = 100;
            this.texno.Multiline = true;
            this.texno.Name = "texno";
            this.texno.Size = new System.Drawing.Size(172, 36);
            this.texno.TabIndex = 1;
            this.texno.TextChanged += new System.EventHandler(this.textnoDR_TextChanged);
            this.texno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texno_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(239, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 38);
            this.label4.TabIndex = 29;
            this.label4.Text = "رقم المريض";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txlname
            // 
            this.txlname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txlname.Location = new System.Drawing.Point(27, 212);
            this.txlname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txlname.MaxLength = 100;
            this.txlname.Multiline = true;
            this.txlname.Name = "txlname";
            this.txlname.Size = new System.Drawing.Size(172, 36);
            this.txlname.TabIndex = 3;
            this.txlname.TextChanged += new System.EventHandler(this.textnameDR_TextChanged);
            this.txlname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txlname_KeyDown);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(239, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 38);
            this.label3.TabIndex = 19;
            this.label3.Text = "الاسم الاخير";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(239, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "العنوان";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(239, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "الاسم الاول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txfname
            // 
            this.txfname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txfname.Location = new System.Drawing.Point(27, 142);
            this.txfname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txfname.MaxLength = 100;
            this.txfname.Multiline = true;
            this.txfname.Name = "txfname";
            this.txfname.Size = new System.Drawing.Size(172, 36);
            this.txfname.TabIndex = 2;
            this.txfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txfname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txfname_KeyDown);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(160, 404);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 55);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // texphone
            // 
            this.texphone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texphone.Location = new System.Drawing.Point(27, 350);
            this.texphone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texphone.MaxLength = 100;
            this.texphone.Multiline = true;
            this.texphone.Name = "texphone";
            this.texphone.Size = new System.Drawing.Size(172, 36);
            this.texphone.TabIndex = 5;
            this.texphone.TextChanged += new System.EventHandler(this.texphone_TextChanged);
            this.texphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texphone_KeyDown);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(239, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "رقم الهاتف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comaddress
            // 
            this.comaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comaddress.Font = new System.Drawing.Font("Tahoma", 14F);
            this.comaddress.FormattingEnabled = true;
            this.comaddress.Items.AddRange(new object[] {
            "عدن",
            "لحج",
            "Aden",
            "Lhij"});
            this.comaddress.Location = new System.Drawing.Point(27, 273);
            this.comaddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comaddress.Name = "comaddress";
            this.comaddress.Size = new System.Drawing.Size(172, 36);
            this.comaddress.TabIndex = 4;
            this.comaddress.SelectedIndexChanged += new System.EventHandler(this.comaddress_SelectedIndexChanged);
            this.comaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comaddress_KeyDown);
            // 
            // btn_one
            // 
            this.btn_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_one.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btn_one.ForeColor = System.Drawing.Color.Black;
            this.btn_one.Location = new System.Drawing.Point(937, 364);
            this.btn_one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(133, 43);
            this.btn_one.TabIndex = 32;
            this.btn_one.Text = "عرض";
            this.btn_one.UseVisualStyleBackColor = false;
            this.btn_one.Visible = false;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_all.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btn_all.ForeColor = System.Drawing.Color.Black;
            this.btn_all.Location = new System.Drawing.Point(937, 422);
            this.btn_all.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(153, 43);
            this.btn_all.TabIndex = 33;
            this.btn_all.Text = "عرض الكل";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Visible = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // text_one
            // 
            this.text_one.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_one.Location = new System.Drawing.Point(728, 421);
            this.text_one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_one.MaxLength = 100;
            this.text_one.Multiline = true;
            this.text_one.Name = "text_one";
            this.text_one.Size = new System.Drawing.Size(145, 42);
            this.text_one.TabIndex = 34;
            this.text_one.Visible = false;
            this.text_one.TextChanged += new System.EventHandler(this.text_one_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(728, 366);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 43);
            this.label6.TabIndex = 35;
            this.label6.Text = "رقم المريض";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // clinicDataSet1
            // 
           
            // personlBindingSource
            // 
            this.personlBindingSource.DataMember = "personl";
      
            // 
            // personlTableAdapter
            // 
           
            // personlBindingNavigator
            // 
            this.personlBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personlBindingNavigator.BindingSource = this.personlBindingSource;
            this.personlBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personlBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personlBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.personlBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.personlBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personlBindingNavigatorSaveItem});
            this.personlBindingNavigator.Location = new System.Drawing.Point(0, 512);
            this.personlBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personlBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personlBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personlBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personlBindingNavigator.Name = "personlBindingNavigator";
            this.personlBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personlBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.personlBindingNavigator.Size = new System.Drawing.Size(439, 31);
            this.personlBindingNavigator.TabIndex = 36;
            this.personlBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // personlBindingNavigatorSaveItem
            // 
            this.personlBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personlBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personlBindingNavigatorSaveItem.Image")));
            this.personlBindingNavigatorSaveItem.Name = "personlBindingNavigatorSaveItem";
            this.personlBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.personlBindingNavigatorSaveItem.Text = "Save Data";
            this.personlBindingNavigatorSaveItem.Click += new System.EventHandler(this.personlBindingNavigatorSaveItem_Click);
            // 
            // personlDataGridView
            // 
            this.personlDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personlDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personlDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personlDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.personlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personlDataGridView.Location = new System.Drawing.Point(540, 34);
            this.personlDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personlDataGridView.MultiSelect = false;
            this.personlDataGridView.Name = "personlDataGridView";
            this.personlDataGridView.ReadOnly = true;
            this.personlDataGridView.RowHeadersWidth = 51;
            this.personlDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personlDataGridView.Size = new System.Drawing.Size(547, 314);
            this.personlDataGridView.TabIndex = 36;
            this.personlDataGridView.Visible = false;
            this.personlDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personlDataGridView_CellContentClick);
            this.personlDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personlDataGridView_CellDoubleClick);
            // 
            // BTNedit
            // 
            this.BTNedit.BackColor = System.Drawing.Color.GhostWhite;
            this.BTNedit.Enabled = false;
            this.BTNedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNedit.Font = new System.Drawing.Font("Tahoma", 16F);
            this.BTNedit.ForeColor = System.Drawing.Color.Black;
            this.BTNedit.Location = new System.Drawing.Point(540, 416);
            this.BTNedit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNedit.Name = "BTNedit";
            this.BTNedit.Size = new System.Drawing.Size(133, 43);
            this.BTNedit.TabIndex = 37;
            this.BTNedit.Text = "تعديل";
            this.BTNedit.UseVisualStyleBackColor = false;
            this.BTNedit.Visible = false;
            this.BTNedit.Click += new System.EventHandler(this.BTNedit_Click);
            // 
            // BTNdel
            // 
            this.BTNdel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNdel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.BTNdel.ForeColor = System.Drawing.Color.Black;
            this.BTNdel.Location = new System.Drawing.Point(540, 366);
            this.BTNdel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNdel.Name = "BTNdel";
            this.BTNdel.Size = new System.Drawing.Size(133, 43);
            this.BTNdel.TabIndex = 38;
            this.BTNdel.Text = "حذف";
            this.BTNdel.UseVisualStyleBackColor = false;
            this.BTNdel.Visible = false;
            this.BTNdel.Click += new System.EventHandler(this.BTNdel_Click);
            // 
            // checkshow_hide
            // 
            this.checkshow_hide.Font = new System.Drawing.Font("Tahoma", 11F);
            this.checkshow_hide.Location = new System.Drawing.Point(145, 466);
            this.checkshow_hide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkshow_hide.Name = "checkshow_hide";
            this.checkshow_hide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkshow_hide.Size = new System.Drawing.Size(160, 37);
            this.checkshow_hide.TabIndex = 40;
            this.checkshow_hide.Text = "عرض التفاصيل";
            this.checkshow_hide.UseVisualStyleBackColor = true;
            this.checkshow_hide.CheckedChanged += new System.EventHandler(this.checkshow_hide_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 30);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Setting
            // 
            this.Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Backup});
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(83, 26);
            this.Setting.Text = "الاعدادات";
            // 
            // Backup
            // 
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(140, 26);
            this.Backup.Text = "Backup";
            this.Backup.Click += new System.EventHandler(this.Backup_Click);
            // 
            // personl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SE.Properties.Resources._7616ce55552d7a8548c7ed5b53aae6f0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 543);
            this.Controls.Add(this.checkshow_hide);
            this.Controls.Add(this.BTNdel);
            this.Controls.Add(this.BTNedit);
            this.Controls.Add(this.personlDataGridView);
            this.Controls.Add(this.personlBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_one);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.comaddress);
            this.Controls.Add(this.texphone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txfname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txlname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(120, 50);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "personl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "personl";
            this.Load += new System.EventHandler(this.personl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.personl_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.personlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personlBindingNavigator)).EndInit();
            this.personlBindingNavigator.ResumeLayout(false);
            this.personlBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personlDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox texno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txlname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txfname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox texphone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comaddress;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.TextBox text_one;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource personlBindingSource;

        private System.Windows.Forms.BindingNavigator personlBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personlBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView personlDataGridView;
        private System.Windows.Forms.Button BTNedit;
        private System.Windows.Forms.Button BTNdel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private System.Windows.Forms.ToolStripMenuItem Backup;
        public System.Windows.Forms.CheckBox checkshow_hide;
    }
}
namespace Pharmcacy1
{
    partial class Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtexprdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtmanudate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtmanufacturer = new System.Windows.Forms.TextBox();
            this.txtbatno = new System.Windows.Forms.TextBox();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medicinetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet10 = new Pharmcacy1.mypharmacyDataSet10();
            this.medicinetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet3 = new Pharmcacy1.mypharmacyDataSet3();
            this.medicine_tableTableAdapter = new Pharmcacy1.mypharmacyDataSet3TableAdapters.medicine_tableTableAdapter();
            this.medicine_tableTableAdapter1 = new Pharmcacy1.mypharmacyDataSet10TableAdapters.medicine_tableTableAdapter();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtexprdate);
            this.groupBox1.Controls.Add(this.txtmanudate);
            this.groupBox1.Controls.Add(this.txtmanufacturer);
            this.groupBox1.Controls.Add(this.txtbatno);
            this.groupBox1.Controls.Add(this.txtmedicine);
            this.groupBox1.Controls.Add(this.lblmsg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Details";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(178, 193);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(174, 23);
            this.txtquantity.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnsave.Location = new System.Drawing.Point(127, 417);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 33);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnreset
            // 
            this.btnreset.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnreset.Location = new System.Drawing.Point(219, 417);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 33);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(178, 341);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(174, 23);
            this.txtprice.TabIndex = 6;
            // 
            // txtexprdate
            // 
            this.txtexprdate.BackColor = System.Drawing.Color.Silver;
            this.txtexprdate.BorderRadius = 0;
            this.txtexprdate.ForeColor = System.Drawing.Color.White;
            this.txtexprdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtexprdate.FormatCustom = null;
            this.txtexprdate.Location = new System.Drawing.Point(178, 287);
            this.txtexprdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtexprdate.Name = "txtexprdate";
            this.txtexprdate.Size = new System.Drawing.Size(174, 28);
            this.txtexprdate.TabIndex = 5;
            this.txtexprdate.Value = new System.DateTime(2017, 10, 21, 22, 33, 11, 379);
            // 
            // txtmanudate
            // 
            this.txtmanudate.BackColor = System.Drawing.Color.Silver;
            this.txtmanudate.BorderRadius = 0;
            this.txtmanudate.ForeColor = System.Drawing.Color.White;
            this.txtmanudate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtmanudate.FormatCustom = null;
            this.txtmanudate.Location = new System.Drawing.Point(178, 237);
            this.txtmanudate.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanudate.Name = "txtmanudate";
            this.txtmanudate.Size = new System.Drawing.Size(174, 26);
            this.txtmanudate.TabIndex = 4;
            this.txtmanudate.Value = new System.DateTime(2017, 10, 21, 22, 32, 59, 81);
            // 
            // txtmanufacturer
            // 
            this.txtmanufacturer.Location = new System.Drawing.Point(178, 147);
            this.txtmanufacturer.Name = "txtmanufacturer";
            this.txtmanufacturer.Size = new System.Drawing.Size(174, 23);
            this.txtmanufacturer.TabIndex = 3;
            // 
            // txtbatno
            // 
            this.txtbatno.Location = new System.Drawing.Point(178, 102);
            this.txtbatno.Name = "txtbatno";
            this.txtbatno.Size = new System.Drawing.Size(174, 23);
            this.txtbatno.TabIndex = 2;
            // 
            // txtmedicine
            // 
            this.txtmedicine.Location = new System.Drawing.Point(178, 52);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(174, 23);
            this.txtmedicine.TabIndex = 1;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(80, 390);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 20);
            this.lblmsg.TabIndex = 0;
            this.lblmsg.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Expy Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantity:";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mf Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manufacturer:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Batch No:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(345, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Location = new System.Drawing.Point(427, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "MEDICINE MENU";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtsearch.BackgroundImage")));
            this.txtsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtsearch.ForeColor = System.Drawing.Color.Honeydew;
            this.txtsearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtsearch.Icon")));
            this.txtsearch.Location = new System.Drawing.Point(516, 65);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(180, 27);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.text = "";
            this.txtsearch.OnTextChange += new System.EventHandler(this.txtsearch_OnTextChange);
            this.txtsearch.KeyPress += new System.EventHandler(this.txtsearch_KeyPress);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(698, 65);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(32, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(431, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 431);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(154, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Available Drugs";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(210, 395);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 33);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Teal;
            this.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnedit.Location = new System.Drawing.Point(129, 395);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 32);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(9, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(407, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // medicinetableBindingSource1
            // 
            this.medicinetableBindingSource1.DataMember = "medicine_table";
            this.medicinetableBindingSource1.DataSource = this.mypharmacyDataSet10;
            // 
            // mypharmacyDataSet10
            // 
            this.mypharmacyDataSet10.DataSetName = "mypharmacyDataSet10";
            this.mypharmacyDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicinetableBindingSource
            // 
            this.medicinetableBindingSource.DataMember = "medicine_table";
            this.medicinetableBindingSource.DataSource = this.mypharmacyDataSet3;
            // 
            // mypharmacyDataSet3
            // 
            this.mypharmacyDataSet3.DataSetName = "mypharmacyDataSet3";
            this.mypharmacyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicine_tableTableAdapter
            // 
            this.medicine_tableTableAdapter.ClearBeforeFill = true;
            // 
            // medicine_tableTableAdapter1
            // 
            this.medicine_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(856, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(22, 16);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 20;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TextBox txtprice;
        private Bunifu.Framework.UI.BunifuDatepicker txtexprdate;
        private Bunifu.Framework.UI.BunifuDatepicker txtmanudate;
        private System.Windows.Forms.TextBox txtmanufacturer;
        private System.Windows.Forms.TextBox txtbatno;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuTextbox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblmsg;
        private mypharmacyDataSet3 mypharmacyDataSet3;
        private System.Windows.Forms.BindingSource medicinetableBindingSource;
        private mypharmacyDataSet3TableAdapters.medicine_tableTableAdapter medicine_tableTableAdapter;
        private System.Windows.Forms.Label label9;
        private mypharmacyDataSet10 mypharmacyDataSet10;
        private System.Windows.Forms.BindingSource medicinetableBindingSource1;
        private mypharmacyDataSet10TableAdapters.medicine_tableTableAdapter medicine_tableTableAdapter1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
    }
}
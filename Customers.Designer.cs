namespace Pharmcacy1
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet4 = new Pharmcacy1.mypharmacyDataSet4();
            this.customer_tableTableAdapter = new Pharmcacy1.mypharmacyDataSet4TableAdapters.customer_tableTableAdapter();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(193, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(58, 54);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblmsg);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtphoneno);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(66, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "..Customers Details";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(66, 222);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 18);
            this.lblmsg.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(94, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(147, 158);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(160, 51);
            this.txtaddress.TabIndex = 3;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(147, 110);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(160, 22);
            this.txtphoneno.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(147, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(160, 22);
            this.txtname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(429, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 440);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(155, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customers Diary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // customertableBindingSource
            // 
            this.customertableBindingSource.DataMember = "customer_table";
            this.customertableBindingSource.DataSource = this.mypharmacyDataSet4;
            // 
            // mypharmacyDataSet4
            // 
            this.mypharmacyDataSet4.DataSetName = "mypharmacyDataSet4";
            this.mypharmacyDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_tableTableAdapter
            // 
            this.customer_tableTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(855, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(22, 16);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 20;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblmsg;
        private mypharmacyDataSet4 mypharmacyDataSet4;
        private System.Windows.Forms.BindingSource customertableBindingSource;
        private mypharmacyDataSet4TableAdapters.customer_tableTableAdapter customer_tableTableAdapter;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
    }
}
namespace Pharmcacy1
{
    partial class usermessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usermessages));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.admintableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet8 = new Pharmcacy1.mypharmacyDataSet8();
            this.label1 = new System.Windows.Forms.Label();
            this.usersbiodataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet7 = new Pharmcacy1.mypharmacyDataSet7();
            this.mypharmacyDataSet6 = new Pharmcacy1.mypharmacyDataSet6();
            this.admintableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_tableTableAdapter = new Pharmcacy1.mypharmacyDataSet6TableAdapters.admin_tableTableAdapter();
            this.users_biodataTableAdapter = new Pharmcacy1.mypharmacyDataSet7TableAdapters.users_biodataTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.admin_tableTableAdapter1 = new Pharmcacy1.mypharmacyDataSet8TableAdapters.admin_tableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.admintableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbiodataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admintableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(152, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Messages";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 206);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 126);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.admintableBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "name";
            // 
            // admintableBindingSource1
            // 
            this.admintableBindingSource1.DataMember = "admin_table";
            this.admintableBindingSource1.DataSource = this.mypharmacyDataSet8;
            // 
            // mypharmacyDataSet8
            // 
            this.mypharmacyDataSet8.DataSetName = "mypharmacyDataSet8";
            this.mypharmacyDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(89, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Admin";
            // 
            // usersbiodataBindingSource
            // 
            this.usersbiodataBindingSource.DataMember = "users_biodata";
            this.usersbiodataBindingSource.DataSource = this.mypharmacyDataSet7;
            // 
            // mypharmacyDataSet7
            // 
            this.mypharmacyDataSet7.DataSetName = "mypharmacyDataSet7";
            this.mypharmacyDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mypharmacyDataSet6
            // 
            this.mypharmacyDataSet6.DataSetName = "mypharmacyDataSet6";
            this.mypharmacyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admintableBindingSource
            // 
            this.admintableBindingSource.DataMember = "admin_table";
            this.admintableBindingSource.DataSource = this.mypharmacyDataSet6;
            // 
            // admin_tableTableAdapter
            // 
            this.admin_tableTableAdapter.ClearBeforeFill = true;
            // 
            // users_biodataTableAdapter
            // 
            this.users_biodataTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(81, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type Message";
            // 
            // admin_tableTableAdapter1
            // 
            this.admin_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(320, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 359);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Messages";
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(731, 1);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(22, 16);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 20;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 335);
            this.dataGridView1.TabIndex = 3;
            // 
            // usermessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(755, 438);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "usermessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "usermessages";
            this.Load += new System.EventHandler(this.usermessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admintableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbiodataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admintableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private mypharmacyDataSet6 mypharmacyDataSet6;
        private System.Windows.Forms.BindingSource admintableBindingSource;
        private mypharmacyDataSet6TableAdapters.admin_tableTableAdapter admin_tableTableAdapter;
        private mypharmacyDataSet7 mypharmacyDataSet7;
        private System.Windows.Forms.BindingSource usersbiodataBindingSource;
        private mypharmacyDataSet7TableAdapters.users_biodataTableAdapter users_biodataTableAdapter;
        private System.Windows.Forms.Label label4;
        private mypharmacyDataSet8 mypharmacyDataSet8;
        private System.Windows.Forms.BindingSource admintableBindingSource1;
        private mypharmacyDataSet8TableAdapters.admin_tableTableAdapter admin_tableTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
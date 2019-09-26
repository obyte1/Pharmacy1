namespace Pharmcacy1
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersbiodataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet = new Pharmcacy1.mypharmacyDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messagetableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet12 = new Pharmcacy1.mypharmacyDataSet12();
            this.messagetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mypharmacyDataSet11 = new Pharmcacy1.mypharmacyDataSet11();
            this.mypharmacyDataSet2 = new Pharmcacy1.mypharmacyDataSet2();
            this.admintableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_tableTableAdapter = new Pharmcacy1.mypharmacyDataSet2TableAdapters.admin_tableTableAdapter();
            this.users_biodataTableAdapter = new Pharmcacy1.mypharmacyDataSetTableAdapters.users_biodataTableAdapter();
            this.message_tableTableAdapter = new Pharmcacy1.mypharmacyDataSet11TableAdapters.message_tableTableAdapter();
            this.messagetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.message_tableTableAdapter1 = new Pharmcacy1.mypharmacyDataSet12TableAdapters.message_tableTableAdapter();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbiodataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admintableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Inbox";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(82, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(79, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersbiodataBindingSource;
            this.comboBox1.DisplayMember = "username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // usersbiodataBindingSource
            // 
            this.usersbiodataBindingSource.DataMember = "users_biodata";
            this.usersbiodataBindingSource.DataSource = this.mypharmacyDataSet;
            // 
            // mypharmacyDataSet
            // 
            this.mypharmacyDataSet.DataSetName = "mypharmacyDataSet";
            this.mypharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(60, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select User:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 106);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(60, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Message:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(367, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 397);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Messages";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.receiverDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messagetableBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(495, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "receiver";
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            this.receiverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "sender";
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messagetableBindingSource2
            // 
            this.messagetableBindingSource2.DataMember = "message_table";
            this.messagetableBindingSource2.DataSource = this.mypharmacyDataSet12;
            // 
            // mypharmacyDataSet12
            // 
            this.mypharmacyDataSet12.DataSetName = "mypharmacyDataSet12";
            this.mypharmacyDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messagetableBindingSource
            // 
            this.messagetableBindingSource.DataMember = "message_table";
            this.messagetableBindingSource.DataSource = this.mypharmacyDataSet11;
            // 
            // mypharmacyDataSet11
            // 
            this.mypharmacyDataSet11.DataSetName = "mypharmacyDataSet11";
            this.mypharmacyDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mypharmacyDataSet2
            // 
            this.mypharmacyDataSet2.DataSetName = "mypharmacyDataSet2";
            this.mypharmacyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admintableBindingSource
            // 
            this.admintableBindingSource.DataMember = "admin_table";
            this.admintableBindingSource.DataSource = this.mypharmacyDataSet2;
            // 
            // admin_tableTableAdapter
            // 
            this.admin_tableTableAdapter.ClearBeforeFill = true;
            // 
            // users_biodataTableAdapter
            // 
            this.users_biodataTableAdapter.ClearBeforeFill = true;
            // 
            // message_tableTableAdapter
            // 
            this.message_tableTableAdapter.ClearBeforeFill = true;
            // 
            // messagetableBindingSource1
            // 
            this.messagetableBindingSource1.DataMember = "message_table";
            this.messagetableBindingSource1.DataSource = this.mypharmacyDataSet11;
            // 
            // message_tableTableAdapter1
            // 
            this.message_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(853, 3);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(22, 16);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 20;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Messages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersbiodataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypharmacyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admintableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagetableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private mypharmacyDataSet2 mypharmacyDataSet2;
        private System.Windows.Forms.BindingSource admintableBindingSource;
        private mypharmacyDataSet2TableAdapters.admin_tableTableAdapter admin_tableTableAdapter;
        private mypharmacyDataSet mypharmacyDataSet;
        private System.Windows.Forms.BindingSource usersbiodataBindingSource;
        private mypharmacyDataSetTableAdapters.users_biodataTableAdapter users_biodataTableAdapter;
        private mypharmacyDataSet11 mypharmacyDataSet11;
        private System.Windows.Forms.BindingSource messagetableBindingSource;
        private mypharmacyDataSet11TableAdapters.message_tableTableAdapter message_tableTableAdapter;
        private System.Windows.Forms.BindingSource messagetableBindingSource1;
        private mypharmacyDataSet12 mypharmacyDataSet12;
        private System.Windows.Forms.BindingSource messagetableBindingSource2;
        private mypharmacyDataSet12TableAdapters.message_tableTableAdapter message_tableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
    }
}
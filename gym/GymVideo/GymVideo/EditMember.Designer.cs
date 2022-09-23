
namespace GymVideo
{
    partial class EditMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMember));
            this.btnEdit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastNameEdit = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOBEdit = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerJoinDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxGymTimeEdit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddressEdit = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxMembershipEdit = new System.Windows.Forms.ComboBox();
            this.dataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.comboBoxGioitinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(408, 540);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 50);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(74, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstNameEdit
            // 
            this.txtFirstNameEdit.Location = new System.Drawing.Point(255, 50);
            this.txtFirstNameEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstNameEdit.Name = "txtFirstNameEdit";
            this.txtFirstNameEdit.Size = new System.Drawing.Size(136, 22);
            this.txtFirstNameEdit.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(74, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(84, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(68, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 27);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date Of Birth";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastNameEdit
            // 
            this.txtLastNameEdit.Location = new System.Drawing.Point(255, 137);
            this.txtLastNameEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastNameEdit.Name = "txtLastNameEdit";
            this.txtLastNameEdit.Size = new System.Drawing.Size(136, 22);
            this.txtLastNameEdit.TabIndex = 19;
            // 
            // dateTimePickerDOBEdit
            // 
            this.dateTimePickerDOBEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOBEdit.Location = new System.Drawing.Point(255, 302);
            this.dateTimePickerDOBEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDOBEdit.Name = "dateTimePickerDOBEdit";
            this.dateTimePickerDOBEdit.Size = new System.Drawing.Size(173, 22);
            this.dateTimePickerDOBEdit.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(539, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(667, 56);
            this.txtEmailEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(165, 22);
            this.txtEmailEdit.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(539, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 27);
            this.label7.TabIndex = 26;
            this.label7.Text = "Join Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerJoinDateEdit
            // 
            this.dateTimePickerJoinDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerJoinDateEdit.Location = new System.Drawing.Point(674, 142);
            this.dateTimePickerJoinDateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerJoinDateEdit.Name = "dateTimePickerJoinDateEdit";
            this.dateTimePickerJoinDateEdit.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerJoinDateEdit.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(526, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 27);
            this.label8.TabIndex = 28;
            this.label8.Text = "Gym Time";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxGymTimeEdit
            // 
            this.comboBoxGymTimeEdit.FormattingEnabled = true;
            this.comboBoxGymTimeEdit.Items.AddRange(new object[] {
            "06AM - 07AM",
            "07AM - 08AM",
            "08AM - 09AM",
            "05PM - 06PM",
            "06PM - 07PM"});
            this.comboBoxGymTimeEdit.Location = new System.Drawing.Point(685, 225);
            this.comboBoxGymTimeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGymTimeEdit.Name = "comboBoxGymTimeEdit";
            this.comboBoxGymTimeEdit.Size = new System.Drawing.Size(165, 24);
            this.comboBoxGymTimeEdit.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(516, 302);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "Address";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddressEdit
            // 
            this.txtAddressEdit.Location = new System.Drawing.Point(674, 292);
            this.txtAddressEdit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressEdit.Name = "txtAddressEdit";
            this.txtAddressEdit.Size = new System.Drawing.Size(165, 142);
            this.txtAddressEdit.TabIndex = 31;
            this.txtAddressEdit.Text = "";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(68, 413);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 21);
            this.label10.TabIndex = 32;
            this.label10.Text = "MemberShip Time";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxMembershipEdit
            // 
            this.comboBoxMembershipEdit.FormattingEnabled = true;
            this.comboBoxMembershipEdit.Items.AddRange(new object[] {
            "1 MONTH",
            "2 MONTH",
            "3 MONTH",
            "6 MONTH",
            "12 MONTH"});
            this.comboBoxMembershipEdit.Location = new System.Drawing.Point(255, 413);
            this.comboBoxMembershipEdit.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMembershipEdit.Name = "comboBoxMembershipEdit";
            this.comboBoxMembershipEdit.Size = new System.Drawing.Size(165, 24);
            this.comboBoxMembershipEdit.TabIndex = 33;
            // 
            // dataGridViewEdit
            // 
            this.dataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdit.Location = new System.Drawing.Point(39, 625);
            this.dataGridViewEdit.Name = "dataGridViewEdit";
            this.dataGridViewEdit.RowHeadersWidth = 51;
            this.dataGridViewEdit.RowTemplate.Height = 24;
            this.dataGridViewEdit.Size = new System.Drawing.Size(895, 168);
            this.dataGridViewEdit.TabIndex = 34;
            // 
            // comboBoxGioitinh
            // 
            this.comboBoxGioitinh.FormattingEnabled = true;
            this.comboBoxGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.comboBoxGioitinh.Location = new System.Drawing.Point(255, 225);
            this.comboBoxGioitinh.Name = "comboBoxGioitinh";
            this.comboBoxGioitinh.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGioitinh.TabIndex = 35;
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 826);
            this.Controls.Add(this.comboBoxGioitinh);
            this.Controls.Add(this.dataGridViewEdit);
            this.Controls.Add(this.comboBoxMembershipEdit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddressEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxGymTimeEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerJoinDateEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmailEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDOBEdit);
            this.Controls.Add(this.txtLastNameEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstNameEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EditMember";
            this.Text = "EditMember";
            this.Load += new System.EventHandler(this.EditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastNameEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOBEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerJoinDateEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxGymTimeEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtAddressEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxMembershipEdit;
        private System.Windows.Forms.DataGridView dataGridViewEdit;
        private System.Windows.Forms.ComboBox comboBoxGioitinh;
    }
}
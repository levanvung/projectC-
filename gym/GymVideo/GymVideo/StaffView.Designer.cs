
namespace GymVideo
{
    partial class StaffView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffView));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.SID = new System.Windows.Forms.Label();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.SearchStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(38, 234);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(776, 266);
            this.dataGridView3.TabIndex = 0;
            // 
            // SID
            // 
            this.SID.AutoSize = true;
            this.SID.Location = new System.Drawing.Point(304, 90);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(57, 17);
            this.SID.TabIndex = 1;
            this.SID.Text = "Nhap id";
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Location = new System.Drawing.Point(425, 90);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(201, 22);
            this.txtStaffSearch.TabIndex = 2;
            // 
            // SearchStaff
            // 
            this.SearchStaff.Location = new System.Drawing.Point(296, 158);
            this.SearchStaff.Name = "SearchStaff";
            this.SearchStaff.Size = new System.Drawing.Size(75, 23);
            this.SearchStaff.TabIndex = 3;
            this.SearchStaff.Text = "Search";
            this.SearchStaff.UseVisualStyleBackColor = true;
            this.SearchStaff.Click += new System.EventHandler(this.SearchStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(425, 158);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 4;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // StaffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 512);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.SearchStaff);
            this.Controls.Add(this.txtStaffSearch);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.dataGridView3);
            this.Name = "StaffView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffView";
            this.Load += new System.EventHandler(this.StaffView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label SID;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Button SearchStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
    }
}
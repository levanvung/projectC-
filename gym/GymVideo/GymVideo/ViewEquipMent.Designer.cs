
namespace GymVideo
{
    partial class ViewEquipMent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEquipMent));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EID = new System.Windows.Forms.Label();
            this.btnSearchE = new System.Windows.Forms.Button();
            this.txtSearchE = new System.Windows.Forms.TextBox();
            this.btnDeleteE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // EID
            // 
            this.EID.AutoSize = true;
            this.EID.Location = new System.Drawing.Point(272, 80);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(57, 17);
            this.EID.TabIndex = 1;
            this.EID.Text = "Nhap id";
            // 
            // btnSearchE
            // 
            this.btnSearchE.Location = new System.Drawing.Point(265, 183);
            this.btnSearchE.Name = "btnSearchE";
            this.btnSearchE.Size = new System.Drawing.Size(75, 23);
            this.btnSearchE.TabIndex = 2;
            this.btnSearchE.Text = "Search";
            this.btnSearchE.UseVisualStyleBackColor = true;
            this.btnSearchE.Click += new System.EventHandler(this.btnSearchE_Click);
            // 
            // txtSearchE
            // 
            this.txtSearchE.Location = new System.Drawing.Point(459, 80);
            this.txtSearchE.Name = "txtSearchE";
            this.txtSearchE.Size = new System.Drawing.Size(145, 22);
            this.txtSearchE.TabIndex = 3;
            // 
            // btnDeleteE
            // 
            this.btnDeleteE.Location = new System.Drawing.Point(469, 183);
            this.btnDeleteE.Name = "btnDeleteE";
            this.btnDeleteE.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteE.TabIndex = 4;
            this.btnDeleteE.Text = "Delete";
            this.btnDeleteE.UseVisualStyleBackColor = true;
            this.btnDeleteE.Click += new System.EventHandler(this.btnDeleteE_Click);
            // 
            // ViewEquipMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 582);
            this.Controls.Add(this.btnDeleteE);
            this.Controls.Add(this.txtSearchE);
            this.Controls.Add(this.btnSearchE);
            this.Controls.Add(this.EID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewEquipMent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEquipMent";
            this.Load += new System.EventHandler(this.ViewEquipMent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label EID;
        private System.Windows.Forms.Button btnSearchE;
        private System.Windows.Forms.TextBox txtSearchE;
        private System.Windows.Forms.Button btnDeleteE;
    }
}
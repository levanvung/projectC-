
namespace GymVideo
{
    partial class Thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewthongke1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewthongke3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewthongke2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê";
            // 
            // dataGridViewthongke1
            // 
            this.dataGridViewthongke1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthongke1.Location = new System.Drawing.Point(12, 181);
            this.dataGridViewthongke1.Name = "dataGridViewthongke1";
            this.dataGridViewthongke1.RowHeadersWidth = 51;
            this.dataGridViewthongke1.RowTemplate.Height = 24;
            this.dataGridViewthongke1.Size = new System.Drawing.Size(442, 225);
            this.dataGridViewthongke1.TabIndex = 1;
            // 
            // dataGridViewthongke3
            // 
            this.dataGridViewthongke3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthongke3.Location = new System.Drawing.Point(378, 531);
            this.dataGridViewthongke3.Name = "dataGridViewthongke3";
            this.dataGridViewthongke3.RowHeadersWidth = 51;
            this.dataGridViewthongke3.RowTemplate.Height = 24;
            this.dataGridViewthongke3.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewthongke3.TabIndex = 2;
            // 
            // dataGridViewthongke2
            // 
            this.dataGridViewthongke2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewthongke2.Location = new System.Drawing.Point(611, 191);
            this.dataGridViewthongke2.Name = "dataGridViewthongke2";
            this.dataGridViewthongke2.RowHeadersWidth = 51;
            this.dataGridViewthongke2.RowTemplate.Height = 24;
            this.dataGridViewthongke2.Size = new System.Drawing.Size(423, 215);
            this.dataGridViewthongke2.TabIndex = 3;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 767);
            this.Controls.Add(this.dataGridViewthongke2);
            this.Controls.Add(this.dataGridViewthongke3);
            this.Controls.Add(this.dataGridViewthongke1);
            this.Controls.Add(this.label1);
            this.Name = "Thongke";
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewthongke2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewthongke1;
        private System.Windows.Forms.DataGridView dataGridViewthongke3;
        private System.Windows.Forms.DataGridView dataGridViewthongke2;
    }
}

namespace GymVideo
{
    partial class ViewPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPT));
            this.dataGridViewPT = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchPT = new System.Windows.Forms.TextBox();
            this.btnSearchPT = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPT
            // 
            this.dataGridViewPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPT.Location = new System.Drawing.Point(12, 330);
            this.dataGridViewPT.Name = "dataGridViewPT";
            this.dataGridViewPT.RowHeadersWidth = 51;
            this.dataGridViewPT.RowTemplate.Height = 24;
            this.dataGridViewPT.Size = new System.Drawing.Size(930, 238);
            this.dataGridViewPT.TabIndex = 0;
            this.dataGridViewPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPT_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhap Id";
            // 
            // txtSearchPT
            // 
            this.txtSearchPT.Location = new System.Drawing.Point(497, 109);
            this.txtSearchPT.Name = "txtSearchPT";
            this.txtSearchPT.Size = new System.Drawing.Size(155, 22);
            this.txtSearchPT.TabIndex = 2;
            // 
            // btnSearchPT
            // 
            this.btnSearchPT.Location = new System.Drawing.Point(375, 235);
            this.btnSearchPT.Name = "btnSearchPT";
            this.btnSearchPT.Size = new System.Drawing.Size(102, 37);
            this.btnSearchPT.TabIndex = 3;
            this.btnSearchPT.Text = "Search";
            this.btnSearchPT.UseVisualStyleBackColor = true;
            this.btnSearchPT.Click += new System.EventHandler(this.btnSearchPT_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ViewPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 580);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchPT);
            this.Controls.Add(this.txtSearchPT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPT);
            this.Name = "ViewPT";
            this.Text = "ViewPT";
            this.Load += new System.EventHandler(this.ViewPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchPT;
        private System.Windows.Forms.Button btnSearchPT;
        private System.Windows.Forms.Button btnDelete;
    }
}
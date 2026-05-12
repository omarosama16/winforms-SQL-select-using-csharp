namespace selectform
{
    partial class Form1
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
            this.btnSimpleSelect = new System.Windows.Forms.Button();
            this.btnJoinSelect = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpleSelect
            // 
            this.btnSimpleSelect.Location = new System.Drawing.Point(343, 89);
            this.btnSimpleSelect.Name = "btnSimpleSelect";
            this.btnSimpleSelect.Size = new System.Drawing.Size(133, 23);
            this.btnSimpleSelect.TabIndex = 0;
            this.btnSimpleSelect.Text = "Simple Select";
            this.btnSimpleSelect.UseVisualStyleBackColor = true;
            this.btnSimpleSelect.Click += new System.EventHandler(this.btnSimpleSelect_Click);            // 
            // btnJoinSelect
            // 
            this.btnJoinSelect.Location = new System.Drawing.Point(343, 159);
            this.btnJoinSelect.Name = "btnJoinSelect";
            this.btnJoinSelect.Size = new System.Drawing.Size(133, 23);
            this.btnJoinSelect.TabIndex = 1;
            this.btnJoinSelect.Text = "Join Select";
            this.btnJoinSelect.UseVisualStyleBackColor = true;
            this.btnJoinSelect.Click += new System.EventHandler(this.btnJoinSelect_Click);            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnJoinSelect);
            this.Controls.Add(this.btnSimpleSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleSelect;
        private System.Windows.Forms.Button btnJoinSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


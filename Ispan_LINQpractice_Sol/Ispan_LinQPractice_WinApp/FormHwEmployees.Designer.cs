namespace Ispan_LinQPractice_WinApp
{
    partial class FormHwEmployees
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
            this.dataGridViewRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewLeft = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRight
            // 
            this.dataGridViewRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRight.Location = new System.Drawing.Point(443, 36);
            this.dataGridViewRight.Name = "dataGridViewRight";
            this.dataGridViewRight.RowHeadersWidth = 51;
            this.dataGridViewRight.RowTemplate.Height = 27;
            this.dataGridViewRight.Size = new System.Drawing.Size(336, 294);
            this.dataGridViewRight.TabIndex = 0;
            // 
            // dataGridViewLeft
            // 
            this.dataGridViewLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeft.Location = new System.Drawing.Point(84, 36);
            this.dataGridViewLeft.Name = "dataGridViewLeft";
            this.dataGridViewLeft.RowHeadersWidth = 51;
            this.dataGridViewLeft.RowTemplate.Height = 27;
            this.dataGridViewLeft.Size = new System.Drawing.Size(336, 294);
            this.dataGridViewLeft.TabIndex = 1;
            this.dataGridViewLeft.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeft_CellClick);
            // 
            // FormHwEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewLeft);
            this.Controls.Add(this.dataGridViewRight);
            this.Name = "FormHwEmployees";
            this.Text = "FormHwEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRight;
        private System.Windows.Forms.DataGridView dataGridViewLeft;
    }
}
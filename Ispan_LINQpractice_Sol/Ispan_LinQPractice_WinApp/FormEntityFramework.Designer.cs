namespace Ispan_LinQPractice_WinApp
{
    partial class FormEntityFramework
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
            this.buttonEntityEmplyees = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCategoryCreate = new System.Windows.Forms.Button();
            this.buttonCategoryUpdate = new System.Windows.Forms.Button();
            this.buttonCategoryDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntityEmplyees
            // 
            this.buttonEntityEmplyees.Location = new System.Drawing.Point(25, 34);
            this.buttonEntityEmplyees.Name = "buttonEntityEmplyees";
            this.buttonEntityEmplyees.Size = new System.Drawing.Size(115, 42);
            this.buttonEntityEmplyees.TabIndex = 0;
            this.buttonEntityEmplyees.Text = "EntityEmplyees";
            this.buttonEntityEmplyees.UseVisualStyleBackColor = true;
            this.buttonEntityEmplyees.Click += new System.EventHandler(this.buttonEntityEmplyees_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(602, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonCategoryCreate
            // 
            this.buttonCategoryCreate.Location = new System.Drawing.Point(25, 104);
            this.buttonCategoryCreate.Name = "buttonCategoryCreate";
            this.buttonCategoryCreate.Size = new System.Drawing.Size(115, 42);
            this.buttonCategoryCreate.TabIndex = 2;
            this.buttonCategoryCreate.Text = "CategoryCreate";
            this.buttonCategoryCreate.UseVisualStyleBackColor = true;
            this.buttonCategoryCreate.Click += new System.EventHandler(this.buttonCategoryCreate_Click);
            // 
            // buttonCategoryUpdate
            // 
            this.buttonCategoryUpdate.Location = new System.Drawing.Point(25, 163);
            this.buttonCategoryUpdate.Name = "buttonCategoryUpdate";
            this.buttonCategoryUpdate.Size = new System.Drawing.Size(115, 42);
            this.buttonCategoryUpdate.TabIndex = 3;
            this.buttonCategoryUpdate.Text = "CategoryUpdate";
            this.buttonCategoryUpdate.UseVisualStyleBackColor = true;
            this.buttonCategoryUpdate.Click += new System.EventHandler(this.buttonCategoryUpdate_Click);
            // 
            // buttonCategoryDelete
            // 
            this.buttonCategoryDelete.Location = new System.Drawing.Point(25, 225);
            this.buttonCategoryDelete.Name = "buttonCategoryDelete";
            this.buttonCategoryDelete.Size = new System.Drawing.Size(115, 42);
            this.buttonCategoryDelete.TabIndex = 4;
            this.buttonCategoryDelete.Text = "CategoryDelete";
            this.buttonCategoryDelete.UseVisualStyleBackColor = true;
            this.buttonCategoryDelete.Click += new System.EventHandler(this.buttonCategoryDelete_Click);
            // 
            // FormEntityFramework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCategoryDelete);
            this.Controls.Add(this.buttonCategoryUpdate);
            this.Controls.Add(this.buttonCategoryCreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEntityEmplyees);
            this.Name = "FormEntityFramework";
            this.Text = "FormEntityFramework";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntityEmplyees;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCategoryCreate;
        private System.Windows.Forms.Button buttonCategoryUpdate;
        private System.Windows.Forms.Button buttonCategoryDelete;
    }
}
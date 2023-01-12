namespace Ispan_LinQPractice_WinApp
{
    partial class FormEntityJoin
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
            this.buttonEntityJoin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOuterJoin = new System.Windows.Forms.Button();
            this.buttonDirectJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEntityJoin
            // 
            this.buttonEntityJoin.Location = new System.Drawing.Point(43, 43);
            this.buttonEntityJoin.Name = "buttonEntityJoin";
            this.buttonEntityJoin.Size = new System.Drawing.Size(127, 66);
            this.buttonEntityJoin.TabIndex = 0;
            this.buttonEntityJoin.Text = "EntityJoin";
            this.buttonEntityJoin.UseVisualStyleBackColor = true;
            this.buttonEntityJoin.Click += new System.EventHandler(this.buttonEntityJoin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(527, 361);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonOuterJoin
            // 
            this.buttonOuterJoin.Location = new System.Drawing.Point(43, 142);
            this.buttonOuterJoin.Name = "buttonOuterJoin";
            this.buttonOuterJoin.Size = new System.Drawing.Size(127, 66);
            this.buttonOuterJoin.TabIndex = 2;
            this.buttonOuterJoin.Text = "EntityOuterJoin";
            this.buttonOuterJoin.UseVisualStyleBackColor = true;
            this.buttonOuterJoin.Click += new System.EventHandler(this.buttonOuterJoin_Click);
            // 
            // buttonDirectJoin
            // 
            this.buttonDirectJoin.Location = new System.Drawing.Point(43, 234);
            this.buttonDirectJoin.Name = "buttonDirectJoin";
            this.buttonDirectJoin.Size = new System.Drawing.Size(127, 66);
            this.buttonDirectJoin.TabIndex = 3;
            this.buttonDirectJoin.Text = "EntityDirectJoin";
            this.buttonDirectJoin.UseVisualStyleBackColor = true;
            this.buttonDirectJoin.Click += new System.EventHandler(this.buttonDirectJoin_Click);
            // 
            // FormEntityJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDirectJoin);
            this.Controls.Add(this.buttonOuterJoin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEntityJoin);
            this.Name = "FormEntityJoin";
            this.Text = "FormEntityJoin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntityJoin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOuterJoin;
        private System.Windows.Forms.Button buttonDirectJoin;
    }
}
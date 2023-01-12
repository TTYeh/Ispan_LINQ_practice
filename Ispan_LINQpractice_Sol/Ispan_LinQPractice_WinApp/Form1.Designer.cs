namespace Ispan_LinQPractice_WinApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonQuery2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCreateDat = new System.Windows.Forms.Button();
            this.buttonGroupByLinQ = new System.Windows.Forms.Button();
            this.buttonQueryCategory = new System.Windows.Forms.Button();
            this.buttonLinQObj = new System.Windows.Forms.Button();
            this.buttonAggrecation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(449, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonQuery.Location = new System.Drawing.Point(15, 17);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(184, 64);
            this.buttonQuery.TabIndex = 1;
            this.buttonQuery.Text = "QueryBySql";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonQuery2
            // 
            this.buttonQuery2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonQuery2.Location = new System.Drawing.Point(15, 97);
            this.buttonQuery2.Name = "buttonQuery2";
            this.buttonQuery2.Size = new System.Drawing.Size(184, 64);
            this.buttonQuery2.TabIndex = 2;
            this.buttonQuery2.Text = "QueryByLinQ";
            this.buttonQuery2.UseVisualStyleBackColor = true;
            this.buttonQuery2.Click += new System.EventHandler(this.buttonQuery2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(747, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "LinQ select Array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(947, 48);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(180, 174);
            this.textBoxResult.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAggrecation);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonCreateDat);
            this.panel1.Controls.Add(this.buttonGroupByLinQ);
            this.panel1.Controls.Add(this.buttonQueryCategory);
            this.panel1.Controls.Add(this.buttonLinQObj);
            this.panel1.Controls.Add(this.buttonQuery2);
            this.panel1.Controls.Add(this.buttonQuery);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(49, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 469);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(528, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 42);
            this.button3.TabIndex = 10;
            this.button3.Text = "LinQ_篩選基數偶數群組";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(368, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "LinQ_篩選偶數";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCreateDat
            // 
            this.buttonCreateDat.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCreateDat.Location = new System.Drawing.Point(208, 389);
            this.buttonCreateDat.Name = "buttonCreateDat";
            this.buttonCreateDat.Size = new System.Drawing.Size(154, 42);
            this.buttonCreateDat.TabIndex = 6;
            this.buttonCreateDat.Text = "LinQ_產生資料";
            this.buttonCreateDat.UseVisualStyleBackColor = true;
            this.buttonCreateDat.Click += new System.EventHandler(this.buttonCreateDat_Click);
            // 
            // buttonGroupByLinQ
            // 
            this.buttonGroupByLinQ.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGroupByLinQ.Location = new System.Drawing.Point(15, 319);
            this.buttonGroupByLinQ.Name = "buttonGroupByLinQ";
            this.buttonGroupByLinQ.Size = new System.Drawing.Size(184, 64);
            this.buttonGroupByLinQ.TabIndex = 8;
            this.buttonGroupByLinQ.Text = "GroupByLinQ";
            this.buttonGroupByLinQ.UseVisualStyleBackColor = true;
            this.buttonGroupByLinQ.Click += new System.EventHandler(this.buttonGroupByLinQ_Click);
            // 
            // buttonQueryCategory
            // 
            this.buttonQueryCategory.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonQueryCategory.Location = new System.Drawing.Point(15, 246);
            this.buttonQueryCategory.Name = "buttonQueryCategory";
            this.buttonQueryCategory.Size = new System.Drawing.Size(184, 64);
            this.buttonQueryCategory.TabIndex = 7;
            this.buttonQueryCategory.Text = "QueryCategory";
            this.buttonQueryCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQueryCategory.UseVisualStyleBackColor = true;
            this.buttonQueryCategory.Click += new System.EventHandler(this.buttonQueryCategory_Click);
            // 
            // buttonLinQObj
            // 
            this.buttonLinQObj.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLinQObj.Location = new System.Drawing.Point(15, 167);
            this.buttonLinQObj.Name = "buttonLinQObj";
            this.buttonLinQObj.Size = new System.Drawing.Size(184, 64);
            this.buttonLinQObj.TabIndex = 6;
            this.buttonLinQObj.Text = "LinQ select 匿名類別";
            this.buttonLinQObj.UseVisualStyleBackColor = true;
            this.buttonLinQObj.Click += new System.EventHandler(this.buttonLinQObj_Click);
            // 
            // buttonAggrecation
            // 
            this.buttonAggrecation.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAggrecation.Location = new System.Drawing.Point(15, 389);
            this.buttonAggrecation.Name = "buttonAggrecation";
            this.buttonAggrecation.Size = new System.Drawing.Size(184, 64);
            this.buttonAggrecation.TabIndex = 11;
            this.buttonAggrecation.Text = "Product彙總函數";
            this.buttonAggrecation.UseVisualStyleBackColor = true;
            this.buttonAggrecation.Click += new System.EventHandler(this.buttonAggrecation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonQuery2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLinQObj;
        private System.Windows.Forms.Button buttonQueryCategory;
        private System.Windows.Forms.Button buttonGroupByLinQ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCreateDat;
        private System.Windows.Forms.Button buttonAggrecation;
    }
}


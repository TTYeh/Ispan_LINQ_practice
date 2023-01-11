namespace Ispan_LinQPractice_WinApp
{
    partial class Form2
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
            this.buttonDelegateInvoke = new System.Windows.Forms.Button();
            this.buttonDelegate = new System.Windows.Forms.Button();
            this.buttonDelegateInvoke2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelegateInvoke
            // 
            this.buttonDelegateInvoke.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelegateInvoke.Location = new System.Drawing.Point(25, 108);
            this.buttonDelegateInvoke.Name = "buttonDelegateInvoke";
            this.buttonDelegateInvoke.Size = new System.Drawing.Size(184, 64);
            this.buttonDelegateInvoke.TabIndex = 4;
            this.buttonDelegateInvoke.Text = "Delegate Invoke";
            this.buttonDelegateInvoke.UseVisualStyleBackColor = true;
            this.buttonDelegateInvoke.Click += new System.EventHandler(this.buttonDelegateInvoke_Click);
            // 
            // buttonDelegate
            // 
            this.buttonDelegate.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelegate.Location = new System.Drawing.Point(25, 38);
            this.buttonDelegate.Name = "buttonDelegate";
            this.buttonDelegate.Size = new System.Drawing.Size(184, 64);
            this.buttonDelegate.TabIndex = 5;
            this.buttonDelegate.Text = "Delegate ";
            this.buttonDelegate.UseVisualStyleBackColor = true;
            this.buttonDelegate.Click += new System.EventHandler(this.buttonDelegate_Click);
            // 
            // buttonDelegateInvoke2
            // 
            this.buttonDelegateInvoke2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDelegateInvoke2.Location = new System.Drawing.Point(25, 178);
            this.buttonDelegateInvoke2.Name = "buttonDelegateInvoke2";
            this.buttonDelegateInvoke2.Size = new System.Drawing.Size(184, 64);
            this.buttonDelegateInvoke2.TabIndex = 6;
            this.buttonDelegateInvoke2.Text = "Multi Invoke";
            this.buttonDelegateInvoke2.UseVisualStyleBackColor = true;
            this.buttonDelegateInvoke2.Click += new System.EventHandler(this.buttonDelegateInvoke2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "21";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCreateButton
            // 
            this.buttonCreateButton.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCreateButton.Location = new System.Drawing.Point(25, 300);
            this.buttonCreateButton.Name = "buttonCreateButton";
            this.buttonCreateButton.Size = new System.Drawing.Size(184, 64);
            this.buttonCreateButton.TabIndex = 9;
            this.buttonCreateButton.Text = "CreateButton";
            this.buttonCreateButton.UseVisualStyleBackColor = true;
            this.buttonCreateButton.Click += new System.EventHandler(this.buttonCreateButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelegateInvoke2);
            this.Controls.Add(this.buttonDelegate);
            this.Controls.Add(this.buttonDelegateInvoke);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelegateInvoke;
        private System.Windows.Forms.Button buttonDelegate;
        private System.Windows.Forms.Button buttonDelegateInvoke2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCreateButton;
    }
}
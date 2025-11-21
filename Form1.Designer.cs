namespace FirstLabExamOOP
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
            this.btnGetFullName = new System.Windows.Forms.Button();
            this.btnShowRegularSalary = new System.Windows.Forms.Button();
            this.btnShowJOSalary = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetFullName
            // 
            this.btnGetFullName.Location = new System.Drawing.Point(16, 15);
            this.btnGetFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetFullName.Name = "btnGetFullName";
            this.btnGetFullName.Size = new System.Drawing.Size(431, 90);
            this.btnGetFullName.TabIndex = 0;
            this.btnGetFullName.Text = "1. Get Employee Full Name";
            this.btnGetFullName.UseVisualStyleBackColor = true;
            this.btnGetFullName.Click += new System.EventHandler(this.btnGetFullName_Click);
            // 
            // btnShowRegularSalary
            // 
            this.btnShowRegularSalary.Location = new System.Drawing.Point(17, 112);
            this.btnShowRegularSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowRegularSalary.Name = "btnShowRegularSalary";
            this.btnShowRegularSalary.Size = new System.Drawing.Size(431, 90);
            this.btnShowRegularSalary.TabIndex = 1;
            this.btnShowRegularSalary.Text = "2. Show Regular Employee Salary";
            this.btnShowRegularSalary.UseVisualStyleBackColor = true;
            this.btnShowRegularSalary.Click += new System.EventHandler(this.btnShowRegularSalary_Click);
            // 
            // btnShowJOSalary
            // 
            this.btnShowJOSalary.Location = new System.Drawing.Point(17, 209);
            this.btnShowJOSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowJOSalary.Name = "btnShowJOSalary";
            this.btnShowJOSalary.Size = new System.Drawing.Size(431, 90);
            this.btnShowJOSalary.TabIndex = 2;
            this.btnShowJOSalary.Text = "3. Show Contractual Employee Salary";
            this.btnShowJOSalary.UseVisualStyleBackColor = true;
            this.btnShowJOSalary.Click += new System.EventHandler(this.btnShowJOSalary_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 306);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(431, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "4. Show Saving to MySQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 90);
            this.button1.TabIndex = 4;
            this.button1.Text = "5. Manager Approve Leave";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowJOSalary);
            this.Controls.Add(this.btnShowRegularSalary);
            this.Controls.Add(this.btnGetFullName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetFullName;
        private System.Windows.Forms.Button btnShowRegularSalary;
        private System.Windows.Forms.Button btnShowJOSalary;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


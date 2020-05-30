namespace SalaryCalculator
{
    partial class SalaryCalculator
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSalEarned = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbYears = new System.Windows.Forms.Label();
            this.lbCompany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(12, 26);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 18);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(15, 63);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(40, 18);
            this.lbAge.TabIndex = 1;
            this.lbAge.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 27);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(100, 61);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(130, 20);
            this.txtAge.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(18, 266);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(144, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbSalEarned
            // 
            this.lbSalEarned.AutoSize = true;
            this.lbSalEarned.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalEarned.Location = new System.Drawing.Point(15, 224);
            this.lbSalEarned.Name = "lbSalEarned";
            this.lbSalEarned.Size = new System.Drawing.Size(113, 18);
            this.lbSalEarned.TabIndex = 16;
            this.lbSalEarned.Text = "Salary Earned:";
            this.lbSalEarned.Visible = false;
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(100, 187);
            this.txtSal.MaxLength = 10;
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(133, 20);
            this.txtSal.TabIndex = 14;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(155, 148);
            this.txtYears.MaxLength = 3;
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(75, 20);
            this.txtYears.TabIndex = 13;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(106, 100);
            this.txtCompany.MaxLength = 25;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(124, 20);
            this.txtCompany.TabIndex = 12;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(15, 189);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(71, 18);
            this.lbSalary.TabIndex = 11;
            this.lbSalary.Text = "Salary: $";
            // 
            // lbYears
            // 
            this.lbYears.AutoSize = true;
            this.lbYears.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYears.Location = new System.Drawing.Point(15, 148);
            this.lbYears.Name = "lbYears";
            this.lbYears.Size = new System.Drawing.Size(129, 18);
            this.lbYears.TabIndex = 10;
            this.lbYears.Text = "Years Employed:";
            // 
            // lbCompany
            // 
            this.lbCompany.AutoSize = true;
            this.lbCompany.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompany.Location = new System.Drawing.Point(15, 103);
            this.lbCompany.Name = "lbCompany";
            this.lbCompany.Size = new System.Drawing.Size(84, 18);
            this.lbCompany.TabIndex = 9;
            this.lbCompany.Text = "Company: ";
            // 
            // SalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 339);
            this.Controls.Add(this.lbSalEarned);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbYears);
            this.Controls.Add(this.lbCompany);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Name = "SalaryCalculator";
            this.ShowIcon = false;
            this.Text = "Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbSalEarned;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbYears;
        private System.Windows.Forms.Label lbCompany;
    }
}


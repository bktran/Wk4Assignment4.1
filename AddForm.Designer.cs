namespace Wk4Assignment4._1
{
    partial class AddForm
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
            btnSubmit = new Button();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtWork = new TextBox();
            txtMobile = new TextBox();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.PowderBlue;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(178, 231);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(234, 83);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnAddContact_Click;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(55, 75);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(210, 23);
            txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(293, 75);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(210, 23);
            txtLast.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 51);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 3;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(293, 51);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(536, 51);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 5;
            label3.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(536, 75);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(203, 173);
            txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(57, 132);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 7;
            label4.Text = "Mobile Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(293, 132);
            label5.Name = "label5";
            label5.Size = new Size(98, 21);
            label5.TabIndex = 8;
            label5.Text = "Work Phone:";
            // 
            // txtWork
            // 
            txtWork.Location = new Point(293, 156);
            txtWork.Name = "txtWork";
            txtWork.Size = new Size(210, 23);
            txtWork.TabIndex = 9;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(57, 156);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(210, 23);
            txtMobile.TabIndex = 10;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(780, 359);
            Controls.Add(txtMobile);
            Controls.Add(txtWork);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(btnSubmit);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtFirst;
        private TextBox txtLast;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Label label5;
        private TextBox txtWork;
        private TextBox txtMobile;
    }
}
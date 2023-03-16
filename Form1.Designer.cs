
namespace Bai1
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
            this.lbLG = new System.Windows.Forms.Label();
            this.lbUS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUS = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLG
            // 
            this.lbLG.AutoSize = true;
            this.lbLG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLG.Location = new System.Drawing.Point(310, 52);
            this.lbLG.Name = "lbLG";
            this.lbLG.Size = new System.Drawing.Size(137, 25);
            this.lbLG.TabIndex = 0;
            this.lbLG.Text = "Login Details";
            // 
            // lbUS
            // 
            this.lbUS.AutoSize = true;
            this.lbUS.Location = new System.Drawing.Point(207, 111);
            this.lbUS.Name = "lbUS";
            this.lbUS.Size = new System.Drawing.Size(88, 13);
            this.lbUS.TabIndex = 1;
            this.lbUS.Text = "Enter User Name";
            this.lbUS.Click += new System.EventHandler(this.lbUS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Password";
            // 
            // txtUS
            // 
            this.txtUS.Location = new System.Drawing.Point(386, 108);
            this.txtUS.Name = "txtUS";
            this.txtUS.Size = new System.Drawing.Size(179, 20);
            this.txtUS.TabIndex = 3;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(386, 176);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(179, 20);
            this.txtPW.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(261, 273);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 35);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(401, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUS);
            this.Controls.Add(this.lbLG);
            this.Name = "Form1";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLG;
        private System.Windows.Forms.Label lbUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUS;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}



namespace Bai1
{
    partial class frmEmployee
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
            this.lbEP = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAdd = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbEdu = new System.Windows.Forms.Label();
            this.lbDep = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lstEdu = new System.Windows.Forms.ListBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEP
            // 
            this.lbEP.AutoSize = true;
            this.lbEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEP.Location = new System.Drawing.Point(322, 38);
            this.lbEP.Name = "lbEP";
            this.lbEP.Size = new System.Drawing.Size(234, 25);
            this.lbEP.TabIndex = 0;
            this.lbEP.Text = "Employee Details Form";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(230, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(84, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Employee Name";
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Location = new System.Drawing.Point(230, 140);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(94, 13);
            this.lbAdd.TabIndex = 2;
            this.lbAdd.Text = "Employee Address";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(230, 183);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(78, 13);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date of Joining";
            // 
            // lbEdu
            // 
            this.lbEdu.AutoSize = true;
            this.lbEdu.Location = new System.Drawing.Point(230, 223);
            this.lbEdu.Name = "lbEdu";
            this.lbEdu.Size = new System.Drawing.Size(55, 13);
            this.lbEdu.TabIndex = 4;
            this.lbEdu.Text = "Education";
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Location = new System.Drawing.Point(230, 266);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(62, 13);
            this.lbDep.TabIndex = 5;
            this.lbDep.Text = "Department";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(379, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(379, 133);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(213, 26);
            this.txtAdd.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(379, 180);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(213, 20);
            this.txtDate.TabIndex = 8;
            // 
            // lstEdu
            // 
            this.lstEdu.FormattingEnabled = true;
            this.lstEdu.Items.AddRange(new object[] {
            "UnderGraduate",
            "College",
            "Intermediate"});
            this.lstEdu.Location = new System.Drawing.Point(378, 225);
            this.lstEdu.Name = "lstEdu";
            this.lstEdu.Size = new System.Drawing.Size(213, 17);
            this.lstEdu.TabIndex = 9;
            this.lstEdu.SelectedIndexChanged += new System.EventHandler(this.lstEdu_SelectedIndexChanged);
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(377, 272);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(213, 21);
            this.cbDep.Sorted = true;
            this.cbDep.TabIndex = 10;
            this.cbDep.SelectedIndexChanged += new System.EventHandler(this.cbDep_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(268, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(385, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(513, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 27);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.lstEdu);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbDep);
            this.Controls.Add(this.lbEdu);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEP);
            this.Name = "frmEmployee";
            this.Text = "Employee Details Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEP;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbEdu;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ListBox lstEdu;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}
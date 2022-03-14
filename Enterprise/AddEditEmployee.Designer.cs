
namespace Enterprise
{
    partial class AddEditEmployee
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.lbRelease = new System.Windows.Forms.Label();
            this.lbEmploy = new System.Windows.Forms.Label();
            this.lbEarnings = new System.Windows.Forms.Label();
            this.tbEarnings = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dtpEmployment = new System.Windows.Forms.DateTimePicker();
            this.tbDateRelease = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 381);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(192, 381);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 25);
            this.btnConfirm.TabIndex = 42;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Uwagi:";
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(147, 264);
            this.rtbComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(237, 96);
            this.rtbComments.TabIndex = 40;
            this.rtbComments.Text = "";
            // 
            // lbRelease
            // 
            this.lbRelease.AutoSize = true;
            this.lbRelease.Location = new System.Drawing.Point(3, 224);
            this.lbRelease.Name = "lbRelease";
            this.lbRelease.Size = new System.Drawing.Size(111, 17);
            this.lbRelease.TabIndex = 35;
            this.lbRelease.Text = "Data zwolnienia:";
            // 
            // lbEmploy
            // 
            this.lbEmploy.AutoSize = true;
            this.lbEmploy.Location = new System.Drawing.Point(3, 187);
            this.lbEmploy.Name = "lbEmploy";
            this.lbEmploy.Size = new System.Drawing.Size(124, 17);
            this.lbEmploy.TabIndex = 33;
            this.lbEmploy.Text = "Data zatrudnienia:";
            // 
            // lbEarnings
            // 
            this.lbEarnings.AutoSize = true;
            this.lbEarnings.Location = new System.Drawing.Point(3, 149);
            this.lbEarnings.Name = "lbEarnings";
            this.lbEarnings.Size = new System.Drawing.Size(60, 17);
            this.lbEarnings.TabIndex = 31;
            this.lbEarnings.Text = "Zarobki:";
            // 
            // tbEarnings
            // 
            this.tbEarnings.Location = new System.Drawing.Point(147, 145);
            this.tbEarnings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEarnings.Name = "tbEarnings";
            this.tbEarnings.Size = new System.Drawing.Size(237, 22);
            this.tbEarnings.TabIndex = 30;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(3, 110);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 17);
            this.lbLastName.TabIndex = 29;
            this.lbLastName.Text = "Nazwisko:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(147, 107);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(237, 22);
            this.tbLastName.TabIndex = 28;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(3, 73);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(37, 17);
            this.lbFirstName.TabIndex = 27;
            this.lbFirstName.Text = "Imię:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(147, 70);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(237, 22);
            this.tbFirstName.TabIndex = 26;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(3, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 17);
            this.lbId.TabIndex = 25;
            this.lbId.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(147, 29);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(237, 22);
            this.tbId.TabIndex = 24;
            // 
            // dtpEmployment
            // 
            this.dtpEmployment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmployment.Location = new System.Drawing.Point(147, 182);
            this.dtpEmployment.Name = "dtpEmployment";
            this.dtpEmployment.Size = new System.Drawing.Size(237, 22);
            this.dtpEmployment.TabIndex = 44;
            // 
            // tbDateRelease
            // 
            this.tbDateRelease.Location = new System.Drawing.Point(147, 221);
            this.tbDateRelease.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDateRelease.Name = "tbDateRelease";
            this.tbDateRelease.Size = new System.Drawing.Size(237, 22);
            this.tbDateRelease.TabIndex = 34;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 421);
            this.Controls.Add(this.dtpEmployment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.lbRelease);
            this.Controls.Add(this.tbDateRelease);
            this.Controls.Add(this.lbEmploy);
            this.Controls.Add(this.lbEarnings);
            this.Controls.Add(this.tbEarnings);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEditEmployee";
            this.Text = "AddEditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label lbRelease;
        private System.Windows.Forms.Label lbEmploy;
        private System.Windows.Forms.Label lbEarnings;
        private System.Windows.Forms.TextBox tbEarnings;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DateTimePicker dtpEmployment;
        private System.Windows.Forms.TextBox tbDateRelease;
    }
}
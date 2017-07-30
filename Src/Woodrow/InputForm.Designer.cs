namespace Woodrow
{
    partial class InputForm
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
            this.numMigration = new System.Windows.Forms.NumericUpDown();
            this.txtTeam = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblMigration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMigration)).BeginInit();
            this.SuspendLayout();
            // 
            // numMigration
            // 
            this.numMigration.Location = new System.Drawing.Point(88, 35);
            this.numMigration.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numMigration.Name = "numMigration";
            this.numMigration.Size = new System.Drawing.Size(100, 20);
            this.numMigration.TabIndex = 1;
            // 
            // txtTeam
            // 
            this.txtTeam.Location = new System.Drawing.Point(88, 6);
            this.txtTeam.Name = "txtTeam";
            this.txtTeam.Size = new System.Drawing.Size(100, 20);
            this.txtTeam.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(116, 72);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(45, 9);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(37, 13);
            this.lblTeam.TabIndex = 4;
            this.lblTeam.Text = "Team:";
            // 
            // lblMigration
            // 
            this.lblMigration.AutoSize = true;
            this.lblMigration.Location = new System.Drawing.Point(12, 35);
            this.lblMigration.Name = "lblMigration";
            this.lblMigration.Size = new System.Drawing.Size(70, 13);
            this.lblMigration.TabIndex = 5;
            this.lblMigration.Text = "Migration No:";
            // 
            // InputForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.lblMigration);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTeam);
            this.Controls.Add(this.numMigration);
            this.Name = "InputForm";
            this.Text = "Migration Separator";
            ((System.ComponentModel.ISupportInitialize)(this.numMigration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMigration;
        private System.Windows.Forms.TextBox txtTeam;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblMigration;
    }
}
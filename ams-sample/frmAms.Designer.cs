namespace ams_sample
{
    partial class frmAms
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtIDnumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdrTimeIn = new System.Windows.Forms.RadioButton();
            this.rdrTimeOut = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeColumns = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(51, 37);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(687, 305);
            this.grdData.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(545, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(652, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.Location = new System.Drawing.Point(282, 395);
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.Size = new System.Drawing.Size(123, 20);
            this.txtIDnumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID number";
            // 
            // rdrTimeIn
            // 
            this.rdrTimeIn.AutoSize = true;
            this.rdrTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdrTimeIn.Location = new System.Drawing.Point(434, 376);
            this.rdrTimeIn.Name = "rdrTimeIn";
            this.rdrTimeIn.Size = new System.Drawing.Size(59, 17);
            this.rdrTimeIn.TabIndex = 5;
            this.rdrTimeIn.TabStop = true;
            this.rdrTimeIn.Text = "Time in";
            this.rdrTimeIn.UseVisualStyleBackColor = true;
            // 
            // rdrTimeOut
            // 
            this.rdrTimeOut.AutoSize = true;
            this.rdrTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdrTimeOut.Location = new System.Drawing.Point(434, 399);
            this.rdrTimeOut.Name = "rdrTimeOut";
            this.rdrTimeOut.Size = new System.Drawing.Size(66, 17);
            this.rdrTimeOut.TabIndex = 5;
            this.rdrTimeOut.TabStop = true;
            this.rdrTimeOut.Text = "Time out";
            this.rdrTimeOut.UseVisualStyleBackColor = true;
            // 
            // frmAms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdrTimeOut);
            this.Controls.Add(this.rdrTimeIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDnumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Monitoring";
            this.Load += new System.EventHandler(this.frmAms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtIDnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdrTimeIn;
        private System.Windows.Forms.RadioButton rdrTimeOut;
    }
}


namespace ams_sample
{
    partial class frmAmsMain
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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.Button();
            this.toolStripClearAttendance = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.grdData.Location = new System.Drawing.Point(56, 88);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(687, 305);
            this.grdData.TabIndex = 6;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Location = new System.Drawing.Point(438, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(657, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.Location = new System.Drawing.Point(204, 448);
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.Size = new System.Drawing.Size(123, 20);
            this.txtIDnumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID number";
            // 
            // rdrTimeIn
            // 
            this.rdrTimeIn.AutoSize = true;
            this.rdrTimeIn.Checked = true;
            this.rdrTimeIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdrTimeIn.Location = new System.Drawing.Point(356, 429);
            this.rdrTimeIn.Name = "rdrTimeIn";
            this.rdrTimeIn.Size = new System.Drawing.Size(59, 17);
            this.rdrTimeIn.TabIndex = 1;
            this.rdrTimeIn.TabStop = true;
            this.rdrTimeIn.Text = "Time in";
            this.rdrTimeIn.UseVisualStyleBackColor = true;
            // 
            // rdrTimeOut
            // 
            this.rdrTimeOut.AutoSize = true;
            this.rdrTimeOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdrTimeOut.Location = new System.Drawing.Point(356, 452);
            this.rdrTimeOut.Name = "rdrTimeOut";
            this.rdrTimeOut.Size = new System.Drawing.Size(66, 17);
            this.rdrTimeOut.TabIndex = 2;
            this.rdrTimeOut.Text = "Time out";
            this.rdrTimeOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attendance Monitoring System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripManageStudent,
            this.toolStripClearAttendance});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "&Menu";
            // 
            // toolStripManageStudent
            // 
            this.toolStripManageStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripManageStudent.Name = "toolStripManageStudent";
            this.toolStripManageStudent.Size = new System.Drawing.Size(180, 22);
            this.toolStripManageStudent.Text = "Manage Student";
            this.toolStripManageStudent.Click += new System.EventHandler(this.toolStripManageStudent_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(548, 429);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 39);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripClearAttendance
            // 
            this.toolStripClearAttendance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripClearAttendance.Name = "toolStripClearAttendance";
            this.toolStripClearAttendance.Size = new System.Drawing.Size(180, 22);
            this.toolStripClearAttendance.Text = "Clear Attendance";
            this.toolStripClearAttendance.Click += new System.EventHandler(this.toolStripClearAttendance_Click);
            // 
            // frmAmsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 505);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdrTimeOut);
            this.Controls.Add(this.rdrTimeIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDnumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAmsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Monitoring";
            this.Load += new System.EventHandler(this.frmAms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripManageStudent;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripClearAttendance;
    }
}


namespace AssignmeentTwoVP
{
    partial class ViewAttendence
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
            this.viewAttendenceDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewAttendenceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAttendenceDataGridView
            // 
            this.viewAttendenceDataGridView.AllowUserToDeleteRows = false;
            this.viewAttendenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAttendenceDataGridView.Location = new System.Drawing.Point(12, 31);
            this.viewAttendenceDataGridView.Name = "viewAttendenceDataGridView";
            this.viewAttendenceDataGridView.Size = new System.Drawing.Size(646, 369);
            this.viewAttendenceDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewAttendenceDataGridView);
            this.Name = "ViewAttendence";
            this.Text = "ViewAttendence";
            this.Load += new System.EventHandler(this.ViewAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAttendenceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAttendenceDataGridView;
        private System.Windows.Forms.Button button1;
    }
}
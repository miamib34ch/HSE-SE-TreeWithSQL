namespace TreeWithSQL
{
    partial class AddCourse
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFacultyId = new System.Windows.Forms.Label();
            this.labelCourseNumber = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFacultyId = new System.Windows.Forms.TextBox();
            this.textBoxCourseNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(108, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(13, 17);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // labelFacultyId
            // 
            this.labelFacultyId.AutoSize = true;
            this.labelFacultyId.Location = new System.Drawing.Point(13, 44);
            this.labelFacultyId.Name = "labelFacultyId";
            this.labelFacultyId.Size = new System.Drawing.Size(50, 13);
            this.labelFacultyId.TabIndex = 3;
            this.labelFacultyId.Text = "FacultyId";
            // 
            // labelCourseNumber
            // 
            this.labelCourseNumber.AutoSize = true;
            this.labelCourseNumber.Location = new System.Drawing.Point(13, 70);
            this.labelCourseNumber.Name = "labelCourseNumber";
            this.labelCourseNumber.Size = new System.Drawing.Size(77, 13);
            this.labelCourseNumber.TabIndex = 4;
            this.labelCourseNumber.Text = "CourseNumber";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(96, 14);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxFacultyId
            // 
            this.textBoxFacultyId.Location = new System.Drawing.Point(96, 41);
            this.textBoxFacultyId.Name = "textBoxFacultyId";
            this.textBoxFacultyId.Size = new System.Drawing.Size(100, 20);
            this.textBoxFacultyId.TabIndex = 6;
            // 
            // textBoxCourseNumber
            // 
            this.textBoxCourseNumber.Location = new System.Drawing.Point(96, 67);
            this.textBoxCourseNumber.Name = "textBoxCourseNumber";
            this.textBoxCourseNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourseNumber.TabIndex = 7;
            this.textBoxCourseNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCourseNumber_KeyUp);
            // 
            // AddCourse
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(215, 130);
            this.Controls.Add(this.textBoxCourseNumber);
            this.Controls.Add(this.textBoxFacultyId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelCourseNumber);
            this.Controls.Add(this.labelFacultyId);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление курса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFacultyId;
        private System.Windows.Forms.Label labelCourseNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxFacultyId;
        private System.Windows.Forms.TextBox textBoxCourseNumber;
    }
}
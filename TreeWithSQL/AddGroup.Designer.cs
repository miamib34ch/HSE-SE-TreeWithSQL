namespace TreeWithSQL
{
    partial class AddGroup
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelCourseId = new System.Windows.Forms.Label();
            this.labelGroupNumber = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 95);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(13, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // labelCourseId
            // 
            this.labelCourseId.AutoSize = true;
            this.labelCourseId.Location = new System.Drawing.Point(13, 43);
            this.labelCourseId.Name = "labelCourseId";
            this.labelCourseId.Size = new System.Drawing.Size(49, 13);
            this.labelCourseId.TabIndex = 3;
            this.labelCourseId.Text = "CourseId";
            // 
            // labelGroupNumber
            // 
            this.labelGroupNumber.AutoSize = true;
            this.labelGroupNumber.Location = new System.Drawing.Point(13, 72);
            this.labelGroupNumber.Name = "labelGroupNumber";
            this.labelGroupNumber.Size = new System.Drawing.Size(73, 13);
            this.labelGroupNumber.TabIndex = 4;
            this.labelGroupNumber.Text = "GroupNumber";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(93, 14);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(111, 20);
            this.textBoxId.TabIndex = 5;
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(93, 43);
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(111, 20);
            this.textBoxCourseId.TabIndex = 6;
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Location = new System.Drawing.Point(93, 69);
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(111, 20);
            this.textBoxGroupNumber.TabIndex = 7;
            this.textBoxGroupNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCourseNumber_KeyUp);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 130);
            this.Controls.Add(this.textBoxGroupNumber);
            this.Controls.Add(this.textBoxCourseId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelGroupNumber);
            this.Controls.Add(this.labelCourseId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroup";
            this.Text = "Добавление группы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCourseId;
        private System.Windows.Forms.Label labelGroupNumber;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
    }
}
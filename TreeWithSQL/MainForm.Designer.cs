namespace TreeWithSQL
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вывестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДеревоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьФакультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNodeFaculty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNodeGroup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripNodeCourse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTreeView.SuspendLayout();
            this.contextMenuStripNodeFaculty.SuspendLayout();
            this.contextMenuStripNodeGroup.SuspendLayout();
            this.contextMenuStripNodeCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.ContextMenuStrip = this.contextMenuStripTreeView;
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(383, 521);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // contextMenuStripTreeView
            // 
            this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вывестиToolStripMenuItem,
            this.обновитьДеревоToolStripMenuItem,
            this.удалитьДеревоToolStripMenuItem,
            this.добавитьФакультетToolStripMenuItem});
            this.contextMenuStripTreeView.Name = "contextMenuStrip1";
            this.contextMenuStripTreeView.Size = new System.Drawing.Size(186, 92);
            // 
            // вывестиToolStripMenuItem
            // 
            this.вывестиToolStripMenuItem.Name = "вывестиToolStripMenuItem";
            this.вывестиToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.вывестиToolStripMenuItem.Text = "Вывести дерево";
            this.вывестиToolStripMenuItem.Click += new System.EventHandler(this.вывестиToolStripMenuItem_Click);
            // 
            // обновитьДеревоToolStripMenuItem
            // 
            this.обновитьДеревоToolStripMenuItem.Name = "обновитьДеревоToolStripMenuItem";
            this.обновитьДеревоToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.обновитьДеревоToolStripMenuItem.Text = "Обновить дерево";
            this.обновитьДеревоToolStripMenuItem.Click += new System.EventHandler(this.обновитьДеревоToolStripMenuItem_Click);
            // 
            // удалитьДеревоToolStripMenuItem
            // 
            this.удалитьДеревоToolStripMenuItem.Name = "удалитьДеревоToolStripMenuItem";
            this.удалитьДеревоToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.удалитьДеревоToolStripMenuItem.Text = "Удалить дерево";
            this.удалитьДеревоToolStripMenuItem.Click += new System.EventHandler(this.удалитьДеревоToolStripMenuItem_Click);
            // 
            // добавитьФакультетToolStripMenuItem
            // 
            this.добавитьФакультетToolStripMenuItem.Name = "добавитьФакультетToolStripMenuItem";
            this.добавитьФакультетToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.добавитьФакультетToolStripMenuItem.Text = "Добавить факультет";
            this.добавитьФакультетToolStripMenuItem.Click += new System.EventHandler(this.добавитьФакультетToolStripMenuItem_Click);
            // 
            // contextMenuStripNodeFaculty
            // 
            this.contextMenuStripNodeFaculty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.contextMenuStripNodeFaculty.Name = "contextMenuStrip2";
            this.contextMenuStripNodeFaculty.Size = new System.Drawing.Size(129, 70);
            this.contextMenuStripNodeFaculty.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNodeFaculty_Opening);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // contextMenuStripNodeGroup
            // 
            this.contextMenuStripNodeGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1});
            this.contextMenuStripNodeGroup.Name = "contextMenuStrip3";
            this.contextMenuStripNodeGroup.Size = new System.Drawing.Size(129, 48);
            this.contextMenuStripNodeGroup.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNodeGroup_Opening);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // contextMenuStripNodeCourse
            // 
            this.contextMenuStripNodeCourse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2,
            this.добавитьToolStripMenuItem1});
            this.contextMenuStripNodeCourse.Name = "contextMenuStripNodeCourse";
            this.contextMenuStripNodeCourse.Size = new System.Drawing.Size(129, 70);
            this.contextMenuStripNodeCourse.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripNodeCourse_Opening);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.удалитьToolStripMenuItem2_Click);
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            this.изменитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 542);
            this.Controls.Add(this.treeView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripTreeView.ResumeLayout(false);
            this.contextMenuStripNodeFaculty.ResumeLayout(false);
            this.contextMenuStripNodeGroup.ResumeLayout(false);
            this.contextMenuStripNodeCourse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
        private System.Windows.Forms.ToolStripMenuItem вывестиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodeFaculty;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodeGroup;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem обновитьДеревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДеревоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьФакультетToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNodeCourse;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
    }
}


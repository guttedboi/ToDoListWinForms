namespace ToDoListWinForms
{
    partial class startproject
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
            this.projectList = new System.Windows.Forms.ListBox();
            this.addProject = new System.Windows.Forms.Button();
            this.delProject = new System.Windows.Forms.Button();
            this.openProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectList
            // 
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(244, 89);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(156, 160);
            this.projectList.TabIndex = 1;
            // 
            // addProject
            // 
            this.addProject.Location = new System.Drawing.Point(12, 323);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(75, 34);
            this.addProject.TabIndex = 2;
            this.addProject.Text = "Добавить проект";
            this.addProject.UseVisualStyleBackColor = true;
            // 
            // delProject
            // 
            this.delProject.Location = new System.Drawing.Point(93, 323);
            this.delProject.Name = "delProject";
            this.delProject.Size = new System.Drawing.Size(75, 34);
            this.delProject.TabIndex = 3;
            this.delProject.Text = "Удалить проект";
            this.delProject.UseVisualStyleBackColor = true;
            // 
            // openProject
            // 
            this.openProject.Location = new System.Drawing.Point(174, 323);
            this.openProject.Name = "openProject";
            this.openProject.Size = new System.Drawing.Size(75, 34);
            this.openProject.TabIndex = 4;
            this.openProject.Text = "Открыть проект";
            this.openProject.UseVisualStyleBackColor = true;
            // 
            // startproject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 369);
            this.Controls.Add(this.openProject);
            this.Controls.Add(this.delProject);
            this.Controls.Add(this.addProject);
            this.Controls.Add(this.projectList);
            this.Name = "startproject";
            this.Text = "startproject";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox projectList;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Button delProject;
        private System.Windows.Forms.Button openProject;
    }
}
namespace Швейная_Фабрика
{
    partial class AdminPanel
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
            this.AddUser_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser_but
            // 
            this.AddUser_but.Location = new System.Drawing.Point(67, 79);
            this.AddUser_but.Name = "AddUser_but";
            this.AddUser_but.Size = new System.Drawing.Size(179, 41);
            this.AddUser_but.TabIndex = 0;
            this.AddUser_but.Text = "Управление пользователями";
            this.AddUser_but.UseVisualStyleBackColor = true;
            this.AddUser_but.Click += new System.EventHandler(this.AddUser_but_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 397);
            this.Controls.Add(this.AddUser_but);
            this.Name = "AdminPanel";
            this.Text = "Швейная фабрика";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUser_but;
    }
}

namespace StudentGradeApplication
{
    partial class StudentGradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentGradeForm));
            this.first_panel = new System.Windows.Forms.Panel();
            this.welcome_screen = new System.Windows.Forms.PictureBox();
            this.next_button1 = new System.Windows.Forms.PictureBox();
            this.first_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_panel
            // 
            this.first_panel.Controls.Add(this.next_button1);
            this.first_panel.Controls.Add(this.welcome_screen);
            this.first_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first_panel.Location = new System.Drawing.Point(0, 0);
            this.first_panel.Name = "first_panel";
            this.first_panel.Size = new System.Drawing.Size(334, 561);
            this.first_panel.TabIndex = 0;
            // 
            // welcome_screen
            // 
            this.welcome_screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome_screen.Image = global::StudentGradeApplication.Properties.Resources.opening;
            this.welcome_screen.Location = new System.Drawing.Point(0, 0);
            this.welcome_screen.Name = "welcome_screen";
            this.welcome_screen.Size = new System.Drawing.Size(334, 561);
            this.welcome_screen.TabIndex = 0;
            this.welcome_screen.TabStop = false;
            // 
            // next_button1
            // 
            this.next_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.next_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button1.Image = ((System.Drawing.Image)(resources.GetObject("next_button1.Image")));
            this.next_button1.Location = new System.Drawing.Point(42, 367);
            this.next_button1.Name = "next_button1";
            this.next_button1.Size = new System.Drawing.Size(184, 80);
            this.next_button1.TabIndex = 1;
            this.next_button1.TabStop = false;
            // 
            // StudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.first_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Application";
            this.first_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.welcome_screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel first_panel;
        private System.Windows.Forms.PictureBox welcome_screen;
        private System.Windows.Forms.PictureBox next_button1;
    }
}


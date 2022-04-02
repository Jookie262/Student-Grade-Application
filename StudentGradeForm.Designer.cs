
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
            this.second_panel = new System.Windows.Forms.Panel();
            this.back_button1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.next_button2 = new System.Windows.Forms.PictureBox();
            this.first_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button1)).BeginInit();
            this.second_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button2)).BeginInit();
            this.SuspendLayout();
            // 
            // first_panel
            // 
            this.first_panel.Controls.Add(this.second_panel);
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
            // second_panel
            // 
            this.second_panel.BackgroundImage = global::StudentGradeApplication.Properties.Resources.bg1;
            this.second_panel.Controls.Add(this.next_button2);
            this.second_panel.Controls.Add(this.name_textbox);
            this.second_panel.Controls.Add(this.pictureBox2);
            this.second_panel.Controls.Add(this.back_button1);
            this.second_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.second_panel.Location = new System.Drawing.Point(0, 0);
            this.second_panel.Name = "second_panel";
            this.second_panel.Size = new System.Drawing.Size(334, 561);
            this.second_panel.TabIndex = 2;
            // 
            // back_button1
            // 
            this.back_button1.BackColor = System.Drawing.Color.Transparent;
            this.back_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button1.Image = global::StudentGradeApplication.Properties.Resources.back;
            this.back_button1.Location = new System.Drawing.Point(32, 96);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(75, 54);
            this.back_button1.TabIndex = 0;
            this.back_button1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::StudentGradeApplication.Properties.Resources.name;
            this.pictureBox2.Location = new System.Drawing.Point(32, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 92);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.Transparent;
            this.name_textbox.BorderRadius = 25;
            this.name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_textbox.DefaultText = "";
            this.name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_textbox.DisabledState.Parent = this.name_textbox;
            this.name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_textbox.FocusedState.Parent = this.name_textbox;
            this.name_textbox.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(82)))));
            this.name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_textbox.HoverState.Parent = this.name_textbox;
            this.name_textbox.Location = new System.Drawing.Point(32, 260);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.name_textbox.PasswordChar = '\0';
            this.name_textbox.PlaceholderText = "";
            this.name_textbox.SelectedText = "";
            this.name_textbox.ShadowDecoration.Parent = this.name_textbox;
            this.name_textbox.Size = new System.Drawing.Size(271, 50);
            this.name_textbox.TabIndex = 2;
            this.name_textbox.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // next_button2
            // 
            this.next_button2.BackColor = System.Drawing.Color.Transparent;
            this.next_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button2.Image = global::StudentGradeApplication.Properties.Resources.NEXT;
            this.next_button2.Location = new System.Drawing.Point(21, 328);
            this.next_button2.Name = "next_button2";
            this.next_button2.Size = new System.Drawing.Size(184, 87);
            this.next_button2.TabIndex = 3;
            this.next_button2.TabStop = false;
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
            this.second_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel first_panel;
        private System.Windows.Forms.PictureBox welcome_screen;
        private System.Windows.Forms.PictureBox next_button1;
        private System.Windows.Forms.Panel second_panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox back_button1;
        private System.Windows.Forms.PictureBox next_button2;
        private Guna.UI2.WinForms.Guna2TextBox name_textbox;
    }
}


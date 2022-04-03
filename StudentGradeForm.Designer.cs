
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
            this.second_panel = new System.Windows.Forms.Panel();
            this.third_panel = new System.Windows.Forms.Panel();
            this.fourth_panel = new System.Windows.Forms.Panel();
            this.again_button = new System.Windows.Forms.PictureBox();
            this.second_text_average = new System.Windows.Forms.Label();
            this.first_text_average = new System.Windows.Forms.Label();
            this.pass_or_fail = new System.Windows.Forms.PictureBox();
            this.back_button2 = new System.Windows.Forms.PictureBox();
            this.next_button3 = new System.Windows.Forms.PictureBox();
            this.history_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.history_label = new System.Windows.Forms.Label();
            this.filipino_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.filipino_label = new System.Windows.Forms.Label();
            this.science_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.science_label = new System.Windows.Forms.Label();
            this.math_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.math_label = new System.Windows.Forms.Label();
            this.english_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.english_label = new System.Windows.Forms.Label();
            this.grades_label = new System.Windows.Forms.PictureBox();
            this.next_button2 = new System.Windows.Forms.PictureBox();
            this.name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_button1 = new System.Windows.Forms.PictureBox();
            this.next_button1 = new System.Windows.Forms.PictureBox();
            this.welcome_screen = new System.Windows.Forms.PictureBox();
            this.first_panel.SuspendLayout();
            this.second_panel.SuspendLayout();
            this.third_panel.SuspendLayout();
            this.fourth_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.again_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_or_fail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grades_label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_screen)).BeginInit();
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
            // second_panel
            // 
            this.second_panel.BackgroundImage = global::StudentGradeApplication.Properties.Resources.bg1;
            this.second_panel.Controls.Add(this.third_panel);
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
            // third_panel
            // 
            this.third_panel.BackgroundImage = global::StudentGradeApplication.Properties.Resources.bg2;
            this.third_panel.Controls.Add(this.fourth_panel);
            this.third_panel.Controls.Add(this.back_button2);
            this.third_panel.Controls.Add(this.next_button3);
            this.third_panel.Controls.Add(this.history_textbox);
            this.third_panel.Controls.Add(this.history_label);
            this.third_panel.Controls.Add(this.filipino_textbox);
            this.third_panel.Controls.Add(this.filipino_label);
            this.third_panel.Controls.Add(this.science_textbox);
            this.third_panel.Controls.Add(this.science_label);
            this.third_panel.Controls.Add(this.math_textbox);
            this.third_panel.Controls.Add(this.math_label);
            this.third_panel.Controls.Add(this.english_textbox);
            this.third_panel.Controls.Add(this.english_label);
            this.third_panel.Controls.Add(this.grades_label);
            this.third_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.third_panel.Location = new System.Drawing.Point(0, 0);
            this.third_panel.Name = "third_panel";
            this.third_panel.Size = new System.Drawing.Size(334, 561);
            this.third_panel.TabIndex = 4;
            // 
            // fourth_panel
            // 
            this.fourth_panel.BackgroundImage = global::StudentGradeApplication.Properties.Resources.bg1;
            this.fourth_panel.Controls.Add(this.again_button);
            this.fourth_panel.Controls.Add(this.second_text_average);
            this.fourth_panel.Controls.Add(this.first_text_average);
            this.fourth_panel.Controls.Add(this.pass_or_fail);
            this.fourth_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourth_panel.Location = new System.Drawing.Point(0, 0);
            this.fourth_panel.Name = "fourth_panel";
            this.fourth_panel.Size = new System.Drawing.Size(334, 561);
            this.fourth_panel.TabIndex = 13;
            // 
            // again_button
            // 
            this.again_button.BackColor = System.Drawing.Color.Transparent;
            this.again_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.again_button.Image = global::StudentGradeApplication.Properties.Resources.again;
            this.again_button.Location = new System.Drawing.Point(75, 361);
            this.again_button.Name = "again_button";
            this.again_button.Size = new System.Drawing.Size(186, 85);
            this.again_button.TabIndex = 3;
            this.again_button.TabStop = false;
            this.again_button.Click += new System.EventHandler(this.again_button_Click);
            // 
            // second_text_average
            // 
            this.second_text_average.BackColor = System.Drawing.Color.Transparent;
            this.second_text_average.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_text_average.ForeColor = System.Drawing.Color.White;
            this.second_text_average.Location = new System.Drawing.Point(-1, 324);
            this.second_text_average.Name = "second_text_average";
            this.second_text_average.Size = new System.Drawing.Size(328, 23);
            this.second_text_average.TabIndex = 2;
            this.second_text_average.Text = "Paul Jolou Barrientos is 88.86";
            this.second_text_average.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // first_text_average
            // 
            this.first_text_average.BackColor = System.Drawing.Color.Transparent;
            this.first_text_average.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_text_average.ForeColor = System.Drawing.Color.White;
            this.first_text_average.Location = new System.Drawing.Point(3, 300);
            this.first_text_average.Name = "first_text_average";
            this.first_text_average.Size = new System.Drawing.Size(328, 23);
            this.first_text_average.TabIndex = 1;
            this.first_text_average.Text = "The general average of";
            this.first_text_average.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pass_or_fail
            // 
            this.pass_or_fail.BackColor = System.Drawing.Color.Transparent;
            this.pass_or_fail.Image = global::StudentGradeApplication.Properties.Resources.pass;
            this.pass_or_fail.Location = new System.Drawing.Point(5, 204);
            this.pass_or_fail.Name = "pass_or_fail";
            this.pass_or_fail.Size = new System.Drawing.Size(328, 71);
            this.pass_or_fail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pass_or_fail.TabIndex = 0;
            this.pass_or_fail.TabStop = false;
            // 
            // back_button2
            // 
            this.back_button2.BackColor = System.Drawing.Color.Transparent;
            this.back_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button2.Image = global::StudentGradeApplication.Properties.Resources.back;
            this.back_button2.Location = new System.Drawing.Point(3, 4);
            this.back_button2.Name = "back_button2";
            this.back_button2.Size = new System.Drawing.Size(67, 58);
            this.back_button2.TabIndex = 12;
            this.back_button2.TabStop = false;
            this.back_button2.Click += new System.EventHandler(this.back_button2_Click);
            // 
            // next_button3
            // 
            this.next_button3.BackColor = System.Drawing.Color.Transparent;
            this.next_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_button3.Image = global::StudentGradeApplication.Properties.Resources.NEXT;
            this.next_button3.Location = new System.Drawing.Point(68, 475);
            this.next_button3.Name = "next_button3";
            this.next_button3.Size = new System.Drawing.Size(179, 80);
            this.next_button3.TabIndex = 11;
            this.next_button3.TabStop = false;
            this.next_button3.Click += new System.EventHandler(this.next_button3_Click);
            // 
            // history_textbox
            // 
            this.history_textbox.BackColor = System.Drawing.Color.Transparent;
            this.history_textbox.BorderRadius = 18;
            this.history_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.history_textbox.DefaultText = "";
            this.history_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.history_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.history_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.history_textbox.DisabledState.Parent = this.history_textbox;
            this.history_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.history_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.history_textbox.FocusedState.Parent = this.history_textbox;
            this.history_textbox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.history_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.history_textbox.HoverState.Parent = this.history_textbox;
            this.history_textbox.Location = new System.Drawing.Point(52, 427);
            this.history_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.history_textbox.Name = "history_textbox";
            this.history_textbox.PasswordChar = '\0';
            this.history_textbox.PlaceholderText = "";
            this.history_textbox.SelectedText = "";
            this.history_textbox.ShadowDecoration.Parent = this.history_textbox;
            this.history_textbox.Size = new System.Drawing.Size(221, 38);
            this.history_textbox.TabIndex = 10;
            this.history_textbox.TextOffset = new System.Drawing.Point(10, 0);
            this.history_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.history_textbox_KeyPress);
            // 
            // history_label
            // 
            this.history_label.AutoSize = true;
            this.history_label.BackColor = System.Drawing.Color.Transparent;
            this.history_label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_label.ForeColor = System.Drawing.Color.White;
            this.history_label.Location = new System.Drawing.Point(52, 397);
            this.history_label.Name = "history_label";
            this.history_label.Size = new System.Drawing.Size(83, 25);
            this.history_label.TabIndex = 9;
            this.history_label.Text = "History";
            // 
            // filipino_textbox
            // 
            this.filipino_textbox.BackColor = System.Drawing.Color.Transparent;
            this.filipino_textbox.BorderRadius = 18;
            this.filipino_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filipino_textbox.DefaultText = "";
            this.filipino_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filipino_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filipino_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filipino_textbox.DisabledState.Parent = this.filipino_textbox;
            this.filipino_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filipino_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filipino_textbox.FocusedState.Parent = this.filipino_textbox;
            this.filipino_textbox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filipino_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.filipino_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filipino_textbox.HoverState.Parent = this.filipino_textbox;
            this.filipino_textbox.Location = new System.Drawing.Point(52, 352);
            this.filipino_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filipino_textbox.Name = "filipino_textbox";
            this.filipino_textbox.PasswordChar = '\0';
            this.filipino_textbox.PlaceholderText = "";
            this.filipino_textbox.SelectedText = "";
            this.filipino_textbox.ShadowDecoration.Parent = this.filipino_textbox;
            this.filipino_textbox.Size = new System.Drawing.Size(221, 38);
            this.filipino_textbox.TabIndex = 8;
            this.filipino_textbox.TextOffset = new System.Drawing.Point(10, 0);
            this.filipino_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filipino_textbox_KeyPress);
            // 
            // filipino_label
            // 
            this.filipino_label.AutoSize = true;
            this.filipino_label.BackColor = System.Drawing.Color.Transparent;
            this.filipino_label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filipino_label.ForeColor = System.Drawing.Color.White;
            this.filipino_label.Location = new System.Drawing.Point(52, 322);
            this.filipino_label.Name = "filipino_label";
            this.filipino_label.Size = new System.Drawing.Size(86, 25);
            this.filipino_label.TabIndex = 7;
            this.filipino_label.Text = "Filipino";
            // 
            // science_textbox
            // 
            this.science_textbox.BackColor = System.Drawing.Color.Transparent;
            this.science_textbox.BorderRadius = 18;
            this.science_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.science_textbox.DefaultText = "";
            this.science_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.science_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.science_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.science_textbox.DisabledState.Parent = this.science_textbox;
            this.science_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.science_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.science_textbox.FocusedState.Parent = this.science_textbox;
            this.science_textbox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.science_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.science_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.science_textbox.HoverState.Parent = this.science_textbox;
            this.science_textbox.Location = new System.Drawing.Point(52, 277);
            this.science_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.science_textbox.Name = "science_textbox";
            this.science_textbox.PasswordChar = '\0';
            this.science_textbox.PlaceholderText = "";
            this.science_textbox.SelectedText = "";
            this.science_textbox.ShadowDecoration.Parent = this.science_textbox;
            this.science_textbox.Size = new System.Drawing.Size(221, 38);
            this.science_textbox.TabIndex = 6;
            this.science_textbox.TextOffset = new System.Drawing.Point(10, 0);
            this.science_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.science_textbox_KeyPress);
            // 
            // science_label
            // 
            this.science_label.AutoSize = true;
            this.science_label.BackColor = System.Drawing.Color.Transparent;
            this.science_label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.science_label.ForeColor = System.Drawing.Color.White;
            this.science_label.Location = new System.Drawing.Point(52, 247);
            this.science_label.Name = "science_label";
            this.science_label.Size = new System.Drawing.Size(85, 25);
            this.science_label.TabIndex = 5;
            this.science_label.Text = "Science";
            // 
            // math_textbox
            // 
            this.math_textbox.BackColor = System.Drawing.Color.Transparent;
            this.math_textbox.BorderRadius = 18;
            this.math_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.math_textbox.DefaultText = "";
            this.math_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.math_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.math_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.math_textbox.DisabledState.Parent = this.math_textbox;
            this.math_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.math_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.math_textbox.FocusedState.Parent = this.math_textbox;
            this.math_textbox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.math_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.math_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.math_textbox.HoverState.Parent = this.math_textbox;
            this.math_textbox.Location = new System.Drawing.Point(52, 202);
            this.math_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.math_textbox.Name = "math_textbox";
            this.math_textbox.PasswordChar = '\0';
            this.math_textbox.PlaceholderText = "";
            this.math_textbox.SelectedText = "";
            this.math_textbox.ShadowDecoration.Parent = this.math_textbox;
            this.math_textbox.Size = new System.Drawing.Size(221, 38);
            this.math_textbox.TabIndex = 4;
            this.math_textbox.TextOffset = new System.Drawing.Point(10, 0);
            this.math_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.math_textbox_KeyPress);
            // 
            // math_label
            // 
            this.math_label.AutoSize = true;
            this.math_label.BackColor = System.Drawing.Color.Transparent;
            this.math_label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.math_label.ForeColor = System.Drawing.Color.White;
            this.math_label.Location = new System.Drawing.Point(53, 172);
            this.math_label.Name = "math_label";
            this.math_label.Size = new System.Drawing.Size(64, 25);
            this.math_label.TabIndex = 3;
            this.math_label.Text = "Math";
            // 
            // english_textbox
            // 
            this.english_textbox.BackColor = System.Drawing.Color.Transparent;
            this.english_textbox.BorderRadius = 18;
            this.english_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.english_textbox.DefaultText = "";
            this.english_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.english_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.english_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.english_textbox.DisabledState.Parent = this.english_textbox;
            this.english_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.english_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.english_textbox.FocusedState.Parent = this.english_textbox;
            this.english_textbox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.english_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.english_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.english_textbox.HoverState.Parent = this.english_textbox;
            this.english_textbox.Location = new System.Drawing.Point(52, 127);
            this.english_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.english_textbox.Name = "english_textbox";
            this.english_textbox.PasswordChar = '\0';
            this.english_textbox.PlaceholderText = "";
            this.english_textbox.SelectedText = "";
            this.english_textbox.ShadowDecoration.Parent = this.english_textbox;
            this.english_textbox.Size = new System.Drawing.Size(221, 38);
            this.english_textbox.TabIndex = 2;
            this.english_textbox.TextOffset = new System.Drawing.Point(10, 0);
            this.english_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.english_textbox_KeyPress);
            // 
            // english_label
            // 
            this.english_label.AutoSize = true;
            this.english_label.BackColor = System.Drawing.Color.Transparent;
            this.english_label.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.english_label.ForeColor = System.Drawing.Color.White;
            this.english_label.Location = new System.Drawing.Point(52, 97);
            this.english_label.Name = "english_label";
            this.english_label.Size = new System.Drawing.Size(83, 25);
            this.english_label.TabIndex = 1;
            this.english_label.Text = "English";
            // 
            // grades_label
            // 
            this.grades_label.BackColor = System.Drawing.Color.Transparent;
            this.grades_label.Image = global::StudentGradeApplication.Properties.Resources.grades;
            this.grades_label.Location = new System.Drawing.Point(57, 26);
            this.grades_label.Name = "grades_label";
            this.grades_label.Size = new System.Drawing.Size(221, 82);
            this.grades_label.TabIndex = 0;
            this.grades_label.TabStop = false;
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
            this.next_button2.Click += new System.EventHandler(this.next_button2_Click);
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
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
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
            this.next_button1.Click += new System.EventHandler(this.next_button1_Click);
            // 
            // welcome_screen
            // 
            this.welcome_screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome_screen.Image = global::StudentGradeApplication.Properties.Resources.opening2;
            this.welcome_screen.Location = new System.Drawing.Point(0, 0);
            this.welcome_screen.Name = "welcome_screen";
            this.welcome_screen.Size = new System.Drawing.Size(334, 561);
            this.welcome_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.welcome_screen.TabIndex = 0;
            this.welcome_screen.TabStop = false;
            // 
            // StudentGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.first_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "StudentGradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Application";
            this.first_panel.ResumeLayout(false);
            this.first_panel.PerformLayout();
            this.second_panel.ResumeLayout(false);
            this.third_panel.ResumeLayout(false);
            this.third_panel.PerformLayout();
            this.fourth_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.again_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pass_or_fail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grades_label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.welcome_screen)).EndInit();
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
        private System.Windows.Forms.Panel third_panel;
        private Guna.UI2.WinForms.Guna2TextBox english_textbox;
        private System.Windows.Forms.Label english_label;
        private System.Windows.Forms.PictureBox grades_label;
        private Guna.UI2.WinForms.Guna2TextBox history_textbox;
        private System.Windows.Forms.Label history_label;
        private Guna.UI2.WinForms.Guna2TextBox filipino_textbox;
        private System.Windows.Forms.Label filipino_label;
        private Guna.UI2.WinForms.Guna2TextBox science_textbox;
        private System.Windows.Forms.Label science_label;
        private Guna.UI2.WinForms.Guna2TextBox math_textbox;
        private System.Windows.Forms.Label math_label;
        private System.Windows.Forms.PictureBox next_button3;
        private System.Windows.Forms.PictureBox back_button2;
        private System.Windows.Forms.Panel fourth_panel;
        private System.Windows.Forms.PictureBox again_button;
        private System.Windows.Forms.Label second_text_average;
        private System.Windows.Forms.Label first_text_average;
        private System.Windows.Forms.PictureBox pass_or_fail;
    }
}


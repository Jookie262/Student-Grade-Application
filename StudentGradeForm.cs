﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class StudentGradeForm : Form
    {
        // Initialize Needed Variables
        string name;
        double english, math, science, filipino, history;

        public StudentGradeForm()
        {
            InitializeComponent();
            showPanel(1);
        }

        // Hide All Panel
        public void hideAllPanel()
        {
            first_panel.Hide();
            second_panel.Hide();
            third_panel.Hide();
            fourth_panel.Hide();
        }

        // Settings for the Panel to make it visible when called
        public void settingsForPanel(Panel panel)
        {
            panel.Parent = this;
            panel.Visible = true;
        } 

        // Method of showing a specific panel
        public void showPanel(int num)
        {
            switch (num)
            {
                case 1:
                    hideAllPanel();
                    settingsForPanel(first_panel);
                    break;
                case 2:
                    hideAllPanel();
                    settingsForPanel(second_panel);
                    break;
                case 3:
                    hideAllPanel();
                    settingsForPanel(third_panel);
                    break;
                case 4:
                    hideAllPanel();
                    settingsForPanel(fourth_panel);
                    break;
            }
        }

        // Accepts Only Number and One Dot (For Inputting Grades) 
        public void gradeValidationTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar);
            if ((e.KeyChar == '.') && ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        // Return the average of the 5 subjects
        public double getAverage()
        {
            return (english + math + science + filipino + history) / 5;
        }

        // Return the name plus the average
        public string nameAverage()
        {
            return name + " is " + getAverage(); 
        }

        // Check is the student passed or not, then change the image
        public void passOrFail()
        {
            if (getAverage() >= 75.00)
            {
                pass_or_fail.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\" + "assets\\pass.png");
            }
            else
            {
                pass_or_fail.Image = Image.FromFile(System.Environment.CurrentDirectory + "\\" + "assets\\failed.png");
            }

            second_text_average.Text = nameAverage();
        }

        // This removes the text inside the textbox and return them to default
        public void backToDefault()
        {
            english_textbox.Text = null;
            math_textbox.Text = null;
            science_textbox.Text = null;
            filipino_textbox.Text = null;
            history_textbox.Text = null;
            name_textbox.Text = null;
        }

        private void next_button1_Click(object sender, EventArgs e)
        {
            showPanel(2);
        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            showPanel(1);
        }

        private void next_button2_Click(object sender, EventArgs e)
        {
            name = name_textbox.Text;
            showPanel(3);
        }

        private void next_button3_Click(object sender, EventArgs e)
        {
            // Get the value of each subject
            english = String.IsNullOrEmpty(english_textbox.Text) ? 0 : Double.Parse(english_textbox.Text);
            math = String.IsNullOrEmpty(math_textbox.Text) ? 0 : Double.Parse(math_textbox.Text);
            science = String.IsNullOrEmpty(science_textbox.Text) ? 0 : Double.Parse(science_textbox.Text);
            filipino = String.IsNullOrEmpty(filipino_textbox.Text) ? 0 : Double.Parse(filipino_textbox.Text);
            history = String.IsNullOrEmpty(history_textbox.Text) ? 0 : Double.Parse(history_textbox.Text);
            passOrFail();
            showPanel(4); 
        }

        private void again_button_Click(object sender, EventArgs e)
        {
            backToDefault();
            showPanel(1);
        }

        private void back_button2_Click(object sender, EventArgs e)
        {
            showPanel(2);
        }

        private void english_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            gradeValidationTextBox(sender, e);
        }

        private void filipino_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            gradeValidationTextBox(sender, e);
        }

        private void history_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            gradeValidationTextBox(sender, e);
        }

        private void math_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            gradeValidationTextBox(sender, e);
        }

        private void science_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            gradeValidationTextBox(sender, e);
        }
    }
}

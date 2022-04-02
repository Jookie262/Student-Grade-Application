using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class StudentGradeForm : Form
    {
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
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
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
    }
}

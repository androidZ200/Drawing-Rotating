using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Rotating
{
    public partial class FormSettings : Form
    {
        SystemCircle systemCircle;
        FormMain form;
        Circle currentCircle = null;

        private void UpdateCircles()
        {
            if(currentCircle == null)
            {
                DeleteButton.Enabled = SaveButton.Enabled = false;
                RadiusTextBox.Enabled = AngleTextBox.Enabled = SpeedTextBox.Enabled = false;
                RadiusTextBox.Text = AngleTextBox.Text = SpeedTextBox.Text = "";
            }
            else
            {
                DeleteButton.Enabled = SaveButton.Enabled = true;
                RadiusTextBox.Enabled = AngleTextBox.Enabled = SpeedTextBox.Enabled = true;
                RadiusTextBox.Text = currentCircle.Radius.ToString();
                AngleTextBox.Text = currentCircle.StartAngle.ToString();
                SpeedTextBox.Text = currentCircle.SpeedAngle.ToString();
            }
        }
        private void UpdateComboBox()
        {
            comboBox.Items.Clear();
            for (int i = 0; i < systemCircle.Count; i++)
                comboBox.Items.Add("Circle " + (i + 1));
            if (systemCircle.Count > 0)
            {
                comboBox.SelectedIndex = 0;
                currentCircle = systemCircle.GetCircle(0);
            }
            else currentCircle = null;
            UpdateCircles();
        }

        public FormSettings(SystemCircle circles, FormMain form)
        {
            InitializeComponent();
            comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            systemCircle = circles;
            this.form = form;
            UpdateComboBox();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            systemCircle.AddCircle(new Circle(1, 0, 0));
            comboBox.Items.Add("Circle " + systemCircle.Count);
            comboBox.SelectedIndex = systemCircle.Count - 1;
            currentCircle = systemCircle.GetCircle(systemCircle.Count - 1);
            UpdateCircles();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            systemCircle.RemoveCircle(systemCircle.GetCircle(comboBox.SelectedIndex));
            UpdateComboBox();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentCircle.Radius = (float)Convert.ToDouble(RadiusTextBox.Text);
                currentCircle.CurrentAngle = currentCircle.StartAngle = (float)Convert.ToDouble(AngleTextBox.Text);
                currentCircle.SpeedAngle = (float)Convert.ToDouble(SpeedTextBox.Text);
                systemCircle.CheckSlow();
                form.UpdatePicture();
            }
            catch
            {
                MessageBox.Show("Not the right data");
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCircle = systemCircle.GetCircle(comboBox.SelectedIndex);
            UpdateCircles();
        }
    }
}

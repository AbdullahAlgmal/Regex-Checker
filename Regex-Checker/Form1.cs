using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btCheck_Click(object sender, EventArgs e)
        {
            if(!Check(tbRegex.Text)) MessageBox.Show("InValid Pattern.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show(Regex.IsMatch(tbInput.Text, tbRegex.Text).ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            bool IsValid = Check(tbRegex.Text.ToString());
            if(IsValid) tbRegex.ForeColor = Color.Green;
            else if(!IsValid) tbRegex.ForeColor = Color.Red;

            if (tbInput.Focused && tbRegex.Text == "Write Your Pattern...") tbRegex.ForeColor = Color.LightGray;
        }
        private bool Check(string Pattern)
        {
            try
            {
                Regex.Match("", Pattern);
                return true;
            }
            catch(ArgumentException)
            {
                return false;
            }
        }
        private void tb_Enter(object sender, EventArgs e)
        {
            if (tbRegex.Focused && tbRegex.Text == "Write Your Pattern...") tbRegex.Text = "";
            else if (tbInput.Focused && (tbInput.Text == "Write Your Text..." || tbInput.Text == "")) { tbInput.Text = ""; tbInput.ForeColor = Color.Navy; }
        }
        private void tb_Leave(object sender, EventArgs e)
        {
            if (tbInput.Focused && tbRegex.Text == "") tbRegex.Text = "Write Your Pattern...";
            else if (tbRegex.Focused && tbInput.Text == "") { tbInput.Text = "Write Your Text..."; tbInput.ForeColor = Color.LightGray; }
        }
        private void btClear_Click(object sender, EventArgs e)
        {
            tbRegex.Text = "";
            tbInput.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_country_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_country.Text) == false)
            {
                list_country.Sorted = true;
                list_country.Items.Add(txtbox_country.Text);
                txtbox_country.Clear();
                txtbox_country.Focus();
                list_country.SelectedIndex = list_country.Items.Count - 1;
                
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string msg = "Harus pilih satu row";
            if (list_country.SelectedIndex >= 0)
                list_country.Items.RemoveAt(list_country.SelectedIndex);
            else
                MessageBox.Show(msg);
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            int count = list_country.Items.Count;
            string msg = "Number of Items: " + count;
            MessageBox.Show(msg);
        }

        private void list_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_select.Text = list_country.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string msg_clear = "Are you SURE you want to clear?";
            if(MessageBox.Show(msg_clear, "SURE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                list_country.Items.Clear();
                lbl_select.Text = "?";
                MessageBox.Show("LIST BOX SUDAH DI CLEAR", "SURE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("TIDAK JADI DI CLEAR", "SURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cmb_games_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_dropchoose.Text = cmb_games.Text;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbl_dropchoose2.Text = cmb_games2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_country.Sorted = true;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            int index = list_country.SelectedIndex;
            string listBoxItemText = list_country.SelectedItem.ToString();
            if(index > 0)
            {
                list_country.Items.RemoveAt(index);
                list_country.Items.Insert(index - 1, listBoxItemText);
                list_country.SetSelected(index - 1, true);
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            int index = list_country.SelectedIndex;
            string listBoxItemText = list_country.SelectedItem.ToString();
            if (index < list_country.Items.Count - 1)
            {
                list_country.Items.RemoveAt(index);
                list_country.Items.Insert(index + 1, listBoxItemText);
                list_country.SetSelected(index + 1, true);
            }
        }
    }
}

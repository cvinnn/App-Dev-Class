using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_ca_test
{
    public partial class Form1 : Form {

        private List<Country> countries = new List<Country>();

        public Form1() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if(!string.IsNullOrEmpty(txtCountry.Text) && !string.IsNullOrEmpty(txtCity.Text) && 
                !string.IsNullOrEmpty(txtPop.Text)) {
                bool found = false;
                foreach(Country country in countries) {
                    if(country.country.ToUpper() == txtCountry.Text.ToUpper()) {
                        if(country.city.ToUpper() == txtCity.Text.ToUpper()) {
                            found = true;
                            break;
                        }
                    }
                }
                if(found == false) {
                    countries.Add(new Country
                    {
                        country = txtCountry.Text,
                        city = txtCity.Text,
                        population = Convert.ToInt32(txtPop.Text)
                    });
                    if (!cmbCountry.Items.Contains(txtCountry.Text))
                        cmbCountry.Items.Add(txtCountry.Text);
                    updateListCountry();
                    updateListCity();
                } else {
                    MessageBox.Show("Country and City is found", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                txtCountry.Clear();
                txtCity.Clear();
                txtPop.Clear();
                txtCountry.Focus();
            } else {
                MessageBox.Show("All Fields must be fiiled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCountry_SelectionChangeCommitted(object sender, EventArgs e) {
            string chosenCountry = cmbCountry.SelectedItem.ToString();
            updateListData(chosenCountry);
        }

        private void btnClearCmbCountry_Click(object sender, EventArgs e) {
            string msg = "Are you sure you want to clear Combo Box Countries?";
            if(MessageBox.Show(msg, "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) ==
                DialogResult.OK) {
                countries.Clear();
                cmbCountry.Items.Clear();
                updateCmbBox();
                updateListCity();
                if(cmbCountry.SelectedItem == null) {
                    listData.Items.Clear();
                }else {
                    updateListData(cmbCountry.SelectedItem.ToString());
                }
                updateListCountry();
            } else {
                string msg2 = "Combo Box is not Cleared";
                MessageBox.Show(msg2, "Cancel Clear", MessageBoxButtons.OK);
            }
        }

        private void updateListData(string chosenCountry) {
            listData.Items.Clear();
            foreach (Country country in countries) {
                if (country.country == chosenCountry) {
                    listData.Items.Add($"Country: {country.country}");
                    listData.Items.Add($"City: {country.city}");
                    listData.Items.Add($"Population: {country.population}");
                }
            }
        }

        private void updateCmbBox() {
            foreach (Country country in this.countries) {
                if (!cmbCountry.Items.Contains(country.country))
                    cmbCountry.Items.Add(country.country);
            }
        }

        private void updateListCountry() {
            listCountry.Items.Clear();
            foreach (Country country in this.countries) {
                if (!listCountry.Items.Contains(country.country))
                    listCountry.Items.Add(country.country);
            }
        }

        private void updateListCity() {
            listCity.Items.Clear();
            foreach (Country country in this.countries) {
                if (!listCity.Items.Contains(country.country))
                    listCity.Items.Add($"{country.city},{country.country}");
            }
        }

        private bool deleteCountry(string delCountry) {
            foreach (Country country in this.countries) {
                if (country.country == delCountry) {
                    countries.Remove(country);
                    return true;
                }
            }
            return false;
        }
        private bool deleteCity(string delCity, string delCountry) {
            foreach (Country country in this.countries) {
                if (country.city == delCity && country.country == delCountry) {
                    countries.Remove(country);
                    return true;
                }
            }
            return false;
        }

        private void btnDelCountry_Click(object sender, EventArgs e) {
            if (listCountry.SelectedItem != null) {
                string delCountry = listCountry.SelectedItem.ToString();
                bool found = true;

                while (found) {
                    found = deleteCountry(delCountry);
                }
                cmbCountry.Items.Clear();
                updateCmbBox();
                updateListCity();
                updateListCountry();
                listData.Items.Clear();
            }
        }

        private void btnDelCity_Click(object sender, EventArgs e) {
            if (listCity.SelectedItem != null) {
                string[] delCity = listCity.SelectedItem.ToString().Split(',');
                bool found = deleteCity(delCity[0], delCity[1]);
                updateCmbBox();
                updateListCity();
                updateListCountry();
                if (cmbCountry.SelectedItem == null) {
                    listData.Items.Clear();
                } else {
                    updateListData(cmbCountry.SelectedItem.ToString());
                }
            }
        }
    }
}

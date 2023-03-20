namespace W4_ca_test
{
    partial class Form1
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
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPop = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPop = new System.Windows.Forms.TextBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.listData = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDelCountry = new System.Windows.Forms.Label();
            this.listCountry = new System.Windows.Forms.ListBox();
            this.lblDelCity = new System.Windows.Forms.Label();
            this.listCity = new System.Windows.Forms.ListBox();
            this.btnDelCountry = new System.Windows.Forms.Button();
            this.btnDelCity = new System.Windows.Forms.Button();
            this.btnClearCmbCountry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(34, 36);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 16);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(34, 70);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(32, 16);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // lblPop
            // 
            this.lblPop.AutoSize = true;
            this.lblPop.Location = new System.Drawing.Point(34, 104);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(74, 16);
            this.lblPop.TabIndex = 2;
            this.lblPop.Text = "Population:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(118, 35);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(155, 22);
            this.txtCountry.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 69);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(155, 22);
            this.txtCity.TabIndex = 4;
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(118, 103);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(155, 22);
            this.txtPop.TabIndex = 5;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(37, 163);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(54, 16);
            this.lblChoose.TabIndex = 6;
            this.lblChoose.Text = "Choose";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(118, 162);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(155, 24);
            this.cmbCountry.TabIndex = 7;
            this.cmbCountry.SelectionChangeCommitted += new System.EventHandler(this.cmbCountry_SelectionChangeCommitted);
            // 
            // listData
            // 
            this.listData.FormattingEnabled = true;
            this.listData.ItemHeight = 16;
            this.listData.Location = new System.Drawing.Point(40, 218);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(400, 180);
            this.listData.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(310, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDelCountry
            // 
            this.lblDelCountry.AutoSize = true;
            this.lblDelCountry.Location = new System.Drawing.Point(522, 35);
            this.lblDelCountry.Name = "lblDelCountry";
            this.lblDelCountry.Size = new System.Drawing.Size(78, 16);
            this.lblDelCountry.TabIndex = 13;
            this.lblDelCountry.Text = "Country List:";
            // 
            // listCountry
            // 
            this.listCountry.FormattingEnabled = true;
            this.listCountry.ItemHeight = 16;
            this.listCountry.Location = new System.Drawing.Point(619, 36);
            this.listCountry.Name = "listCountry";
            this.listCountry.Size = new System.Drawing.Size(129, 100);
            this.listCountry.TabIndex = 14;
            // 
            // lblDelCity
            // 
            this.lblDelCity.AutoSize = true;
            this.lblDelCity.Location = new System.Drawing.Point(522, 163);
            this.lblDelCity.Name = "lblDelCity";
            this.lblDelCity.Size = new System.Drawing.Size(55, 16);
            this.lblDelCity.TabIndex = 15;
            this.lblDelCity.Text = "City List:";
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.ItemHeight = 16;
            this.listCity.Location = new System.Drawing.Point(619, 162);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(129, 100);
            this.listCity.TabIndex = 16;
            // 
            // btnDelCountry
            // 
            this.btnDelCountry.Location = new System.Drawing.Point(754, 36);
            this.btnDelCountry.Name = "btnDelCountry";
            this.btnDelCountry.Size = new System.Drawing.Size(121, 23);
            this.btnDelCountry.TabIndex = 17;
            this.btnDelCountry.Text = "Delete Country";
            this.btnDelCountry.UseVisualStyleBackColor = true;
            this.btnDelCountry.Click += new System.EventHandler(this.btnDelCountry_Click);
            // 
            // btnDelCity
            // 
            this.btnDelCity.Location = new System.Drawing.Point(754, 163);
            this.btnDelCity.Name = "btnDelCity";
            this.btnDelCity.Size = new System.Drawing.Size(121, 23);
            this.btnDelCity.TabIndex = 18;
            this.btnDelCity.Text = "Delete City";
            this.btnDelCity.UseVisualStyleBackColor = true;
            this.btnDelCity.Click += new System.EventHandler(this.btnDelCity_Click);
            // 
            // btnClearCmbCountry
            // 
            this.btnClearCmbCountry.Location = new System.Drawing.Point(310, 163);
            this.btnClearCmbCountry.Name = "btnClearCmbCountry";
            this.btnClearCmbCountry.Size = new System.Drawing.Size(130, 23);
            this.btnClearCmbCountry.TabIndex = 11;
            this.btnClearCmbCountry.Text = "Clear ComboBox";
            this.btnClearCmbCountry.UseVisualStyleBackColor = true;
            this.btnClearCmbCountry.Click += new System.EventHandler(this.btnClearCmbCountry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 532);
            this.Controls.Add(this.btnDelCity);
            this.Controls.Add(this.btnDelCountry);
            this.Controls.Add(this.listCity);
            this.Controls.Add(this.lblDelCity);
            this.Controls.Add(this.listCountry);
            this.Controls.Add(this.lblDelCountry);
            this.Controls.Add(this.btnClearCmbCountry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblPop);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPop;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPop;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ListBox listData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDelCountry;
        private System.Windows.Forms.ListBox listCountry;
        private System.Windows.Forms.Label lblDelCity;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.Button btnDelCountry;
        private System.Windows.Forms.Button btnDelCity;
        private System.Windows.Forms.Button btnClearCmbCountry;
    }
}


namespace ListBoxComboBox
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
            this.list_country = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_country = new System.Windows.Forms.Label();
            this.txtbox_country = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.lbl_select = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_games = new System.Windows.Forms.ComboBox();
            this.lbl_dropchoose = new System.Windows.Forms.Label();
            this.cmb_games2 = new System.Windows.Forms.ComboBox();
            this.lbl_dropchoose2 = new System.Windows.Forms.Label();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_country
            // 
            this.list_country.FormattingEnabled = true;
            this.list_country.Items.AddRange(new object[] {
            "America",
            "Malaysia",
            "Indonesia",
            "Singapore",
            "England"});
            this.list_country.Location = new System.Drawing.Point(468, 38);
            this.list_country.Name = "list_country";
            this.list_country.Size = new System.Drawing.Size(179, 160);
            this.list_country.TabIndex = 0;
            this.list_country.SelectedIndexChanged += new System.EventHandler(this.list_country_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(351, 33);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(75, 35);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(46, 13);
            this.lbl_country.TabIndex = 2;
            this.lbl_country.Text = "Country:";
            this.lbl_country.Click += new System.EventHandler(this.lbl_country_Click);
            // 
            // txtbox_country
            // 
            this.txtbox_country.Location = new System.Drawing.Point(127, 35);
            this.txtbox_country.Name = "txtbox_country";
            this.txtbox_country.Size = new System.Drawing.Size(218, 20);
            this.txtbox_country.TabIndex = 3;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(351, 62);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(351, 91);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(75, 23);
            this.btn_count.TabIndex = 5;
            this.btn_count.Text = "Count";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // lbl_selected
            // 
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.Location = new System.Drawing.Point(465, 217);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(55, 13);
            this.lbl_selected.TabIndex = 6;
            this.lbl_selected.Text = "Selected: ";
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Location = new System.Drawing.Point(526, 217);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(13, 13);
            this.lbl_select.TabIndex = 7;
            this.lbl_select.Text = "?";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(351, 121);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cmb_games
            // 
            this.cmb_games.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_games.FormattingEnabled = true;
            this.cmb_games.Items.AddRange(new object[] {
            "Valorant",
            "Apex Legends",
            "League of Legends",
            "Dota2",
            "Ragnarok Online",
            "RF Online"});
            this.cmb_games.Location = new System.Drawing.Point(468, 258);
            this.cmb_games.Name = "cmb_games";
            this.cmb_games.Size = new System.Drawing.Size(179, 21);
            this.cmb_games.TabIndex = 9;
            this.cmb_games.SelectedIndexChanged += new System.EventHandler(this.cmb_games_SelectedIndexChanged);
            // 
            // lbl_dropchoose
            // 
            this.lbl_dropchoose.AutoSize = true;
            this.lbl_dropchoose.Location = new System.Drawing.Point(653, 261);
            this.lbl_dropchoose.Name = "lbl_dropchoose";
            this.lbl_dropchoose.Size = new System.Drawing.Size(13, 13);
            this.lbl_dropchoose.TabIndex = 10;
            this.lbl_dropchoose.Text = "?";
            // 
            // cmb_games2
            // 
            this.cmb_games2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_games2.FormattingEnabled = true;
            this.cmb_games2.Items.AddRange(new object[] {
            "Valorant",
            "Apex Legends",
            "League of Legends",
            "Dota2",
            "Ragnarok Online",
            "RF Online"});
            this.cmb_games2.Location = new System.Drawing.Point(468, 320);
            this.cmb_games2.Name = "cmb_games2";
            this.cmb_games2.Size = new System.Drawing.Size(179, 21);
            this.cmb_games2.TabIndex = 11;
            this.cmb_games2.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // lbl_dropchoose2
            // 
            this.lbl_dropchoose2.AutoSize = true;
            this.lbl_dropchoose2.Location = new System.Drawing.Point(653, 328);
            this.lbl_dropchoose2.Name = "lbl_dropchoose2";
            this.lbl_dropchoose2.Size = new System.Drawing.Size(13, 13);
            this.lbl_dropchoose2.TabIndex = 12;
            this.lbl_dropchoose2.Text = "?";
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(656, 92);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(50, 23);
            this.btn_up.TabIndex = 13;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(656, 121);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(50, 23);
            this.btn_down.TabIndex = 14;
            this.btn_down.Text = "Down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.lbl_dropchoose2);
            this.Controls.Add(this.cmb_games2);
            this.Controls.Add(this.lbl_dropchoose);
            this.Controls.Add(this.cmb_games);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_select);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txtbox_country);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_country);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_country;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.TextBox txtbox_country;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Label lbl_selected;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_games;
        private System.Windows.Forms.Label lbl_dropchoose;
        private System.Windows.Forms.ComboBox cmb_games2;
        private System.Windows.Forms.Label lbl_dropchoose2;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
    }
}


namespace Project_Orcpub_Phoenix
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboxRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboxClass = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // cboxRace
            // 
            this.cboxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRace.FormattingEnabled = true;
            this.cboxRace.Items.AddRange(new object[] {
            "Dragon Born",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Half Orc",
            "Halfling",
            "Human",
            "Tiefling"});
            this.cboxRace.Location = new System.Drawing.Point(69, 65);
            this.cboxRace.Name = "cboxRace";
            this.cboxRace.Size = new System.Drawing.Size(189, 21);
            this.cboxRace.TabIndex = 3;
            this.cboxRace.SelectedIndexChanged += new System.EventHandler(this.cboxRace_SelectedIndexChanged);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(12, 65);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 4;
            this.lblRace.Text = "Race";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(13, 101);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Class";
            // 
            // cboxClass
            // 
            this.cboxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxClass.FormattingEnabled = true;
            this.cboxClass.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.cboxClass.Location = new System.Drawing.Point(69, 98);
            this.cboxClass.Name = "cboxClass";
            this.cboxClass.Size = new System.Drawing.Size(189, 21);
            this.cboxClass.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(99, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cboxClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.cboxRace);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboxRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboxClass;
        private System.Windows.Forms.Button btnClear;
    }
}


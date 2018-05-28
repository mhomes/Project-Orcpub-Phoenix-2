namespace Project_Orcpub_Phoenix
{
    partial class ASI
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblCha = new System.Windows.Forms.Label();
            this.nudStr = new System.Windows.Forms.NumericUpDown();
            this.nudDex = new System.Windows.Forms.NumericUpDown();
            this.nudCon = new System.Windows.Forms.NumericUpDown();
            this.nudInt = new System.Windows.Forms.NumericUpDown();
            this.nudWis = new System.Windows.Forms.NumericUpDown();
            this.nudCha = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 251);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(174, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(336, 251);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(21, 28);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(47, 13);
            this.lblStr.TabIndex = 5;
            this.lblStr.Text = "Strength";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(24, 60);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(48, 13);
            this.lblDex.TabIndex = 6;
            this.lblDex.Text = "Dexterity";
            this.lblDex.Click += new System.EventHandler(this.lblDex_Click);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(24, 92);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(62, 13);
            this.lblCon.TabIndex = 7;
            this.lblCon.Text = "Constitution";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(21, 125);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(61, 13);
            this.lblInt.TabIndex = 8;
            this.lblInt.Text = "Intelligence";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(21, 160);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(45, 13);
            this.lblWis.TabIndex = 9;
            this.lblWis.Text = "Wisdom";
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(21, 195);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(50, 13);
            this.lblCha.TabIndex = 10;
            this.lblCha.Text = "Charisma";
            // 
            // nudStr
            // 
            this.nudStr.Location = new System.Drawing.Point(183, 21);
            this.nudStr.Name = "nudStr";
            this.nudStr.Size = new System.Drawing.Size(120, 20);
            this.nudStr.TabIndex = 11;
            this.nudStr.ValueChanged += new System.EventHandler(this.nudStr_ValueChanged);
            // 
            // nudDex
            // 
            this.nudDex.Location = new System.Drawing.Point(183, 53);
            this.nudDex.Name = "nudDex";
            this.nudDex.Size = new System.Drawing.Size(120, 20);
            this.nudDex.TabIndex = 12;
            this.nudDex.ValueChanged += new System.EventHandler(this.nudDex_ValueChanged);
            // 
            // nudCon
            // 
            this.nudCon.Location = new System.Drawing.Point(183, 90);
            this.nudCon.Name = "nudCon";
            this.nudCon.Size = new System.Drawing.Size(120, 20);
            this.nudCon.TabIndex = 13;
            this.nudCon.ValueChanged += new System.EventHandler(this.nudCon_ValueChanged);
            // 
            // nudInt
            // 
            this.nudInt.Location = new System.Drawing.Point(183, 118);
            this.nudInt.Name = "nudInt";
            this.nudInt.Size = new System.Drawing.Size(120, 20);
            this.nudInt.TabIndex = 14;
            this.nudInt.ValueChanged += new System.EventHandler(this.nudInt_ValueChanged);
            // 
            // nudWis
            // 
            this.nudWis.Location = new System.Drawing.Point(183, 153);
            this.nudWis.Name = "nudWis";
            this.nudWis.Size = new System.Drawing.Size(120, 20);
            this.nudWis.TabIndex = 15;
            this.nudWis.ValueChanged += new System.EventHandler(this.nudWis_ValueChanged);
            // 
            // nudCha
            // 
            this.nudCha.Location = new System.Drawing.Point(183, 188);
            this.nudCha.Name = "nudCha";
            this.nudCha.Size = new System.Drawing.Size(120, 20);
            this.nudCha.TabIndex = 16;
            this.nudCha.ValueChanged += new System.EventHandler(this.nudCha_ValueChanged);
            // 
            // ASI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 286);
            this.Controls.Add(this.nudCha);
            this.Controls.Add(this.nudWis);
            this.Controls.Add(this.nudInt);
            this.Controls.Add(this.nudCon);
            this.Controls.Add(this.nudDex);
            this.Controls.Add(this.nudStr);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Name = "ASI";
            this.Text = "Ability Score Index";
            ((System.ComponentModel.ISupportInitialize)(this.nudStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.NumericUpDown nudStr;
        private System.Windows.Forms.NumericUpDown nudDex;
        private System.Windows.Forms.NumericUpDown nudCon;
        private System.Windows.Forms.NumericUpDown nudInt;
        private System.Windows.Forms.NumericUpDown nudWis;
        private System.Windows.Forms.NumericUpDown nudCha;
    }
}
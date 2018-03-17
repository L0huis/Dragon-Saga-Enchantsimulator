namespace Soulcraft_Enchant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.doSoulcraft = new System.Windows.Forms.CheckBox();
            this.doEnchanting = new System.Windows.Forms.CheckBox();
            this.risNeeded = new System.Windows.Forms.Label();
            this.isNeeded = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chanceIncrease = new System.Windows.Forms.TextBox();
            this.labelChanceIncrease = new System.Windows.Forms.Label();
            this.hasEWBuff = new System.Windows.Forms.CheckBox();
            this.labelEmporiaBuff = new System.Windows.Forms.Label();
            this.toELvl = new System.Windows.Forms.NumericUpDown();
            this.labelTo = new System.Windows.Forms.Label();
            this.fromELvl = new System.Windows.Forms.NumericUpDown();
            this.labelFrom = new System.Windows.Forms.Label();
            this.weapOrArmor = new System.Windows.Forms.ComboBox();
            this.labelItemToEnchant = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toELvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromELvl)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(400, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(466, 242);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.doSoulcraft);
            this.tabPage1.Controls.Add(this.doEnchanting);
            this.tabPage1.Controls.Add(this.risNeeded);
            this.tabPage1.Controls.Add(this.isNeeded);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.chanceIncrease);
            this.tabPage1.Controls.Add(this.labelChanceIncrease);
            this.tabPage1.Controls.Add(this.hasEWBuff);
            this.tabPage1.Controls.Add(this.labelEmporiaBuff);
            this.tabPage1.Controls.Add(this.toELvl);
            this.tabPage1.Controls.Add(this.labelTo);
            this.tabPage1.Controls.Add(this.fromELvl);
            this.tabPage1.Controls.Add(this.labelFrom);
            this.tabPage1.Controls.Add(this.weapOrArmor);
            this.tabPage1.Controls.Add(this.labelItemToEnchant);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crafting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // doSoulcraft
            // 
            this.doSoulcraft.AutoSize = true;
            this.doSoulcraft.Checked = true;
            this.doSoulcraft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doSoulcraft.Location = new System.Drawing.Point(212, 52);
            this.doSoulcraft.Name = "doSoulcraft";
            this.doSoulcraft.Size = new System.Drawing.Size(82, 17);
            this.doSoulcraft.TabIndex = 18;
            this.doSoulcraft.Text = "Soulcrafting";
            this.doSoulcraft.UseVisualStyleBackColor = true;
            // 
            // doEnchanting
            // 
            this.doEnchanting.AutoSize = true;
            this.doEnchanting.Checked = true;
            this.doEnchanting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.doEnchanting.Location = new System.Drawing.Point(9, 52);
            this.doEnchanting.Name = "doEnchanting";
            this.doEnchanting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.doEnchanting.Size = new System.Drawing.Size(80, 17);
            this.doEnchanting.TabIndex = 17;
            this.doEnchanting.Text = "Enchanting";
            this.doEnchanting.UseVisualStyleBackColor = true;
            this.doEnchanting.CheckedChanged += new System.EventHandler(this.doEnchanting_CheckedChanged);
            // 
            // risNeeded
            // 
            this.risNeeded.AutoSize = true;
            this.risNeeded.Location = new System.Drawing.Point(101, 196);
            this.risNeeded.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.risNeeded.Name = "risNeeded";
            this.risNeeded.Size = new System.Drawing.Size(13, 13);
            this.risNeeded.TabIndex = 16;
            this.risNeeded.Text = "0";
            // 
            // isNeeded
            // 
            this.isNeeded.AutoSize = true;
            this.isNeeded.Location = new System.Drawing.Point(101, 173);
            this.isNeeded.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.isNeeded.Name = "isNeeded";
            this.isNeeded.Size = new System.Drawing.Size(13, 13);
            this.isNeeded.TabIndex = 15;
            this.isNeeded.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "RIS needed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "IS needed:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Craft";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chanceIncrease
            // 
            this.chanceIncrease.Location = new System.Drawing.Point(103, 5);
            this.chanceIncrease.Name = "chanceIncrease";
            this.chanceIncrease.Size = new System.Drawing.Size(44, 20);
            this.chanceIncrease.TabIndex = 11;
            // 
            // labelChanceIncrease
            // 
            this.labelChanceIncrease.AutoSize = true;
            this.labelChanceIncrease.Location = new System.Drawing.Point(6, 8);
            this.labelChanceIncrease.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelChanceIncrease.Name = "labelChanceIncrease";
            this.labelChanceIncrease.Size = new System.Drawing.Size(91, 13);
            this.labelChanceIncrease.TabIndex = 10;
            this.labelChanceIncrease.Text = "Chance Increase:";
            // 
            // hasEWBuff
            // 
            this.hasEWBuff.AutoSize = true;
            this.hasEWBuff.Location = new System.Drawing.Point(104, 30);
            this.hasEWBuff.Name = "hasEWBuff";
            this.hasEWBuff.Size = new System.Drawing.Size(15, 14);
            this.hasEWBuff.TabIndex = 9;
            this.hasEWBuff.UseVisualStyleBackColor = true;
            // 
            // labelEmporiaBuff
            // 
            this.labelEmporiaBuff.AutoSize = true;
            this.labelEmporiaBuff.Location = new System.Drawing.Point(6, 31);
            this.labelEmporiaBuff.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelEmporiaBuff.Name = "labelEmporiaBuff";
            this.labelEmporiaBuff.Size = new System.Drawing.Size(70, 13);
            this.labelEmporiaBuff.TabIndex = 8;
            this.labelEmporiaBuff.Text = "Emporia Buff:";
            // 
            // toELvl
            // 
            this.toELvl.Location = new System.Drawing.Point(104, 116);
            this.toELvl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.toELvl.Name = "toELvl";
            this.toELvl.Size = new System.Drawing.Size(43, 20);
            this.toELvl.TabIndex = 5;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(6, 118);
            this.labelTo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 13);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "To:";
            // 
            // fromELvl
            // 
            this.fromELvl.Location = new System.Drawing.Point(104, 93);
            this.fromELvl.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.fromELvl.Name = "fromELvl";
            this.fromELvl.Size = new System.Drawing.Size(43, 20);
            this.fromELvl.TabIndex = 3;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(6, 95);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From:";
            // 
            // weapOrArmor
            // 
            this.weapOrArmor.FormattingEnabled = true;
            this.weapOrArmor.Items.AddRange(new object[] {
            "Weapon",
            "Armor"});
            this.weapOrArmor.Location = new System.Drawing.Point(103, 69);
            this.weapOrArmor.Name = "weapOrArmor";
            this.weapOrArmor.Size = new System.Drawing.Size(64, 21);
            this.weapOrArmor.TabIndex = 1;
            // 
            // labelItemToEnchant
            // 
            this.labelItemToEnchant.AutoSize = true;
            this.labelItemToEnchant.Location = new System.Drawing.Point(6, 72);
            this.labelItemToEnchant.Name = "labelItemToEnchant";
            this.labelItemToEnchant.Size = new System.Drawing.Size(87, 13);
            this.labelItemToEnchant.TabIndex = 0;
            this.labelItemToEnchant.Text = "Item to enchant: \r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Probabilities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(404, 47);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 11);
            this.label26.TabIndex = 26;
            this.label26.Text = ": 2.00%";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(404, 36);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 11);
            this.label25.TabIndex = 25;
            this.label25.Text = ": 2.00%";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(404, 25);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 11);
            this.label24.TabIndex = 24;
            this.label24.Text = ": 4.00%";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(404, 14);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 11);
            this.label23.TabIndex = 23;
            this.label23.Text = ": 6.00%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(200)))));
            this.label17.Location = new System.Drawing.Point(343, 47);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 11);
            this.label17.TabIndex = 22;
            this.label17.Text = "Legend";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(324, 47);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 11);
            this.label18.TabIndex = 21;
            this.label18.Text = "->";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(1)))));
            this.label19.Location = new System.Drawing.Point(263, 47);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 11);
            this.label19.TabIndex = 20;
            this.label19.Text = "Artifact";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(1)))));
            this.label20.Location = new System.Drawing.Point(343, 36);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 11);
            this.label20.TabIndex = 19;
            this.label20.Text = "Artifact";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(324, 36);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 11);
            this.label21.TabIndex = 18;
            this.label21.Text = "->";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.label22.Location = new System.Drawing.Point(263, 36);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 11);
            this.label22.TabIndex = 17;
            this.label22.Text = "Special";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.label16.Location = new System.Drawing.Point(343, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 11);
            this.label16.TabIndex = 16;
            this.label16.Text = "Special";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(324, 25);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 11);
            this.label15.TabIndex = 15;
            this.label15.Text = "->";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(22)))));
            this.label14.Location = new System.Drawing.Point(263, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 11);
            this.label14.TabIndex = 14;
            this.label14.Text = "Advanced";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(22)))));
            this.label13.Location = new System.Drawing.Point(343, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 11);
            this.label13.TabIndex = 13;
            this.label13.Text = "Advanced";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(324, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 11);
            this.label12.TabIndex = 12;
            this.label12.Text = "->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(263, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 11);
            this.label11.TabIndex = 11;
            this.label11.Text = "Normal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 11);
            this.label10.TabIndex = 10;
            this.label10.Text = "Soulcraft:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 231);
            this.label5.TabIndex = 9;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 231);
            this.label4.TabIndex = 8;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 242);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DS Enchant/Soulcraft";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toELvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromELvl)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label risNeeded;
        private System.Windows.Forms.Label isNeeded;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chanceIncrease;
        private System.Windows.Forms.Label labelChanceIncrease;
        private System.Windows.Forms.CheckBox hasEWBuff;
        private System.Windows.Forms.Label labelEmporiaBuff;
        private System.Windows.Forms.NumericUpDown toELvl;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.NumericUpDown fromELvl;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox weapOrArmor;
        private System.Windows.Forms.Label labelItemToEnchant;
        private System.Windows.Forms.CheckBox doSoulcraft;
        private System.Windows.Forms.CheckBox doEnchanting;
    }
}


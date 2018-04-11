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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCrafting = new System.Windows.Forms.TabPage();
            this.buttonViewSuccessrates = new System.Windows.Forms.Button();
            this.labelTotalRIS = new System.Windows.Forms.Label();
            this.labelTotalIS = new System.Windows.Forms.Label();
            this.labelSuccessProbability2 = new System.Windows.Forms.Label();
            this.textBoxSuccessProbability = new System.Windows.Forms.TextBox();
            this.labelSuccessProbability = new System.Windows.Forms.Label();
            this.buttonResetTotal = new System.Windows.Forms.Button();
            this.numberOfItems = new System.Windows.Forms.NumericUpDown();
            this.labelNumOfItems = new System.Windows.Forms.Label();
            this.labelIsSoulNeeded = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelOutTotalRIS = new System.Windows.Forms.Label();
            this.labelOutTotalIS = new System.Windows.Forms.Label();
            this.labelEnchantEvent = new System.Windows.Forms.Label();
            this.textBoxEnchantEvent = new System.Windows.Forms.TextBox();
            this.labelChanceIncrease2 = new System.Windows.Forms.Label();
            this.comboBoxToSC = new System.Windows.Forms.ComboBox();
            this.comboBoxFromSC = new System.Windows.Forms.ComboBox();
            this.labelToSC = new System.Windows.Forms.Label();
            this.labelFromSC = new System.Windows.Forms.Label();
            this.checkBoxDoSoulcraft = new System.Windows.Forms.CheckBox();
            this.checkBoxDoEnchanting = new System.Windows.Forms.CheckBox();
            this.labelRisNeeded = new System.Windows.Forms.Label();
            this.labelIsNeeded = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCraft = new System.Windows.Forms.Button();
            this.textBoxChanceIncrease = new System.Windows.Forms.TextBox();
            this.labelChanceIncrease = new System.Windows.Forms.Label();
            this.checkBoxhasEWBuff = new System.Windows.Forms.CheckBox();
            this.labelEmporiaBuff = new System.Windows.Forms.Label();
            this.toELvl = new System.Windows.Forms.NumericUpDown();
            this.labelTo = new System.Windows.Forms.Label();
            this.fromELvl = new System.Windows.Forms.NumericUpDown();
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxWeapOrArmor = new System.Windows.Forms.ComboBox();
            this.labelItemToEnchant = new System.Windows.Forms.Label();
            this.tabPageProbabilities = new System.Windows.Forms.TabPage();
            this.labelSCProbs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelArmorProbs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labelNormalFrom = new System.Windows.Forms.Label();
            this.labelSoulcraft = new System.Windows.Forms.Label();
            this.labelWeaponProbs = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.tabPageCrafting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toELvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromELvl)).BeginInit();
            this.tabPageProbabilities.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageCrafting);
            this.tabControl.Controls.Add(this.tabPageProbabilities);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(400, 18);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(351, 324);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCrafting
            // 
            this.tabPageCrafting.Controls.Add(this.buttonViewSuccessrates);
            this.tabPageCrafting.Controls.Add(this.labelTotalRIS);
            this.tabPageCrafting.Controls.Add(this.labelTotalIS);
            this.tabPageCrafting.Controls.Add(this.labelSuccessProbability2);
            this.tabPageCrafting.Controls.Add(this.textBoxSuccessProbability);
            this.tabPageCrafting.Controls.Add(this.labelSuccessProbability);
            this.tabPageCrafting.Controls.Add(this.buttonResetTotal);
            this.tabPageCrafting.Controls.Add(this.numberOfItems);
            this.tabPageCrafting.Controls.Add(this.labelNumOfItems);
            this.tabPageCrafting.Controls.Add(this.labelIsSoulNeeded);
            this.tabPageCrafting.Controls.Add(this.label6);
            this.tabPageCrafting.Controls.Add(this.labelOutTotalRIS);
            this.tabPageCrafting.Controls.Add(this.labelOutTotalIS);
            this.tabPageCrafting.Controls.Add(this.labelEnchantEvent);
            this.tabPageCrafting.Controls.Add(this.textBoxEnchantEvent);
            this.tabPageCrafting.Controls.Add(this.labelChanceIncrease2);
            this.tabPageCrafting.Controls.Add(this.comboBoxToSC);
            this.tabPageCrafting.Controls.Add(this.comboBoxFromSC);
            this.tabPageCrafting.Controls.Add(this.labelToSC);
            this.tabPageCrafting.Controls.Add(this.labelFromSC);
            this.tabPageCrafting.Controls.Add(this.checkBoxDoSoulcraft);
            this.tabPageCrafting.Controls.Add(this.checkBoxDoEnchanting);
            this.tabPageCrafting.Controls.Add(this.labelRisNeeded);
            this.tabPageCrafting.Controls.Add(this.labelIsNeeded);
            this.tabPageCrafting.Controls.Add(this.label9);
            this.tabPageCrafting.Controls.Add(this.label8);
            this.tabPageCrafting.Controls.Add(this.buttonCraft);
            this.tabPageCrafting.Controls.Add(this.textBoxChanceIncrease);
            this.tabPageCrafting.Controls.Add(this.labelChanceIncrease);
            this.tabPageCrafting.Controls.Add(this.checkBoxhasEWBuff);
            this.tabPageCrafting.Controls.Add(this.labelEmporiaBuff);
            this.tabPageCrafting.Controls.Add(this.toELvl);
            this.tabPageCrafting.Controls.Add(this.labelTo);
            this.tabPageCrafting.Controls.Add(this.fromELvl);
            this.tabPageCrafting.Controls.Add(this.labelFrom);
            this.tabPageCrafting.Controls.Add(this.comboBoxWeapOrArmor);
            this.tabPageCrafting.Controls.Add(this.labelItemToEnchant);
            this.tabPageCrafting.Location = new System.Drawing.Point(4, 22);
            this.tabPageCrafting.Name = "tabPageCrafting";
            this.tabPageCrafting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCrafting.Size = new System.Drawing.Size(343, 298);
            this.tabPageCrafting.TabIndex = 0;
            this.tabPageCrafting.Text = "Crafting";
            this.tabPageCrafting.UseVisualStyleBackColor = true;
            // 
            // buttonViewSuccessrates
            // 
            this.buttonViewSuccessrates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonViewSuccessrates.Location = new System.Drawing.Point(4, 273);
            this.buttonViewSuccessrates.Name = "buttonViewSuccessrates";
            this.buttonViewSuccessrates.Size = new System.Drawing.Size(334, 23);
            this.buttonViewSuccessrates.TabIndex = 51;
            this.buttonViewSuccessrates.Text = "View Successrates";
            this.buttonViewSuccessrates.UseVisualStyleBackColor = true;
            this.buttonViewSuccessrates.Click += new System.EventHandler(this.buttonViewSuccessrates_Click);
            // 
            // labelTotalRIS
            // 
            this.labelTotalRIS.AutoSize = true;
            this.labelTotalRIS.Location = new System.Drawing.Point(197, 219);
            this.labelTotalRIS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelTotalRIS.Name = "labelTotalRIS";
            this.labelTotalRIS.Size = new System.Drawing.Size(52, 13);
            this.labelTotalRIS.TabIndex = 50;
            this.labelTotalRIS.Text = "Total RIS";
            // 
            // labelTotalIS
            // 
            this.labelTotalIS.AutoSize = true;
            this.labelTotalIS.Location = new System.Drawing.Point(197, 196);
            this.labelTotalIS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelTotalIS.Name = "labelTotalIS";
            this.labelTotalIS.Size = new System.Drawing.Size(47, 13);
            this.labelTotalIS.TabIndex = 49;
            this.labelTotalIS.Text = "Total IS:";
            // 
            // labelSuccessProbability2
            // 
            this.labelSuccessProbability2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuccessProbability2.AutoSize = true;
            this.labelSuccessProbability2.Location = new System.Drawing.Point(238, 173);
            this.labelSuccessProbability2.Name = "labelSuccessProbability2";
            this.labelSuccessProbability2.Size = new System.Drawing.Size(15, 13);
            this.labelSuccessProbability2.TabIndex = 42;
            this.labelSuccessProbability2.Text = "%";
            // 
            // textBoxSuccessProbability
            // 
            this.textBoxSuccessProbability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSuccessProbability.Location = new System.Drawing.Point(197, 170);
            this.textBoxSuccessProbability.Name = "textBoxSuccessProbability";
            this.textBoxSuccessProbability.Size = new System.Drawing.Size(41, 20);
            this.textBoxSuccessProbability.TabIndex = 41;
            this.textBoxSuccessProbability.Text = "75";
            this.textBoxSuccessProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSuccessProbability
            // 
            this.labelSuccessProbability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSuccessProbability.AutoSize = true;
            this.labelSuccessProbability.Location = new System.Drawing.Point(90, 173);
            this.labelSuccessProbability.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelSuccessProbability.Name = "labelSuccessProbability";
            this.labelSuccessProbability.Size = new System.Drawing.Size(101, 13);
            this.labelSuccessProbability.TabIndex = 40;
            this.labelSuccessProbability.Text = "Success probability:";
            // 
            // buttonResetTotal
            // 
            this.buttonResetTotal.Location = new System.Drawing.Point(200, 240);
            this.buttonResetTotal.Name = "buttonResetTotal";
            this.buttonResetTotal.Size = new System.Drawing.Size(135, 23);
            this.buttonResetTotal.TabIndex = 39;
            this.buttonResetTotal.Text = "Reset Total";
            this.buttonResetTotal.UseVisualStyleBackColor = true;
            this.buttonResetTotal.Click += new System.EventHandler(this.buttonResetTotal_Click);
            // 
            // numberOfItems
            // 
            this.numberOfItems.Location = new System.Drawing.Point(254, 28);
            this.numberOfItems.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numberOfItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfItems.Name = "numberOfItems";
            this.numberOfItems.Size = new System.Drawing.Size(40, 20);
            this.numberOfItems.TabIndex = 38;
            this.numberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberOfItems.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumOfItems
            // 
            this.labelNumOfItems.AutoSize = true;
            this.labelNumOfItems.Location = new System.Drawing.Point(170, 31);
            this.labelNumOfItems.Name = "labelNumOfItems";
            this.labelNumOfItems.Size = new System.Drawing.Size(57, 13);
            this.labelNumOfItems.TabIndex = 37;
            this.labelNumOfItems.Text = "# of Items:";
            // 
            // labelIsSoulNeeded
            // 
            this.labelIsSoulNeeded.AutoSize = true;
            this.labelIsSoulNeeded.Location = new System.Drawing.Point(131, 242);
            this.labelIsSoulNeeded.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelIsSoulNeeded.Name = "labelIsSoulNeeded";
            this.labelIsSoulNeeded.Size = new System.Drawing.Size(13, 13);
            this.labelIsSoulNeeded.TabIndex = 36;
            this.labelIsSoulNeeded.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "IS needed (Soulcraft):";
            // 
            // labelOutTotalRIS
            // 
            this.labelOutTotalRIS.AutoSize = true;
            this.labelOutTotalRIS.Location = new System.Drawing.Point(252, 219);
            this.labelOutTotalRIS.Name = "labelOutTotalRIS";
            this.labelOutTotalRIS.Size = new System.Drawing.Size(13, 13);
            this.labelOutTotalRIS.TabIndex = 31;
            this.labelOutTotalRIS.Text = "0";
            // 
            // labelOutTotalIS
            // 
            this.labelOutTotalIS.AutoSize = true;
            this.labelOutTotalIS.Location = new System.Drawing.Point(252, 196);
            this.labelOutTotalIS.Name = "labelOutTotalIS";
            this.labelOutTotalIS.Size = new System.Drawing.Size(13, 13);
            this.labelOutTotalIS.TabIndex = 29;
            this.labelOutTotalIS.Text = "0";
            // 
            // labelEnchantEvent
            // 
            this.labelEnchantEvent.AutoSize = true;
            this.labelEnchantEvent.Location = new System.Drawing.Point(170, 8);
            this.labelEnchantEvent.Name = "labelEnchantEvent";
            this.labelEnchantEvent.Size = new System.Drawing.Size(80, 13);
            this.labelEnchantEvent.TabIndex = 26;
            this.labelEnchantEvent.Text = "Enchant event:";
            // 
            // textBoxEnchantEvent
            // 
            this.textBoxEnchantEvent.Location = new System.Drawing.Point(254, 5);
            this.textBoxEnchantEvent.Name = "textBoxEnchantEvent";
            this.textBoxEnchantEvent.Size = new System.Drawing.Size(40, 20);
            this.textBoxEnchantEvent.TabIndex = 25;
            this.textBoxEnchantEvent.Text = "0";
            this.textBoxEnchantEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelChanceIncrease2
            // 
            this.labelChanceIncrease2.AutoSize = true;
            this.labelChanceIncrease2.Location = new System.Drawing.Point(144, 8);
            this.labelChanceIncrease2.Name = "labelChanceIncrease2";
            this.labelChanceIncrease2.Size = new System.Drawing.Size(15, 13);
            this.labelChanceIncrease2.TabIndex = 23;
            this.labelChanceIncrease2.Text = "%";
            // 
            // comboBoxToSC
            // 
            this.comboBoxToSC.AutoCompleteCustomSource.AddRange(new string[] {
            "Advanced",
            "Special",
            "Artifact",
            "Legend"});
            this.comboBoxToSC.FormattingEnabled = true;
            this.comboBoxToSC.Items.AddRange(new object[] {
            "Advanced",
            "Special",
            "Artifact",
            "Legend"});
            this.comboBoxToSC.Location = new System.Drawing.Point(254, 92);
            this.comboBoxToSC.Name = "comboBoxToSC";
            this.comboBoxToSC.Size = new System.Drawing.Size(83, 21);
            this.comboBoxToSC.TabIndex = 22;
            this.comboBoxToSC.Text = "Legend";
            // 
            // comboBoxFromSC
            // 
            this.comboBoxFromSC.FormattingEnabled = true;
            this.comboBoxFromSC.Items.AddRange(new object[] {
            "Normal",
            "Advanced",
            "Special",
            "Artifact"});
            this.comboBoxFromSC.Location = new System.Drawing.Point(254, 69);
            this.comboBoxFromSC.Name = "comboBoxFromSC";
            this.comboBoxFromSC.Size = new System.Drawing.Size(83, 21);
            this.comboBoxFromSC.TabIndex = 21;
            this.comboBoxFromSC.Text = "Advanced";
            // 
            // labelToSC
            // 
            this.labelToSC.AutoSize = true;
            this.labelToSC.Location = new System.Drawing.Point(170, 95);
            this.labelToSC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelToSC.Name = "labelToSC";
            this.labelToSC.Size = new System.Drawing.Size(65, 13);
            this.labelToSC.TabIndex = 20;
            this.labelToSC.Text = "To Soulcraft";
            // 
            // labelFromSC
            // 
            this.labelFromSC.AutoSize = true;
            this.labelFromSC.Location = new System.Drawing.Point(170, 72);
            this.labelFromSC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelFromSC.Name = "labelFromSC";
            this.labelFromSC.Size = new System.Drawing.Size(78, 13);
            this.labelFromSC.TabIndex = 19;
            this.labelFromSC.Text = "From Soulcraft:";
            // 
            // checkBoxDoSoulcraft
            // 
            this.checkBoxDoSoulcraft.AutoSize = true;
            this.checkBoxDoSoulcraft.Checked = true;
            this.checkBoxDoSoulcraft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDoSoulcraft.Location = new System.Drawing.Point(173, 52);
            this.checkBoxDoSoulcraft.Name = "checkBoxDoSoulcraft";
            this.checkBoxDoSoulcraft.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDoSoulcraft.TabIndex = 18;
            this.checkBoxDoSoulcraft.Text = "Soulcrafting";
            this.checkBoxDoSoulcraft.UseVisualStyleBackColor = true;
            this.checkBoxDoSoulcraft.CheckedChanged += new System.EventHandler(this.doSoulcraft_CheckedChanged);
            // 
            // checkBoxDoEnchanting
            // 
            this.checkBoxDoEnchanting.AutoSize = true;
            this.checkBoxDoEnchanting.Checked = true;
            this.checkBoxDoEnchanting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDoEnchanting.Location = new System.Drawing.Point(9, 52);
            this.checkBoxDoEnchanting.Name = "checkBoxDoEnchanting";
            this.checkBoxDoEnchanting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxDoEnchanting.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDoEnchanting.TabIndex = 17;
            this.checkBoxDoEnchanting.Text = "Enchanting";
            this.checkBoxDoEnchanting.UseVisualStyleBackColor = true;
            this.checkBoxDoEnchanting.CheckedChanged += new System.EventHandler(this.doEnchanting_CheckedChanged);
            // 
            // labelRisNeeded
            // 
            this.labelRisNeeded.AutoSize = true;
            this.labelRisNeeded.Location = new System.Drawing.Point(131, 219);
            this.labelRisNeeded.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelRisNeeded.Name = "labelRisNeeded";
            this.labelRisNeeded.Size = new System.Drawing.Size(13, 13);
            this.labelRisNeeded.TabIndex = 16;
            this.labelRisNeeded.Text = "0";
            // 
            // labelIsNeeded
            // 
            this.labelIsNeeded.AutoSize = true;
            this.labelIsNeeded.Location = new System.Drawing.Point(131, 196);
            this.labelIsNeeded.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelIsNeeded.Name = "labelIsNeeded";
            this.labelIsNeeded.Size = new System.Drawing.Size(13, 13);
            this.labelIsNeeded.TabIndex = 15;
            this.labelIsNeeded.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "RIS needed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "IS needed:";
            // 
            // buttonCraft
            // 
            this.buttonCraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCraft.Location = new System.Drawing.Point(4, 142);
            this.buttonCraft.Name = "buttonCraft";
            this.buttonCraft.Size = new System.Drawing.Size(334, 23);
            this.buttonCraft.TabIndex = 12;
            this.buttonCraft.Text = "Craft";
            this.buttonCraft.UseVisualStyleBackColor = true;
            this.buttonCraft.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxChanceIncrease
            // 
            this.textBoxChanceIncrease.Location = new System.Drawing.Point(103, 5);
            this.textBoxChanceIncrease.Name = "textBoxChanceIncrease";
            this.textBoxChanceIncrease.Size = new System.Drawing.Size(41, 20);
            this.textBoxChanceIncrease.TabIndex = 11;
            this.textBoxChanceIncrease.Text = "0";
            this.textBoxChanceIncrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // checkBoxhasEWBuff
            // 
            this.checkBoxhasEWBuff.AutoSize = true;
            this.checkBoxhasEWBuff.Location = new System.Drawing.Point(104, 30);
            this.checkBoxhasEWBuff.Name = "checkBoxhasEWBuff";
            this.checkBoxhasEWBuff.Size = new System.Drawing.Size(15, 14);
            this.checkBoxhasEWBuff.TabIndex = 9;
            this.checkBoxhasEWBuff.UseVisualStyleBackColor = true;
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
            this.toELvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toELvl.Name = "toELvl";
            this.toELvl.Size = new System.Drawing.Size(40, 20);
            this.toELvl.TabIndex = 5;
            this.toELvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toELvl.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
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
            this.fromELvl.Size = new System.Drawing.Size(40, 20);
            this.fromELvl.TabIndex = 3;
            this.fromELvl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fromELvl.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
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
            // comboBoxWeapOrArmor
            // 
            this.comboBoxWeapOrArmor.FormattingEnabled = true;
            this.comboBoxWeapOrArmor.Items.AddRange(new object[] {
            "Weapon",
            "Armor"});
            this.comboBoxWeapOrArmor.Location = new System.Drawing.Point(103, 69);
            this.comboBoxWeapOrArmor.Name = "comboBoxWeapOrArmor";
            this.comboBoxWeapOrArmor.Size = new System.Drawing.Size(64, 21);
            this.comboBoxWeapOrArmor.TabIndex = 1;
            this.comboBoxWeapOrArmor.Text = "Weapon";
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
            // tabPageProbabilities
            // 
            this.tabPageProbabilities.Controls.Add(this.labelSCProbs);
            this.tabPageProbabilities.Controls.Add(this.label3);
            this.tabPageProbabilities.Controls.Add(this.labelArmorProbs);
            this.tabPageProbabilities.Controls.Add(this.label2);
            this.tabPageProbabilities.Controls.Add(this.label17);
            this.tabPageProbabilities.Controls.Add(this.label18);
            this.tabPageProbabilities.Controls.Add(this.label19);
            this.tabPageProbabilities.Controls.Add(this.label20);
            this.tabPageProbabilities.Controls.Add(this.label21);
            this.tabPageProbabilities.Controls.Add(this.label22);
            this.tabPageProbabilities.Controls.Add(this.label16);
            this.tabPageProbabilities.Controls.Add(this.label15);
            this.tabPageProbabilities.Controls.Add(this.label14);
            this.tabPageProbabilities.Controls.Add(this.label13);
            this.tabPageProbabilities.Controls.Add(this.label12);
            this.tabPageProbabilities.Controls.Add(this.labelNormalFrom);
            this.tabPageProbabilities.Controls.Add(this.labelSoulcraft);
            this.tabPageProbabilities.Controls.Add(this.labelWeaponProbs);
            this.tabPageProbabilities.Controls.Add(this.label99);
            this.tabPageProbabilities.ForeColor = System.Drawing.Color.Black;
            this.tabPageProbabilities.Location = new System.Drawing.Point(4, 22);
            this.tabPageProbabilities.Name = "tabPageProbabilities";
            this.tabPageProbabilities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProbabilities.Size = new System.Drawing.Size(343, 298);
            this.tabPageProbabilities.TabIndex = 1;
            this.tabPageProbabilities.Text = "Successrates";
            this.tabPageProbabilities.UseVisualStyleBackColor = true;
            // 
            // labelSCProbs
            // 
            this.labelSCProbs.AutoSize = true;
            this.labelSCProbs.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSCProbs.Location = new System.Drawing.Point(156, 254);
            this.labelSCProbs.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelSCProbs.Name = "labelSCProbs";
            this.labelSCProbs.Size = new System.Drawing.Size(40, 44);
            this.labelSCProbs.TabIndex = 30;
            this.labelSCProbs.Text = "6.00%\r\n4.00%\r\n2.00%\r\n2.00%";
            this.labelSCProbs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 44);
            this.label3.TabIndex = 29;
            this.label3.Text = ":\r\n:\r\n:\r\n:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelArmorProbs
            // 
            this.labelArmorProbs.AutoSize = true;
            this.labelArmorProbs.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArmorProbs.Location = new System.Drawing.Point(220, 14);
            this.labelArmorProbs.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelArmorProbs.Name = "labelArmorProbs";
            this.labelArmorProbs.Size = new System.Drawing.Size(47, 220);
            this.labelArmorProbs.TabIndex = 28;
            this.labelArmorProbs.Text = "95.00%\r\n95.00%\r\n95.00%\r\n50.00%\r\n40.00%\r\n30.00%\r\n25.00%\r\n20.00%\r\n18.00%\r\n16.00%\r\n1" +
    "4.00%\r\n12.00%\r\n10.00%\r\n5.00%\r\n3.00%\r\n0.90%\r\n0.80%\r\n0.40%\r\n0.35%\r\n0.34%";
            this.labelArmorProbs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label2.Location = new System.Drawing.Point(145, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 231);
            this.label2.TabIndex = 27;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(200)))));
            this.label17.Location = new System.Drawing.Point(83, 287);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 11);
            this.label17.TabIndex = 22;
            this.label17.Text = "Legend";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(64, 287);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 11);
            this.label18.TabIndex = 21;
            this.label18.Text = "->";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(1)))));
            this.label19.Location = new System.Drawing.Point(3, 287);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 11);
            this.label19.TabIndex = 20;
            this.label19.Text = "Artifact";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(70)))), ((int)(((byte)(1)))));
            this.label20.Location = new System.Drawing.Point(83, 276);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 11);
            this.label20.TabIndex = 19;
            this.label20.Text = "Artifact";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(64, 276);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 11);
            this.label21.TabIndex = 18;
            this.label21.Text = "->";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.label22.Location = new System.Drawing.Point(3, 276);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 11);
            this.label22.TabIndex = 17;
            this.label22.Text = "Special";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(124)))), ((int)(((byte)(165)))));
            this.label16.Location = new System.Drawing.Point(83, 265);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 11);
            this.label16.TabIndex = 16;
            this.label16.Text = "Special";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(64, 265);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 11);
            this.label15.TabIndex = 15;
            this.label15.Text = "->";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(22)))));
            this.label14.Location = new System.Drawing.Point(3, 265);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 11);
            this.label14.TabIndex = 14;
            this.label14.Text = "Advanced";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(143)))), ((int)(((byte)(22)))));
            this.label13.Location = new System.Drawing.Point(83, 254);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 11);
            this.label13.TabIndex = 13;
            this.label13.Text = "Advanced";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(64, 254);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 11);
            this.label12.TabIndex = 12;
            this.label12.Text = "->";
            // 
            // labelNormalFrom
            // 
            this.labelNormalFrom.AutoSize = true;
            this.labelNormalFrom.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormalFrom.Location = new System.Drawing.Point(3, 254);
            this.labelNormalFrom.Margin = new System.Windows.Forms.Padding(0);
            this.labelNormalFrom.Name = "labelNormalFrom";
            this.labelNormalFrom.Size = new System.Drawing.Size(47, 11);
            this.labelNormalFrom.TabIndex = 11;
            this.labelNormalFrom.Text = "Normal";
            // 
            // labelSoulcraft
            // 
            this.labelSoulcraft.AutoSize = true;
            this.labelSoulcraft.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoulcraft.Location = new System.Drawing.Point(3, 243);
            this.labelSoulcraft.Name = "labelSoulcraft";
            this.labelSoulcraft.Size = new System.Drawing.Size(75, 11);
            this.labelSoulcraft.TabIndex = 10;
            this.labelSoulcraft.Text = "Soulcraft:";
            // 
            // labelWeaponProbs
            // 
            this.labelWeaponProbs.AutoSize = true;
            this.labelWeaponProbs.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeaponProbs.Location = new System.Drawing.Point(78, 14);
            this.labelWeaponProbs.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelWeaponProbs.Name = "labelWeaponProbs";
            this.labelWeaponProbs.Size = new System.Drawing.Size(47, 220);
            this.labelWeaponProbs.TabIndex = 9;
            this.labelWeaponProbs.Text = "95.00%\r\n95.00%\r\n95.00%\r\n30.00%\r\n27.00%\r\n24.00%\r\n21.00%\r\n18.00%\r\n15.00%\r\n12.00%\r\n9" +
    ".00%\r\n6.00%\r\n3.00%\r\n3.00%\r\n1.00%\r\n0.70%\r\n0.40%\r\n0.20%\r\n0.18%\r\n0.17%";
            this.labelWeaponProbs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Lucida Console", 8F);
            this.label99.Location = new System.Drawing.Point(3, 3);
            this.label99.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(75, 231);
            this.label99.TabIndex = 8;
            this.label99.Text = resources.GetString("label99.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 324);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DS Enchant/Soulcraft";
            this.tabControl.ResumeLayout(false);
            this.tabPageCrafting.ResumeLayout(false);
            this.tabPageCrafting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toELvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromELvl)).EndInit();
            this.tabPageProbabilities.ResumeLayout(false);
            this.tabPageProbabilities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageProbabilities;
        public System.Windows.Forms.TabPage tabPageCrafting;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelNormalFrom;
        private System.Windows.Forms.Label labelSoulcraft;
        private System.Windows.Forms.Label labelWeaponProbs;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelRisNeeded;
        private System.Windows.Forms.Label labelIsNeeded;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCraft;
        private System.Windows.Forms.TextBox textBoxChanceIncrease;
        private System.Windows.Forms.Label labelChanceIncrease;
        private System.Windows.Forms.CheckBox checkBoxhasEWBuff;
        private System.Windows.Forms.Label labelEmporiaBuff;
        private System.Windows.Forms.NumericUpDown toELvl;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.NumericUpDown fromELvl;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxWeapOrArmor;
        private System.Windows.Forms.Label labelItemToEnchant;
        private System.Windows.Forms.CheckBox checkBoxDoSoulcraft;
        private System.Windows.Forms.CheckBox checkBoxDoEnchanting;
        private System.Windows.Forms.ComboBox comboBoxToSC;
        private System.Windows.Forms.ComboBox comboBoxFromSC;
        private System.Windows.Forms.Label labelToSC;
        private System.Windows.Forms.Label labelFromSC;
        private System.Windows.Forms.Label labelChanceIncrease2;
        private System.Windows.Forms.Label labelEnchantEvent;
        private System.Windows.Forms.TextBox textBoxEnchantEvent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelOutTotalIS;
        private System.Windows.Forms.Label labelOutTotalRIS;
        private System.Windows.Forms.Label labelIsSoulNeeded;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberOfItems;
        private System.Windows.Forms.Label labelNumOfItems;
        private System.Windows.Forms.Button buttonResetTotal;
        private System.Windows.Forms.Label labelSuccessProbability2;
        private System.Windows.Forms.TextBox textBoxSuccessProbability;
        private System.Windows.Forms.Label labelSuccessProbability;
        private System.Windows.Forms.Label labelTotalRIS;
        private System.Windows.Forms.Label labelTotalIS;
        private System.Windows.Forms.Button buttonViewSuccessrates;
        private System.Windows.Forms.Label labelArmorProbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSCProbs;
        private System.Windows.Forms.Label label3;
    }
}


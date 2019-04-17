using System;

namespace DnDApp2
{
    partial class DnDUnitCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DnDUnitCalc));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.unitLibraryBox = new System.Windows.Forms.ComboBox();
            this.removeUnit = new System.Windows.Forms.Button();
            this.saveUnitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameInputBox = new System.Windows.Forms.TextBox();
            this.cardName = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toughnesso = new System.Windows.Forms.Label();
            this.defenseo = new System.Windows.Forms.Label();
            this.sizeo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.powero = new System.Windows.Forms.Label();
            this.attacko = new System.Windows.Forms.Label();
            this.moraleo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ancestryBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.experienceBox = new System.Windows.Forms.ComboBox();
            this.equipmentBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ancestryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitsOutputText = new System.Windows.Forms.RichTextBox();
            this.loadLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.unitLibraryBox);
            this.tabPage1.Controls.Add(this.removeUnit);
            this.tabPage1.Controls.Add(this.saveUnitButton);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.sizeBox);
            this.tabPage1.Controls.Add(this.typeBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ancestryBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.experienceBox);
            this.tabPage1.Controls.Add(this.equipmentBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(491, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unit Design";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // unitLibraryBox
            // 
            this.unitLibraryBox.FormattingEnabled = true;
            this.unitLibraryBox.Location = new System.Drawing.Point(8, 259);
            this.unitLibraryBox.Name = "unitLibraryBox";
            this.unitLibraryBox.Size = new System.Drawing.Size(121, 21);
            this.unitLibraryBox.TabIndex = 27;
            this.unitLibraryBox.SelectedIndexChanged += new System.EventHandler(this.UnitLibraryBox_SelectedIndexChanged);
            // 
            // removeUnit
            // 
            this.removeUnit.Location = new System.Drawing.Point(8, 334);
            this.removeUnit.Name = "removeUnit";
            this.removeUnit.Size = new System.Drawing.Size(121, 42);
            this.removeUnit.TabIndex = 26;
            this.removeUnit.Text = "Remove form Library";
            this.removeUnit.UseVisualStyleBackColor = true;
            this.removeUnit.Click += new System.EventHandler(this.RemoveUnit_Click);
            // 
            // saveUnitButton
            // 
            this.saveUnitButton.Location = new System.Drawing.Point(8, 286);
            this.saveUnitButton.Name = "saveUnitButton";
            this.saveUnitButton.Size = new System.Drawing.Size(121, 42);
            this.saveUnitButton.TabIndex = 25;
            this.saveUnitButton.Text = "Add to Library";
            this.saveUnitButton.UseVisualStyleBackColor = true;
            this.saveUnitButton.Click += new System.EventHandler(this.SaveUnitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.traitsOutputText);
            this.panel1.Controls.Add(this.nameInputBox);
            this.panel1.Controls.Add(this.cardName);
            this.panel1.Controls.Add(this.costo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.toughnesso);
            this.panel1.Controls.Add(this.defenseo);
            this.panel1.Controls.Add(this.sizeo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.powero);
            this.panel1.Controls.Add(this.attacko);
            this.panel1.Controls.Add(this.moraleo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(155, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 372);
            this.panel1.TabIndex = 24;
            // 
            // nameInputBox
            // 
            this.nameInputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputBox.Location = new System.Drawing.Point(39, 20);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(250, 13);
            this.nameInputBox.TabIndex = 49;
            this.nameInputBox.Text = "Unit Name";
            this.nameInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardName
            // 
            this.cardName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardName.BackColor = System.Drawing.Color.White;
            this.cardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardName.Location = new System.Drawing.Point(15, 40);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(301, 20);
            this.cardName.TabIndex = 48;
            this.cardName.Text = "----------------------";
            this.cardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costo
            // 
            this.costo.AutoSize = true;
            this.costo.BackColor = System.Drawing.Color.White;
            this.costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(257, 83);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(14, 13);
            this.costo.TabIndex = 47;
            this.costo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(162, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "COST";
            // 
            // toughnesso
            // 
            this.toughnesso.AutoSize = true;
            this.toughnesso.BackColor = System.Drawing.Color.White;
            this.toughnesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toughnesso.Location = new System.Drawing.Point(257, 139);
            this.toughnesso.Name = "toughnesso";
            this.toughnesso.Size = new System.Drawing.Size(14, 13);
            this.toughnesso.TabIndex = 45;
            this.toughnesso.Text = "0";
            // 
            // defenseo
            // 
            this.defenseo.AutoSize = true;
            this.defenseo.BackColor = System.Drawing.Color.White;
            this.defenseo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseo.Location = new System.Drawing.Point(257, 123);
            this.defenseo.Name = "defenseo";
            this.defenseo.Size = new System.Drawing.Size(14, 13);
            this.defenseo.TabIndex = 44;
            this.defenseo.Text = "0";
            // 
            // sizeo
            // 
            this.sizeo.AutoSize = true;
            this.sizeo.BackColor = System.Drawing.Color.White;
            this.sizeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeo.Location = new System.Drawing.Point(257, 155);
            this.sizeo.Name = "sizeo";
            this.sizeo.Size = new System.Drawing.Size(14, 13);
            this.sizeo.TabIndex = 43;
            this.sizeo.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(162, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "SIZE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(162, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "TOUGHNESS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(162, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "DEFENSE";
            // 
            // powero
            // 
            this.powero.AutoSize = true;
            this.powero.BackColor = System.Drawing.Color.White;
            this.powero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powero.Location = new System.Drawing.Point(73, 139);
            this.powero.Name = "powero";
            this.powero.Size = new System.Drawing.Size(14, 13);
            this.powero.TabIndex = 39;
            this.powero.Text = "0";
            // 
            // attacko
            // 
            this.attacko.AutoSize = true;
            this.attacko.BackColor = System.Drawing.Color.White;
            this.attacko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attacko.Location = new System.Drawing.Point(73, 123);
            this.attacko.Name = "attacko";
            this.attacko.Size = new System.Drawing.Size(14, 13);
            this.attacko.TabIndex = 38;
            this.attacko.Text = "0";
            // 
            // moraleo
            // 
            this.moraleo.AutoSize = true;
            this.moraleo.BackColor = System.Drawing.Color.White;
            this.moraleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moraleo.Location = new System.Drawing.Point(73, 155);
            this.moraleo.Name = "moraleo";
            this.moraleo.Size = new System.Drawing.Size(14, 13);
            this.moraleo.TabIndex = 37;
            this.moraleo.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "MORALE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "POWER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "TRAITS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "ATTACK";
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(8, 182);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(121, 21);
            this.sizeBox.TabIndex = 22;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.SizeBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(8, 102);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 18;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Experience";
            // 
            // ancestryBox
            // 
            this.ancestryBox.FormattingEnabled = true;
            this.ancestryBox.Location = new System.Drawing.Point(8, 22);
            this.ancestryBox.Name = "ancestryBox";
            this.ancestryBox.Size = new System.Drawing.Size(121, 21);
            this.ancestryBox.TabIndex = 14;
            this.ancestryBox.SelectedIndexChanged += new System.EventHandler(this.AncestryBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ancestry";
            // 
            // experienceBox
            // 
            this.experienceBox.FormattingEnabled = true;
            this.experienceBox.Location = new System.Drawing.Point(8, 142);
            this.experienceBox.Name = "experienceBox";
            this.experienceBox.Size = new System.Drawing.Size(121, 21);
            this.experienceBox.TabIndex = 20;
            this.experienceBox.SelectedIndexChanged += new System.EventHandler(this.ExperienceBox_SelectedIndexChanged);
            // 
            // equipmentBox
            // 
            this.equipmentBox.FormattingEnabled = true;
            this.equipmentBox.Location = new System.Drawing.Point(8, 62);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(121, 21);
            this.equipmentBox.TabIndex = 16;
            this.equipmentBox.SelectedIndexChanged += new System.EventHandler(this.EquipmentBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Equipment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Type";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveLibraryToolStripMenuItem,
            this.loadLibraryToolStripMenuItem,
            this.generateCardToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // saveLibraryToolStripMenuItem
            // 
            this.saveLibraryToolStripMenuItem.Name = "saveLibraryToolStripMenuItem";
            this.saveLibraryToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveLibraryToolStripMenuItem.Text = "Save Library";
            this.saveLibraryToolStripMenuItem.Click += new System.EventHandler(this.SaveLibraryToolStripMenuItem_Click);
            // 
            // generateCardToolStripMenuItem
            // 
            this.generateCardToolStripMenuItem.Name = "generateCardToolStripMenuItem";
            this.generateCardToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.generateCardToolStripMenuItem.Text = "Generate Card";
            this.generateCardToolStripMenuItem.Click += new System.EventHandler(this.GenerateCardToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.toolStripSeparator1,
            this.importTablesToolStripMenuItem,
            this.exportTablesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ancestryToolStripMenuItem,
            this.traidToolStripMenuItem,
            this.experienceToolStripMenuItem,
            this.equipmentToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.sizeToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // ancestryToolStripMenuItem
            // 
            this.ancestryToolStripMenuItem.Name = "ancestryToolStripMenuItem";
            this.ancestryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ancestryToolStripMenuItem.Text = "Ancestry";
            this.ancestryToolStripMenuItem.Click += new System.EventHandler(this.AncestryToolStripMenuItem_Click);
            // 
            // traidToolStripMenuItem
            // 
            this.traidToolStripMenuItem.Name = "traidToolStripMenuItem";
            this.traidToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.traidToolStripMenuItem.Text = "Traid";
            this.traidToolStripMenuItem.Click += new System.EventHandler(this.TraidToolStripMenuItem_Click);
            // 
            // experienceToolStripMenuItem
            // 
            this.experienceToolStripMenuItem.Name = "experienceToolStripMenuItem";
            this.experienceToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.experienceToolStripMenuItem.Text = "Experience";
            this.experienceToolStripMenuItem.Click += new System.EventHandler(this.ExperienceToolStripMenuItem_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.EquipmentToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.TypeToolStripMenuItem_Click);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.SizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // importTablesToolStripMenuItem
            // 
            this.importTablesToolStripMenuItem.Name = "importTablesToolStripMenuItem";
            this.importTablesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.importTablesToolStripMenuItem.Text = "Import Tables";
            this.importTablesToolStripMenuItem.Click += new System.EventHandler(this.ImportTablesToolStripMenuItem_Click);
            // 
            // exportTablesToolStripMenuItem
            // 
            this.exportTablesToolStripMenuItem.Name = "exportTablesToolStripMenuItem";
            this.exportTablesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exportTablesToolStripMenuItem.Text = "Export Tables";
            this.exportTablesToolStripMenuItem.Click += new System.EventHandler(this.ExportTablesToolStripMenuItem_Click);
            // 
            // traitsOutputText
            // 
            this.traitsOutputText.BackColor = System.Drawing.SystemColors.Window;
            this.traitsOutputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.traitsOutputText.DetectUrls = false;
            this.traitsOutputText.Location = new System.Drawing.Point(15, 195);
            this.traitsOutputText.Name = "traitsOutputText";
            this.traitsOutputText.ReadOnly = true;
            this.traitsOutputText.ShortcutsEnabled = false;
            this.traitsOutputText.Size = new System.Drawing.Size(301, 145);
            this.traitsOutputText.TabIndex = 50;
            this.traitsOutputText.Text = "traitsOutputText";
            // 
            // loadLibraryToolStripMenuItem
            // 
            this.loadLibraryToolStripMenuItem.Name = "loadLibraryToolStripMenuItem";
            this.loadLibraryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadLibraryToolStripMenuItem.Text = "Load Library";
            this.loadLibraryToolStripMenuItem.Click += new System.EventHandler(this.LoadLibraryToolStripMenuItem_Click);
            // 
            // DnDUnitCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 437);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "DnDUnitCalc";
            this.ShowIcon = false;
            this.Text = "UnitCalc";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.Label cardName;
        private System.Windows.Forms.Label costo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label toughnesso;
        private System.Windows.Forms.Label defenseo;
        private System.Windows.Forms.Label sizeo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label powero;
        private System.Windows.Forms.Label attacko;
        private System.Windows.Forms.Label moraleo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ancestryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox experienceBox;
        private System.Windows.Forms.ComboBox equipmentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ancestryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTablesToolStripMenuItem;
        private System.Windows.Forms.Button saveUnitButton;
        private System.Windows.Forms.ComboBox unitLibraryBox;
        private System.Windows.Forms.Button removeUnit;
        private System.Windows.Forms.ToolStripMenuItem saveLibraryToolStripMenuItem;
        private System.Windows.Forms.RichTextBox traitsOutputText;
        private System.Windows.Forms.ToolStripMenuItem loadLibraryToolStripMenuItem;
    }
}


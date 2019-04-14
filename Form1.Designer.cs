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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ancestryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.experienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ancestryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.experienceBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.traitsOutput = new System.Windows.Forms.ListBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateCardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // generateCardToolStripMenuItem
            // 
            this.generateCardToolStripMenuItem.Name = "generateCardToolStripMenuItem";
            this.generateCardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateCardToolStripMenuItem.Text = "Generate Unit Card";
            this.generateCardToolStripMenuItem.Click += new System.EventHandler(this.GenerateCardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // importTablesToolStripMenuItem
            // 
            this.importTablesToolStripMenuItem.Name = "importTablesToolStripMenuItem";
            this.importTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importTablesToolStripMenuItem.Text = "Import Tables";
            this.importTablesToolStripMenuItem.Click += new System.EventHandler(this.ImportTablesToolStripMenuItem_Click);
            // 
            // exportTablesToolStripMenuItem
            // 
            this.exportTablesToolStripMenuItem.Name = "exportTablesToolStripMenuItem";
            this.exportTablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportTablesToolStripMenuItem.Text = "Export Tables";
            this.exportTablesToolStripMenuItem.Click += new System.EventHandler(this.ExportTablesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ancestryBox
            // 
            this.ancestryBox.FormattingEnabled = true;
            this.ancestryBox.Location = new System.Drawing.Point(12, 38);
            this.ancestryBox.Name = "ancestryBox";
            this.ancestryBox.Size = new System.Drawing.Size(121, 21);
            this.ancestryBox.TabIndex = 2;
            this.ancestryBox.SelectedIndexChanged += new System.EventHandler(this.updateOutput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ancestry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Equipment";
            // 
            // equipmentBox
            // 
            this.equipmentBox.FormattingEnabled = true;
            this.equipmentBox.Location = new System.Drawing.Point(12, 78);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(121, 21);
            this.equipmentBox.TabIndex = 4;
            this.equipmentBox.SelectedIndexChanged += new System.EventHandler(this.updateOutput);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type";
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(12, 118);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 21);
            this.typeBox.TabIndex = 6;
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.updateOutput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Experience";
            // 
            // experienceBox
            // 
            this.experienceBox.FormattingEnabled = true;
            this.experienceBox.Location = new System.Drawing.Point(12, 158);
            this.experienceBox.Name = "experienceBox";
            this.experienceBox.Size = new System.Drawing.Size(121, 21);
            this.experienceBox.TabIndex = 8;
            this.experienceBox.SelectedIndexChanged += new System.EventHandler(this.updateOutput);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Size";
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Location = new System.Drawing.Point(12, 198);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(121, 21);
            this.sizeBox.TabIndex = 10;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.updateOutput);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameInputBox);
            this.groupBox1.Controls.Add(this.cardName);
            this.groupBox1.Controls.Add(this.costo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.toughnesso);
            this.groupBox1.Controls.Add(this.defenseo);
            this.groupBox1.Controls.Add(this.sizeo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.powero);
            this.groupBox1.Controls.Add(this.attacko);
            this.groupBox1.Controls.Add(this.moraleo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.traitsOutput);
            this.groupBox1.Location = new System.Drawing.Point(165, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 283);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Info";
            // 
            // nameInputBox
            // 
            this.nameInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInputBox.Location = new System.Drawing.Point(9, 16);
            this.nameInputBox.Name = "nameInputBox";
            this.nameInputBox.Size = new System.Drawing.Size(302, 20);
            this.nameInputBox.TabIndex = 31;
            this.nameInputBox.Text = "Unit Name";
            this.nameInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cardName
            // 
            this.cardName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardName.Location = new System.Drawing.Point(10, 40);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(301, 20);
            this.cardName.TabIndex = 30;
            this.cardName.Text = "----------------------";
            this.cardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costo
            // 
            this.costo.AutoSize = true;
            this.costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo.Location = new System.Drawing.Point(252, 64);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(14, 13);
            this.costo.TabIndex = 29;
            this.costo.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(157, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "COST";
            // 
            // toughnesso
            // 
            this.toughnesso.AutoSize = true;
            this.toughnesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toughnesso.Location = new System.Drawing.Point(252, 120);
            this.toughnesso.Name = "toughnesso";
            this.toughnesso.Size = new System.Drawing.Size(14, 13);
            this.toughnesso.TabIndex = 27;
            this.toughnesso.Text = "0";
            // 
            // defenseo
            // 
            this.defenseo.AutoSize = true;
            this.defenseo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defenseo.Location = new System.Drawing.Point(252, 104);
            this.defenseo.Name = "defenseo";
            this.defenseo.Size = new System.Drawing.Size(14, 13);
            this.defenseo.TabIndex = 26;
            this.defenseo.Text = "0";
            // 
            // sizeo
            // 
            this.sizeo.AutoSize = true;
            this.sizeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeo.Location = new System.Drawing.Point(252, 136);
            this.sizeo.Name = "sizeo";
            this.sizeo.Size = new System.Drawing.Size(14, 13);
            this.sizeo.TabIndex = 25;
            this.sizeo.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(157, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "SIZE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(157, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "TOUGHNESS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(157, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "DEFENSE";
            // 
            // powero
            // 
            this.powero.AutoSize = true;
            this.powero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powero.Location = new System.Drawing.Point(69, 120);
            this.powero.Name = "powero";
            this.powero.Size = new System.Drawing.Size(14, 13);
            this.powero.TabIndex = 21;
            this.powero.Text = "0";
            // 
            // attacko
            // 
            this.attacko.AutoSize = true;
            this.attacko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attacko.Location = new System.Drawing.Point(68, 104);
            this.attacko.Name = "attacko";
            this.attacko.Size = new System.Drawing.Size(14, 13);
            this.attacko.TabIndex = 20;
            this.attacko.Text = "0";
            // 
            // moraleo
            // 
            this.moraleo.AutoSize = true;
            this.moraleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moraleo.Location = new System.Drawing.Point(68, 136);
            this.moraleo.Name = "moraleo";
            this.moraleo.Size = new System.Drawing.Size(14, 13);
            this.moraleo.TabIndex = 18;
            this.moraleo.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "MORALE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "POWER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "TRAITS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ATTACK";
            // 
            // traitsOutput
            // 
            this.traitsOutput.FormattingEnabled = true;
            this.traitsOutput.Location = new System.Drawing.Point(9, 176);
            this.traitsOutput.Name = "traitsOutput";
            this.traitsOutput.Size = new System.Drawing.Size(302, 95);
            this.traitsOutput.TabIndex = 0;
            this.traitsOutput.DoubleClick += new System.EventHandler(this.TraitsOutput_DoubleClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // DnDUnitCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.experienceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipmentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ancestryBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 356);
            this.MinimumSize = new System.Drawing.Size(602, 356);
            this.Name = "DnDUnitCalc";
            this.ShowIcon = false;
            this.Text = "UnitCalc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ancestryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem experienceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTablesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox ancestryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipmentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox experienceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox traitsOutput;
        private System.Windows.Forms.Label powero;
        private System.Windows.Forms.Label attacko;
        private System.Windows.Forms.Label moraleo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label toughnesso;
        private System.Windows.Forms.Label defenseo;
        private System.Windows.Forms.Label sizeo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label costo;
        private System.Windows.Forms.TextBox nameInputBox;
        private System.Windows.Forms.Label cardName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


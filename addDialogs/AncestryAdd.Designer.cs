﻿namespace DnDApp2
{
    partial class AncestryAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.atkl = new System.Windows.Forms.Label();
            this.powerl = new System.Windows.Forms.Label();
            this.defesel = new System.Windows.Forms.Label();
            this.toughnessl = new System.Windows.Forms.Label();
            this.traitscbox = new System.Windows.Forms.ComboBox();
            this.moralel = new System.Windows.Forms.Label();
            this.toughness = new System.Windows.Forms.NumericUpDown();
            this.defense = new System.Windows.Forms.NumericUpDown();
            this.power = new System.Windows.Forms.NumericUpDown();
            this.attack = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.traitsdisplay = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.morale = new System.Windows.Forms.NumericUpDown();
            this.traitsl = new System.Windows.Forms.Label();
            this.addTrait = new System.Windows.Forms.Button();
            this.removeTrait = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.toughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morale)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancestry";
            // 
            // atkl
            // 
            this.atkl.AutoSize = true;
            this.atkl.Location = new System.Drawing.Point(12, 52);
            this.atkl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.atkl.Name = "atkl";
            this.atkl.Size = new System.Drawing.Size(38, 13);
            this.atkl.TabIndex = 2;
            this.atkl.Text = "Attack";
            // 
            // powerl
            // 
            this.powerl.AutoSize = true;
            this.powerl.Location = new System.Drawing.Point(12, 85);
            this.powerl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.powerl.Name = "powerl";
            this.powerl.Size = new System.Drawing.Size(37, 13);
            this.powerl.TabIndex = 3;
            this.powerl.Text = "Power";
            // 
            // defesel
            // 
            this.defesel.AutoSize = true;
            this.defesel.Location = new System.Drawing.Point(12, 118);
            this.defesel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.defesel.Name = "defesel";
            this.defesel.Size = new System.Drawing.Size(47, 13);
            this.defesel.TabIndex = 4;
            this.defesel.Text = "Defense";
            // 
            // toughnessl
            // 
            this.toughnessl.AutoSize = true;
            this.toughnessl.Location = new System.Drawing.Point(12, 151);
            this.toughnessl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.toughnessl.Name = "toughnessl";
            this.toughnessl.Size = new System.Drawing.Size(60, 13);
            this.toughnessl.TabIndex = 5;
            this.toughnessl.Text = "Toughness";
            // 
            // traitscbox
            // 
            this.traitscbox.FormattingEnabled = true;
            this.traitscbox.Location = new System.Drawing.Point(15, 243);
            this.traitscbox.Name = "traitscbox";
            this.traitscbox.Size = new System.Drawing.Size(121, 21);
            this.traitscbox.TabIndex = 6;
            // 
            // moralel
            // 
            this.moralel.AutoSize = true;
            this.moralel.Location = new System.Drawing.Point(12, 184);
            this.moralel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.moralel.Name = "moralel";
            this.moralel.Size = new System.Drawing.Size(39, 13);
            this.moralel.TabIndex = 7;
            this.moralel.Text = "Morale";
            // 
            // toughness
            // 
            this.toughness.Location = new System.Drawing.Point(81, 149);
            this.toughness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.toughness.Name = "toughness";
            this.toughness.Size = new System.Drawing.Size(34, 20);
            this.toughness.TabIndex = 9;
            // 
            // defense
            // 
            this.defense.Location = new System.Drawing.Point(81, 116);
            this.defense.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.defense.Name = "defense";
            this.defense.Size = new System.Drawing.Size(34, 20);
            this.defense.TabIndex = 10;
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(81, 83);
            this.power.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(34, 20);
            this.power.TabIndex = 11;
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(81, 50);
            this.attack.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(34, 20);
            this.attack.TabIndex = 12;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(81, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 13;
            // 
            // traitsdisplay
            // 
            this.traitsdisplay.FormattingEnabled = true;
            this.traitsdisplay.Location = new System.Drawing.Point(15, 270);
            this.traitsdisplay.Name = "traitsdisplay";
            this.traitsdisplay.Size = new System.Drawing.Size(120, 95);
            this.traitsdisplay.TabIndex = 14;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(25, 395);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 15;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(106, 395);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "close";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // morale
            // 
            this.morale.Location = new System.Drawing.Point(81, 184);
            this.morale.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.morale.Name = "morale";
            this.morale.Size = new System.Drawing.Size(34, 20);
            this.morale.TabIndex = 17;
            // 
            // traitsl
            // 
            this.traitsl.AutoSize = true;
            this.traitsl.Location = new System.Drawing.Point(12, 217);
            this.traitsl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.traitsl.Name = "traitsl";
            this.traitsl.Size = new System.Drawing.Size(33, 13);
            this.traitsl.TabIndex = 18;
            this.traitsl.Text = "Traits";
            // 
            // addTrait
            // 
            this.addTrait.Location = new System.Drawing.Point(142, 243);
            this.addTrait.Name = "addTrait";
            this.addTrait.Size = new System.Drawing.Size(48, 54);
            this.addTrait.TabIndex = 19;
            this.addTrait.Text = "+";
            this.addTrait.UseVisualStyleBackColor = true;
            this.addTrait.Click += new System.EventHandler(this.AddTrait_Click);
            // 
            // removeTrait
            // 
            this.removeTrait.Location = new System.Drawing.Point(142, 312);
            this.removeTrait.Name = "removeTrait";
            this.removeTrait.Size = new System.Drawing.Size(48, 53);
            this.removeTrait.TabIndex = 20;
            this.removeTrait.Text = "-";
            this.removeTrait.UseVisualStyleBackColor = true;
            this.removeTrait.Click += new System.EventHandler(this.RemoveTrait_Click);
            // 
            // AncestryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 447);
            this.Controls.Add(this.removeTrait);
            this.Controls.Add(this.addTrait);
            this.Controls.Add(this.traitsl);
            this.Controls.Add(this.morale);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.traitsdisplay);
            this.Controls.Add(this.name);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.power);
            this.Controls.Add(this.defense);
            this.Controls.Add(this.toughness);
            this.Controls.Add(this.moralel);
            this.Controls.Add(this.traitscbox);
            this.Controls.Add(this.toughnessl);
            this.Controls.Add(this.defesel);
            this.Controls.Add(this.powerl);
            this.Controls.Add(this.atkl);
            this.Controls.Add(this.label2);
            this.Name = "AncestryAdd";
            this.Text = "AncestryAdd";
            ((System.ComponentModel.ISupportInitialize)(this.toughness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label atkl;
        private System.Windows.Forms.Label powerl;
        private System.Windows.Forms.Label defesel;
        private System.Windows.Forms.Label toughnessl;
        private System.Windows.Forms.ComboBox traitscbox;
        private System.Windows.Forms.Label moralel;
        private System.Windows.Forms.NumericUpDown toughness;
        private System.Windows.Forms.NumericUpDown defense;
        private System.Windows.Forms.NumericUpDown power;
        private System.Windows.Forms.NumericUpDown attack;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ListBox traitsdisplay;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown morale;
        private System.Windows.Forms.Label traitsl;
        private System.Windows.Forms.Button addTrait;
        private System.Windows.Forms.Button removeTrait;
    }
}
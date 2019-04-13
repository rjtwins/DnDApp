namespace DnDApp2
{
    partial class SizeAdd
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
            this.afterd = new System.Windows.Forms.NumericUpDown();
            this.befored = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.defesel = new System.Windows.Forms.Label();
            this.costMod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.afterd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.befored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costMod)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size";
            // 
            // atkl
            // 
            this.atkl.AutoSize = true;
            this.atkl.Location = new System.Drawing.Point(93, 19);
            this.atkl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.atkl.Name = "atkl";
            this.atkl.Size = new System.Drawing.Size(13, 13);
            this.atkl.TabIndex = 2;
            this.atkl.Text = "d";
            // 
            // afterd
            // 
            this.afterd.Location = new System.Drawing.Point(112, 17);
            this.afterd.Name = "afterd";
            this.afterd.Size = new System.Drawing.Size(34, 20);
            this.afterd.TabIndex = 11;
            // 
            // befored
            // 
            this.befored.Location = new System.Drawing.Point(56, 17);
            this.befored.Name = "befored";
            this.befored.Size = new System.Drawing.Size(31, 20);
            this.befored.TabIndex = 12;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(15, 93);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 15;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(96, 93);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "close";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // defesel
            // 
            this.defesel.AutoSize = true;
            this.defesel.Location = new System.Drawing.Point(12, 52);
            this.defesel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.defesel.Name = "defesel";
            this.defesel.Size = new System.Drawing.Size(52, 13);
            this.defesel.TabIndex = 4;
            this.defesel.Text = "Cost Mod";
            // 
            // costMod
            // 
            this.costMod.DecimalPlaces = 2;
            this.costMod.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.costMod.Location = new System.Drawing.Point(81, 50);
            this.costMod.Name = "costMod";
            this.costMod.Size = new System.Drawing.Size(49, 20);
            this.costMod.TabIndex = 10;
            // 
            // SizeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 136);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.befored);
            this.Controls.Add(this.afterd);
            this.Controls.Add(this.costMod);
            this.Controls.Add(this.defesel);
            this.Controls.Add(this.atkl);
            this.Controls.Add(this.label2);
            this.Name = "SizeAdd";
            this.ShowIcon = false;
            this.Text = "Add Unit Type";
            ((System.ComponentModel.ISupportInitialize)(this.afterd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.befored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label atkl;
        private System.Windows.Forms.NumericUpDown afterd;
        private System.Windows.Forms.NumericUpDown befored;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label defesel;
        private System.Windows.Forms.NumericUpDown costMod;
    }
}
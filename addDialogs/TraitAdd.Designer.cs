namespace DnDApp2
{
    partial class TraitAdd
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
            this.namel = new System.Windows.Forms.Label();
            this.descl = new System.Windows.Forms.Label();
            this.costl = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.descBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.SuspendLayout();
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(12, 19);
            this.namel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(35, 13);
            this.namel.TabIndex = 1;
            this.namel.Text = "Name";
            // 
            // descl
            // 
            this.descl.AutoSize = true;
            this.descl.Location = new System.Drawing.Point(12, 52);
            this.descl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.descl.Name = "descl";
            this.descl.Size = new System.Drawing.Size(60, 13);
            this.descl.TabIndex = 2;
            this.descl.Text = "Description";
            // 
            // costl
            // 
            this.costl.AutoSize = true;
            this.costl.Location = new System.Drawing.Point(12, 312);
            this.costl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.costl.Name = "costl";
            this.costl.Size = new System.Drawing.Size(28, 13);
            this.costl.TabIndex = 3;
            this.costl.Text = "Cost";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(66, 310);
            this.cost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(65, 20);
            this.cost.TabIndex = 11;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(53, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 13;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 338);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 15;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(93, 338);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "close";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(15, 78);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(439, 211);
            this.descBox.TabIndex = 17;
            // 
            // TraitAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 377);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.costl);
            this.Controls.Add(this.descl);
            this.Controls.Add(this.namel);
            this.Name = "TraitAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add Trait";
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label descl;
        private System.Windows.Forms.Label costl;
        private System.Windows.Forms.NumericUpDown cost;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox descBox;
    }
}
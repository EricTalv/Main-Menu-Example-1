namespace ET_MME_1
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
            this.CBX_Categories = new System.Windows.Forms.ComboBox();
            this.LBX_Choices = new System.Windows.Forms.ListBox();
            this.L_Description = new System.Windows.Forms.Label();
            this.L_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBX_Categories
            // 
            this.CBX_Categories.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CBX_Categories.FormattingEnabled = true;
            this.CBX_Categories.Items.AddRange(new object[] {
            "(choose a category!)"});
            this.CBX_Categories.Location = new System.Drawing.Point(12, 12);
            this.CBX_Categories.Name = "CBX_Categories";
            this.CBX_Categories.Size = new System.Drawing.Size(188, 23);
            this.CBX_Categories.TabIndex = 0;
            this.CBX_Categories.Text = "(Choose a Category!)";
            this.CBX_Categories.SelectedIndexChanged += new System.EventHandler(this.CBX_Categories_SelectedIndexChanged);
            // 
            // LBX_Choices
            // 
            this.LBX_Choices.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LBX_Choices.FormattingEnabled = true;
            this.LBX_Choices.ItemHeight = 18;
            this.LBX_Choices.Location = new System.Drawing.Point(12, 39);
            this.LBX_Choices.Name = "LBX_Choices";
            this.LBX_Choices.Size = new System.Drawing.Size(188, 418);
            this.LBX_Choices.TabIndex = 2;
            this.LBX_Choices.SelectedIndexChanged += new System.EventHandler(this.LBX_Choices_SelectedIndexChanged);
            // 
            // L_Description
            // 
            this.L_Description.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Description.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.L_Description.Location = new System.Drawing.Point(206, 39);
            this.L_Description.Name = "L_Description";
            this.L_Description.Size = new System.Drawing.Size(384, 418);
            this.L_Description.TabIndex = 7;
            // 
            // L_Title
            // 
            this.L_Title.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.L_Title.Location = new System.Drawing.Point(206, 11);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(384, 22);
            this.L_Title.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(602, 473);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.L_Description);
            this.Controls.Add(this.LBX_Choices);
            this.Controls.Add(this.CBX_Categories);
            this.Name = "Form1";
            this.Text = "Main Menu Example 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_Categories;
        private System.Windows.Forms.ListBox LBX_Choices;
        private System.Windows.Forms.Label L_Description;
        private System.Windows.Forms.Label L_Title;
    }
}


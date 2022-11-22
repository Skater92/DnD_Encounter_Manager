namespace DnD_Encounter_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddMonBtn = new System.Windows.Forms.Button();
            this.DisplayMonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica 55 Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "DnD Encounter Manager v0.1 (c) DeadPeopleLabs 2022";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "MAIN MENU";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(191, 143);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(133, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save Files";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMonBtn
            // 
            this.AddMonBtn.Location = new System.Drawing.Point(191, 226);
            this.AddMonBtn.Name = "AddMonBtn";
            this.AddMonBtn.Size = new System.Drawing.Size(133, 23);
            this.AddMonBtn.TabIndex = 6;
            this.AddMonBtn.Text = "Add Monster";
            this.AddMonBtn.UseVisualStyleBackColor = true;
            // 
            // DisplayMonBtn
            // 
            this.DisplayMonBtn.Location = new System.Drawing.Point(191, 316);
            this.DisplayMonBtn.Name = "DisplayMonBtn";
            this.DisplayMonBtn.Size = new System.Drawing.Size(133, 23);
            this.DisplayMonBtn.TabIndex = 7;
            this.DisplayMonBtn.Text = "Display Monster";
            this.DisplayMonBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 536);
            this.Controls.Add(this.DisplayMonBtn);
            this.Controls.Add(this.AddMonBtn);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button SaveButton;
        private Button AddMonBtn;
        private Button DisplayMonBtn;
    }
}
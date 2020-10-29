namespace InClassAssignment6
{
    partial class frmDice
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
            this.btnRoleDice = new System.Windows.Forms.Button();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRoleDice
            // 
            this.btnRoleDice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleDice.Location = new System.Drawing.Point(347, 55);
            this.btnRoleDice.Name = "btnRoleDice";
            this.btnRoleDice.Size = new System.Drawing.Size(98, 34);
            this.btnRoleDice.TabIndex = 0;
            this.btnRoleDice.Text = "Role Dice";
            this.btnRoleDice.UseVisualStyleBackColor = true;
            this.btnRoleDice.Click += new System.EventHandler(this.btnRoleDice_Click);
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Consolas", 12F);
            this.lblDice1.Location = new System.Drawing.Point(242, 131);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(63, 19);
            this.lblDice1.TabIndex = 1;
            this.lblDice1.Text = "label1";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Consolas", 12F);
            this.lblDice2.Location = new System.Drawing.Point(483, 131);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(63, 19);
            this.lblDice2.TabIndex = 2;
            this.lblDice2.Text = "label2";
            // 
            // frmDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InClassAssignment6.Properties.Resources._60778039_3d_rendering_red_dice_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.btnRoleDice);
            this.Name = "frmDice";
            this.Text = "Dice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoleDice;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
    }
}


namespace L15GUI
{
    partial class pizzaShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaShop));
            this.cmdLaunchOderForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdLauchCalculator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLaunchOderForm
            // 
            this.cmdLaunchOderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLaunchOderForm.Location = new System.Drawing.Point(53, 66);
            this.cmdLaunchOderForm.Name = "cmdLaunchOderForm";
            this.cmdLaunchOderForm.Size = new System.Drawing.Size(310, 103);
            this.cmdLaunchOderForm.TabIndex = 0;
            this.cmdLaunchOderForm.Text = "Order Form";
            this.cmdLaunchOderForm.UseVisualStyleBackColor = true;
            this.cmdLaunchOderForm.Click += new System.EventHandler(this.cmdLaunchOderForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdLauchCalculator
            // 
            this.cmdLauchCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLauchCalculator.Location = new System.Drawing.Point(53, 196);
            this.cmdLauchCalculator.Name = "cmdLauchCalculator";
            this.cmdLauchCalculator.Size = new System.Drawing.Size(310, 96);
            this.cmdLauchCalculator.TabIndex = 3;
            this.cmdLauchCalculator.Text = "Calculator";
            this.cmdLauchCalculator.UseVisualStyleBackColor = true;
            this.cmdLauchCalculator.Click += new System.EventHandler(this.cmdLauchCalculator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hoskote Pizza Store";
            // 
            // pizzaShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdLauchCalculator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdLaunchOderForm);
            this.Name = "pizzaShop";
            this.Text = "Pizza Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLaunchOderForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdLauchCalculator;
        private System.Windows.Forms.Label label1;
    }
}


namespace L15GUI
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxMobile = new System.Windows.Forms.TextBox();
            this.tbxZIP = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbXLarge = new System.Windows.Forms.RadioButton();
            this.chkExtraChesse = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.grpDevlivery = new System.Windows.Forms.GroupBox();
            this.rbDeliveryYes = new System.Windows.Forms.RadioButton();
            this.rbDeliveryNo = new System.Windows.Forms.RadioButton();
            this.lblTip = new System.Windows.Forms.Label();
            this.tbxTip = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdSaveOrder = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpDevlivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ZIP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(67, 10);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 6;
            // 
            // tbxMobile
            // 
            this.tbxMobile.Location = new System.Drawing.Point(67, 140);
            this.tbxMobile.Name = "tbxMobile";
            this.tbxMobile.Size = new System.Drawing.Size(100, 20);
            this.tbxMobile.TabIndex = 7;
            // 
            // tbxZIP
            // 
            this.tbxZIP.Location = new System.Drawing.Point(67, 114);
            this.tbxZIP.Name = "tbxZIP";
            this.tbxZIP.Size = new System.Drawing.Size(100, 20);
            this.tbxZIP.TabIndex = 8;
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(67, 88);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(100, 20);
            this.tbxState.TabIndex = 9;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(67, 62);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 20);
            this.tbxCity.TabIndex = 10;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(67, 36);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxAddress.TabIndex = 11;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rbXLarge);
            this.grpSize.Controls.Add(this.rbLarge);
            this.grpSize.Controls.Add(this.rbMedium);
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.Location = new System.Drawing.Point(184, 10);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(235, 150);
            this.grpSize.TabIndex = 12;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Pizza Size:";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomato);
            this.grpToppings.Controls.Add(this.chkSausage);
            this.grpToppings.Controls.Add(this.chkExtraChesse);
            this.grpToppings.Location = new System.Drawing.Point(425, 10);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(235, 150);
            this.grpToppings.TabIndex = 13;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings:";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 19);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(68, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small: $8";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(7, 54);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(86, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Medium: $10";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(7, 86);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(76, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Text = "Large: $14";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbXLarge
            // 
            this.rbXLarge.AutoSize = true;
            this.rbXLarge.Location = new System.Drawing.Point(7, 121);
            this.rbXLarge.Name = "rbXLarge";
            this.rbXLarge.Size = new System.Drawing.Size(86, 17);
            this.rbXLarge.TabIndex = 3;
            this.rbXLarge.Text = "X-Large: $18";
            this.rbXLarge.UseVisualStyleBackColor = true;
            // 
            // chkExtraChesse
            // 
            this.chkExtraChesse.AutoSize = true;
            this.chkExtraChesse.Location = new System.Drawing.Point(7, 19);
            this.chkExtraChesse.Name = "chkExtraChesse";
            this.chkExtraChesse.Size = new System.Drawing.Size(88, 17);
            this.chkExtraChesse.TabIndex = 0;
            this.chkExtraChesse.Text = "Extra Chesse";
            this.chkExtraChesse.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(7, 121);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(68, 17);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(7, 86);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(62, 17);
            this.chkTomato.TabIndex = 2;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(7, 51);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // grpDevlivery
            // 
            this.grpDevlivery.Controls.Add(this.rbDeliveryNo);
            this.grpDevlivery.Controls.Add(this.rbDeliveryYes);
            this.grpDevlivery.Location = new System.Drawing.Point(16, 175);
            this.grpDevlivery.Name = "grpDevlivery";
            this.grpDevlivery.Size = new System.Drawing.Size(109, 74);
            this.grpDevlivery.TabIndex = 14;
            this.grpDevlivery.TabStop = false;
            this.grpDevlivery.Text = "Devlivery?  ($5)";
            // 
            // rbDeliveryYes
            // 
            this.rbDeliveryYes.AutoSize = true;
            this.rbDeliveryYes.Checked = true;
            this.rbDeliveryYes.Location = new System.Drawing.Point(6, 19);
            this.rbDeliveryYes.Name = "rbDeliveryYes";
            this.rbDeliveryYes.Size = new System.Drawing.Size(43, 17);
            this.rbDeliveryYes.TabIndex = 0;
            this.rbDeliveryYes.TabStop = true;
            this.rbDeliveryYes.Text = "Yes";
            this.rbDeliveryYes.UseVisualStyleBackColor = true;
            // 
            // rbDeliveryNo
            // 
            this.rbDeliveryNo.AutoSize = true;
            this.rbDeliveryNo.Location = new System.Drawing.Point(6, 42);
            this.rbDeliveryNo.Name = "rbDeliveryNo";
            this.rbDeliveryNo.Size = new System.Drawing.Size(39, 17);
            this.rbDeliveryNo.TabIndex = 1;
            this.rbDeliveryNo.Text = "No";
            this.rbDeliveryNo.UseVisualStyleBackColor = true;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(132, 175);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(25, 13);
            this.lblTip.TabIndex = 15;
            this.lblTip.Text = "Tip:";
            // 
            // tbxTip
            // 
            this.tbxTip.Location = new System.Drawing.Point(167, 172);
            this.tbxTip.Name = "tbxTip";
            this.tbxTip.Size = new System.Drawing.Size(100, 20);
            this.tbxTip.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(131, 214);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total:";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(131, 237);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(94, 33);
            this.cmdCalculate.TabIndex = 18;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdSaveOrder
            // 
            this.cmdSaveOrder.Location = new System.Drawing.Point(243, 237);
            this.cmdSaveOrder.Name = "cmdSaveOrder";
            this.cmdSaveOrder.Size = new System.Drawing.Size(99, 33);
            this.cmdSaveOrder.TabIndex = 19;
            this.cmdSaveOrder.Text = "Save Order";
            this.cmdSaveOrder.UseVisualStyleBackColor = true;
            this.cmdSaveOrder.Click += new System.EventHandler(this.cmdSaveOrder_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(412, 194);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(68, 73);
            this.lblTimer.TabIndex = 20;
            this.lblTimer.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Seconds";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 327);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.cmdSaveOrder);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.tbxTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.grpDevlivery);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxState);
            this.Controls.Add(this.tbxZIP);
            this.Controls.Add(this.tbxMobile);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpDevlivery.ResumeLayout(false);
            this.grpDevlivery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxMobile;
        private System.Windows.Forms.TextBox tbxZIP;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.RadioButton rbXLarge;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkExtraChesse;
        private System.Windows.Forms.GroupBox grpDevlivery;
        private System.Windows.Forms.RadioButton rbDeliveryNo;
        private System.Windows.Forms.RadioButton rbDeliveryYes;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox tbxTip;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdSaveOrder;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
namespace AutoMobileRepair
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_line = new System.Windows.Forms.Label();
            this.lbl_ttlcost = new System.Windows.Forms.Label();
            this.lbl_ttlinfo = new System.Windows.Forms.Label();
            this.lbl_grandamt = new System.Windows.Forms.Label();
            this.lbl_ttlvat = new System.Windows.Forms.Label();
            this.lbl_ttllabourvat = new System.Windows.Forms.Label();
            this.lbl_ttlsuppliesvat = new System.Windows.Forms.Label();
            this.lbl_ttlpartsvat = new System.Windows.Forms.Label();
            this.lbl_grandtotal = new System.Windows.Forms.Label();
            this.lbl_totalvat = new System.Windows.Forms.Label();
            this.lbl_labourvat = new System.Windows.Forms.Label();
            this.lbl_suppliesvat = new System.Windows.Forms.Label();
            this.lbl_partsvat = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_totalcost = new System.Windows.Forms.Label();
            this.txt_hourrate = new System.Windows.Forms.TextBox();
            this.txt_timereq = new System.Windows.Forms.TextBox();
            this.txt_supplies = new System.Windows.Forms.TextBox();
            this.txt_repairparts = new System.Windows.Forms.TextBox();
            this.lbl_hourrate = new System.Windows.Forms.Label();
            this.lbl_timereq = new System.Windows.Forms.Label();
            this.lbl_supplies = new System.Windows.Forms.Label();
            this.lbl_repairparts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Michale Automobile Repair Workshop";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_line);
            this.groupBox1.Controls.Add(this.lbl_ttlcost);
            this.groupBox1.Controls.Add(this.lbl_ttlinfo);
            this.groupBox1.Controls.Add(this.lbl_grandamt);
            this.groupBox1.Controls.Add(this.lbl_ttlvat);
            this.groupBox1.Controls.Add(this.lbl_ttllabourvat);
            this.groupBox1.Controls.Add(this.lbl_ttlsuppliesvat);
            this.groupBox1.Controls.Add(this.lbl_ttlpartsvat);
            this.groupBox1.Controls.Add(this.lbl_grandtotal);
            this.groupBox1.Controls.Add(this.lbl_totalvat);
            this.groupBox1.Controls.Add(this.lbl_labourvat);
            this.groupBox1.Controls.Add(this.lbl_suppliesvat);
            this.groupBox1.Controls.Add(this.lbl_partsvat);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_calculate);
            this.groupBox1.Controls.Add(this.lbl_totalcost);
            this.groupBox1.Controls.Add(this.txt_hourrate);
            this.groupBox1.Controls.Add(this.txt_timereq);
            this.groupBox1.Controls.Add(this.txt_supplies);
            this.groupBox1.Controls.Add(this.txt_repairparts);
            this.groupBox1.Controls.Add(this.lbl_hourrate);
            this.groupBox1.Controls.Add(this.lbl_timereq);
            this.groupBox1.Controls.Add(this.lbl_supplies);
            this.groupBox1.Controls.Add(this.lbl_repairparts);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estimate Guide";
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(462, 204);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(353, 17);
            this.lbl_line.TabIndex = 25;
            this.lbl_line.Text = "---------------------------------------------------------------------";
            // 
            // lbl_ttlcost
            // 
            this.lbl_ttlcost.AutoSize = true;
            this.lbl_ttlcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttlcost.Location = new System.Drawing.Point(728, 264);
            this.lbl_ttlcost.Name = "lbl_ttlcost";
            this.lbl_ttlcost.Size = new System.Drawing.Size(16, 17);
            this.lbl_ttlcost.TabIndex = 24;
            this.lbl_ttlcost.Text = "0";
            // 
            // lbl_ttlinfo
            // 
            this.lbl_ttlinfo.AutoSize = true;
            this.lbl_ttlinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttlinfo.Location = new System.Drawing.Point(480, 264);
            this.lbl_ttlinfo.Name = "lbl_ttlinfo";
            this.lbl_ttlinfo.Size = new System.Drawing.Size(242, 17);
            this.lbl_ttlinfo.TabIndex = 23;
            this.lbl_ttlinfo.Text = "(Parts+Supplies+Labour)                  :";
            // 
            // lbl_grandamt
            // 
            this.lbl_grandamt.AutoSize = true;
            this.lbl_grandamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grandamt.Location = new System.Drawing.Point(690, 307);
            this.lbl_grandamt.Name = "lbl_grandamt";
            this.lbl_grandamt.Size = new System.Drawing.Size(29, 31);
            this.lbl_grandamt.TabIndex = 22;
            this.lbl_grandamt.Text = "0";
            // 
            // lbl_ttlvat
            // 
            this.lbl_ttlvat.AutoSize = true;
            this.lbl_ttlvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttlvat.Location = new System.Drawing.Point(728, 221);
            this.lbl_ttlvat.Name = "lbl_ttlvat";
            this.lbl_ttlvat.Size = new System.Drawing.Size(16, 17);
            this.lbl_ttlvat.TabIndex = 21;
            this.lbl_ttlvat.Text = "0";
            // 
            // lbl_ttllabourvat
            // 
            this.lbl_ttllabourvat.AutoSize = true;
            this.lbl_ttllabourvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttllabourvat.Location = new System.Drawing.Point(728, 168);
            this.lbl_ttllabourvat.Name = "lbl_ttllabourvat";
            this.lbl_ttllabourvat.Size = new System.Drawing.Size(16, 17);
            this.lbl_ttllabourvat.TabIndex = 20;
            this.lbl_ttllabourvat.Text = "0";
            // 
            // lbl_ttlsuppliesvat
            // 
            this.lbl_ttlsuppliesvat.AutoSize = true;
            this.lbl_ttlsuppliesvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttlsuppliesvat.Location = new System.Drawing.Point(728, 115);
            this.lbl_ttlsuppliesvat.Name = "lbl_ttlsuppliesvat";
            this.lbl_ttlsuppliesvat.Size = new System.Drawing.Size(16, 17);
            this.lbl_ttlsuppliesvat.TabIndex = 19;
            this.lbl_ttlsuppliesvat.Text = "0";
            // 
            // lbl_ttlpartsvat
            // 
            this.lbl_ttlpartsvat.AutoSize = true;
            this.lbl_ttlpartsvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ttlpartsvat.Location = new System.Drawing.Point(728, 64);
            this.lbl_ttlpartsvat.Name = "lbl_ttlpartsvat";
            this.lbl_ttlpartsvat.Size = new System.Drawing.Size(16, 17);
            this.lbl_ttlpartsvat.TabIndex = 18;
            this.lbl_ttlpartsvat.Text = "0";
            // 
            // lbl_grandtotal
            // 
            this.lbl_grandtotal.AutoSize = true;
            this.lbl_grandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grandtotal.Location = new System.Drawing.Point(478, 307);
            this.lbl_grandtotal.Name = "lbl_grandtotal";
            this.lbl_grandtotal.Size = new System.Drawing.Size(172, 31);
            this.lbl_grandtotal.TabIndex = 17;
            this.lbl_grandtotal.Text = "Grand Total :";
            // 
            // lbl_totalvat
            // 
            this.lbl_totalvat.AutoSize = true;
            this.lbl_totalvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalvat.Location = new System.Drawing.Point(480, 221);
            this.lbl_totalvat.Name = "lbl_totalvat";
            this.lbl_totalvat.Size = new System.Drawing.Size(242, 17);
            this.lbl_totalvat.TabIndex = 16;
            this.lbl_totalvat.Text = "Total Tax to be paid                          :";
            // 
            // lbl_labourvat
            // 
            this.lbl_labourvat.AutoSize = true;
            this.lbl_labourvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_labourvat.Location = new System.Drawing.Point(480, 168);
            this.lbl_labourvat.Name = "lbl_labourvat";
            this.lbl_labourvat.Size = new System.Drawing.Size(244, 17);
            this.lbl_labourvat.TabIndex = 15;
            this.lbl_labourvat.Text = "Vat Applied on Labour (GST 5%)      :";
            // 
            // lbl_suppliesvat
            // 
            this.lbl_suppliesvat.AutoSize = true;
            this.lbl_suppliesvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suppliesvat.Location = new System.Drawing.Point(480, 115);
            this.lbl_suppliesvat.Name = "lbl_suppliesvat";
            this.lbl_suppliesvat.Size = new System.Drawing.Size(245, 17);
            this.lbl_suppliesvat.TabIndex = 14;
            this.lbl_suppliesvat.Text = "Vat Applied on Supplies (GST 7%)    :";
            // 
            // lbl_partsvat
            // 
            this.lbl_partsvat.AutoSize = true;
            this.lbl_partsvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partsvat.Location = new System.Drawing.Point(480, 64);
            this.lbl_partsvat.Name = "lbl_partsvat";
            this.lbl_partsvat.Size = new System.Drawing.Size(244, 17);
            this.lbl_partsvat.TabIndex = 13;
            this.lbl_partsvat.Text = "Vat Applied on Parts (GST 5%)         :";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(515, 395);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 25);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(350, 395);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 25);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(187, 395);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 25);
            this.btn_calculate.TabIndex = 10;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_totalcost
            // 
            this.lbl_totalcost.AutoSize = true;
            this.lbl_totalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalcost.Location = new System.Drawing.Point(480, 247);
            this.lbl_totalcost.Name = "lbl_totalcost";
            this.lbl_totalcost.Size = new System.Drawing.Size(76, 17);
            this.lbl_totalcost.TabIndex = 8;
            this.lbl_totalcost.Text = "Total Cost ";
            // 
            // txt_hourrate
            // 
            this.txt_hourrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hourrate.Location = new System.Drawing.Point(268, 218);
            this.txt_hourrate.Name = "txt_hourrate";
            this.txt_hourrate.Size = new System.Drawing.Size(136, 23);
            this.txt_hourrate.TabIndex = 7;
            // 
            // txt_timereq
            // 
            this.txt_timereq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timereq.Location = new System.Drawing.Point(268, 165);
            this.txt_timereq.Name = "txt_timereq";
            this.txt_timereq.Size = new System.Drawing.Size(136, 23);
            this.txt_timereq.TabIndex = 6;
            // 
            // txt_supplies
            // 
            this.txt_supplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplies.Location = new System.Drawing.Point(268, 112);
            this.txt_supplies.Name = "txt_supplies";
            this.txt_supplies.Size = new System.Drawing.Size(136, 23);
            this.txt_supplies.TabIndex = 5;
            // 
            // txt_repairparts
            // 
            this.txt_repairparts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repairparts.Location = new System.Drawing.Point(268, 61);
            this.txt_repairparts.Name = "txt_repairparts";
            this.txt_repairparts.Size = new System.Drawing.Size(136, 23);
            this.txt_repairparts.TabIndex = 4;
            // 
            // lbl_hourrate
            // 
            this.lbl_hourrate.AutoSize = true;
            this.lbl_hourrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hourrate.Location = new System.Drawing.Point(51, 221);
            this.lbl_hourrate.Name = "lbl_hourrate";
            this.lbl_hourrate.Size = new System.Drawing.Size(192, 17);
            this.lbl_hourrate.TabIndex = 3;
            this.lbl_hourrate.Text = "Labour (Per Hour)                :";
            // 
            // lbl_timereq
            // 
            this.lbl_timereq.AutoSize = true;
            this.lbl_timereq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timereq.Location = new System.Drawing.Point(51, 168);
            this.lbl_timereq.Name = "lbl_timereq";
            this.lbl_timereq.Size = new System.Drawing.Size(192, 17);
            this.lbl_timereq.TabIndex = 2;
            this.lbl_timereq.Text = "TIme Required (In Hours)     :";
            // 
            // lbl_supplies
            // 
            this.lbl_supplies.AutoSize = true;
            this.lbl_supplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplies.Location = new System.Drawing.Point(51, 115);
            this.lbl_supplies.Name = "lbl_supplies";
            this.lbl_supplies.Size = new System.Drawing.Size(194, 17);
            this.lbl_supplies.TabIndex = 1;
            this.lbl_supplies.Text = "Total Cost of Supplies           :";
            // 
            // lbl_repairparts
            // 
            this.lbl_repairparts.AutoSize = true;
            this.lbl_repairparts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repairparts.Location = new System.Drawing.Point(51, 64);
            this.lbl_repairparts.Name = "lbl_repairparts";
            this.lbl_repairparts.Size = new System.Drawing.Size(195, 17);
            this.lbl_repairparts.TabIndex = 0;
            this.lbl_repairparts.Text = "Total Cost of Repair Parts     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "---------------------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "---------------------------------------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_totalcost;
        private System.Windows.Forms.TextBox txt_hourrate;
        private System.Windows.Forms.TextBox txt_timereq;
        private System.Windows.Forms.TextBox txt_supplies;
        private System.Windows.Forms.TextBox txt_repairparts;
        private System.Windows.Forms.Label lbl_hourrate;
        private System.Windows.Forms.Label lbl_timereq;
        private System.Windows.Forms.Label lbl_supplies;
        private System.Windows.Forms.Label lbl_repairparts;
        private System.Windows.Forms.Label lbl_grandtotal;
        private System.Windows.Forms.Label lbl_totalvat;
        private System.Windows.Forms.Label lbl_labourvat;
        private System.Windows.Forms.Label lbl_suppliesvat;
        private System.Windows.Forms.Label lbl_partsvat;
        private System.Windows.Forms.Label lbl_grandamt;
        private System.Windows.Forms.Label lbl_ttlvat;
        private System.Windows.Forms.Label lbl_ttllabourvat;
        private System.Windows.Forms.Label lbl_ttlsuppliesvat;
        private System.Windows.Forms.Label lbl_ttlpartsvat;
        private System.Windows.Forms.Label lbl_ttlinfo;
        private System.Windows.Forms.Label lbl_ttlcost;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


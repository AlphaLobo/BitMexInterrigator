namespace BitMexInterrigator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetTradeableInstruments = new System.Windows.Forms.Button();
            this.lvInstruments = new System.Windows.Forms.ListView();
            this.groupBoxColumnSelections = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnGetTradeableInstruments
            // 
            this.btnGetTradeableInstruments.Location = new System.Drawing.Point(1728, 401);
            this.btnGetTradeableInstruments.Name = "btnGetTradeableInstruments";
            this.btnGetTradeableInstruments.Size = new System.Drawing.Size(167, 23);
            this.btnGetTradeableInstruments.TabIndex = 0;
            this.btnGetTradeableInstruments.Text = "Get Instruments";
            this.btnGetTradeableInstruments.UseVisualStyleBackColor = true;
            this.btnGetTradeableInstruments.Click += new System.EventHandler(this.btnGetTradeableInstruments_Click);
            // 
            // lvInstruments
            // 
            this.lvInstruments.Location = new System.Drawing.Point(1484, 12);
            this.lvInstruments.Name = "lvInstruments";
            this.lvInstruments.Size = new System.Drawing.Size(666, 353);
            this.lvInstruments.TabIndex = 1;
            this.lvInstruments.UseCompatibleStateImageBehavior = false;
            this.lvInstruments.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxColumnSelections
            // 
            this.groupBoxColumnSelections.AutoSize = true;
            this.groupBoxColumnSelections.Location = new System.Drawing.Point(12, 21);
            this.groupBoxColumnSelections.Name = "groupBoxColumnSelections";
            this.groupBoxColumnSelections.Size = new System.Drawing.Size(954, 100);
            this.groupBoxColumnSelections.TabIndex = 3;
            this.groupBoxColumnSelections.TabStop = false;
            this.groupBoxColumnSelections.Text = "Column Options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2427, 631);
            this.Controls.Add(this.groupBoxColumnSelections);
            this.Controls.Add(this.lvInstruments);
            this.Controls.Add(this.btnGetTradeableInstruments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetTradeableInstruments;
        private ListView lvInstruments;
        private GroupBox groupBoxColumnSelections;
    }
}
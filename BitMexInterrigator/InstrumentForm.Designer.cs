namespace BitMexInterrigator
{
    partial class InstrumentForm
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
            this.groupBoxColumnSelections = new System.Windows.Forms.GroupBox();
            this.dgInstruments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgInstruments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetTradeableInstruments
            // 
            this.btnGetTradeableInstruments.Location = new System.Drawing.Point(1260, 565);
            this.btnGetTradeableInstruments.Name = "btnGetTradeableInstruments";
            this.btnGetTradeableInstruments.Size = new System.Drawing.Size(167, 23);
            this.btnGetTradeableInstruments.TabIndex = 0;
            this.btnGetTradeableInstruments.Text = "Get Instruments";
            this.btnGetTradeableInstruments.UseVisualStyleBackColor = true;
            this.btnGetTradeableInstruments.Click += new System.EventHandler(this.btnGetTradeableInstruments_Click);
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
            // dgInstruments
            // 
            this.dgInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInstruments.Location = new System.Drawing.Point(1074, 3);
            this.dgInstruments.Name = "dgInstruments";
            this.dgInstruments.RowTemplate.Height = 25;
            this.dgInstruments.Size = new System.Drawing.Size(525, 520);
            this.dgInstruments.TabIndex = 4;
            // 
            // InstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 631);
            this.Controls.Add(this.dgInstruments);
            this.Controls.Add(this.groupBoxColumnSelections);
            this.Controls.Add(this.btnGetTradeableInstruments);
            this.Name = "InstrumentForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgInstruments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGetTradeableInstruments;
        private GroupBox groupBoxColumnSelections;
        private DataGridView dgInstruments;
    }
}
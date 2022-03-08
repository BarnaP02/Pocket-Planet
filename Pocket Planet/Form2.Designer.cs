
namespace Pocket_Planet
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pb_Simulation = new System.Windows.Forms.PictureBox();
            this.tmr_Lup = new System.Windows.Forms.Timer(this.components);
            this.tmr_paint = new System.Windows.Forms.Timer(this.components);
            this.lbl_log = new System.Windows.Forms.Label();
            this.lbl_log2 = new System.Windows.Forms.Label();
            this.lbl_log3 = new System.Windows.Forms.Label();
            this.lbl_log4 = new System.Windows.Forms.Label();
            this.lbl_log5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Simulation)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Simulation
            // 
            this.pb_Simulation.BackColor = System.Drawing.Color.Gray;
            this.pb_Simulation.Location = new System.Drawing.Point(2, 2);
            this.pb_Simulation.Name = "pb_Simulation";
            this.pb_Simulation.Size = new System.Drawing.Size(1290, 750);
            this.pb_Simulation.TabIndex = 0;
            this.pb_Simulation.TabStop = false;
            // 
            // tmr_Lup
            // 
            this.tmr_Lup.Enabled = true;
            this.tmr_Lup.Tick += new System.EventHandler(this.tmr_Lup_Tick);
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.ForeColor = System.Drawing.Color.Red;
            this.lbl_log.Location = new System.Drawing.Point(1350, 234);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(55, 13);
            this.lbl_log.TabIndex = 1;
            this.lbl_log.Text = "label1";
            // 
            // lbl_log2
            // 
            this.lbl_log2.AutoSize = true;
            this.lbl_log2.ForeColor = System.Drawing.Color.Red;
            this.lbl_log2.Location = new System.Drawing.Point(1350, 274);
            this.lbl_log2.Name = "lbl_log2";
            this.lbl_log2.Size = new System.Drawing.Size(55, 13);
            this.lbl_log2.TabIndex = 2;
            this.lbl_log2.Text = "label1";
            // 
            // lbl_log3
            // 
            this.lbl_log3.AutoSize = true;
            this.lbl_log3.ForeColor = System.Drawing.Color.Red;
            this.lbl_log3.Location = new System.Drawing.Point(1350, 316);
            this.lbl_log3.Name = "lbl_log3";
            this.lbl_log3.Size = new System.Drawing.Size(55, 13);
            this.lbl_log3.TabIndex = 3;
            this.lbl_log3.Text = "label1";
            // 
            // lbl_log4
            // 
            this.lbl_log4.AutoSize = true;
            this.lbl_log4.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_log4.Location = new System.Drawing.Point(1350, 350);
            this.lbl_log4.Name = "lbl_log4";
            this.lbl_log4.Size = new System.Drawing.Size(55, 13);
            this.lbl_log4.TabIndex = 4;
            this.lbl_log4.Text = "label1";
            // 
            // lbl_log5
            // 
            this.lbl_log5.AutoSize = true;
            this.lbl_log5.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_log5.Location = new System.Drawing.Point(1350, 383);
            this.lbl_log5.Name = "lbl_log5";
            this.lbl_log5.Size = new System.Drawing.Size(55, 13);
            this.lbl_log5.TabIndex = 5;
            this.lbl_log5.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1584, 755);
            this.Controls.Add(this.lbl_log5);
            this.Controls.Add(this.lbl_log4);
            this.Controls.Add(this.lbl_log3);
            this.Controls.Add(this.lbl_log2);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.pb_Simulation);
            this.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Pocket Planet";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Simulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Simulation;
        private System.Windows.Forms.Timer tmr_Lup;
        private System.Windows.Forms.Timer tmr_paint;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Label lbl_log2;
        private System.Windows.Forms.Label lbl_log3;
        private System.Windows.Forms.Label lbl_log4;
        private System.Windows.Forms.Label lbl_log5;
    }
}
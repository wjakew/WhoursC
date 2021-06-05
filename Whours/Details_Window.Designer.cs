
namespace Whours
{
    partial class Details_Window
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
            this.label_hours = new System.Windows.Forms.Label();
            this.label_payment = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_hours
            // 
            this.label_hours.AutoSize = true;
            this.label_hours.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hours.Location = new System.Drawing.Point(12, 80);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(144, 25);
            this.label_hours.TabIndex = 0;
            this.label_hours.Text = "Hours: XXX/XXX";
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_payment.Location = new System.Drawing.Point(12, 114);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(187, 25);
            this.label_payment.TabIndex = 1;
            this.label_payment.Text = "Payment: XXXXX PLN";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(13, 176);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(261, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Details_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 232);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.label_hours);
            this.Name = "Details_Window";
            this.Text = "Generated Raport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hours;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.Button button_close;
    }
}
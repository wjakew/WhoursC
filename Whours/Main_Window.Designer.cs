
namespace Whours
{
    partial class Main_Window
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
            this.button_loadfile = new System.Windows.Forms.Button();
            this.button_createtemplate = new System.Windows.Forms.Button();
            this.label_filepath = new System.Windows.Forms.Label();
            this.list_data = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.field_money = new System.Windows.Forms.TextBox();
            this.field_hours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_raportgeneration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_loadfile
            // 
            this.button_loadfile.Location = new System.Drawing.Point(618, 12);
            this.button_loadfile.Name = "button_loadfile";
            this.button_loadfile.Size = new System.Drawing.Size(170, 23);
            this.button_loadfile.TabIndex = 0;
            this.button_loadfile.Tag = "button_loadfile";
            this.button_loadfile.Text = "Load File";
            this.button_loadfile.UseVisualStyleBackColor = true;
            this.button_loadfile.Click += new System.EventHandler(this.button_loadfile_Click);
            // 
            // button_createtemplate
            // 
            this.button_createtemplate.Location = new System.Drawing.Point(490, 12);
            this.button_createtemplate.Name = "button_createtemplate";
            this.button_createtemplate.Size = new System.Drawing.Size(122, 23);
            this.button_createtemplate.TabIndex = 1;
            this.button_createtemplate.Tag = "button_createtemplate";
            this.button_createtemplate.Text = "Create Template";
            this.button_createtemplate.UseVisualStyleBackColor = true;
            // 
            // label_filepath
            // 
            this.label_filepath.AutoSize = true;
            this.label_filepath.Location = new System.Drawing.Point(13, 19);
            this.label_filepath.Name = "label_filepath";
            this.label_filepath.Size = new System.Drawing.Size(96, 15);
            this.label_filepath.TabIndex = 2;
            this.label_filepath.Tag = "label_filepath";
            this.label_filepath.Text = "File is not loaded";
            // 
            // list_data
            // 
            this.list_data.FormattingEnabled = true;
            this.list_data.ItemHeight = 15;
            this.list_data.Location = new System.Drawing.Point(12, 51);
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(776, 334);
            this.list_data.TabIndex = 3;
            this.list_data.Tag = "list_data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hourly rate";
            // 
            // field_money
            // 
            this.field_money.Location = new System.Drawing.Point(101, 392);
            this.field_money.Name = "field_money";
            this.field_money.Size = new System.Drawing.Size(100, 23);
            this.field_money.TabIndex = 5;
            this.field_money.Tag = "field_cash";
            this.field_money.Text = "18,5";
            this.field_money.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // field_hours
            // 
            this.field_hours.Location = new System.Drawing.Point(273, 392);
            this.field_hours.Name = "field_hours";
            this.field_hours.Size = new System.Drawing.Size(100, 23);
            this.field_hours.TabIndex = 6;
            this.field_hours.Tag = "field_hour";
            this.field_hours.Text = " 168";
            this.field_hours.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hour goal";
            // 
            // button_raportgeneration
            // 
            this.button_raportgeneration.Location = new System.Drawing.Point(612, 392);
            this.button_raportgeneration.Name = "button_raportgeneration";
            this.button_raportgeneration.Size = new System.Drawing.Size(176, 23);
            this.button_raportgeneration.TabIndex = 8;
            this.button_raportgeneration.Text = "Raport Generation";
            this.button_raportgeneration.UseVisualStyleBackColor = true;
            this.button_raportgeneration.Click += new System.EventHandler(this.button_raportgeneration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "v1.0.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_raportgeneration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.field_hours);
            this.Controls.Add(this.field_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_data);
            this.Controls.Add(this.label_filepath);
            this.Controls.Add(this.button_createtemplate);
            this.Controls.Add(this.button_loadfile);
            this.Name = "Main_Window";
            this.Text = "Whours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_loadfile;
        private System.Windows.Forms.Button button_createtemplate;
        private System.Windows.Forms.Label label_filepath;
        private System.Windows.Forms.ListBox list_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox field_money;
        private System.Windows.Forms.TextBox field_hours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_raportgeneration;
        private System.Windows.Forms.Label label1;
    }
}
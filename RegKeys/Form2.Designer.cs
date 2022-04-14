namespace RegKeys
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
            this.Add_Registry = new System.Windows.Forms.Button();
            this.NameReg = new System.Windows.Forms.TextBox();
            this.ValueOptions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameOptions = new System.Windows.Forms.TextBox();
            this.Add_Option = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Registry
            // 
            this.Add_Registry.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Registry.Location = new System.Drawing.Point(87, 104);
            this.Add_Registry.Name = "Add_Registry";
            this.Add_Registry.Size = new System.Drawing.Size(119, 23);
            this.Add_Registry.TabIndex = 0;
            this.Add_Registry.Text = "Добавить реестр";
            this.Add_Registry.UseVisualStyleBackColor = false;
            this.Add_Registry.Click += new System.EventHandler(this.Add_Registry_Click);
            // 
            // NameReg
            // 
            this.NameReg.BackColor = System.Drawing.SystemColors.Info;
            this.NameReg.Location = new System.Drawing.Point(137, 28);
            this.NameReg.Name = "NameReg";
            this.NameReg.Size = new System.Drawing.Size(156, 20);
            this.NameReg.TabIndex = 2;
            // 
            // ValueOptions
            // 
            this.ValueOptions.BackColor = System.Drawing.SystemColors.Info;
            this.ValueOptions.Location = new System.Drawing.Point(137, 78);
            this.ValueOptions.Name = "ValueOptions";
            this.ValueOptions.Size = new System.Drawing.Size(156, 20);
            this.ValueOptions.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название Реестра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Значение параметра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название параметра";
            // 
            // NameOptions
            // 
            this.NameOptions.BackColor = System.Drawing.SystemColors.Info;
            this.NameOptions.Location = new System.Drawing.Point(137, 54);
            this.NameOptions.Name = "NameOptions";
            this.NameOptions.Size = new System.Drawing.Size(156, 20);
            this.NameOptions.TabIndex = 6;
            // 
            // Add_Option
            // 
            this.Add_Option.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Option.Location = new System.Drawing.Point(212, 104);
            this.Add_Option.Name = "Add_Option";
            this.Add_Option.Size = new System.Drawing.Size(119, 23);
            this.Add_Option.TabIndex = 8;
            this.Add_Option.Text = "Добавить параметр";
            this.Add_Option.UseVisualStyleBackColor = false;
            this.Add_Option.Click += new System.EventHandler(this.Add_Option_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(353, 153);
            this.Controls.Add(this.Add_Option);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameOptions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueOptions);
            this.Controls.Add(this.NameReg);
            this.Controls.Add(this.Add_Registry);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Registry;
        private System.Windows.Forms.TextBox NameReg;
        private System.Windows.Forms.TextBox ValueOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameOptions;
        private System.Windows.Forms.Button Add_Option;
    }
}
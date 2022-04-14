namespace RegKeys
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add_Reg = new System.Windows.Forms.Button();
            this.GetRegVal = new System.Windows.Forms.Button();
            this.RegTree = new System.Windows.Forms.ListBox();
            this.DeleteReg = new System.Windows.Forms.Button();
            this.RegistryList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_RegTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Reg
            // 
            this.Add_Reg.BackColor = System.Drawing.SystemColors.Info;
            this.Add_Reg.Location = new System.Drawing.Point(196, 48);
            this.Add_Reg.Name = "Add_Reg";
            this.Add_Reg.Size = new System.Drawing.Size(312, 51);
            this.Add_Reg.TabIndex = 0;
            this.Add_Reg.Text = "Add Registry and Value";
            this.Add_Reg.UseVisualStyleBackColor = false;
            this.Add_Reg.Click += new System.EventHandler(this.Add_Reg_Click);
            // 
            // GetRegVal
            // 
            this.GetRegVal.BackColor = System.Drawing.SystemColors.Info;
            this.GetRegVal.Location = new System.Drawing.Point(196, 105);
            this.GetRegVal.Name = "GetRegVal";
            this.GetRegVal.Size = new System.Drawing.Size(312, 51);
            this.GetRegVal.TabIndex = 1;
            this.GetRegVal.Text = "Get Registry Value";
            this.GetRegVal.UseVisualStyleBackColor = false;
            this.GetRegVal.Click += new System.EventHandler(this.GetRegVal_Click);
            // 
            // RegTree
            // 
            this.RegTree.BackColor = System.Drawing.SystemColors.Info;
            this.RegTree.FormattingEnabled = true;
            this.RegTree.Location = new System.Drawing.Point(542, 48);
            this.RegTree.Name = "RegTree";
            this.RegTree.Size = new System.Drawing.Size(188, 108);
            this.RegTree.TabIndex = 2;
            // 
            // DeleteReg
            // 
            this.DeleteReg.BackColor = System.Drawing.SystemColors.Info;
            this.DeleteReg.Location = new System.Drawing.Point(196, 162);
            this.DeleteReg.Name = "DeleteReg";
            this.DeleteReg.Size = new System.Drawing.Size(312, 51);
            this.DeleteReg.TabIndex = 3;
            this.DeleteReg.Text = "Delete Registry";
            this.DeleteReg.UseVisualStyleBackColor = false;
            this.DeleteReg.Click += new System.EventHandler(this.DeleteReg_Click);
            // 
            // RegistryList
            // 
            this.RegistryList.BackColor = System.Drawing.SystemColors.Info;
            this.RegistryList.FormattingEnabled = true;
            this.RegistryList.Location = new System.Drawing.Point(263, 280);
            this.RegistryList.Name = "RegistryList";
            this.RegistryList.Size = new System.Drawing.Size(188, 108);
            this.RegistryList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список созданных реестров";
            // 
            // Clear_RegTree
            // 
            this.Clear_RegTree.BackColor = System.Drawing.SystemColors.Info;
            this.Clear_RegTree.Location = new System.Drawing.Point(590, 162);
            this.Clear_RegTree.Name = "Clear_RegTree";
            this.Clear_RegTree.Size = new System.Drawing.Size(93, 23);
            this.Clear_RegTree.TabIndex = 6;
            this.Clear_RegTree.Text = "Clear";
            this.Clear_RegTree.UseVisualStyleBackColor = false;
            this.Clear_RegTree.Click += new System.EventHandler(this.Clear_RegTree_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_RegTree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistryList);
            this.Controls.Add(this.DeleteReg);
            this.Controls.Add(this.RegTree);
            this.Controls.Add(this.GetRegVal);
            this.Controls.Add(this.Add_Reg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Reg;
        private System.Windows.Forms.Button GetRegVal;
        private System.Windows.Forms.ListBox RegTree;
        private System.Windows.Forms.Button DeleteReg;
        private System.Windows.Forms.ListBox RegistryList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_RegTree;
    }
}



namespace Slots
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spinButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAmmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(457, 283);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(75, 23);
            this.spinButton.TabIndex = 0;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 108);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 108);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(23, 288);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Money:";
            // 
            // labelAmmount
            // 
            this.labelAmmount.AutoSize = true;
            this.labelAmmount.Location = new System.Drawing.Point(346, 288);
            this.labelAmmount.Name = "labelAmmount";
            this.labelAmmount.Size = new System.Drawing.Size(51, 13);
            this.labelAmmount.TabIndex = 6;
            this.labelAmmount.Text = "Ammount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 318);
            this.Controls.Add(this.labelAmmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Slots by IlNevioIl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAmmount;
    }
}


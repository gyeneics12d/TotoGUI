
namespace TotoGUI
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
            this.txt = new System.Windows.Forms.TextBox();
            this.btnMentes = new System.Windows.Forms.Button();
            this.cbCharAmount = new System.Windows.Forms.CheckBox();
            this.cbInvChar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kérem a forduló eredményeit [1, 2, X]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 39);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(270, 20);
            this.txt.TabIndex = 1;
            this.txt.Text = "12X12X12X12X12";
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(12, 148);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(177, 23);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Eredmények mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // cbCharAmount
            // 
            this.cbCharAmount.AutoSize = true;
            this.cbCharAmount.Location = new System.Drawing.Point(12, 78);
            this.cbCharAmount.Name = "cbCharAmount";
            this.cbCharAmount.Size = new System.Drawing.Size(213, 17);
            this.cbCharAmount.TabIndex = 5;
            this.cbCharAmount.Text = "Nem megfelelő a karakterek száma (14)";
            this.cbCharAmount.UseVisualStyleBackColor = true;
            this.cbCharAmount.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbInvChar
            // 
            this.cbInvChar.AutoSize = true;
            this.cbInvChar.Location = new System.Drawing.Point(12, 110);
            this.cbInvChar.Name = "cbInvChar";
            this.cbInvChar.Size = new System.Drawing.Size(214, 17);
            this.cbInvChar.TabIndex = 6;
            this.cbInvChar.Text = "Helytelen karakter az eredményekben ()";
            this.cbInvChar.UseVisualStyleBackColor = true;
            this.cbInvChar.CheckedChanged += new System.EventHandler(this.cbInvChar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 201);
            this.Controls.Add(this.cbInvChar);
            this.Controls.Add(this.cbCharAmount);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Totó eredmény ellenőrző";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.CheckBox cbCharAmount;
        private System.Windows.Forms.CheckBox cbInvChar;
    }
}


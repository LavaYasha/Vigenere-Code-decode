namespace VijinerTableSymbl_v2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CodeTB = new System.Windows.Forms.RichTextBox();
            this.DecodeTB = new System.Windows.Forms.RichTextBox();
            this.TextLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyTB = new System.Windows.Forms.TextBox();
            this.CodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(631, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CodeTB
            // 
            this.CodeTB.Location = new System.Drawing.Point(416, 61);
            this.CodeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(204, 296);
            this.CodeTB.TabIndex = 1;
            this.CodeTB.Text = "";
            // 
            // DecodeTB
            // 
            this.DecodeTB.Location = new System.Drawing.Point(9, 61);
            this.DecodeTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecodeTB.Name = "DecodeTB";
            this.DecodeTB.Size = new System.Drawing.Size(204, 296);
            this.DecodeTB.TabIndex = 2;
            this.DecodeTB.Text = "";
            // 
            // TextLable
            // 
            this.TextLable.AutoSize = true;
            this.TextLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.TextLable.Location = new System.Drawing.Point(9, 40);
            this.TextLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextLable.Name = "TextLable";
            this.TextLable.Size = new System.Drawing.Size(100, 17);
            this.TextLable.TabIndex = 3;
            this.TextLable.Text = "Расшифровка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label2.Location = new System.Drawing.Point(413, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шифровка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label3.Location = new System.Drawing.Point(214, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ключ";
            // 
            // KeyTB
            // 
            this.KeyTB.Location = new System.Drawing.Point(217, 61);
            this.KeyTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KeyTB.Name = "KeyTB";
            this.KeyTB.Size = new System.Drawing.Size(195, 20);
            this.KeyTB.TabIndex = 6;
            // 
            // CodeButton
            // 
            this.CodeButton.Location = new System.Drawing.Point(216, 316);
            this.CodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeButton.Name = "CodeButton";
            this.CodeButton.Size = new System.Drawing.Size(81, 40);
            this.CodeButton.TabIndex = 7;
            this.CodeButton.Text = "Шифровка";
            this.CodeButton.UseVisualStyleBackColor = true;
            this.CodeButton.Click += new System.EventHandler(this.CodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(325, 316);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(87, 40);
            this.DecodeButton.TabIndex = 8;
            this.DecodeButton.Text = "Дешифровка";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.DecodeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 364);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.CodeButton);
            this.Controls.Add(this.KeyTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextLable);
            this.Controls.Add(this.DecodeTB);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox CodeTB;
        private System.Windows.Forms.RichTextBox DecodeTB;
        private System.Windows.Forms.Label TextLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KeyTB;
        private System.Windows.Forms.Button CodeButton;
        private System.Windows.Forms.Button DecodeButton;
    }
}


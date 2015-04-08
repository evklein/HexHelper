namespace HexHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.HexLabel = new System.Windows.Forms.Label();
            this.CopyHexButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.Location = new System.Drawing.Point(475, 23);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(70, 33);
            this.RedLabel.TabIndex = 2;
            this.RedLabel.Text = "Red: ";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLabel.Location = new System.Drawing.Point(475, 56);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(94, 33);
            this.GreenLabel.TabIndex = 3;
            this.GreenLabel.Text = "Green: ";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLabel.Location = new System.Drawing.Point(474, 89);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(63, 33);
            this.BlueLabel.TabIndex = 4;
            this.BlueLabel.Text = "Blue";
            // 
            // HexLabel
            // 
            this.HexLabel.AutoSize = true;
            this.HexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexLabel.Location = new System.Drawing.Point(475, 127);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(45, 20);
            this.HexLabel.TabIndex = 5;
            this.HexLabel.Text = "Hex: ";
            this.HexLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CopyHexButton
            // 
            this.CopyHexButton.Location = new System.Drawing.Point(478, 152);
            this.CopyHexButton.Name = "CopyHexButton";
            this.CopyHexButton.Size = new System.Drawing.Size(103, 23);
            this.CopyHexButton.TabIndex = 6;
            this.CopyHexButton.Text = "Copy Hex";
            this.CopyHexButton.UseVisualStyleBackColor = true;
            this.CopyHexButton.Click += new System.EventHandler(this.CopyHexButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.Location = new System.Drawing.Point(478, 181);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(103, 196);
            this.PasteButton.TabIndex = 7;
            this.PasteButton.Text = "Paste";
            this.PasteButton.UseVisualStyleBackColor = true;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageBox.Location = new System.Drawing.Point(13, 13);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(455, 364);
            this.ImageBox.TabIndex = 8;
            this.ImageBox.TabStop = false;
            this.ImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 386);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.CopyHexButton);
            this.Controls.Add(this.HexLabel);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hex Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label HexLabel;
        private System.Windows.Forms.Button CopyHexButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.PictureBox ImageBox;

    }
}


﻿namespace Nikse.SubtitleEdit.Forms.Ocr
{
    sealed partial class VobSubOcrSetItalicFactor
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBoxSubtitleImage = new System.Windows.Forms.PictureBox();
            this.contextMenuStripListview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownItalicFactor = new Nikse.SubtitleEdit.Controls.NikseUpDown();
            this.labelDescription = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtitleImage)).BeginInit();
            this.contextMenuStripListview.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(794, 366);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOK.Location = new System.Drawing.Point(713, 366);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // pictureBoxSubtitleImage
            // 
            this.pictureBoxSubtitleImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSubtitleImage.ContextMenuStrip = this.contextMenuStripListview;
            this.pictureBoxSubtitleImage.Location = new System.Drawing.Point(12, 47);
            this.pictureBoxSubtitleImage.Name = "pictureBoxSubtitleImage";
            this.pictureBoxSubtitleImage.Size = new System.Drawing.Size(857, 313);
            this.pictureBoxSubtitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSubtitleImage.TabIndex = 9;
            this.pictureBoxSubtitleImage.TabStop = false;
            // 
            // contextMenuStripListview
            // 
            this.contextMenuStripListview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsToolStripMenuItem});
            this.contextMenuStripListview.Name = "contextMenuStripListview";
            this.contextMenuStripListview.Size = new System.Drawing.Size(158, 26);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveImageAsToolStripMenuItem.Text = "Save image as...";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // numericUpDownItalicFactor
            // 
            this.numericUpDownItalicFactor.DecimalPlaces = 2;
            this.numericUpDownItalicFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownItalicFactor.Location = new System.Drawing.Point(12, 19);
            this.numericUpDownItalicFactor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownItalicFactor.Name = "numericUpDownItalicFactor";
            this.numericUpDownItalicFactor.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownItalicFactor.TabIndex = 10;
            this.numericUpDownItalicFactor.Value = new decimal(new int[] {
            31,
            0,
            0,
            131072});
            this.numericUpDownItalicFactor.ValueChanged += new System.EventHandler(this.numericUpDownItalicFactor_ValueChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(76, 21);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(529, 13);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Adjust value until text style is normal and not italic. Note that original image " +
    "should be italic.";
            // 
            // VobSubOcrSetItalicFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(881, 399);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.numericUpDownItalicFactor);
            this.Controls.Add(this.pictureBoxSubtitleImage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(783, 384);
            this.Name = "VobSubOcrSetItalicFactor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set un-italic factor";
            this.Shown += new System.EventHandler(this.VobSubOcrSetItalicFactor_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VobSubOcrSetItalicFactor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtitleImage)).EndInit();
            this.contextMenuStripListview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBoxSubtitleImage;
        private Nikse.SubtitleEdit.Controls.NikseUpDown numericUpDownItalicFactor;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListview;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
    }
}
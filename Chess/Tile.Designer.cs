﻿namespace Chess
{
    partial class Tile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PieceImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PieceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PieceImage
            // 
            this.PieceImage.BackColor = System.Drawing.Color.White;
            this.PieceImage.ErrorImage = null;
            this.PieceImage.InitialImage = null;
            this.PieceImage.Location = new System.Drawing.Point(0, 0);
            this.PieceImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PieceImage.MaximumSize = new System.Drawing.Size(48, 52);
            this.PieceImage.MinimumSize = new System.Drawing.Size(48, 52);
            this.PieceImage.Name = "PieceImage";
            this.PieceImage.Size = new System.Drawing.Size(48, 52);
            this.PieceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PieceImage.TabIndex = 0;
            this.PieceImage.TabStop = false;
            // 
            // Tile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PieceImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tile";
            this.Size = new System.Drawing.Size(48, 52);
            this.Load += new System.EventHandler(this.Tile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PieceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PieceImage;
    }
}

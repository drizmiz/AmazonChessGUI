﻿namespace AmazonChessGUI
{
    partial class SinglePlayerForm
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
            this.chessTable1 = new AmazonChessGUI.ChessTable(Game);
            this.SuspendLayout();
            // 
            // chessTable1
            // 
            this.chessTable1.Horizontal = 9;
            this.chessTable1.Location = new System.Drawing.Point(34, 39);
            this.chessTable1.Name = "chessTable1";
            this.chessTable1.Size = new System.Drawing.Size(382, 375);
            this.chessTable1.TabIndex = 0;
            this.chessTable1.Vertical = 9;
            // 
            // SinglePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chessTable1);
            this.Name = "SinglePlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单人模式";
            this.ResumeLayout(false);

        }

        #endregion

        private ChessTable chessTable1;
    }
}
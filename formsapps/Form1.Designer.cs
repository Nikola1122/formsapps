﻿namespace formsapps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stalin = new System.Windows.Forms.Button();
            this.hitler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stalin
            // 
            this.stalin.BackColor = System.Drawing.Color.Red;
            this.stalin.Location = new System.Drawing.Point(34, 212);
            this.stalin.Name = "stalin";
            this.stalin.Size = new System.Drawing.Size(75, 23);
            this.stalin.TabIndex = 0;
            this.stalin.Text = "stalin";
            this.stalin.UseVisualStyleBackColor = false;
            this.stalin.Click += new System.EventHandler(this.stalin_Click);
            // 
            // hitler
            // 
            this.hitler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hitler.Location = new System.Drawing.Point(656, 212);
            this.hitler.Name = "hitler";
            this.hitler.Size = new System.Drawing.Size(75, 23);
            this.hitler.TabIndex = 1;
            this.hitler.Text = "hitler";
            this.hitler.UseVisualStyleBackColor = false;
            this.hitler.Click += new System.EventHandler(this.hitler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(303, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "izberi strana";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hitler);
            this.Controls.Add(this.stalin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stalin;
        private System.Windows.Forms.Button hitler;
        private System.Windows.Forms.Label label1;
    }
}


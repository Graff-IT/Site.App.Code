﻿namespace Lab1
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
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.btnDefine = new System.Windows.Forms.Button();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What term do you want to look up?";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(42, 85);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(224, 22);
            this.txtTerm.TabIndex = 1;
            // 
            // btnDefine
            // 
            this.btnDefine.Location = new System.Drawing.Point(312, 85);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(75, 23);
            this.btnDefine.TabIndex = 2;
            this.btnDefine.Text = "Define";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Location = new System.Drawing.Point(39, 157);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(20, 17);
            this.lblDefinition.TabIndex = 3;
            this.lblDefinition.Text = "...";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(312, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(42, 230);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(224, 22);
            this.txtDefinition.TabIndex = 5;
            this.txtDefinition.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.btnDefine);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Label lblDefinition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDefinition;
    }
}


//
//  MainForm.cs
//  LK-Renderer
//
//  Created by ArdiMaster on 29.02.2016
//
//  Copyright (C) 2016 LK-Studios
//
//  Distributed under the terms and conditions of the MIT license.
//  You can obtain a copy of the license at https://opensource.org/licenses/MIT
//

namespace LK_Renderer
{
    partial class MainForm
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
            this.blenderVersionSelector = new System.Windows.Forms.ComboBox();
            this.labelBlndrVrsnSlctr = new System.Windows.Forms.Label();
            this.loadBlenderButton = new System.Windows.Forms.Button();
            this.unzipper = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // blenderVersionSelector
            // 
            this.blenderVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blenderVersionSelector.FormattingEnabled = true;
            this.blenderVersionSelector.Location = new System.Drawing.Point(12, 29);
            this.blenderVersionSelector.Name = "blenderVersionSelector";
            this.blenderVersionSelector.Size = new System.Drawing.Size(121, 21);
            this.blenderVersionSelector.TabIndex = 0;
            this.blenderVersionSelector.SelectedIndexChanged += new System.EventHandler(this.blenderVersionSelector_SelectedIndexChanged);
            // 
            // labelBlndrVrsnSlctr
            // 
            this.labelBlndrVrsnSlctr.AutoSize = true;
            this.labelBlndrVrsnSlctr.Location = new System.Drawing.Point(12, 9);
            this.labelBlndrVrsnSlctr.Name = "labelBlndrVrsnSlctr";
            this.labelBlndrVrsnSlctr.Size = new System.Drawing.Size(84, 13);
            this.labelBlndrVrsnSlctr.TabIndex = 1;
            this.labelBlndrVrsnSlctr.Text = "Blender Version:";
            // 
            // loadBlenderButton
            // 
            this.loadBlenderButton.Location = new System.Drawing.Point(12, 57);
            this.loadBlenderButton.Name = "loadBlenderButton";
            this.loadBlenderButton.Size = new System.Drawing.Size(121, 23);
            this.loadBlenderButton.TabIndex = 2;
            this.loadBlenderButton.Text = "Download";
            this.loadBlenderButton.UseVisualStyleBackColor = true;
            this.loadBlenderButton.Click += new System.EventHandler(this.loadBlenderButton_Click);
            // 
            // unzipper
            // 
            this.unzipper.DoWork += new System.ComponentModel.DoWorkEventHandler(this.unzipper_DoWork);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(729, 547);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(189, 16);
            this.progressBar.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 547);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Ready.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 563);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.loadBlenderButton);
            this.Controls.Add(this.labelBlndrVrsnSlctr);
            this.Controls.Add(this.blenderVersionSelector);
            this.Name = "MainForm";
            this.Text = "LK-Renderer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox blenderVersionSelector;
        private System.Windows.Forms.Label labelBlndrVrsnSlctr;
        private System.Windows.Forms.Button loadBlenderButton;
        private System.ComponentModel.BackgroundWorker unzipper;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
    }
}


﻿namespace osuEditor
{
    partial class FindReplaceForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.findPreviousButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.directionDownRadio = new System.Windows.Forms.RadioButton();
            this.directionUpRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wrapCheck = new System.Windows.Forms.CheckBox();
            this.caseCheck = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.findNextButton = new System.Windows.Forms.Button();
            this.findTextField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.replaceTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.replaceTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchTab);
            this.tabControl1.Controls.Add(this.replaceTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 166);
            this.tabControl1.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.findPreviousButton);
            this.searchTab.Controls.Add(this.groupBox3);
            this.searchTab.Controls.Add(this.groupBox2);
            this.searchTab.Controls.Add(this.closeButton);
            this.searchTab.Controls.Add(this.countButton);
            this.searchTab.Controls.Add(this.findNextButton);
            this.searchTab.Controls.Add(this.findTextField);
            this.searchTab.Controls.Add(this.label1);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(507, 140);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Find";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // findPreviousButton
            // 
            this.findPreviousButton.Location = new System.Drawing.Point(352, 36);
            this.findPreviousButton.Name = "findPreviousButton";
            this.findPreviousButton.Size = new System.Drawing.Size(145, 23);
            this.findPreviousButton.TabIndex = 7;
            this.findPreviousButton.Text = "Find Previous";
            this.findPreviousButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.directionDownRadio);
            this.groupBox3.Controls.Add(this.directionUpRadio);
            this.groupBox3.Location = new System.Drawing.Point(142, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 71);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Direction";
            // 
            // directionDownRadio
            // 
            this.directionDownRadio.AutoSize = true;
            this.directionDownRadio.Location = new System.Drawing.Point(7, 44);
            this.directionDownRadio.Name = "directionDownRadio";
            this.directionDownRadio.Size = new System.Drawing.Size(53, 17);
            this.directionDownRadio.TabIndex = 1;
            this.directionDownRadio.TabStop = true;
            this.directionDownRadio.Text = "Down";
            this.directionDownRadio.UseVisualStyleBackColor = true;
            // 
            // directionUpRadio
            // 
            this.directionUpRadio.AutoSize = true;
            this.directionUpRadio.Location = new System.Drawing.Point(7, 20);
            this.directionUpRadio.Name = "directionUpRadio";
            this.directionUpRadio.Size = new System.Drawing.Size(39, 17);
            this.directionUpRadio.TabIndex = 0;
            this.directionUpRadio.TabStop = true;
            this.directionUpRadio.Text = "Up";
            this.directionUpRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wrapCheck);
            this.groupBox2.Controls.Add(this.caseCheck);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // wrapCheck
            // 
            this.wrapCheck.AutoSize = true;
            this.wrapCheck.Location = new System.Drawing.Point(7, 44);
            this.wrapCheck.Name = "wrapCheck";
            this.wrapCheck.Size = new System.Drawing.Size(88, 17);
            this.wrapCheck.TabIndex = 1;
            this.wrapCheck.Text = "Wrap around";
            this.wrapCheck.UseVisualStyleBackColor = true;
            // 
            // caseCheck
            // 
            this.caseCheck.AutoSize = true;
            this.caseCheck.Location = new System.Drawing.Point(7, 20);
            this.caseCheck.Name = "caseCheck";
            this.caseCheck.Size = new System.Drawing.Size(82, 17);
            this.caseCheck.TabIndex = 0;
            this.caseCheck.Text = "Match case";
            this.caseCheck.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(352, 94);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(145, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(352, 65);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(145, 23);
            this.countButton.TabIndex = 6;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(352, 7);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(145, 23);
            this.findNextButton.TabIndex = 5;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // findTextField
            // 
            this.findTextField.FormattingEnabled = true;
            this.findTextField.Location = new System.Drawing.Point(92, 9);
            this.findTextField.Name = "findTextField";
            this.findTextField.Size = new System.Drawing.Size(254, 21);
            this.findTextField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // replaceTab
            // 
            this.replaceTab.Controls.Add(this.groupBox4);
            this.replaceTab.Controls.Add(this.groupBox5);
            this.replaceTab.Controls.Add(this.button5);
            this.replaceTab.Controls.Add(this.comboBox3);
            this.replaceTab.Controls.Add(this.button6);
            this.replaceTab.Controls.Add(this.button7);
            this.replaceTab.Controls.Add(this.label3);
            this.replaceTab.Controls.Add(this.comboBox4);
            this.replaceTab.Controls.Add(this.label4);
            this.replaceTab.Controls.Add(this.groupBox6);
            this.replaceTab.Location = new System.Drawing.Point(4, 22);
            this.replaceTab.Name = "replaceTab";
            this.replaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.replaceTab.Size = new System.Drawing.Size(507, 140);
            this.replaceTab.TabIndex = 1;
            this.replaceTab.Text = "Replace";
            this.replaceTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Location = new System.Drawing.Point(142, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(94, 71);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Direction";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 44);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Down";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Up";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Location = new System.Drawing.Point(6, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 71);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Options";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 44);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 17);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Wrap around";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(82, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Match case";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(352, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(92, 36);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(254, 21);
            this.comboBox3.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(352, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Replace";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(352, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(145, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Find Next";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Replace with:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(92, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(254, 21);
            this.comboBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Find what:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Location = new System.Drawing.Point(253, 56);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(250, 36);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(13, 13);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "In selection";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(99, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(145, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Replace All";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FindReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 169);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.Activated += new System.EventHandler(this.FindReplaceForm_Activated);
            this.Deactivate += new System.EventHandler(this.FindReplaceForm_Deactivate);
            this.tabControl1.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.replaceTab.ResumeLayout(false);
            this.replaceTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage replaceTab;
        private System.Windows.Forms.ComboBox findTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox wrapCheck;
        private System.Windows.Forms.CheckBox caseCheck;
        private System.Windows.Forms.RadioButton directionDownRadio;
        private System.Windows.Forms.RadioButton directionUpRadio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button findPreviousButton;
    }
}
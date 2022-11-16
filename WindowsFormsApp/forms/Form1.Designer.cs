
namespace WindowsFormsApp
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
            this.SviatskiRadioButton = new System.Windows.Forms.RadioButton();
            this.ArtuhovRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TreeNameBox = new System.Windows.Forms.TextBox();
            this.TreeAgeBox = new System.Windows.Forms.TextBox();
            this.TreeTrunkLengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TreeCrownVolubeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TreeInfoApplyButton = new System.Windows.Forms.Button();
            this.TreeGrowButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SviatskiRadioButton
            // 
            this.SviatskiRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SviatskiRadioButton.AutoSize = true;
            this.SviatskiRadioButton.Location = new System.Drawing.Point(6, 38);
            this.SviatskiRadioButton.Name = "SviatskiRadioButton";
            this.SviatskiRadioButton.Size = new System.Drawing.Size(183, 17);
            this.SviatskiRadioButton.TabIndex = 6;
            this.SviatskiRadioButton.Text = "Святский Алексей Николаевич";
            this.SviatskiRadioButton.UseVisualStyleBackColor = true;
            // 
            // ArtuhovRadioButton
            // 
            this.ArtuhovRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ArtuhovRadioButton.AutoSize = true;
            this.ArtuhovRadioButton.Checked = true;
            this.ArtuhovRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ArtuhovRadioButton.Name = "ArtuhovRadioButton";
            this.ArtuhovRadioButton.Size = new System.Drawing.Size(182, 17);
            this.ArtuhovRadioButton.TabIndex = 7;
            this.ArtuhovRadioButton.TabStop = true;
            this.ArtuhovRadioButton.Text = "Артюхов Александр Сергеевич";
            this.ArtuhovRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ArtuhovRadioButton);
            this.groupBox1.Controls.Add(this.SviatskiRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кто будет поливать дерево?";
            // 
            // TreeNameBox
            // 
            this.TreeNameBox.Location = new System.Drawing.Point(188, 17);
            this.TreeNameBox.Name = "TreeNameBox";
            this.TreeNameBox.Size = new System.Drawing.Size(77, 20);
            this.TreeNameBox.TabIndex = 10;
            this.TreeNameBox.Text = "Яблоня";
            // 
            // TreeAgeBox
            // 
            this.TreeAgeBox.Location = new System.Drawing.Point(188, 43);
            this.TreeAgeBox.Name = "TreeAgeBox";
            this.TreeAgeBox.Size = new System.Drawing.Size(77, 20);
            this.TreeAgeBox.TabIndex = 11;
            this.TreeAgeBox.Text = "10";
            this.TreeAgeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreeAgeBox_KeyPress);
            // 
            // TreeTrunkLengthBox
            // 
            this.TreeTrunkLengthBox.Location = new System.Drawing.Point(188, 69);
            this.TreeTrunkLengthBox.Name = "TreeTrunkLengthBox";
            this.TreeTrunkLengthBox.Size = new System.Drawing.Size(77, 20);
            this.TreeTrunkLengthBox.TabIndex = 12;
            this.TreeTrunkLengthBox.Text = "12";
            this.TreeTrunkLengthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreeTrunkLengthBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Название:";
            // 
            // TreeCrownVolubeBox
            // 
            this.TreeCrownVolubeBox.Location = new System.Drawing.Point(188, 95);
            this.TreeCrownVolubeBox.Name = "TreeCrownVolubeBox";
            this.TreeCrownVolubeBox.Size = new System.Drawing.Size(77, 20);
            this.TreeCrownVolubeBox.TabIndex = 14;
            this.TreeCrownVolubeBox.Text = "30";
            this.TreeCrownVolubeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreeCrownVolumeBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Длинна ствола:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Объем кроны:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TreeInfoApplyButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TreeCrownVolubeBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TreeTrunkLengthBox);
            this.groupBox2.Controls.Add(this.TreeAgeBox);
            this.groupBox2.Controls.Add(this.TreeNameBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 130);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о дереве";
            // 
            // TreeInfoApplyButton
            // 
            this.TreeInfoApplyButton.Location = new System.Drawing.Point(281, 43);
            this.TreeInfoApplyButton.Name = "TreeInfoApplyButton";
            this.TreeInfoApplyButton.Size = new System.Drawing.Size(64, 46);
            this.TreeInfoApplyButton.TabIndex = 19;
            this.TreeInfoApplyButton.Text = "ОК";
            this.TreeInfoApplyButton.UseVisualStyleBackColor = true;
            this.TreeInfoApplyButton.Click += new System.EventHandler(this.TreeInfoApplyButton_Click_1);
            // 
            // TreeGrowButton
            // 
            this.TreeGrowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TreeGrowButton.Location = new System.Drawing.Point(12, 222);
            this.TreeGrowButton.Name = "TreeGrowButton";
            this.TreeGrowButton.Size = new System.Drawing.Size(351, 30);
            this.TreeGrowButton.TabIndex = 22;
            this.TreeGrowButton.Text = "Вырастить дерево (+1 год)";
            this.TreeGrowButton.UseVisualStyleBackColor = true;
            this.TreeGrowButton.Click += new System.EventHandler(this.TreeGrowButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(369, 222);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(386, 30);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputTextBox.Location = new System.Drawing.Point(6, 19);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.Size = new System.Drawing.Size(374, 173);
            this.OutputTextBox.TabIndex = 20;
            this.OutputTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.OutputTextBox);
            this.groupBox3.Location = new System.Drawing.Point(369, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 198);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод информации о поливах и росте дерева";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(766, 264);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TreeGrowButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Вырасти дерево 1.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton SviatskiRadioButton;
        private System.Windows.Forms.RadioButton ArtuhovRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TreeNameBox;
        private System.Windows.Forms.TextBox TreeAgeBox;
        private System.Windows.Forms.TextBox TreeTrunkLengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TreeCrownVolubeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TreeInfoApplyButton;
        private System.Windows.Forms.Button TreeGrowButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}



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
            this.rbSviatski = new System.Windows.Forms.RadioButton();
            this.rbArtuhov = new System.Windows.Forms.RadioButton();
            this.gbWaterers = new System.Windows.Forms.GroupBox();
            this.tbTreeName = new System.Windows.Forms.TextBox();
            this.tbTreeAge = new System.Windows.Forms.TextBox();
            this.tbTrunkLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCrownVolube = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbTreeInfo = new System.Windows.Forms.GroupBox();
            this.bTreeInfoApply = new System.Windows.Forms.Button();
            this.bTreeGrow = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.gbOutputInfo = new System.Windows.Forms.GroupBox();
            this.gbWaterers.SuspendLayout();
            this.gbTreeInfo.SuspendLayout();
            this.gbOutputInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbSviatski
            // 
            this.rbSviatski.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSviatski.AutoSize = true;
            this.rbSviatski.Location = new System.Drawing.Point(6, 38);
            this.rbSviatski.Name = "rbSviatski";
            this.rbSviatski.Size = new System.Drawing.Size(183, 17);
            this.rbSviatski.TabIndex = 6;
            this.rbSviatski.Text = "Святский Алексей Николаевич";
            this.rbSviatski.UseVisualStyleBackColor = true;
            // 
            // rbArtuhov
            // 
            this.rbArtuhov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbArtuhov.AutoSize = true;
            this.rbArtuhov.Checked = true;
            this.rbArtuhov.Location = new System.Drawing.Point(6, 19);
            this.rbArtuhov.Name = "rbArtuhov";
            this.rbArtuhov.Size = new System.Drawing.Size(182, 17);
            this.rbArtuhov.TabIndex = 7;
            this.rbArtuhov.TabStop = true;
            this.rbArtuhov.Text = "Артюхов Александр Сергеевич";
            this.rbArtuhov.UseVisualStyleBackColor = true;
            // 
            // gbWaterers
            // 
            this.gbWaterers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbWaterers.Controls.Add(this.rbArtuhov);
            this.gbWaterers.Controls.Add(this.rbSviatski);
            this.gbWaterers.Location = new System.Drawing.Point(12, 149);
            this.gbWaterers.Name = "gbWaterers";
            this.gbWaterers.Size = new System.Drawing.Size(351, 61);
            this.gbWaterers.TabIndex = 8;
            this.gbWaterers.TabStop = false;
            this.gbWaterers.Text = "Кто будет поливать дерево?";
            // 
            // tbTreeName
            // 
            this.tbTreeName.Location = new System.Drawing.Point(188, 17);
            this.tbTreeName.Name = "tbTreeName";
            this.tbTreeName.Size = new System.Drawing.Size(77, 20);
            this.tbTreeName.TabIndex = 10;
            this.tbTreeName.Text = "Яблоня";
            // 
            // tbTreeAge
            // 
            this.tbTreeAge.Location = new System.Drawing.Point(188, 43);
            this.tbTreeAge.Name = "tbTreeAge";
            this.tbTreeAge.Size = new System.Drawing.Size(77, 20);
            this.tbTreeAge.TabIndex = 11;
            this.tbTreeAge.Text = "10";
            this.tbTreeAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreeAgeBox_KeyPress);
            // 
            // tbTrunkLength
            // 
            this.tbTrunkLength.Location = new System.Drawing.Point(188, 69);
            this.tbTrunkLength.Name = "tbTrunkLength";
            this.tbTrunkLength.Size = new System.Drawing.Size(77, 20);
            this.tbTrunkLength.TabIndex = 12;
            this.tbTrunkLength.Text = "12";
            this.tbTrunkLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreeTrunkLengthBox_KeyPress);
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
            // tbCrownVolube
            // 
            this.tbCrownVolube.Location = new System.Drawing.Point(188, 95);
            this.tbCrownVolube.Name = "tbCrownVolube";
            this.tbCrownVolube.Size = new System.Drawing.Size(77, 20);
            this.tbCrownVolube.TabIndex = 14;
            this.tbCrownVolube.Text = "30";
            this.tbCrownVolube.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TreeCrownVolumeBox_KeyPress);
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
            // gbTreeInfo
            // 
            this.gbTreeInfo.Controls.Add(this.bTreeInfoApply);
            this.gbTreeInfo.Controls.Add(this.label5);
            this.gbTreeInfo.Controls.Add(this.label4);
            this.gbTreeInfo.Controls.Add(this.label3);
            this.gbTreeInfo.Controls.Add(this.label2);
            this.gbTreeInfo.Controls.Add(this.tbCrownVolube);
            this.gbTreeInfo.Controls.Add(this.label1);
            this.gbTreeInfo.Controls.Add(this.tbTrunkLength);
            this.gbTreeInfo.Controls.Add(this.tbTreeAge);
            this.gbTreeInfo.Controls.Add(this.tbTreeName);
            this.gbTreeInfo.Location = new System.Drawing.Point(12, 12);
            this.gbTreeInfo.Name = "gbTreeInfo";
            this.gbTreeInfo.Size = new System.Drawing.Size(351, 130);
            this.gbTreeInfo.TabIndex = 19;
            this.gbTreeInfo.TabStop = false;
            this.gbTreeInfo.Text = "Информация о дереве";
            // 
            // bTreeInfoApply
            // 
            this.bTreeInfoApply.Location = new System.Drawing.Point(281, 43);
            this.bTreeInfoApply.Name = "bTreeInfoApply";
            this.bTreeInfoApply.Size = new System.Drawing.Size(64, 46);
            this.bTreeInfoApply.TabIndex = 19;
            this.bTreeInfoApply.Text = "ОК";
            this.bTreeInfoApply.UseVisualStyleBackColor = true;
            this.bTreeInfoApply.Click += new System.EventHandler(this.TreeInfoApplyButton_Click_1);
            // 
            // bTreeGrow
            // 
            this.bTreeGrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bTreeGrow.Location = new System.Drawing.Point(12, 222);
            this.bTreeGrow.Name = "bTreeGrow";
            this.bTreeGrow.Size = new System.Drawing.Size(351, 30);
            this.bTreeGrow.TabIndex = 22;
            this.bTreeGrow.Text = "Вырастить дерево (+1 год)";
            this.bTreeGrow.UseVisualStyleBackColor = true;
            this.bTreeGrow.Click += new System.EventHandler(this.TreeGrowButton_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(369, 222);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(386, 30);
            this.bClear.TabIndex = 23;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbOutput.Location = new System.Drawing.Point(6, 19);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(374, 173);
            this.tbOutput.TabIndex = 20;
            this.tbOutput.Text = "";
            // 
            // gbOutputInfo
            // 
            this.gbOutputInfo.Controls.Add(this.tbOutput);
            this.gbOutputInfo.Location = new System.Drawing.Point(369, 12);
            this.gbOutputInfo.Name = "gbOutputInfo";
            this.gbOutputInfo.Size = new System.Drawing.Size(386, 198);
            this.gbOutputInfo.TabIndex = 24;
            this.gbOutputInfo.TabStop = false;
            this.gbOutputInfo.Text = "Вывод информации о поливах и росте дерева";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(766, 264);
            this.Controls.Add(this.gbOutputInfo);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bTreeGrow);
            this.Controls.Add(this.gbTreeInfo);
            this.Controls.Add(this.gbWaterers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Вырасти дерево 1.1";
            this.gbWaterers.ResumeLayout(false);
            this.gbWaterers.PerformLayout();
            this.gbTreeInfo.ResumeLayout(false);
            this.gbTreeInfo.PerformLayout();
            this.gbOutputInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSviatski;
        private System.Windows.Forms.RadioButton rbArtuhov;
        private System.Windows.Forms.GroupBox gbWaterers;
        private System.Windows.Forms.TextBox tbTreeName;
        private System.Windows.Forms.TextBox tbTreeAge;
        private System.Windows.Forms.TextBox tbTrunkLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCrownVolube;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTreeInfo;
        private System.Windows.Forms.Button bTreeInfoApply;
        private System.Windows.Forms.Button bTreeGrow;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.GroupBox gbOutputInfo;
    }
}


namespace lttpspoiler {
    partial class MainFrame {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mapSelector = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.objective = new System.Windows.Forms.TextBox();
            this.find1 = new System.Windows.Forms.Button();
            this.find2 = new System.Windows.Forms.Button();
            this.find3 = new System.Windows.Forms.Button();
            this.find4 = new System.Windows.Forms.Button();
            this.find8 = new System.Windows.Forms.Button();
            this.find7 = new System.Windows.Forms.Button();
            this.find6 = new System.Windows.Forms.Button();
            this.find5 = new System.Windows.Forms.Button();
            this.find13 = new System.Windows.Forms.Button();
            this.find12 = new System.Windows.Forms.Button();
            this.find10 = new System.Windows.Forms.Button();
            this.find9 = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.entranceCheck = new System.Windows.Forms.CheckBox();
            this.enemiesCheck = new System.Windows.Forms.CheckBox();
            this.objectivesCheck = new System.Windows.Forms.CheckBox();
            this.itemsCheck = new System.Windows.Forms.CheckBox();
            this.mapControl = new lttpspoiler.MapControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapSelector
            // 
            this.mapSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mapSelector.FormattingEnabled = true;
            this.mapSelector.Location = new System.Drawing.Point(12, 585);
            this.mapSelector.Name = "mapSelector";
            this.mapSelector.Size = new System.Drawing.Size(209, 95);
            this.mapSelector.TabIndex = 1;
            this.mapSelector.SelectedIndexChanged += new System.EventHandler(this.mapSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maps";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.currentButton);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.objective);
            this.groupBox1.Location = new System.Drawing.Point(227, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objective";
            // 
            // currentButton
            // 
            this.currentButton.Location = new System.Drawing.Point(148, 57);
            this.currentButton.Name = "currentButton";
            this.currentButton.Size = new System.Drawing.Size(75, 23);
            this.currentButton.TabIndex = 3;
            this.currentButton.Text = "Current";
            this.currentButton.UseVisualStyleBackColor = true;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(6, 57);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(293, 57);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // objective
            // 
            this.objective.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objective.Location = new System.Drawing.Point(6, 19);
            this.objective.Multiline = true;
            this.objective.Name = "objective";
            this.objective.Size = new System.Drawing.Size(365, 32);
            this.objective.TabIndex = 0;
            // 
            // find1
            // 
            this.find1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find1.Location = new System.Drawing.Point(610, 560);
            this.find1.Margin = new System.Windows.Forms.Padding(0);
            this.find1.Name = "find1";
            this.find1.Size = new System.Drawing.Size(40, 40);
            this.find1.TabIndex = 4;
            this.find1.UseVisualStyleBackColor = true;
            this.find1.Click += new System.EventHandler(this.find_Click);
            // 
            // find2
            // 
            this.find2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find2.Location = new System.Drawing.Point(652, 560);
            this.find2.Margin = new System.Windows.Forms.Padding(0);
            this.find2.Name = "find2";
            this.find2.Size = new System.Drawing.Size(40, 40);
            this.find2.TabIndex = 5;
            this.find2.UseVisualStyleBackColor = true;
            this.find2.Click += new System.EventHandler(this.find_Click);
            // 
            // find3
            // 
            this.find3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find3.Location = new System.Drawing.Point(694, 560);
            this.find3.Margin = new System.Windows.Forms.Padding(0);
            this.find3.Name = "find3";
            this.find3.Size = new System.Drawing.Size(40, 40);
            this.find3.TabIndex = 6;
            this.find3.UseVisualStyleBackColor = true;
            this.find3.Click += new System.EventHandler(this.find_Click);
            // 
            // find4
            // 
            this.find4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find4.Location = new System.Drawing.Point(736, 560);
            this.find4.Margin = new System.Windows.Forms.Padding(0);
            this.find4.Name = "find4";
            this.find4.Size = new System.Drawing.Size(40, 40);
            this.find4.TabIndex = 7;
            this.find4.UseVisualStyleBackColor = true;
            this.find4.Click += new System.EventHandler(this.find_Click);
            // 
            // find8
            // 
            this.find8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find8.Location = new System.Drawing.Point(736, 602);
            this.find8.Margin = new System.Windows.Forms.Padding(0);
            this.find8.Name = "find8";
            this.find8.Size = new System.Drawing.Size(40, 40);
            this.find8.TabIndex = 11;
            this.find8.UseVisualStyleBackColor = true;
            this.find8.Click += new System.EventHandler(this.find_Click);
            // 
            // find7
            // 
            this.find7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find7.Location = new System.Drawing.Point(694, 602);
            this.find7.Margin = new System.Windows.Forms.Padding(0);
            this.find7.Name = "find7";
            this.find7.Size = new System.Drawing.Size(40, 40);
            this.find7.TabIndex = 10;
            this.find7.UseVisualStyleBackColor = true;
            this.find7.Click += new System.EventHandler(this.find_Click);
            // 
            // find6
            // 
            this.find6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find6.Location = new System.Drawing.Point(652, 602);
            this.find6.Margin = new System.Windows.Forms.Padding(0);
            this.find6.Name = "find6";
            this.find6.Size = new System.Drawing.Size(40, 40);
            this.find6.TabIndex = 9;
            this.find6.UseVisualStyleBackColor = true;
            this.find6.Click += new System.EventHandler(this.find_Click);
            // 
            // find5
            // 
            this.find5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find5.Location = new System.Drawing.Point(610, 602);
            this.find5.Margin = new System.Windows.Forms.Padding(0);
            this.find5.Name = "find5";
            this.find5.Size = new System.Drawing.Size(40, 40);
            this.find5.TabIndex = 8;
            this.find5.UseVisualStyleBackColor = true;
            this.find5.Click += new System.EventHandler(this.find_Click);
            // 
            // find13
            // 
            this.find13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find13.Location = new System.Drawing.Point(736, 644);
            this.find13.Margin = new System.Windows.Forms.Padding(0);
            this.find13.Name = "find13";
            this.find13.Size = new System.Drawing.Size(40, 40);
            this.find13.TabIndex = 15;
            this.find13.UseVisualStyleBackColor = true;
            this.find13.Click += new System.EventHandler(this.find_Click);
            // 
            // find12
            // 
            this.find12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find12.Location = new System.Drawing.Point(694, 644);
            this.find12.Margin = new System.Windows.Forms.Padding(0);
            this.find12.Name = "find12";
            this.find12.Size = new System.Drawing.Size(40, 40);
            this.find12.TabIndex = 14;
            this.find12.UseVisualStyleBackColor = true;
            this.find12.Click += new System.EventHandler(this.find_Click);
            // 
            // find10
            // 
            this.find10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find10.Location = new System.Drawing.Point(652, 644);
            this.find10.Margin = new System.Windows.Forms.Padding(0);
            this.find10.Name = "find10";
            this.find10.Size = new System.Drawing.Size(40, 40);
            this.find10.TabIndex = 13;
            this.find10.UseVisualStyleBackColor = true;
            this.find10.Click += new System.EventHandler(this.find_Click);
            // 
            // find9
            // 
            this.find9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.find9.Location = new System.Drawing.Point(610, 644);
            this.find9.Margin = new System.Windows.Forms.Padding(0);
            this.find9.Name = "find9";
            this.find9.Size = new System.Drawing.Size(40, 40);
            this.find9.TabIndex = 12;
            this.find9.UseVisualStyleBackColor = true;
            this.find9.Click += new System.EventHandler(this.find_Click);
            // 
            // about
            // 
            this.about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.about.Location = new System.Drawing.Point(520, 663);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(75, 23);
            this.about.TabIndex = 4;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Location = new System.Drawing.Point(233, 663);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 16;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(314, 663);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // entranceCheck
            // 
            this.entranceCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.entranceCheck.AutoSize = true;
            this.entranceCheck.Checked = global::lttpspoiler.Properties.Settings.Default.mainFrameEntranceCheck;
            this.entranceCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::lttpspoiler.Properties.Settings.Default, "mainFrameEntranceCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.entranceCheck.Location = new System.Drawing.Point(223, 544);
            this.entranceCheck.Name = "entranceCheck";
            this.entranceCheck.Size = new System.Drawing.Size(69, 17);
            this.entranceCheck.TabIndex = 21;
            this.entranceCheck.Tag = "entrances";
            this.entranceCheck.Text = "Entrance";
            this.entranceCheck.UseVisualStyleBackColor = true;
            this.entranceCheck.CheckedChanged += new System.EventHandler(this.LayerState_Changed);
            // 
            // enemiesCheck
            // 
            this.enemiesCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enemiesCheck.AutoSize = true;
            this.enemiesCheck.Checked = global::lttpspoiler.Properties.Settings.Default.mainFrameEnemiesCheck;
            this.enemiesCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::lttpspoiler.Properties.Settings.Default, "mainFrameEnemiesCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enemiesCheck.Location = new System.Drawing.Point(151, 544);
            this.enemiesCheck.Name = "enemiesCheck";
            this.enemiesCheck.Size = new System.Drawing.Size(66, 17);
            this.enemiesCheck.TabIndex = 20;
            this.enemiesCheck.Tag = "enemies";
            this.enemiesCheck.Text = "Enemies";
            this.enemiesCheck.UseVisualStyleBackColor = true;
            this.enemiesCheck.CheckedChanged += new System.EventHandler(this.LayerState_Changed);
            // 
            // objectivesCheck
            // 
            this.objectivesCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.objectivesCheck.AutoSize = true;
            this.objectivesCheck.Checked = global::lttpspoiler.Properties.Settings.Default.mainFrameObjectivesCheck;
            this.objectivesCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::lttpspoiler.Properties.Settings.Default, "mainFrameObjectivesCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.objectivesCheck.Location = new System.Drawing.Point(69, 544);
            this.objectivesCheck.Name = "objectivesCheck";
            this.objectivesCheck.Size = new System.Drawing.Size(76, 17);
            this.objectivesCheck.TabIndex = 19;
            this.objectivesCheck.Tag = "objectives";
            this.objectivesCheck.Text = "Objectives";
            this.objectivesCheck.UseVisualStyleBackColor = true;
            this.objectivesCheck.CheckedChanged += new System.EventHandler(this.LayerState_Changed);
            // 
            // itemsCheck
            // 
            this.itemsCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsCheck.AutoSize = true;
            this.itemsCheck.Checked = global::lttpspoiler.Properties.Settings.Default.mainFrameItemsCheck;
            this.itemsCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::lttpspoiler.Properties.Settings.Default, "mainFrameItemsCheck", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemsCheck.Location = new System.Drawing.Point(12, 544);
            this.itemsCheck.Name = "itemsCheck";
            this.itemsCheck.Size = new System.Drawing.Size(51, 17);
            this.itemsCheck.TabIndex = 18;
            this.itemsCheck.Tag = "items";
            this.itemsCheck.Text = "Items";
            this.itemsCheck.UseVisualStyleBackColor = true;
            this.itemsCheck.CheckedChanged += new System.EventHandler(this.LayerState_Changed);
            // 
            // mapControl
            // 
            this.mapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl.AutoScroll = true;
            this.mapControl.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.mapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl.Location = new System.Drawing.Point(12, 12);
            this.mapControl.Name = "mapControl";
            this.mapControl.selectedMapIndex = -1;
            this.mapControl.Size = new System.Drawing.Size(760, 526);
            this.mapControl.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 692);
            this.Controls.Add(this.entranceCheck);
            this.Controls.Add(this.enemiesCheck);
            this.Controls.Add(this.objectivesCheck);
            this.Controls.Add(this.itemsCheck);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.about);
            this.Controls.Add(this.find13);
            this.Controls.Add(this.find12);
            this.Controls.Add(this.find10);
            this.Controls.Add(this.find9);
            this.Controls.Add(this.find8);
            this.Controls.Add(this.find7);
            this.Controls.Add(this.find6);
            this.Controls.Add(this.find5);
            this.Controls.Add(this.find4);
            this.Controls.Add(this.find3);
            this.Controls.Add(this.find2);
            this.Controls.Add(this.find1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapSelector);
            this.Controls.Add(this.mapControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::lttpspoiler.Properties.Settings.Default, "mainFrameLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::lttpspoiler.Properties.Settings.Default.mainFrameLocation;
            this.MinimumSize = new System.Drawing.Size(800, 730);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrame_FormClosing);
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainFrame_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainFrame_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl;
        private System.Windows.Forms.ListBox mapSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox objective;
        private System.Windows.Forms.Button find1;
        private System.Windows.Forms.Button find2;
        private System.Windows.Forms.Button find3;
        private System.Windows.Forms.Button find4;
        private System.Windows.Forms.Button find8;
        private System.Windows.Forms.Button find7;
        private System.Windows.Forms.Button find6;
        private System.Windows.Forms.Button find5;
        private System.Windows.Forms.Button find13;
        private System.Windows.Forms.Button find12;
        private System.Windows.Forms.Button find10;
        private System.Windows.Forms.Button find9;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox itemsCheck;
        private System.Windows.Forms.CheckBox objectivesCheck;
        private System.Windows.Forms.CheckBox enemiesCheck;
        private System.Windows.Forms.CheckBox entranceCheck;
    }
}
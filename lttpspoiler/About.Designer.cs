namespace lttpspoiler {
    partial class About {
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
            this.label1 = new System.Windows.Forms.Label();
            this.diff = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.logic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.build = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Difficulty";
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(101, 39);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(215, 20);
            this.diff.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(241, 195);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // logic
            // 
            this.logic.Location = new System.Drawing.Point(101, 65);
            this.logic.Name = "logic";
            this.logic.Size = new System.Drawing.Size(215, 20);
            this.logic.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logic";
            // 
            // goal
            // 
            this.goal.Location = new System.Drawing.Point(101, 117);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(215, 20);
            this.goal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Goal";
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(101, 91);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(215, 20);
            this.seed.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seed";
            // 
            // mode
            // 
            this.mode.Location = new System.Drawing.Point(101, 169);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(215, 20);
            this.mode.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mode";
            // 
            // build
            // 
            this.build.Location = new System.Drawing.Point(101, 143);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(215, 20);
            this.build.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Build";
            // 
            // About
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.build);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox diff;
        public System.Windows.Forms.TextBox logic;
        public System.Windows.Forms.TextBox goal;
        public System.Windows.Forms.TextBox seed;
        public System.Windows.Forms.TextBox mode;
        public System.Windows.Forms.TextBox build;
    }
}
namespace springfield_nuclear_app
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
            this.top_title = new System.Windows.Forms.Label();
            this.reactor2_text = new System.Windows.Forms.Label();
            this.reactor1_text = new System.Windows.Forms.Label();
            this.reactor1_button = new System.Windows.Forms.Button();
            this.reactor2_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.reactor_status_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // top_title
            // 
            this.top_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.top_title.Location = new System.Drawing.Point(258, 9);
            this.top_title.Name = "top_title";
            this.top_title.Size = new System.Drawing.Size(248, 25);
            this.top_title.TabIndex = 0;
            this.top_title.Text = "Nuclear Reactor Control";
            this.top_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactor2_text
            // 
            this.reactor2_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.reactor2_text.Location = new System.Drawing.Point(410, 88);
            this.reactor2_text.Name = "reactor2_text";
            this.reactor2_text.Size = new System.Drawing.Size(248, 25);
            this.reactor2_text.TabIndex = 1;
            this.reactor2_text.Text = "Reactor 2";
            this.reactor2_text.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // reactor1_text
            // 
            this.reactor1_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.reactor1_text.Location = new System.Drawing.Point(83, 88);
            this.reactor1_text.Name = "reactor1_text";
            this.reactor1_text.Size = new System.Drawing.Size(248, 25);
            this.reactor1_text.TabIndex = 2;
            this.reactor1_text.Text = "Reactor 1";
            this.reactor1_text.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // reactor1_button
            // 
            this.reactor1_button.Location = new System.Drawing.Point(88, 141);
            this.reactor1_button.Name = "reactor1_button";
            this.reactor1_button.Size = new System.Drawing.Size(100, 100);
            this.reactor1_button.TabIndex = 3;
            this.reactor1_button.UseVisualStyleBackColor = true;
            this.reactor1_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reactor1_button_MouseClick);
            // 
            // reactor2_button
            // 
            this.reactor2_button.Location = new System.Drawing.Point(415, 141);
            this.reactor2_button.Name = "reactor2_button";
            this.reactor2_button.Size = new System.Drawing.Size(100, 100);
            this.reactor2_button.TabIndex = 4;
            this.reactor2_button.UseVisualStyleBackColor = true;
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.start_button.ForeColor = System.Drawing.Color.Black;
            this.start_button.Location = new System.Drawing.Point(308, 375);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(185, 52);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "Start Reactor";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // reactor_status_text
            // 
            this.reactor_status_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.reactor_status_text.Location = new System.Drawing.Point(267, 306);
            this.reactor_status_text.Name = "reactor_status_text";
            this.reactor_status_text.Size = new System.Drawing.Size(248, 25);
            this.reactor_status_text.TabIndex = 6;
            this.reactor_status_text.Text = "Reactors are Ok";
            this.reactor_status_text.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reactor_status_text);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.reactor2_button);
            this.Controls.Add(this.reactor1_button);
            this.Controls.Add(this.reactor1_text);
            this.Controls.Add(this.reactor2_text);
            this.Controls.Add(this.top_title);
            this.Name = "Form1";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label top_title;
        private System.Windows.Forms.Label reactor2_text;
        private System.Windows.Forms.Label reactor1_text;
        private System.Windows.Forms.Button reactor1_button;
        private System.Windows.Forms.Button reactor2_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label reactor_status_text;
    }
}


namespace ColourCombiner
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
            this.percent0 = new System.Windows.Forms.TrackBar();
            this.percent1 = new System.Windows.Forms.TrackBar();
            this.percent2 = new System.Windows.Forms.TrackBar();
            this.frequency0 = new System.Windows.Forms.TrackBar();
            this.frequency1 = new System.Windows.Forms.TrackBar();
            this.frequency2 = new System.Windows.Forms.TrackBar();
            this.frequency0_text = new System.Windows.Forms.TextBox();
            this.percent0_text = new System.Windows.Forms.TextBox();
            this.frequency1_text = new System.Windows.Forms.TextBox();
            this.percent1_text = new System.Windows.Forms.TextBox();
            this.frequency2_text = new System.Windows.Forms.TextBox();
            this.percent2_text = new System.Windows.Forms.TextBox();
            this.colour0 = new System.Windows.Forms.Panel();
            this.colour1 = new System.Windows.Forms.Panel();
            this.colour2 = new System.Windows.Forms.Panel();
            this.average_colour = new System.Windows.Forms.Panel();
            this.colour_a = new System.Windows.Forms.Label();
            this.colour_b = new System.Windows.Forms.Label();
            this.colour_c = new System.Windows.Forms.Label();
            this.mix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.percent0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency2)).BeginInit();
            this.SuspendLayout();
            // 
            // percent0
            // 
            this.percent0.Location = new System.Drawing.Point(68, 94);
            this.percent0.Margin = new System.Windows.Forms.Padding(2);
            this.percent0.Maximum = 200;
            this.percent0.Name = "percent0";
            this.percent0.Size = new System.Drawing.Size(430, 45);
            this.percent0.TabIndex = 0;
            this.percent0.Value = 100;
            this.percent0.Scroll += new System.EventHandler(this.percent0_Scroll);
            // 
            // percent1
            // 
            this.percent1.Location = new System.Drawing.Point(68, 204);
            this.percent1.Margin = new System.Windows.Forms.Padding(2);
            this.percent1.Maximum = 200;
            this.percent1.Name = "percent1";
            this.percent1.Size = new System.Drawing.Size(430, 45);
            this.percent1.TabIndex = 1;
            this.percent1.Value = 100;
            this.percent1.Scroll += new System.EventHandler(this.percent1_Scroll);
            // 
            // percent2
            // 
            this.percent2.Location = new System.Drawing.Point(68, 327);
            this.percent2.Margin = new System.Windows.Forms.Padding(2);
            this.percent2.Maximum = 200;
            this.percent2.Name = "percent2";
            this.percent2.Size = new System.Drawing.Size(430, 45);
            this.percent2.TabIndex = 2;
            this.percent2.Value = 100;
            this.percent2.Scroll += new System.EventHandler(this.percent2_Scroll);
            // 
            // frequency0
            // 
            this.frequency0.BackColor = System.Drawing.SystemColors.Control;
            this.frequency0.LargeChange = 20;
            this.frequency0.Location = new System.Drawing.Point(68, 44);
            this.frequency0.Margin = new System.Windows.Forms.Padding(2);
            this.frequency0.Maximum = 750;
            this.frequency0.Minimum = 390;
            this.frequency0.Name = "frequency0";
            this.frequency0.Size = new System.Drawing.Size(430, 45);
            this.frequency0.TabIndex = 3;
            this.frequency0.Value = 610;
            this.frequency0.Scroll += new System.EventHandler(this.frequency0_Scroll);
            // 
            // frequency1
            // 
            this.frequency1.LargeChange = 20;
            this.frequency1.Location = new System.Drawing.Point(68, 154);
            this.frequency1.Margin = new System.Windows.Forms.Padding(2);
            this.frequency1.Maximum = 750;
            this.frequency1.Minimum = 390;
            this.frequency1.Name = "frequency1";
            this.frequency1.Size = new System.Drawing.Size(430, 45);
            this.frequency1.TabIndex = 4;
            this.frequency1.Value = 610;
            this.frequency1.Scroll += new System.EventHandler(this.frequency1_Scroll);
            // 
            // frequency2
            // 
            this.frequency2.LargeChange = 20;
            this.frequency2.Location = new System.Drawing.Point(68, 277);
            this.frequency2.Margin = new System.Windows.Forms.Padding(2);
            this.frequency2.Maximum = 750;
            this.frequency2.Minimum = 390;
            this.frequency2.Name = "frequency2";
            this.frequency2.Size = new System.Drawing.Size(430, 45);
            this.frequency2.TabIndex = 5;
            this.frequency2.Value = 610;
            this.frequency2.Scroll += new System.EventHandler(this.frequency2_Scroll);
            // 
            // frequency0_text
            // 
            this.frequency0_text.Location = new System.Drawing.Point(503, 44);
            this.frequency0_text.Margin = new System.Windows.Forms.Padding(2);
            this.frequency0_text.Name = "frequency0_text";
            this.frequency0_text.Size = new System.Drawing.Size(76, 20);
            this.frequency0_text.TabIndex = 6;
            this.frequency0_text.Text = "610";
            // 
            // percent0_text
            // 
            this.percent0_text.Location = new System.Drawing.Point(503, 94);
            this.percent0_text.Margin = new System.Windows.Forms.Padding(2);
            this.percent0_text.Name = "percent0_text";
            this.percent0_text.Size = new System.Drawing.Size(76, 20);
            this.percent0_text.TabIndex = 7;
            this.percent0_text.Text = "100";
            // 
            // frequency1_text
            // 
            this.frequency1_text.Location = new System.Drawing.Point(503, 154);
            this.frequency1_text.Margin = new System.Windows.Forms.Padding(2);
            this.frequency1_text.Name = "frequency1_text";
            this.frequency1_text.Size = new System.Drawing.Size(76, 20);
            this.frequency1_text.TabIndex = 8;
            this.frequency1_text.Text = "610";
            // 
            // percent1_text
            // 
            this.percent1_text.Location = new System.Drawing.Point(503, 204);
            this.percent1_text.Margin = new System.Windows.Forms.Padding(2);
            this.percent1_text.Name = "percent1_text";
            this.percent1_text.Size = new System.Drawing.Size(76, 20);
            this.percent1_text.TabIndex = 9;
            this.percent1_text.Text = "100";
            // 
            // frequency2_text
            // 
            this.frequency2_text.Location = new System.Drawing.Point(503, 277);
            this.frequency2_text.Margin = new System.Windows.Forms.Padding(2);
            this.frequency2_text.Name = "frequency2_text";
            this.frequency2_text.Size = new System.Drawing.Size(76, 20);
            this.frequency2_text.TabIndex = 10;
            this.frequency2_text.Text = "610";
            // 
            // percent2_text
            // 
            this.percent2_text.Location = new System.Drawing.Point(503, 327);
            this.percent2_text.Margin = new System.Windows.Forms.Padding(2);
            this.percent2_text.Name = "percent2_text";
            this.percent2_text.Size = new System.Drawing.Size(76, 20);
            this.percent2_text.TabIndex = 11;
            this.percent2_text.Text = "100";
            // 
            // colour0
            // 
            this.colour0.BackColor = System.Drawing.Color.Red;
            this.colour0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colour0.Location = new System.Drawing.Point(9, 52);
            this.colour0.Margin = new System.Windows.Forms.Padding(2);
            this.colour0.Name = "colour0";
            this.colour0.Size = new System.Drawing.Size(50, 58);
            this.colour0.TabIndex = 12;
            // 
            // colour1
            // 
            this.colour1.BackColor = System.Drawing.Color.Red;
            this.colour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colour1.Location = new System.Drawing.Point(9, 164);
            this.colour1.Margin = new System.Windows.Forms.Padding(2);
            this.colour1.Name = "colour1";
            this.colour1.Size = new System.Drawing.Size(50, 58);
            this.colour1.TabIndex = 13;
            // 
            // colour2
            // 
            this.colour2.BackColor = System.Drawing.Color.Red;
            this.colour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colour2.Location = new System.Drawing.Point(9, 286);
            this.colour2.Margin = new System.Windows.Forms.Padding(2);
            this.colour2.Name = "colour2";
            this.colour2.Size = new System.Drawing.Size(50, 58);
            this.colour2.TabIndex = 13;
            // 
            // average_colour
            // 
            this.average_colour.BackColor = System.Drawing.Color.Red;
            this.average_colour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.average_colour.Location = new System.Drawing.Point(637, 84);
            this.average_colour.Margin = new System.Windows.Forms.Padding(2);
            this.average_colour.Name = "average_colour";
            this.average_colour.Size = new System.Drawing.Size(222, 220);
            this.average_colour.TabIndex = 13;
            // 
            // colour_a
            // 
            this.colour_a.AutoSize = true;
            this.colour_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colour_a.Location = new System.Drawing.Point(12, 16);
            this.colour_a.Name = "colour_a";
            this.colour_a.Size = new System.Drawing.Size(84, 24);
            this.colour_a.TabIndex = 14;
            this.colour_a.Text = "Colour A";
            // 
            // colour_b
            // 
            this.colour_b.AutoSize = true;
            this.colour_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colour_b.Location = new System.Drawing.Point(12, 128);
            this.colour_b.Name = "colour_b";
            this.colour_b.Size = new System.Drawing.Size(83, 24);
            this.colour_b.TabIndex = 14;
            this.colour_b.Text = "Colour B";
            // 
            // colour_c
            // 
            this.colour_c.AutoSize = true;
            this.colour_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colour_c.Location = new System.Drawing.Point(13, 251);
            this.colour_c.Name = "colour_c";
            this.colour_c.Size = new System.Drawing.Size(84, 24);
            this.colour_c.TabIndex = 15;
            this.colour_c.Text = "Colour C";
            // 
            // mix
            // 
            this.mix.AutoSize = true;
            this.mix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mix.Location = new System.Drawing.Point(720, 44);
            this.mix.Name = "mix";
            this.mix.Size = new System.Drawing.Size(55, 31);
            this.mix.TabIndex = 16;
            this.mix.Text = "Mix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Frequency (nm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Frequency (nm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Frequency (nm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Intensity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Intensity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Intensity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mix);
            this.Controls.Add(this.colour_c);
            this.Controls.Add(this.colour_b);
            this.Controls.Add(this.colour_a);
            this.Controls.Add(this.average_colour);
            this.Controls.Add(this.colour2);
            this.Controls.Add(this.colour1);
            this.Controls.Add(this.colour0);
            this.Controls.Add(this.percent2_text);
            this.Controls.Add(this.frequency2_text);
            this.Controls.Add(this.percent1_text);
            this.Controls.Add(this.frequency1_text);
            this.Controls.Add(this.percent0_text);
            this.Controls.Add(this.frequency0_text);
            this.Controls.Add(this.frequency2);
            this.Controls.Add(this.frequency1);
            this.Controls.Add(this.frequency0);
            this.Controls.Add(this.percent2);
            this.Controls.Add(this.percent1);
            this.Controls.Add(this.percent0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Wavelength to Colour";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.percent0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar percent0;
        private System.Windows.Forms.TrackBar percent1;
        private System.Windows.Forms.TrackBar percent2;
        private System.Windows.Forms.TrackBar frequency0;
        private System.Windows.Forms.TrackBar frequency1;
        private System.Windows.Forms.TrackBar frequency2;
        private System.Windows.Forms.TextBox frequency0_text;
        private System.Windows.Forms.TextBox percent0_text;
        private System.Windows.Forms.TextBox frequency1_text;
        private System.Windows.Forms.TextBox percent1_text;
        private System.Windows.Forms.TextBox frequency2_text;
        private System.Windows.Forms.TextBox percent2_text;
        private System.Windows.Forms.Panel colour0;
        private System.Windows.Forms.Panel colour1;
        private System.Windows.Forms.Panel colour2;
        private System.Windows.Forms.Panel average_colour;
        private System.Windows.Forms.Label colour_a;
        private System.Windows.Forms.Label colour_b;
        private System.Windows.Forms.Label colour_c;
        private System.Windows.Forms.Label mix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


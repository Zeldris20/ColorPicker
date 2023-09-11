namespace Bunifuframework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtRedval = new TextBox();
            textGreenval = new TextBox();
            txtBlueval = new TextBox();
            PanelSpectrum = new Panel();
            Start = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            RevertTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(720, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(94, 29);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "Color Picker";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 64);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(278, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(258, 254);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(52, 426);
            label2.Name = "label2";
            label2.Size = new Size(78, 33);
            label2.TabIndex = 4;
            label2.Text = "RGB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kollektif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(330, 360);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 6;
            label4.Text = "Color Selection";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(332, 390);
            label5.Name = "label5";
            label5.Size = new Size(39, 18);
            label5.TabIndex = 7;
            label5.Text = "Red:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(318, 431);
            label6.Name = "label6";
            label6.Size = new Size(53, 18);
            label6.TabIndex = 8;
            label6.Text = "Green:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(330, 471);
            label7.Name = "label7";
            label7.Size = new Size(41, 18);
            label7.TabIndex = 9;
            label7.Text = "Blue:";
            // 
            // txtRedval
            // 
            txtRedval.Location = new Point(377, 385);
            txtRedval.Name = "txtRedval";
            txtRedval.Size = new Size(100, 23);
            txtRedval.TabIndex = 10;
            txtRedval.TextChanged += txtRedval_TextChanged;
            // 
            // textGreenval
            // 
            textGreenval.Location = new Point(377, 426);
            textGreenval.Name = "textGreenval";
            textGreenval.Size = new Size(100, 23);
            textGreenval.TabIndex = 11;
            textGreenval.TextChanged += textGreenval_TextChanged;
            // 
            // txtBlueval
            // 
            txtBlueval.Location = new Point(377, 471);
            txtBlueval.Name = "txtBlueval";
            txtBlueval.Size = new Size(100, 23);
            txtBlueval.TabIndex = 12;
            txtBlueval.TextChanged += txtBlueval_TextChanged;
            // 
            // PanelSpectrum
            // 
            PanelSpectrum.BackColor = Color.Transparent;
            PanelSpectrum.Location = new Point(544, 390);
            PanelSpectrum.Name = "PanelSpectrum";
            PanelSpectrum.Size = new Size(133, 104);
            PanelSpectrum.TabIndex = 13;
            PanelSpectrum.Paint += PanelSpectrum_Paint;
            // 
            // Start
            // 
            Start.Location = new Point(437, 289);
            Start.Name = "Start";
            Start.Size = new Size(75, 23);
            Start.TabIndex = 15;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(156, 424);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 33);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(296, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "HEX";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(800, 513);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Start);
            Controls.Add(PanelSpectrum);
            Controls.Add(txtBlueval);
            Controls.Add(textGreenval);
            Controls.Add(txtRedval);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtRedval;
        private TextBox textGreenval;
        private TextBox txtBlueval;
        private Panel PanelSpectrum;
        private Button Start;
        private TextBox textBox1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer RevertTimer;
    }
}
namespace Lab04
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
            pictureBox1 = new PictureBox();
            btnPrevious = new Button();
            btnOpen = new Button();
            btnNext = new Button();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 334);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(12, 352);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 37);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "<< Trước\r\n";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(343, 352);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(122, 37);
            btnOpen.TabIndex = 2;
            btnOpen.Text = "Mở Thư Mục hình";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(713, 352);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 37);
            btnNext.TabIndex = 3;
            btnNext.Text = "Sau >>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 395);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(776, 43);
            btnStart.TabIndex = 4;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(btnNext);
            Controls.Add(btnOpen);
            Controls.Add(btnPrevious);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnPrevious;
        private Button btnOpen;
        private Button btnNext;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

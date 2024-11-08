namespace Graphs
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
            textBoxData = new TextBox();
            buttonDraw = new Button();
            pictureBoxChart = new PictureBox();
            label1 = new Label();
            buttonReset = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).BeginInit();
            SuspendLayout();
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(199, 198);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(317, 34);
            textBoxData.TabIndex = 0;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(787, 48);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(103, 46);
            buttonDraw.TabIndex = 1;
            buttonDraw.Text = "Draw";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click_1;
            // 
            // pictureBoxChart
            // 
            pictureBoxChart.Location = new Point(199, 289);
            pictureBoxChart.Name = "pictureBoxChart";
            pictureBoxChart.Size = new Size(691, 517);
            pictureBoxChart.TabIndex = 2;
            pictureBoxChart.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 66);
            label1.Name = "label1";
            label1.Size = new Size(339, 28);
            label1.TabIndex = 3;
            label1.Text = "User: Input Width,Height,sweep angle";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(787, 130);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(103, 51);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 130);
            label2.Name = "label2";
            label2.Size = new Size(280, 28);
            label2.TabIndex = 5;
            label2.Text = "Format: Num,Num,Num,Num...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 852);
            Controls.Add(label2);
            Controls.Add(buttonReset);
            Controls.Add(label1);
            Controls.Add(pictureBoxChart);
            Controls.Add(buttonDraw);
            Controls.Add(textBoxData);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxData;
        private Button buttonDraw;
        private PictureBox pictureBoxChart;
        private Label label1;
        private Button buttonReset;
        private Label label2;
    }
}

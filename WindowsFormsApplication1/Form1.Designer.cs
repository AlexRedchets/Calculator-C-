namespace WindowsFormsApplication1
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
            this.length_input = new System.Windows.Forms.TextBox();
            this.width_input = new System.Windows.Forms.TextBox();
            this.height_input = new System.Windows.Forms.TextBox();
            this.label_length = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.count_button = new System.Windows.Forms.Button();
            this.label_boxes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.result_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // length_input
            // 
            this.length_input.Location = new System.Drawing.Point(247, 66);
            this.length_input.Name = "length_input";
            this.length_input.Size = new System.Drawing.Size(100, 20);
            this.length_input.TabIndex = 0;
            // 
            // width_input
            // 
            this.width_input.Location = new System.Drawing.Point(247, 92);
            this.width_input.Name = "width_input";
            this.width_input.Size = new System.Drawing.Size(100, 20);
            this.width_input.TabIndex = 0;
            // 
            // height_input
            // 
            this.height_input.Location = new System.Drawing.Point(247, 118);
            this.height_input.Name = "height_input";
            this.height_input.Size = new System.Drawing.Size(100, 20);
            this.height_input.TabIndex = 0;
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(182, 69);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(40, 13);
            this.label_length.TabIndex = 1;
            this.label_length.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(182, 121);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(38, 13);
            this.label_height.TabIndex = 3;
            this.label_height.Text = "Height";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(244, 199);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(37, 13);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "Result";
            // 
            // count_button
            // 
            this.count_button.Location = new System.Drawing.Point(247, 155);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(100, 23);
            this.count_button.TabIndex = 4;
            this.count_button.Text = "Count";
            this.count_button.UseVisualStyleBackColor = true;
            this.count_button.Click += new System.EventHandler(this.count_button_Click);
            // 
            // label_boxes
            // 
            this.label_boxes.AutoSize = true;
            this.label_boxes.Location = new System.Drawing.Point(326, 199);
            this.label_boxes.Name = "label_boxes";
            this.label_boxes.Size = new System.Drawing.Size(35, 13);
            this.label_boxes.TabIndex = 3;
            this.label_boxes.Text = "boxes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "feet";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(182, 95);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(35, 13);
            this.label_width.TabIndex = 2;
            this.label_width.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "feet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "feet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(313, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "How many cartons can fit inside a 18\"x18\"x8\" shipping container";
            // 
            // result_num
            // 
            this.result_num.AutoSize = true;
            this.result_num.Location = new System.Drawing.Point(296, 199);
            this.result_num.Name = "result_num";
            this.result_num.Size = new System.Drawing.Size(13, 13);
            this.result_num.TabIndex = 3;
            this.result_num.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 298);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.count_button);
            this.Controls.Add(this.label_boxes);
            this.Controls.Add(this.result_num);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.height_input);
            this.Controls.Add(this.width_input);
            this.Controls.Add(this.length_input);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox length_input;
        private System.Windows.Forms.TextBox width_input;
        private System.Windows.Forms.TextBox height_input;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button count_button;
        private System.Windows.Forms.Label label_boxes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label result_num;
    }
}


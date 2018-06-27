namespace _7_segment_display
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_2 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.bt_6 = new System.Windows.Forms.Button();
            this.bt_7 = new System.Windows.Forms.Button();
            this.bt_rand = new System.Windows.Forms.Button();
            this.bt_sc = new System.Windows.Forms.Button();
            this.lb_show = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(41, 13);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(175, 28);
            this.bt_1.TabIndex = 0;
            this.bt_1.Text = "button1";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(213, 47);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(31, 151);
            this.bt_2.TabIndex = 1;
            this.bt_2.Text = "button1";
            this.bt_2.UseVisualStyleBackColor = true;
            this.bt_2.Click += new System.EventHandler(this.bt_2_Click);
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(213, 238);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(31, 151);
            this.bt_3.TabIndex = 2;
            this.bt_3.Text = "button2";
            this.bt_3.UseVisualStyleBackColor = true;
            this.bt_3.Click += new System.EventHandler(this.bt_3_Click);
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(41, 395);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(175, 28);
            this.bt_4.TabIndex = 3;
            this.bt_4.Text = "button1";
            this.bt_4.UseVisualStyleBackColor = true;
            this.bt_4.Click += new System.EventHandler(this.bt_4_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(12, 238);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(31, 151);
            this.bt_5.TabIndex = 4;
            this.bt_5.Text = "button4";
            this.bt_5.UseVisualStyleBackColor = true;
            this.bt_5.Click += new System.EventHandler(this.bt_5_Click);
            // 
            // bt_6
            // 
            this.bt_6.Location = new System.Drawing.Point(12, 47);
            this.bt_6.Name = "bt_6";
            this.bt_6.Size = new System.Drawing.Size(31, 151);
            this.bt_6.TabIndex = 5;
            this.bt_6.Text = "button5";
            this.bt_6.UseVisualStyleBackColor = true;
            this.bt_6.Click += new System.EventHandler(this.bt_6_Click);
            // 
            // bt_7
            // 
            this.bt_7.Location = new System.Drawing.Point(41, 204);
            this.bt_7.Name = "bt_7";
            this.bt_7.Size = new System.Drawing.Size(175, 28);
            this.bt_7.TabIndex = 6;
            this.bt_7.Text = "button1";
            this.bt_7.UseVisualStyleBackColor = true;
            this.bt_7.Click += new System.EventHandler(this.bt_7_Click);
            // 
            // bt_rand
            // 
            this.bt_rand.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt_rand.Location = new System.Drawing.Point(271, 395);
            this.bt_rand.Name = "bt_rand";
            this.bt_rand.Size = new System.Drawing.Size(159, 38);
            this.bt_rand.TabIndex = 7;
            this.bt_rand.Text = "隨機產生";
            this.bt_rand.UseVisualStyleBackColor = true;
            this.bt_rand.Click += new System.EventHandler(this.bt_rand_Click);
            // 
            // bt_sc
            // 
            this.bt_sc.Font = new System.Drawing.Font("新細明體", 20F);
            this.bt_sc.Location = new System.Drawing.Point(271, 438);
            this.bt_sc.Name = "bt_sc";
            this.bt_sc.Size = new System.Drawing.Size(159, 38);
            this.bt_sc.TabIndex = 8;
            this.bt_sc.Text = "辨認";
            this.bt_sc.UseVisualStyleBackColor = true;
            this.bt_sc.Click += new System.EventHandler(this.bt_sc_Click);
            // 
            // lb_show
            // 
            this.lb_show.AutoSize = true;
            this.lb_show.Font = new System.Drawing.Font("新細明體", 20F);
            this.lb_show.Location = new System.Drawing.Point(21, 444);
            this.lb_show.Name = "lb_show";
            this.lb_show.Size = new System.Drawing.Size(66, 27);
            this.lb_show.TabIndex = 9;
            this.lb_show.Text = "show";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 495);
            this.Controls.Add(this.lb_show);
            this.Controls.Add(this.bt_sc);
            this.Controls.Add(this.bt_rand);
            this.Controls.Add(this.bt_7);
            this.Controls.Add(this.bt_6);
            this.Controls.Add(this.bt_5);
            this.Controls.Add(this.bt_4);
            this.Controls.Add(this.bt_3);
            this.Controls.Add(this.bt_2);
            this.Controls.Add(this.bt_1);
            this.Name = "Form1";
            this.Text = "7 segment display";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.Button bt_6;
        private System.Windows.Forms.Button bt_7;
        private System.Windows.Forms.Button bt_rand;
        private System.Windows.Forms.Button bt_sc;
        private System.Windows.Forms.Label lb_show;
    }
}


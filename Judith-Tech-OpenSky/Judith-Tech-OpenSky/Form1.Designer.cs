namespace Judith_Tech_OpenSky
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
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flights_counter = new System.Windows.Forms.Label();
            this.last_update = new System.Windows.Forms.Label();
            this.highestFlight_btn = new System.Windows.Forms.Button();
            this.lowestFlight_btn = new System.Windows.Forms.Button();
            this.top_five = new System.Windows.Forms.ListBox();
            this.countries_list = new System.Windows.Forms.ListBox();
            this.flights = new System.Windows.Forms.ListBox();
            this.flights_details = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.TextBox();
            this.bottom = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.top = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start_btn.Location = new System.Drawing.Point(12, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(97, 33);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.stop_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stop_btn.Location = new System.Drawing.Point(123, 12);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(91, 33);
            this.stop_btn.TabIndex = 1;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flights counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Update";
            // 
            // flights_counter
            // 
            this.flights_counter.AutoSize = true;
            this.flights_counter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flights_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flights_counter.Location = new System.Drawing.Point(194, 56);
            this.flights_counter.Name = "flights_counter";
            this.flights_counter.Size = new System.Drawing.Size(20, 22);
            this.flights_counter.TabIndex = 4;
            this.flights_counter.Text = "0";
            this.flights_counter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.last_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.last_update.Location = new System.Drawing.Point(194, 86);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(132, 22);
            this.last_update.TabIndex = 5;
            this.last_update.Text = "xx/xx/xx xx:xx:xx";
            this.last_update.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highestFlight_btn
            // 
            this.highestFlight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.highestFlight_btn.Location = new System.Drawing.Point(820, 12);
            this.highestFlight_btn.Name = "highestFlight_btn";
            this.highestFlight_btn.Size = new System.Drawing.Size(157, 33);
            this.highestFlight_btn.TabIndex = 6;
            this.highestFlight_btn.Text = "Highest Flight";
            this.highestFlight_btn.UseVisualStyleBackColor = true;
            this.highestFlight_btn.Click += new System.EventHandler(this.highestFlight_btn_Click);
            // 
            // lowestFlight_btn
            // 
            this.lowestFlight_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lowestFlight_btn.Location = new System.Drawing.Point(820, 58);
            this.lowestFlight_btn.Name = "lowestFlight_btn";
            this.lowestFlight_btn.Size = new System.Drawing.Size(157, 33);
            this.lowestFlight_btn.TabIndex = 7;
            this.lowestFlight_btn.Text = "Lowest Flight";
            this.lowestFlight_btn.UseVisualStyleBackColor = true;
            this.lowestFlight_btn.Click += new System.EventHandler(this.lowestFlight_btn_Click);
            // 
            // top_five
            // 
            this.top_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.top_five.FormattingEnabled = true;
            this.top_five.ItemHeight = 20;
            this.top_five.Location = new System.Drawing.Point(281, 174);
            this.top_five.Name = "top_five";
            this.top_five.Size = new System.Drawing.Size(234, 144);
            this.top_five.TabIndex = 8;
            this.top_five.SelectedIndexChanged += new System.EventHandler(this.top_five_SelectedIndexChanged);
            // 
            // countries_list
            // 
            this.countries_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.countries_list.FormattingEnabled = true;
            this.countries_list.ItemHeight = 20;
            this.countries_list.Location = new System.Drawing.Point(12, 174);
            this.countries_list.Margin = new System.Windows.Forms.Padding(5);
            this.countries_list.Name = "countries_list";
            this.countries_list.Size = new System.Drawing.Size(234, 284);
            this.countries_list.TabIndex = 9;
            this.countries_list.SelectedIndexChanged += new System.EventHandler(this.countries_list_SelectedIndexChanged);
            // 
            // flights
            // 
            this.flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flights.FormattingEnabled = true;
            this.flights.ItemHeight = 20;
            this.flights.Location = new System.Drawing.Point(551, 174);
            this.flights.Name = "flights";
            this.flights.Size = new System.Drawing.Size(234, 284);
            this.flights.TabIndex = 10;
            this.flights.SelectedIndexChanged += new System.EventHandler(this.flights_SelectedIndexChanged);
            // 
            // flights_details
            // 
            this.flights_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flights_details.FormattingEnabled = true;
            this.flights_details.ItemHeight = 20;
            this.flights_details.Location = new System.Drawing.Point(820, 174);
            this.flights_details.Name = "flights_details";
            this.flights_details.Size = new System.Drawing.Size(147, 144);
            this.flights_details.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(276, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Top 5 Countries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Countries List";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(815, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Flights Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(546, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Flights";
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.left.Location = new System.Drawing.Point(1136, 180);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(43, 26);
            this.left.TabIndex = 16;
            this.left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bottom
            // 
            this.bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bottom.Location = new System.Drawing.Point(1136, 360);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(43, 26);
            this.bottom.TabIndex = 17;
            this.bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.right.Location = new System.Drawing.Point(1136, 303);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(43, 26);
            this.right.TabIndex = 18;
            this.right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // top
            // 
            this.top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.top.Location = new System.Drawing.Point(1136, 244);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(43, 26);
            this.top.TabIndex = 19;
            this.top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1049, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1049, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bottom";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(1049, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Right";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(1049, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Top";
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refresh_btn.Location = new System.Drawing.Point(1053, 405);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(126, 42);
            this.refresh_btn.TabIndex = 24;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 623);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.top);
            this.Controls.Add(this.right);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flights_details);
            this.Controls.Add(this.flights);
            this.Controls.Add(this.countries_list);
            this.Controls.Add(this.top_five);
            this.Controls.Add(this.lowestFlight_btn);
            this.Controls.Add(this.highestFlight_btn);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.flights_counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.Button highestFlight_btn;
        private System.Windows.Forms.Button lowestFlight_btn;
        private System.Windows.Forms.ListBox top_five;
        private System.Windows.Forms.ListBox countries_list;
        private System.Windows.Forms.ListBox flights;
        private System.Windows.Forms.ListBox flights_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label flights_counter;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox bottom;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.TextBox top;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button refresh_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


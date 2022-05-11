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
            this.top_five = new System.Windows.Forms.ListBox();
            this.countries_list = new System.Windows.Forms.ListBox();
            this.flights = new System.Windows.Forms.ListBox();
            this.flights_details = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.highest_flight = new System.Windows.Forms.ListBox();
            this.lowest_flight = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.NumericUpDown();
            this.right = new System.Windows.Forms.NumericUpDown();
            this.top = new System.Windows.Forms.NumericUpDown();
            this.bottom = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.start_btn.Location = new System.Drawing.Point(12, 57);
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
            this.stop_btn.Location = new System.Drawing.Point(123, 57);
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
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Flights counter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(13, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Update";
            // 
            // flights_counter
            // 
            this.flights_counter.AutoSize = true;
            this.flights_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flights_counter.Location = new System.Drawing.Point(194, 104);
            this.flights_counter.Name = "flights_counter";
            this.flights_counter.Size = new System.Drawing.Size(0, 20);
            this.flights_counter.TabIndex = 4;
            this.flights_counter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // last_update
            // 
            this.last_update.AutoSize = true;
            this.last_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.last_update.Location = new System.Drawing.Point(194, 137);
            this.last_update.Name = "last_update";
            this.last_update.Size = new System.Drawing.Size(0, 20);
            this.last_update.TabIndex = 5;
            this.last_update.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // top_five
            // 
            this.top_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.top_five.FormattingEnabled = true;
            this.top_five.ItemHeight = 20;
            this.top_five.Location = new System.Drawing.Point(407, 222);
            this.top_five.Name = "top_five";
            this.top_five.Size = new System.Drawing.Size(277, 144);
            this.top_five.TabIndex = 8;
            this.top_five.SelectedIndexChanged += new System.EventHandler(this.top_five_SelectedIndexChanged);
            // 
            // countries_list
            // 
            this.countries_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.countries_list.FormattingEnabled = true;
            this.countries_list.ItemHeight = 20;
            this.countries_list.Location = new System.Drawing.Point(12, 224);
            this.countries_list.Margin = new System.Windows.Forms.Padding(5);
            this.countries_list.Name = "countries_list";
            this.countries_list.Size = new System.Drawing.Size(355, 404);
            this.countries_list.TabIndex = 9;
            this.countries_list.SelectedIndexChanged += new System.EventHandler(this.countries_list_SelectedIndexChanged);
            // 
            // flights
            // 
            this.flights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flights.FormattingEnabled = true;
            this.flights.ItemHeight = 20;
            this.flights.Location = new System.Drawing.Point(725, 222);
            this.flights.Name = "flights";
            this.flights.Size = new System.Drawing.Size(332, 404);
            this.flights.TabIndex = 10;
            this.flights.SelectedIndexChanged += new System.EventHandler(this.flights_SelectedIndexChanged);
            // 
            // flights_details
            // 
            this.flights_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.flights_details.FormattingEnabled = true;
            this.flights_details.ItemHeight = 20;
            this.flights_details.Location = new System.Drawing.Point(1093, 222);
            this.flights_details.Name = "flights_details";
            this.flights_details.Size = new System.Drawing.Size(307, 104);
            this.flights_details.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(406, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Top 5 Countries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(12, 194);
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
            this.label5.Location = new System.Drawing.Point(1088, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Flights Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(720, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Flights";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(452, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 21;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.refresh_btn.Location = new System.Drawing.Point(407, 584);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(277, 42);
            this.refresh_btn.TabIndex = 24;
            this.refresh_btn.Text = "Find Flights";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(817, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 25;
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(407, 465);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Latitude";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(407, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Longitude";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(587, 460);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(587, 525);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(406, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(221, 25);
            this.label16.TabIndex = 30;
            this.label16.Text = "Find All Flights in Range";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highest_flight
            // 
            this.highest_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.highest_flight.FormattingEnabled = true;
            this.highest_flight.ItemHeight = 20;
            this.highest_flight.Location = new System.Drawing.Point(1093, 371);
            this.highest_flight.Name = "highest_flight";
            this.highest_flight.Size = new System.Drawing.Size(307, 104);
            this.highest_flight.TabIndex = 31;
            // 
            // lowest_flight
            // 
            this.lowest_flight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lowest_flight.FormattingEnabled = true;
            this.lowest_flight.ItemHeight = 20;
            this.lowest_flight.Location = new System.Drawing.Point(1093, 525);
            this.lowest_flight.Name = "lowest_flight";
            this.lowest_flight.Size = new System.Drawing.Size(307, 104);
            this.lowest_flight.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1092, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Lowest Flight Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(1088, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Highest Flight Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(608, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Bottom";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.Location = new System.Drawing.Point(509, 501);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Top";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.Location = new System.Drawing.Point(608, 436);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 37;
            this.label18.Text = "Right";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.Location = new System.Drawing.Point(508, 436);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 20);
            this.label19.TabIndex = 38;
            this.label19.Text = "Left";
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.left.Location = new System.Drawing.Point(509, 459);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(72, 26);
            this.left.TabIndex = 39;
            this.left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.right.Location = new System.Drawing.Point(612, 459);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(72, 26);
            this.right.TabIndex = 40;
            this.right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // top
            // 
            this.top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.top.Location = new System.Drawing.Point(511, 524);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(72, 26);
            this.top.TabIndex = 41;
            this.top.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bottom
            // 
            this.bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bottom.Location = new System.Drawing.Point(612, 524);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(72, 26);
            this.bottom.TabIndex = 42;
            this.bottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 675);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.top);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lowest_flight);
            this.Controls.Add(this.highest_flight);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flights_details);
            this.Controls.Add(this.flights);
            this.Controls.Add(this.countries_list);
            this.Controls.Add(this.top_five);
            this.Controls.Add(this.last_update);
            this.Controls.Add(this.flights_counter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label last_update;
        private System.Windows.Forms.ListBox top_five;
        private System.Windows.Forms.ListBox countries_list;
        private System.Windows.Forms.ListBox flights;
        private System.Windows.Forms.ListBox flights_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label flights_counter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refresh_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox highest_flight;
        private System.Windows.Forms.ListBox lowest_flight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown left;
        private System.Windows.Forms.NumericUpDown right;
        private System.Windows.Forms.NumericUpDown top;
        private System.Windows.Forms.NumericUpDown bottom;
    }
}


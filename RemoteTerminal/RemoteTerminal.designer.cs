namespace RemoteTerminal
{
	partial class RemoteTerminal
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteTerminal));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.work_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.time_refresh = new System.Windows.Forms.NumericUpDown();
			this.textBox_thing = new System.Windows.Forms.TextBox();
			this.textBox_service = new System.Windows.Forms.TextBox();
			this.textBox_key = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_server = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.DeadMenSwitch = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.Func_button_1 = new System.Windows.Forms.Button();
			this.Func_button_2 = new System.Windows.Forms.Button();
			this.Func_button_3 = new System.Windows.Forms.Button();
			this.led1 = new System.Windows.Forms.Panel();
			this.led2 = new System.Windows.Forms.Panel();
			this.led3 = new System.Windows.Forms.Panel();
			this.led4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox_log = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.button_load = new System.Windows.Forms.Button();
			this.listBox_UserParameters = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.time_refresh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeadMenSwitch)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.work_status,
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 525);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(781, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// work_status
			// 
			this.work_status.Name = "work_status";
			this.work_status.Size = new System.Drawing.Size(132, 17);
			this.work_status.Text = "Отправка остановлена";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// time_refresh
			// 
			this.time_refresh.Location = new System.Drawing.Point(586, 328);
			this.time_refresh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.time_refresh.Name = "time_refresh";
			this.time_refresh.ReadOnly = true;
			this.time_refresh.Size = new System.Drawing.Size(47, 20);
			this.time_refresh.TabIndex = 5;
			this.toolTip1.SetToolTip(this.time_refresh, "Задержка перед отправкой запроса. Измеряется в секундах");
			this.time_refresh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.time_refresh.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// textBox_thing
			// 
			this.textBox_thing.Location = new System.Drawing.Point(63, 122);
			this.textBox_thing.Name = "textBox_thing";
			this.textBox_thing.Size = new System.Drawing.Size(237, 20);
			this.textBox_thing.TabIndex = 1;
			this.textBox_thing.Text = "d1_thing1";
			// 
			// textBox_service
			// 
			this.textBox_service.Location = new System.Drawing.Point(63, 148);
			this.textBox_service.Name = "textBox_service";
			this.textBox_service.Size = new System.Drawing.Size(237, 20);
			this.textBox_service.TabIndex = 2;
			this.textBox_service.Text = "RemoteTerminal_test";
			// 
			// textBox_key
			// 
			this.textBox_key.Location = new System.Drawing.Point(63, 174);
			this.textBox_key.Name = "textBox_key";
			this.textBox_key.Size = new System.Drawing.Size(237, 20);
			this.textBox_key.TabIndex = 3;
			this.textBox_key.Text = "6561610d-6d8b-4a7e-9ec8-897eb93c9ae7";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "AppKey";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Service";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Thing";
			// 
			// button
			// 
			this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button.Location = new System.Drawing.Point(332, 148);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(124, 46);
			this.button.TabIndex = 6;
			this.button.Text = "Подключиться";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(14, 203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server IP";
			// 
			// textBox_server
			// 
			this.textBox_server.Location = new System.Drawing.Point(90, 200);
			this.textBox_server.Name = "textBox_server";
			this.textBox_server.Size = new System.Drawing.Size(210, 20);
			this.textBox_server.TabIndex = 4;
			this.textBox_server.Text = "194.226.199.73:38080";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Switch";
			// 
			// DeadMenSwitch
			// 
			this.DeadMenSwitch.Location = new System.Drawing.Point(14, 24);
			this.DeadMenSwitch.Margin = new System.Windows.Forms.Padding(2);
			this.DeadMenSwitch.Maximum = 1;
			this.DeadMenSwitch.Name = "DeadMenSwitch";
			this.DeadMenSwitch.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.DeadMenSwitch.Size = new System.Drawing.Size(45, 84);
			this.DeadMenSwitch.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(104, 9);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Functional buttons";
			// 
			// Func_button_1
			// 
			this.Func_button_1.Location = new System.Drawing.Point(63, 24);
			this.Func_button_1.Margin = new System.Windows.Forms.Padding(2);
			this.Func_button_1.Name = "Func_button_1";
			this.Func_button_1.Size = new System.Drawing.Size(56, 84);
			this.Func_button_1.TabIndex = 8;
			this.Func_button_1.Text = "1";
			this.Func_button_1.UseVisualStyleBackColor = true;
			this.Func_button_1.Click += new System.EventHandler(this.Func_button_1_Click);
			// 
			// Func_button_2
			// 
			this.Func_button_2.Location = new System.Drawing.Point(123, 24);
			this.Func_button_2.Margin = new System.Windows.Forms.Padding(2);
			this.Func_button_2.Name = "Func_button_2";
			this.Func_button_2.Size = new System.Drawing.Size(56, 84);
			this.Func_button_2.TabIndex = 9;
			this.Func_button_2.Text = "2";
			this.Func_button_2.UseVisualStyleBackColor = true;
			this.Func_button_2.Click += new System.EventHandler(this.Func_button_2_Click);
			// 
			// Func_button_3
			// 
			this.Func_button_3.Location = new System.Drawing.Point(183, 24);
			this.Func_button_3.Margin = new System.Windows.Forms.Padding(2);
			this.Func_button_3.Name = "Func_button_3";
			this.Func_button_3.Size = new System.Drawing.Size(56, 84);
			this.Func_button_3.TabIndex = 10;
			this.Func_button_3.Text = "3";
			this.Func_button_3.UseVisualStyleBackColor = true;
			this.Func_button_3.Click += new System.EventHandler(this.Func_button_3_Click);
			// 
			// led1
			// 
			this.led1.BackColor = System.Drawing.Color.Gray;
			this.led1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.led1.Location = new System.Drawing.Point(244, 24);
			this.led1.Name = "led1";
			this.led1.Size = new System.Drawing.Size(56, 84);
			this.led1.TabIndex = 0;
			// 
			// led2
			// 
			this.led2.BackColor = System.Drawing.Color.Gray;
			this.led2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.led2.Location = new System.Drawing.Point(306, 24);
			this.led2.Name = "led2";
			this.led2.Size = new System.Drawing.Size(56, 84);
			this.led2.TabIndex = 0;
			// 
			// led3
			// 
			this.led3.BackColor = System.Drawing.Color.Gray;
			this.led3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.led3.Location = new System.Drawing.Point(368, 24);
			this.led3.Name = "led3";
			this.led3.Size = new System.Drawing.Size(56, 84);
			this.led3.TabIndex = 0;
			// 
			// led4
			// 
			this.led4.BackColor = System.Drawing.Color.Gray;
			this.led4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.led4.Location = new System.Drawing.Point(430, 24);
			this.led4.Name = "led4";
			this.led4.Size = new System.Drawing.Size(56, 84);
			this.led4.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(256, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "LED1";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(317, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "LED2";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(380, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "LED3";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(441, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(34, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "LED4";
			// 
			// textBox_log
			// 
			this.textBox_log.ContextMenuStrip = this.contextMenuStrip1;
			this.textBox_log.Location = new System.Drawing.Point(17, 244);
			this.textBox_log.Multiline = true;
			this.textBox_log.Name = "textBox_log";
			this.textBox_log.ReadOnly = true;
			this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox_log.Size = new System.Drawing.Size(472, 273);
			this.textBox_log.TabIndex = 0;
			this.textBox_log.TabStop = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
			// 
			// очиститьToolStripMenuItem
			// 
			this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
			this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.очиститьToolStripMenuItem.Text = "Очистить";
			this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(17, 228);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(153, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Протокол обработки команд";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(510, 330);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "Time refresh";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(510, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Файл настроек";
			// 
			// button_load
			// 
			this.button_load.Location = new System.Drawing.Point(602, 19);
			this.button_load.Name = "button_load";
			this.button_load.Size = new System.Drawing.Size(123, 23);
			this.button_load.TabIndex = 0;
			this.button_load.TabStop = false;
			this.button_load.Text = "Загрузить";
			this.button_load.UseVisualStyleBackColor = true;
			this.button_load.Click += new System.EventHandler(this.button_load_Click);
			// 
			// listBox_UserParameters
			// 
			this.listBox_UserParameters.FormattingEnabled = true;
			this.listBox_UserParameters.Location = new System.Drawing.Point(513, 48);
			this.listBox_UserParameters.Name = "listBox_UserParameters";
			this.listBox_UserParameters.Size = new System.Drawing.Size(252, 225);
			this.listBox_UserParameters.TabIndex = 0;
			this.listBox_UserParameters.TabStop = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(513, 289);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(252, 23);
			this.button2.TabIndex = 0;
			this.button2.TabStop = false;
			this.button2.Text = "<- Установить настройки";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// RemoteTerminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 547);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox_UserParameters);
			this.Controls.Add(this.button_load);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.time_refresh);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox_log);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.led4);
			this.Controls.Add(this.led3);
			this.Controls.Add(this.led2);
			this.Controls.Add(this.led1);
			this.Controls.Add(this.Func_button_3);
			this.Controls.Add(this.Func_button_2);
			this.Controls.Add(this.Func_button_1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.DeadMenSwitch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_server);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBox_service);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_thing);
			this.Controls.Add(this.button);
			this.Controls.Add(this.textBox_key);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RemoteTerminal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Удалённый терминал (RemoteTerminal)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoteTerminal_FormClosing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.time_refresh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeadMenSwitch)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel work_status;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox textBox_thing;
		private System.Windows.Forms.TextBox textBox_service;
		private System.Windows.Forms.TextBox textBox_key;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_server;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar DeadMenSwitch;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button Func_button_1;
		private System.Windows.Forms.Button Func_button_2;
		private System.Windows.Forms.Button Func_button_3;
		private System.Windows.Forms.Panel led1;
		private System.Windows.Forms.Panel led2;
		private System.Windows.Forms.Panel led3;
		private System.Windows.Forms.Panel led4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox_log;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown time_refresh;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button_load;
		private System.Windows.Forms.ListBox listBox_UserParameters;
		private System.Windows.Forms.Button button2;
	}
}


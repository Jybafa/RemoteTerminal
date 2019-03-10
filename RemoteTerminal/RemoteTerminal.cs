using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RemoteTerminal
{
	public partial class RemoteTerminal : Form
	{
		int b1 = 0, b2 = 0, b3 = 0;

		public RemoteTerminal()
		{
			InitializeComponent();
			try
			{
				foreach (string line in File.ReadLines("LastUserParameters.txt"))
				{
					string[] separator = new string[] { ";" };
					string[] strArray = line.Split(separator, StringSplitOptions.None);
					if (strArray.Length >= 4)
					{
						textBox_server.Text = strArray[0];
						textBox_thing.Text = strArray[1];
						textBox_service.Text = strArray[2];
						textBox_key.Text = strArray[3];
						return;
					}
				}
			}
			catch
			{
			}
		}

		Worker _worker;

		private void button_Click(object sender, EventArgs e)
		{
			if (button.Text == "Подключиться")
			{
				bool error = false;
				if (textBox_server.Text == "")
				{
					textBox_log.Text += "Ошибка! Сервер не указан\r\n";
					error = true;
				}
				if (textBox_key.Text == "")
				{
					textBox_log.Text += "Ошибка! AppKey не указан\r\n";
					error = true;
				}
				if (textBox_thing.Text == "")
				{
					textBox_log.Text += "Ошибка! Вещь не указана\r\n";
					error = true;
				}
				if (textBox_service.Text == "")
				{
					textBox_log.Text += "Ошибка! Сервис не указан\r\n";
					error = true;
				}
				if (error)
				{
					return;
				}
				_worker = new Worker();
				_worker.ProcessChanged += worker_ProcessChanged;
				_worker.WorkCompleted += worker_WorkCompleted;

				button.Text = "Отключиться";

				work_status.Text = "Отправка данных";

				Thread thread = new Thread(_worker.Work);
				thread.Start();
			}
			else
			{
				if (_worker != null)
				{
					_worker.Cancel();
					button.Text = "Подключиться";
				}
			}
		}

		private void worker_WorkCompleted(bool cancelled)
		{
			Action action = () =>
			{
				work_status.Text = "Отправка остановлена";
				button.Text = "Подключиться";
			};

			this.InvokeEx(action);
		}

		private void Func_button_1_Click(object sender, EventArgs e)
		{
			b1++;
		}

		private void Func_button_2_Click(object sender, EventArgs e)
		{
			b2++;
		}

		private void Func_button_3_Click(object sender, EventArgs e)
		{
			b3++;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			Worker.refresh_time = (int)time_refresh.Value*1000;
		}

		private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_log.Text = "";
		}

		private void button_load_Click(object sender, EventArgs e)
		{
			string path = "UserParameters.txt";
			listBox_UserParameters.Items.Clear();
			try
			{
				string[] strArray = File.ReadAllLines(path);
				foreach (string str in strArray)
				{
					if (str.Trim() != "")
					{
						listBox_UserParameters.Items.Add(str.Trim());
					}
				}
				listBox_UserParameters.SelectedIndex = 0;
			}
			catch
			{
				textBox_log.Text += "Не удаётся считать параметры пользователей";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int selectedIndex = this.listBox_UserParameters.SelectedIndex;
			if (selectedIndex >= 0)
			{
				string str = this.listBox_UserParameters.Items[selectedIndex].ToString();
				string[] separator = new string[] { ";" };
				try
				{
					string[] strArray2 = str.Split(separator, StringSplitOptions.None);
					if (strArray2.Length >= 5)
					{
						//this.IndividualUserLoginTextBox.Text = strArray2[0];
						textBox_server.Text = strArray2[1];
						textBox_thing.Text = strArray2[2];
						textBox_service.Text = strArray2[3];
						textBox_key.Text = strArray2[4];
					}
				}
				catch
				{
					textBox_log.Text += "Ошибка загрузки параметров пользователя";
				}
			}
			else
			{
				textBox_log.Text += "Ошибка загрузки параметров пользователя";
			}
		}

		private void RemoteTerminal_FormClosing(object sender, FormClosingEventArgs e)
		{
			using (StreamWriter sw = new StreamWriter("LastUserParameters.txt"))
			{
				sw.WriteLine(textBox_server.Text + ";" + textBox_thing.Text + ";" + textBox_service.Text + ";" + textBox_key.Text + ";");
			}
		}

		private void worker_ProcessChanged()
		{
			Action action = () =>
			{
				try
				{
					var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + textBox_server.Text + "/Thingworx/Things/" + textBox_thing.Text + "/Services/" + textBox_service.Text + "?method=post&appKey=" + textBox_key.Text + "&p=" + DeadMenSwitch.Value + "&b1=" + b1 + "&b2=" + b2 + "&b3=" + b3 +"&n=0");
					httpWebRequest.ContentType = "application/json";
					httpWebRequest.Method = "POST";
					var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					using (var streamReader = new StreamReader(httpResponse.GetResponseStream(), Encoding.ASCII))
					{
						var result = streamReader.ReadToEnd();
						result = result.Substring(result.IndexOf("<TD>") + 4, result.IndexOf("</TD>") - result.IndexOf("<TD>") - 4);
						result = result.Replace("&#x7b;", "{");
						result = result.Replace("&quot;", @"""");
						result = result.Replace("&#x3a;", ":");
						result = result.Replace("&#x7d;", "}");
						RootObject answer = JsonConvert.DeserializeObject<RootObject>(result);
						textBox_log.Text += result + "\r\n";

						led1.BackColor = led2.BackColor = led3.BackColor = led4.BackColor = Color.Gray;
						if (answer.L1 == 1)
						{
							led1.BackColor = Color.Blue;
						}
						if (answer.L2 == 1)
						{
							led2.BackColor = Color.Red;
						}
						if (answer.L3 == 1)
						{
							led3.BackColor = Color.Yellow;
						}
						if (answer.L4 == 1)
						{
							led4.BackColor = Color.Green;
						}
					}
				}
				catch (WebException ex)
				{
					/*WebExceptionStatus status = ex.Status;

					if (status == WebExceptionStatus.ProtocolError)
					{
						HttpWebResponse httpResponse = (HttpWebResponse)ex.Response;
						textBox_log.Text += "Статусный код ошибки: "+ (int)httpResponse.StatusCode + " - "+ httpResponse.StatusCode + "\r\n";
					}*/
					textBox_log.Text += ex.Message + "\r\n";
					_worker.Cancel();
				}
			};

			this.InvokeEx(action);
		}

		private void textBox__KeyPress_1(object sender, KeyPressEventArgs e)
		{
			if (Char.IsDigit(e.KeyChar) || e.KeyChar == (Char)Keys.Back) return;
			else
				e.Handled = true;
		}
	}

	public class RootObject
	{
		public float L1 { get; set; }
		public float L2 { get; set; }
		public float L3 { get; set; }
		public float L4 { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AnnounceTimer {
    public partial class Form1 : Form {

        string settingFile = "_setting.txt";

        string[] settingNames = new string[] { "団1", "団2", "団3" };

        DateTime startTime = DateTime.MinValue;
        string[] lines;
        string prevTime = "9:59";

        SpeakText speak = new SpeakText();
        Dictionary<string, string> delayString = new Dictionary<string, string>();

        DataGridViewCellStyle defaultStyle = new DataGridViewCellStyle();
        DataGridViewCellStyle endStyle = new DataGridViewCellStyle();

        public Form1() {
            InitializeComponent();

            endStyle.BackColor = Color.Gray;

            delayString.Add("00", "ぜろ");
            delayString.Add("01", "いち");
            delayString.Add("02", "に");
            delayString.Add("03", "さん");
            delayString.Add("04", "よん");
            delayString.Add("05", "ご");
            delayString.Add("06", "ろく");
            delayString.Add("07", "なな");
            delayString.Add("08", "はち");
            delayString.Add("09", "きゅう");
            delayString.Add("10", "じゅう");
            delayString.Add("11", "じゅういち");
            delayString.Add("12", "じゅうに");
            delayString.Add("13", "じゅうさん");
            delayString.Add("14", "じゅうよん");
            delayString.Add("15", "じゅうご");
            delayString.Add("16", "じゅうろく");
            delayString.Add("17", "じゅうなな");
            delayString.Add("18", "じゅうはち");
            delayString.Add("19", "じゅうきゅう");
            delayString.Add("20", "にじゅう");


            List<string> minutesItems = new List<string>();
            List<string> secondItems = new List<string>();
            List<string> announceItems = new List<string>();

            for (int i = 9; i >= 0; i--) {
                minutesItems.Add(i.ToString());
            }
            for (int i = 59; i >= 0; i--) {
                secondItems.Add(string.Format("{0:D2}", i));
            }
            for (int i = 20; i >= 0; i--) {
                announceItems.Add(string.Format("{0:D2}", i));
            }

            SettingComboBox.Items.AddRange(settingNames);

            MinutesComboBox.Items.AddRange(minutesItems.ToArray());
            SecondComboBox.Items.AddRange(secondItems.ToArray());
            AnnounceComboBox.Items.AddRange(announceItems.ToArray());

            MinutesComboBox.SelectedIndex = 0;
            SecondComboBox.SelectedIndex = 0;
            AnnounceComboBox.SelectedItem = "10";

            ChartDataGridView.ColumnCount = 3;

            // カラム名を指定
            ChartDataGridView.Columns[0].HeaderText = "時間";
            ChartDataGridView.Columns[1].HeaderText = "秒前";
            ChartDataGridView.Columns[2].HeaderText = "アナウンス";

            SettingComboBox.SelectedIndex = 0;

            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            startTime = DateTime.Now;
            button1.Enabled = false;
            button3.Enabled = true;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            string text = MinutesComboBox.SelectedItem.ToString() + ":" + SecondComboBox.SelectedItem.ToString() + "," + AnnounceComboBox.SelectedItem.ToString() + "," + AnnounceTextBox.Text;
            File.AppendAllText(SettingComboBox.SelectedItem.ToString() + settingFile, text + Environment.NewLine);
            SettingComboBox_SelectedIndexChanged(null, null);
        }

        private void SettingComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ChartDataGridView.Rows.Clear();
            if (File.Exists(SettingComboBox.SelectedItem.ToString() + settingFile)) {
                string fileText = File.ReadAllText(SettingComboBox.SelectedItem.ToString() + settingFile);
                lines = fileText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                lines = lines.OrderByDescending(x => (x.Split(new char[] { ',' })[0])).ToArray();
                for (int i = 0; i < lines.Length; i++) {
                    ChartDataGridView.Rows.Add(lines[i].Split(new char[] { ',' }));
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            DateTime nowTime = DateTime.Now;
            TimeSpan span = (nowTime - startTime);
            string remainTime = (9 - span.Minutes) + ":" + string.Format("{0:D2}", (59 - span.Seconds));
            string status = "";

            List<string> announs = lines.Where(x => totalSecond(prevTime) >= totalSecond((x.Split(new char[] { ',' })[0]), (x.Split(new char[] { ',' })[1])) && totalSecond((x.Split(new char[] { ',' })[0]), (x.Split(new char[] { ',' })[1])) > totalSecond(remainTime)).ToList();
            if(announs.Count > 0) {
                string[] text = announs[0].Split(new char[] { ',' });

                //speak.Speak("あと" + delayString[text[1]] + "びょうごに" + text[2]);
                status = announs[0];
            }

            for(int i = 0; i < ChartDataGridView.Rows.Count -1; i++) {
                if(totalSecond(ChartDataGridView.Rows[i].Cells[0].Value.ToString()) > totalSecond(remainTime)) {
                    ChartDataGridView.Rows[i].Cells[0].Style = endStyle;
                }
                else {
                    ChartDataGridView.Rows[i].Cells[0].Style = defaultStyle;
                }
            }

            label1.Text = remainTime;
            label2.Text = status;
            prevTime = remainTime;
        }

        private int totalSecond(string timeString) {
            string[] parts = timeString.Split(new char[] { ':' });
            return int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
        }
        private int totalSecond(string timeString, string appendSecond) {
            string[] parts = timeString.Split(new char[] { ':' });
            return int.Parse(parts[0]) * 60 + int.Parse(parts[1]) + int.Parse(appendSecond);
        }

        private void button3_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void ChartDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if(MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                int rowIndex = e.RowIndex;
                DataGridViewRow selextedRow = ChartDataGridView.Rows[rowIndex];
                string deleteString = selextedRow.Cells[0].Value + "," + selextedRow.Cells[1].Value + "," + selextedRow.Cells[2].Value;
                string fileText = File.ReadAllText(SettingComboBox.SelectedItem.ToString() + settingFile);
                fileText = fileText.Replace(deleteString + Environment.NewLine, "");
                File.WriteAllText(SettingComboBox.SelectedItem.ToString() + settingFile, fileText);
                SettingComboBox_SelectedIndexChanged(null, null);
            }
        }
    }
}

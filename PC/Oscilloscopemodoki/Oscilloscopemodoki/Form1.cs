using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscopemodoki
{
    public partial class Form1 : Form
    {
        Bitmap canvas; // 画像描画するbitmap
        double ad_input = 0.0; // A/D入力値
        double ad_input_old = 0.0; // A/D入力値一個古い分(線描画用)
        int scroll_num = 5; // グラフ横移動ピクセル数

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGraph();
            try 
	        {
                cmb_com_portname.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                cmb_com_portname.SelectedIndex = 0;
	         }
        	catch (Exception)   
            {
                MessageBox.Show("シリアルポートが見つかりません", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cmb_com_portname.Enabled  = false;
                btnStart.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) {
                timer1.Enabled = false;
                serialPort1.Close();
                btnStart.Text = "開始";
            } else {
                serialPort1.PortName = cmb_com_portname.SelectedItem.ToString();
                serialPort1.Open();

                timer1.Enabled = true;
                btnStart.Text = "停止";
                ResetGraph();
            }

        }

        /// <summary>
        /// グラフ描画を初期化
        /// </summary>
        private void ResetGraph() {
            canvas = new Bitmap(pb_graph.Width, pb_graph.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(Brushes.White, 0, 0, canvas.Width, canvas.Height);
            g.DrawLine(Pens.Black, 0, canvas.Height / 2, canvas.Width, canvas.Height / 2);
            g.Dispose();
            pb_graph.Image = canvas;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;

            lbl_ad_value.Text = ad_input.ToString();
            DrawGraph();

            //timer1.Enabled = true;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            string[] spline = line.Split(',');
            ad_input = double.Parse(spline[1]);
        }

        /// <summary>
        /// 波形描画
        /// </summary>
        private void DrawGraph()
        {
            int x1, x2, y1, y2;


            pb_graph.Visible = false;

            try
            {
                Graphics g;
                Bitmap bmx;
                g = Graphics.FromImage(canvas);

                // 画像移動
                bmx = canvas;
                g.DrawImage(bmx, -1 * scroll_num, 0); // 左へ移動
                g.FillRectangle(Brushes.White, canvas.Width - scroll_num, 0, canvas.Width - 1, canvas.Height); // ゴミ削除用
                pb_graph.Image = bmx;

                // 軸描画
                g.DrawLine(Pens.Black, 0, canvas.Height / 2, canvas.Width, canvas.Height / 2);

                // LPF計算
                //ad_input_lpf = ad_input * 0.1 + ad_input_lpf * 0.9;
                
                // 波形描画
                x1 = pb_graph.Width - scroll_num;
                y1 = (int)((pb_graph.Height / 2) - (ad_input_old * 49));
                x2 = pb_graph.Width - 1;
                y2 = (int)((pb_graph.Height / 2) - (ad_input * 49));
                g.DrawLine(Pens.Red, x1, y1, x2, y2);

                g.Dispose();
                pb_graph.Image = canvas;

                // 次の線描画のために値を保存
                ad_input_old = ad_input;

            }
            catch (Exception)
            {
                
            }

            // 表示
            pb_graph.Visible = true;


        }

    }
}

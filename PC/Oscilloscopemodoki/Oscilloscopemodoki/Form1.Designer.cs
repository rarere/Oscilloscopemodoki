namespace Oscilloscopemodoki
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_com = new System.Windows.Forms.Label();
            this.pb_graph = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmb_com_portname = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl_v = new System.Windows.Forms.Label();
            this.lbl_ad_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(10, 15);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(32, 12);
            this.lbl_com.TabIndex = 0;
            this.lbl_com.Text = "COM:";
            // 
            // pb_graph
            // 
            this.pb_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_graph.BackColor = System.Drawing.SystemColors.Window;
            this.pb_graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_graph.Location = new System.Drawing.Point(14, 39);
            this.pb_graph.Name = "pb_graph";
            this.pb_graph.Size = new System.Drawing.Size(758, 510);
            this.pb_graph.TabIndex = 1;
            this.pb_graph.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmb_com_portname
            // 
            this.cmb_com_portname.FormattingEnabled = true;
            this.cmb_com_portname.Location = new System.Drawing.Point(48, 12);
            this.cmb_com_portname.Name = "cmb_com_portname";
            this.cmb_com_portname.Size = new System.Drawing.Size(121, 20);
            this.cmb_com_portname.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(175, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_v
            // 
            this.lbl_v.AutoSize = true;
            this.lbl_v.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_v.Location = new System.Drawing.Point(15, 41);
            this.lbl_v.Name = "lbl_v";
            this.lbl_v.Size = new System.Drawing.Size(15, 12);
            this.lbl_v.TabIndex = 4;
            this.lbl_v.Text = "V:";
            // 
            // lbl_ad_value
            // 
            this.lbl_ad_value.AutoSize = true;
            this.lbl_ad_value.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ad_value.Location = new System.Drawing.Point(28, 41);
            this.lbl_ad_value.Name = "lbl_ad_value";
            this.lbl_ad_value.Size = new System.Drawing.Size(11, 12);
            this.lbl_ad_value.TabIndex = 5;
            this.lbl_ad_value.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "t";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ad_value);
            this.Controls.Add(this.lbl_v);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmb_com_portname);
            this.Controls.Add(this.pb_graph);
            this.Controls.Add(this.lbl_com);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "オシロスコープもどき";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.PictureBox pb_graph;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_com_portname;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl_v;
        private System.Windows.Forms.Label lbl_ad_value;
        private System.Windows.Forms.Label label1;
    }
}


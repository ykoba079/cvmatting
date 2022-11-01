
namespace winCVTest01
{
    partial class frm特徴点
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.picA = new System.Windows.Forms.PictureBox();
            this.picB = new System.Windows.Forms.PictureBox();
            this.btn拡大表示 = new System.Windows.Forms.Button();
            this.btn拡大表示B = new System.Windows.Forms.Button();
            this.btnマッチング = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            this.SuspendLayout();
            // 
            // picA
            // 
            this.picA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picA.Location = new System.Drawing.Point(1, 42);
            this.picA.Name = "picA";
            this.picA.Size = new System.Drawing.Size(387, 534);
            this.picA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picA.TabIndex = 0;
            this.picA.TabStop = false;
            this.picA.DragDrop += new System.Windows.Forms.DragEventHandler(this.picA_DragDrop);
            this.picA.DragEnter += new System.Windows.Forms.DragEventHandler(this.picA_DragEnter);
            // 
            // picB
            // 
            this.picB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB.Location = new System.Drawing.Point(393, 42);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(387, 534);
            this.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB.TabIndex = 1;
            this.picB.TabStop = false;
            this.picB.DragDrop += new System.Windows.Forms.DragEventHandler(this.picB_DragDrop);
            this.picB.DragEnter += new System.Windows.Forms.DragEventHandler(this.picB_DragEnter);
            // 
            // btn拡大表示
            // 
            this.btn拡大表示.Location = new System.Drawing.Point(12, 4);
            this.btn拡大表示.Name = "btn拡大表示";
            this.btn拡大表示.Size = new System.Drawing.Size(105, 32);
            this.btn拡大表示.TabIndex = 2;
            this.btn拡大表示.Text = "拡大表示";
            this.btn拡大表示.UseVisualStyleBackColor = true;
            this.btn拡大表示.Click += new System.EventHandler(this.btn原寸表示_Click);
            // 
            // btn拡大表示B
            // 
            this.btn拡大表示B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn拡大表示B.Location = new System.Drawing.Point(663, 4);
            this.btn拡大表示B.Name = "btn拡大表示B";
            this.btn拡大表示B.Size = new System.Drawing.Size(105, 32);
            this.btn拡大表示B.TabIndex = 3;
            this.btn拡大表示B.Text = "拡大表示";
            this.btn拡大表示B.UseVisualStyleBackColor = true;
            this.btn拡大表示B.Click += new System.EventHandler(this.btn原寸表示B_Click);
            // 
            // btnマッチング
            // 
            this.btnマッチング.Location = new System.Drawing.Point(338, 4);
            this.btnマッチング.Name = "btnマッチング";
            this.btnマッチング.Size = new System.Drawing.Size(105, 32);
            this.btnマッチング.TabIndex = 4;
            this.btnマッチング.Text = "マッチング";
            this.btnマッチング.UseVisualStyleBackColor = true;
            this.btnマッチング.Click += new System.EventHandler(this.btnマッチング_Click);
            // 
            // frm特徴点
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 574);
            this.Controls.Add(this.btnマッチング);
            this.Controls.Add(this.btn拡大表示B);
            this.Controls.Add(this.btn拡大表示);
            this.Controls.Add(this.picB);
            this.Controls.Add(this.picA);
            this.Name = "frm特徴点";
            this.Text = "OpenCV_特徴点を出すだけ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frm特徴点_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picA;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.Button btn拡大表示;
        private System.Windows.Forms.Button btn拡大表示B;
        private System.Windows.Forms.Button btnマッチング;
    }
}


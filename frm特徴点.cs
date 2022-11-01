using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;       // Bitmap変換に必要

namespace winCVTest01
{
    public partial class frm特徴点 : Form
    {

        AKAZE objAkaze = AKAZE.Create();
        Mat mt元画像A = new Mat();
        Mat mt特徴点A = new Mat();
        Mat mt特徴描画A = new Mat();
        KeyPoint[] ptKeyPointA;
        Image img特徴画像A;

        Mat mt元画像B = new Mat();
        Mat mt特徴点B = new Mat();
        Mat mt特徴描画B = new Mat();
        KeyPoint[] ptKeyPointB;
        Image img特徴画像B;

        DescriptorMatcher objMatcher; //マッチング
        DMatch[] lstMatches; //特徴量ベクトル同士のマッチング結果を格納する配列

        public frm特徴点()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            picA.AllowDrop = true;
            picB.AllowDrop = true;
        }
        private void frm特徴点_Resize(object sender, EventArgs e)
        {
            picA.Width = this.Width / 2 - 10;
            picB.Width = this.Width / 2 - 10;
            picB.Left = this.Width / 2 + 10;
        }

        private void picA_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void picA_DragDrop(object sender, DragEventArgs e)
        {
            string filename = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            try
            {
                Mat mt元画像A = Cv2.ImRead(filename);
                objAkaze.DetectAndCompute(mt元画像A, null, out ptKeyPointA, mt特徴点A);
                Cv2.DrawKeypoints(mt元画像A, ptKeyPointA, mt特徴描画A);
                img特徴画像A = BitmapConverter.ToBitmap(mt特徴描画A);
                picA.Image = img特徴画像A;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void picB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void picB_DragDrop(object sender, DragEventArgs e)
        {
            string filename = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            try
            {
                Mat mt元画像B = Cv2.ImRead(filename);
                objAkaze.DetectAndCompute(mt元画像B, null, out ptKeyPointB, mt特徴点B);
                Cv2.DrawKeypoints(mt元画像B, ptKeyPointB, mt特徴描画B);
                 img特徴画像B = BitmapConverter.ToBitmap(mt特徴描画B);
                picB.Image = img特徴画像B;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

        }

        private void btn原寸表示_Click(object sender, EventArgs e)
        {
            frm表示用 obj表示用 = new frm表示用();
            obj表示用.p_img表示 = img特徴画像A;
            obj表示用.Show();

        }

        private void btn原寸表示B_Click(object sender, EventArgs e)
        {
            frm表示用 obj表示用 = new frm表示用();
            obj表示用.p_img表示 = img特徴画像B;
            obj表示用.Show();
        }

        private void btnマッチング_Click(object sender, EventArgs e)
        {


            objMatcher = DescriptorMatcher.Create("BruteForce");
            lstMatches = objMatcher.Match(mt特徴点A , mt特徴点B);

            // マッチングした特徴量同士を線でつなぐ
            Mat mtマッチング = new Mat(); //繋いだ画像の領域
            Cv2.DrawMatches(mt特徴描画A, ptKeyPointA, mt特徴描画B, ptKeyPointB, lstMatches, mtマッチング);

            frm表示用 obj表示用 = new frm表示用();
            obj表示用.p_img表示 = BitmapConverter.ToBitmap(mtマッチング);
            obj表示用.Show();
        }
    }
}

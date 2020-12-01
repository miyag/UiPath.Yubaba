using System;
using System.Windows.Forms;
using Microsoft.Ink;

namespace ContractWithYubaba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.DisplayMember = "Name";

            // インストールされている手書き認識エンジンの取得
            Recognizers recognizers = new Recognizers();
            Recognizers.RecognizersEnumerator recognizersEnum = 
                recognizers.GetEnumerator();
            while (recognizersEnum.MoveNext())
            {
                // ListBoxに追加
                Recognizer recognizer = (Recognizer)recognizersEnum.Current;
                listBox1.Items.Add(recognizer);
            }
        }

        private void buttonInk_Click(object sender, EventArgs e)
        {
            inkPicture1.EditingMode = Microsoft.Ink.InkOverlayEditingMode.Ink;
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            inkPicture1.EditingMode = Microsoft.Ink.InkOverlayEditingMode.Delete;
        }

        private void buttonRecognize_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("手書き認識エンジンを選択してください");
                return;
            }
            if (inkPicture1.Ink.Strokes.Count == 0)
            {
                MessageBox.Show("手書きが行われていません");
                return;
            }
            Recognizer recognizer = (Recognizer)listBox1.SelectedItem;
            RecognizerContext context = recognizer.CreateRecognizerContext();
            context.Strokes = inkPicture1.Ink.Strokes;
            context.EndInkInput();
            RecognitionStatus status;
            RecognitionResult result = context.Recognize(out status);
            if (status != RecognitionStatus.NoError)
            {
                MessageBox.Show("認識に失敗しました:" + status);
                return;
            }
            labelNameRecognized.Visible = true;
            labelNameRecognized.Text = result.TopString;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            buttonInk.Enabled = false;
            buttonErase.Enabled = false;
            buttonRecognize.Enabled = false;
            buttonOk.Enabled = false;
            listBox1.Enabled = false;
            labelSigned.Visible = true;
        }
    }
}

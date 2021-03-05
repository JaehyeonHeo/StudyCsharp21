using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name); 
            }
        }

        private void ChangeFont() // ==> 콤보박스, 체크박스 값변경으로 글자체 변경하는 메서드 
        {
            if (CboFont.SelectedIndex < 0) return;    // 콤보선택값의 인덱스가 없으면 메서드 탈출 

            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold;
            if (ChkItalic.Checked) style |= FontStyle.Italic;

            TxtResult.Font = new Font((string)CboFont.SelectedItem, 14, style); 
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont(); 
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrbHandle_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = TrbHandle.Value; 
        }
    }
}

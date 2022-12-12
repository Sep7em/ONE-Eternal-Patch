using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ONE_Eternal_Patch
{
    public partial class ONE_Eternal_Patch_Gui : Form
    {
        public ONE_Eternal_Patch_Gui()
        {
            InitializeComponent();
        }

        private void radioButtonJapaneseAndEnglish_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            
            //It's only useful to know the edition with the Japanese and English languages
            if (rb.Checked)
            {
                groupBoxEdition.Enabled = true;
            }

            radioButtonsCheckedChanged(sender, e);
        }

        private void radioButtonSpanishAndChinese_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                groupBoxEdition.Enabled = false;
                radioButtonFullVoice.Checked = false;
                radioButtonVista.Checked = false;
            }

            radioButtonsCheckedChanged(sender, e);
        }

        private void radioButtonsCheckedChanged(object sender, EventArgs e)
        {
            //Reset Natsuki's sprite if the user changes an option
            pictureBox.Image = ONE_Eternal_Patch_GUI.Properties.Resources.CGNT01;

            if (textBox.Text.Length <= 0 ||
                (!radioButtonJapanese.Checked && !radioButtonEnglish.Checked && !radioButtonSpanish.Checked && !radioButtonChinese.Checked) ||
                ((radioButtonJapanese.Checked || radioButtonEnglish.Checked) && !radioButtonFullVoice.Checked && !radioButtonVista.Checked) ||
                (!radioButtonEnableCGs.Checked && !radioButtonDisableCGs.Checked) ||
                (!radioButtonAllAges.Checked && !radioButtonHScenes.Checked))
                buttonPatch.Enabled = false;
            else
                buttonPatch.Enabled = true;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonPatch_Click(object sender, EventArgs e)
        {
            string edition;
            string language;
            string bonusCG;
            string aaContent;
            string sepChar = Path.DirectorySeparatorChar.ToString();
            string altChar = Path.AltDirectorySeparatorChar.ToString();

            if (!textBox.Text.EndsWith(sepChar) && !textBox.Text.EndsWith(altChar))
            {
                textBox.Text += sepChar;
            }

            if (radioButtonVista.Checked)
                edition = "2";
            //For the Full Voice Edition and for the Spanish and Chinese languages
            else
                edition = "1";

            if (radioButtonJapanese.Checked)
                language = "1";
            else if (radioButtonEnglish.Checked)
                language = "2";
            else if (radioButtonSpanish.Checked)
                language = "3";
            else
                language = "4";

            if (radioButtonEnableCGs.Checked)
                bonusCG = "1";
            else
                bonusCG = "2";

            if (radioButtonAllAges.Checked)
                aaContent = "1";
            else
                aaContent = "2";

            richTextBox.Text = "";
            richTextBox.ForeColor = Color.Black;

            ONE_Eternal_Patch.Patch(edition, language, bonusCG, aaContent, textBox.Text, richTextBox);
            
            //Error: Natsuki is sad
            if (richTextBox.ForeColor == Color.Red)
                pictureBox.Image = ONE_Eternal_Patch_GUI.Properties.Resources.CGNT04;
            //Success: Natsuki is happy
            else
                pictureBox.Image = ONE_Eternal_Patch_GUI.Properties.Resources.CGNT03;

        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            //If an error isn't being displayed we make the textbox scrolls
            if (richTextBox.ForeColor == Color.Black)
            {
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.ScrollToCaret();
            }
        }
    }
}

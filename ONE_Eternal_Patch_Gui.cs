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

            //Line needed to be able to display Japanese characters in the richTextBox without breaking the font
            richTextBox.LanguageOption = RichTextBoxLanguageOptions.DualFont | RichTextBoxLanguageOptions.UIFonts;
        }

        private void RadioButtonJapaneseAndEnglish_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            
            //It's only useful to know the edition with the Japanese and English languages
            if (rb.Checked)
            {
                groupBoxEdition.Enabled = true;
            }

            RadioButtonsCheckedChanged(sender, e);
        }

        private void RadioButtonSpanishChineseAndKorean_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                groupBoxEdition.Enabled = false;
                radioButtonFullVoice.Checked = false;
                radioButtonVista.Checked = false;
            }

            RadioButtonsCheckedChanged(sender, e);
        }

        private void RadioButtonsCheckedChanged(object sender, EventArgs e)
        {
            //Reset Natsuki's sprite if the user changes an option
            pictureBox.Image = ONE_Eternal_Patch_GUI.Properties.Resources.CGNT01;

            if (textBox.Text.Length <= 0 ||
                (!radioButtonJapanese.Checked && !radioButtonEnglish.Checked && !radioButtonSpanish.Checked && !radioButtonChinese.Checked && !radioButtonKorean.Checked) ||
                ((radioButtonJapanese.Checked || radioButtonEnglish.Checked) && !radioButtonFullVoice.Checked && !radioButtonVista.Checked) ||
                ((radioButtonJapanese.Checked || radioButtonEnglish.Checked || radioButtonSpanish.Checked || radioButtonChinese.Checked) && !radioButtonAllAges.Checked && !radioButtonHScenes.Checked) ||
                (!radioButtonEnablePS1.Checked && !radioButtonDisablePS1.Checked) ||
                (!radioButtonKorean.Checked && !radioButtonAllAges.Checked && !radioButtonHScenes.Checked) ||
                (!radioButtonEnableMiscellaneous.Checked && !radioButtonDisableMiscellaneous.Checked))
                buttonPatch.Enabled = false;
            else
                buttonPatch.Enabled = true;

            if (radioButtonJapanese.Checked || radioButtonEnglish.Checked || radioButtonSpanish.Checked)
                groupBoxPS1.Text = "PS1 (New CGs + Natsuki's route)";
            else if (radioButtonChinese.Checked || radioButtonKorean.Checked)
                groupBoxPS1.Text = "PS1 (New CGs)";
            else
                groupBoxPS1.Text = "PS1";

            if (radioButtonKorean.Checked) {
                groupBoxAdultContent.Enabled = false;
                radioButtonAllAges.Checked = false;
                radioButtonHScenes.Checked = false;
            }
            else
                groupBoxAdultContent.Enabled = true;
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonPatch_Click(object sender, EventArgs e)
        {
            Edition edition;
            Language language;
            bool PS1Content = false;
            bool aaContent = false;
            bool miscContent = false;
            string sepChar = Path.DirectorySeparatorChar.ToString();
            string altChar = Path.AltDirectorySeparatorChar.ToString();

            if (!textBox.Text.EndsWith(sepChar) && !textBox.Text.EndsWith(altChar))
            {
                textBox.Text += sepChar;
            }

            if (radioButtonVista.Checked)
                edition = Edition.VI;
            //For the Full Voice Edition and for the Spanish, Chinese and Korean languages
            else
                edition = Edition.FV;

            if (radioButtonJapanese.Checked)
                language = Language.JP;
            else if (radioButtonEnglish.Checked)
                language = Language.EN;
            else if (radioButtonSpanish.Checked)
                language = Language.SP;
            else if (radioButtonChinese.Checked)
                language = Language.CH;
            else
                language = Language.KR;

            if (radioButtonEnablePS1.Checked)
                PS1Content = true;

            if (radioButtonAllAges.Checked)
                aaContent = true;

            if (radioButtonEnableMiscellaneous.Checked)
                miscContent = true;

            richTextBox.Text = "";
            richTextBox.ForeColor = Color.Black;

            ONE_Eternal_Patch.Patch(edition, language, PS1Content, aaContent, miscContent, textBox.Text, richTextBox);
            
            //Error: Natsuki is sad
            if (richTextBox.ForeColor == Color.Red)
                pictureBox.Image = ONE_Eternal_Patch_GUI.Properties.Resources.CGNT04;
            //Success: Natsuki is happy
            else
                pictureBox.Image = ONE_Eternal_Patch_GUI.Properties.Resources.CGNT03;

        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            //If an error isn't being displayed we make the textbox scrolls
            if (richTextBox.ForeColor == Color.Black)
            {
                richTextBox.Text += "\n";
                richTextBox.SelectionStart = richTextBox.Text.Length;
                richTextBox.ScrollToCaret();
                //The caret needs to be refreshed twice to prevent the textbox from jumping when text is written on the current line
                richTextBox.ScrollToCaret();
                richTextBox.Text = richTextBox.Text.Remove(richTextBox.Text.Length - 1, 1);
            }
        }
    }
}

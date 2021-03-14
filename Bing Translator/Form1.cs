using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_translate_Click(object sender, EventArgs e)
        {
            string strTranslatedText = null;
            try
            {
                TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();
                client = new TranslatorService.LanguageServiceClient();
                strTranslatedText = client.Translate("6CE9C85A41571C050C379F60DA173D286384E0F2", txt_input.Text, "en", "vi");
                txt_output.Text = strTranslatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

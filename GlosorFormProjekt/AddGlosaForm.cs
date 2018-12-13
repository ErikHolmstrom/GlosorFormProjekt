using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlosorFormProjekt
{
    public partial class AddGlosaForm : Form
    {

        private GlosorForm glosorForm;

        public AddGlosaForm(GlosorForm formBack)
        {
            this.glosorForm = formBack;
            InitializeComponent();
        }

        private void AddGlosaForm_Load(object sender, EventArgs e)
        {

        }

        private void cancel_button_click(object sender, EventArgs e)
        {
            goBackToOriginalForm();
        }

        //Saves a glosa to file
        private void save_button_click(object sender, EventArgs e)
        {
            Glosa glosa = new Glosa(this.textBox1.Text, this.textBox2.Text);
            XmlController xmlCtrl = new XmlController();
            xmlCtrl.WriteGlosaToXml(glosa);
                
            //System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            goBackToOriginalForm();
        }

        private void goBackToOriginalForm()
        {
            glosorForm.Show();
            this.Hide();
        }
    }
}

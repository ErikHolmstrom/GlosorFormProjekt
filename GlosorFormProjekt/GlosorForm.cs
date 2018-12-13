using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlosorFormProjekt
{
    public partial class GlosorForm : Form
    {
        public GlosorForm()
        {
            InitializeComponent();            
        }

        private void GlosorForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGlosaForm addGlosaForm = new AddGlosaForm(this);
            addGlosaForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlController xmlCtrl = new XmlController();
            Console.WriteLine(xmlCtrl.readFullXml());
           // Console.WriteLine(Environment.SpecialFolder.add);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ServiceRef;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        ServiceContextClient service;
        public Form3(ServiceContextClient _service)
        {
            InitializeComponent();
            service = _service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationRequest request = new RegistrationRequest() { login = textBox1.Text, password = textBox2.Text, numbers = textBox3.Text };
            string s = service.Registration(request).message;
            if (s == "Password or login not founded")
            {
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
                Form4 form4 = new Form4(service);
                form4.Show();
            }
        }
    }
}

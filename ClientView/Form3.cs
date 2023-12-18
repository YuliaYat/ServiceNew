using ClientView.ServiceRef;
using System;
using System.Windows.Forms;

namespace ClientView
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
            
            Service.Requests.Registration request = new Service.Requests.Registration() { login = textBox1.Text, password = textBox2.Text, numbers = textBox3.Text };
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

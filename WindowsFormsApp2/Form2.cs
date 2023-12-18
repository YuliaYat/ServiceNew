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
using Service.Requests;
using AutorizationRequest = WindowsFormsApp2.ServiceRef.AutorizationRequest;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        ServiceContextClient service;

        public Form2(ServiceContextClient _service)
        {
            InitializeComponent();
            service = _service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutorizationRequest request = new AutorizationRequest() { login = textBox1.Text, password = textBox2.Text};
            string s = service.Autorization(request).message;
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

//Autorization autorization = new Autorization() { login = textBox1.Text, password = textBox2.Text };
//string s = sc.Autorization(autorization).message;
//if (s == "Password or login not founded")
//{
//    MessageBox.Show(s);
//}
//else
//{
//    MessageBox.Show(s);
//    Form3 form3 = new Form3(sc);
//    form3.Show();
//}
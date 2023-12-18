using Service;
using System;
using System.Windows.Forms;
using Service.Requests;
using WindowsFormsApp1.ServiceContext;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServiceContextClient service = new ServiceContextClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Service.Requests.RegistrationRequest request = new Service.Requests.RegistrationRequest() {login = "asdsad",password = " asdasdasdsa", numbers = "89" };
            service.Registration(request);
            
        }

        
    }
}

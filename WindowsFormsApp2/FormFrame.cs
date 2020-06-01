using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormFrame : Form
    {
        static FormFrame instance;
   
        public static FormFrame getInstance()
        {
            if (instance == null)
                new FormFrame();
            return instance;
        }

        public FormFrame()
        {
            Console.WriteLine("ts");
            instance = this;
            InitializeComponent();
            FormSignIn formSignIn = FormSignIn.getInstance();
            formSignIn.Show();
        }
    }
}

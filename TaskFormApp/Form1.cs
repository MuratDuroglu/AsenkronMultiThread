using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskFormApp
{
    public partial class Form1 : Form
    {
        public int Counter { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

          

            string dataa =  await ReadFileAsync();
            richTextBox1.Text = dataa;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Counter++.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private string ReadFile()
        {
            string data = string.Empty;
            using (StreamReader s = new StreamReader("sorgularmilenferre.txt"))
            {
                Thread.Sleep(5000);

                data=s.ReadToEnd(); 
            }
          return data; 


        }



        private  async Task<string> ReadFileAsync()
        {
            string data = string.Empty;

            using (StreamReader s=new StreamReader("sorgularmilenferre.txt"))
            {
               Task<string> a= s.ReadToEndAsync();


                //Burda başka işllemlerde yapılabilir....

                 await  Task.Delay(5000);    

                data = await a;

                return data;
            }


        }
    }
}

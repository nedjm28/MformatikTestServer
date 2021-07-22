using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MformatikTestService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public void OnDubag()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            Label lab1 = new Label();
            lab1.Size = new Size(150, 14);
            lab1.AutoSize = true;


            while (true)
            {
                Form form_v = new Form();
                form_v.Size = new Size(250, 50);
                form_v.Text = "MformatikTestService";
                form_v.StartPosition = FormStartPosition.CenterScreen;
                form_v.FormBorderStyle = FormBorderStyle.None;
                form_v.BackColor = Color.WhiteSmoke;
                set_text(lab1);
                form_v.Controls.Add(lab1);
                new ParalleCode().CLoseFormAfterTenSecond(form_v, 10000); //duration 10s to close
                form_v.ShowDialog();
                Task t2 = Task.Delay(2000);//duration 2 min
                t2.Wait();
                

            }
        }


        public void set_text(Label lb1)
        {
            lb1.Text = "Hellow " + DateTime.Now.ToString("dddd d MMM yyy");

            
        }

        protected override void OnStop()
        {
        }
    }
    class ParalleCode
    {
        public async Task CLoseFormAfterTenSecond(Form form_i, int x)
        {
            await Task.Delay(x);
            form_i.Close();

        }

       
    }
}

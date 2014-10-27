using System;
using System.ServiceModel;
using System.Windows.Forms;
using CounterServiceCommon;

namespace CounterClientWinFormsManual
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeCounter();
        }

        private void InitializeCounter()
        {

        }

        private void IncBtnClick(object sender, EventArgs e)
        {

        }

        private void DecBtnClick(object sender, EventArgs e)
        {

        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Uncomment this!
            //if (channelFactory.State != CommunicationState.Closed)
            //{
            //    channelFactory.Close();
            //}
        }

        delegate void UpdateDel(int result);
        private void SafeUpdate(int result)
        {
            if (textBox1.InvokeRequired)
            {
                UpdateDel del = SafeUpdate;
                textBox1.Invoke(del, new object[] { result });
            }
            else
            {
                textBox1.Text = result.ToString();
            }
        }
    }
}
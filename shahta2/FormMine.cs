using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shahta2
{
    public partial class FormMine : Form
    {
        public FormMine()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FormMine_Load(object sender, EventArgs e)
        {

        }
        public void Show(int ore,int worker)
        {
            labelOre.Text = "Ore: " + ore.ToString();
            labelWorker.Text = "Worker: " + worker.ToString();
        }
    }
}
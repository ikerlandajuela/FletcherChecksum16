using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FletcherChecksum16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtTrmHex.Focus();
        }

        private byte Calcula_CRC(string cmd)
        {
            ulong suma=0;
            int i=0;
            for (i = 0; i < cmd.Length; i++)
            {
                suma+=cmd[i];
            }

            return (byte)(suma & 0xFF);              
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTrmHex.Text.Equals(""))
            {
                MessageBox.Show(this, "No puedes dejar el campo vacio", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                txtCRC.Text = String.Format("{0,2:X}", Calcula_CRC(txtTrmHex.Text));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCRC.Text = "";
            txtTrmHex.Text = "";

        }

        private void btnQuitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTrmHex_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter) 
            {
                if (txtTrmHex.Text.Equals(""))
                {
                    MessageBox.Show(this, "No puedes dejar el campo vacio", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                
                    txtCRC.Text = String.Format("{0,2:X}", Calcula_CRC(txtTrmHex.Text));
                }

            } 
        }

      
      
    }
}

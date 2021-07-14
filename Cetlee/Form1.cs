using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cetlee
{
    public partial class Form1 : Form
    {
        public string user, pecset;
        public static class Jogok
        {
            public static string jog;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Jogok' table. You can move, or remove it, as needed.
            this.jogokTableAdapter.Fill(this.dataSet1.Jogok);
            System.Security.Principal.WindowsIdentity currentUser = System.Security.Principal.WindowsIdentity.GetCurrent();
            user = Environment.UserName;
            Számlák childForm = new Számlák();
            childForm.MdiParent = this;
            childForm.Show();
            Jogosult();
        }
        private void Jogosult()
        {
            int itemFound = JogokBindingSource.Find("Jogosult", user);
            if (itemFound < 0)
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            else
            {
                DataTable joguDataTable = dataSet1.Tables["Jogok"];
                joguDataTable.PrimaryKey =
                     new DataColumn[]
                    {
                     joguDataTable.Columns["Jogosult"]
                    };
                DataRow jogi = joguDataTable.Rows.Find(user);
                foreach (DataColumn myDataColumn in joguDataTable.Columns)
                {
                   Jogok.jog = jogi["Cetlee_Jog"].ToString();
                    pecset = jogi["Pecset"].ToString().Trim();
                }
            }
        }
        private void closeMdis()
        {
            foreach (Form c in this.MdiChildren)
                c.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            closeMdis();
            Számlák childForm = new Számlák();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (Jogok.jog.Trim() == "A" || Jogok.jog.Trim() == "E")
            {
                closeMdis();
                Jovahagy childForm = new Jovahagy();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Jogok.jog.Trim() == "A" || Jogok.jog.Trim() == "K")
            {
                closeMdis();
                Konyvelheto childForm = new Konyvelheto();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Jogok.jog.Trim() == "A" || Jogok.jog.Trim() == "R")
            {
                closeMdis();
                Felvitel childForm = new Felvitel();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (Jogok.jog.Trim() == "A" || Jogok.jog.Trim() == "B")
            {
                closeMdis();
                AlvallFelvitel childForm = new AlvallFelvitel();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            closeMdis();
           Lekerdezes childForm = new Lekerdezes();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (Jogok.jog.Trim() == "A" || Jogok.jog.Trim() == "B")
            {
                closeMdis();
                BomFelvitel childForm = new  BomFelvitel();
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("ACCESZ DINÁJDID !", "Figyelmeztetés", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
            }
        }

    }
}

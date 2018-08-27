using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootCDNAPIDemo
{
    public partial class FrmLibraries : FrmBaseDocument
    {
        public FrmLibraries()
        {
            InitializeComponent();
        }

        private void FrmLibraries_Load(object sender, EventArgs e)
        {
            LibrariesModels librariesModel = StCloud.GetSingle().GetLibraries();
            foreach(LibrariesModel model in librariesModel.ListLibraries)
            {
                this.lstLibrarie.Items.Add(model);
            }
            this.lstLibrarie.SelectedIndex = 0;
        }

        private void lstLibrarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            LibrariesModel model = this.lstLibrarie.SelectedItem as LibrariesModel;
            if(model != null)
            {
                this.txtName.Text = model.name;
                this.txtDesc.Text = model.desc;
                this.txtStarts.Text = model.stars;
            }
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            string query = this.txtQuery.Text;
            foreach(LibrariesModel model in this.lstLibrarie.Items)
            {
                if(model.name.Contains(query))
                {
                    this.lstLibrarie.SelectedItem = model;
                    break;
                }
            }
        }

        private void btnDetailed_Click(object sender, EventArgs e)
        {
            LibrariesModel model = this.lstLibrarie.SelectedItem as LibrariesModel;
            if (model != null)
            {
                FrmDetailed frm = new FrmDetailed();
                frm.Name = model.name;
                frm.ShowDialog(this);
            }
        }
    }
}

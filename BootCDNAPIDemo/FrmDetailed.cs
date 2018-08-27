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
    public partial class FrmDetailed : FrmBaseDocument
    {
        public new string Name { get; set; }
        public FrmDetailed()
        {
            InitializeComponent();
        }

        private void FrmDetailed_Load(object sender, EventArgs e)
        {
            DetailedModel model = StCloud.GetSingle().GetDetailedByName(this.Name);
            this.txtName.Text = model.name;
            this.txtNpmName.Text = model.npmName;
            this.txtVersion.Text = model.version;
            this.txtHomepage.Text = model.homepage;
            this.txtLicense.Text = model.license;
            this.txtStars.Text = model.stars;
            this.txtGit.Text = model.repository.url;
            this.lstkeywords.Items.Clear();
            model.keywords.ForEach(item => {
                this.lstkeywords.Items.Add(item);
            });
        }
    }
}

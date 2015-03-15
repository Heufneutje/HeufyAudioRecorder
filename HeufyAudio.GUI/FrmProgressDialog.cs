using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeufyAudio.GUI
{
    public partial class FrmProgressDialog : Form
    {
        #region Fields & Properties
        public event EventHandler Cancelled;
        public string Task
        {
            get
            {
                return lblTask.Text;
            }
            set
            {
                lblTask.Text = value;
            }
        }
        public int Progress
        {
            get
            {
                return progressBar.Value;
            }
            set
            {
                progressBar.Value = value;
            }
        }
        public bool CanCancel
        {
            get
            {
                return btnCancel.Enabled;
            }
            set
            {
                btnCancel.Enabled = value;
            }
        }
        #endregion

        #region Constructor
        public FrmProgressDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region Control Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Cancelled != null)
                Cancelled(this, new EventArgs());
        }
        #endregion
    }
}

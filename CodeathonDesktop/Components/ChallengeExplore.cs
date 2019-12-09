using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codeathon.Desktop.Components
{
    public partial class ChallengeExplore : UserControl
    {
        private object[] dataset;
        public ChallengeExplore()
        {
            InitializeComponent();
        }

        public object[] Dataset { get => dataset;
            set
            {
                dataset = value;
                gridControl1.DataSource = dataset;
                gridControl1.RefreshDataSource();
            }
        }

       

    }
}

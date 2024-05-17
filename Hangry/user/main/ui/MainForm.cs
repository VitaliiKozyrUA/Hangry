using Hangry.user.login.data.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangry.user.main.ui
{
    public partial class MainForm : Form
    {
        internal User User { get; set; }

        internal MainForm(User user)
        {
            User = user;
            InitializeComponent();
        }
    }
}

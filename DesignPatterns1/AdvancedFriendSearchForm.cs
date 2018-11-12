using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace DesignPatterns1
{
    public partial class AdvancedFriendSearchForm : Form
    {
        public User LoggedInUser{ private get; set; }

        public AdvancedFriendSearchForm()
        {
            InitializeComponent();
        }



        private void AdvancedFriendSearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}

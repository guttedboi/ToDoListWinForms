<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListWinForms
{
    public partial class workspace : Form
    {
        public workspace()
        {
            InitializeComponent();

            timer.Start();
        }

        private void workspace_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.timeLabel.Text = dateTime.ToString();
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListWinForms
{
    public partial class workspace : Form
    {
        public workspace()
        {
            InitializeComponent();

            timer.Start();
        }

        private void workspace_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.timeLabel.Text = dateTime.ToString();
        }

    }
}
>>>>>>> origin/master

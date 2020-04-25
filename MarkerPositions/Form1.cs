using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkerPositions
{
    public partial class Form1 : Form
    {
        private MarkerMediator markerMediator = new MarkerMediator();
        private Button addButton;

        public Form1()
        {
            InitializeComponent();
            addButton = new Button();
            addButton.Click += OnAddClick;
            addButton.Text = "Add Marker";
            addButton.Dock = DockStyle.Bottom;
            Controls.Add(this.addButton);
        }

        private void OnAddClick(object sender, EventArgs eventArgs)
        {
            var mediator = this.markerMediator.CreateMaker();
            Controls.Add(mediator);
        }
    }
}

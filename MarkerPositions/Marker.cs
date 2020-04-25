using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MarkerPositions
{
    public class Marker : Label
    {
        private MarkerMediator markerMediator;
        private Point mouseDownLocation;

        public void SetMediator(MarkerMediator markerMediator)
        {
            this.markerMediator = markerMediator;
        }

        public Marker()
        {
            this.Text = "{Drag me}";
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MouseDown += OnMouseDown;
            this.MouseMove += OnMouseMove;
        }

        private void OnMouseDown(object sender, MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.Button == MouseButtons.Left)
            {
                this.mouseDownLocation = mouseEventArgs.Location; 
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs mouseEventArgs)
        {
            if (mouseEventArgs.Button == MouseButtons.Left)
            {
                this.Text = this.Location.ToString();
                this.Left = mouseEventArgs.X + this.Left - this.mouseDownLocation.X;
                this.Top = mouseEventArgs.Y + this.Top - this.mouseDownLocation.Y;
                this.markerMediator.Send(this.Location, this); 
            }
        }

        public void ReceiveLocation(Point location)
        {
            var distance = CalculateDistance(location);
            if (distance < 100 && this.BackColor != Color.Red)
            {
                this.BackColor = Color.Red;
            }
            else if(distance >= 100 && this.BackColor != Color.Green)
            {
                this.BackColor = Color.Green;
            }
        }

        private double CalculateDistance(Point location)
        {
            return Math.Sqrt(Math.Pow(location.X - this.Location.X, 2) + Math.Pow(location.Y - this.Location.Y, 2));
        }
    }
}

//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/HotTrackButtonHost.htm


using System;using System.Drawing;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._Button
{ 
   public   class Button_17_HotTrackButtonHost:Form
    {
        private HotTrackButton hotTrackButton1;
        internal HotTrackButton hotTrackButton2;
        internal HotTrackButton HotTrackButton3;
        private System.ComponentModel.Container components = null;
        public   Button_17_HotTrackButtonHost()
       {
            InitializeComponent();

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(HotTrackButtonHost));
            this.hotTrackButton1 = new HotTrackButton();
            this.hotTrackButton2 = new HotTrackButton();
            this.HotTrackButton3 = new HotTrackButton();
            this.SuspendLayout();
            // 
            // hotTrackButton1
            // 
            //            this.hotTrackButton1.Image = ((System.Drawing.Bitmap)(resources.GetObject("hotTrackButton1.Image")));
            this.hotTrackButton1.Location = new System.Drawing.Point(28, 128);
            this.hotTrackButton1.Name = "hotTrackButton1";
            this.hotTrackButton1.Size = new System.Drawing.Size(168, 36);
            this.hotTrackButton1.TabIndex = 0;
            this.hotTrackButton1.Text = "Large HotTrackButton";
            // 
            // hotTrackButton2
            // 
            this.hotTrackButton2.BackColor = System.Drawing.SystemColors.Control;
            this.hotTrackButton2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.hotTrackButton2.ForeColor = System.Drawing.Color.Black;
            //            this.hotTrackButton2.Image = ((System.Drawing.Bitmap)(resources.GetObject("hotTrackButton2.Image")));
            this.hotTrackButton2.Location = new System.Drawing.Point(32, 24);
            this.hotTrackButton2.Name = "hotTrackButton2";
            this.hotTrackButton2.Size = new System.Drawing.Size(168, 20);
            this.hotTrackButton2.TabIndex = 1;
            this.hotTrackButton2.Text = "Ordinary HotTrackButton";
            // 
            // HotTrackButton3
            // 
            this.HotTrackButton3.BackColor = System.Drawing.SystemColors.Control;
            this.HotTrackButton3.Enabled = false;
            this.HotTrackButton3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.HotTrackButton3.ForeColor = System.Drawing.Color.Black;
            //            this.HotTrackButton3.Image = ((System.Drawing.Bitmap)(resources.GetObject("HotTrackButton3.Image")));
            this.HotTrackButton3.Location = new System.Drawing.Point(32, 68);
            this.HotTrackButton3.Name = "HotTrackButton3";
            this.HotTrackButton3.Size = new System.Drawing.Size(168, 28);
            this.HotTrackButton3.TabIndex = 3;
            this.HotTrackButton3.Text = "Disabled HotTrackButton";
            // 
            // HotTrackButtonHost
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.HotTrackButton3,
                                                                          this.hotTrackButton2,
                                                                          this.hotTrackButton1});
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Name = "HotTrackButtonHost";
            this.Text = "HotTrackButtonHost";
            this.ResumeLayout(false);

        }
        #endregion


    }
    /// <summary>
    /// Summary description for HotTrackButton.
    /// </summary>
    public class HotTrackButton : Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public HotTrackButton()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call

        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion


        public enum State
        {
            Normal,
            MouseOver,
            Pushed
        }

        private State state = State.Normal;

        private Image image;
        private Rectangle bounds;

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                bounds = new Rectangle(0, 0, image.Width + 5, image.Height + 5);
                this.Invalidate();
            }
        }

        // You must override this property to invalidate the display and
        // provide automatic refresh when the property is changed.
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                this.Invalidate();
            }
        }
        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // Check if the mouse pointer is over the button.
            // If the mouse moves off the button surface, it will be deactivated,
            // even if the button is being held in a pressed position.
            // The code repaints the button only if needed.
            if (bounds.Contains(e.X, e.Y))
            {
                if (state == State.Normal)
                {
                    state = State.MouseOver;
                    this.Invalidate(bounds);
                }
            }
            else
            {
                if (state != State.Normal)
                {
                    state = State.Normal;
                    this.Invalidate(bounds);
                }
            }
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            // Reset the button appearance. This will also deactivate the button
            // if it has been pressed but not released.
            // The code repaints the button only if needed.
            if (state != State.Normal)
            {
                state = State.Normal;
                this.Invalidate(bounds);
            }
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            // Change the button to a pushed state, provided the mouse pointer is
            // over the image and the Left mouse button has been clicked 
            if (bounds.Contains(e.X, e.Y) &&
                (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                state = State.Pushed;
                this.Invalidate(bounds);
            }
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            // Change the button to a normal state and repaint if needed.
            if (!((e.Button & MouseButtons.Left) == MouseButtons.Left))
            {
                state = State.Normal;

                if (bounds.Contains(e.X, e.Y))
                {
                    state = State.MouseOver;
                }
                else
                {
                    state = State.Normal;
                }

                this.Invalidate(bounds);
            }
        }


        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (image == null)
            {
                // Draw the text without the image.
                e.Graphics.DrawString(this.Text, this.Font,
                    new SolidBrush(this.ForeColor), 10, 0);
            }
            else
            {
                if (!this.Enabled)
                {
                    // Paint the picture in a disabled state.
                    ControlPaint.DrawImageDisabled(e.Graphics, image, 2, 2,
                        this.BackColor);
                }
                else
                {
                    // Paint the image according to the button state.
                    switch (state)
                    {
                        case State.Normal:
                            e.Graphics.DrawImage(image, 2, 2);
                            break;
                        case State.MouseOver:
                            ControlPaint.DrawBorder3D(e.Graphics, bounds,
                                Border3DStyle.Raised, Border3DSide.All);
                            e.Graphics.DrawImage(image, 2, 2);
                            break;
                        case State.Pushed:
                            ControlPaint.DrawBorder3D(e.Graphics, bounds,
                                Border3DStyle.Sunken, Border3DSide.All);
                            e.Graphics.DrawImage(image, 3, 3);
                            break;
                    }
                }

                // Paint the caption text next to the image.
                e.Graphics.DrawString(this.Text, this.Font,
                    new SolidBrush(this.ForeColor), bounds.Width + 3,
                    (bounds.Height - this.Font.Height) / 2);
            }

        }

        protected override void OnClick(System.EventArgs e)
        {
            // Only propagate the click to the client if it was detected over the image.
            if (state == State.Pushed)
            {
                base.OnClick(e);
            }
        }


    }
}

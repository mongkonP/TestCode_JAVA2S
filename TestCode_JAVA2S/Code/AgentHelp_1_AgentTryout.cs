//http://www.java2s.com/Code/CSharp/GUI-Windows-Form/AgentTryout.htm


using System;using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestCode_JAVA2S._AgentHelp
{ 
  /* public   class AgentHelp_1_AgentTryout:Form
    {
        internal System.Windows.Forms.Button cmdClose;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtY;
        internal System.Windows.Forms.TextBox txtX;
        internal System.Windows.Forms.Button cmdMove;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button cmdSpeak;
        internal System.Windows.Forms.TextBox txtSpeak;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button cmdStop;
        internal System.Windows.Forms.Button cmdPlay;
        internal System.Windows.Forms.ListBox lstAnimations;
        private AxAgentObjects.AxAgent axAgent1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public   AgentHelp_1_AgentTryout()
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AgentTryout));
            this.cmdClose = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.cmdMove = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdSpeak = new System.Windows.Forms.Button();
            this.txtSpeak = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.axAgent1 = new AxAgentObjects.AxAgent();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdPlay = new System.Windows.Forms.Button();
            this.lstAnimations = new System.Windows.Forms.ListBox();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAgent1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdClose.Location = new System.Drawing.Point(295, 331);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(96, 24);
            this.cmdClose.TabIndex = 12;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right);
            this.GroupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
                                          this.Label2,
                                          this.Label1,
                                          this.txtY,
                                          this.txtX,
                                          this.cmdMove});
            this.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox3.Location = new System.Drawing.Point(8, 251);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(384, 64);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Move";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(84, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(20, 16);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Y:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(20, 16);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "X:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(104, 24);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(36, 20);
            this.txtY.TabIndex = 9;
            this.txtY.Text = "";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(36, 24);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(36, 20);
            this.txtX.TabIndex = 8;
            this.txtX.Text = "";
            // 
            // cmdMove
            // 
            this.cmdMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdMove.Location = new System.Drawing.Point(248, 24);
            this.cmdMove.Name = "cmdMove";
            this.cmdMove.Size = new System.Drawing.Size(72, 20);
            this.cmdMove.TabIndex = 7;
            this.cmdMove.Text = "Move";
            this.cmdMove.Click += new System.EventHandler(this.cmdMove_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right);
            this.GroupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                          this.cmdSpeak,
                                          this.txtSpeak});
            this.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox2.Location = new System.Drawing.Point(8, 163);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(384, 80);
            this.GroupBox2.TabIndex = 10;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Speak";
            // 
            // cmdSpeak
            // 
            this.cmdSpeak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdSpeak.Location = new System.Drawing.Point(248, 20);
            this.cmdSpeak.Name = "cmdSpeak";
            this.cmdSpeak.Size = new System.Drawing.Size(72, 20);
            this.cmdSpeak.TabIndex = 6;
            this.cmdSpeak.Text = "Speak";
            this.cmdSpeak.Click += new System.EventHandler(this.cmdSpeak_Click);
            // 
            // txtSpeak
            // 
            this.txtSpeak.AcceptsReturn = true;
            this.txtSpeak.Location = new System.Drawing.Point(8, 20);
            this.txtSpeak.Multiline = true;
            this.txtSpeak.Name = "txtSpeak";
            this.txtSpeak.Size = new System.Drawing.Size(232, 48);
            this.txtSpeak.TabIndex = 4;
            this.txtSpeak.Text = "";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right);
            this.GroupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                          this.axAgent1,
                                          this.cmdStop,
                                          this.cmdPlay,
                                          this.lstAnimations});
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(8, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(384, 144);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Animate";
            // 
            // axAgent1
            // 
            this.axAgent1.ContainingControl = this;
            this.axAgent1.Enabled = true;
            this.axAgent1.Location = new System.Drawing.Point(336, 32);
            this.axAgent1.Name = "axAgent1";
            this.axAgent1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAgent1.OcxState")));
            this.axAgent1.Size = new System.Drawing.Size(32, 32);
            this.axAgent1.TabIndex = 7;
            // 
            // cmdStop
            // 
            this.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdStop.Location = new System.Drawing.Point(248, 48);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(72, 20);
            this.cmdStop.TabIndex = 6;
            this.cmdStop.Text = "Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdPlay
            // 
            this.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdPlay.Location = new System.Drawing.Point(248, 24);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(72, 20);
            this.cmdPlay.TabIndex = 5;
            this.cmdPlay.Text = "Play";
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // lstAnimations
            // 
            this.lstAnimations.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
              | System.Windows.Forms.AnchorStyles.Left);
            this.lstAnimations.IntegralHeight = false;
            this.lstAnimations.Location = new System.Drawing.Point(8, 22);
            this.lstAnimations.Name = "lstAnimations";
            this.lstAnimations.Size = new System.Drawing.Size(232, 109);
            this.lstAnimations.TabIndex = 4;
            // 
            // AgentTryout
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(400, 366);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.cmdClose,
                                      this.GroupBox3,
                                      this.GroupBox2,
                                      this.GroupBox1});
            this.Name = "AgentTryout";
            this.Text = "AgentTryout";
            this.Load += new System.EventHandler(this.AgentTryout_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAgent1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private AgentController controller;

        private void AgentTryout_Load(object sender, System.EventArgs e)
        {
            controller = new AgentController(axAgent1, "Genie");

            lstAnimations.DataSource = controller.GetAnimations();

            controller.Show();
        }

        private void cmdPlay_Click(object sender, System.EventArgs e)
        {
            controller.Animate(lstAnimations.Text);
        }

        private void cmdStop_Click(object sender, System.EventArgs e)
        {
            controller.StopAll();
        }

        private void cmdSpeak_Click(object sender, System.EventArgs e)
        {
            controller.Speak(txtSpeak.Text);
        }

        private void cmdMove_Click(object sender, System.EventArgs e)
        {
            controller.MoveTo(short.Parse(txtX.Text), short.Parse(txtY.Text));
        }

        private void cmdClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }*/
   /* public class AgentController
    {
        // Agent variable.
        private AgentObjects.IAgentCtlCharacterEx agentChar;

        // Name of the initialized character.
        private string characterName;

        // Balloon constants
        private const short BalloonOn = 1;
        private const short SizeToText = 2;
        private const short AutoHide = 4;
        private const short AutoPace = 8;

        public AgentController(AxAgentObjects.AxAgent agentHost,
          string character)
        {
            agentHost.Characters.Load(character, null);
            agentChar = agentHost.Characters[character];

            characterName = character;

            // You could put your own options in this menu, if desired.
            agentChar.AutoPopupMenu = false;

            // Set balloon style.
            agentChar.Balloon.Style = agentChar.Balloon.Style | BalloonOn;
            agentChar.Balloon.Style = agentChar.Balloon.Style | SizeToText;
            agentChar.Balloon.Style = agentChar.Balloon.Style | AutoHide;
            //agentChar.Balloon.Style = agentChar.Balloon.Style & !(AutoPace);
        }

        public void Dispose()
        {
            if (agentChar.Visible)
            {
                agentChar.StopAll(null);
                agentChar.Hide(null);
            }
        }

        public void Show()
        {
            agentChar.Show(null);
        }

        public void Hide()
        {
            agentChar.Hide(null);
        }

        public void StopAll()
        {
            agentChar.StopAll(null);
        }

        public void Speak(string text)
        {
            agentChar.StopAll(null);
            agentChar.Speak(text, "");
        }

        public void Think(string text)
        {
            agentChar.StopAll(null);
            agentChar.Think(text);
        }

        public void Animate(string animation)
        {
            agentChar.StopAll(null);
            agentChar.Play(animation);
        }

        public void MoveTo(short x, short y)
        {
            agentChar.MoveTo(x, y, null);
        }

        public void GestureAt(short x, short y)
        {
            agentChar.GestureAt(x, y);
        }

        public Array GetAnimations()
        {
            ArrayList list = new ArrayList();
            foreach (string animation in agentChar.AnimationNames)
            {
                list.Add(animation);
            }
            return list.ToArray(typeof(string));
        }

        // Tests if the agent is visible.
        // If the agent is not visible it will be shown.
        private bool IsAgentVisible()
        {
            if (agentChar.Visible)
            {
                return true;
            }
            else
            {
                agentChar.Show(null);
                return false;
            }
        }
    }*/
}

namespace MultiPlayerInvader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.bulletright = new System.Windows.Forms.PictureBox();
            this.playerright = new System.Windows.Forms.PictureBox();
            this.playerleft = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bulletleft = new System.Windows.Forms.PictureBox();
            this.labelright = new System.Windows.Forms.Label();
            this.labelleft = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.resultlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bulletright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletleft)).BeginInit();
            this.SuspendLayout();
            // 
            // bulletright
            // 
            this.bulletright.Image = global::MultiPlayerInvader.Properties.Resources.bulletl;
            this.bulletright.Location = new System.Drawing.Point(867, 320);
            this.bulletright.Name = "bulletright";
            this.bulletright.Size = new System.Drawing.Size(52, 30);
            this.bulletright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletright.TabIndex = 4;
            this.bulletright.TabStop = false;
            this.bulletright.Tag = "bullet";
            // 
            // playerright
            // 
            this.playerright.Image = global::MultiPlayerInvader.Properties.Resources.spyelow;
            this.playerright.Location = new System.Drawing.Point(842, 297);
            this.playerright.Name = "playerright";
            this.playerright.Size = new System.Drawing.Size(100, 90);
            this.playerright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerright.TabIndex = 2;
            this.playerright.TabStop = false;
            this.playerright.Tag = "player";
            // 
            // playerleft
            // 
            this.playerleft.Image = global::MultiPlayerInvader.Properties.Resources.spred1;
            this.playerleft.Location = new System.Drawing.Point(23, 297);
            this.playerleft.Name = "playerleft";
            this.playerleft.Size = new System.Drawing.Size(100, 96);
            this.playerleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerleft.TabIndex = 1;
            this.playerleft.TabStop = false;
            this.playerleft.Tag = "player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(489, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 684);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bulletleft
            // 
            this.bulletleft.Image = global::MultiPlayerInvader.Properties.Resources.bulletr1;
            this.bulletleft.Location = new System.Drawing.Point(47, 320);
            this.bulletleft.Name = "bulletleft";
            this.bulletleft.Size = new System.Drawing.Size(45, 35);
            this.bulletleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletleft.TabIndex = 3;
            this.bulletleft.TabStop = false;
            this.bulletleft.Tag = "bullet";
            // 
            // labelright
            // 
            this.labelright.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelright.Location = new System.Drawing.Point(822, 0);
            this.labelright.Name = "labelright";
            this.labelright.Size = new System.Drawing.Size(152, 57);
            this.labelright.TabIndex = 5;
            this.labelright.Text = "Heart : 10";
            // 
            // labelleft
            // 
            this.labelleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelleft.Location = new System.Drawing.Point(1, 0);
            this.labelleft.Name = "labelleft";
            this.labelleft.Size = new System.Drawing.Size(152, 57);
            this.labelleft.TabIndex = 6;
            this.labelleft.Text = "Heart : 10";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // resultlabel
            // 
            this.resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlabel.Location = new System.Drawing.Point(357, 0);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(278, 103);
            this.resultlabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(986, 683);
            this.Controls.Add(this.labelleft);
            this.Controls.Add(this.labelright);
            this.Controls.Add(this.playerright);
            this.Controls.Add(this.playerleft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bulletleft);
            this.Controls.Add(this.bulletright);
            this.Controls.Add(this.resultlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bulletright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletleft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playerleft;
        private System.Windows.Forms.PictureBox playerright;
        private System.Windows.Forms.PictureBox bulletleft;
        private System.Windows.Forms.PictureBox bulletright;
        private System.Windows.Forms.Label labelright;
        private System.Windows.Forms.Label labelleft;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label resultlabel;
    }
}


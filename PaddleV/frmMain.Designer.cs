namespace PaddleV
{
    partial class frmMain
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
            this.ChatBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearAllTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmotes = new System.Windows.Forms.Button();
            this.btnPictures = new System.Windows.Forms.Button();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ChatBubbles = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChatBox
            // 
            this.ChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatBox.ContextMenuStrip = this.contextMenuStrip1;
            this.ChatBox.Location = new System.Drawing.Point(325, 678);
            this.ChatBox.MaxLength = 500;
            this.ChatBox.Multiline = true;
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(711, 54);
            this.ChatBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ChatBox, "Message Box");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearAllTextToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 98);
            // 
            // clearAllTextToolStripMenuItem
            // 
            this.clearAllTextToolStripMenuItem.Name = "clearAllTextToolStripMenuItem";
            this.clearAllTextToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.clearAllTextToolStripMenuItem.Text = "Clear Text";
            this.clearAllTextToolStripMenuItem.Click += new System.EventHandler(this.clearAllTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1059, 677);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 57);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.toolTip1.SetToolTip(this.btnSend, "Send (ENTER)");
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btnEmotes);
            this.panel1.Controls.Add(this.btnPictures);
            this.panel1.Location = new System.Drawing.Point(190, 678);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 57);
            this.panel1.TabIndex = 4;
            // 
            // btnEmotes
            // 
            this.btnEmotes.Location = new System.Drawing.Point(66, 3);
            this.btnEmotes.Name = "btnEmotes";
            this.btnEmotes.Size = new System.Drawing.Size(60, 48);
            this.btnEmotes.TabIndex = 6;
            this.btnEmotes.Text = "Emotes";
            this.toolTip1.SetToolTip(this.btnEmotes, "Emotes");
            this.btnEmotes.UseVisualStyleBackColor = true;
            this.btnEmotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPictures
            // 
            this.btnPictures.Location = new System.Drawing.Point(3, 3);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(60, 48);
            this.btnPictures.TabIndex = 5;
            this.btnPictures.Text = "Picture";
            this.toolTip1.SetToolTip(this.btnPictures, "Pictures");
            this.btnPictures.UseVisualStyleBackColor = true;
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // ChatBubbles
            // 
            this.ChatBubbles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ChatBubbles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatBubbles.Location = new System.Drawing.Point(12, 12);
            this.ChatBubbles.MaxLength = 500;
            this.ChatBubbles.Multiline = true;
            this.ChatBubbles.Name = "ChatBubbles";
            this.ChatBubbles.Size = new System.Drawing.Size(1008, 601);
            this.ChatBubbles.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ChatBubbles, "Messages");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel2.Location = new System.Drawing.Point(1026, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 623);
            this.panel2.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1208, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ChatBubbles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.ChatBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaddleV (Main)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clearAllTextToolStripMenuItem;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmotes;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox ChatBubbles;
        private System.Windows.Forms.Panel panel2;
    }
}
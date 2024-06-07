using System.Drawing;

namespace FindAndReplace.App
{
	partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDir = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip_btnSwap = new System.Windows.Forms.ToolTip(this.components);
            this.btnSwap = new System.Windows.Forms.Button();
            this.toolTip_chkIncludeFilesWithoutMatches = new System.Windows.Forms.ToolTip(this.components);
            this.chkIncludeFilesWithoutMatches = new System.Windows.Forms.CheckBox();
            this.toolTip_chkSkipBinaryFileDetection = new System.Windows.Forms.ToolTip(this.components);
            this.chkSkipBinaryFileDetection = new System.Windows.Forms.CheckBox();
            this.toolTip_chkShowEncoding = new System.Windows.Forms.ToolTip(this.components);
            this.chkShowEncoding = new System.Windows.Forms.CheckBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOnlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStats = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.txtFind = new System.Windows.Forms.RichTextBox();
            this.pnlReplace = new System.Windows.Forms.Panel();
            this.txtReplace = new System.Windows.Forms.RichTextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnGenReplaceCommandLine = new System.Windows.Forms.Button();
            this.btnFindOnly = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkIsCaseSensitive = new System.Windows.Forms.CheckBox();
            this.chkIsRegEx = new System.Windows.Forms.CheckBox();
            this.chkKeepModifiedDate = new System.Windows.Forms.CheckBox();
            this.chkUseEscapeChars = new System.Windows.Forms.CheckBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcludeFileMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileMask = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chkIncludeSubDirectories = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExcludeDir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCommandLine = new System.Windows.Forms.Panel();
            this.txtCommandLine = new System.Windows.Forms.TextBox();
            this.lblCommandLine = new System.Windows.Forms.Label();
            this.txtNoMatches = new System.Windows.Forms.Label();
            this.pnlGridResults = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtMatchesPreview = new System.Windows.Forms.RichTextBox();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlFind.SuspendLayout();
            this.pnlReplace.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCommandLine.SuspendLayout();
            this.pnlGridResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.errorProvider1.SetIconPadding(this.txtDir, 30);
            this.txtDir.Location = new System.Drawing.Point(78, 9);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(597, 23);
            this.txtDir.TabIndex = 0;
            this.txtDir.Validating += new System.ComponentModel.CancelEventHandler(this.txtDir_Validating);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select folder with files to find and replace.";
            // 
            // btnSwap
            // 
            this.btnSwap.AccessibleDescription = "";
            this.btnSwap.CausesValidation = false;
            this.btnSwap.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSwap.Location = new System.Drawing.Point(625, 130);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(93, 27);
            this.btnSwap.TabIndex = 1;
            this.btnSwap.Text = "↑ ↓";
            this.toolTip_btnSwap.SetToolTip(this.btnSwap, "Swap find text and replace text");
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // chkIncludeFilesWithoutMatches
            // 
            this.chkIncludeFilesWithoutMatches.AutoSize = true;
            this.chkIncludeFilesWithoutMatches.Location = new System.Drawing.Point(180, 57);
            this.chkIncludeFilesWithoutMatches.Name = "chkIncludeFilesWithoutMatches";
            this.chkIncludeFilesWithoutMatches.Size = new System.Drawing.Size(194, 21);
            this.chkIncludeFilesWithoutMatches.TabIndex = 5;
            this.chkIncludeFilesWithoutMatches.Text = "Include files without matches";
            this.toolTip_chkIncludeFilesWithoutMatches.SetToolTip(this.chkIncludeFilesWithoutMatches, "Show files without matches in results.");
            this.chkIncludeFilesWithoutMatches.UseVisualStyleBackColor = true;
            // 
            // chkSkipBinaryFileDetection
            // 
            this.chkSkipBinaryFileDetection.AutoSize = true;
            this.chkSkipBinaryFileDetection.Location = new System.Drawing.Point(3, 57);
            this.chkSkipBinaryFileDetection.Name = "chkSkipBinaryFileDetection";
            this.chkSkipBinaryFileDetection.Size = new System.Drawing.Size(171, 21);
            this.chkSkipBinaryFileDetection.TabIndex = 2;
            this.chkSkipBinaryFileDetection.Text = "Skip binary file detection";
            this.toolTip_chkSkipBinaryFileDetection.SetToolTip(this.chkSkipBinaryFileDetection, "Include binary files when searching for the string in \'Find\'.");
            this.chkSkipBinaryFileDetection.UseVisualStyleBackColor = true;
            // 
            // chkShowEncoding
            // 
            this.chkShowEncoding.AutoSize = true;
            this.chkShowEncoding.Location = new System.Drawing.Point(180, 30);
            this.chkShowEncoding.Name = "chkShowEncoding";
            this.chkShowEncoding.Size = new System.Drawing.Size(116, 21);
            this.chkShowEncoding.TabIndex = 4;
            this.chkShowEncoding.Text = "Show encoding";
            this.toolTip_chkShowEncoding.SetToolTip(this.chkShowEncoding, "Indicate encoding detected for each file");
            this.chkShowEncoding.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(945, 25);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOnlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewOnlineHelpToolStripMenuItem
            // 
            this.viewOnlineHelpToolStripMenuItem.Name = "viewOnlineHelpToolStripMenuItem";
            this.viewOnlineHelpToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.viewOnlineHelpToolStripMenuItem.Text = "View Online Help";
            this.viewOnlineHelpToolStripMenuItem.Click += new System.EventHandler(this.viewOnlineHelpToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // lblStats
            // 
            this.lblStats.BackColor = System.Drawing.SystemColors.Control;
            this.lblStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStats.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblStats.Location = new System.Drawing.Point(730, 28);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(212, 371);
            this.lblStats.TabIndex = 51;
            this.lblStats.Text = "Stats";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlFind);
            this.panel5.Controls.Add(this.pnlReplace);
            this.panel5.Controls.Add(this.btnReplace);
            this.panel5.Controls.Add(this.btnGenReplaceCommandLine);
            this.panel5.Controls.Add(this.btnFindOnly);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnSwap);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(721, 253);
            this.panel5.TabIndex = 2;
            // 
            // pnlFind
            // 
            this.pnlFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFind.Controls.Add(this.txtFind);
            this.pnlFind.Location = new System.Drawing.Point(78, 8);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(640, 52);
            this.pnlFind.TabIndex = 73;
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.DetectUrls = false;
            this.txtFind.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtFind.Location = new System.Drawing.Point(-1, 0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(640, 52);
            this.txtFind.TabIndex = 0;
            this.txtFind.Text = "";
            this.txtFind.WordWrap = false;
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // pnlReplace
            // 
            this.pnlReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReplace.Controls.Add(this.txtReplace);
            this.pnlReplace.Location = new System.Drawing.Point(78, 164);
            this.pnlReplace.Name = "pnlReplace";
            this.pnlReplace.Size = new System.Drawing.Size(640, 52);
            this.pnlReplace.TabIndex = 9;
            // 
            // txtReplace
            // 
            this.txtReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReplace.CausesValidation = false;
            this.txtReplace.DetectUrls = false;
            this.txtReplace.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtReplace.Location = new System.Drawing.Point(-1, -1);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(640, 52);
            this.txtReplace.TabIndex = 0;
            this.txtReplace.Text = "";
            this.txtReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReplace_KeyDown);
            this.txtReplace.Validating += new System.ComponentModel.CancelEventHandler(this.pnlReplace_Validating);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnReplace.Location = new System.Drawing.Point(643, 220);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 27);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnGenReplaceCommandLine
            // 
            this.btnGenReplaceCommandLine.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnGenReplaceCommandLine.Location = new System.Drawing.Point(463, 220);
            this.btnGenReplaceCommandLine.Name = "btnGenReplaceCommandLine";
            this.btnGenReplaceCommandLine.Size = new System.Drawing.Size(174, 27);
            this.btnGenReplaceCommandLine.TabIndex = 1;
            this.btnGenReplaceCommandLine.Text = "Gen Replace Command Line";
            this.btnGenReplaceCommandLine.UseVisualStyleBackColor = true;
            this.btnGenReplaceCommandLine.Click += new System.EventHandler(this.btnGenReplaceCommandLine_Click);
            // 
            // btnFindOnly
            // 
            this.btnFindOnly.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnFindOnly.Location = new System.Drawing.Point(625, 66);
            this.btnFindOnly.Name = "btnFindOnly";
            this.btnFindOnly.Size = new System.Drawing.Size(93, 27);
            this.btnFindOnly.TabIndex = 0;
            this.btnFindOnly.Text = "Find Only";
            this.btnFindOnly.UseVisualStyleBackColor = true;
            this.btnFindOnly.Click += new System.EventHandler(this.btnFindOnly_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.Location = new System.Drawing.Point(3, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.chkIsCaseSensitive);
            this.flowLayoutPanel1.Controls.Add(this.chkIsRegEx);
            this.flowLayoutPanel1.Controls.Add(this.chkSkipBinaryFileDetection);
            this.flowLayoutPanel1.Controls.Add(this.chkKeepModifiedDate);
            this.flowLayoutPanel1.Controls.Add(this.chkShowEncoding);
            this.flowLayoutPanel1.Controls.Add(this.chkIncludeFilesWithoutMatches);
            this.flowLayoutPanel1.Controls.Add(this.chkUseEscapeChars);
            this.flowLayoutPanel1.Controls.Add(this.lblEncoding);
            this.flowLayoutPanel1.Controls.Add(this.cmbEncoding);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(78, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 90);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // chkIsCaseSensitive
            // 
            this.chkIsCaseSensitive.AutoSize = true;
            this.chkIsCaseSensitive.Location = new System.Drawing.Point(3, 3);
            this.chkIsCaseSensitive.Name = "chkIsCaseSensitive";
            this.chkIsCaseSensitive.Size = new System.Drawing.Size(108, 21);
            this.chkIsCaseSensitive.TabIndex = 0;
            this.chkIsCaseSensitive.Text = "Case sensitive";
            this.chkIsCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // chkIsRegEx
            // 
            this.chkIsRegEx.AutoSize = true;
            this.chkIsRegEx.Location = new System.Drawing.Point(3, 30);
            this.chkIsRegEx.Name = "chkIsRegEx";
            this.chkIsRegEx.Size = new System.Drawing.Size(168, 21);
            this.chkIsRegEx.TabIndex = 1;
            this.chkIsRegEx.Text = "Use regular expressions";
            this.chkIsRegEx.UseVisualStyleBackColor = true;
            // 
            // chkKeepModifiedDate
            // 
            this.chkKeepModifiedDate.AutoSize = true;
            this.chkKeepModifiedDate.Location = new System.Drawing.Point(180, 3);
            this.chkKeepModifiedDate.Name = "chkKeepModifiedDate";
            this.chkKeepModifiedDate.Size = new System.Drawing.Size(145, 21);
            this.chkKeepModifiedDate.TabIndex = 3;
            this.chkKeepModifiedDate.Text = "Keep Modified Date";
            this.chkKeepModifiedDate.UseVisualStyleBackColor = true;
            // 
            // chkUseEscapeChars
            // 
            this.chkUseEscapeChars.AutoSize = true;
            this.chkUseEscapeChars.Location = new System.Drawing.Point(380, 3);
            this.chkUseEscapeChars.Name = "chkUseEscapeChars";
            this.chkUseEscapeChars.Size = new System.Drawing.Size(129, 21);
            this.chkUseEscapeChars.TabIndex = 6;
            this.chkUseEscapeChars.Text = "Use escape chars";
            this.chkUseEscapeChars.UseVisualStyleBackColor = true;
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(380, 27);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(65, 17);
            this.lblEncoding.TabIndex = 7;
            this.lblEncoding.Text = "Encoding:";
            this.lblEncoding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(380, 47);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(121, 25);
            this.cmbEncoding.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExcludeFileMask
            // 
            this.txtExcludeFileMask.Location = new System.Drawing.Point(532, 7);
            this.txtExcludeFileMask.Name = "txtExcludeFileMask";
            this.txtExcludeFileMask.Size = new System.Drawing.Size(186, 23);
            this.txtExcludeFileMask.TabIndex = 1;
            this.txtExcludeFileMask.Text = "*.dll, *.exe";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(435, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Exclude Mask:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileMask
            // 
            this.txtFileMask.Location = new System.Drawing.Point(78, 7);
            this.txtFileMask.Name = "txtFileMask";
            this.txtFileMask.Size = new System.Drawing.Size(325, 23);
            this.txtFileMask.TabIndex = 0;
            this.txtFileMask.Text = "*.*";
            this.txtFileMask.Validating += new System.ComponentModel.CancelEventHandler(this.txtFileMask_Validating);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "File Mask:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtExcludeFileMask);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtFileMask);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.panel6.Location = new System.Drawing.Point(3, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(721, 47);
            this.panel6.TabIndex = 0;
            // 
            // chkIncludeSubDirectories
            // 
            this.chkIncludeSubDirectories.AutoSize = true;
            this.chkIncludeSubDirectories.Checked = true;
            this.chkIncludeSubDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeSubDirectories.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chkIncludeSubDirectories.Location = new System.Drawing.Point(82, 38);
            this.chkIncludeSubDirectories.Name = "chkIncludeSubDirectories";
            this.chkIncludeSubDirectories.Size = new System.Drawing.Size(161, 21);
            this.chkIncludeSubDirectories.TabIndex = 1;
            this.chkIncludeSubDirectories.Text = "Include sub-directories";
            this.chkIncludeSubDirectories.UseVisualStyleBackColor = true;
            this.chkIncludeSubDirectories.CheckedChanged += new System.EventHandler(this.chkIncludeSubDirectories_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label6.Location = new System.Drawing.Point(272, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Exclude Dir:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExcludeDir
            // 
            this.txtExcludeDir.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtExcludeDir.Location = new System.Drawing.Point(355, 36);
            this.txtExcludeDir.MinimumSize = new System.Drawing.Size(50, 20);
            this.txtExcludeDir.Name = "txtExcludeDir";
            this.txtExcludeDir.Size = new System.Drawing.Size(363, 23);
            this.txtExcludeDir.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelectDir);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtExcludeDir);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkIncludeSubDirectories);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 64);
            this.panel1.TabIndex = 38;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.CausesValidation = false;
            this.btnSelectDir.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSelectDir.Location = new System.Drawing.Point(681, 9);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(37, 23);
            this.btnSelectDir.TabIndex = 1;
            this.btnSelectDir.Text = "...";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dir:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCommandLine
            // 
            this.pnlCommandLine.Controls.Add(this.txtCommandLine);
            this.pnlCommandLine.Controls.Add(this.lblCommandLine);
            this.pnlCommandLine.Location = new System.Drawing.Point(3, 402);
            this.pnlCommandLine.Name = "pnlCommandLine";
            this.pnlCommandLine.Size = new System.Drawing.Size(942, 165);
            this.pnlCommandLine.TabIndex = 54;
            this.pnlCommandLine.Visible = false;
            // 
            // txtCommandLine
            // 
            this.txtCommandLine.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtCommandLine.Location = new System.Drawing.Point(102, 5);
            this.txtCommandLine.Multiline = true;
            this.txtCommandLine.Name = "txtCommandLine";
            this.txtCommandLine.Size = new System.Drawing.Size(837, 157);
            this.txtCommandLine.TabIndex = 0;
            // 
            // lblCommandLine
            // 
            this.lblCommandLine.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblCommandLine.Location = new System.Drawing.Point(3, 5);
            this.lblCommandLine.Name = "lblCommandLine";
            this.lblCommandLine.Size = new System.Drawing.Size(101, 23);
            this.lblCommandLine.TabIndex = 20;
            this.lblCommandLine.Text = "Command Line:";
            this.lblCommandLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNoMatches
            // 
            this.txtNoMatches.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtNoMatches.Location = new System.Drawing.Point(6, 410);
            this.txtNoMatches.Name = "txtNoMatches";
            this.txtNoMatches.Size = new System.Drawing.Size(151, 23);
            this.txtNoMatches.TabIndex = 49;
            this.txtNoMatches.Text = "No matching files found.";
            this.txtNoMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlGridResults
            // 
            this.pnlGridResults.Controls.Add(this.label9);
            this.pnlGridResults.Controls.Add(this.lblResults);
            this.pnlGridResults.Controls.Add(this.txtMatchesPreview);
            this.pnlGridResults.Controls.Add(this.gvResults);
            this.pnlGridResults.Controls.Add(this.btnCancel);
            this.pnlGridResults.Controls.Add(this.lblStatus);
            this.pnlGridResults.Controls.Add(this.progressBar);
            this.pnlGridResults.Location = new System.Drawing.Point(3, 401);
            this.pnlGridResults.Name = "pnlGridResults";
            this.pnlGridResults.Size = new System.Drawing.Size(942, 253);
            this.pnlGridResults.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label9.Location = new System.Drawing.Point(3, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Preview:";
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblResults.Location = new System.Drawing.Point(3, 9);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(52, 23);
            this.lblResults.TabIndex = 52;
            this.lblResults.Text = "Results:";
            // 
            // txtMatchesPreview
            // 
            this.txtMatchesPreview.BackColor = System.Drawing.SystemColors.Info;
            this.txtMatchesPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatchesPreview.DetectUrls = false;
            this.txtMatchesPreview.Enabled = false;
            this.txtMatchesPreview.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtMatchesPreview.Location = new System.Drawing.Point(78, 141);
            this.txtMatchesPreview.Name = "txtMatchesPreview";
            this.txtMatchesPreview.ReadOnly = true;
            this.txtMatchesPreview.Size = new System.Drawing.Size(861, 104);
            this.txtMatchesPreview.TabIndex = 57;
            this.txtMatchesPreview.Text = "";
            this.txtMatchesPreview.WordWrap = false;
            // 
            // gvResults
            // 
            this.gvResults.AllowUserToAddRows = false;
            this.gvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvResults.Location = new System.Drawing.Point(78, 1);
            this.gvResults.MultiSelect = false;
            this.gvResults.Name = "gvResults";
            this.gvResults.ReadOnly = true;
            this.gvResults.RowHeadersVisible = false;
            this.gvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResults.Size = new System.Drawing.Size(861, 78);
            this.gvResults.TabIndex = 51;
            this.gvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellClick);
            this.gvResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellDoubleClick);
            this.gvResults.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.Location = new System.Drawing.Point(834, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblStatus.Location = new System.Drawing.Point(75, 86);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 23);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(78, 112);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(750, 23);
            this.progressBar.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(945, 662);
            this.Controls.Add(this.pnlGridResults);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnlCommandLine);
            this.Controls.Add(this.txtNoMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find and Replace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.pnlFind.ResumeLayout(false);
            this.pnlReplace.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCommandLine.ResumeLayout(false);
            this.pnlCommandLine.PerformLayout();
            this.pnlGridResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ToolTip toolTip_btnSwap;
		private System.Windows.Forms.ToolTip toolTip_chkIncludeFilesWithoutMatches;
		private System.Windows.Forms.ToolTip toolTip_chkSkipBinaryFileDetection;
		private System.Windows.Forms.ToolTip toolTip_chkShowEncoding;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewOnlineHelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtFileMask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindOnly;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox chkIsCaseSensitive;
        private System.Windows.Forms.CheckBox chkIsRegEx;
        private System.Windows.Forms.CheckBox chkSkipBinaryFileDetection;
        private System.Windows.Forms.CheckBox chkKeepModifiedDate;
        private System.Windows.Forms.CheckBox chkShowEncoding;
        private System.Windows.Forms.CheckBox chkIncludeFilesWithoutMatches;
        private System.Windows.Forms.CheckBox chkUseEscapeChars;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenReplaceCommandLine;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.RichTextBox txtFind;
        private System.Windows.Forms.RichTextBox txtReplace;
        private System.Windows.Forms.TextBox txtExcludeFileMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtExcludeDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIncludeSubDirectories;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel pnlReplace;
        private System.Windows.Forms.Panel pnlCommandLine;
        private System.Windows.Forms.Label lblCommandLine;
        private System.Windows.Forms.TextBox txtCommandLine;
        private System.Windows.Forms.Label txtNoMatches;
        private System.Windows.Forms.Panel pnlGridResults;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.RichTextBox txtMatchesPreview;
        public System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.ProgressBar progressBar;
    }
}


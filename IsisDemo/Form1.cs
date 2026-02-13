using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Atalasoft.Isis;
using Atalasoft.Imaging.Metadata;

namespace IsisDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string _fileSaveDir = "";
		private int _fileCount;
		private string _multipageFile = "";
		private bool _usingIsisCodecs;
		private IsisPixelFormat[] _driverColorFormats;
		private Atalasoft.Isis.IsisAcquisition _acquisition;
		private System.Windows.Forms.Panel panelControls;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboDevices;
		private System.Windows.Forms.Button btnAcquire;
		private System.Windows.Forms.CheckBox chkShowDialog;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panelIimage;
		private System.Windows.Forms.PictureBox picImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboPixelFormat;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboScanMode;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboFileType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboCompression;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cboResolution;
		private System.Windows.Forms.CheckBox chkSaveMultipage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cboAcquiredImageType;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numPageCountLimit;
		private System.Windows.Forms.Label label9;
        private Button btnAbout;
        private Label labl10;
        private NumericUpDown numScanAhead;
        private Label label11;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panelControls = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.numScanAhead = new System.Windows.Forms.NumericUpDown();
            this.labl10 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numPageCountLimit = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAcquiredImageType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSaveMultipage = new System.Windows.Forms.CheckBox();
            this.cboResolution = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCompression = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboScanMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPixelFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkShowDialog = new System.Windows.Forms.CheckBox();
            this.btnAcquire = new System.Windows.Forms.Button();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelIimage = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScanAhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageCountLimit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelIimage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label11);
            this.panelControls.Controls.Add(this.numScanAhead);
            this.panelControls.Controls.Add(this.labl10);
            this.panelControls.Controls.Add(this.btnAbout);
            this.panelControls.Controls.Add(this.label9);
            this.panelControls.Controls.Add(this.numPageCountLimit);
            this.panelControls.Controls.Add(this.label8);
            this.panelControls.Controls.Add(this.groupBox1);
            this.panelControls.Controls.Add(this.chkShowDialog);
            this.panelControls.Controls.Add(this.btnAcquire);
            this.panelControls.Controls.Add(this.cboDevices);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControls.Location = new System.Drawing.Point(0, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(224, 557);
            this.panelControls.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(166, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "pages.";
            // 
            // numScanAhead
            // 
            this.numScanAhead.Location = new System.Drawing.Point(120, 136);
            this.numScanAhead.Name = "numScanAhead";
            this.numScanAhead.Size = new System.Drawing.Size(40, 20);
            this.numScanAhead.TabIndex = 10;
            this.numScanAhead.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labl10
            // 
            this.labl10.AutoSize = true;
            this.labl10.Location = new System.Drawing.Point(18, 137);
            this.labl10.Name = "labl10";
            this.labl10.Size = new System.Drawing.Size(71, 13);
            this.labl10.TabIndex = 9;
            this.labl10.Text = "Scan ahead: ";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbout.Location = new System.Drawing.Point(71, 520);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(81, 25);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About ...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(168, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "pages.";
            // 
            // numPageCountLimit
            // 
            this.numPageCountLimit.Location = new System.Drawing.Point(120, 109);
            this.numPageCountLimit.Name = "numPageCountLimit";
            this.numPageCountLimit.Size = new System.Drawing.Size(40, 20);
            this.numPageCountLimit.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Limit scan count to:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboAcquiredImageType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkSaveMultipage);
            this.groupBox1.Controls.Add(this.cboResolution);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboCompression);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboFileType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboScanMode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboPixelFormat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(16, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 347);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Settings";
            // 
            // cboAcquiredImageType
            // 
            this.cboAcquiredImageType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAcquiredImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAcquiredImageType.Items.AddRange(new object[] {
            "AtalaImage",
            ".NET Bitmap"});
            this.cboAcquiredImageType.Location = new System.Drawing.Point(16, 72);
            this.cboAcquiredImageType.Name = "cboAcquiredImageType";
            this.cboAcquiredImageType.Size = new System.Drawing.Size(160, 21);
            this.cboAcquiredImageType.TabIndex = 12;
            this.cboAcquiredImageType.SelectedIndexChanged += new System.EventHandler(this.cboAcquiredImageType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Acquired Image Type:";
            // 
            // chkSaveMultipage
            // 
            this.chkSaveMultipage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkSaveMultipage.Location = new System.Drawing.Point(16, 256);
            this.chkSaveMultipage.Name = "chkSaveMultipage";
            this.chkSaveMultipage.Size = new System.Drawing.Size(152, 16);
            this.chkSaveMultipage.TabIndex = 8;
            this.chkSaveMultipage.Text = "Save as a multipage file.";
            // 
            // cboResolution
            // 
            this.cboResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResolution.Location = new System.Drawing.Point(16, 168);
            this.cboResolution.Name = "cboResolution";
            this.cboResolution.Size = new System.Drawing.Size(160, 21);
            this.cboResolution.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Resolution:";
            // 
            // cboCompression
            // 
            this.cboCompression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompression.Location = new System.Drawing.Point(16, 304);
            this.cboCompression.Name = "cboCompression";
            this.cboCompression.Size = new System.Drawing.Size(160, 21);
            this.cboCompression.Sorted = true;
            this.cboCompression.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Compression:";
            // 
            // cboFileType
            // 
            this.cboFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileType.Location = new System.Drawing.Point(16, 224);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(160, 21);
            this.cboFileType.Sorted = true;
            this.cboFileType.TabIndex = 7;
            this.cboFileType.SelectedIndexChanged += new System.EventHandler(this.cboFileType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Type:";
            // 
            // cboScanMode
            // 
            this.cboScanMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboScanMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScanMode.Items.AddRange(new object[] {
            "Memory",
            "File"});
            this.cboScanMode.Location = new System.Drawing.Point(88, 24);
            this.cboScanMode.Name = "cboScanMode";
            this.cboScanMode.Size = new System.Drawing.Size(88, 21);
            this.cboScanMode.TabIndex = 1;
            this.cboScanMode.SelectedIndexChanged += new System.EventHandler(this.cboScanMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scan Mode:";
            // 
            // cboPixelFormat
            // 
            this.cboPixelFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPixelFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPixelFormat.Location = new System.Drawing.Point(16, 120);
            this.cboPixelFormat.Name = "cboPixelFormat";
            this.cboPixelFormat.Size = new System.Drawing.Size(160, 21);
            this.cboPixelFormat.TabIndex = 3;
            this.cboPixelFormat.SelectedIndexChanged += new System.EventHandler(this.cboPixelFormat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pixel Format:";
            // 
            // chkShowDialog
            // 
            this.chkShowDialog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkShowDialog.Location = new System.Drawing.Point(16, 58);
            this.chkShowDialog.Name = "chkShowDialog";
            this.chkShowDialog.Size = new System.Drawing.Size(176, 16);
            this.chkShowDialog.TabIndex = 2;
            this.chkShowDialog.Text = "Show Scanner Dialog";
            // 
            // btnAcquire
            // 
            this.btnAcquire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcquire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAcquire.Location = new System.Drawing.Point(16, 80);
            this.btnAcquire.Name = "btnAcquire";
            this.btnAcquire.Size = new System.Drawing.Size(192, 24);
            this.btnAcquire.TabIndex = 3;
            this.btnAcquire.Text = "&Acquire";
            this.btnAcquire.Click += new System.EventHandler(this.btnAcquire_Click);
            // 
            // cboDevices
            // 
            this.cboDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevices.Location = new System.Drawing.Point(16, 32);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(192, 21);
            this.cboDevices.Sorted = true;
            this.cboDevices.TabIndex = 1;
            this.cboDevices.SelectedIndexChanged += new System.EventHandler(this.cboDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(224, 0);
            this.splitter1.MinExtra = 200;
            this.splitter1.MinSize = 200;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 557);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelIimage
            // 
            this.panelIimage.AutoScroll = true;
            this.panelIimage.BackColor = System.Drawing.SystemColors.Window;
            this.panelIimage.Controls.Add(this.picImage);
            this.panelIimage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIimage.Location = new System.Drawing.Point(230, 0);
            this.panelIimage.Name = "panelIimage";
            this.panelIimage.Size = new System.Drawing.Size(482, 557);
            this.panelIimage.TabIndex = 2;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.SystemColors.Window;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(712, 557);
            this.Controls.Add(this.panelIimage);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelControls);
            this.Name = "Form1";
            this.Text = "Atalasoft DotImage ISIS Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScanAhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPageCountLimit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelIimage.ResumeLayout(false);
            this.panelIimage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            // This will throw an exception if there is no license.
            try
            {
                Atalasoft.Imaging.AtalaImage img = new Atalasoft.Imaging.AtalaImage();
                img.Dispose();

                _acquisition = new Atalasoft.Isis.IsisAcquisition();
            }
            catch (Atalasoft.Imaging.AtalasoftLicenseException)
            {
                MessageBox.Show("This demo requires a license for 'DotImage' and 'DotImage ISIS'.\r\n\r\nYou can get an evaluation license using the Activation utility or\r\nfrom http://www.atalasoft.com/portal/requestevaluation.aspx.", "No License Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

			if (_acquisition.Devices.Count == 0)
			{
				MessageBox.Show("No ISIS drivers where found on your system.", "No ISIS Drivers");
				this.cboDevices.Enabled = false;
				this.groupBox1.Enabled = false;
				this.btnAcquire.Enabled = false;
				this.chkShowDialog.Enabled = false;
				return;
			}

			// Fill the combobox with devices and make the default device selected.
			this.cboDevices.Items.AddRange(_acquisition.Devices.ToArray());

			// It's possible that the Default property will return null.
			// This can happen if the user never used an ISIS driver before.
			if (_acquisition.Devices.Default != null)
			{
				int index = this.cboDevices.Items.IndexOf(_acquisition.Devices.Default);
				if (index != -1) this.cboDevices.SelectedIndex = index;
			}

			this.cboScanMode.SelectedIndex = 0;
			this.cboAcquiredImageType.SelectedIndex = 0;

			HookEvents(true);

			// Show the version of DotImage ISIS in the title bar.
			this.Text = "Atalasoft DotImage ISIS Demo - Version " + GetDotImageIsisVersion();
		}

		private void HookEvents(bool enable)
		{
			if (enable)
			{
				_acquisition.AcquireCanceled += new EventHandler(_acquisition_AcquireCanceled);
				_acquisition.AcquireFinished += new EventHandler(_acquisition_AcquireFinished);
				_acquisition.BarcodeDetected += new IsisBarcodeDetectedEventHandler(_acquisition_BarcodeDetected);
				_acquisition.ErrorNotification += new IsisErrorNotificationEventHandler(_acquisition_ErrorNotification);
				_acquisition.ImageAcquired += new IsisImageAcquiredEventHandler(_acquisition_ImageAcquired);
				_acquisition.ImageAcquiring += new IsisImageAcquiringEventHandler(_acquisition_ImageAcquiring);
				_acquisition.FileAcquisition += new IsisFileAcquisitionEventHandler(_acquisition_FileAcquisition);
			}
			else
			{
				_acquisition.AcquireCanceled -= new EventHandler(_acquisition_AcquireCanceled);
				_acquisition.AcquireFinished -= new EventHandler(_acquisition_AcquireFinished);
				_acquisition.BarcodeDetected -= new IsisBarcodeDetectedEventHandler(_acquisition_BarcodeDetected);
				_acquisition.ErrorNotification -= new IsisErrorNotificationEventHandler(_acquisition_ErrorNotification);
				_acquisition.ImageAcquired -= new IsisImageAcquiredEventHandler(_acquisition_ImageAcquired);
				_acquisition.ImageAcquiring -= new IsisImageAcquiringEventHandler(_acquisition_ImageAcquiring);
				_acquisition.FileAcquisition -= new IsisFileAcquisitionEventHandler(_acquisition_FileAcquisition);
			}
		}

		#region Isis Events

		private void _acquisition_AcquireCanceled(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Acquire Canceled");
		}

		private void _acquisition_AcquireFinished(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Acquire Finished");
		}

		private void _acquisition_BarcodeDetected(object sender, IsisBarcodeDetectedEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Barcode Detected: " + e.Text);
		}

		private void _acquisition_ErrorNotification(object sender, IsisErrorNotificationEventArgs e)
		{
			MessageBox.Show(this, "Error:\r\n\r\n" + e.Message + (e.Exception == null ? "" : e.Exception.Message), "Error Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void _acquisition_ImageAcquiring(object sender, IsisImageAcquiringEventArgs e)
		{
            // This event is raised before each page is acquired, allowing it to be canceled.
            int count = (int)this.numPageCountLimit.Value;

            if (count > 0)
            {
                // suggested by Michael C for proper cancel in ISIS, the scanAhead needs to 
                // adjust downard
                if (_acquisition.ActiveDevice.Settings.ScanAheadCount > count - e.PageCount)
                {
                    _acquisition.ActiveDevice.Settings.ScanAheadCount = count - e.PageCount;
                }
                // changed > to >+ for "off by 1 error"
                if (e.PageCount >= count)
                {
                    // added to ensure scanner stops scanning
                    _acquisition.ActiveDevice.Settings.ScanAhead = false;
                    e.Cancel = true;
                }
            }
		}

		private void _acquisition_ImageAcquired(object sender, IsisImageAcquiredEventArgs e)
		{
			// This event is raised for each page during an acquisition.
			if (this.picImage.Image != null) this.picImage.Image.Dispose();
			
			// Set the AcquiredImageType property on the IsisAcquisition or IsisController 
			// to specify whether you receive an AtalaImage or a .NET Bitmap.
			if (e.Image != null)
			{
				this.picImage.Image = e.Image.ToBitmap();
				e.Image.Dispose();
			}
			else if (e.Bitmap != null)
			{
				this.picImage.Image = e.Bitmap;
			}

			if (e.JobSeparator) System.Diagnostics.Debug.WriteLine("Job Separator");
		}

		private void _acquisition_FileAcquisition(object sender, IsisFileAcquisitionEventArgs e)
		{
			// This event is raised for each page during a file acquisition.
			if (this.chkSaveMultipage.Checked && (e.FileType == IsisFileType.Tiff || e.FileType == IsisFileType.Pdf || e.FileType == IsisFileType.Dcx))
				e.Append = true; // This can be true for the first page as well.
			
			e.FileName = GetCustomFileName(GetFileExtension(e.FileType));

		}

		#endregion

		private void btnAcquire_Click(object sender, System.EventArgs e)
		{
			// Remove the current image.
			if (this.picImage.Image != null)
				this.picImage.Image.Dispose();
			this.picImage.Image = null;

			this.Cursor = Cursors.WaitCursor;
			EnableControls(false);
			_multipageFile = "";

			try
			{
				IsisDevice dev = this._acquisition.ActiveDevice;
				if (dev.Open())
				{
					try
					{
						// Set requested properties.
						dev.Settings.PixelFormat = (IsisPixelFormat)this.cboPixelFormat.SelectedItem;
						dev.Settings.Resolution = (Rational)this.cboResolution.SelectedItem;

                        if (numScanAhead.Value > 0)
                        {
                            dev.Settings.ScanAhead = true;
                            dev.Settings.ScanAheadCount = (int)numScanAhead.Value;
                        }
                        else
                        {
                            dev.Settings.ScanAhead = false;
                            dev.Settings.ScanAheadCount = 0;
                        }
                        
						if (this.chkShowDialog.Checked)
						{
							if (!this._acquisition.ShowDeviceDialog(this))
								return;
						}

						if (this.cboScanMode.SelectedIndex == 0)
							dev.Acquire();
						else
						{
							if (_fileSaveDir.Length == 0)
							{
								FolderBrowserDialog dlg = new FolderBrowserDialog();
								dlg.Description = "Select where these images will be saved.";
								if (dlg.ShowDialog(this) == DialogResult.OK)
								{
									_fileSaveDir = dlg.SelectedPath;
									dev.AcquireToFile((IsisFileType)this.cboFileType.SelectedItem, (IsisCompression)this.cboCompression.SelectedItem);
								}
								dlg.Dispose();
							}
							else
								dev.AcquireToFile((IsisFileType)this.cboFileType.SelectedItem, (IsisCompression)this.cboCompression.SelectedItem);
						}
					}
					finally
					{
						dev.Close();
					}
				}
			}
			finally
			{
				EnableControls(true);
				this.Cursor = Cursors.Default;
			}
		}

		#region Combobox Selection Changed Events

		private void cboDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Clear and rebuild the scanner options.
			this.cboFileType.Items.Clear();
			this.cboCompression.Items.Clear();
			this.cboPixelFormat.Items.Clear();
			this.cboResolution.Items.Clear();

			this.Cursor = Cursors.WaitCursor;

			// Set the active device and query its capabilities.
			this._acquisition.ActiveDevice = (IsisDevice)this.cboDevices.SelectedItem;
			if (!this._acquisition.ActiveDevice.Open())
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show("We were unable to open a connection to the driver.", "Open Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			try
			{
				IsisSettings settings = _acquisition.ActiveDevice.Settings;
				
				// Drivers must support color format, so there is no need to use QuerySupport on it.
				_driverColorFormats = settings.GetSupportedColorFormats();
				if (_driverColorFormats != null)
					FillColorFormatControl(_driverColorFormats, settings.PixelFormat);

				if (settings.QuerySupport(IsisSetting.FileType))
				{
					_usingIsisCodecs = false;

					IsisFileType[] fileTypes = settings.GetSupportedFileTypes();
					if (fileTypes != null)
						FillFileTypeControl(fileTypes, settings.FileType);
				}
				else
				{
					_usingIsisCodecs = true;
					
					// See if there are other ISIS drivers which can be used to save the file.
					IsisFileType[] fts = _acquisition.CodecManager.GetFileTypes();
					if (fts != null && fts.Length > 0)
						FillFileTypeControl(fts, fts[0]);
				}

				if (settings.QuerySupport(IsisSetting.ResolutionX))
				{
					Rational[] resolutions = settings.GetSupportedResolutions();
					if (resolutions != null)
					{
						foreach (Rational rat in resolutions)
							this.cboResolution.Items.Add(rat);
					}

					int resIndex = this.cboResolution.Items.IndexOf(settings.Resolution);
					if (resIndex != -1) this.cboResolution.SelectedIndex = resIndex;
				}
			}
			finally
			{
				this._acquisition.ActiveDevice.Close();
				this.Cursor = Cursors.Default;
			}
		}

		private void cboAcquiredImageType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this._acquisition.AcquiredImageType = (this.cboAcquiredImageType.Text == "AtalaImage" ? IsisAcquiredImageType.AtalaImage : IsisAcquiredImageType.Bitmap);
		}

		private void cboFileType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			IsisFileType ff = (IsisFileType)this.cboFileType.SelectedItem;
			this.chkSaveMultipage.Enabled = (ff == IsisFileType.Tiff || ff == IsisFileType.Pdf || ff == IsisFileType.Dcx);
			if (!this.chkSaveMultipage.Enabled)
				this.chkSaveMultipage.Checked = false;

			if (_usingIsisCodecs)
			{
				if (this.cboScanMode.Text.Equals("File"))
					FillFileTypeColorFormats();

				this.cboCompression.Items.Clear();
				IsisCompression[] comps = this._acquisition.CodecManager[ff].GetSupportedCompressions();
				if (comps != null)
				{
					foreach (IsisCompression c in comps)
						this.cboCompression.Items.Add(c);

					this.cboCompression.SelectedIndex = 0;
				}
			}
			else
			{
				if (this._acquisition.ActiveDevice.Open())
				{
					try
					{
						this._acquisition.ActiveDevice.Settings.FileType = ff;
						IsisCompression[] comps = this._acquisition.ActiveDevice.Settings.GetSupportedCompressions();
						if (comps != null)
						{
							foreach (IsisCompression c in comps)
								this.cboCompression.Items.Add(c);

							this.cboCompression.SelectedIndex = 0;
						}
					}
					finally
					{
						this._acquisition.ActiveDevice.Close();
					}
				}
			}
		}

		private void cboScanMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			bool fileMode = this.cboScanMode.Text.Equals("File");
			this.cboFileType.Enabled = fileMode;
			this.cboCompression.Enabled = fileMode;
			this.chkSaveMultipage.Enabled = fileMode;

			if (fileMode)
			{
				if (this.cboFileType.SelectedIndex != -1)
					FillFileTypeColorFormats();
			}
			else if (_driverColorFormats != null && _driverColorFormats.Length > 0)
			{
				FillColorFormatControl(_driverColorFormats, _driverColorFormats[0]);
			}
		}

		private void cboPixelFormat_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Only allow supported compressions.
			if (_usingIsisCodecs && this.cboFileType.SelectedIndex != -1 && this.cboPixelFormat.SelectedIndex != -1)
			{
				IsisFileType ft = (IsisFileType)this.cboFileType.SelectedItem;
				IsisPixelFormat pf = (IsisPixelFormat)this.cboPixelFormat.SelectedItem;

				IsisCompression[] comps = this._acquisition.CodecManager[ft].GetSupportedCompressions(pf);
				if (comps != null)
				{
					this.cboCompression.Items.Clear();
					foreach (IsisCompression comp in comps)
						this.cboCompression.Items.Add(comp);

					this.cboCompression.SelectedIndex = 0;
				}
			}
		}

		#endregion

		private void EnableControls(bool enabled)
		{
			this.btnAcquire.Enabled = enabled;
			this.cboDevices.Enabled = enabled;
			this.chkShowDialog.Enabled = enabled;
			this.groupBox1.Enabled = enabled;
		}

		private void FillFileTypeColorFormats()
		{
			if (!_usingIsisCodecs || _driverColorFormats == null) return;

			// Fill the color format list so it only contains
			// valid formats for the selected file type.
			IsisFileType ft = (IsisFileType)this.cboFileType.SelectedItem;
			IsisPixelFormat[] cfs = _acquisition.CodecManager[ft].GetSupportedColorFormats();
			if (cfs != null)
			{
				// Make sure the color format is supported by the driver.
				ArrayList list = new ArrayList();
				foreach (IsisPixelFormat cf in cfs)
				{
					foreach (IsisPixelFormat dcf in _driverColorFormats)
					{
						if (dcf == cf)
						{
							list.Add(cf);
							break;
						}
					}
				}

				cfs = (IsisPixelFormat[])list.ToArray(typeof(IsisPixelFormat));

				if (cfs != null)
					FillColorFormatControl(cfs, cfs[0]);
			}

			this.chkSaveMultipage.Enabled = (ft == IsisFileType.Dcx || ft == IsisFileType.Pdf || ft == IsisFileType.Tiff);
		}

		private void FillColorFormatControl(IsisPixelFormat[] formats, IsisPixelFormat selected)
		{
			this.cboPixelFormat.Items.Clear();

			if (formats != null)
			{
				int selectedIndex = 0;
				int index = 0;

				foreach (IsisPixelFormat cf in formats)
				{
					this.cboPixelFormat.Items.Add(cf);
					if (cf == selected) 
					{
						selectedIndex = index;
					}
					index++;
				}

				this.cboPixelFormat.SelectedIndex = selectedIndex;
			}
		}

		private void FillFileTypeControl(IsisFileType[] fileTypes, IsisFileType selected)
		{
			this.cboFileType.Items.Clear();

			if (fileTypes != null)
			{
				int selectedIndex = 0;
				int index = 0;

				foreach (IsisFileType ft in fileTypes)
				{
					this.cboFileType.Items.Add(ft);
					if (ft == selected) 
					{
						selectedIndex = index;
						this.chkSaveMultipage.Enabled = (ft == IsisFileType.Tiff || ft == IsisFileType.Pdf || ft == IsisFileType.Dcx);
					}
					index++;
				}

				this.cboFileType.SelectedIndex = selectedIndex;
			}
		}

		private string GetCustomFileName(string extension)
		{
			// Use the same filename for multipage support.
			if (_multipageFile.Length > 0)
				return _multipageFile;

			string filename = _fileSaveDir + @"\scan_" + _fileCount.ToString() + extension;

			while (System.IO.File.Exists(filename))
			{
				_fileCount++;
				filename = _fileSaveDir + @"\scan_" + _fileCount.ToString() + extension;
			}

			if (this.chkSaveMultipage.Checked)
				_multipageFile = filename;

			return filename;
		}

		private string GetFileExtension(IsisFileType fileType)
		{
			switch (fileType)
			{
				case IsisFileType.Bmp:
					return ".bmp";
				case IsisFileType.Dcx:
					return ".dcx";
				case IsisFileType.Gif:
					return ".gif";
				case IsisFileType.Jbig:
					return ".jbg";
				case IsisFileType.Jpeg:
					return ".jpg";
				case IsisFileType.Jpeg2000:
					return ".jp2";
				case IsisFileType.Pcx:
					return ".pcx";
				case IsisFileType.Pda:
					return ".pda";
				case IsisFileType.Pdf:
					return ".pdf";
				case IsisFileType.Png:
					return ".png";
				case IsisFileType.Cals:
					return ".cal";
				case IsisFileType.MoDca:
					return ".dca";
				default:
					return ".tif";
			}
		}

		private string GetDotImageIsisVersion()
		{
			try
			{
                System.Reflection.Assembly asm = System.Reflection.Assembly.Load("Atalasoft.dotImage.Isis", null);
				Version ver = asm.GetName().Version;
				return ver.ToString();
			}
			catch
			{
				return "unknown";
			}
		}

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AtalaDemos.AboutBox.About aboutBox = new AtalaDemos.AboutBox.About("Atalasoft DotImage ISIS Demo", "ISIS Demo");
            aboutBox.Description = "Basic scanner selection and acquisition using Atalasoft's ISIS components.\r\n\r\n" +
                                   "This is a slightly scaled down ISIS version of our TWAIN Acquisition Demo. Its main purpose is to demonstrate the basics of how select from available ISIS scanners, and how to control various basic settings like pixel format, resolution, and whether or not to show the device's default scanning dialog.\r\n\r\n" +
                                   "The source code should provide a solid foundation in understanding how to work with our ISIS scanning components, while the running demo provides a quick means to 'sanity check' whether your scanner is visible to DotImage.";
            aboutBox.ShowDialog();
        }
	}
}

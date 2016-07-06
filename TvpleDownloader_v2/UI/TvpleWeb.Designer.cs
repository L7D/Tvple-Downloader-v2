/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

namespace TvpleDownloader_v2
{
	partial class TvpleWeb
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( TvpleWeb ) );
			this.webBrowser = new System.Windows.Forms.WebBrowser( );
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel( );
			this.DOWNLOAD_NOW_BUTTON = new System.Windows.Forms.Button( );
			this.WEB_NAME = new TvpleDownloader_v2.CustomLabel( );
			this.HOME_BUTTON = new System.Windows.Forms.PictureBox( );
			this.TVPLE_URL_GO_BUTTON = new System.Windows.Forms.Button( );
			this.NEXT_BUTTON = new System.Windows.Forms.PictureBox( );
			this.TVPLE_URL = new System.Windows.Forms.TextBox( );
			this.PREVIOUS_BUTTON = new System.Windows.Forms.PictureBox( );
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox( );
			this.APP_TITLE = new TvpleDownloader_v2.CustomLabel( );
			this.APP_TITLE_BAR.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.HOME_BUTTON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.NEXT_BUTTON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.PREVIOUS_BUTTON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// webBrowser
			// 
			this.webBrowser.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
			| System.Windows.Forms.AnchorStyles.Left )
			| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.webBrowser.Location = new System.Drawing.Point( 10, 39 );
			this.webBrowser.MinimumSize = new System.Drawing.Size( 20, 20 );
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size( 880, 551 );
			this.webBrowser.TabIndex = 0;
			this.webBrowser.Url = new System.Uri( "http://tvple.com/", System.UriKind.Absolute );
			this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler( this.webBrowser_DocumentCompleted );
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
			| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add( this.DOWNLOAD_NOW_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.WEB_NAME );
			this.APP_TITLE_BAR.Controls.Add( this.HOME_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.TVPLE_URL_GO_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.NEXT_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.TVPLE_URL );
			this.APP_TITLE_BAR.Controls.Add( this.PREVIOUS_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.CLOSE_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.APP_TITLE );
			this.APP_TITLE_BAR.Location = new System.Drawing.Point( 0, 0 );
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size( 900, 40 );
			this.APP_TITLE_BAR.TabIndex = 23;
			this.APP_TITLE_BAR.SizeChanged += new System.EventHandler( this.APP_TITLE_BAR_SizeChanged );
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler( this.APP_TITLE_BAR_Paint );
			this.APP_TITLE_BAR.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseDoubleClick );
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseDown );
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseMove );
			// 
			// DOWNLOAD_NOW_BUTTON
			// 
			this.DOWNLOAD_NOW_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.DOWNLOAD_NOW_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.DOWNLOAD_NOW_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.DOWNLOAD_NOW_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DOWNLOAD_NOW_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.DOWNLOAD_NOW_BUTTON.Location = new System.Drawing.Point( 115, 8 );
			this.DOWNLOAD_NOW_BUTTON.Name = "DOWNLOAD_NOW_BUTTON";
			this.DOWNLOAD_NOW_BUTTON.Size = new System.Drawing.Size( 133, 25 );
			this.DOWNLOAD_NOW_BUTTON.TabIndex = 48;
			this.DOWNLOAD_NOW_BUTTON.Text = "현재 영상 다운로드!";
			this.DOWNLOAD_NOW_BUTTON.UseVisualStyleBackColor = true;
			this.DOWNLOAD_NOW_BUTTON.Visible = false;
			this.DOWNLOAD_NOW_BUTTON.Click += new System.EventHandler( this.DOWNLOAD_NOW_BUTTON_Click );
			// 
			// WEB_NAME
			// 
			this.WEB_NAME.BackColor = System.Drawing.Color.Transparent;
			this.WEB_NAME.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.WEB_NAME.Location = new System.Drawing.Point( 265, 12 );
			this.WEB_NAME.Name = "WEB_NAME";
			this.WEB_NAME.Size = new System.Drawing.Size( 244, 17 );
			this.WEB_NAME.TabIndex = 40;
			this.WEB_NAME.Text = "티비플";
			this.WEB_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HOME_BUTTON
			// 
			this.HOME_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.HOME_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HOME_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.HOME_BUTTON;
			this.HOME_BUTTON.Location = new System.Drawing.Point( 772, 8 );
			this.HOME_BUTTON.Name = "HOME_BUTTON";
			this.HOME_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.HOME_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HOME_BUTTON.TabIndex = 47;
			this.HOME_BUTTON.TabStop = false;
			this.HOME_BUTTON.Click += new System.EventHandler( this.HOME_BUTTON_Click );
			// 
			// TVPLE_URL_GO_BUTTON
			// 
			this.TVPLE_URL_GO_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.TVPLE_URL_GO_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.TVPLE_URL_GO_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.TVPLE_URL_GO_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TVPLE_URL_GO_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.TVPLE_URL_GO_BUTTON.Location = new System.Drawing.Point( 717, 8 );
			this.TVPLE_URL_GO_BUTTON.Name = "TVPLE_URL_GO_BUTTON";
			this.TVPLE_URL_GO_BUTTON.Size = new System.Drawing.Size( 49, 25 );
			this.TVPLE_URL_GO_BUTTON.TabIndex = 44;
			this.TVPLE_URL_GO_BUTTON.Text = "이동";
			this.TVPLE_URL_GO_BUTTON.UseVisualStyleBackColor = true;
			this.TVPLE_URL_GO_BUTTON.Click += new System.EventHandler( this.TVPLE_URL_GO_BUTTON_Click );
			// 
			// NEXT_BUTTON
			// 
			this.NEXT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.NEXT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NEXT_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.NEXT_BUTTON;
			this.NEXT_BUTTON.Location = new System.Drawing.Point( 834, 8 );
			this.NEXT_BUTTON.Name = "NEXT_BUTTON";
			this.NEXT_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.NEXT_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NEXT_BUTTON.TabIndex = 46;
			this.NEXT_BUTTON.TabStop = false;
			this.NEXT_BUTTON.Click += new System.EventHandler( this.NEXT_BUTTON_Click );
			// 
			// TVPLE_URL
			// 
			this.TVPLE_URL.BackColor = System.Drawing.Color.White;
			this.TVPLE_URL.Font = new System.Drawing.Font( "맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.TVPLE_URL.Location = new System.Drawing.Point( 516, 8 );
			this.TVPLE_URL.Name = "TVPLE_URL";
			this.TVPLE_URL.Size = new System.Drawing.Size( 195, 25 );
			this.TVPLE_URL.TabIndex = 29;
			this.TVPLE_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.TVPLE_URL_KeyPress );
			// 
			// PREVIOUS_BUTTON
			// 
			this.PREVIOUS_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.PREVIOUS_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PREVIOUS_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.PREVIOUS_BUTTON;
			this.PREVIOUS_BUTTON.Location = new System.Drawing.Point( 803, 8 );
			this.PREVIOUS_BUTTON.Name = "PREVIOUS_BUTTON";
			this.PREVIOUS_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.PREVIOUS_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PREVIOUS_BUTTON.TabIndex = 45;
			this.PREVIOUS_BUTTON.TabStop = false;
			this.PREVIOUS_BUTTON.Click += new System.EventHandler( this.PREVIOUS_BUTTON_Click );
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.CLOSE_BUTTON;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point( 866, 8 );
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 23;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler( this.CLOSE_BUTTON_Click );
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.Font = new System.Drawing.Font( "맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_TITLE.Location = new System.Drawing.Point( 5, 10 );
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size( 104, 20 );
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "티비플 탐색기";
			// 
			// TvpleWeb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size( 900, 600 );
			this.Controls.Add( this.APP_TITLE_BAR );
			this.Controls.Add( this.webBrowser );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
			this.MinimumSize = new System.Drawing.Size( 900, 600 );
			this.Name = "TvpleWeb";
			this.Text = "티비플 탐색기";
			this.Load += new System.EventHandler( this.TvpleWeb_Load );
			this.APP_TITLE_BAR.ResumeLayout( false );
			this.APP_TITLE_BAR.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.HOME_BUTTON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.NEXT_BUTTON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.PREVIOUS_BUTTON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).EndInit( );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.TextBox TVPLE_URL;
		private System.Windows.Forms.Button TVPLE_URL_GO_BUTTON;
		private System.Windows.Forms.PictureBox PREVIOUS_BUTTON;
		private System.Windows.Forms.PictureBox NEXT_BUTTON;
		private System.Windows.Forms.PictureBox HOME_BUTTON;
		private CustomLabel WEB_NAME;
		private System.Windows.Forms.Button DOWNLOAD_NOW_BUTTON;
	}
}
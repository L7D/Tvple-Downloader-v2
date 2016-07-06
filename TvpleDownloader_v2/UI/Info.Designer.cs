/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

namespace TvpleDownloader_v2
{
	partial class Info
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Info ) );
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel( );
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox( );
			this.APP_TITLE = new TvpleDownloader_v2.CustomLabel( );
			this.PROGRAM_TITLE = new System.Windows.Forms.Label( );
			this.PROGRAM_TITLE_ENG = new System.Windows.Forms.Label( );
			this.PROGRAM_VERSION = new System.Windows.Forms.Label( );
			this.COPYRIGHT = new System.Windows.Forms.Label( );
			this.COPYRIGHT_STREAM_PROFILE = new System.Windows.Forms.Button( );
			this.LAW_DESC = new System.Windows.Forms.Label( );
			this.LAW_TITLE = new System.Windows.Forms.Label( );
			this.PROGRAM_ICON = new System.Windows.Forms.PictureBox( );
			this.COPYRIGHT_TVPLE = new System.Windows.Forms.Label( );
			this.APP_TITLE_BAR.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.PROGRAM_ICON ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add( this.CLOSE_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.APP_TITLE );
			this.APP_TITLE_BAR.Location = new System.Drawing.Point( 0, 0 );
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size( 350, 40 );
			this.APP_TITLE_BAR.TabIndex = 23;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler( this.APP_TITLE_BAR_Paint );
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseDown );
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseMove );
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.CLOSE_BUTTON;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point( 316, 8 );
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 26;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler( this.CLOSE_BUTTON_Click );
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.Font = new System.Drawing.Font( "맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_TITLE.Location = new System.Drawing.Point( 5, 10 );
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size( 154, 20 );
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "티비플 다운로더 정보";
			// 
			// PROGRAM_TITLE
			// 
			this.PROGRAM_TITLE.AutoSize = true;
			this.PROGRAM_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_TITLE.Font = new System.Drawing.Font( "맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.PROGRAM_TITLE.Location = new System.Drawing.Point( 162, 46 );
			this.PROGRAM_TITLE.Name = "PROGRAM_TITLE";
			this.PROGRAM_TITLE.Size = new System.Drawing.Size( 119, 20 );
			this.PROGRAM_TITLE.TabIndex = 27;
			this.PROGRAM_TITLE.Text = "티비플 다운로더";
			// 
			// PROGRAM_TITLE_ENG
			// 
			this.PROGRAM_TITLE_ENG.AutoSize = true;
			this.PROGRAM_TITLE_ENG.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_TITLE_ENG.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.PROGRAM_TITLE_ENG.Location = new System.Drawing.Point( 163, 68 );
			this.PROGRAM_TITLE_ENG.Name = "PROGRAM_TITLE_ENG";
			this.PROGRAM_TITLE_ENG.Size = new System.Drawing.Size( 112, 15 );
			this.PROGRAM_TITLE_ENG.TabIndex = 28;
			this.PROGRAM_TITLE_ENG.Text = "Tvple Downloader";
			// 
			// PROGRAM_VERSION
			// 
			this.PROGRAM_VERSION.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_VERSION.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.PROGRAM_VERSION.Location = new System.Drawing.Point( 163, 88 );
			this.PROGRAM_VERSION.Name = "PROGRAM_VERSION";
			this.PROGRAM_VERSION.Size = new System.Drawing.Size( 175, 20 );
			this.PROGRAM_VERSION.TabIndex = 29;
			this.PROGRAM_VERSION.Text = "버전 1.0";
			this.PROGRAM_VERSION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// COPYRIGHT
			// 
			this.COPYRIGHT.AutoSize = true;
			this.COPYRIGHT.BackColor = System.Drawing.Color.Transparent;
			this.COPYRIGHT.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.COPYRIGHT.Location = new System.Drawing.Point( 7, 301 );
			this.COPYRIGHT.Name = "COPYRIGHT";
			this.COPYRIGHT.Size = new System.Drawing.Size( 79, 15 );
			this.COPYRIGHT.TabIndex = 30;
			this.COPYRIGHT.Text = "© 2016 L7D.";
			// 
			// COPYRIGHT_STREAM_PROFILE
			// 
			this.COPYRIGHT_STREAM_PROFILE.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.COPYRIGHT_STREAM_PROFILE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.COPYRIGHT_STREAM_PROFILE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.COPYRIGHT_STREAM_PROFILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.COPYRIGHT_STREAM_PROFILE.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.COPYRIGHT_STREAM_PROFILE.Location = new System.Drawing.Point( 195, 297 );
			this.COPYRIGHT_STREAM_PROFILE.Name = "COPYRIGHT_STREAM_PROFILE";
			this.COPYRIGHT_STREAM_PROFILE.Size = new System.Drawing.Size( 150, 23 );
			this.COPYRIGHT_STREAM_PROFILE.TabIndex = 31;
			this.COPYRIGHT_STREAM_PROFILE.Text = "개발자 스팀 프로필";
			this.COPYRIGHT_STREAM_PROFILE.UseVisualStyleBackColor = true;
			this.COPYRIGHT_STREAM_PROFILE.Click += new System.EventHandler( this.COPYRIGHT_STREAM_PROFILE_Click );
			// 
			// LAW_DESC
			// 
			this.LAW_DESC.BackColor = System.Drawing.Color.Transparent;
			this.LAW_DESC.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.LAW_DESC.Location = new System.Drawing.Point( 6, 226 );
			this.LAW_DESC.Name = "LAW_DESC";
			this.LAW_DESC.Size = new System.Drawing.Size( 335, 49 );
			this.LAW_DESC.TabIndex = 32;
			this.LAW_DESC.Text = "본 프로그램 \'티비플 다운로더\' 를 사용하여 발생하는 모든 티비플 영상 관련 저작권 문제는 본 프로그램의 개발자가 책임지지 않습니다.";
			// 
			// LAW_TITLE
			// 
			this.LAW_TITLE.AutoSize = true;
			this.LAW_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.LAW_TITLE.Font = new System.Drawing.Font( "맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.LAW_TITLE.Location = new System.Drawing.Point( 6, 202 );
			this.LAW_TITLE.Name = "LAW_TITLE";
			this.LAW_TITLE.Size = new System.Drawing.Size( 39, 20 );
			this.LAW_TITLE.TabIndex = 33;
			this.LAW_TITLE.Text = "경고";
			// 
			// PROGRAM_ICON
			// 
			this.PROGRAM_ICON.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_ICON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PROGRAM_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.APP_ICON;
			this.PROGRAM_ICON.Location = new System.Drawing.Point( 6, 46 );
			this.PROGRAM_ICON.Name = "PROGRAM_ICON";
			this.PROGRAM_ICON.Size = new System.Drawing.Size( 150, 150 );
			this.PROGRAM_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PROGRAM_ICON.TabIndex = 26;
			this.PROGRAM_ICON.TabStop = false;
			// 
			// COPYRIGHT_TVPLE
			// 
			this.COPYRIGHT_TVPLE.AutoSize = true;
			this.COPYRIGHT_TVPLE.BackColor = System.Drawing.Color.Transparent;
			this.COPYRIGHT_TVPLE.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.COPYRIGHT_TVPLE.Location = new System.Drawing.Point( 7, 286 );
			this.COPYRIGHT_TVPLE.Name = "COPYRIGHT_TVPLE";
			this.COPYRIGHT_TVPLE.Size = new System.Drawing.Size( 178, 15 );
			this.COPYRIGHT_TVPLE.TabIndex = 34;
			this.COPYRIGHT_TVPLE.Text = "© 2016 Ultra Monster(Tvple).";
			// 
			// Info
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size( 350, 325 );
			this.Controls.Add( this.COPYRIGHT_TVPLE );
			this.Controls.Add( this.LAW_TITLE );
			this.Controls.Add( this.LAW_DESC );
			this.Controls.Add( this.COPYRIGHT_STREAM_PROFILE );
			this.Controls.Add( this.COPYRIGHT );
			this.Controls.Add( this.PROGRAM_VERSION );
			this.Controls.Add( this.PROGRAM_TITLE_ENG );
			this.Controls.Add( this.PROGRAM_TITLE );
			this.Controls.Add( this.PROGRAM_ICON );
			this.Controls.Add( this.APP_TITLE_BAR );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
			this.Name = "Info";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "티비플 다운로더";
			this.Load += new System.EventHandler( this.Info_Load );
			this.APP_TITLE_BAR.ResumeLayout( false );
			this.APP_TITLE_BAR.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.PROGRAM_ICON ) ).EndInit( );
			this.ResumeLayout( false );
			this.PerformLayout( );

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox PROGRAM_ICON;
		private System.Windows.Forms.Label PROGRAM_TITLE;
		private System.Windows.Forms.Label PROGRAM_TITLE_ENG;
		private System.Windows.Forms.Label PROGRAM_VERSION;
		private System.Windows.Forms.Label COPYRIGHT;
		private System.Windows.Forms.Button COPYRIGHT_STREAM_PROFILE;
		private System.Windows.Forms.Label LAW_DESC;
		private System.Windows.Forms.Label LAW_TITLE;
		private System.Windows.Forms.Label COPYRIGHT_TVPLE;
	}
}
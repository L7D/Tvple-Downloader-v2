/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

namespace TvpleDownloader_v2
{
	partial class Main
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Main ) );
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel( );
			this.APP_ICON = new System.Windows.Forms.PictureBox( );
			this.MINIMIZE_BUTTON = new System.Windows.Forms.PictureBox( );
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox( );
			this.APP_TITLE = new TvpleDownloader_v2.CustomLabel( );
			this.TVPLE_WEB_BUTTON = new System.Windows.Forms.Button( );
			this.VIDEO_NAME = new System.Windows.Forms.Label( );
			this.VIDEO_UPLOADER = new System.Windows.Forms.Label( );
			this.VIDEO_UPLOADER_CHANEL = new System.Windows.Forms.Button( );
			this.VIDEO_INFO_PANEL = new System.Windows.Forms.Panel( );
			this.VIDEO_OPEN_URL_BUTTON = new System.Windows.Forms.Button( );
			this.STAR_BUTTON = new System.Windows.Forms.Button( );
			this.VIDEO_VIEWS_ICON = new System.Windows.Forms.PictureBox( );
			this.VIDEO_POPULAR_ICON = new System.Windows.Forms.PictureBox( );
			this.VIDEO_LENGTH_ICON = new System.Windows.Forms.PictureBox( );
			this.VIDEO_RESOLUTION_ICON = new System.Windows.Forms.PictureBox( );
			this.VIDEO_DESC = new System.Windows.Forms.Label( );
			this.DOWNLOAD_LABEL = new System.Windows.Forms.Label( );
			this.DOWNLOAD_PERCENT_MAX = new System.Windows.Forms.Panel( );
			this.DOWNLOAD_PERCENT = new System.Windows.Forms.Panel( );
			this.VIDEO_VIEWS = new System.Windows.Forms.Label( );
			this.VIDEO_POPULAR = new System.Windows.Forms.Label( );
			this.VIDEO_LENGTH = new System.Windows.Forms.Label( );
			this.VIDEO_RESOLUTION = new System.Windows.Forms.Label( );
			this.VIDEO_IMAGE = new System.Windows.Forms.PictureBox( );
			this.TVPLE_URL_TEXTBOX = new System.Windows.Forms.TextBox( );
			this.GETINFO_BUTTON = new System.Windows.Forms.Button( );
			this.TVPLE_URL_TITLE = new System.Windows.Forms.Label( );
			this.APP_INFO_1 = new System.Windows.Forms.Label( );
			this.BOTTOM_CONTROL_PANEL = new System.Windows.Forms.Panel( );
			this.CONTROL_PANEL = new System.Windows.Forms.Panel( );
			this.CANCEL_DOWNLOAD = new System.Windows.Forms.Button( );
			this.CANCEL_VIDEO = new System.Windows.Forms.Button( );
			this.DOWNLOAD_VIDEO = new System.Windows.Forms.Button( );
			this.APP_INFO_2 = new System.Windows.Forms.Label( );
			this.APP_INFO_0 = new System.Windows.Forms.Label( );
			this.APP_INFO_3 = new System.Windows.Forms.Label( );
			this.TVPLE_LOGO = new System.Windows.Forms.PictureBox( );
			this.APP_TITLE_BAR.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.APP_ICON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.MINIMIZE_BUTTON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).BeginInit( );
			this.VIDEO_INFO_PANEL.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_VIEWS_ICON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_POPULAR_ICON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_LENGTH_ICON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_RESOLUTION_ICON ) ).BeginInit( );
			this.DOWNLOAD_PERCENT_MAX.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_IMAGE ) ).BeginInit( );
			this.BOTTOM_CONTROL_PANEL.SuspendLayout( );
			this.CONTROL_PANEL.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.TVPLE_LOGO ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add( this.APP_ICON );
			this.APP_TITLE_BAR.Controls.Add( this.MINIMIZE_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.CLOSE_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.APP_TITLE );
			this.APP_TITLE_BAR.Location = new System.Drawing.Point( 0, 0 );
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size( 550, 40 );
			this.APP_TITLE_BAR.TabIndex = 22;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler( this.APP_TITLE_BAR_Paint );
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseDown );
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseMove );
			// 
			// APP_ICON
			// 
			this.APP_ICON.BackColor = System.Drawing.Color.Transparent;
			this.APP_ICON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.APP_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.APP_ICON_50x50;
			this.APP_ICON.Location = new System.Drawing.Point( 6, 5 );
			this.APP_ICON.Name = "APP_ICON";
			this.APP_ICON.Size = new System.Drawing.Size( 30, 30 );
			this.APP_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_ICON.TabIndex = 25;
			this.APP_ICON.TabStop = false;
			this.APP_ICON.Click += new System.EventHandler( this.APP_ICON_Click );
			// 
			// MINIMIZE_BUTTON
			// 
			this.MINIMIZE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MINIMIZE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MINIMIZE_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.MINIMIZE_BUTTON;
			this.MINIMIZE_BUTTON.Location = new System.Drawing.Point( 479, 8 );
			this.MINIMIZE_BUTTON.Name = "MINIMIZE_BUTTON";
			this.MINIMIZE_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.MINIMIZE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MINIMIZE_BUTTON.TabIndex = 24;
			this.MINIMIZE_BUTTON.TabStop = false;
			this.MINIMIZE_BUTTON.Click += new System.EventHandler( this.MINIMIZE_BUTTON_Click );
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.CLOSE_BUTTON;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point( 515, 8 );
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
			this.APP_TITLE.Location = new System.Drawing.Point( 42, 10 );
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size( 119, 20 );
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "티비플 다운로더";
			// 
			// TVPLE_WEB_BUTTON
			// 
			this.TVPLE_WEB_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.TVPLE_WEB_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.TVPLE_WEB_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.TVPLE_WEB_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TVPLE_WEB_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.TVPLE_WEB_BUTTON.Location = new System.Drawing.Point( 10, 136 );
			this.TVPLE_WEB_BUTTON.Name = "TVPLE_WEB_BUTTON";
			this.TVPLE_WEB_BUTTON.Size = new System.Drawing.Size( 149, 25 );
			this.TVPLE_WEB_BUTTON.TabIndex = 43;
			this.TVPLE_WEB_BUTTON.Text = "티비플 탐색기";
			this.TVPLE_WEB_BUTTON.UseVisualStyleBackColor = true;
			this.TVPLE_WEB_BUTTON.Click += new System.EventHandler( this.TVPLE_WEB_BUTTON_Click );
			// 
			// VIDEO_NAME
			// 
			this.VIDEO_NAME.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_NAME.Font = new System.Drawing.Font( "맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.VIDEO_NAME.Location = new System.Drawing.Point( 10, 196 );
			this.VIDEO_NAME.Name = "VIDEO_NAME";
			this.VIDEO_NAME.Size = new System.Drawing.Size( 409, 29 );
			this.VIDEO_NAME.TabIndex = 24;
			this.VIDEO_NAME.Text = "영상 이름";
			this.VIDEO_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VIDEO_UPLOADER
			// 
			this.VIDEO_UPLOADER.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_UPLOADER.Font = new System.Drawing.Font( "맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.VIDEO_UPLOADER.Location = new System.Drawing.Point( 10, 228 );
			this.VIDEO_UPLOADER.Name = "VIDEO_UPLOADER";
			this.VIDEO_UPLOADER.Size = new System.Drawing.Size( 320, 20 );
			this.VIDEO_UPLOADER.TabIndex = 25;
			this.VIDEO_UPLOADER.Text = "업로더";
			this.VIDEO_UPLOADER.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VIDEO_UPLOADER_CHANEL
			// 
			this.VIDEO_UPLOADER_CHANEL.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.VIDEO_UPLOADER_CHANEL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.VIDEO_UPLOADER_CHANEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.VIDEO_UPLOADER_CHANEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.VIDEO_UPLOADER_CHANEL.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.VIDEO_UPLOADER_CHANEL.Location = new System.Drawing.Point( 336, 165 );
			this.VIDEO_UPLOADER_CHANEL.Name = "VIDEO_UPLOADER_CHANEL";
			this.VIDEO_UPLOADER_CHANEL.Size = new System.Drawing.Size( 192, 25 );
			this.VIDEO_UPLOADER_CHANEL.TabIndex = 26;
			this.VIDEO_UPLOADER_CHANEL.Text = "업로더 채널 방문";
			this.VIDEO_UPLOADER_CHANEL.UseVisualStyleBackColor = true;
			this.VIDEO_UPLOADER_CHANEL.Click += new System.EventHandler( this.VIDEO_UPLOADER_CHANEL_Click );
			// 
			// VIDEO_INFO_PANEL
			// 
			this.VIDEO_INFO_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_OPEN_URL_BUTTON );
			this.VIDEO_INFO_PANEL.Controls.Add( this.STAR_BUTTON );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_VIEWS_ICON );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_POPULAR_ICON );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_LENGTH_ICON );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_RESOLUTION_ICON );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_DESC );
			this.VIDEO_INFO_PANEL.Controls.Add( this.DOWNLOAD_LABEL );
			this.VIDEO_INFO_PANEL.Controls.Add( this.DOWNLOAD_PERCENT_MAX );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_VIEWS );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_POPULAR );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_LENGTH );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_RESOLUTION );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_IMAGE );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_UPLOADER_CHANEL );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_NAME );
			this.VIDEO_INFO_PANEL.Controls.Add( this.VIDEO_UPLOADER );
			this.VIDEO_INFO_PANEL.Location = new System.Drawing.Point( 0, 40 );
			this.VIDEO_INFO_PANEL.Name = "VIDEO_INFO_PANEL";
			this.VIDEO_INFO_PANEL.Size = new System.Drawing.Size( 550, 366 );
			this.VIDEO_INFO_PANEL.TabIndex = 27;
			this.VIDEO_INFO_PANEL.Visible = false;
			// 
			// VIDEO_OPEN_URL_BUTTON
			// 
			this.VIDEO_OPEN_URL_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.VIDEO_OPEN_URL_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.VIDEO_OPEN_URL_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.VIDEO_OPEN_URL_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.VIDEO_OPEN_URL_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.VIDEO_OPEN_URL_BUTTON.Location = new System.Drawing.Point( 336, 134 );
			this.VIDEO_OPEN_URL_BUTTON.Name = "VIDEO_OPEN_URL_BUTTON";
			this.VIDEO_OPEN_URL_BUTTON.Size = new System.Drawing.Size( 192, 25 );
			this.VIDEO_OPEN_URL_BUTTON.TabIndex = 42;
			this.VIDEO_OPEN_URL_BUTTON.Text = "티비플 영상 열기";
			this.VIDEO_OPEN_URL_BUTTON.UseVisualStyleBackColor = true;
			this.VIDEO_OPEN_URL_BUTTON.Click += new System.EventHandler( this.VIDEO_OPEN_URL_BUTTON_Click );
			// 
			// STAR_BUTTON
			// 
			this.STAR_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.STAR_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.STAR_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.STAR_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.STAR_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.STAR_BUTTON.Location = new System.Drawing.Point( 425, 197 );
			this.STAR_BUTTON.Name = "STAR_BUTTON";
			this.STAR_BUTTON.Size = new System.Drawing.Size( 103, 26 );
			this.STAR_BUTTON.TabIndex = 41;
			this.STAR_BUTTON.Text = "찜 하기 / 취소";
			this.STAR_BUTTON.UseVisualStyleBackColor = true;
			this.STAR_BUTTON.Click += new System.EventHandler( this.STAR_BUTTON_Click );
			// 
			// VIDEO_VIEWS_ICON
			// 
			this.VIDEO_VIEWS_ICON.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_VIEWS_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.VIDEO_VIEWS;
			this.VIDEO_VIEWS_ICON.Location = new System.Drawing.Point( 336, 104 );
			this.VIDEO_VIEWS_ICON.Name = "VIDEO_VIEWS_ICON";
			this.VIDEO_VIEWS_ICON.Size = new System.Drawing.Size( 25, 25 );
			this.VIDEO_VIEWS_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VIDEO_VIEWS_ICON.TabIndex = 40;
			this.VIDEO_VIEWS_ICON.TabStop = false;
			// 
			// VIDEO_POPULAR_ICON
			// 
			this.VIDEO_POPULAR_ICON.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_POPULAR_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.VIDEO_POPULAR;
			this.VIDEO_POPULAR_ICON.Location = new System.Drawing.Point( 336, 73 );
			this.VIDEO_POPULAR_ICON.Name = "VIDEO_POPULAR_ICON";
			this.VIDEO_POPULAR_ICON.Size = new System.Drawing.Size( 25, 25 );
			this.VIDEO_POPULAR_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VIDEO_POPULAR_ICON.TabIndex = 39;
			this.VIDEO_POPULAR_ICON.TabStop = false;
			// 
			// VIDEO_LENGTH_ICON
			// 
			this.VIDEO_LENGTH_ICON.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_LENGTH_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.VIDEO_TIME;
			this.VIDEO_LENGTH_ICON.Location = new System.Drawing.Point( 336, 41 );
			this.VIDEO_LENGTH_ICON.Name = "VIDEO_LENGTH_ICON";
			this.VIDEO_LENGTH_ICON.Size = new System.Drawing.Size( 25, 25 );
			this.VIDEO_LENGTH_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VIDEO_LENGTH_ICON.TabIndex = 38;
			this.VIDEO_LENGTH_ICON.TabStop = false;
			// 
			// VIDEO_RESOLUTION_ICON
			// 
			this.VIDEO_RESOLUTION_ICON.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_RESOLUTION_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.VIDEO_RESOLUTION;
			this.VIDEO_RESOLUTION_ICON.Location = new System.Drawing.Point( 336, 10 );
			this.VIDEO_RESOLUTION_ICON.Name = "VIDEO_RESOLUTION_ICON";
			this.VIDEO_RESOLUTION_ICON.Size = new System.Drawing.Size( 25, 25 );
			this.VIDEO_RESOLUTION_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VIDEO_RESOLUTION_ICON.TabIndex = 37;
			this.VIDEO_RESOLUTION_ICON.TabStop = false;
			// 
			// VIDEO_DESC
			// 
			this.VIDEO_DESC.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_DESC.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.VIDEO_DESC.Location = new System.Drawing.Point( 10, 260 );
			this.VIDEO_DESC.Name = "VIDEO_DESC";
			this.VIDEO_DESC.Size = new System.Drawing.Size( 520, 72 );
			this.VIDEO_DESC.TabIndex = 36;
			this.VIDEO_DESC.Text = "영상 설명";
			// 
			// DOWNLOAD_LABEL
			// 
			this.DOWNLOAD_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.DOWNLOAD_LABEL.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.DOWNLOAD_LABEL.Location = new System.Drawing.Point( 386, 345 );
			this.DOWNLOAD_LABEL.Name = "DOWNLOAD_LABEL";
			this.DOWNLOAD_LABEL.Size = new System.Drawing.Size( 160, 15 );
			this.DOWNLOAD_LABEL.TabIndex = 35;
			this.DOWNLOAD_LABEL.Text = "다운로드 준비";
			this.DOWNLOAD_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DOWNLOAD_PERCENT_MAX
			// 
			this.DOWNLOAD_PERCENT_MAX.BackColor = System.Drawing.Color.WhiteSmoke;
			this.DOWNLOAD_PERCENT_MAX.Controls.Add( this.DOWNLOAD_PERCENT );
			this.DOWNLOAD_PERCENT_MAX.Location = new System.Drawing.Point( 10, 345 );
			this.DOWNLOAD_PERCENT_MAX.Name = "DOWNLOAD_PERCENT_MAX";
			this.DOWNLOAD_PERCENT_MAX.Size = new System.Drawing.Size( 370, 15 );
			this.DOWNLOAD_PERCENT_MAX.TabIndex = 31;
			// 
			// DOWNLOAD_PERCENT
			// 
			this.DOWNLOAD_PERCENT.BackColor = System.Drawing.Color.LightGray;
			this.DOWNLOAD_PERCENT.Location = new System.Drawing.Point( 0, 0 );
			this.DOWNLOAD_PERCENT.Name = "DOWNLOAD_PERCENT";
			this.DOWNLOAD_PERCENT.Size = new System.Drawing.Size( 0, 15 );
			this.DOWNLOAD_PERCENT.TabIndex = 32;
			// 
			// VIDEO_VIEWS
			// 
			this.VIDEO_VIEWS.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_VIEWS.Font = new System.Drawing.Font( "맑은 고딕", 9.75F );
			this.VIDEO_VIEWS.Location = new System.Drawing.Point( 367, 106 );
			this.VIDEO_VIEWS.Name = "VIDEO_VIEWS";
			this.VIDEO_VIEWS.Size = new System.Drawing.Size( 170, 20 );
			this.VIDEO_VIEWS.TabIndex = 30;
			this.VIDEO_VIEWS.Text = "영상 조회수";
			this.VIDEO_VIEWS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VIDEO_POPULAR
			// 
			this.VIDEO_POPULAR.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_POPULAR.Font = new System.Drawing.Font( "맑은 고딕", 9.75F );
			this.VIDEO_POPULAR.Location = new System.Drawing.Point( 367, 75 );
			this.VIDEO_POPULAR.Name = "VIDEO_POPULAR";
			this.VIDEO_POPULAR.Size = new System.Drawing.Size( 170, 20 );
			this.VIDEO_POPULAR.TabIndex = 29;
			this.VIDEO_POPULAR.Text = "영상 인기도";
			this.VIDEO_POPULAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VIDEO_LENGTH
			// 
			this.VIDEO_LENGTH.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_LENGTH.Font = new System.Drawing.Font( "맑은 고딕", 9.75F );
			this.VIDEO_LENGTH.Location = new System.Drawing.Point( 367, 43 );
			this.VIDEO_LENGTH.Name = "VIDEO_LENGTH";
			this.VIDEO_LENGTH.Size = new System.Drawing.Size( 170, 20 );
			this.VIDEO_LENGTH.TabIndex = 28;
			this.VIDEO_LENGTH.Text = "영상 길이";
			this.VIDEO_LENGTH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VIDEO_RESOLUTION
			// 
			this.VIDEO_RESOLUTION.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_RESOLUTION.Font = new System.Drawing.Font( "맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.VIDEO_RESOLUTION.Location = new System.Drawing.Point( 367, 12 );
			this.VIDEO_RESOLUTION.Name = "VIDEO_RESOLUTION";
			this.VIDEO_RESOLUTION.Size = new System.Drawing.Size( 170, 20 );
			this.VIDEO_RESOLUTION.TabIndex = 27;
			this.VIDEO_RESOLUTION.Text = "영상 해상도";
			this.VIDEO_RESOLUTION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// VIDEO_IMAGE
			// 
			this.VIDEO_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.VIDEO_IMAGE.Image = global::TvpleDownloader_v2.Properties.Resources.VIDEO_IMAGE_DEFAULT;
			this.VIDEO_IMAGE.Location = new System.Drawing.Point( 10, 10 );
			this.VIDEO_IMAGE.Name = "VIDEO_IMAGE";
			this.VIDEO_IMAGE.Size = new System.Drawing.Size( 320, 180 );
			this.VIDEO_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VIDEO_IMAGE.TabIndex = 23;
			this.VIDEO_IMAGE.TabStop = false;
			this.VIDEO_IMAGE.Paint += new System.Windows.Forms.PaintEventHandler( this.VIDEO_IMAGE_Paint );
			// 
			// TVPLE_URL_TEXTBOX
			// 
			this.TVPLE_URL_TEXTBOX.BackColor = System.Drawing.Color.White;
			this.TVPLE_URL_TEXTBOX.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.TVPLE_URL_TEXTBOX.Location = new System.Drawing.Point( 111, 8 );
			this.TVPLE_URL_TEXTBOX.Name = "TVPLE_URL_TEXTBOX";
			this.TVPLE_URL_TEXTBOX.Size = new System.Drawing.Size( 270, 23 );
			this.TVPLE_URL_TEXTBOX.TabIndex = 28;
			// 
			// GETINFO_BUTTON
			// 
			this.GETINFO_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.GETINFO_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.GETINFO_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.GETINFO_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GETINFO_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.GETINFO_BUTTON.Location = new System.Drawing.Point( 389, 8 );
			this.GETINFO_BUTTON.Name = "GETINFO_BUTTON";
			this.GETINFO_BUTTON.Size = new System.Drawing.Size( 151, 23 );
			this.GETINFO_BUTTON.TabIndex = 29;
			this.GETINFO_BUTTON.Text = "티비플 영상 가져오기";
			this.GETINFO_BUTTON.UseVisualStyleBackColor = true;
			this.GETINFO_BUTTON.Click += new System.EventHandler( this.GETINFO_BUTTON_Click );
			// 
			// TVPLE_URL_TITLE
			// 
			this.TVPLE_URL_TITLE.AutoSize = true;
			this.TVPLE_URL_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.TVPLE_URL_TITLE.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.TVPLE_URL_TITLE.Location = new System.Drawing.Point( 11, 13 );
			this.TVPLE_URL_TITLE.Name = "TVPLE_URL_TITLE";
			this.TVPLE_URL_TITLE.Size = new System.Drawing.Size( 92, 13 );
			this.TVPLE_URL_TITLE.TabIndex = 32;
			this.TVPLE_URL_TITLE.Text = "티비플 영상 주소";
			// 
			// APP_INFO_1
			// 
			this.APP_INFO_1.AutoSize = true;
			this.APP_INFO_1.BackColor = System.Drawing.Color.Transparent;
			this.APP_INFO_1.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_INFO_1.Location = new System.Drawing.Point( 7, 75 );
			this.APP_INFO_1.Name = "APP_INFO_1";
			this.APP_INFO_1.Size = new System.Drawing.Size( 179, 15 );
			this.APP_INFO_1.TabIndex = 34;
			this.APP_INFO_1.Text = "티비플 영상 주소를 입력하세요!";
			// 
			// BOTTOM_CONTROL_PANEL
			// 
			this.BOTTOM_CONTROL_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.BOTTOM_CONTROL_PANEL.Controls.Add( this.TVPLE_URL_TITLE );
			this.BOTTOM_CONTROL_PANEL.Controls.Add( this.TVPLE_URL_TEXTBOX );
			this.BOTTOM_CONTROL_PANEL.Controls.Add( this.GETINFO_BUTTON );
			this.BOTTOM_CONTROL_PANEL.Location = new System.Drawing.Point( 0, 194 );
			this.BOTTOM_CONTROL_PANEL.Name = "BOTTOM_CONTROL_PANEL";
			this.BOTTOM_CONTROL_PANEL.Size = new System.Drawing.Size( 550, 38 );
			this.BOTTOM_CONTROL_PANEL.TabIndex = 35;
			// 
			// CONTROL_PANEL
			// 
			this.CONTROL_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.CONTROL_PANEL.Controls.Add( this.CANCEL_DOWNLOAD );
			this.CONTROL_PANEL.Controls.Add( this.CANCEL_VIDEO );
			this.CONTROL_PANEL.Controls.Add( this.DOWNLOAD_VIDEO );
			this.CONTROL_PANEL.Location = new System.Drawing.Point( 0, 405 );
			this.CONTROL_PANEL.Name = "CONTROL_PANEL";
			this.CONTROL_PANEL.Size = new System.Drawing.Size( 550, 38 );
			this.CONTROL_PANEL.TabIndex = 36;
			// 
			// CANCEL_DOWNLOAD
			// 
			this.CANCEL_DOWNLOAD.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CANCEL_DOWNLOAD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.CANCEL_DOWNLOAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.CANCEL_DOWNLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CANCEL_DOWNLOAD.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.CANCEL_DOWNLOAD.ForeColor = System.Drawing.Color.Black;
			this.CANCEL_DOWNLOAD.Location = new System.Drawing.Point( 10, 7 );
			this.CANCEL_DOWNLOAD.Name = "CANCEL_DOWNLOAD";
			this.CANCEL_DOWNLOAD.Size = new System.Drawing.Size( 530, 26 );
			this.CANCEL_DOWNLOAD.TabIndex = 37;
			this.CANCEL_DOWNLOAD.Text = "다운로드 취소";
			this.CANCEL_DOWNLOAD.UseVisualStyleBackColor = true;
			this.CANCEL_DOWNLOAD.Visible = false;
			this.CANCEL_DOWNLOAD.Click += new System.EventHandler( this.CANCEL_DOWNLOAD_Click );
			// 
			// CANCEL_VIDEO
			// 
			this.CANCEL_VIDEO.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CANCEL_VIDEO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.CANCEL_VIDEO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.CANCEL_VIDEO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CANCEL_VIDEO.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.CANCEL_VIDEO.Location = new System.Drawing.Point( 348, 7 );
			this.CANCEL_VIDEO.Name = "CANCEL_VIDEO";
			this.CANCEL_VIDEO.Size = new System.Drawing.Size( 192, 26 );
			this.CANCEL_VIDEO.TabIndex = 28;
			this.CANCEL_VIDEO.Text = "이 영상이 아닙니다";
			this.CANCEL_VIDEO.UseVisualStyleBackColor = true;
			this.CANCEL_VIDEO.Click += new System.EventHandler( this.CANCEL_VIDEO_Click );
			// 
			// DOWNLOAD_VIDEO
			// 
			this.DOWNLOAD_VIDEO.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.DOWNLOAD_VIDEO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.DOWNLOAD_VIDEO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.DOWNLOAD_VIDEO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DOWNLOAD_VIDEO.Font = new System.Drawing.Font( "맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.DOWNLOAD_VIDEO.Location = new System.Drawing.Point( 10, 7 );
			this.DOWNLOAD_VIDEO.Name = "DOWNLOAD_VIDEO";
			this.DOWNLOAD_VIDEO.Size = new System.Drawing.Size( 332, 26 );
			this.DOWNLOAD_VIDEO.TabIndex = 27;
			this.DOWNLOAD_VIDEO.Text = "이 영상 다운로드";
			this.DOWNLOAD_VIDEO.UseVisualStyleBackColor = true;
			this.DOWNLOAD_VIDEO.Click += new System.EventHandler( this.DOWNLOAD_VIDEO_Click );
			// 
			// APP_INFO_2
			// 
			this.APP_INFO_2.AutoSize = true;
			this.APP_INFO_2.BackColor = System.Drawing.Color.Transparent;
			this.APP_INFO_2.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_INFO_2.Location = new System.Drawing.Point( 7, 96 );
			this.APP_INFO_2.Name = "APP_INFO_2";
			this.APP_INFO_2.Size = new System.Drawing.Size( 159, 13 );
			this.APP_INFO_2.TabIndex = 37;
			this.APP_INFO_2.Text = "형식 : http://tvple.com/123456";
			// 
			// APP_INFO_0
			// 
			this.APP_INFO_0.AutoSize = true;
			this.APP_INFO_0.BackColor = System.Drawing.Color.Transparent;
			this.APP_INFO_0.Font = new System.Drawing.Font( "맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_INFO_0.Location = new System.Drawing.Point( 7, 49 );
			this.APP_INFO_0.Name = "APP_INFO_0";
			this.APP_INFO_0.Size = new System.Drawing.Size( 319, 17 );
			this.APP_INFO_0.TabIndex = 39;
			this.APP_INFO_0.Text = "티비플에 업로드 된 영상을 다운로드 할 수 있습니다.";
			// 
			// APP_INFO_3
			// 
			this.APP_INFO_3.AutoSize = true;
			this.APP_INFO_3.BackColor = System.Drawing.Color.Transparent;
			this.APP_INFO_3.Font = new System.Drawing.Font( "맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_INFO_3.Location = new System.Drawing.Point( 7, 115 );
			this.APP_INFO_3.Name = "APP_INFO_3";
			this.APP_INFO_3.Size = new System.Drawing.Size( 179, 15 );
			this.APP_INFO_3.TabIndex = 44;
			this.APP_INFO_3.Text = "또는 티비플 영상을 탐색하세요!";
			// 
			// TVPLE_LOGO
			// 
			this.TVPLE_LOGO.BackColor = System.Drawing.Color.Transparent;
			this.TVPLE_LOGO.Image = global::TvpleDownloader_v2.Properties.Resources.TVPLE_LOGO_FULL;
			this.TVPLE_LOGO.Location = new System.Drawing.Point( 260, 46 );
			this.TVPLE_LOGO.Name = "TVPLE_LOGO";
			this.TVPLE_LOGO.Size = new System.Drawing.Size( 280, 145 );
			this.TVPLE_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TVPLE_LOGO.TabIndex = 38;
			this.TVPLE_LOGO.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size( 550, 235 );
			this.Controls.Add( this.APP_INFO_3 );
			this.Controls.Add( this.APP_INFO_0 );
			this.Controls.Add( this.TVPLE_LOGO );
			this.Controls.Add( this.TVPLE_WEB_BUTTON );
			this.Controls.Add( this.APP_INFO_2 );
			this.Controls.Add( this.CONTROL_PANEL );
			this.Controls.Add( this.APP_TITLE_BAR );
			this.Controls.Add( this.BOTTOM_CONTROL_PANEL );
			this.Controls.Add( this.APP_INFO_1 );
			this.Controls.Add( this.VIDEO_INFO_PANEL );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
			this.Name = "Main";
			this.Text = "티비플 다운로더";
			this.Activated += new System.EventHandler( this.Main_Activated );
			this.Load += new System.EventHandler( this.Main_Load );
			this.APP_TITLE_BAR.ResumeLayout( false );
			this.APP_TITLE_BAR.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.APP_ICON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.MINIMIZE_BUTTON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).EndInit( );
			this.VIDEO_INFO_PANEL.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_VIEWS_ICON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_POPULAR_ICON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_LENGTH_ICON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_RESOLUTION_ICON ) ).EndInit( );
			this.DOWNLOAD_PERCENT_MAX.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.VIDEO_IMAGE ) ).EndInit( );
			this.BOTTOM_CONTROL_PANEL.ResumeLayout( false );
			this.BOTTOM_CONTROL_PANEL.PerformLayout( );
			this.CONTROL_PANEL.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize ) ( this.TVPLE_LOGO ) ).EndInit( );
			this.ResumeLayout( false );
			this.PerformLayout( );

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox MINIMIZE_BUTTON;
		private System.Windows.Forms.PictureBox APP_ICON;
		private System.Windows.Forms.PictureBox VIDEO_IMAGE;
		private System.Windows.Forms.Label VIDEO_NAME;
		private System.Windows.Forms.Label VIDEO_UPLOADER;
		private System.Windows.Forms.Button VIDEO_UPLOADER_CHANEL;
		private System.Windows.Forms.Panel VIDEO_INFO_PANEL;
		private System.Windows.Forms.Label VIDEO_RESOLUTION;
		private System.Windows.Forms.Label VIDEO_LENGTH;
		public System.Windows.Forms.TextBox TVPLE_URL_TEXTBOX;
		private System.Windows.Forms.Button GETINFO_BUTTON;
		private System.Windows.Forms.Label VIDEO_POPULAR;
		private System.Windows.Forms.Label VIDEO_VIEWS;
		private System.Windows.Forms.Label TVPLE_URL_TITLE;
		private System.Windows.Forms.Label APP_INFO_1;
		private System.Windows.Forms.Panel BOTTOM_CONTROL_PANEL;
		private System.Windows.Forms.Panel CONTROL_PANEL;
		private System.Windows.Forms.Button DOWNLOAD_VIDEO;
		private System.Windows.Forms.Button CANCEL_VIDEO;
		private System.Windows.Forms.Panel DOWNLOAD_PERCENT_MAX;
		public System.Windows.Forms.Panel DOWNLOAD_PERCENT;
		public System.Windows.Forms.Label DOWNLOAD_LABEL;
		public System.Windows.Forms.Button CANCEL_DOWNLOAD;
		private System.Windows.Forms.Label VIDEO_DESC;
		private System.Windows.Forms.Label APP_INFO_2;
		private System.Windows.Forms.PictureBox TVPLE_LOGO;
		private System.Windows.Forms.Label APP_INFO_0;
		private System.Windows.Forms.PictureBox VIDEO_RESOLUTION_ICON;
		private System.Windows.Forms.PictureBox VIDEO_LENGTH_ICON;
		private System.Windows.Forms.PictureBox VIDEO_POPULAR_ICON;
		private System.Windows.Forms.PictureBox VIDEO_VIEWS_ICON;
		private System.Windows.Forms.Button STAR_BUTTON;
		private System.Windows.Forms.Button VIDEO_OPEN_URL_BUTTON;
		private System.Windows.Forms.Button TVPLE_WEB_BUTTON;
		private System.Windows.Forms.Label APP_INFO_3;
	}
}


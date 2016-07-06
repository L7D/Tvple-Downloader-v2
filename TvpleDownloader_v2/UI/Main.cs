/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	public partial class Main : Form
	{
		private const string VERSION_CHECK_URL = "http://textuploader.com/5ik2x/raw";
		private const string UPDATE_LOG_URL = "http://textuploader.com/5ikvf/raw";
		private Point startPoint;
		private Pen linePen = new Pen( Color.Silver );
		private Tvple TVPLE;
		private string uploaderURL = "";
		private string directDownloadURL = "";
		private string videoName = "";

		public Main( )
		{
			InitializeComponent( );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			// 아웃라인 그리기
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( linePen, 0, 0, w, 0 ); // 맨 위
			e.Graphics.DrawLine( linePen, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( linePen, w - linePen.Width, 0, w - linePen.Width, h ); // 오른쪽
			e.Graphics.DrawLine( linePen, 0, h - linePen.Width, w, h - linePen.Width ); // 맨 아래
		}

		private void Main_Load( object sender, EventArgs e )
		{
			TVPLE = new Tvple( this );
			linePen.Width = 1;

			VIDEO_UPLOADER_CHANEL.FlatAppearance.BorderColor = Color.Silver;
			this.BOTTOM_CONTROL_PANEL.Visible = true;
			this.CONTROL_PANEL.Visible = false;
		}

		private void UpdateCheck( )
		{
			try
			{
				WebRequest request = WebRequest.Create( VERSION_CHECK_URL );
				request.Method = "GET";

				using ( WebResponse webResponse = request.GetResponse( ) )
				{
					using ( StreamReader streamReader = new StreamReader( webResponse.GetResponseStream( ) ) )
					{
						string newVersion = "2.0.0.0";
						string[ ] information = streamReader.ReadToEnd( ).Split( '\n' );

						if ( information.Length == 2 )
						{
							newVersion = information[ 0 ].Replace( "\r", "" );
						}

						System.Reflection.Assembly assemObject = System.Reflection.Assembly.GetExecutingAssembly( );
						Version version = assemObject.GetName( ).Version;
						string currentVer = version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;

						if ( !newVersion.Equals( currentVer ) )
						{
							try
							{
								WebRequest request2 = WebRequest.Create( UPDATE_LOG_URL );
								request2.Method = "GET";

								using ( WebResponse webResponse2 = request2.GetResponse( ) )
								{
									using ( StreamReader streamReader2 = new StreamReader( webResponse2.GetResponseStream( ) ) )
									{
										Update Form = new Update( newVersion, streamReader2.ReadToEnd( ) );
										Form.ShowDialog( );
									}
								}
							}
							catch ( Exception ex )
							{
								Update Form = new Update( newVersion, "업데이트 내역을 가져올 수 없습니다.\n\n[ 예외 : " + ex.Message + " ]" );
								Form.ShowDialog( );
							}
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response != null )
				{
					HttpStatusCode code = ( ( HttpWebResponse ) ex.Response ).StatusCode;

					if ( code == HttpStatusCode.NotFound )
						MessageBox.Show( this, "티비플 다운로더의 업데이트를 확인할 수 없습니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
					else
						MessageBox.Show( this, "티비플 다운로더의 업데이트를 확인할 수 없습니다.\n\n[ 오류 코드 : " + code.ToString( ) + " ]", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			}
			catch ( Exception ex )
			{
				MessageBox.Show( this, "티비플 다운로더의 업데이트를 확인할 수 없습니다.\n\n[ 예외 : " + ex.Message + " ]", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		bool isFirst = true;
		private void Main_Activated( object sender, EventArgs e )
		{
			if ( isFirst )
			{
				Thread thread = new Thread( new ThreadStart( UpdateCheck ) );
				thread.IsBackground = true;
				thread.Start( );
				isFirst = false;
			}
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( ( e.Button & MouseButtons.Left ) == MouseButtons.Left )
			{
				Rectangle ang = Screen.FromHandle( this.Handle ).WorkingArea; // ANG?
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), ang.Top )
				);
			}
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			startPoint = e.Location;
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			e.Graphics.DrawLine( linePen, 0, this.APP_TITLE_BAR.Height - linePen.Width, this.APP_TITLE_BAR.Width, this.APP_TITLE_BAR.Height - linePen.Width ); // 맨 아래
		}

		private void VIDEO_IMAGE_Paint( object sender, PaintEventArgs e )
		{
			// 비디오 썸네일 아웃라인 그리기
			int w = this.VIDEO_IMAGE.Width, h = this.VIDEO_IMAGE.Height;

			e.Graphics.DrawLine( linePen, 0, 0, w, 0 ); // 맨 위
			e.Graphics.DrawLine( linePen, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( linePen, w - linePen.Width, 0, w - linePen.Width, h ); // 오른쪽
			e.Graphics.DrawLine( linePen, 0, h - linePen.Width, w, h - linePen.Width ); // 맨 아래
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void MINIMIZE_BUTTON_Click( object sender, EventArgs e )
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void APP_ICON_Click( object sender, EventArgs e )
		{
			Info Form = new Info( );
			Form.ShowDialog( );
		}

		private void ToLargeMode( ) // 다운로드 모드
		{
			this.Size = new Size( 550, 450 );

			this.BOTTOM_CONTROL_PANEL.Visible = false;
			this.APP_INFO_0.Visible = false;
			this.APP_INFO_1.Visible = false;
			this.APP_INFO_2.Visible = false;
			this.APP_INFO_3.Visible = false;
			this.TVPLE_LOGO.Visible = false;
			this.TVPLE_WEB_BUTTON.Visible = false;
			this.CONTROL_PANEL.Visible = true;

			this.Refresh( );
		}

		private void ToNormalMode( ) // 일반 모드
		{
			this.Size = new Size( 550, 235 );

			this.BOTTOM_CONTROL_PANEL.Visible = true;
			this.APP_INFO_0.Visible = true;
			this.APP_INFO_1.Visible = true;
			this.APP_INFO_2.Visible = true;
			this.APP_INFO_3.Visible = true;
			this.TVPLE_LOGO.Visible = true;
			this.TVPLE_WEB_BUTTON.Visible = true;
			this.CONTROL_PANEL.Visible = false;

			this.Refresh( );
		}

		public void GETINFO_BUTTON_Click( object sender, EventArgs e )
		{
			if ( !TVPLE.IsTvpleURL( this.TVPLE_URL_TEXTBOX.Text ) )
			{
				this.GETINFO_BUTTON.Text = "티비플 영상 가져오기";
				MessageBox.Show( this, "티비플 영상 주소를 올바르게 입력하세요!\n티비플 영상 주소는 http://tvple.com/123456 와 같은 형식이어야 합니다!", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}

			this.GETINFO_BUTTON.Text = "서버에 요청 하는 중 ...";

			string[ ] videoInformation = TVPLE.GetInformation( this.TVPLE_URL_TEXTBOX.Text );

			if ( videoInformation[ 0 ] == "#TVPLE_UNKNOWN_VIDEO" )
			{
				this.GETINFO_BUTTON.Text = "티비플 영상 가져오기";
				MessageBox.Show( this, "해당 티비플 영상이 존재하지 않거나, 업로더에 의해 삭제되었거나, 티비플 운영 정책 위반으로 삭제된 영상입니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				return;
			}
			else if ( videoInformation[ 0 ] == "#ERROR_INTERNET" )
			{
				this.GETINFO_BUTTON.Text = "티비플 영상 가져오기";
				MessageBox.Show( this, "티비플 서버에 연결할 수 없습니다, 귀하의 인터넷 연결을 확인하십시오.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}
			else if ( videoInformation.Length != 10 )
			{
				this.GETINFO_BUTTON.Text = "티비플 영상 가져오기";
				MessageBox.Show( this, "알 수 없는 오류가 발생했습니다.\n\n[ 오류 코드 : " + videoInformation[ 0 ] + " ]", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			this.VIDEO_INFO_PANEL.Visible = true;
			ToLargeMode( );

			try
			{
				TimeSpan timeSpan = TimeSpan.FromSeconds( double.Parse( videoInformation[ 9 ] ) );

				this.VIDEO_NAME.Text = videoInformation[ 1 ];
				this.VIDEO_DESC.Text = videoInformation[ 2 ];
				this.VIDEO_UPLOADER.Text = videoInformation[ 4 ];
				this.VIDEO_POPULAR.Text = videoInformation[ 6 ];
				this.VIDEO_VIEWS.Text = videoInformation[ 7 ];
				this.VIDEO_RESOLUTION.Text = videoInformation[ 8 ];
				this.VIDEO_LENGTH.Text = timeSpan.Minutes + "분 " + timeSpan.Seconds + "초";

				uploaderURL = videoInformation[ 5 ];
				directDownloadURL = videoInformation[ 0 ];
				videoName = videoInformation[ 1 ];

				Stream stream = new MemoryStream( );

				using ( WebClient webClient = new WebClient( ) )
				{
					byte[ ] buffer = webClient.DownloadData( videoInformation[ 3 ] );

					stream.Write( buffer, 0, buffer.Length );

					this.VIDEO_IMAGE.Image = Image.FromStream( stream, true );
				}
			}
			catch ( IndexOutOfRangeException )
			{
				MessageBox.Show( this, "데이터 인덱스 관련 오류가 발생했습니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			catch ( ArgumentException )
			{
				MessageBox.Show( this, "이미지 스트림 관련 오류가 발생했습니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( this, "알 수 없는 오류가 발생했습니다.\n\n[ 예외 : " + ex.Message + " ]", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}

			this.GETINFO_BUTTON.Text = "티비플 영상 가져오기";
		}

		private void VIDEO_UPLOADER_CHANEL_Click( object sender, EventArgs e )
		{
			if ( uploaderURL != "" )
			{
				System.Diagnostics.Process.Start( "http://tvple.com" + uploaderURL );
			}
		}

		private void DOWNLOAD_VIDEO_Click( object sender, EventArgs e )
		{
			if ( videoName == "" ) return;

			DialogResult result = MessageBox.Show( this, "영상을 다운로드 하기 전에 ...\n\n이 영상을 다운로드함으로 써 발생하는 영상 관련 저작권 문제는 본 프로그램 개발자가 책임지지 않습니다.", "티비플 다운로더", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

			if ( result == DialogResult.Yes )
			{
				SaveFileDialog savePanel = new SaveFileDialog( );
				savePanel.Title = "어느 경로에 영상을 다운로드 받으시겠습니까?";
				savePanel.Filter = "MP4 영상 파일 (*.mp4)|";
				savePanel.FileName = TVPLE.CanUseFileNameString( videoName ) ? videoName : "영상";
				savePanel.DefaultExt = "mp4";

				if ( savePanel.ShowDialog( ) == DialogResult.OK )
				{
					if ( directDownloadURL != "" )
					{
						TVPLE.DownloadVideo( directDownloadURL, savePanel.FileName );

						this.CANCEL_DOWNLOAD.Visible = true;
						this.CANCEL_VIDEO.Visible = false;
						this.DOWNLOAD_VIDEO.Visible = false;
					}
				}
			}
		}

		public void CANCEL_VIDEO_Click( object sender, EventArgs e )
		{
			uploaderURL = "";
			videoName = "";
			directDownloadURL = "";

			ToNormalMode( );

			this.VIDEO_INFO_PANEL.Visible = false;
			this.TVPLE_URL_TEXTBOX.Text = "";
			this.CANCEL_DOWNLOAD.Visible = false;
			this.CANCEL_VIDEO.Visible = true;
			this.DOWNLOAD_VIDEO.Visible = true;
			this.DOWNLOAD_PERCENT.Size = new Size( 0, 15 );
			this.DOWNLOAD_LABEL.Text = "다운로드 준비";
		}

		private void CANCEL_DOWNLOAD_Click( object sender, EventArgs e )
		{
			DialogResult result = MessageBox.Show( this, "영상 다운로드를 취소하시겠습니까?", "티비플 다운로더", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

			if ( result == DialogResult.Yes )
			{
				CANCEL_VIDEO_Click( null, null );
				TVPLE.CancelVideo( );
			}
		}

		private void STAR_BUTTON_Click( object sender, EventArgs e )
		{
			System.Diagnostics.Process.Start( this.TVPLE_URL_TEXTBOX.Text + "/favorite" );
		}

		private void VIDEO_OPEN_URL_BUTTON_Click( object sender, EventArgs e )
		{
			System.Diagnostics.Process.Start( this.TVPLE_URL_TEXTBOX.Text );
		}

		private void TVPLE_WEB_BUTTON_Click( object sender, EventArgs e )
		{
			TvpleWeb Form = new TvpleWeb( this );
			Form.Show( );
		}
	}
}

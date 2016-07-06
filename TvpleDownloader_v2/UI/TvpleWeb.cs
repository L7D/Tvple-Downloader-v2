/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	public partial class TvpleWeb : Form
	{
		private Point startPoint;
		private Pen linePen = new Pen( Color.Silver );
		private const int cCaption = 32;
		private const int cGrip = 16;
		private Main MainForm;
		private Tvple TVPLE;

		public TvpleWeb( Main MainForm )
		{
			InitializeComponent( );

			this.MainForm = MainForm;
			this.TVPLE = new Tvple( MainForm );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( linePen, 0, 0, w, 0 ); // 맨 위
			e.Graphics.DrawLine( linePen, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( linePen, w - linePen.Width, 0, w - linePen.Width, h ); // 오른쪽
			e.Graphics.DrawLine( linePen, 0, h - linePen.Width, w, h - linePen.Width ); // 맨 아래

			Rectangle rc = new Rectangle( this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip );
			ControlPaint.DrawSizeGrip( e.Graphics, Color.Silver, rc );
		}

		protected override void WndProc( ref Message m )
		{
			if ( m.Msg == 0x84 )
			{  // Trap WM_NCHITTEST
				Point pos = new Point( m.LParam.ToInt32( ) & 0xffff, m.LParam.ToInt32( ) >> 16 );
				pos = this.PointToClient( pos );
				if ( pos.Y < cCaption )
				{
					m.Result = ( IntPtr ) 2;  // HTCAPTION
					return;
				}
				if ( pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip )
				{
					m.Result = ( IntPtr ) 17; // HTBOTTOMRIGHT
					return;
				}
			}

			base.WndProc( ref m );
		}

		private void webBrowser_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
		{
			this.TVPLE_URL.Text = webBrowser.Document.Url.OriginalString;
			this.WEB_NAME.Text = webBrowser.Document.Title;

			if ( TVPLE.IsTvpleURL( webBrowser.Document.Url.OriginalString ) )
			{
				this.DOWNLOAD_NOW_BUTTON.Visible = true;
				this.DOWNLOAD_NOW_BUTTON.Enabled = true;
			}
			else
			{
				this.DOWNLOAD_NOW_BUTTON.Visible = false;
				this.DOWNLOAD_NOW_BUTTON.Enabled = false;
			}

			if ( webBrowser.CanGoBack )
				this.PREVIOUS_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.PREVIOUS_BUTTON;
			else
				this.PREVIOUS_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.PREVIOUS_BUTTON_NONE;


			if ( webBrowser.CanGoForward )
				this.NEXT_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.NEXT_BUTTON;
			else
				this.NEXT_BUTTON.Image = global::TvpleDownloader_v2.Properties.Resources.NEXT_BUTTON_NONE;
			/*
			if ( !isFirst ) return;

			HtmlElementCollection elements = webBrowser.Document.GetElementsByTagName( "div" );

			foreach ( HtmlElement i in elements )
			{
				HtmlElementCollection el2 = i.Document.GetElementsByTagName( "input" );
				HtmlElementCollection el3 = i.Document.GetElementsByTagName( "button" );

				foreach ( HtmlElement i2 in el2 )
				{
					if ( i2.Id == "id" )
						i2.SetAttribute( "value", "smhjyh2009@gmail.com" );

					if ( i2.Id == "password" )
						i2.SetAttribute( "value", "" );
				}

				foreach ( HtmlElement i2 in el3 )
				{
					if ( i2.InnerHtml.Contains( "로그인" ) )
					{
						i2.InvokeMember( "click" );
					}
				}
			}

			isFirst = false;
			*/
		}

		// http://ksyjkh24.tistory.com/114 (다른 소스 참고) <- 이것도 좋음
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

		private void APP_TITLE_BAR_MouseDoubleClick( object sender, MouseEventArgs e )
		{
			if ( this.WindowState == FormWindowState.Maximized )
				this.WindowState = FormWindowState.Normal;
			else
			{
				// http://oneday0012.tistory.com/45
				this.MaximizedBounds = Screen.FromHandle( this.Handle ).WorkingArea;
				this.WindowState = FormWindowState.Maximized;
			}
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			e.Graphics.DrawLine( linePen, 0, this.APP_TITLE_BAR.Height - linePen.Width, this.APP_TITLE_BAR.Width, this.APP_TITLE_BAR.Height - linePen.Width ); // 맨 아래
		}

		private void APP_TITLE_BAR_SizeChanged( object sender, EventArgs e )
		{
			this.CLOSE_BUTTON.Location = new Point( this.Size.Width - 35, 8 );
			this.TVPLE_URL_GO_BUTTON.Location = new Point( this.Size.Width - 190, 8 );
			this.TVPLE_URL.Location = new Point( this.Size.Width - this.TVPLE_URL.Size.Width - 200, 8 );
			this.NEXT_BUTTON.Location = new Point( this.Size.Width - 70, 8 );
			this.PREVIOUS_BUTTON.Location = new Point( this.Size.Width - 100, 8 );
			this.HOME_BUTTON.Location = new Point( this.Size.Width - 130, 8 );
			this.WEB_NAME.Location = new Point( this.TVPLE_URL.Location.X - this.WEB_NAME.Size.Width - 10, 12 );
		}

		private void TvpleWeb_Load( object sender, EventArgs e )
		{
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
			this.SetStyle( ControlStyles.AllPaintingInWmPaint, true );
			this.SetStyle( ControlStyles.ResizeRedraw, true );

			linePen.Width = 1;
			//webBrowser.ObjectForScripting = true;
			webBrowser.ScriptErrorsSuppressed = true;


			// http://stackoverflow.com/questions/5529615/webbrowser-control-and-javascript-errors

			/*
			if you have IE9 installed, the WebBrowser will still use IE7 mode unless you override this behaviour with a registry setting - as described in this StackOverflow answer.
			This is the most likely cause of the JavaScript errors you're getting in the WebBrowser (because you're not seeing the same errors in IE9).

			You can make the registry setting using the following c# code (which sets IE10 mode if Windows 8 is detected) and changing app-name.exe to match your own application.
			You should add an error handler for the case where there are insufficient privileges (admin privileges are required to write to this registry key).
			*/

			string installkey = @"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION";
			string entryLabel = Path.GetFileNameWithoutExtension( Application.ExecutablePath ) + ".exe";
			System.OperatingSystem osInfo = System.Environment.OSVersion;

			string version = osInfo.Version.Major.ToString( ) + '.' + osInfo.Version.Minor.ToString( );
			uint editFlag = ( uint ) ( ( version == "6.2" ) ? 0x2710 : 0x2328 ); // 6.2 = Windows 8 and therefore IE10

			RegistryKey existingSubKey = Registry.LocalMachine.OpenSubKey( installkey, false );

			if ( existingSubKey.GetValue( entryLabel ) == null )
			{
				if ( !Program.IsAdministrator( ) )
				{
					DialogResult result = MessageBox.Show( this, "티비플 탐색기에서 최신 JavaScript 기술을 사용하려면 사용자 컴퓨터의 레지스트리를 수정해야 합니다, 이 작업에는 관리자 권한이 필요합니다.\n\n최신 JavaScript 기술이 필요한 이유 : 티비플 영상을 재생하려면 최신 JavaScript 기술이 필요합니다.", "티비플 다운로더", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );

					if ( result == DialogResult.Yes )
					{
						try
						{
							ProcessStartInfo startInfo = new ProcessStartInfo( );
							startInfo.UseShellExecute = true;
							startInfo.FileName = Application.ExecutablePath;
							startInfo.WorkingDirectory = Environment.CurrentDirectory;
							startInfo.Arguments = "web";
							startInfo.Verb = "runas";
							Process.Start( startInfo );

							Application.Exit( );
						}
						catch ( Exception ex )
						{
							MessageBox.Show( this, "권한 요청 중 알 수 없는 오류가 발생했습니다!\n\n" + ex.Message, "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
						}
					}
					else
					{
						MessageBox.Show( this, "최신 JavaScript 기술을 사용할 수 없으면, 티비플 탐색기를 사용할 수 없습니다. (티비플 영상 재생이 불가합니다.)", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Warning );
						this.Close( );
					}

					return;
				}
				else
				{
					existingSubKey = Registry.LocalMachine.OpenSubKey( installkey, true );
					existingSubKey.SetValue( entryLabel, unchecked(( int ) editFlag), RegistryValueKind.DWord );
				}
			}
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			webBrowser.Dispose( );
			this.Close( );
		}

		private void TVPLE_URL_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( e.KeyChar == '\r' )
			{
				TVPLE_URL_GO_BUTTON_Click( null, null );
				e.Handled = true;
			}
		}

		private void TVPLE_URL_GO_BUTTON_Click( object sender, EventArgs e )
		{
			webBrowser.Url = new Uri( this.TVPLE_URL.Text );
		}

		private void PREVIOUS_BUTTON_Click( object sender, EventArgs e )
		{
			if ( webBrowser.CanGoBack )
				webBrowser.GoBack( );
			else
				System.Media.SystemSounds.Beep.Play( );
		}

		private void NEXT_BUTTON_Click( object sender, EventArgs e )
		{
			if ( webBrowser.CanGoForward )
				webBrowser.GoForward( );
			else
				System.Media.SystemSounds.Beep.Play( );
		}

		private void HOME_BUTTON_Click( object sender, EventArgs e )
		{
			webBrowser.Url = new Uri( "http://tvple.com/" );
		}

		private void DOWNLOAD_NOW_BUTTON_Click( object sender, EventArgs e )
		{
			if ( TVPLE.IsTvpleURL( webBrowser.Document.Url.OriginalString ) )
			{
				MainForm.TVPLE_URL_TEXTBOX.Text = webBrowser.Document.Url.OriginalString;
				MainForm.GETINFO_BUTTON_Click( null, null );
				webBrowser.Dispose( );
				this.Close( );
			}
		}
	}
}

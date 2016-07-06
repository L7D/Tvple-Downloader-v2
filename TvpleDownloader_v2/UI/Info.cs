/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	public partial class Info : Form
	{
		private Point startPoint;
		private Pen linePen = new Pen( Color.Silver );

		public Info( )
		{
			InitializeComponent( );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( linePen, 0, 0, w, 0 ); // 맨 위
			e.Graphics.DrawLine( linePen, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( linePen, w - linePen.Width, 0, w - linePen.Width, h ); // 오른쪽
			e.Graphics.DrawLine( linePen, 0, h - linePen.Width, w, h - linePen.Width ); // 맨 아래
		}

		private void Info_Load( object sender, EventArgs e )
		{
			linePen.Width = 1;

			System.Reflection.Assembly assemObject = System.Reflection.Assembly.GetExecutingAssembly( );
			Version version = assemObject.GetName( ).Version;

			this.PROGRAM_VERSION.Text = "버전 " + version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
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

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			e.Graphics.DrawLine( linePen, 0, this.APP_TITLE_BAR.Height - linePen.Width, this.APP_TITLE_BAR.Width, this.APP_TITLE_BAR.Height - linePen.Width ); // 맨 아래
		}

		private void COPYRIGHT_STREAM_PROFILE_Click( object sender, EventArgs e )
		{
			MessageBox.Show( this, "티비플 다운로더 관련 문의 사항으로 스팀 친구 추가를 거실 경우 꼭 스팀 프로필 댓글에 사유를 게시해주십시오.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Information );
			System.Diagnostics.Process.Start( "http://steamcommunity.com/profiles/76561198011675377/" );
		}
	}
}

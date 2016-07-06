/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	public partial class Update : Form
	{
		private Pen linePen = new Pen( Color.Silver );
		private Point startPoint;

		public Update( string newVer, string updateLog )
		{
			InitializeComponent( );

			this.APP_INFO_0.Text = "티비플 다운로더를 " + newVer + " 버전으로 업데이트 할 수 있습니다!";
			this.UPDATE_LOG.Text = "업데이트 내역\n\n" + updateLog;
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

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			DialogResult result = MessageBox.Show( this, "정말로 티비플 다운로더를 다음에 업데이트 하시겠습니까?", "티비플 다운로더", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

			if ( result == DialogResult.Yes )
			{
				this.Close( );
			}
		}

		private void UPDATE_NOW_BUTTON_Click( object sender, EventArgs e )
		{
			DialogResult result = MessageBox.Show( this, "프로그램이 종료된 다음 업데이트 프로그램을 실행합니다, 계속하시겠습니까", "티비플 다운로더", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

			if ( result == DialogResult.Yes )
			{
				if ( System.IO.File.Exists( Application.StartupPath + "\\Tvple Downloader Update.exe" ) )
				{
					Process process = new Process( );

					ProcessStartInfo startInfo = new ProcessStartInfo( );
					startInfo.FileName = Application.StartupPath + "\\Tvple Downloader Update.exe";
					startInfo.Verb = "runas";

					process.StartInfo = startInfo;
					process.Start( );

					Application.Exit( );
				}
				else
				{
					MessageBox.Show( this, "티비플 다운로더 업데이트 프로그램을 찾을 수 없습니다, 업데이트를 할 수 없습니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
					this.Close( );
				}
			}
		}

		private void Update_Load( object sender, EventArgs e )
		{
			linePen.Width = 1;
		}
	}
}

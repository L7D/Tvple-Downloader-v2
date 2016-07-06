/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main( )
		{
			System.Diagnostics.Process[ ] process = System.Diagnostics.Process.GetProcessesByName( "Tvple Downloader Update" );

			if ( process.Length > 0 )
			{
				foreach ( System.Diagnostics.Process p in process )
				{
					MessageBox.Show( "티비플 다운로더 업데이트가 실행중 입니다, 업데이트가 끝난 다음 다시 시도하십시오.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Warning );
					Application.Exit( );
					return;
				}
			}

			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new Main( ) );
		}

		// http://deokss.blogspot.kr/2015/04/c.html
		public static bool IsAdministrator( )
		{
			WindowsIdentity identity = WindowsIdentity.GetCurrent( );

			if ( identity != null )
			{
				return ( new WindowsPrincipal( identity ) ).IsInRole( WindowsBuiltInRole.Administrator );
			}

			return false;
		}
	}
}

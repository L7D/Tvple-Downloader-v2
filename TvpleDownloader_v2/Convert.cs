/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	class Convert
	{
		[DllImport( "user32.dll" )]
		static extern int SetWindowText( IntPtr hWnd, string text );

		[DllImport( "user32.dll", SetLastError = true )]
		internal static extern bool MoveWindow( IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint );

		[DllImport( "user32.dll" )]
		static extern bool EnableMenuItem( IntPtr hMenu, uint uIDEnableItem, uint uEnable );
		[DllImport( "user32.dll" )]
		static extern IntPtr GetSystemMenu( IntPtr hWnd, bool bRevert );
		internal const UInt32 SC_CLOSE = 0xF060;
		internal const UInt32 MF_ENABLED = 0x00000000;
		internal const UInt32 MF_GRAYED = 0x00000001;
		internal const UInt32 MF_DISABLED = 0x00000002;
		internal const uint MF_BYCOMMAND = 0x00000000;

		public object[ ] ConvertToMP3( string fileDir )
		{
			string APP_DIR = Application.StartupPath;

			if ( File.Exists( APP_DIR + "\\bin\\ffmpeg.exe" ) )
			{
				if ( File.Exists( fileDir ) )
				{
					if ( Path.GetExtension( fileDir ).ToLower( ) == ".mp4" )
					{
						try
						{
							Process process = new Process( );

							// http://www.programkr.com/blog/MATMyADMwYT2.
							ProcessStartInfo startInfo = new ProcessStartInfo( );
							startInfo.FileName = APP_DIR + "\\bin\\ffmpeg.exe";
							startInfo.Arguments = "-y -i \"" + fileDir + "\" -vn -f mp3 -ab 192k \"" + Path.GetDirectoryName( fileDir ) + "\\" + Path.GetFileNameWithoutExtension( fileDir ) + "\".mp3";
							startInfo.CreateNoWindow = false;
							startInfo.WindowStyle = ProcessWindowStyle.Normal;

							process.StartInfo = startInfo;

							process.Start( );

							System.Threading.Thread.Sleep( 100 );
							MoveWindow( process.MainWindowHandle, 50, 50, 600, 100, true );
							SetWindowText( process.MainWindowHandle, "티비플 다운로더 - MP3 파일로 변환 중 ... [Powered by ffmpeg]" );
						}
						catch ( Exception ex )
						{
							return new object[ 1 ]
							{
								ex.Message
							};
						}


						while ( true )
						{
							System.Threading.Thread.Sleep( 1000 );

							Process[ ] processes = Process.GetProcessesByName( "ffmpeg" );

							if ( processes.Length <= 0 )
								break;
						}
						
						return new object[ 1 ]
					   {
							"#SUCCESS"
					   };
					}
					else
					{
						return new object[ 1 ]
					   {
							"#ERROR_NO_MP4_FILE"
					   };
					}

				}
				else
				{
					return new object[ 1 ]
					{
						"#ERROR_NO_TARGET_FILE"
					};
				}
			}
			else
			{
				return new object[ 1 ]
				{
					"#ERROR_NO_FFMPEG"
				};
			}
		}
	}
}

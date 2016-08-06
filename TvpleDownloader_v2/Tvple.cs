/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Json;
using System.Windows.Forms;

namespace TvpleDownloader_v2
{
	class Tvple
	{
		private Main MainForm;
		private string fileNameBackup = "";
		private WebClient webClient = null;

		public Tvple( Main MainForm )
		{
			this.MainForm = MainForm;
		}

		public string ConvertFromHTMLCode( string HTMLstring )
		{
			HTMLstring = HTMLstring.Replace( "&lt;", "<" );  // &lt; 를 < 로 변환
			HTMLstring = HTMLstring.Replace( "&gt;", ">" );  // &gt; 를 > 로 변환
			HTMLstring = HTMLstring.Replace( "&nbsp;", " " );  // &nbsp; 를 띄어쓰기 로 변환
			HTMLstring = HTMLstring.Replace( "&amp;", "&" );  // &amp; 를 & 로 변환
			HTMLstring = HTMLstring.Replace( "&quot;", "\"" );  // &quot; 를 " 로 변환 (따옴표)

			return HTMLstring;
		}

		public bool IsTvpleURL( string tvpleURL )
		{
			if ( tvpleURL.StartsWith( "http://tvple.com/" ) && tvpleURL.Length > 17 )
			{
				int i = 0;

				if ( int.TryParse( tvpleURL.Substring( 17, tvpleURL.Length - 17 ), out i ) )
				{
					return true;
				}
			}

			return false;
		}

		public bool CanUseFileNameString( string fileName )
		{
			if (
				fileName.Contains( "\\" ) ||
				fileName.Contains( "/" ) ||
				fileName.Contains( ":" ) ||
				fileName.Contains( "*" ) ||
				fileName.Contains( "?" ) ||
				fileName.Contains( "\"" )
			)
				return false;
			else
				return true;
		}

		public bool IsNewVideoImageURL( string imageURL )
		{
			// 최근에 나온 썸네일 이미지 경로는 &amp; (&) 와 Key-Pair-Id 를 포함하고 있습니다.

			if ( imageURL.Contains( "&amp;" ) && imageURL.Contains( "Key-Pair-Id=" ) )
				return true;
			else
				return false;
		}

		public void DownloadVideo( string directURL, string fileName )
		{
			webClient = new WebClient( );

			webClient.DownloadFileAsync( new Uri( directURL ), fileName );
			webClient.DownloadProgressChanged += DownloadProgressChanged;
			webClient.DownloadFileCompleted += DownloadFileCompleted;

			fileNameBackup = fileName;
		}

		public void CancelVideo( )
		{
			if ( webClient != null )
				webClient.CancelAsync( );
			else
				MessageBox.Show( "알 수 없는 오류가 발생했습니다, 취소할 수 없습니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
		}

		private void DownloadProgressChanged( object sender, DownloadProgressChangedEventArgs e )
		{
			float per = ( float ) e.BytesReceived / ( float ) e.TotalBytesToReceive;

			MainForm.DOWNLOAD_PERCENT.Size = new Size( ( int ) ( 365 * per ), 15 );
			MainForm.DOWNLOAD_LABEL.Text = string.Format( "다운로드 중 : {0:P}", ( double ) e.BytesReceived / ( double ) e.TotalBytesToReceive );
		}

		private void DownloadFileCompleted( object sender, AsyncCompletedEventArgs e )
		{
			if ( !e.Cancelled )
			{
				MainForm.DOWNLOAD_LABEL.Text = "다운로드 완료!";
				DialogResult result = MessageBox.Show( "영상을 성공적으로 다운로드 했습니다!\n이 영상을 MP3 파일로 변환하시겠습니까? (다운받은 영상이 삭제되지 않습니다.)", "티비플 다운로더", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

				if ( result == DialogResult.Yes )
				{
					Convert convert = new Convert( );
					object[ ] convertResult = convert.ConvertToMP3( fileNameBackup );

					if ( convertResult[ 0 ] == "#SUCCESS" )
					{
						MessageBox.Show( "해당 영상 파일을 MP3 파일로 성공적으로 변환하였습니다! (다운받은 영상이 삭제된 것이 아닙니다.)", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Information );
					}
					else if ( convertResult[ 0 ] == "#UNKNOWN" )
					{
						MessageBox.Show( "알 수 없는 오류가 발생했습니다.", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
					}
					else
					{
						MessageBox.Show( "해당 영상 파일을 MP3 파일로 변환할 수 없습니다.\n\n[ 오류 코드 : " + convertResult[ 0 ] + " ]", "티비플 다운로더", MessageBoxButtons.OK, MessageBoxIcon.Error );
					}
				}

				MainForm.CANCEL_VIDEO_Click( null, null );
			}
		}
		
		public string[ ] GetInformation( string tvpleURL )
		{
			try
			{
				WebRequest request = WebRequest.Create( tvpleURL );
				request.Method = "GET";

				using ( WebResponse webResponse = request.GetResponse( ) )
				{
					using ( StreamReader streamReader = new StreamReader( webResponse.GetResponseStream( ) ) )
					{
						string tvpleVideoHTML = streamReader.ReadToEnd( );

						int findVideoName_start = tvpleVideoHTML.IndexOf( "og:title" ); // 영상 이름 찾기
						int findVideoImageURL_start = tvpleVideoHTML.IndexOf( "og:image" ); // 썸네일 이미지를 찾습니다 ...
						int findAPIURL_start = tvpleVideoHTML.IndexOf( "data-meta=" ); // API 링크를 찾습니다 ...
						int findUploader_start = tvpleVideoHTML.IndexOf( "<div class=\"info-body-author\">" ); // 업로더 관련 정보를 찾습니다 ...
						int findChart_start = tvpleVideoHTML.IndexOf( "fa fa-fw fa-bar-chart" ); // 인기도 관련 정보를 찾습니다 ...

						string[ ] mixedArrayList_1 = tvpleVideoHTML.Substring( findVideoImageURL_start, tvpleVideoHTML.IndexOf( "og:video:url" ) - findVideoImageURL_start )
								.Split( new char[ 1 ] { '"' }, StringSplitOptions.RemoveEmptyEntries );

						string[ ] mixedArrayList_2 = tvpleVideoHTML.Substring( findAPIURL_start, tvpleVideoHTML.IndexOf( "data-nexts=" ) - findAPIURL_start )
								.Split( new char[ 1 ] { '"' }, StringSplitOptions.RemoveEmptyEntries );

						string[ ] mixedArrayList_3 = tvpleVideoHTML.Substring( findUploader_start, tvpleVideoHTML.IndexOf( "btn-group btn-group-xs" ) - findUploader_start )
								.Split( new char[ 2 ] { '>', '"' }, StringSplitOptions.RemoveEmptyEntries );

						string[ ] mixedArrayList_4 = tvpleVideoHTML.Substring( findChart_start, tvpleVideoHTML.IndexOf( "fa fa-fw fa-video-camera" ) - findChart_start )
								.Split( new char[ 2 ] { '>', '"' }, StringSplitOptions.RemoveEmptyEntries );

						string[ ] mixedArrayList_5 = tvpleVideoHTML.Substring( findVideoName_start, tvpleVideoHTML.IndexOf( "og:type" ) - findVideoName_start )
									.Split( new char[ 1 ] { '"' }, StringSplitOptions.RemoveEmptyEntries );

						string TVPLE_API_URL = mixedArrayList_2[ 1 ];
						string TVPLE_VIDEO_NAME = ConvertFromHTMLCode( mixedArrayList_5[ 2 ] );
						string TVPLE_VIDEO_DESC = ConvertFromHTMLCode( mixedArrayList_1[ 6 ] );
						string TVPLE_VIDEO_IMAGE_URL = mixedArrayList_1[ 2 ];
						string TVPLE_UPLOADER_NAME = mixedArrayList_3[ 13 ].Trim( ).Replace( "<small class=", "" ).Replace( "</a", "" );
						string TVPLE_UPLOADER_CHANEL_URL = mixedArrayList_3[ 3 ];
						string TVPLE_POPULAR = mixedArrayList_4[ 3 ].Replace( "</li", "" ).Trim( );
						string TVPLE_VIEWS = mixedArrayList_4[ 11 ].Replace( "</li", "" ).Trim( );

						// 영상 설명이 없을 때 처리
						if ( TVPLE_VIDEO_DESC.Substring( 0, 2 ) == "/>" && TVPLE_VIDEO_DESC.Contains( "<meta property=" ) )
						{
							TVPLE_VIDEO_DESC = "영상 설명이 없습니다.";
						}

						// 새로운 썸네일 방식인지 확인
						if ( IsNewVideoImageURL( TVPLE_VIDEO_IMAGE_URL ) )
							TVPLE_VIDEO_IMAGE_URL = TVPLE_VIDEO_IMAGE_URL.Replace( "&amp;", "&" );
						//else
							//TVPLE_VIDEO_IMAGE_URL = TVPLE_VIDEO_IMAGE_URL.Replace( ".md-16x9", ".sm-16x9-gif" ); // GIF 이미지 지원

						try
						{
							WebRequest request2 = WebRequest.Create( TVPLE_API_URL );
							request2.Method = "GET";

							using ( WebResponse webResponse2 = request2.GetResponse( ) )
							{
								using ( StreamReader streamReader2 = new StreamReader( webResponse2.GetResponseStream( ) ) )
								{
									string apiData = streamReader2.ReadToEnd( );

									// 비디오 이름 인덱스 : mixedArrayList_5[ 2 ]
									// 썸네일 이미지 인덱스 : mixedArrayList_1[ 2 ]
									// API 인덱스 : mixedArrayList_2[ 1 ]
									// 업로더 채널 주소 인덱스 mixedArrayList_3[ 3 ]
									// 업로더 이름 인덱스 mixedArrayList_3[ 13 ] (Trim 필요) (</a 공백 전환 필요)
									// 비디오 설명 인덱스 : mixedArrayList_1[ 6 ] (HTML 코드 전환 필요)
									// 비디오 인기도 인덱스 : mixedArrayList_4[ 3 ] (</li 공백 전환 필요)
									// 비디오 조회수 인덱스 : mixedArrayList_4[ 11 ] (</li 공백 전환 필요)

									JsonObject json = new JsonTextParser( ).Parse( apiData );
									JsonObjectCollection masterJSON = ( JsonObjectCollection ) json;
									JsonObjectCollection streamJSON = ( JsonObjectCollection ) masterJSON[ "stream" ];
									JsonObjectCollection sourcesJSON = ( JsonObjectCollection ) streamJSON[ "sources" ];
									JsonObjectCollection aJSON = ( JsonObjectCollection ) sourcesJSON[ "a" ];
									JsonObjectCollection urlsJSON = ( JsonObjectCollection ) aJSON[ "urls" ];

									return new string[ ]
									{
										urlsJSON[ "mp4_avc" ].GetValue( ).ToString( ),
										TVPLE_VIDEO_NAME,
										TVPLE_VIDEO_DESC,
										TVPLE_VIDEO_IMAGE_URL,
										TVPLE_UPLOADER_NAME,
										TVPLE_UPLOADER_CHANEL_URL,
										TVPLE_POPULAR,
										TVPLE_VIEWS,
										streamJSON[ "width" ].GetValue( ).ToString( ) + "x" + streamJSON[ "height" ].GetValue( ).ToString( ),
										streamJSON[ "duration" ].GetValue( ).ToString( )
									};
								}
							}
						}
						catch ( WebException ex )
						{
							if ( ex.Response == null )
								return new string[ 1 ]
								{
									"#ERROR_INTERNET"
								};

							HttpStatusCode code = ( ( HttpWebResponse ) ex.Response ).StatusCode;

							if ( code == HttpStatusCode.NotFound )
							{
								return new string[ 1 ]
								{
									"#TVPLE_UNKNOWN_VIDEO"
								};
							}
						}
						catch ( Exception ex )
						{
							return new string[ 1 ]
							{
								ex.Message
							};
						}
					}
				}
			}
			catch ( WebException ex )
			{
				if ( ex.Response == null )
					return new string[ 1 ]
					{
						"#ERROR_INTERNET"
					};

				HttpStatusCode code = ( ( HttpWebResponse ) ex.Response ).StatusCode;

				if ( code == HttpStatusCode.NotFound )
				{
					return new string[ 1 ]
					{
						"#TVPLE_UNKNOWN_VIDEO"
					};
				}
			}
			catch ( Exception ex )
			{
				return new string[ 1 ]
				{
					ex.Message
				};
			}

			return new string[ 1 ]
			{
				"#UNKNOWN_ERROR"
			};
		}
	}
}
/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

using System;

namespace TvpleDownloader_v2
{
	public class CustomLabel : System.Windows.Forms.Label
	{
		private const int WM_NCHITTEST = 0x84; // 현재 마우스 커서의 위치가 윈도우의 어떤 부분에 있는지 조사할 때 먼저 보내는 메시지;
		private const int HTTRANSPARENT = -1;

		protected override void WndProc( ref System.Windows.Forms.Message message )
		{
			if ( message.Msg == ( int ) WM_NCHITTEST ) // 만약 이 라벨에 메시지가 전달되면;
				message.Result = ( IntPtr ) HTTRANSPARENT; // 그대로 통과시킴;
			else
				base.WndProc( ref message );
		}

		/*
        ---------------------- DefwindowProc 의 리턴값 -------------------------------------
        HTBORDER 크기 조절이 불가능한 경계선 18
        HTBOTTOM 아래쪽 경계선 15
        HTTOP  위쪽 경계선
        HTBOTTOMLEFT 아래 왼쪽 경계선 16
        HTBOTTOMRIGHT 아래 오른쪽 경계선 17
        HTTOPLEFT 위 왼쪽  경계선 13
        HTTOPRIGHT 위 오른쪽 경계선 14
        HTLEFT  왼쪽 경계선 10
        HTRIGHT  오른쪽 경계선 11
        HTCAPTION 타이틀 바 2
        HTCLIENT  작업영역 1
        HTCLOSE  닫기 버튼 20
        HTSIZE  크기 변경 박스 4
        HTHELP  도움말 버튼 21
        HTHSCROLL 수평 스크롤 바 6
        HTVSCROLL 수직 스크롤바 7 
        HTMENU  메뉴 5
        HTMAXBUTTON 최대화 버튼 9
        HTMINBUTTON 최소화 버튼 8
        HTSYSMENU 시스템 메뉴 3
        HTTRANSPARENT 같은 스레드의 다른 윈도우에 가려진 부분 -1
        --------------------------------------------------------------------------------------
        */
	}
}

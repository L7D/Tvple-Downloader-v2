/*
	___ _  _ ___  _    ____             ___  ____ _ _ _ _  _ _    ____ ____ ___  ____ ____ 
	 |  |  | |__] |    |___             |  \ |  | | | | |\ | |    |  | |__| |  \ |___ |__/ 
	 |   \/  |    |___ |___             |__/ |__| |_|_| | \| |___ |__| |  | |__/ |___ |  \ 

	Copyright © L7D 2016
*/

namespace TvpleDownloader_v2
{
	partial class Update
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Update ) );
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel( );
			this.APP_INFO_0 = new System.Windows.Forms.Label( );
			this.APP_INFO_1 = new System.Windows.Forms.Label( );
			this.UPDATE_NOW_BUTTON = new System.Windows.Forms.Button( );
			this.UPDATE_LOG = new System.Windows.Forms.Label( );
			this.APP_UPDATE_ICON = new System.Windows.Forms.PictureBox( );
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox( );
			this.APP_TITLE = new TvpleDownloader_v2.CustomLabel( );
			this.APP_TITLE_BAR.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.APP_UPDATE_ICON ) ).BeginInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add( this.CLOSE_BUTTON );
			this.APP_TITLE_BAR.Controls.Add( this.APP_TITLE );
			this.APP_TITLE_BAR.Location = new System.Drawing.Point( 0, 0 );
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size( 550, 40 );
			this.APP_TITLE_BAR.TabIndex = 23;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler( this.APP_TITLE_BAR_Paint );
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseDown );
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler( this.APP_TITLE_BAR_MouseMove );
			// 
			// APP_INFO_0
			// 
			this.APP_INFO_0.AutoSize = true;
			this.APP_INFO_0.BackColor = System.Drawing.Color.Transparent;
			this.APP_INFO_0.Font = new System.Drawing.Font( "맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_INFO_0.Location = new System.Drawing.Point( 9, 49 );
			this.APP_INFO_0.Name = "APP_INFO_0";
			this.APP_INFO_0.Size = new System.Drawing.Size( 352, 17 );
			this.APP_INFO_0.TabIndex = 40;
			this.APP_INFO_0.Text = "티비플 다운로더를 1.0 버전으로 업데이트 할 수 있습니다!";
			// 
			// APP_INFO_1
			// 
			this.APP_INFO_1.AutoSize = true;
			this.APP_INFO_1.BackColor = System.Drawing.Color.Transparent;
			this.APP_INFO_1.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_INFO_1.Location = new System.Drawing.Point( 9, 68 );
			this.APP_INFO_1.Name = "APP_INFO_1";
			this.APP_INFO_1.Size = new System.Drawing.Size( 328, 13 );
			this.APP_INFO_1.TabIndex = 41;
			this.APP_INFO_1.Text = "지금 업데이트 하시면 새로운 기능을 모두 사용하실 수 있습니다.";
			// 
			// UPDATE_NOW_BUTTON
			// 
			this.UPDATE_NOW_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.UPDATE_NOW_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.UPDATE_NOW_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.UPDATE_NOW_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UPDATE_NOW_BUTTON.Font = new System.Drawing.Font( "맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.UPDATE_NOW_BUTTON.Location = new System.Drawing.Point( 12, 351 );
			this.UPDATE_NOW_BUTTON.Name = "UPDATE_NOW_BUTTON";
			this.UPDATE_NOW_BUTTON.Size = new System.Drawing.Size( 526, 37 );
			this.UPDATE_NOW_BUTTON.TabIndex = 44;
			this.UPDATE_NOW_BUTTON.Text = "지금 업데이트";
			this.UPDATE_NOW_BUTTON.UseVisualStyleBackColor = true;
			this.UPDATE_NOW_BUTTON.Click += new System.EventHandler( this.UPDATE_NOW_BUTTON_Click );
			// 
			// UPDATE_LOG
			// 
			this.UPDATE_LOG.BackColor = System.Drawing.Color.Transparent;
			this.UPDATE_LOG.Font = new System.Drawing.Font( "맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.UPDATE_LOG.Location = new System.Drawing.Point( 9, 104 );
			this.UPDATE_LOG.Name = "UPDATE_LOG";
			this.UPDATE_LOG.Size = new System.Drawing.Size( 372, 244 );
			this.UPDATE_LOG.TabIndex = 45;
			this.UPDATE_LOG.Text = "업데이트 내역";
			// 
			// APP_UPDATE_ICON
			// 
			this.APP_UPDATE_ICON.BackColor = System.Drawing.Color.Transparent;
			this.APP_UPDATE_ICON.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.APP_UPDATE_ICON.Image = global::TvpleDownloader_v2.Properties.Resources.UPDATE_APP_ICON;
			this.APP_UPDATE_ICON.Location = new System.Drawing.Point( 400, 49 );
			this.APP_UPDATE_ICON.Name = "APP_UPDATE_ICON";
			this.APP_UPDATE_ICON.Size = new System.Drawing.Size( 150, 150 );
			this.APP_UPDATE_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.APP_UPDATE_ICON.TabIndex = 46;
			this.APP_UPDATE_ICON.TabStop = false;
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
			this.APP_TITLE.Location = new System.Drawing.Point( 5, 10 );
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size( 184, 20 );
			this.APP_TITLE.TabIndex = 0;
			this.APP_TITLE.Text = "티비플 다운로더 업데이트";
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size( 550, 400 );
			this.Controls.Add( this.APP_UPDATE_ICON );
			this.Controls.Add( this.UPDATE_LOG );
			this.Controls.Add( this.UPDATE_NOW_BUTTON );
			this.Controls.Add( this.APP_INFO_1 );
			this.Controls.Add( this.APP_INFO_0 );
			this.Controls.Add( this.APP_TITLE_BAR );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
			this.Name = "Update";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update";
			this.TopMost = true;
			this.Load += new System.EventHandler( this.Update_Load );
			this.APP_TITLE_BAR.ResumeLayout( false );
			this.APP_TITLE_BAR.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.APP_UPDATE_ICON ) ).EndInit( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).EndInit( );
			this.ResumeLayout( false );
			this.PerformLayout( );

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.Label APP_INFO_0;
		private System.Windows.Forms.Label APP_INFO_1;
		private System.Windows.Forms.Button UPDATE_NOW_BUTTON;
		private System.Windows.Forms.Label UPDATE_LOG;
		private System.Windows.Forms.PictureBox APP_UPDATE_ICON;
	}
}
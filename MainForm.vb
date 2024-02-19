Option Strict On

'●言語のドキュメント
'Sub:戻り値として何も返さないという意味
'Dim:変数の宣言時に使用
'　→Dimがない変数もあるグローバルの場合は使用しない方法を検討、ローカル変数ならDimを使用するの検討
'Nothing: 照型の場合、既定値は null 参照です
'DirectCast: 型変換
'  →(例)GameStartButton_Clickの引数は、(ByVal sender As System.Object, ByVal e As System.EventArgs)は●Object型なので、プロパティやメソッドの実行を行うことが不可能
'    →型変換を行うと、プロパティの取得やメソッドの実行などが行える
'Exit Sub: Subのプロシージャー終了する。(内容次第ではあるが、プログラムが完全に終わるかどうかは処理全体をみて判断すること)
'Is: オブジェクトの参照の比較を行う
'=(イコール): 値の比較などに行う 
'IsNot: 等しくない
'For Each: 配列やオブジェクトのループ処理を行う際に使用
'For Each 変数名 In オブジェクト
'ループ処理
'Next

'●デザイナーで使用されているプロパティ一覧
'PictureBox: デザイナーでハンバーガーの画像を貼り付けるパネル
'ScoreLabel: デザイナーで得点の隣にあるスコアボード
'NumLabel: デザイナーで右下のハンバーガーの画像の隣にあるスコアボード
'PerfectPicture: デザイナーで全問正解したとき表示される
'TimeOverPicture: デザイナーで時間切れの時に表示される
'GameStartButton: デザイナーでGameStartと表示されているボタン
'StartMenuItem: デザイナーでゲーム(G)と表示されているボタンの中にあるゲーム開始ボタン
'TimeProgressBar: デザイナーで時間を表す棒
'TimeLimitTimer: 500にしている(0.5秒)1秒が1000ミリ秒
'TimeLimitTimer: デザイナーでタイマーの設定を行っている
'QuitMenuItem: デザイナーでゲーム(G)→HamburgerPartyの終了(Q)の処理を行う
'QuestionPicture: デザイナーで12マスあるところ
'MainPanel: デザイナーで12マスのハンバーガーの下にある大きなパネル

'●わからないこと
'sender: 意味が理解できない


Public Class MainForm

    '定数を定義(NumPictureだけでも伝わるが、定数を記載することで人間が見たときにわかる。機械はインデックス番号は0からだから、この場合0から5までの数になる)
    Private Const OptionNum As Integer = 6
    Private Const PictureNum As Integer = 12

    '正解ペア数
    Private CorrectNum As Integer = 0

    '画像を貼り付けるパネル(PictureBox)を定義
    Private FirstBurger As PictureBox

    'ハンバーガーの中身は全部で6種類(定数のところを確認)
    '()の中については配列のことを指している
    Private NumPicture(OptionNum - 1) As Image

    '出題用の乱数を保持する配列
    '''''''''''''''''''''''''''''''''''''''
    '''''''''''解説は後ほど''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''
    Private RandomNumArray(PictureNum - 1) As Integer

    'ここは怪しいかも
    Private Sub ResetForm()

        'For Eachのブロックで使用する変数
        Dim BurgerPicture As PictureBox

        'フォームの○○.Textに対して初期値0を代入
        Me.ScoreLabel.Text = "0"
        Me.NumLabel.Text = "0"

        'ゲーム開始前はPerfectとTimeOverを非表示にする
        Me.PerfectPicture.Visible = False
        Me.TimeOverPicture.Visible = False

        'MainPanel上にある12マスのハンバーガーの中身の画像のコントロールを全て指定
        'Me.MainPanel.Controlsオブジェクトから1つ取り出して、BurgerPicture変数に代入する、代入されたオブジェクトをループ処理する
        For Each BurgerPicture In Me.MainPanel.Controls

            'もしBurgerPicture.BackgroundImage(ハンバーガーの中身の画像)がNullではない場合
            If BurgerPicture.BackgroundImage IsNot Nothing Then
                'BurgerPicture.BackgroundImageをNullにする
                BurgerPicture.BackgroundImage = Nothing
            End If
        Next
        '上記の処理で行っているのこととしては、Me.MainPanel.Controlsは全部で12個のハンバーガーの画像を管理している。その中から1個選択されたらそれを変数BurgerPictureに格納してループ処理へ
        'もしBurgerPicture.BackgroundImageの中身がNullではなく中に画像が格納されている場合は...
        'BurgerPicture.BackgroundImageをNullにする、つまり非表示にしてハンバーガーの中身を再び見えなくするため
    End Sub

    '時間切れ時に描画される文字と制限時間内にゲームがクリアした時に描画される処理
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'フォームの○○.Visibleに対してFalseを代入すると非表示にされる:Trueになると表示
        Me.PerfectPicture.Visible = False
        Me.TimeOverPicture.Visible = False
    End Sub

    '画面を閉じる際にゲームを終了しますか？ウィンドウの処理
    Private Sub MainForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Reply As DialogResult

        'MessageBoxのShowメソッドの引数にて、メッセージボックスの内容が記載されている
        Reply = MessageBox.Show("HamburgerPartyを終了します。", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        'もしReplyとDialogResult.Cancelが等しければ...(キャンセルが押されたら)
        If Reply = DialogResult.Cancel Then
            'e.CancelをTureにする(フォームを閉じることキャンセルする)
            e.Cancel = True
        End If

    End Sub

    'GameStartButtonの処理
    'ボタンは違うけどStartMenuの処理と同じ
    Private Sub GameStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameStartButton.Click

        'Falseにすることで、ボタン押下後非活性にできる
        Me.GameStartButton.Enabled = False
        Me.StartMenuItem.Enabled = False

        'Maxiumは60で設定、Valueは0で設定している。
        'Valueが0だと最初のバーには値が0しか入っていない。その上にMaximumの60を上から被せる(代入)とタイマーのような緑のバーに変わる
        Me.TimeProgressBar.Value = Me.TimeProgressBar.Maximum

        'タイマーの起動(EnabledプロパティをTrueにすること)
        Me.TimeLimitTimer.Enabled = False

    End Sub

    'StartMenuの処理
    'ボタンは違うけどGameStartButtonの処理と同じ
    Private Sub StartMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMenuItem.Click

        Me.GameStartButton.Enabled = False
        Me.StartMenuItem.Enabled = False
        Me.TimeProgressBar.Value = Me.TimeProgressBar.Maximum
        Me.TimeLimitTimer.Enabled = True

    End Sub

    'ゲーム(G)→HamburgerPartyの終了(Q)の処理(フォームを閉じる)
    Private Sub QuitMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitMenuItem.Click
        'Closeメソッドは今回は、実行されるとMainForm_FormClosingのイベントハンドラーが実行されることになる
        Me.Close()
    End Sub

    'プログレスバーの処理を行う
    Private Sub TimeLimitTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLimitTimer.Tick

        'GameStartButton_Click内のローカル変数に記載されているTimeProgressBar.Valueに対して-1を行う
        '60-1だが、500で設定しているので実質0.5を60回カウントされるので時間は30秒なので30秒-1秒が行われる
        Me.TimeProgressBar.Value -= 1

        'もしTimeProgressBar.Valueの値が0以下であれば...
        If Me.TimeProgressBar.Value <= 0 Then
            'タイマーを停止
            Me.TimeLimitTimer.Stop()
            '時間切れの表示を行う
            Me.TimeOverPicture.Visible = True

            'FirstBurgerをnullにする
            FirstBurger = Nothing

            'GameStartButtonとStartMenuItemを活性化させる
            Me.GameStartButton.Enabled = True
            Me.StartMenuItem.Enabled = True
        End If
    End Sub

    'ハンバーガーが12マス描画されるエリアの処理
    Private Sub QuestionPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionPicture1.Click, QuestionPicture2.Click, QuestionPicture3.Click, QuestionPicture4.Click, QuestionPicture5.Click, QuestionPicture6.Click, QuestionPicture7.Click, QuestionPicture8.Click, QuestionPicture9.Click, QuestionPicture10.Click, QuestionPicture11.Click, QuestionPicture12.Click

        'イベントが発生したときにクリックされた PictureBox を保持する変数。例えばQuestionPicture1.Clickが押下されたら保持する役割
        Dim NowPicture As PictureBox


        'ゲームの判定はタイマーが動いているかどうかで判断
        'タイマーが動いているならTrue、動いてないならFalse
        'もし、タイマーが停止しているのであれば、Exit Sub(サブルーチン)にて終了
        If Me.TimeLimitTimer.Enabled = False Then
            Exit Sub
        End If

        'DirectCastを使用して第一引数のsenderを複製して、複製したsenderを第二引数のPictureBox型に型変換して、NowPictureに代入
        NowPicture = DirectCast(sender, PictureBox)

        'もしNowPicture.ImageがNullであれば何もしない
        'ゲームで例えると、このゲームは神経衰弱である、カードが裏返しであれば表示されるけど、表の表示であれば何もしないようにしたい
        'Isでオブジェクトの比較を行う(イコールは値の比較で用いる)
        If NowPicture.Image Is Nothing Then
            Exit Sub
        End If

        'ハンバーガーの画像をPictureBoxのImageプロパティに設定される
        '6種類のハンバーガーの中身の画像に対して、上からハンバーガーのバンズの画像を重ねる
        '上のバンズの画像を削除することで、神経衰弱が可能。それを実現するには、Imageプロパティをの値を削除する必要がある
        'Nothingを指定すると可能
        NowPicture.Image = Nothing

        '上記だけだと比較対象(2つめのハンバーガー)の画像の中身を見る前に一致した時点で削除されてしまう。
        '画面更新を行うと中身の画像が確認できる(Refreshメソッド)
        Me.Refresh()

        'もしFirstBurgerがNullであれば(1回目の処理開始時)
        If FirstBurger Is Nothing Then
            'NowPictureでハンバーガーの画像をFirstBurgerに代入する
            FirstBurger = NowPicture
        Else
            '1回目のクリックではないとき、2回目のクリックイベント時の処理にて正誤の判定を行う(コードはまだ)

        End If
    End Sub

    'コンストラクタ(MainFormの右のタブをNewにすると生成される
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        'NumPictureは配列変数
        'ハンバーガーの中身の画像6枚がNumPictureに代入される
        NumPicture(0) = My.Resources.hamburger010
        NumPicture(1) = My.Resources.hamburger020
        NumPicture(2) = My.Resources.hamburger030
        NumPicture(3) = My.Resources.hamburger040
        NumPicture(4) = My.Resources.hamburger050
        NumPicture(5) = My.Resources.hamburger060

    End Sub

    Private Sub PrepareGame(ByVal PictureBoxNum As Integer)
        Dim QuestRandom As Random = New Random()
        Dim RandomNum As Integer
        Dim RandomNumArray(PictureNum - 1) As Integer
        Dim MatchFlag As Boolean = False
        Dim i As Integer
        Dim MyPictureBox As PictureBox
        Dim PictureNo As Integer = 0


        For i = 0 To PictureBoxNum - 3
            Do
                RandomNum = QuestRandom.Next(0, PictureBoxNum)
                RandomNumArray(i) = RandomNum

                MatchFlag = False
                For j As Integer = 0 To i - 1
                    If RandomNumArray(j) = RandomNum Then
                        MatchFlag = True
                        Exit For
                    End If
                Next

                If MatchFlag = False Then
                    RandomNumArray(i) = RandomNum
                End If
            Loop While MatchFlag = True
        Next
    End Sub

End Class
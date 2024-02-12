Option Strict On

Public Class MainForm
    Private Const OptionNum As Integer = 6
    Private Const PictureNum As Integer = 12

    Private CorrectNum As Integer = 0       '正解ペア数
    Private FirstBurger As PictureBox       '1つ目のハンバーガー

    Private NumPicture(OptionNum - 1) As Image          'ハンバーガーの中身
    Private RandomNumArray(PictureNum - 1) As Integer   '出題用乱数

    Private Sub ResetForm()                 'ResetFormメソッド内の処理(ResetFormは引数も戻り値もなしなのでSubを使用
        Me.ScoreLabel.Text = "0"
        Me.NumLabel.Text = "0"
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '以下TimeOverとPerfectを非表示にするためFalse
        Me.PerfectPicture.Visible = False
        Me.TimeOverPicture.Visible = False
    End Sub

    Private Sub MainForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Reply As DialogResult
        Reply = MessageBox.Show("HamburgerPartyを終了します。", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If Reply = DialogResult.Cancel Then
            e.Cancel = True
        End If

    End Sub

    Private Sub GameStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameStartButton.Click

        '以下の処理はGameStartボタンと左上のゲーム開始ボタンを非活性状態にする(ゲームが開始されたときのみ)
        Me.GameStartButton.Enabled = False
        Me.StartMenuItem.Enabled = False
        'デザイナー側で設定しているMaximumの値が60である。Maximumと同じ値にするとバーの長さは100％になる
        Me.TimeProgressBar.Value = Me.TimeProgressBar.Maximum
        '制限時間のタイマーを作動(EnabledプロパティをTrueにすると動く)
        Me.TimeLimitTimer.Enabled = True

    End Sub
End Class

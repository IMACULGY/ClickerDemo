Imports System.Runtime.InteropServices
Imports System.Threading
Public Class Form1
    <DllImport("user32.dll")>
    Private Shared Sub mouse_event(dwFlags As UInteger, dx As UInteger, dy As UInteger, dwData As UInteger, dwExtraInfo As Integer)
    End Sub
    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function

    Public Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Public Const MOUSEEVENTF_LEFTUP = &H4 ' left button up

    Private flag As Boolean = False
    Private clicks As Integer = 100
    Private i As Integer = 0

    Private Sub EmulateClickEvent()
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0) 'cursor will go down (like a click)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0) ' cursor goes up again
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = i
        Me.KeyPreview = True
        Timer2.Interval = 100
        Timer2.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StartAutoClicker()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    'Timer will stop if # of clicks exceeds the entered value OR hotkey is entered.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Hotkey As Boolean
        Hotkey = GetAsyncKeyState(Keys.F8)
        If Hotkey = True Then
            Timer1.Stop()
            flag = False
            i = 0
            Timer2.Start()
        Else
            If i < clicks Then
                i = i + 1
                Label3.Text = i
                EmulateClickEvent()
            Else
                Timer1.Stop()
                flag = False
                i = 0
                Timer2.Start()
            End If
        End If
    End Sub

    'Start the autoclicking timer.
    Private Sub StartAutoClicker()

        If (TextBox1.Text = "" Or TextBox2.Text = "" Or Not (IsNumeric(TextBox2.Text)) Or Not (IsNumeric(TextBox1.Text))) Then
            MsgBox("Please enter a valid number value for clicks and/or interval", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
        ElseIf (Integer.Parse(TextBox1.Text) <= 0 Or Integer.Parse(TextBox2.Text) <= 0) Then
            MsgBox("Please enter a number other than 0 for clicks and/or interval", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
        Else
            clicks = Integer.Parse(TextBox1.Text)
            Dim interval As Integer = Integer.Parse(TextBox2.Text)

            'Makes sure the button/keybind is only clicked once.
            If Not flag Then
                flag = True
                Timer2.Stop()
                Timer1.Interval = interval
                Timer1.Start()
            End If
        End If
    End Sub

    'Pressing F7 will start the autoclicker, pressing F8 will stop it.
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Hotkey As Boolean
        Hotkey = GetAsyncKeyState(Keys.F7)
        If Hotkey = True Then
            StartAutoClicker()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HotkeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotkeysToolStripMenuItem.Click
        MsgBox("F7 to start the clicker, F8 to stop it. Hotkeys can be pressed when the program is in the background. Make sure you have correct values for # of Clicks and Interval before starting the clicker.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Hotkeys")
    End Sub
End Class

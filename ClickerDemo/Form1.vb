Imports System.Runtime.InteropServices
Imports System.Threading
Public Class Form1
    <DllImport("user32.dll")>
    Private Shared Sub mouse_event(dwFlags As UInteger, dx As UInteger, dy As UInteger, dwData As UInteger, dwExtraInfo As Integer)
    End Sub



    Private WithEvents MouseDetector As MouseDetector
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Long
    Public Declare Auto Function GetCursorPos Lib "User32.dll" (ByRef lpPoint As Point) As Long
    'Public Declare Sub apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Long, ByVal dx As Long, ByVal dy As Long, ByVal cButtons As Long, ByVal dwExtraInfo As Long)
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
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clicks = Integer.Parse(TextBox1.Text)
        Dim interval As Integer = Integer.Parse(TextBox2.Text)

        'Makes sure the button is only clicked once.
        If Not flag Then
            flag = True
            Timer1.Interval = interval
            Timer1.Start()
        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If i < clicks Then
            i = i + 1
            Label3.Text = i
            EmulateClickEvent()
        Else
            Timer1.Stop()
            flag = False
            i = 0
        End If
    End Sub



End Class

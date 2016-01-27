Module DelayMod
    Private Structure SYSTEMTIME    '»ñÈ¡ÏµÍ³Ê±¼ä ×Ô¶¨ÒåÀàÐÍ  ÅäºÏ³ÌÐòËÙ¶È²âÊÔ¹¦ÄÜÊ¹ÓÃ
        Public wYear As Integer
        Public wMonth As Integer
        Public wDayOfWeek As Integer
        Public wDay As Integer
        Public wHour As Integer
        Public wMinute As Integer
        Public wSecond As Integer
        Public wMilliseconds As Integer
    End Structure

    Private Structure FILETIME    '»ñÈ¡ÏµÍ³Ê±¼ä ×Ô¶¨ÒåÀàÐÍ  ÅäºÏ³ÌÐòËÙ¶È²âÊÔ¹¦ÄÜÊ¹ÓÃ
        Public dwLowDateTime As Long
        Public dwHighDateTime As Long
    End Structure


    Private Declare Sub GetLocalTime Lib "kernel32" (lpSystemTime As SYSTEMTIME)  'API »ñÈ¡ÏµÍ³¿ª»úÊ±¼ä

    Public Declare Function WriteProcessMemory Lib "kernel32" (
            ByVal hProcess As Long,
            ByVal lpBaseAddress As IntPtr,
            ByVal lpBuffer As IntPtr,
            ByVal nSize As Long, lpNumberOfBytesWritten As Long) As Long          'Ð´ÄÚ´æAPI

    Public Declare Function ReadProcessMemory Lib "kernel32" (
            ByVal hProcess As Long,
            ByVal lpBaseAddress As IntPtr,
            ByVal lpBuffer As IntPtr,
            ByVal nSize As Long,
            lpNumberOfBytesWritten As Long) As Long                             '¶ÁÄÚ´æAPI


    Public Structure MyImageSize      'Ä¿µÄ£º ÅäºÏ»ñÈ¡Í¼Æ¬ÎÄ¼þ´óÐ¡  ×Ô¶¨ÒåÀàÐÍ
        Public Width As Long
        Public Height As Long
    End Structure



    'ÅäºÏÑÓ³Ùº¯Êý########################

    Private Const WAIT_ABANDONED& = &H80&
    Private Const WAIT_ABANDONED_0& = &H80&
    Private Const WAIT_FAILED& = -1&
    Private Const WAIT_IO_COMPLETION& = &HC0&
    Private Const WAIT_OBJECT_0& = 0
    Private Const WAIT_OBJECT_1& = 1
    Private Const WAIT_TIMEOUT& = &H102&
    Private Const INFINITE = &HFFFF
    Private Const ERROR_ALREADY_EXISTS = 183&
    Private Const QS_HOTKEY& = &H80
    Private Const QS_KEY& = &H1
    Private Const QS_MOUSEBUTTON& = &H4
    Private Const QS_MOUSEMOVE& = &H2
    Private Const QS_PAINT& = &H20
    Private Const QS_POSTMESSAGE& = &H8
    Private Const QS_SENDMESSAGE& = &H40
    Private Const QS_TIMER& = &H10
    Private Const QS_MOUSE& = (QS_MOUSEMOVE Or QS_MOUSEBUTTON)
    Private Const QS_INPUT& = (QS_MOUSE Or QS_KEY)
    Private Const QS_ALLEVENTS& = (QS_INPUT Or QS_POSTMESSAGE Or QS_TIMER Or QS_PAINT Or QS_HOTKEY)
    Private Const QS_ALLINPUT& = (QS_SENDMESSAGE Or QS_PAINT Or QS_TIMER Or QS_POSTMESSAGE Or QS_MOUSEBUTTON Or QS_MOUSEMOVE Or QS_HOTKEY Or QS_KEY)
    Private Const UNITS = 4294967296.0#
    Private Const MAX_LONG = -2147483648.0#
    Private Declare Function CreateWaitableTimer _
            Lib "kernel32" _
            Alias "CreateWaitableTimerA" (ByVal lpSemaphoreAttributes As Integer,
            ByVal bManualReset As Integer,
            ByVal lpName As String) As Long            'api ÅäºÏÑÓ³Ùº¯Êý

    Private Declare Function OpenWaitableTimer _
            Lib "kernel32" _
            Alias "OpenWaitableTimerA" (ByVal dwDesiredAccess As Long,
            ByVal bInheritHandle As Long,
            ByVal lpName As String) As Long           'api ÅäºÏÑÓ³Ùº¯Êý

    Private Declare Function SetWaitableTimer _
            Lib "kernel32" (ByVal hTimer As Integer,
            lpDueTime As FILETIME,
            ByVal lPeriod As Integer,
            ByVal pfnCompletionRoutine As Integer,
            ByVal lpArgToCompletionRoutine As Integer,
            ByVal fResume As Integer) As Long                 'api ÅäºÏÑÓ³Ùº¯Êý

    Private Declare Function CancelWaitableTimer Lib "kernel32" (ByVal hTimer As Long)

    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Long) As Long

    Private Declare Function WaitForSingleObject _
            Lib "kernel32" (ByVal hHandle As Long,
            ByVal dwMilliseconds As Long) As Long

    Private Declare Function MsgWaitForMultipleObjects _
            Lib "user32" (ByVal nCount As Long,
            pHandles As Long,
            ByVal fWaitAll As Long,
            ByVal dwMilliseconds As Long,
            ByVal dwWakeMask As Long) As Long          'api ÅäºÏÑÓ³Ùº¯Êý

    Private mlTimer As Long
    'ÅäºÏÑÓ³Ùº¯Êý#########################################
    '***************************************
    ''Private Sub Class_Terminate()   '²»Çå³þÊ²Ã´ÓÃÍ¾
    ''    On Error Resume Next
    ''    If mlTimer <> 0 Then CloseHandle mlTimer
    ''End Sub

    Public Sub Delay(HaoMiao As Long)        'Ä¿µÄ£ºÑÓ³Ùº¯Êý  ²ÎÊý£ººÁÃëÊýn
        On Error GoTo ErrHandler
        Dim ft As FILETIME
        Dim lBusy As Long
        Dim lRet As Long
        Dim dblDelay As Double
        Dim dblDelayLow As Double


        mlTimer = CreateWaitableTimer(0, True, Application.ExecutablePath & "Timer" & Format$(Now(), "NNSS"))
        If Err.LastDllError <> ERROR_ALREADY_EXISTS Then
            ft.dwLowDateTime = -1
            ft.dwHighDateTime = -1
            lRet = SetWaitableTimer(mlTimer, ft, 0, 0, 0, 0)
        End If
        dblDelay = CDbl(HaoMiao) * 10000.0#
        ft.dwHighDateTime = -CLng(dblDelay / UNITS) - 1
        dblDelayLow = -UNITS * (dblDelay / UNITS - Fix(CStr(dblDelay / UNITS)))
        If dblDelayLow < MAX_LONG Then dblDelayLow = UNITS + dblDelayLow
        ft.dwLowDateTime = CLng(dblDelayLow)
        lRet = SetWaitableTimer(mlTimer, ft, 0, 0, 0, False)
        Do
            lBusy = MsgWaitForMultipleObjects(1, mlTimer, False, INFINITE, QS_ALLINPUT&)


        Loop Until lBusy = WAIT_OBJECT_0
        CloseHandle(mlTimer)
        mlTimer = 0
        Exit Sub
ErrHandler:

    End Sub





End Module

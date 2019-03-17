Namespace Global
    Namespace CS
        Namespace System
            Namespace IO

                ''' <summary>
                ''' The Share class encapsulate the  WMI Win32_Share class, that represents 
                ''' a shared resource on a computer system running Windows. This may be a disk drive,
                ''' printer, interprocess communication, or other sharable device.
                ''' </summary>
                ''' <remarks>
                ''' Documentation Win32_Share WMI class: 
                ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-share
                ''' </remarks>
                Public Class Share

#Region "PrivateVariables"
                    ' Private Variables to store Attributes of Win32_Share WMI Object
                    Private strCaption As String
                    Private strDescription As String
                    Private dtInstallDate As Date
                    Private strStatus As String
                    Private bolAllowMaximum As Boolean
                    Private intMaximumAllowed As UInteger
                    Private strPath As String
                    Private strShareName As String
                    Private intType As UInteger
#End Region

                    ''' <summary>
                    ''' Creates and returns a new Share object
                    ''' </summary>
                    ''' <param name="SelectedShare">Required. One instance from WMI Win32_Share class as ManagementObject</param>
                    Friend Sub New(SelectedShare As Global.System.Management.ManagementObject)

                        strCaption = SelectedShare("Caption")
                        strDescription = SelectedShare("Description")
                        dtInstallDate = SelectedShare("InstallDate")
                        strStatus = SelectedShare("Status")
                        bolAllowMaximum = SelectedShare("AllowMaximum")
                        intMaximumAllowed = SelectedShare("MaximumAllowed")
                        strPath = SelectedShare("Path")
                        strShareName = SelectedShare("Name")
                        intType = SelectedShare("Type")

                    End Sub

#Region "PublicProperties"
                    ''' <summary>
                    ''' Number of concurrent users for this resource has been limited. If True, 
                    ''' the value in the MaximumAllowed property is ignored.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property AllowMaximum() As Boolean
                        Get
                            If IsNothing(bolAllowMaximum) = True Then
                                Return False
                            Else
                                Return bolAllowMaximum
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' A short textual description of the object.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Caption() As String
                        Get
                            If IsNothing(strCaption) = True Then
                                Return ""
                            Else
                                Return strCaption
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' A textual description of the object.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Description() As String
                        Get
                            If IsNothing(strDescription) = True Then
                                Return ""
                            Else
                                Return strDescription
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Indicates when the object was installed. Lack of a value does not indicate that the 
                    ''' object is not installed.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property InstallDate() As Date
                        Get
                            If IsNothing(dtInstallDate) = True Then
                                Return #01/01/0001#
                            Else
                                Return dtInstallDate
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Limit on the maximum number of users allowed to use this resource concurrently. 
                    ''' The value is only valid if the AllowMaximum property is set to FALSE.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property MaximumAllowed() As UInteger
                        Get
                            If IsNothing(intMaximumAllowed) = True Then
                                Return 0
                            Else
                                Return intMaximumAllowed
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Local path of the Windows share.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Path() As String
                        Get
                            If IsNothing(strPath) = True Then
                                Return ""
                            Else
                                Return strPath
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Alias given to a path set up as a share on a computer system running Windows.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property ShareName() As String
                        Get
                            If IsNothing(strShareName) = True Then
                                Return ""
                            Else
                                Return strShareName
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' String that indicates the current status of the object. Operational and 
                    ''' non-operational status can be defined. Operational status can include "OK", 
                    ''' "Degraded", and "Pred Fail". "Pred Fail" indicates that an element is 
                    ''' functioning properly, but is predicting a failure (for example, a 
                    ''' SMART-enabled hard disk drive). Non-operational status can include "Error", 
                    ''' "Starting", "Stopping", And "Service". "Service" can apply during disk 
                    ''' mirror-resilvering, reloading a user permissions list, Or other 
                    ''' administrative work. Not all such work Is online, but the managed 
                    ''' element Is neither "OK" nor in one of the other states.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Status() As String
                        Get
                            If IsNothing(strStatus) = True Then
                                Return ""
                            Else
                                Return strStatus
                            End If
                        End Get
                    End Property

                    ''' <summary>
                    ''' Type of resource being shared. Types include: disk drives, print queues, 
                    ''' interprocess communications (IPC), and general devices.
                    ''' </summary>
                    ''' <returns></returns>
                    Public ReadOnly Property Type() As UInteger
                        Get
                            If IsNothing(intType) = True Then
                                Return 0
                            Else
                                Return intType
                            End If
                        End Get
                    End Property
#End Region

                End Class

            End Namespace
        End Namespace
    End Namespace
End Namespace
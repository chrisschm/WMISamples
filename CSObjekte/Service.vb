Namespace Global
    Namespace CS
        Namespace System

            ''' <summary>
            ''' The Service class encapsulate the  WMI Win32_Service class, 
            ''' that represents a service on a computer system running Windows.
            ''' </summary>
            ''' <remarks>
            ''' Documentation Win32_Service WMI class: 
            ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-service
            ''' </remarks>
            Public Class Service


#Region "PrivateVariables"
                ' Private Variables to store Attributes of Win32_Service WMI Object
                Private bolAcceptPause As Boolean
                Private bolAcceptStop As Boolean
                Private strCaption As String
                Private intCheckPoint As UInteger
                Private strCreationClassName As String
                Private bolDelayedAutoStart As Boolean
                Private strDescription As String
                Private bolDesktopInteract As Boolean
                Private strDisplayName As String
                Private strErrorControl As String
                Private intExitCode As UInteger
                Private dtInstallDate As Date
                Private strPathName As String
                Private intProcessId As UInteger
                Private strServiceName As String        ' Win32_Service Attributename = Name
                Private intServiceSpecificExitCode As UInteger
                Private strServiceType As String
                Private bolStarted As Boolean
                Private strStartMode As String
                Private strStartName As String
                Private strState As String
                Private strStatus As String
                Private strSystemCreationClassName As String
                Private strSystemName As String
                Private intTagId As UInteger
                Private intWaitHint As UInteger
#End Region

                ''' <summary>
                ''' Creates and returns a new Service object
                ''' </summary>
                ''' <param name="SelectedService">Required. One instance from WMI Win32_Service class as ManagementObject</param>
                Friend Sub New(SelectedService As Global.System.Management.ManagementObject)

                    bolAcceptPause = SelectedService("AcceptPause")
                    bolAcceptStop = SelectedService("AcceptStop")
                    strCaption = SelectedService("Caption")
                    intCheckPoint = SelectedService("CheckPoint")
                    strCreationClassName = SelectedService("CreationClassName")
                    bolDelayedAutoStart = SelectedService("DelayedAutoStart")
                    strDescription = SelectedService("Description")
                    bolDesktopInteract = SelectedService("DesktopInteract")
                    strDisplayName = SelectedService("DisplayName")
                    strErrorControl = SelectedService("ErrorControl")
                    intExitCode = SelectedService("ExitCode")
                    dtInstallDate = SelectedService("InstallDate")
                    strPathName = SelectedService("PathName")
                    intProcessId = SelectedService("ProcessId")
                    strServiceName = SelectedService("Name")
                    intServiceSpecificExitCode = SelectedService("ServiceSpecificExitCode")
                    strServiceType = SelectedService("ServiceType")
                    bolStarted = SelectedService("Started")
                    strStartMode = SelectedService("StartMode")
                    strStartName = SelectedService("StartName")
                    strState = SelectedService("State")
                    strStatus = SelectedService("Status")
                    strSystemCreationClassName = SelectedService("SystemCreationClassName")
                    strSystemName = SelectedService("SystemName")
                    intTagId = SelectedService("TagId")
                    intWaitHint = SelectedService("WaitHint")

                End Sub

#Region "PublicProperties"
                ''' <summary>
                ''' Indicates whether the service can be paused.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property AcceptPause() As Boolean
                    Get
                        If IsNothing(bolAcceptPause) = True Then
                            Return False
                        Else
                            Return bolAcceptPause
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Indicates whether the service can be stopped.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property AcceptStop() As Boolean
                    Get
                        If IsNothing(bolAcceptStop) = True Then
                            Return False
                        Else
                            Return bolAcceptStop
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Short description of the service —a one-line string.
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
                ''' Value that the service increments periodically to report its progress during a long 
                ''' start, stop, pause, or continue operation. For example, the service increments this 
                ''' value as it completes each step of its initialization when it is starting up. The 
                ''' user interface program that invokes the operation on the service uses this value 
                ''' to track the progress of the service during a lengthy operation. This value is 
                ''' not valid and should be zero when the service does not have a start, stop, pause, 
                ''' or continue operation pending.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property CheckPoint() As UInteger
                    Get
                        If IsNothing(intCheckPoint) = True Then
                            Return 0
                        Else
                            Return intCheckPoint
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the first concrete class to appear in the inheritance chain used in the 
                ''' creation of an instance. When used with the other key properties of the class, 
                ''' this property allows all instances of this class and its subclasses to be 
                ''' uniquely identified.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property CreationClassName() As String
                    Get
                        If IsNothing(strCreationClassName) = True Then
                            Return ""
                        Else
                            Return strCreationClassName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the service is started after other auto-start services are started plus a short delay.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property DelayedAutoStart() As Boolean
                    Get
                        If IsNothing(bolDelayedAutoStart) = True Then
                            Return False
                        Else
                            Return bolDelayedAutoStart
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Description of the object.
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
                ''' Indicates whether the service can create or communicate with windows on the desktop, 
                ''' and thus interact in some way with a user. Interactive services must run under the 
                ''' Local System account. Most services are not interactive; that is, they do not 
                ''' communicate with the user in any way.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property DesktopInteract() As Boolean
                    Get
                        If IsNothing(bolDesktopInteract) = True Then
                            Return False
                        Else
                            Return bolDesktopInteract
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the service as viewed in the Services snap-in. This string has a maximum 
                ''' length of 256 characters. Note that the display name and the service name (which 
                ''' is stored in the registry) are not always the same. For example, the DHCP Client 
                ''' service has the service name Dhcp but the display name DHCP Client. The name is 
                ''' case-preserved in the Service Control Manager. However, DisplayName comparisons 
                ''' are always case-insensitive.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property DisplayName() As String
                    Get
                        If IsNothing(strDisplayName) = True Then
                            Return ""
                        Else
                            Return strDisplayName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Severity of the error if this service fails to start during startup. The value indicates 
                ''' the action taken by the startup program if failure occurs. All errors are logged by the 
                ''' computer system.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ErrorControl() As String
                    Get
                        If IsNothing(strErrorControl) = True Then
                            Return ""
                        Else
                            Return strErrorControl
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Windows error code that defines errors encountered in starting or stopping the service. 
                ''' This property is set to ERROR_SERVICE_SPECIFIC_ERROR (1066) when the error is unique to 
                ''' the service represented by this class, and information about the error is available in 
                ''' the ServiceSpecificExitCode property. The service sets this value to NO_ERROR when 
                ''' running, and again upon normal termination.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ExitCode() As UInteger
                    Get
                        If IsNothing(intExitCode) = True Then
                            Return 0
                        Else
                            Return intExitCode
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Date object is installed. This property does not require a value to indicate that the object is installed.
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
                ''' Fully qualified path to the service binary file that implements the service.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property PathName() As String
                    Get
                        If IsNothing(strPathName) = True Then
                            Return ""
                        Else
                            Return strPathName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Process identifier of the service.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ProcessId() As UInteger
                    Get
                        If IsNothing(intProcessId) = True Then
                            Return 0
                        Else
                            Return intProcessId
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Unique identifier of the service that provides an indication of the functionality 
                ''' that is managed. This functionality is described in the Description property of the object.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ServiceName() As String
                    Get
                        If IsNothing(strServiceName) = True Then
                            Return ""
                        Else
                            Return strServiceName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Service-specific error code for errors that occur while the service is either 
                ''' starting or stopping. The exit codes are defined by the service represented by 
                ''' this class. This value is only set when the ExitCode property value is 
                ''' ERROR_SERVICE_SPECIFIC_ERROR (1066).
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ServiceSpecificExitCode() As UInteger
                    Get
                        If IsNothing(intServiceSpecificExitCode) = True Then
                            Return 0
                        Else
                            Return intServiceSpecificExitCode
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Type of service provided to calling processes.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ServiceType() As String
                    Get
                        If IsNothing(strServiceType) = True Then
                            Return ""
                        Else
                            Return strServiceType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Indicates whether or not the service is started.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Started() As Boolean
                    Get
                        If IsNothing(bolStarted) = True Then
                            Return False
                        Else
                            Return bolStarted
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Start mode of the Windows base service.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property StartMode() As String
                    Get
                        If IsNothing(strStartMode) = True Then
                            Return ""
                        Else
                            Return strStartMode
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Account name under which a service runs. Depending on the service type, the account 
                ''' name may be in the form of "DomainName\Username" or UPN format ("*Username@DomainName*"). 
                ''' The service process is logged by using one of these two forms when it runs. If the 
                ''' account belongs to the built-in domain, then ".\Username" can be specified. For kernel 
                ''' or system-level drivers, StartName contains the driver object name (that is, 
                ''' "\FileSystem\Rdr" or "\Driver\Xns") which the I/O system uses to load the device driver. 
                ''' Additionally, if NULL is specified, the driver runs with a default object name created 
                ''' by the I/O system based on the service name.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property StartName() As String
                    Get
                        If IsNothing(strStartName) = True Then
                            Return ""
                        Else
                            Return strStartName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current state of the base service.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property State() As String
                    Get
                        If IsNothing(strState) = True Then
                            Return ""
                        Else
                            Return strState
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current status of the object. Various operational and nonoperational statuses can be 
                ''' defined. Operational statuses include: "OK", "Degraded", and "Pred Fail" (an element, 
                ''' such as a SMART-enabled hard disk drive, may be functioning properly but predicting 
                ''' a failure in the near future). Nonoperational statuses include: "Error", "Starting", 
                ''' "Stopping", and "Service". The latter, "Service", could apply during mirror-resilvering 
                ''' of a disk, reload of a user permissions list, or other administrative work. Not all 
                ''' such work is online, yet the managed element is neither "OK" nor in one of the other states.
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
                ''' Type name of the system that hosts this service.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property SystemCreationClassName() As String
                    Get
                        If IsNothing(strSystemCreationClassName) = True Then
                            Return ""
                        Else
                            Return strSystemCreationClassName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the system that hosts this service.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property SystemName() As String
                    Get
                        If IsNothing(strSystemName) = True Then
                            Return ""
                        Else
                            Return strSystemName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Unique tag value for this service in the group. A value of 0 (zero) indicates that the 
                ''' service does not have a tag. A tag can be used to order service startup within a load 
                ''' order group by specifying a tag order vector in the registry located at: 
                ''' HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\    GroupOrderList 
                ''' Tags are only evaluated For Kernel Driver And File System Driver start type services 
                ''' that have Boot Or System start modes.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property TagId() As UInteger
                    Get
                        If IsNothing(intTagId) = True Then
                            Return 0
                        Else
                            Return intTagId
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Estimated time required, in milliseconds, for a pending start, stop, pause, or continue 
                ''' operation. After the specified time has elapsed, the service makes its next call to the 
                ''' SetServiceStatus method with either an incremented CheckPoint value or a change in 
                ''' CurrentState. If the amount of time specified by WaitHint passes, and CheckPoint has 
                ''' not been incremented, or CurrentState has not changed, the service control manager or 
                ''' service control program assumes that an error has occurred.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property WaitHint() As UInteger
                    Get
                        If IsNothing(intWaitHint) = True Then
                            Return 0
                        Else
                            Return intWaitHint
                        End If
                    End Get
                End Property
#End Region

            End Class

        End Namespace
    End Namespace
End Namespace
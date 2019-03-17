Namespace Global
    Namespace CS
        Namespace System

            ''' <summary>
            ''' The ComputerSystem class encapsulate the  WMI Win32_ComputerSystem class, 
            ''' that represents a computer system running Windows.
            ''' </summary>
            ''' <remarks>
            ''' Documentation Win32_ComputerSystem WMI class: 
            ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-computersystem
            ''' </remarks>
            Public Class ComputerSystem

#Region "PrivateVariables"
                ' Private Variables to store Attributes of Win32_ComputerSystem WMI Object
                Private srtAdminPasswordStatus As UShort
                Private bolAutomaticManagedPagefile As Boolean
                Private bolAutomaticResetBootOption As Boolean
                Private bolAutomaticResetCapability As Boolean
                Private srtBootOptionOnLimit As UShort
                Private srtBootOptionOnWatchDog As UShort
                Private bolBootROMSupported As Boolean
                Private strBootupState As String
                Private srtBootStatus() As UShort
                Private strCaption As String
                Private srtChassisBootupState As UShort
                Private strChassisSKUNumber As String
                Private strComputerName As String         'WMI Attribute name = Name
                Private strCreationClassName As String
                Private srtCurrentTimeZone As Short
                Private bolDaylightInEffect As Boolean
                Private strDescription As String
                Private strDNSHostName As String
                Private strDomain As String
                Private srtDomainRole As UShort
                Private bolEnableDaylightSavingsTime As Boolean
                Private srtFrontPanelResetStatus As UShort
                Private bolHypervisorPresent As Boolean
                Private bolInfraredSupported As Boolean
                Private strInitialLoadInfo() As String
                Private dtInstallDate As Date
                Private srtKeyboardPasswordStatus As UShort
                Private strLastLoadInfo As String
                Private strManufacturer As String
                Private strModel As String
                Private strNameFormat As String
                Private bolNetworkServerModeEnabled As Boolean
                Private intNumberOfLogicalProcessors As UInteger
                Private intNumberOfProcessors As UInteger
                Private bytOEMLogoBitmap() As Byte          'UInt8
                Private strOEMStringArray() As String
                Private bolPartOfDomain As Boolean
                Private lngPauseAfterReset As Long
                Private srtPCSystemType As UShort
                Private srtPCSystemTypeEx As UShort
                Private srtPowerManagementCapabilities() As UShort
                Private bolPowerManagementSupported As Boolean
                Private srtPowerOnPasswordStatus As UShort
                Private srtPowerState As UShort
                Private srtPowerSupplyState As UShort
                Private strPrimaryOwnerContact As String
                Private strPrimaryOwnerName As String
                Private srtResetCapability As UShort
                Private srtResetCount As Short
                Private srtResetLimit As Short
                Private strRoles() As String
                Private strStatus As String
                Private strSupportContactDescription() As String
                Private strSystemFamily As String
                Private strSystemSKUNumber As String
                Private strSystemType As String
                Private srtThermalState As UShort
                Private lngTotalPhysicalMemory As ULong
                Private strUserName As String
                Private srtWakeUpType As UShort
                Private strWorkgroup As String

                ' Other private variables
                Private bolSingleInstance As Boolean = True
#End Region

                ''' <summary>
                ''' Creates and returns a new ComputerSystem object
                ''' </summary>
                Public Sub New()

                    Dim i As Integer
                    Dim mosCSs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")

                    i = mosCSs.Get.Count
                    Select Case i
                        Case 0
                            bolSingleInstance = False
                            Throw New Exception("No Result in WMI Query")
                        Case 1
                            Dim mosCS As Global.System.Management.ManagementObject = mosCSs.[Get](0)

                            srtAdminPasswordStatus = mosCS("AdminPasswordStatus")
                            bolAutomaticManagedPagefile = mosCS("AutomaticManagedPagefile")
                            bolAutomaticResetBootOption = mosCS("AutomaticResetBootOption")
                            bolAutomaticResetCapability = mosCS("AutomaticResetCapability")
                            srtBootOptionOnLimit = mosCS("BootOptionOnLimit")
                            srtBootOptionOnWatchDog = mosCS("BootOptionOnWatchDog")
                            bolBootROMSupported = mosCS("BootROMSupported")
                            strBootupState = mosCS("BootupState")
                            srtBootStatus = mosCS("BootStatus")
                            strCaption = mosCS("Caption")
                            srtChassisBootupState = mosCS("ChassisBootupState")
                            strChassisSKUNumber = mosCS("ChassisSKUNumber")
                            strComputerName = mosCS("Name")
                            strCreationClassName = mosCS("CreationClassName")
                            srtCurrentTimeZone = mosCS("CurrentTimeZone")
                            bolDaylightInEffect = mosCS("DaylightInEffect")
                            strDescription = mosCS("Description")
                            strDNSHostName = mosCS("DNSHostName")
                            strDomain = mosCS("Domain")
                            srtDomainRole = mosCS("DomainRole")
                            bolEnableDaylightSavingsTime = mosCS("EnableDaylightSavingsTime")
                            srtFrontPanelResetStatus = mosCS("FrontPanelResetStatus")
                            bolHypervisorPresent = mosCS("HypervisorPresent")
                            bolInfraredSupported = mosCS("InfraredSupported")
                            strInitialLoadInfo = mosCS("InitialLoadInfo")
                            dtInstallDate = mosCS("InstallDate")
                            srtKeyboardPasswordStatus = mosCS("KeyboardPasswordStatus")
                            strLastLoadInfo = mosCS("LastLoadInfo")
                            strManufacturer = mosCS("Manufacturer")
                            strModel = mosCS("Model")
                            strNameFormat = mosCS("NameFormat")
                            bolNetworkServerModeEnabled = mosCS("NetworkServerModeEnabled")
                            intNumberOfLogicalProcessors = mosCS("NumberOfLogicalProcessors")
                            intNumberOfProcessors = mosCS("NumberOfProcessors")
                            bytOEMLogoBitmap = mosCS("OEMLogoBitmap")
                            strOEMStringArray = mosCS("OEMStringArray")
                            bolPartOfDomain = mosCS("PartOfDomain")
                            lngPauseAfterReset = mosCS("PauseAfterReset")
                            srtPCSystemType = mosCS("PCSystemType")
                            srtPCSystemTypeEx = mosCS("PCSystemTypeEx")
                            srtPowerManagementCapabilities = mosCS("PowerManagementCapabilities")
                            bolPowerManagementSupported = mosCS("PowerManagementSupported")
                            srtPowerOnPasswordStatus = mosCS("PowerOnPasswordStatus")
                            srtPowerState = mosCS("PowerState")
                            srtPowerSupplyState = mosCS("PowerSupplyState")
                            strPrimaryOwnerContact = mosCS("PrimaryOwnerContact")
                            strPrimaryOwnerName = mosCS("PrimaryOwnerName")
                            srtResetCapability = mosCS("ResetCapability")
                            srtResetCount = mosCS("ResetCount")
                            srtResetLimit = mosCS("ResetLimit")
                            strRoles = mosCS("Roles")
                            strStatus = mosCS("Status")
                            strSupportContactDescription = mosCS("SupportContactDescription")
                            strSystemFamily = mosCS("SystemFamily")
                            strSystemSKUNumber = mosCS("SystemSKUNumber")
                            strSystemType = mosCS("SystemType")
                            srtThermalState = mosCS("ThermalState")
                            lngTotalPhysicalMemory = mosCS("TotalPhysicalMemory")
                            strUserName = mosCS("UserName")
                            srtWakeUpType = mosCS("WakeUpType")
                            strWorkgroup = mosCS("Workgroup")
                        Case Else
                            bolSingleInstance = False
                    End Select

                End Sub

#Region "PublicProperties"
                ''' <summary>
                ''' System hardware security settings for administrator password status.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property AdminPasswordStatus() As UShort
                    Get
                        If IsNothing(srtAdminPasswordStatus) = True Then
                            Return 0
                        Else
                            Return srtAdminPasswordStatus
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the system manages the page file.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property AutomaticManagedPagefile() As Boolean
                    Get
                        If IsNothing(bolAutomaticManagedPagefile) = True Then
                            Return False
                        Else
                            Return bolAutomaticManagedPagefile
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the automatic reset boot option is enabled.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property AutomaticResetBootOption() As Boolean
                    Get
                        If IsNothing(bolAutomaticResetBootOption) = True Then
                            Return False
                        Else
                            Return bolAutomaticResetBootOption
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the automatic reset is enabled.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property AutomaticResetCapability() As Boolean
                    Get
                        If IsNothing(bolAutomaticResetCapability) = True Then
                            Return False
                        Else
                            Return bolAutomaticResetCapability
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Boot option limit is ON. Identifies the system action when the ResetLimit value is reached.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property BootOptionOnLimit() As UShort
                    Get
                        If IsNothing(srtBootOptionOnLimit) = True Then
                            Return 0
                        Else
                            Return srtBootOptionOnLimit
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Type of reboot action after the time on the watchdog timer is elapsed.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property BootOptionOnWatchDog() As UShort
                    Get
                        If IsNothing(srtBootOptionOnWatchDog) = True Then
                            Return 0
                        Else
                            Return srtBootOptionOnWatchDog
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, indicates whether a boot ROM is supported.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property BootROMSupported() As Boolean
                    Get
                        If IsNothing(bolBootROMSupported) = True Then
                            Return False
                        Else
                            Return bolBootROMSupported
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Status and Additional Data fields that identify the boot status.
                ''' </summary>
                ''' <returns>UShort array</returns>
                Public ReadOnly Property BootStatus() As UShort()
                    Get
                        If IsNothing(srtBootStatus) = True Then
                            Return {0}
                        Else
                            Return srtBootStatus
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' System is started. Fail-safe boot bypasses the user startup files also called SafeBoot.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property BootupState() As String
                    Get
                        If IsNothing(strBootupState) = True Then
                            Return ""
                        Else
                            Return strBootupState
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Short description of the object a one-line string.
                ''' </summary>
                ''' <returns>String</returns>
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
                ''' Boot up state of the chassis.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property ChassisBootupState() As UShort
                    Get
                        If IsNothing(srtChassisBootupState) = True Then
                            Return 0
                        Else
                            Return srtChassisBootupState
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The chassis or enclosure SKU number as a string.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property ChassisSKUNumber() As String
                    Get
                        If IsNothing(strChassisSKUNumber) = True Then
                            Return ""
                        Else
                            Return strChassisSKUNumber
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Key of a CIM_System instance in an enterprise environment.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property ComputerName() As String
                    Get
                        If IsNothing(strComputerName) = True Then
                            Return ""
                        Else
                            Return strComputerName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the first concrete class in the inheritance chain of an instance. 
                ''' You can use this property with other properties of the class to identify 
                ''' all instances of the class and its subclasses.
                ''' </summary>
                ''' <returns>String</returns>
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
                ''' Amount of time the unitary computer system is offset from Coordinated Universal Time (UTC).
                ''' </summary>
                ''' <returns>Short</returns>
                Public ReadOnly Property CurrentTimeZone() As Short
                    Get
                        If IsNothing(srtCurrentTimeZone) = True Then
                            Return 0
                        Else
                            Return srtCurrentTimeZone
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the daylight savings mode is ON.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property DaylightInEffect() As Boolean
                    Get
                        If IsNothing(bolDaylightInEffect) = True Then
                            Return False
                        Else
                            Return bolDaylightInEffect
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Description of the object.
                ''' </summary>
                ''' <returns>String</returns>
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
                ''' Name of local computer according to the domain name server (DNS).
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property DNSHostName() As String
                    Get
                        If IsNothing(strDNSHostName) = True Then
                            Return ""
                        Else
                            Return strDNSHostName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the domain to which a computer belongs.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Domain() As String
                    Get
                        If IsNothing(strDomain) = True Then
                            Return ""
                        Else
                            Return strDomain
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Role of a computer in an assigned domain workgroup. A domain workgroup is 
                ''' a collection of computers on the same network. For example, a DomainRole 
                ''' property may show that a computer is a member workstation.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property DomainRole() As UShort
                    Get
                        If IsNothing(srtDomainRole) = True Then
                            Return 0
                        Else
                            Return srtDomainRole
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Enables daylight savings time (DST) on a computer. A value of True indicates 
                ''' that the system time changes to an hour ahead or behind when DST starts or 
                ''' ends. A value of False indicates that the system time does not change to an 
                ''' hour ahead or behind when DST starts or ends. A value of NULL indicates that 
                ''' the DST status is unknown on a system.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property EnableDaylightSavingsTime() As Boolean
                    Get
                        If IsNothing(bolEnableDaylightSavingsTime) = True Then
                            Return False
                        Else
                            Return bolEnableDaylightSavingsTime
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The following table lists the hardware security settings for the reset button on a computer.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property FrontPanelResetStatus() As UShort
                    Get
                        If IsNothing(srtFrontPanelResetStatus) = True Then
                            Return 0
                        Else
                            Return srtFrontPanelResetStatus
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, a hypervisor is present.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property HypervisorPresent() As Boolean
                    Get
                        If IsNothing(bolHypervisorPresent) = True Then
                            Return False
                        Else
                            Return bolHypervisorPresent
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, an infrared (IR) port exists on a computer system.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property InfraredSupported() As Boolean
                    Get
                        If IsNothing(bolInfraredSupported) = True Then
                            Return False
                        Else
                            Return bolInfraredSupported
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Data required to find the initial load device or boot service to 
                ''' request that the operating system start up.
                ''' </summary>
                ''' <returns>String array</returns>
                Public ReadOnly Property InitialLoadInfo() As String()
                    Get
                        If IsNothing(strInitialLoadInfo) = True Then
                            Return {""}
                        Else
                            Return strInitialLoadInfo
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Object is installed. An object does not need a value to indicate that it is installed.
                ''' </summary>
                ''' <returns>DateTime</returns>
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
                ''' System hardware security settings for Keyboard Password Status.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property KeyboardPasswordStatus() As UShort
                    Get
                        If IsNothing(srtKeyboardPasswordStatus) = True Then
                            Return 0
                        Else
                            Return srtKeyboardPasswordStatus
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Array entry of the InitialLoadInfo property that contains the 
                ''' data to start the loaded operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property LastLoadInfo() As String
                    Get
                        If IsNothing(strLastLoadInfo) = True Then
                            Return ""
                        Else
                            Return strLastLoadInfo
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of a computer manufacturer.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Manufacturer() As String
                    Get
                        If IsNothing(strManufacturer) = True Then
                            Return ""
                        Else
                            Return strManufacturer
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Product name that a manufacturer gives to a computer. This property must have a value.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Model() As String
                    Get
                        If IsNothing(strModel) = True Then
                            Return ""
                        Else
                            Return strModel
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Computer system Name value that is generated automatically.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property NameFormat() As String
                    Get
                        If IsNothing(strNameFormat) = True Then
                            Return ""
                        Else
                            Return strNameFormat
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the network Server Mode is enabled.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property NetworkServerModeEnabled() As Boolean
                    Get
                        If IsNothing(bolNetworkServerModeEnabled) = True Then
                            Return False
                        Else
                            Return bolNetworkServerModeEnabled
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of logical processors available on the computer.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property NumberOfLogicalProcessors() As UInteger
                    Get
                        If IsNothing(intNumberOfLogicalProcessors) = True Then
                            Return 0
                        Else
                            Return intNumberOfLogicalProcessors
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of physical processors currently available on a system. This is the number 
                ''' of enabled processors for a system, which does not include the disabled processors. 
                ''' If a computer system has two physical processors each containing two logical 
                ''' processors, then the value of NumberOfProcessors is 2 and NumberOfLogicalProcessors 
                ''' is 4. The processors may be multicore or they may be hyperthreading processors.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property NumberOfProcessors() As UInteger
                    Get
                        If IsNothing(intNumberOfProcessors) = True Then
                            Return 0
                        Else
                            Return intNumberOfProcessors
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' List of data for a bitmap that the original equipment manufacturer (OEM) creates.
                ''' </summary>
                ''' <returns>Byte array</returns>
                Public ReadOnly Property OEMLogoBitmap() As Byte()
                    Get
                        If IsNothing(bytOEMLogoBitmap) = True Then
                            Return {0}
                        Else
                            Return bytOEMLogoBitmap
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' List of free-form strings that an OEM defines. For example, an OEM defines the part 
                ''' numbers for system reference documents, manufacturer contact information, and so on.
                ''' </summary>
                ''' <returns>String array</returns>
                Public ReadOnly Property OEMStringArray() As String()
                    Get
                        If IsNothing(strOEMStringArray) = True Then
                            Return {""}
                        Else
                            Return strOEMStringArray
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the computer is part of a domain.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property PartOfDomain() As Boolean
                    Get
                        If IsNothing(bolPartOfDomain) = True Then
                            Return False
                        Else
                            Return bolPartOfDomain
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Time delay before a reboot is initiated in milliseconds. It is used after 
                ''' a system power cycle, local or remote system reset, and automatic system 
                ''' reset. A value of 1 (minus one) indicates that the pause value is unknown.
                ''' </summary>
                ''' <returns>Long</returns>
                Public ReadOnly Property PauseAfterReset() As Long
                    Get
                        If IsNothing(lngPauseAfterReset) = True Then
                            Return 0
                        Else
                            Return lngPauseAfterReset
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Type of the computer in use, such as laptop, desktop, or Tablet.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property PCSystemType() As UShort
                    Get
                        If IsNothing(srtPCSystemType) = True Then
                            Return 0
                        Else
                            Return srtPCSystemType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Type of the computer in use, such as laptop, desktop, or Tablet.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property PCSystemTypeEx() As UShort
                    Get
                        If IsNothing(srtPCSystemTypeEx) = True Then
                            Return 0
                        Else
                            Return srtPCSystemTypeEx
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Array of the specific power-related capabilities of a logical device.
                ''' </summary>
                ''' <returns>UShort array</returns>
                Public ReadOnly Property PowerManagementCapabilities() As UShort()
                    Get
                        If IsNothing(srtPowerManagementCapabilities) = True Then
                            Return {0}
                        Else
                            Return srtPowerManagementCapabilities
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, device can be power-managed, for example, a device can be put into 
                ''' suspend mode, and so on. This property does not indicate that power management 
                ''' features are enabled currently, but it does indicate that the logical device 
                ''' is capable of power management.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property PowerManagementSupported() As Boolean
                    Get
                        If IsNothing(bolPowerManagementSupported) = True Then
                            Return False
                        Else
                            Return bolPowerManagementSupported
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' System hardware security settings for Power-On Password Status.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property PowerOnPasswordStatus() As UShort
                    Get
                        If IsNothing(srtPowerOnPasswordStatus) = True Then
                            Return 0
                        Else
                            Return srtPowerOnPasswordStatus
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current power state of a computer and its associated operating system. The power 
                ''' saving states have the following values: Value 4 (Unknown) indicates that the 
                ''' system is known to be in a power save mode, but its exact status in this mode 
                ''' is unknown; 2 (Low Power Mode) indicates that the system is in a power save 
                ''' state, but still functioning and may exhibit degraded performance; 3 (Standby) 
                ''' indicates that the system is not functioning, but could be brought to full 
                ''' power quickly; and 7 (Warning) indicates that the computer system is in a 
                ''' warning state and a power save mode.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property PowerState() As UShort
                    Get
                        If IsNothing(srtPowerState) = True Then
                            Return 0
                        Else
                            Return srtPowerState
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' State of the power supply or supplies when last booted.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property PowerSupplyState() As UShort
                    Get
                        If IsNothing(srtPowerSupplyState) = True Then
                            Return 0
                        Else
                            Return srtPowerSupplyState
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Contact information for the primary system owner, for example, phone number, email address, and so on.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property PrimaryOwnerContact() As String
                    Get
                        If IsNothing(strPrimaryOwnerContact) = True Then
                            Return ""
                        Else
                            Return strPrimaryOwnerContact
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the primary system owner.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property PrimaryOwnerName() As String
                    Get
                        If IsNothing(strPrimaryOwnerName) = True Then
                            Return ""
                        Else
                            Return strPrimaryOwnerName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If enabled, the value is 4 and the unitary computer system can be reset using 
                ''' the power and reset buttons. If disabled, the value is 3, and a reset is not allowed.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property ResetCapability() As UShort
                    Get
                        If IsNothing(srtResetCapability) = True Then
                            Return 0
                        Else
                            Return srtResetCapability
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of automatic resets since the last reset. A value of 1 (minus one) indicates that the count is unknown.
                ''' </summary>
                ''' <returns>Short</returns>
                Public ReadOnly Property ResetCount() As Short
                    Get
                        If IsNothing(srtResetLimit) = True Then
                            Return 0
                        Else
                            Return srtResetLimit
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of consecutive times a system reset is attempted. A value of 1 (minus one) 
                ''' indicates that the limit is unknown.
                ''' </summary>
                ''' <returns>Short</returns>
                Public ReadOnly Property ResetLimit() As Short
                    Get
                        If IsNothing(srtResetLimit) = True Then
                            Return 0
                        Else
                            Return srtResetLimit
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' List that specifies the roles of a system in the information technology environment.
                ''' </summary>
                ''' <returns>String array</returns>
                Public ReadOnly Property Roles() As String()
                    Get
                        If IsNothing(strRoles) = True Then
                            Return {""}
                        Else
                            Return strRoles
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current status of an object. Various operational and nonoperational statuses can 
                ''' be defined. Operational statuses include: OK, Degraded, and Pred Fail, which is 
                ''' an element such as a SMART-enabled hard disk drive that may be functioning properly, 
                ''' but predicts a failure in the near future. Nonoperational statuses include: Error, 
                ''' Starting, Stopping, and Service, which can apply during mirror-resilvering of a 
                ''' disk, reloading a user permissions list, or other administrative work. Not all 
                ''' status work is online, but the managed element is not OK or in one of the other states.
                ''' </summary>
                ''' <returns>String</returns>
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
                ''' List of the support contact information for the Windows operating system.
                ''' </summary>
                ''' <returns>String array</returns>
                Public ReadOnly Property SupportContactDescription() As String()
                    Get
                        If IsNothing(strSupportContactDescription) = True Then
                            Return {""}
                        Else
                            Return strSupportContactDescription
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The family to which a particular computer belongs. A family refers to a set of 
                ''' computers that are similar but not identical from a hardware or software point of view.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SystemFamily() As String
                    Get
                        If IsNothing(strSystemFamily) = True Then
                            Return ""
                        Else
                            Return strSystemFamily
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Identifies a particular computer configuration for sale. It is sometimes also called a product ID or purchase order number.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SystemSKUNumber() As String
                    Get
                        If IsNothing(strSystemSKUNumber) = True Then
                            Return ""
                        Else
                            Return strSystemSKUNumber
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' System running on the Windows-based computer. This property must have a value.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SystemType() As String
                    Get
                        If IsNothing(strSystemType) = True Then
                            Return ""
                        Else
                            Return strSystemType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Thermal state of the system when last booted.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property ThermalState() As UShort
                    Get
                        If IsNothing(srtThermalState) = True Then
                            Return 0
                        Else
                            Return srtThermalState
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Total size of physical memory. Be aware that, under some circumstances, this 
                ''' property may not return an accurate value for the physical memory. For example, 
                ''' it is not accurate if the BIOS is using some of the physical memory.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property TotalPhysicalMemory() As ULong
                    Get
                        If IsNothing(lngTotalPhysicalMemory) = True Then
                            Return 0
                        Else
                            Return lngTotalPhysicalMemory
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of a user that is logged on currently. This property must have a value. In 
                ''' a terminal services session, UserName returns the name of the user that is logged 
                ''' on to the console not the user logged on during the terminal service session.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property UserName() As String
                    Get
                        If IsNothing(strUserName) = True Then
                            Return ""
                        Else
                            Return strUserName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Event that causes the system to power up.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property WakeUpType() As UShort
                    Get
                        If IsNothing(srtWakeUpType) = True Then
                            Return 0
                        Else
                            Return srtWakeUpType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the workgroup for this computer. If the value of the PartOfDomain 
                ''' property is False, then the name of the workgroup is returned.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Workgroup() As String
                    Get
                        If IsNothing(strWorkgroup) = True Then
                            Return ""
                        Else
                            Return strWorkgroup
                        End If
                    End Get
                End Property
#End Region

            End Class

        End Namespace
    End Namespace
End Namespace
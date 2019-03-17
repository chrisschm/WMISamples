Namespace Global
    Namespace CS
        Namespace System

            ''' <summary>
            ''' The OperatingSystem class encapsulate the  WMI Win32_OperatingSystem class, 
            ''' that represents a Windows-based operating system installed on a computer.
            ''' </summary>
            ''' <remarks>
            ''' Documentation Win32_OperatingSystem WMI class: 
            ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-operatingsystem
            ''' </remarks>
            Public Class OperatingSystem

#Region "PrivateVariables"
                ' Private Variables to store Attributes of Win32_OperatingSystem WMI Object
                Private strBootDevice As String
                Private strBuildNumber As String
                Private strBuildType As String
                Private strCaption As String
                Private strCodeSet As String
                Private strCountryCode As String
                Private strCreationClassName As String
                Private strCSCreationClassName As String
                Private strCSDVersion As String
                Private strCSName As String
                Private srtCurrentTimeZone As Short
                Private bolDataExecutionPrevention_Available As Boolean
                Private bolDataExecutionPrevention_32BitApplications As Boolean
                Private bolDataExecutionPrevention_Drivers As Boolean
                Private bytDataExecutionPrevention_SupportPolicy As Byte    'uint8
                Private bolDebug As Boolean
                Private strDescription As String
                Private bolDistributed As Boolean
                Private intEncryptionLevel As UInteger
                Private bytForegroundApplicationBoost As Byte               'uint8
                Private lngFreePhysicalMemory As ULong
                Private lngFreeSpaceInPagingFiles As ULong
                Private lngFreeVirtualMemory As ULong
                Private dtInstallDate As Date
                Private dtLastBootUpTime As Date
                Private dtLocalDateTime As Date
                Private strLocale As String
                Private strManufacturer As String
                Private intMaxNumberOfProcesses As UInteger
                Private lngMaxProcessMemorySize As ULong
                Private strMUILanguages() As String
                Private intNumberOfLicensedUsers As UInteger
                Private intNumberOfProcesses As UInteger
                Private intNumberOfUsers As UInteger
                Private intOperatingSystemSKU As UInteger
                Private strOrganization As String
                Private strOSArchitecture As String
                Private intOSLanguage As UInteger
                Private strOSName As String
                Private intOSProductSuite As UInteger
                Private srtOSType As UShort
                Private strOtherTypeDescription As String
                Private bolPAEEnabled As Boolean
                Private bolPortableOperatingSystem As Boolean
                Private bolPrimary As Boolean
                Private intProductType As UInteger
                Private strRegisteredUser As String
                Private strSerialNumber As String
                Private srtServicePackMajorVersion As UShort
                Private srtServicePackMinorVersion As UShort
                Private lngSizeStoredInPagingFiles As ULong
                Private strStatus As String
                Private intSuiteMask As UInteger
                Private strSystemDevice As String
                Private strSystemDirectory As String
                Private strSystemDrive As String
                Private lngTotalSwapSpaceSize As ULong
                Private lngTotalVirtualMemorySize As ULong
                Private lngTotalVisibleMemorySize As ULong
                Private strVersion As String
                Private strWindowsDirectory As String
                Private bytQuantumLength As Byte                            'UInt8
                Private bytQuantumType As Byte                              'UInt8

                ' Other private variables
                Private bolSingleInstance As Boolean = True
#End Region

                ''' <summary>
                ''' Creates and returns a new OperatingSystem object
                ''' </summary>
                Public Sub New()

                    Dim i As Integer
                    Dim mosOSs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")

                    i = mosOSs.Get.Count
                    Select Case i
                        Case 0
                            bolSingleInstance = False
                            Throw New Exception("No Result in WMI Query")
                        Case 1
                            Dim mosOS As Global.System.Management.ManagementObject = mosOSs.[Get](0)

                            strBootDevice = mosOS("BootDevice")
                            strBuildNumber = mosOS("BuildNumber")
                            strBuildType = mosOS("BuildType")
                            strCaption = mosOS("Caption")
                            strCodeSet = mosOS("CodeSet")
                            strCountryCode = mosOS("CountryCode")
                            strCreationClassName = mosOS("CreationClassName")
                            strCSCreationClassName = mosOS("CSCreationClassName")
                            strCSDVersion = mosOS("CSDVersion")
                            strCSName = mosOS("CSName")
                            srtCurrentTimeZone = mosOS("CurrentTimeZone")
                            bolDataExecutionPrevention_Available = mosOS("DataExecutionPrevention_Available")
                            bolDataExecutionPrevention_32BitApplications = mosOS("DataExecutionPrevention_32BitApplications")
                            bolDataExecutionPrevention_Drivers = mosOS("DataExecutionPrevention_Drivers")
                            bytDataExecutionPrevention_SupportPolicy = mosOS("DataExecutionPrevention_SupportPolicy")
                            bolDebug = mosOS("Debug")
                            strDescription = mosOS("Description")
                            bolDistributed = mosOS("Distributed")
                            intEncryptionLevel = mosOS("EncryptionLevel")
                            bytForegroundApplicationBoost = mosOS("ForegroundApplicationBoost")
                            lngFreePhysicalMemory = mosOS("FreePhysicalMemory")
                            lngFreeSpaceInPagingFiles = mosOS("FreeSpaceInPagingFiles")
                            lngFreeVirtualMemory = mosOS("FreeVirtualMemory")
                            dtInstallDate = GetReleaseDate(mosOS("InstallDate").ToString)
                            dtLastBootUpTime = GetReleaseDate(mosOS("LastBootUpTime").ToString)
                            dtLocalDateTime = GetReleaseDate(mosOS("LocalDateTime").ToString)
                            strLocale = mosOS("Locale")
                            strManufacturer = mosOS("Manufacturer")
                            intMaxNumberOfProcesses = mosOS("MaxNumberOfProcesses")
                            lngMaxProcessMemorySize = mosOS("MaxProcessMemorySize")
                            strMUILanguages = mosOS("MUILanguages")
                            intNumberOfLicensedUsers = mosOS("NumberOfLicensedUsers")
                            intNumberOfProcesses = mosOS("NumberOfProcesses")
                            intNumberOfUsers = mosOS("NumberOfUsers")
                            intOperatingSystemSKU = mosOS("OperatingSystemSKU")
                            strOrganization = mosOS("Organization")
                            strOSArchitecture = mosOS("OSArchitecture")
                            intOSLanguage = mosOS("OSLanguage")
                            strOSName = mosOS("Name")
                            intOSProductSuite = mosOS("OSProductSuite")
                            srtOSType = mosOS("OSType")
                            strOtherTypeDescription = mosOS("OtherTypeDescription")
                            bolPAEEnabled = mosOS("PAEEnabled")
                            bolPortableOperatingSystem = mosOS("PortableOperatingSystem")
                            bolPrimary = mosOS("Primary")
                            intProductType = mosOS("ProductType")
                            strRegisteredUser = mosOS("RegisteredUser")
                            strSerialNumber = mosOS("SerialNumber")
                            srtServicePackMajorVersion = mosOS("ServicePackMajorVersion")
                            srtServicePackMinorVersion = mosOS("ServicePackMinorVersion")
                            lngSizeStoredInPagingFiles = mosOS("SizeStoredInPagingFiles")
                            strStatus = mosOS("Status")
                            intSuiteMask = mosOS("SuiteMask")
                            strSystemDevice = mosOS("SystemDevice")
                            strSystemDirectory = mosOS("SystemDirectory")
                            strSystemDrive = mosOS("SystemDrive")
                            lngTotalSwapSpaceSize = mosOS("TotalSwapSpaceSize")
                            lngTotalVirtualMemorySize = mosOS("TotalVirtualMemorySize")
                            lngTotalVisibleMemorySize = mosOS("TotalVisibleMemorySize")
                            strVersion = mosOS("Version")
                            strWindowsDirectory = mosOS("WindowsDirectory")
                        Case Else
                            bolSingleInstance = False
                    End Select

                End Sub

#Region "PublicProperties"
                ''' <summary>
                ''' Name of the disk drive from which the Windows operating system starts.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property BootDevice() As String
                    Get
                        If IsNothing(strBootDevice) = True Then
                            Return ""
                        Else
                            Return strBootDevice
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Build number of an operating system. It can be used for more precise version 
                ''' information than product release version numbers.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property BuildNumber() As String
                    Get
                        If IsNothing(strBuildNumber) = True Then
                            Return ""
                        Else
                            Return strBuildNumber
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Type of build used for an operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property BuildType() As String
                    Get
                        If IsNothing(strBuildType) = True Then
                            Return ""
                        Else
                            Return strBuildType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Short description of the object—a one-line string. The string includes the 
                ''' operating system version. For example, "Microsoft Windows 7 Enterprise ". 
                ''' This property can be localized.
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
                ''' Code page value an operating system uses. A code page contains a character table 
                ''' that an operating system uses to translate strings for different languages. The 
                ''' American National Standards Institute (ANSI) lists values that represent defined 
                ''' code pages. If an operating system does not use an ANSI code page, this member 
                ''' is set to 0 (zero). The CodeSet string can use a maximum of six characters to 
                ''' define the code page value.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property CodeSet() As String
                    Get
                        If IsNothing(strCodeSet) = True Then
                            Return ""
                        Else
                            Return strCodeSet
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Code for the country/region that an operating system uses. Values are based 
                ''' on international phone dialing prefixes—also referred to as IBM country/region codes. 
                ''' This property can use a maximum of six characters to define the country/region code value.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property CountryCode() As String
                    Get
                        If IsNothing(strCountryCode) = True Then
                            Return ""
                        Else
                            Return strCountryCode
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the first concrete class that appears in the inheritance chain used 
                ''' in the creation of an instance. When used with other key properties of the 
                ''' class, this property allows all instances of this class and its subclasses 
                ''' to be identified uniquely.
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
                ''' Creation class name of the scoping computer system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property CSCreationClassName() As String
                    Get
                        If IsNothing(strCSCreationClassName) = True Then
                            Return ""
                        Else
                            Return strCSCreationClassName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' String that indicates the latest service pack installed on a computer.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property CSDVersion() As String
                    Get
                        If IsNothing(strCSDVersion) = True Then
                            Return ""
                        Else
                            Return strCSDVersion
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the scoping computer system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property CSName() As String
                    Get
                        If IsNothing(strCSName) = True Then
                            Return ""
                        Else
                            Return strCSName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number, in minutes, an operating system is offset from Greenwich mean time (GMT). 
                ''' The number is positive, negative, or zero.
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
                ''' Data execution prevention is a hardware feature to prevent buffer overrun attacks 
                ''' by stopping the execution of code on data-type memory pages. If True, then this 
                ''' feature is available. On 64-bit computers, the data execution prevention feature 
                ''' is configured in the BCD store and the properties in Win32_OperatingSystem are 
                ''' set accordingly.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property DataExecutionPrevention_Available() As Boolean
                    Get
                        If IsNothing(bolDataExecutionPrevention_Available) = True Then
                            Return False
                        Else
                            Return bolDataExecutionPrevention_Available
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' When the data execution prevention hardware feature is available, this property 
                ''' indicates that the feature is set to work for 32-bit applications if True. 
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property DataExecutionPrevention_32BitApplications() As Boolean
                    Get
                        If IsNothing(bolDataExecutionPrevention_32BitApplications) = True Then
                            Return False
                        Else
                            Return bolDataExecutionPrevention_32BitApplications
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' When the data execution prevention hardware feature is available, this 
                ''' property indicates that the feature is set to work for drivers if True.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property DataExecutionPrevention_Drivers() As Boolean
                    Get
                        If IsNothing(bolDataExecutionPrevention_Drivers) = True Then
                            Return False
                        Else
                            Return bolDataExecutionPrevention_Drivers
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Indicates which Data Execution Prevention (DEP) setting is applied. The DEP 
                ''' setting specifies the extent to which DEP applies to 32-bit applications on 
                ''' the system. DEP is always applied to the Windows kernel.
                ''' </summary>
                ''' <returns>Byte (UInt8)</returns>
                Public ReadOnly Property DataExecutionPrevention_SupportPolicy() As Byte
                    Get
                        If IsNothing(bytDataExecutionPrevention_SupportPolicy) = True Then
                            Return 0
                        Else
                            Return bytDataExecutionPrevention_SupportPolicy
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Operating system is a checked (debug) build. If True, the debugging version is 
                ''' installed. Checked builds provide error checking, argument verification, and 
                ''' system debugging code. Additional code in a checked binary generates a kernel 
                ''' debugger error message and breaks into the debugger. This helps immediately 
                ''' determine the cause and location of the error. Performance may be affected in 
                ''' a checked build due to the additional code that is executed.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property Debug() As Boolean
                    Get
                        If IsNothing(bolDebug) = True Then
                            Return False
                        Else
                            Return bolDebug
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Description of the Windows operating system. Some user interfaces for example, 
                ''' those that allow editing of this description, limit its length to 48 characters.
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
                ''' If True, the operating system is distributed across several computer system 
                ''' nodes. If so, these nodes should be grouped as a cluster.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property Distributed() As Boolean
                    Get
                        If IsNothing(bolDistributed) = True Then
                            Return False
                        Else
                            Return bolDistributed
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Encryption level for secure transactions: 40-bit, 128-bit, or n-bit.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property EncryptionLevel() As UInteger
                    Get
                        If IsNothing(intEncryptionLevel) = True Then
                            Return 0
                        Else
                            Return intEncryptionLevel
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Increase in priority is given to the foreground application. Application boost 
                ''' is implemented by giving an application more execution time slices (quantum lengths).
                ''' </summary>
                ''' <returns>Byte (UInt8)</returns>
                Public ReadOnly Property ForegroundApplicationBoost() As Byte
                    Get
                        If IsNothing(bytForegroundApplicationBoost) = True Then
                            Return 0
                        Else
                            Return bytForegroundApplicationBoost
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number, in kilobytes, of physical memory currently unused and available.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property FreePhysicalMemory() As ULong
                    Get
                        If IsNothing(lngFreePhysicalMemory) = True Then
                            Return 0
                        Else
                            Return lngFreePhysicalMemory
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number, in kilobytes, that can be mapped into the operating system paging 
                ''' files without causing any other pages to be swapped out.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property FreeSpaceInPagingFiles() As ULong
                    Get
                        If IsNothing(lngFreeSpaceInPagingFiles) = True Then
                            Return 0
                        Else
                            Return lngFreeSpaceInPagingFiles
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number, in kilobytes, of virtual memory currently unused and available.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property FreeVirtualMemory() As ULong
                    Get
                        If IsNothing(lngFreeVirtualMemory) = True Then
                            Return 0
                        Else
                            Return lngFreeVirtualMemory
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Date object was installed. This property does not require a value to indicate that the object is installed.
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
                ''' Date and time the operating system was last restarted.
                ''' </summary>
                ''' <returns>DateTime</returns>
                Public ReadOnly Property LastBootUpTime() As Date
                    Get
                        If IsNothing(dtLastBootUpTime) = True Then
                            Return #01/01/0001#
                        Else
                            Return dtLastBootUpTime
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Operating system version of the local date and time-of-day.
                ''' </summary>
                ''' <returns>DateTime</returns>
                Public ReadOnly Property LocalDateTime() As Date
                    Get
                        If IsNothing(dtLocalDateTime) = True Then
                            Return #01/01/0001#
                        Else
                            Return dtLocalDateTime
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Language identifier used by the operating system. A language identifier is a 
                ''' standard international numeric abbreviation for a country/region. Each language 
                ''' has a unique language identifier (LANGID), a 16-bit value that consists of a 
                ''' primary language identifier and a secondary language identifier.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Locale() As String
                    Get
                        If IsNothing(strLocale) = True Then
                            Return ""
                        Else
                            Return strLocale
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the operating system manufacturer. For Windows-based systems, this value is "Microsoft Corporation".
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
                ''' Maximum number of process contexts the operating system can support. The default value 
                ''' set by the provider is 4294967295 (0xFFFFFFFF). If there is no fixed maximum, the value 
                ''' should be 0 (zero). On systems that have a fixed maximum, this object can help diagnose 
                ''' failures that occur when the maximum is reached—if unknown, enter 4294967295 (0xFFFFFFFF).
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property MaxNumberOfProcesses() As UInteger
                    Get
                        If IsNothing(intMaxNumberOfProcesses) = True Then
                            Return 4294967295
                        Else
                            Return intMaxNumberOfProcesses
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Maximum number, in kilobytes, of memory that can be allocated to a process. For operating 
                ''' systems with no virtual memory, typically this value is equal to the total amount of 
                ''' physical memory minus the memory used by the BIOS and the operating system. For some 
                ''' operating systems, this value may be infinity, in which case 0 (zero) should be entered. 
                ''' In other cases, this value could be a constant, for example, 2G or 4G.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property MaxProcessMemorySize() As ULong
                    Get
                        If IsNothing(lngMaxProcessMemorySize) = True Then
                            Return 0
                        Else
                            Return lngMaxProcessMemorySize
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Multilingual User Interface Pack (MUI Pack ) languages installed on the computer. 
                ''' For example, "en-us". MUI Pack languages are resource files that can be installed 
                ''' on the English version of the operating system. When an MUI Pack is installed, 
                ''' you can can change the user interface language to one of 33 supported languages.
                ''' </summary>
                ''' <returns>String array</returns>
                Public ReadOnly Property MUILanguages() As String()
                    Get
                        If IsNothing(strMUILanguages) = True Then
                            Return {""}
                        Else
                            Return strMUILanguages
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of user licenses for the operating system. If unlimited, enter 0 (zero). 
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property NumberOfLicensedUsers() As UInteger
                    Get
                        If IsNothing(intNumberOfLicensedUsers) = True Then
                            Return 0
                        Else
                            Return intNumberOfLicensedUsers
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of process contexts currently loaded or running on the operating system.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property NumberOfProcesses() As UInteger
                    Get
                        If IsNothing(intNumberOfProcesses) = True Then
                            Return 0
                        Else
                            Return intNumberOfProcesses
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of user sessions for which the operating system is storing state information currently.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property NumberOfUsers() As UInteger
                    Get
                        If IsNothing(intNumberOfUsers) = True Then
                            Return 0
                        Else
                            Return intNumberOfUsers
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Stock Keeping Unit (SKU) number for the operating system. 
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property OperatingSystemSKU() As UInteger
                    Get
                        If IsNothing(intOperatingSystemSKU) = True Then
                            Return 0
                        Else
                            Return intOperatingSystemSKU
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Company name for the registered user of the operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Organization() As String
                    Get
                        If IsNothing(strOrganization) = True Then
                            Return ""
                        Else
                            Return strOrganization
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Architecture of the operating system, as opposed to the processor. This property can be localized.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property OSArchitecture() As String
                    Get
                        If IsNothing(strOSArchitecture) = True Then
                            Return ""
                        Else
                            Return strOSArchitecture
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Language version of the operating system installed.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property OSLanguage() As UInteger
                    Get
                        If IsNothing(intOSLanguage) = True Then
                            Return 0
                        Else
                            Return intOSLanguage
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Operating system instance within a computer system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property OSName() As String
                    Get
                        If IsNothing(strOSName) = True Then
                            Return ""
                        Else
                            Return strOSName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Installed and licensed system product additions to the operating system. For 
                ''' example, the value of 146 (0x92) for OSProductSuite indicates Enterprise, 
                ''' Terminal Services, and Data Center (bits one, four, and seven set).
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property OSProductSuite() As UInteger
                    Get
                        If IsNothing(intOSProductSuite) = True Then
                            Return 0
                        Else
                            Return intOSProductSuite
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Type of operating system. The following list identifies the possible values.
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property OSType() As UShort
                    Get
                        If IsNothing(srtOSType) = True Then
                            Return 0
                        Else
                            Return srtOSType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Additional description for the current operating system version.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property OtherTypeDescription() As String
                    Get
                        If IsNothing(strOtherTypeDescription) = True Then
                            Return ""
                        Else
                            Return strOtherTypeDescription
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the physical address extensions (PAE) are enabled by the operating system running on Intel processors.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property PAEEnabled() As Boolean
                    Get
                        If IsNothing(bolPAEEnabled) = True Then
                            Return False
                        Else
                            Return bolPAEEnabled
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Specifies whether the operating system booted from an external USB device. 
                ''' If true, the operating system has detected it is booting on a supported 
                ''' locally connected storage device.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property PortableOperatingSystem() As Boolean
                    Get
                        If IsNothing(bolPortableOperatingSystem) = True Then
                            Return False
                        Else
                            Return bolPortableOperatingSystem
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Specifies whether this is the primary operating system.
                ''' </summary>
                ''' <returns>Boolean</returns>
                Public ReadOnly Property Primary() As Boolean
                    Get
                        If IsNothing(bolPrimary) = True Then
                            Return False
                        Else
                            Return bolPrimary
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Additional system information.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property ProductType() As UInteger
                    Get
                        If IsNothing(intProductType) = True Then
                            Return 0
                        Else
                            Return intProductType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the registered user of the operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property RegisteredUser() As String
                    Get
                        If IsNothing(strRegisteredUser) = True Then
                            Return ""
                        Else
                            Return strRegisteredUser
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Operating system product serial identification number.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SerialNumber() As String
                    Get
                        If IsNothing(strSerialNumber) = True Then
                            Return ""
                        Else
                            Return strSerialNumber
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Major version number of the service pack installed on the computer system. 
                ''' If no service pack has been installed, the value is 0 (zero).
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property ServicePackMajorVersion() As UShort
                    Get
                        If IsNothing(srtServicePackMajorVersion) = True Then
                            Return 0
                        Else
                            Return srtServicePackMajorVersion
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Minor version number of the service pack installed on the computer system. 
                ''' If no service pack has been installed, the value is 0 (zero).
                ''' </summary>
                ''' <returns>UShort</returns>
                Public ReadOnly Property ServicePackMinorVersion() As UShort
                    Get
                        If IsNothing(srtServicePackMinorVersion) = True Then
                            Return 0
                        Else
                            Return srtServicePackMinorVersion
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Total number of kilobytes that can be stored in the operating system paging files—0 (zero) 
                ''' indicates that there are no paging files. Be aware that this number does not represent the 
                ''' actual physical size of the paging file on disk.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property SizeStoredInPagingFiles() As ULong
                    Get
                        If IsNothing(lngSizeStoredInPagingFiles) = True Then
                            Return 0
                        Else
                            Return lngSizeStoredInPagingFiles
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current status of the object. Various operational and nonoperational statuses can be defined. 
                ''' Operational statuses include: "OK", "Degraded", and "Pred Fail" (an element, such as a 
                ''' SMART-enabled hard disk drive may function properly, but predicts a failure in the near 
                ''' future). Nonoperational statuses include: "Error", "Starting", "Stopping", and "Service". 
                ''' The Service status applies to administrative work, such as mirror-resilvering of a disk, 
                ''' reload of a user permissions list, or other administrative work. Not all such work is 
                ''' online, but the managed element is neither "OK" nor in one of the other states.
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
                ''' Bit flags that identify the product suites available on the system.
                ''' </summary>
                ''' <returns>UInteger</returns>
                Public ReadOnly Property SuiteMask() As UInteger
                    Get
                        If IsNothing(intSuiteMask) = True Then
                            Return 0
                        Else
                            Return intSuiteMask
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Physical disk partition on which the operating system is installed.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SystemDevice() As String
                    Get
                        If IsNothing(strSystemDevice) = True Then
                            Return ""
                        Else
                            Return strSystemDevice
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' System directory of the operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SystemDirectory() As String
                    Get
                        If IsNothing(strSystemDirectory) = True Then
                            Return ""
                        Else
                            Return strSystemDirectory
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Letter of the disk drive on which the operating system resides.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property SystemDrive() As String
                    Get
                        If IsNothing(strSystemDrive) = True Then
                            Return ""
                        Else
                            Return strSystemDrive
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Total swap space in kilobytes. This value may be NULL (unspecified) if the swap space 
                ''' is not distinguished from page files. However, some operating systems distinguish 
                ''' these concepts. For example, in UNIX, whole processes can be swapped out when the 
                ''' free page list falls and remains below a specified amount.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property TotalSwapSpaceSize() As ULong
                    Get
                        If IsNothing(lngTotalSwapSpaceSize) = True Then
                            Return 0
                        Else
                            Return lngTotalSwapSpaceSize
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number, in kilobytes, of virtual memory. For example, this may be calculated by adding 
                ''' the amount of total RAM to the amount of paging space, that is, adding the amount of 
                ''' memory in or aggregated by the computer system to the property, SizeStoredInPagingFiles.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property TotalVirtualMemorySize() As ULong
                    Get
                        If IsNothing(lngTotalVirtualMemorySize) = True Then
                            Return 0
                        Else
                            Return lngTotalVirtualMemorySize
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Total amount, in kilobytes, of physical memory available to the operating system. 
                ''' This value does not necessarily indicate the true amount of physical memory, but 
                ''' what is reported to the operating system as available to it.
                ''' </summary>
                ''' <returns>ULong</returns>
                Public ReadOnly Property TotalVisibleMemorySize() As ULong
                    Get
                        If IsNothing(lngTotalVisibleMemorySize) = True Then
                            Return 0
                        Else
                            Return lngTotalVisibleMemorySize
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Version number of the operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property Version() As String
                    Get
                        If IsNothing(strVersion) = True Then
                            Return ""
                        Else
                            Return strVersion
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Windows directory of the operating system.
                ''' </summary>
                ''' <returns>String</returns>
                Public ReadOnly Property WindowsDirectory() As String
                    Get
                        If IsNothing(strWindowsDirectory) = True Then
                            Return ""
                        Else
                            Return strWindowsDirectory
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The QuantumLength property defines the number of clock ticks per quantum. A quantum 
                ''' is a unit of execution time that the scheduler is allowed to give to an application 
                ''' before switching to other applications. When a thread runs one quantum, the kernel 
                ''' preempts it and moves it to the end of a queue for applications with equal priorities. 
                ''' The actual length of a thread's quantum varies across different Windows platforms. 
                ''' For Windows NT/Windows 2000 only.
                ''' </summary>
                ''' <returns>Byte (UInt8)</returns>
                Public ReadOnly Property QuantumLength() As Byte
                    Get
                        If IsNothing(bytQuantumLength) = True Then
                            Return 0
                        Else
                            Return bytQuantumLength
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The QuantumType property specifies either fixed or variable length quantums. Windows 
                ''' defaults to variable length quantums where the foreground application has a longer 
                ''' quantum than the background applications. Windows Server defaults to fixed-length 
                ''' quantums. A quantum is a unit of execution time that the scheduler is allowed to 
                ''' give to an application before switching to another application. When a thread runs 
                ''' one quantum, the kernel preempts it and moves it to the end of a queue for 
                ''' applications with equal priorities. The actual length of a thread's quantum 
                ''' varies across different Windows platforms.
                ''' </summary>
                ''' <returns>Byte (UInt8)</returns>
                Public ReadOnly Property QuantumType() As Byte
                    Get
                        If IsNothing(bytQuantumType) = True Then
                            Return 0
                        Else
                            Return bytQuantumType
                        End If
                    End Get
                End Property
#End Region

            End Class

        End Namespace
    End Namespace
End Namespace
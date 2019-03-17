Namespace Global
    Namespace CS
        Namespace System

            ''' <summary>
            ''' The Processor class encapsulate the  WMI Win32_Processor class, 
            ''' that represents a device that can interpret a sequence of instructions 
            ''' on a computer running on a Windows operating system.
            ''' </summary>
            ''' <remarks>
            ''' Documentation Win32_Processor WMI class: 
            ''' https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-processor
            ''' </remarks>
            Public Class Processor

#Region "PrivateVariables"
                ' Private Variables to store Attributes of Win32_Processor WMI Object
                Private srtAddressWidth As UShort
                Private srtArchitecture As UShort
                Private strAssetTag As String
                Private srtAvailability As UShort
                Private strCaption As String
                Private intCharacteristics As UInteger
                Private intConfigManagerErrorCode As UInteger
                Private bolConfigManagerUserConfig As Boolean
                Private srtCpuStatus As UShort
                Private strCreationClassName As String
                Private intCurrentClockSpeed As UInteger
                Private srtCurrentVoltage As UShort
                Private srtDataWidth As UShort
                Private strDescription As String
                Private strDeviceID As String
                Private bolErrorCleared As Boolean
                Private strErrorDescription As String
                Private intExtClock As UInteger
                Private srtFamily As UShort
                Private dtInstallDate As Date
                Private intL2CacheSize As UInteger
                Private intL2CacheSpeed As UInteger
                Private intL3CacheSize As UInteger
                Private intL3CacheSpeed As UInteger
                Private intLastErrorCode As UInteger
                Private srtLevel As UShort
                Private srtLoadPercentage As UShort
                Private strManufacturer As String
                Private intMaxClockSpeed As UInteger
                Private intNumberOfCores As UInteger
                Private intNumberOfEnabledCore As UInteger
                Private intNumberOfLogicalProcessors As UInteger
                Private strOtherFamilyDescription As String
                Private strPartNumber As String
                Private strPNPDeviceID As String
                Private srtPowerManagementCapabilities() As UShort
                Private bolPowerManagementSupported As Boolean
                Private strProcessorId As String
                Private strProcessorName As String
                Private srtProcessorType As UShort
                Private srtRevision As UShort
                Private strRole As String
                Private bolSecondLevelAddressTranslationExtensions As Boolean
                Private strSerialNumber As String
                Private strSocketDesignation As String
                Private strStatus As String
                Private srtStatusInfo As UShort
                Private strStepping As String
                Private strSystemCreationClassName As String
                Private strSystemName As String
                Private intThreadCount As UInteger
                Private strUniqueId As String
                Private srtUpgradeMethod As UShort
                Private strVersion As String
                Private bolVirtualizationFirmwareEnabled As Boolean
                Private bolVMMonitorModeExtensions As Boolean
                Private intVoltageCaps As UInteger

                ' Other private variables
                Private bolSingleInstance As Boolean = True
#End Region

                ''' <summary>
                ''' Creates and returns a new Processor object
                ''' </summary>
                Public Sub New()

                    Dim i As Integer
                    Dim mosPs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_Processor")

                    i = mosPs.Get.Count
                    Select Case i
                        Case 0
                            bolSingleInstance = False
                            Throw New Exception("No Result in WMI Query")
                        Case 1
                            Dim mosP As Global.System.Management.ManagementObject = mosPs.[Get](0)

                            srtAddressWidth = mosP("AddressWidth")
                            srtArchitecture = mosP("Architecture")
                            strAssetTag = mosP("AssetTag")
                            srtAvailability = mosP("Availability")
                            strCaption = mosP("Caption")
                            intCharacteristics = mosP("Characteristics")
                            intConfigManagerErrorCode = mosP("ConfigManagerErrorCode")
                            bolConfigManagerUserConfig = mosP("ConfigManagerUserConfig")
                            srtCpuStatus = mosP("CpuStatus")
                            strCreationClassName = mosP("CreationClassName")
                            intCurrentClockSpeed = mosP("CurrentClockSpeed")
                            srtCurrentVoltage = mosP("CurrentVoltage")
                            srtDataWidth = mosP("DataWidth")
                            strDescription = mosP("Description")
                            strDeviceID = mosP("DeviceID")
                            bolErrorCleared = mosP("ErrorCleared")
                            strErrorDescription = mosP("ErrorDescription")
                            intExtClock = mosP("ExtClock")
                            srtFamily = mosP("Family")
                            dtInstallDate = mosP("InstallDate")
                            intL2CacheSize = mosP("L2CacheSize")
                            intL2CacheSpeed = mosP("L2CacheSpeed")
                            intL3CacheSize = mosP("L3CacheSize")
                            intL3CacheSpeed = mosP("L3CacheSpeed")
                            intLastErrorCode = mosP("LastErrorCode")
                            srtLevel = mosP("Level")
                            srtLoadPercentage = mosP("LoadPercentage")
                            strManufacturer = mosP("Manufacturer")
                            intMaxClockSpeed = mosP("MaxClockSpeed")
                            intNumberOfCores = mosP("NumberOfCores")
                            intNumberOfEnabledCore = mosP("NumberOfEnabledCore")
                            intNumberOfLogicalProcessors = mosP("NumberOfLogicalProcessors")
                            strOtherFamilyDescription = mosP("OtherFamilyDescription")
                            strPartNumber = mosP("PartNumber")
                            strPNPDeviceID = mosP("PNPDeviceID")
                            srtPowerManagementCapabilities = mosP("PowerManagementCapabilities")
                            bolPowerManagementSupported = mosP("PowerManagementSupported")
                            strProcessorId = mosP("ProcessorId")
                            strProcessorName = mosP("Name")
                            srtProcessorType = mosP("ProcessorType")
                            srtRevision = mosP("Revision")
                            strRole = mosP("Role")
                            bolSecondLevelAddressTranslationExtensions = mosP("SecondLevelAddressTranslationExtensions")
                            strSerialNumber = mosP("SerialNumber")
                            strSocketDesignation = mosP("SocketDesignation")
                            strStatus = mosP("Status")
                            srtStatusInfo = mosP("StatusInfo")
                            strStepping = mosP("Stepping")
                            strSystemCreationClassName = mosP("SystemCreationClassName")
                            strSystemName = mosP("SystemName")
                            intThreadCount = mosP("ThreadCount")
                            strUniqueId = mosP("UniqueId")
                            srtUpgradeMethod = mosP("UpgradeMethod")
                            strVersion = mosP("Version")
                            bolVirtualizationFirmwareEnabled = mosP("VirtualizationFirmwareEnabled")
                            bolVMMonitorModeExtensions = mosP("VMMonitorModeExtensions")
                            intVoltageCaps = mosP("VoltageCaps")
                        Case Else
                            bolSingleInstance = False
                    End Select

                End Sub

#Region "PublicProperties"
                ''' <summary>
                ''' On a 32-bit operating system, the value is 32 and on a 64-bit operating system it is 64.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property AddressWidth As UShort
                    Get
                        If IsNothing(srtAddressWidth) = True Then
                            Return 0
                        Else
                            Return srtAddressWidth
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Processor architecture used by the platform.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Architecture() As UShort
                    Get
                        If IsNothing(srtArchitecture) = True Then
                            Return 0
                        Else
                            Return srtArchitecture
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' This value comes from the Asset Tag member of the Processor Information structure in the SMBIOS information.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property AssetTag() As String
                    Get
                        If IsNothing(strAssetTag) = True Then
                            Return ""
                        Else
                            Return strAssetTag
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Availability and status of the device.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Availability() As UShort
                    Get
                        If IsNothing(srtAvailability) = True Then
                            Return 0
                        Else
                            Return srtAvailability
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Short description of an object (a one-line string).
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
                ''' Defines which functions the processor supports.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Characteristics() As UInteger
                    Get
                        If IsNothing(intCharacteristics) = True Then
                            Return 0
                        Else
                            Return intCharacteristics
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Windows API Configuration Manager error code.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ConfigManagerErrorCode() As UInteger
                    Get
                        If IsNothing(intConfigManagerErrorCode) = True Then
                            Return 0
                        Else
                            Return intConfigManagerErrorCode
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If TRUE, the device is using a configuration that the user defines.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ConfigManagerUserConfig() As Boolean
                    Get
                        If IsNothing(bolConfigManagerUserConfig) = True Then
                            Return False
                        Else
                            Return bolConfigManagerUserConfig
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current status of the processor. Status changes indicate processor usage, but not the physical condition of the processor.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property CpuStatus() As UShort
                    Get
                        If IsNothing(srtCpuStatus) = True Then
                            Return 0
                        Else
                            Return srtCpuStatus
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the first concrete class that appears in the inheritance chain used to create 
                ''' an instance. When used with the other key properties of the class, the property allows 
                ''' all instances of this class and its subclasses to be identified uniquely.
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
                ''' Current speed of the processor, in MHz.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property CurrentClockSpeed() As UInteger
                    Get
                        If IsNothing(intCurrentClockSpeed) = True Then
                            Return 0
                        Else
                            Return intCurrentClockSpeed
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Voltage of the processor. If the eighth bit is set, bits 0-6 contain the voltage 
                ''' multiplied by 10. If the eighth bit is not set, then the bit setting in VoltageCaps 
                ''' represents the voltage value. CurrentVoltage is only set when SMBIOS designates a voltage value.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property CurrentVoltage() As UShort
                    Get
                        If IsNothing(srtCurrentVoltage) = True Then
                            Return 0
                        Else
                            Return srtCurrentVoltage
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' On a 32-bit processor, the value is 32 and on a 64-bit processor it is 64.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property DataWidth() As UShort
                    Get
                        If IsNothing(srtDataWidth) = True Then
                            Return 0
                        Else
                            Return srtDataWidth
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
                ''' Unique identifier of a processor on the system.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property DeviceID() As String
                    Get
                        If IsNothing(strDeviceID) = True Then
                            Return ""
                        Else
                            Return strDeviceID
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If TRUE, the error reported in LastErrorCode is clear.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ErrorCleared() As Boolean
                    Get
                        If IsNothing(bolErrorCleared) = True Then
                            Return False
                        Else
                            Return bolErrorCleared
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' More information about the error recorded in LastErrorCode, and information 
                ''' about corrective actions that can be taken.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ErrorDescription() As String
                    Get
                        If IsNothing(strErrorDescription) = True Then
                            Return ""
                        Else
                            Return strErrorDescription
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' External clock frequency, in MHz. If the frequency is unknown, this property is set to NULL.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ExtClock() As UInteger
                    Get
                        If IsNothing(intExtClock) = True Then
                            Return 0
                        Else
                            Return intExtClock
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Processor family type.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Family() As UShort
                    Get
                        If IsNothing(srtFamily) = True Then
                            Return 0
                        Else
                            Return srtFamily
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Date and time the object is installed. This property does not require a value to indicate that the object is installed. 
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
                ''' Size of the Level 2 processor cache. A Level 2 cache is an external memory area that has a faster access time than the main RAM memory.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property L2CacheSize() As UInteger
                    Get
                        If IsNothing(intL2CacheSize) = True Then
                            Return 0
                        Else
                            Return intL2CacheSize
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Clock speed of the Level 2 processor cache. A Level 2 cache is an external memory area that has a faster access time than the main RAM memory.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property L2CacheSpeed() As UInteger
                    Get
                        If IsNothing(intL2CacheSpeed) = True Then
                            Return 0
                        Else
                            Return intL2CacheSpeed
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Size of the Level 3 processor cache. A Level 3 cache is an external memory area that has a faster access time than the main RAM memory.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property L3CacheSize() As UInteger
                    Get
                        If IsNothing(intL3CacheSize) = True Then
                            Return 0
                        Else
                            Return intL3CacheSize
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Clockspeed of the Level 3 property cache. A Level 3 cache is an external memory area that has a faster access time than the main RAM memory.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property L3CacheSpeed() As UInteger
                    Get
                        If IsNothing(L3CacheSpeed) = True Then
                            Return 0
                        Else
                            Return intL3CacheSpeed
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Last error code reported by the logical device.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property LastErrorCode() As UInteger
                    Get
                        If IsNothing(intLastErrorCode) = True Then
                            Return 0
                        Else
                            Return intLastErrorCode
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Definition of the processor type. The value depends on the architecture of the processor.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Level() As UShort
                    Get
                        If IsNothing(srtLevel) = True Then
                            Return 0
                        Else
                            Return srtLevel
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Load capacity of each processor, averaged to the last second. Processor 
                ''' loading refers to the total computing burden for each processor at one time.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property LoadPercentage() As UShort
                    Get
                        If IsNothing(srtLoadPercentage) = True Then
                            Return 0
                        Else
                            Return srtLoadPercentage
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Name of the processor manufacturer.
                ''' </summary>
                ''' <returns></returns>
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
                ''' Maximum speed of the processor, in MHz.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property MaxClockSpeed() As UInteger
                    Get
                        If IsNothing(intMaxClockSpeed) = True Then
                            Return 0
                        Else
                            Return intMaxClockSpeed
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of cores for the current instance of the processor. A core is a physical 
                ''' processor on the integrated circuit. For example, in a dual-core processor this 
                ''' property has a value of 2. For more information, see Remarks.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property NumberOfCores() As UInteger
                    Get
                        If IsNothing(intNumberOfCores) = True Then
                            Return 0
                        Else
                            Return intNumberOfCores
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' This value comes from the Processor Information structure in the SMBIOS version 
                ''' information. For SMBIOS versions 2.5 thru 2.9 the value comes from the Core Enabled 
                ''' member. For SMBIOS version 3.0+ the value comes from the Core Enabled 2 member.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property NumberOfEnabledCore() As UInteger
                    Get
                        If IsNothing(intNumberOfEnabledCore) = True Then
                            Return 0
                        Else
                            Return intNumberOfEnabledCore
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Number of logical processors for the current instance of the processor. For processors 
                ''' capable of hyperthreading, this value includes only the processors which have hyperthreading 
                ''' enabled. For more information, see Remarks.
                ''' </summary>
                ''' <returns></returns>
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
                ''' Processor family type. Used when the Family property is set to 1, which means Other.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property OtherFamilyDescription() As String
                    Get
                        If IsNothing(strOtherFamilyDescription) = True Then
                            Return ""
                        Else
                            Return strOtherFamilyDescription
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The part number of this processor as set by the manufacturer.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property PartNumber() As String
                    Get
                        If IsNothing(strPartNumber) = True Then
                            Return ""
                        Else
                            Return strPartNumber
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Windows Plug and Play device identifier of the logical device.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property PNPDeviceID() As String
                    Get
                        If IsNothing(strPNPDeviceID) = True Then
                            Return ""
                        Else
                            Return strPNPDeviceID
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Array of the specific power-related capabilities of a logical device.
                ''' </summary>
                ''' <returns></returns>
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
                ''' If TRUE, the power of the device can be managed, which means that it can be put into 
                ''' suspend mode, and so on. The property does not indicate that power management features 
                ''' are enabled, but it does indicate that the logical device power can be managed.
                ''' </summary>
                ''' <returns></returns>
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
                ''' Processor information that describes the processor features. For an x86 class CPU, 
                ''' the field format depends on the processor support of the CPUID instruction. If the 
                ''' instruction is supported, the property contains 2 (two) DWORD formatted values. 
                ''' The first is an offset of 08h-0Bh, which is the EAX value that a CPUID instruction 
                ''' returns with input EAX set to 1. The second is an offset of 0Ch-0Fh, which is the 
                ''' EDX value that the instruction returns. Only the first two bytes of the property 
                ''' are significant and contain the contents of the DX register at CPU reset—all others 
                ''' are set to 0 (zero), and the contents are in DWORD format.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ProcessorId() As String
                    Get
                        If IsNothing(strProcessorId) = True Then
                            Return ""
                        Else
                            Return strProcessorId
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Label by which the object is known. When this property is a subclass, it can be overridden to be a key property.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ProcessorName() As String
                    Get
                        If IsNothing(strProcessorName) = True Then
                            Return ""
                        Else
                            Return strProcessorName
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Primary function of the processor.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ProcessorType() As UShort
                    Get
                        If IsNothing(srtProcessorType) = True Then
                            Return 0
                        Else
                            Return srtProcessorType
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' System revision level that depends on the architecture. The system revision 
                ''' level contains the same values as the Version property, but in a numerical format.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Revision() As UShort
                    Get
                        If IsNothing(srtRevision) = True Then
                            Return 0
                        Else
                            Return srtRevision
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Role of the processor.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Role() As String
                    Get
                        If IsNothing(strRole) = True Then
                            Return ""
                        Else
                            Return strRole
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the processor supports address translation extensions used for virtualization.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property SecondLevelAddressTranslationExtensions() As Boolean
                    Get
                        If IsNothing(bolSecondLevelAddressTranslationExtensions) = True Then
                            Return False
                        Else
                            Return bolSecondLevelAddressTranslationExtensions
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' The serial number of this processor This value is set by the manufacturer and normally not changeable.
                ''' </summary>
                ''' <returns></returns>
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
                ''' Type of chip socket used on the circuit.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property SocketDesignation() As String
                    Get
                        If IsNothing(strSocketDesignation) = True Then
                            Return ""
                        Else
                            Return strSocketDesignation
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Current status of an object. 
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
                ''' State of the logical device. If this property does not apply to the logical device, use the value 5, which means Not Applicable.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property StatusInfo() As UShort
                    Get
                        If IsNothing(srtStatusInfo) = True Then
                            Return 0
                        Else
                            Return srtStatusInfo
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Revision level of the processor in the processor family.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property Stepping() As String
                    Get
                        If IsNothing(strStepping) = True Then
                            Return ""
                        Else
                            Return strStepping
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Value of the CreationClassName property for the scoping computer.
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
                ''' Name of the scoping system.
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
                ''' This value comes from the Processor Information structure in the SMBIOS version 
                ''' information. For SMBIOS versions 2.5 thru 2.9 the value comes from the Thread 
                ''' Count member. For SMBIOS version 3.0+ the value comes from the Thread Count 2 member.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property ThreadCount() As UInteger
                    Get
                        If IsNothing(intThreadCount) = True Then
                            Return 0
                        Else
                            Return intThreadCount
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Globally unique identifier for the processor. This identifier may only be unique within a processor family.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property UniqueId() As String
                    Get
                        If IsNothing(strUniqueId) = True Then
                            Return ""
                        Else
                            Return strUniqueId
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' CPU socket information, including the method by which this processor can be 
                ''' upgraded, if upgrades are supported. This property is an integer enumeration.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property UpgradeMethod() As UShort
                    Get
                        If IsNothing(srtUpgradeMethod) = True Then
                            Return 0
                        Else
                            Return srtUpgradeMethod
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Processor revision number that depends on the architecture.
                ''' </summary>
                ''' <returns></returns>
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
                ''' If True, the Firmware has enabled virtualization extensions.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property VirtualizationFirmwareEnabled() As Boolean
                    Get
                        If IsNothing(bolVirtualizationFirmwareEnabled) = True Then
                            Return False
                        Else
                            Return bolVirtualizationFirmwareEnabled
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' If True, the processor supports Intel or AMD Virtual Machine Monitor extensions.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property VMMonitorModeExtensions() As Boolean
                    Get
                        If IsNothing(bolVMMonitorModeExtensions) = True Then
                            Return False
                        Else
                            Return bolVMMonitorModeExtensions
                        End If
                    End Get
                End Property

                ''' <summary>
                ''' Voltage capabilities of the processor. Bits 0-3 of the field represent specific 
                ''' voltages that the processor socket can accept. All other bits should be set to 0 (zero). 
                ''' The socket is configurable if multiple bits are set. For more information about the actual 
                ''' voltage at which the processor is running, see CurrentVoltage.
                ''' </summary>
                ''' <returns></returns>
                Public ReadOnly Property VoltageCaps() As UInteger
                    Get
                        If IsNothing(intVoltageCaps) = True Then
                            Return 0
                        Else
                            Return intVoltageCaps
                        End If
                    End Get
                End Property
#End Region

            End Class

        End Namespace
    End Namespace
End Namespace
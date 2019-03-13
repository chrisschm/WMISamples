﻿Namespace Global
    Namespace CS
        Namespace System

            Public Class BIOS

#Region "PrivateVariables"
                ' Private Variables to store Attributes of Win32_BIOS WMI Object
                ' Documentation: https://docs.microsoft.com/en-us/windows/desktop/cimwin32prov/win32-bios

                Private strucBiosCharacteristics As BiosCharacteristicValues
                Private strBiosName As String
                Private strBIOSVersion As String()
                Private strBuildNumber As String
                Private strCaption As String
                Private strCodeSet As String
                Private strCurrentLanguage As String
                Private strDescription As String
                Private bytEmbeddedControllerMajorVersion As Byte ' UInt8
                Private bytEmbeddedControllerMinorVersion As Byte ' UInt8
                Private strIdentificationCode As String
                Private srtInstallableLanguages As UShort
                Private dtInstallDate As Date
                Private strLanguageEdition As String
                Private strManufacturer As String
                Private strOtherTargetOS As String
                Private bolPrimaryBIOS As Boolean
                Private strReleaseDate As String
                Private strSerialNumber As String
                Private strSMBIOSBIOSVersion As String
                Private srtSMBIOSMajorVersion As UShort
                Private srtSMBIOSMinorVersion As UShort
                Private bolSMBIOSPresent As Boolean
                Private strSoftwareElementID As String
                Private srtSoftwareElementState As UShort
                Private strStatus As String
                Private bytSystemBiosMajorVersion As Byte ' UInt8
                Private bytSystemBiosMinorVersion As Byte ' UInt8
                Private srtTargetOperatingSystem As UShort
                Private strVersion As String

                ' Other private variables
                Private bolSingleInstance As Boolean = True

#End Region

#Region "PublicStrutures"
                Public Structure BiosCharacteristicValues
                    Public Reserved0 As Boolean
                    Public Reserved1 As Boolean
                    Public Unknown2 As Boolean
                    Public BIOSCharacteristicsNotSupported As Boolean
                    Public ISASupported As Boolean
                    Public MCASupported As Boolean
                    Public EISASupported As Boolean
                    Public PCISupported As Boolean
                    Public PCCardSupported As Boolean
                    Public PlugNPlaySupported As Boolean
                    Public APMSupported As Boolean
                    Public BIOSUpgradeable As Boolean
                    Public BIOSShadowingAllowed As Boolean
                    Public VLVESASupported As Boolean
                    Public ESCDSupportAvailable As Boolean
                    Public BootFromCDSupported As Boolean
                    Public SelectableBootSupported As Boolean
                    Public BIOSROMSocketed As Boolean
                    Public BootFromPCCardSupported As Boolean
                    Public EDDSpecificationSupported As Boolean
                    Public Int13hFloppyNEC9800Supported As Boolean
                    Public Int13hFloppyToshibaSupported As Boolean
                    Public Int13h360KBFloppyServicesSupported As Boolean
                    Public Int13h12MBFloppyServicesSupported As Boolean
                    Public Int13h720KBFloppyServicesSupported As Boolean
                    Public Int13h288MBFloppyServicesSupported As Boolean
                    Public Int5hPrintScreenServiceSupported As Boolean
                    Public Int9h8042KeyboardServicesSupported As Boolean
                    Public Int14hSerialServicesSupported As Boolean
                    Public Int17hPrinterServicesSupported As Boolean
                    Public Int10hCGAMonoVideoServicesSupported As Boolean
                    Public NECPC98 As Boolean
                    Public ACPISupported As Boolean
                    Public USBLegacySupported As Boolean
                    Public AGPSupported As Boolean
                    Public I2OBootSupported As Boolean
                    Public LS120BootSupported As Boolean
                    Public ATAPIZIPDriveBootSupported As Boolean
                    Public FW1394BootSupported As Boolean
                    Public SmartBatterySupported As Boolean
                    Public BIOSVendorReserved40 As Boolean
                    Public BIOSVendorReserved41 As Boolean
                    Public BIOSVendorReserved42 As Boolean
                    Public BIOSVendorReserved43 As Boolean
                    Public BIOSVendorReserved44 As Boolean
                    Public BIOSVendorReserved45 As Boolean
                    Public BIOSVendorReserved46 As Boolean
                    Public BIOSVendorReserved47 As Boolean
                    Public SystemVendorReserved48 As Boolean
                    Public SystemVendorReserved49 As Boolean
                    Public SystemVendorReserved50 As Boolean
                    Public SystemVendorReserved51 As Boolean
                    Public SystemVendorReserved52 As Boolean
                    Public SystemVendorReserved53 As Boolean
                    Public SystemVendorReserved54 As Boolean
                    Public SystemVendorReserved55 As Boolean
                    Public SystemVendorReserved56 As Boolean
                    Public SystemVendorReserved57 As Boolean
                    Public SystemVendorReserved58 As Boolean
                    Public SystemVendorReserved59 As Boolean
                    Public SystemVendorReserved60 As Boolean
                    Public SystemVendorReserved61 As Boolean
                    Public SystemVendorReserved62 As Boolean
                    Public SystemVendorReserved63 As Boolean
                End Structure
#End Region



                Public Sub New()

                    Dim i As Integer
                    Dim mosBs As New Global.System.Management.ManagementObjectSearcher("SELECT * FROM Win32_BIOS")

                    i = mosBs.Get.Count
                    Select Case i
                        Case 0
                            bolSingleInstance = False
                            Throw New Exception("No Result in WMI Query")
                        Case 1
                            Dim mosB As Global.System.Management.ManagementObject = mosBs.[Get](0)

                            InitBiosCharacteristicValues()
                            strucBiosCharacteristics = GetBiosCharacteristicValues(mosB("BiosCharacteristics"))

                            strBiosName = mosB("Name")
                            strBIOSVersion = mosB("BIOSVersion")
                            strBuildNumber = mosB("BuildNumber")
                            strCaption = mosB("Caption")
                            strCodeSet = mosB("CodeSet")
                            strCurrentLanguage = mosB("CurrentLanguage")
                            strDescription = mosB("Description")
                            bytEmbeddedControllerMajorVersion = mosB("EmbeddedControllerMajorVersion")
                            bytEmbeddedControllerMinorVersion = mosB("EmbeddedControllerMinorVersion")
                            strIdentificationCode = mosB("IdentificationCode")
                            srtInstallableLanguages = mosB("InstallableLanguages")
                            dtInstallDate = mosB("InstallDate")
                            strLanguageEdition = mosB("LanguageEdition")
                            strManufacturer = mosB("Manufacturer")
                            strOtherTargetOS = mosB("OtherTargetOS")
                            bolPrimaryBIOS = mosB("PrimaryBIOS")
                            strReleaseDate = mosB("ReleaseDate") ' ISSUE: should be DATE but does not work
                            strSerialNumber = mosB("SerialNumber")
                            strSMBIOSBIOSVersion = mosB("SMBIOSBIOSVersion")
                            srtSMBIOSMajorVersion = mosB("SMBIOSMajorVersion")
                            srtSMBIOSMinorVersion = mosB("SMBIOSMinorVersion")
                            bolSMBIOSPresent = mosB("SMBIOSPresent")
                            strSoftwareElementID = mosB("SoftwareElementID")
                            srtSoftwareElementState = mosB("SoftwareElementState")
                            strStatus = mosB("Status")
                            bytSystemBiosMajorVersion = mosB("SystemBiosMajorVersion")
                            bytSystemBiosMinorVersion = mosB("SystemBiosMinorVersion")
                            srtTargetOperatingSystem = mosB("TargetOperatingSystem")
                            strVersion = mosB("Version")
                        Case Else
                            bolSingleInstance = False
                    End Select

                End Sub

#Region "PrivateMethods"
                Private Function GetBiosCharacteristicValues(Values As UShort()) As BiosCharacteristicValues

                    For Each value As UShort In Values
                        Select Case value
                            Case 0
                                strucBiosCharacteristics.Reserved0 = True
                            Case 1
                                strucBiosCharacteristics.Reserved1 = True
                            Case 2
                                strucBiosCharacteristics.Unknown2 = True
                            Case 3
                                strucBiosCharacteristics.BIOSCharacteristicsNotSupported = True
                            Case 4
                                strucBiosCharacteristics.ISASupported = True
                            Case 5
                                strucBiosCharacteristics.MCASupported = True
                            Case 6
                                strucBiosCharacteristics.EISASupported = True
                            Case 7
                                strucBiosCharacteristics.PCISupported = True
                            Case 8
                                strucBiosCharacteristics.PCCardSupported = True
                            Case 9
                                strucBiosCharacteristics.PlugNPlaySupported = True
                            Case 10
                                strucBiosCharacteristics.APMSupported = True
                            Case 11
                                strucBiosCharacteristics.BIOSUpgradeable = True
                            Case 12
                                strucBiosCharacteristics.BIOSShadowingAllowed = True
                            Case 13
                                strucBiosCharacteristics.VLVESASupported = True
                            Case 14
                                strucBiosCharacteristics.ESCDSupportAvailable = True
                            Case 15
                                strucBiosCharacteristics.BootFromCDSupported = True
                            Case 16
                                strucBiosCharacteristics.SelectableBootSupported = True
                            Case 17
                                strucBiosCharacteristics.BIOSROMSocketed = True
                            Case 18
                                strucBiosCharacteristics.BootFromPCCardSupported = True
                            Case 19
                                strucBiosCharacteristics.EDDSpecificationSupported = True
                            Case 20
                                strucBiosCharacteristics.Int13hFloppyNEC9800Supported = True
                            Case 21
                                strucBiosCharacteristics.Int13hFloppyToshibaSupported = True
                            Case 22
                                strucBiosCharacteristics.Int13h360KBFloppyServicesSupported = True
                            Case 23
                                strucBiosCharacteristics.Int13h12MBFloppyServicesSupported = True
                            Case 24
                                strucBiosCharacteristics.Int13h720KBFloppyServicesSupported = True
                            Case 25
                                strucBiosCharacteristics.Int13h288MBFloppyServicesSupported = True
                            Case 26
                                strucBiosCharacteristics.Int5hPrintScreenServiceSupported = True
                            Case 27
                                strucBiosCharacteristics.Int9h8042KeyboardServicesSupported = True
                            Case 28
                                strucBiosCharacteristics.Int14hSerialServicesSupported = True
                            Case 29
                                strucBiosCharacteristics.Int17hPrinterServicesSupported = True
                            Case 30
                                strucBiosCharacteristics.Int10hCGAMonoVideoServicesSupported = True
                            Case 31
                                strucBiosCharacteristics.NECPC98 = True
                            Case 32
                                strucBiosCharacteristics.ACPISupported = True
                            Case 33
                                strucBiosCharacteristics.USBLegacySupported = True
                            Case 34
                                strucBiosCharacteristics.AGPSupported = True
                            Case 35
                                strucBiosCharacteristics.I2OBootSupported = True
                            Case 36
                                strucBiosCharacteristics.LS120BootSupported = True
                            Case 37
                                strucBiosCharacteristics.ATAPIZIPDriveBootSupported = True
                            Case 38
                                strucBiosCharacteristics.FW1394BootSupported = True
                            Case 39
                                strucBiosCharacteristics.SmartBatterySupported = True
                            Case 40
                                strucBiosCharacteristics.BIOSVendorReserved40 = True
                            Case 41
                                strucBiosCharacteristics.BIOSVendorReserved41 = True
                            Case 42
                                strucBiosCharacteristics.BIOSVendorReserved42 = True
                            Case 43
                                strucBiosCharacteristics.BIOSVendorReserved43 = True
                            Case 44
                                strucBiosCharacteristics.BIOSVendorReserved44 = True
                            Case 45
                                strucBiosCharacteristics.BIOSVendorReserved45 = True
                            Case 46
                                strucBiosCharacteristics.BIOSVendorReserved46 = True
                            Case 47
                                strucBiosCharacteristics.BIOSVendorReserved47 = True
                            Case 48
                                strucBiosCharacteristics.SystemVendorReserved48 = True
                            Case 49
                                strucBiosCharacteristics.SystemVendorReserved49 = True
                            Case 50
                                strucBiosCharacteristics.SystemVendorReserved50 = True
                            Case 51
                                strucBiosCharacteristics.SystemVendorReserved51 = True
                            Case 52
                                strucBiosCharacteristics.SystemVendorReserved52 = True
                            Case 53
                                strucBiosCharacteristics.SystemVendorReserved53 = True
                            Case 54
                                strucBiosCharacteristics.SystemVendorReserved54 = True
                            Case 55
                                strucBiosCharacteristics.SystemVendorReserved55 = True
                            Case 56
                                strucBiosCharacteristics.SystemVendorReserved56 = True
                            Case 57
                                strucBiosCharacteristics.SystemVendorReserved57 = True
                            Case 58
                                strucBiosCharacteristics.SystemVendorReserved58 = True
                            Case 59
                                strucBiosCharacteristics.SystemVendorReserved59 = True
                            Case 60
                                strucBiosCharacteristics.SystemVendorReserved60 = True
                            Case 61
                                strucBiosCharacteristics.SystemVendorReserved61 = True
                            Case 62
                                strucBiosCharacteristics.SystemVendorReserved62 = True
                            Case 63
                                strucBiosCharacteristics.SystemVendorReserved63 = True
                            Case Else
                                Throw New Exception("Unknown Value in BiosCharacteristics")
                        End Select
                    Next

                End Function

                Private Sub InitBiosCharacteristicValues()

                    With strucBiosCharacteristics
                        .Reserved0 = False
                        .Reserved1 = False
                        .Unknown2 = False
                        .BIOSCharacteristicsNotSupported = False
                        .ISASupported = False
                        .MCASupported = False
                        .EISASupported = False
                        .PCISupported = False
                        .PCCardSupported = False
                        .PlugNPlaySupported = False
                        .APMSupported = False
                        .BIOSUpgradeable = False
                        .BIOSShadowingAllowed = False
                        .VLVESASupported = False
                        .ESCDSupportAvailable = False
                        .BootFromCDSupported = False
                        .SelectableBootSupported = False
                        .BIOSROMSocketed = False
                        .BootFromPCCardSupported = False
                        .EDDSpecificationSupported = False
                        .Int13hFloppyNEC9800Supported = False
                        .Int13hFloppyToshibaSupported = False
                        .Int13h360KBFloppyServicesSupported = False
                        .Int13h12MBFloppyServicesSupported = False
                        .Int13h720KBFloppyServicesSupported = False
                        .Int13h288MBFloppyServicesSupported = False
                        .Int5hPrintScreenServiceSupported = False
                        .Int9h8042KeyboardServicesSupported = False
                        .Int14hSerialServicesSupported = False
                        .Int17hPrinterServicesSupported = False
                        .Int10hCGAMonoVideoServicesSupported = False
                        .NECPC98 = False
                        .ACPISupported = False
                        .USBLegacySupported = False
                        .AGPSupported = False
                        .I2OBootSupported = False
                        .LS120BootSupported = False
                        .ATAPIZIPDriveBootSupported = False
                        .FW1394BootSupported = False
                        .SmartBatterySupported = False
                        .BIOSVendorReserved40 = False
                        .BIOSVendorReserved41 = False
                        .BIOSVendorReserved42 = False
                        .BIOSVendorReserved43 = False
                        .BIOSVendorReserved44 = False
                        .BIOSVendorReserved45 = False
                        .BIOSVendorReserved46 = False
                        .BIOSVendorReserved47 = False
                        .SystemVendorReserved48 = False
                        .SystemVendorReserved49 = False
                        .SystemVendorReserved50 = False
                        .SystemVendorReserved51 = False
                        .SystemVendorReserved52 = False
                        .SystemVendorReserved53 = False
                        .SystemVendorReserved54 = False
                        .SystemVendorReserved55 = False
                        .SystemVendorReserved56 = False
                        .SystemVendorReserved57 = False
                        .SystemVendorReserved58 = False
                        .SystemVendorReserved59 = False
                        .SystemVendorReserved60 = False
                        .SystemVendorReserved61 = False
                        .SystemVendorReserved62 = False
                        .SystemVendorReserved63 = False
                    End With

                End Sub
#End Region

#Region "PublicProperties"

                Public ReadOnly Property BiosCharacteristics() As BiosCharacteristicValues
                    Get
                        Return strucBiosCharacteristics
                    End Get
                End Property

                Public ReadOnly Property BiosName() As String
                    Get
                        If IsNothing(strBiosName) = True Then
                            Return ""
                        Else
                            Return strBiosName
                        End If
                    End Get
                End Property

                Public ReadOnly Property BIOSVersion() As String()
                    Get
                        Return strBIOSVersion
                    End Get
                End Property

                Public ReadOnly Property BuildNumber() As String
                    Get
                        If IsNothing(strBuildNumber) = True Then
                            Return ""
                        Else
                            Return strBuildNumber
                        End If
                    End Get
                End Property

                Public ReadOnly Property Caption() As String
                    Get
                        If IsNothing(strCaption) = True Then
                            Return ""
                        Else
                            Return strCaption
                        End If
                    End Get
                End Property

                Public ReadOnly Property CodeSet() As String
                    Get
                        If IsNothing(strCodeSet) = True Then
                            Return ""
                        Else
                            Return strCodeSet
                        End If
                    End Get
                End Property

                Public ReadOnly Property CurrentLanguage() As String
                    Get
                        If IsNothing(strCurrentLanguage) = True Then
                            Return ""
                        Else
                            Return strCurrentLanguage
                        End If
                    End Get
                End Property

                Public ReadOnly Property Description() As String
                    Get
                        If IsNothing(strDescription) = True Then
                            Return ""
                        Else
                            Return strDescription
                        End If
                    End Get
                End Property

                Public ReadOnly Property EmbeddedControllerMajorVersion() As Byte
                    Get
                        Return bytEmbeddedControllerMajorVersion
                    End Get
                End Property

                Public ReadOnly Property EmbeddedControllerMinorVersion() As Byte
                    Get
                        Return bytEmbeddedControllerMinorVersion
                    End Get
                End Property

                Public ReadOnly Property IdentificationCode() As String
                    Get
                        If IsNothing(strIdentificationCode) = True Then
                            Return ""
                        Else
                            Return strIdentificationCode
                        End If
                    End Get
                End Property

                Public ReadOnly Property InstallableLanguages() As UShort
                    Get
                        Return srtInstallableLanguages
                    End Get
                End Property

                Public ReadOnly Property InstallDate() As Date
                    Get
                        Return dtInstallDate
                    End Get
                End Property

                Public ReadOnly Property LanguageEdition() As String
                    Get
                        If IsNothing(strLanguageEdition) = True Then
                            Return ""
                        Else
                            Return strLanguageEdition
                        End If
                    End Get
                End Property

                Public ReadOnly Property Manufacturer() As String
                    Get
                        If IsNothing(strManufacturer) = True Then
                            Return ""
                        Else
                            Return strManufacturer
                        End If
                    End Get
                End Property

                Public ReadOnly Property OtherTargetOS() As String
                    Get
                        If IsNothing(strOtherTargetOS) = True Then
                            Return ""
                        Else
                            Return strOtherTargetOS
                        End If
                    End Get
                End Property

                Public ReadOnly Property PrimaryBIOS() As Boolean
                    Get
                        Return bolPrimaryBIOS
                    End Get
                End Property

                Public ReadOnly Property ReleaseDate() As String
                    Get
                        Return strReleaseDate
                    End Get
                End Property

                Public ReadOnly Property SerialNumber() As String
                    Get
                        If IsNothing(strSerialNumber) = True Then
                            Return ""
                        Else
                            Return strSerialNumber
                        End If
                    End Get
                End Property

                Public ReadOnly Property SMBIOSBIOSVersion() As String
                    Get
                        If IsNothing(strSMBIOSBIOSVersion) = True Then
                            Return ""
                        Else
                            Return strSMBIOSBIOSVersion
                        End If
                    End Get
                End Property

                Public ReadOnly Property SMBIOSMajorVersion() As UShort
                    Get
                        Return srtSMBIOSMajorVersion
                    End Get
                End Property

                Public ReadOnly Property SMBIOSMinorVersion() As UShort
                    Get
                        Return srtSMBIOSMinorVersion
                    End Get
                End Property

                Public ReadOnly Property SMBIOSPresent() As Boolean
                    Get
                        Return bolSMBIOSPresent
                    End Get
                End Property

                Public ReadOnly Property SoftwareElementID() As String
                    Get
                        If IsNothing(strSoftwareElementID) = True Then
                            Return ""
                        Else
                            Return strSoftwareElementID
                        End If
                    End Get
                End Property

                Public ReadOnly Property SoftwareElementState() As UShort
                    Get
                        Return srtSoftwareElementState
                    End Get
                End Property

                Public ReadOnly Property Status() As String
                    Get
                        If IsNothing(strStatus) = True Then
                            Return ""
                        Else
                            Return strStatus
                        End If
                    End Get
                End Property

                Public ReadOnly Property SystemBiosMajorVersion() As Byte
                    Get
                        Return bytSystemBiosMajorVersion
                    End Get
                End Property

                Public ReadOnly Property SystemBiosMinorVersion() As Byte
                    Get
                        Return bytSystemBiosMinorVersion
                    End Get
                End Property

                Public ReadOnly Property TargetOperatingSystem() As UShort
                    Get
                        Return srtTargetOperatingSystem
                    End Get
                End Property

                Public ReadOnly Property Version() As String
                    Get
                        If IsNothing(strVersion) = True Then
                            Return ""
                        Else
                            Return strVersion
                        End If
                    End Get
                End Property
#End Region



            End Class

        End Namespace
    End Namespace
End Namespace
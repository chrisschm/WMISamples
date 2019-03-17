Imports CS.System
Imports CS.System.IO

Public Class Form1


#Region "BIOS"
    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter

        Dim cBIOS As New BIOS
        Dim lstBIOSItem As ListViewItem
        Dim l As Long

        lstBIOS.Items.Clear()
        Application.DoEvents()

        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "BiosName"
        lstBIOSItem.SubItems.Add(cBIOS.BiosName.ToString)
        For l = 1 To cBIOS.BIOSVersion.Count
            lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
            lstBIOSItem.SubItems(0).Text = "BIOSVersion #" & l.ToString
            lstBIOSItem.SubItems.Add(cBIOS.BIOSVersion(l - 1).ToString)
        Next
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "BuildNumber"
        lstBIOSItem.SubItems.Add(cBIOS.BuildNumber.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Caption"
        lstBIOSItem.SubItems.Add(cBIOS.Caption.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "CodeSet"
        lstBIOSItem.SubItems.Add(cBIOS.CodeSet.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "CurrentLanguage"
        lstBIOSItem.SubItems.Add(cBIOS.CurrentLanguage.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Description"
        lstBIOSItem.SubItems.Add(cBIOS.Description.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "EmbeddedControllerMajorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.EmbeddedControllerMajorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "EmbeddedControllerMinorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.EmbeddedControllerMinorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "IdentificationCode"
        lstBIOSItem.SubItems.Add(cBIOS.IdentificationCode.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "InstallableLanguages"
        lstBIOSItem.SubItems.Add(cBIOS.InstallableLanguages.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "InstallDate"
        lstBIOSItem.SubItems.Add(cBIOS.InstallDate.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "LanguageEdition"
        lstBIOSItem.SubItems.Add(cBIOS.LanguageEdition.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Manufacturer"
        lstBIOSItem.SubItems.Add(cBIOS.Manufacturer.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "OtherTargetOS"
        lstBIOSItem.SubItems.Add(cBIOS.OtherTargetOS.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "PrimaryBIOS"
        lstBIOSItem.SubItems.Add(cBIOS.PrimaryBIOS.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "ReleaseDate"
        lstBIOSItem.SubItems.Add(cBIOS.ReleaseDate.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SerialNumber"
        lstBIOSItem.SubItems.Add(cBIOS.SerialNumber.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSBIOSVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSBIOSVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSMajorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSMajorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSMinorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSMinorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SMBIOSPresent"
        lstBIOSItem.SubItems.Add(cBIOS.SMBIOSPresent.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SoftwareElementID"
        lstBIOSItem.SubItems.Add(cBIOS.SoftwareElementID.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SoftwareElementState"
        lstBIOSItem.SubItems.Add(cBIOS.SoftwareElementState.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Status"
        lstBIOSItem.SubItems.Add(cBIOS.Status.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SystemBiosMajorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SystemBiosMajorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "SystemBiosMinorVersion"
        lstBIOSItem.SubItems.Add(cBIOS.SystemBiosMinorVersion.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "TargetOperatingSystem"
        lstBIOSItem.SubItems.Add(cBIOS.TargetOperatingSystem.ToString)
        lstBIOSItem = lstBIOS.Items.Add(New ListViewItem)
        lstBIOSItem.SubItems(0).Text = "Version"
        lstBIOSItem.SubItems.Add(cBIOS.Version.ToString)
    End Sub
#End Region

#Region "CoputerSystem"
    Private Sub TabPage4_Enter(sender As Object, e As EventArgs) Handles TabPage4.Enter

        Dim cCS As New ComputerSystem
        Dim lstCSItem As ListViewItem
        Dim l As Long

        lstComputer.Items.Clear()
        Application.DoEvents()

        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "AdminPasswordStatus"
        lstCSItem.SubItems.Add(cCS.AdminPasswordStatus.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "AutomaticManagedPagefile"
        lstCSItem.SubItems.Add(cCS.AutomaticManagedPagefile.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "AutomaticResetBootOption"
        lstCSItem.SubItems.Add(cCS.AutomaticResetBootOption.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "AutomaticResetCapability"
        lstCSItem.SubItems.Add(cCS.AutomaticResetCapability.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "BootOptionOnLimit"
        lstCSItem.SubItems.Add(cCS.BootOptionOnLimit.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "BootOptionOnWatchDog"
        lstCSItem.SubItems.Add(cCS.BootOptionOnWatchDog.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "BootROMSupported"
        lstCSItem.SubItems.Add(cCS.BootROMSupported.ToString)
        For l = 1 To cCS.BootStatus.Count
            lstCSItem = lstComputer.Items.Add(New ListViewItem)
            lstCSItem.SubItems(0).Text = "BootStatus #" & l.ToString
            lstCSItem.SubItems.Add(cCS.BootStatus(l - 1).ToString)
        Next
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "BootupState"
        lstCSItem.SubItems.Add(cCS.BootupState.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Caption"
        lstCSItem.SubItems.Add(cCS.Caption.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ChassisBootupState"
        lstCSItem.SubItems.Add(cCS.ChassisBootupState.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ChassisSKUNumber"
        lstCSItem.SubItems.Add(cCS.ChassisSKUNumber.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ComputerName"
        lstCSItem.SubItems.Add(cCS.ComputerName.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "CreationClassName"
        lstCSItem.SubItems.Add(cCS.CreationClassName.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "CurrentTimeZone"
        lstCSItem.SubItems.Add(cCS.CurrentTimeZone.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "DaylightInEffect"
        lstCSItem.SubItems.Add(cCS.DaylightInEffect.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Description"
        lstCSItem.SubItems.Add(cCS.Description.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "DNSHostName"
        lstCSItem.SubItems.Add(cCS.DNSHostName.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Domain"
        lstCSItem.SubItems.Add(cCS.Domain.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "DomainRole"
        lstCSItem.SubItems.Add(cCS.DomainRole.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "EnableDaylightSavingsTime"
        lstCSItem.SubItems.Add(cCS.EnableDaylightSavingsTime.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "FrontPanelResetStatus"
        lstCSItem.SubItems.Add(cCS.FrontPanelResetStatus.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "HypervisorPresent"
        lstCSItem.SubItems.Add(cCS.HypervisorPresent.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "InfraredSupported"
        lstCSItem.SubItems.Add(cCS.InfraredSupported.ToString)
        For l = 1 To cCS.InitialLoadInfo.Count
            lstCSItem = lstComputer.Items.Add(New ListViewItem)
            lstCSItem.SubItems(0).Text = "InitialLoadInfo #" & l.ToString
            lstCSItem.SubItems.Add(cCS.InitialLoadInfo(l - 1).ToString)
        Next
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "InstallDate"
        lstCSItem.SubItems.Add(cCS.InstallDate.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "KeyboardPasswordStatus"
        lstCSItem.SubItems.Add(cCS.KeyboardPasswordStatus.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "LastLoadInfo"
        lstCSItem.SubItems.Add(cCS.LastLoadInfo.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Manufacturer"
        lstCSItem.SubItems.Add(cCS.Manufacturer.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Model"
        lstCSItem.SubItems.Add(cCS.Model.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "NameFormat"
        lstCSItem.SubItems.Add(cCS.NameFormat.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "NetworkServerModeEnabled"
        lstCSItem.SubItems.Add(cCS.NetworkServerModeEnabled.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "NumberOfLogicalProcessors"
        lstCSItem.SubItems.Add(cCS.NumberOfLogicalProcessors.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "NumberOfProcessors"
        lstCSItem.SubItems.Add(cCS.NumberOfProcessors.ToString)
        For l = 1 To cCS.OEMLogoBitmap.Count
            lstCSItem = lstComputer.Items.Add(New ListViewItem)
            lstCSItem.SubItems(0).Text = "OEMLogoBitmap #" & l.ToString
            lstCSItem.SubItems.Add(cCS.OEMLogoBitmap(l - 1).ToString)
        Next
        For l = 1 To cCS.OEMStringArray.Count
            lstCSItem = lstComputer.Items.Add(New ListViewItem)
            lstCSItem.SubItems(0).Text = "OEMStringArray #" & l.ToString
            lstCSItem.SubItems.Add(cCS.OEMStringArray(l - 1).ToString)
        Next
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PartOfDomain"
        lstCSItem.SubItems.Add(cCS.PartOfDomain.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PauseAfterReset"
        lstCSItem.SubItems.Add(cCS.PauseAfterReset.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PCSystemType"
        lstCSItem.SubItems.Add(cCS.PCSystemType.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PCSystemTypeEx"
        lstCSItem.SubItems.Add(cCS.PCSystemTypeEx.ToString)
        If cCS.PowerManagementSupported = True Then
            For l = 1 To cCS.PowerManagementCapabilities.Count
                lstCSItem = lstComputer.Items.Add(New ListViewItem)
                lstCSItem.SubItems(0).Text = "PowerManagementCapabilities #" & l.ToString
                lstCSItem.SubItems.Add(cCS.PowerManagementCapabilities(l - 1).ToString)
            Next
        End If
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PowerManagementSupported"
        lstCSItem.SubItems.Add(cCS.PowerManagementSupported.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PowerOnPasswordStatus"
        lstCSItem.SubItems.Add(cCS.PowerOnPasswordStatus.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PowerState"
        lstCSItem.SubItems.Add(cCS.PowerState.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PowerSupplyState"
        lstCSItem.SubItems.Add(cCS.PowerSupplyState.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PrimaryOwnerContact"
        lstCSItem.SubItems.Add(cCS.PrimaryOwnerContact.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "PrimaryOwnerName"
        lstCSItem.SubItems.Add(cCS.PrimaryOwnerName.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ResetCapability"
        lstCSItem.SubItems.Add(cCS.ResetCapability.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ResetCount"
        lstCSItem.SubItems.Add(cCS.ResetCount.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ResetLimit"
        lstCSItem.SubItems.Add(cCS.ResetLimit.ToString)
        For l = 1 To cCS.Roles.Count
            lstCSItem = lstComputer.Items.Add(New ListViewItem)
            lstCSItem.SubItems(0).Text = "Roles #" & l.ToString
            lstCSItem.SubItems.Add(cCS.Roles(l - 1).ToString)
        Next
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Status"
        lstCSItem.SubItems.Add(cCS.Status.ToString)
        For l = 1 To cCS.SupportContactDescription.Count
            lstCSItem = lstComputer.Items.Add(New ListViewItem)
            lstCSItem.SubItems(0).Text = "SupportContactDescription #" & l.ToString
            lstCSItem.SubItems.Add(cCS.SupportContactDescription(l - 1).ToString)
        Next
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "SystemFamily"
        lstCSItem.SubItems.Add(cCS.SystemFamily.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "SystemSKUNumber"
        lstCSItem.SubItems.Add(cCS.SystemSKUNumber.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "SystemType"
        lstCSItem.SubItems.Add(cCS.SystemType.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "ThermalState"
        lstCSItem.SubItems.Add(cCS.ThermalState.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "TotalPhysicalMemory"
        lstCSItem.SubItems.Add(cCS.TotalPhysicalMemory.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "UserName"
        lstCSItem.SubItems.Add(cCS.UserName.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "WakeUpType"
        lstCSItem.SubItems.Add(cCS.WakeUpType.ToString)
        lstCSItem = lstComputer.Items.Add(New ListViewItem)
        lstCSItem.SubItems(0).Text = "Workgroup"
        lstCSItem.SubItems.Add(cCS.Workgroup.ToString)
    End Sub
#End Region

#Region "DiskDrives"
    Private dds As DiskDrives

    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click

        dds = New DiskDrives

        CBModel.Items.Clear()
        Application.DoEvents()

        For Each dd As DiskDrive In dds
            CBModel.Items.Add(dd.Model & " (" & dd.SerialNumber & ")")
        Next

        CBModel.SelectedIndex = 0

    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged

        Dim serial As String
        Dim l As Long
        Dim lstvItem As ListViewItem

        If dds.Count = 0 Then Exit Sub

        serial = CBModel.Text
        l = InStr(serial, "(")
        serial = Mid(serial, l + 1, serial.Length - l - 1)

        lstDrive.Items.Clear()
        Application.DoEvents()

        For Each dd As DiskDrive In dds

            If dd.SerialNumber = serial Then
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Availability"
                lstvItem.SubItems.Add(dd.Availability.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "BytesPerSector"
                lstvItem.SubItems.Add(dd.BytesPerSector.ToString)
                For l = 1 To dd.Capabilities.Count
                    lstvItem = lstDrive.Items.Add(New ListViewItem)
                    lstvItem.SubItems(0).Text = "Capabilities #" & l.ToString
                    lstvItem.SubItems.Add(dd.Capabilities(l - 1).ToString)
                Next
                For l = 1 To dd.CapabilityDescriptions.Count
                    lstvItem = lstDrive.Items.Add(New ListViewItem)
                    lstvItem.SubItems(0).Text = "CapabilityDescriptions #" & l.ToString
                    lstvItem.SubItems.Add(dd.CapabilityDescriptions(l - 1).ToString)
                Next
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Caption"
                lstvItem.SubItems.Add(dd.Caption.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CompressionMethod"
                lstvItem.SubItems.Add(dd.CompressionMethod.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerErrorCode"
                lstvItem.SubItems.Add(dd.ConfigManagerErrorCode.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerUserConfig"
                lstvItem.SubItems.Add(dd.ConfigManagerUserConfig.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CreationClassName"
                lstvItem.SubItems.Add(dd.CreationClassName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DefaultBlockSize"
                lstvItem.SubItems.Add(dd.DefaultBlockSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Description"
                lstvItem.SubItems.Add(dd.Description.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceID"
                lstvItem.SubItems.Add(dd.DeviceID.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceIndex"
                lstvItem.SubItems.Add(dd.DeviceIndex.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceName"
                lstvItem.SubItems.Add(dd.DeviceName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorCleared"
                lstvItem.SubItems.Add(dd.ErrorCleared.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorDescription"
                lstvItem.SubItems.Add(dd.ErrorDescription.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorMethodology"
                lstvItem.SubItems.Add(dd.ErrorMethodology.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "FirmwareRevision"
                lstvItem.SubItems.Add(dd.FirmwareRevision.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InstallDate"
                lstvItem.SubItems.Add(dd.InstallDate.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InterfaceType"
                lstvItem.SubItems.Add(dd.InterfaceType.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "LastErrorCode"
                lstvItem.SubItems.Add(dd.LastErrorCode.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Manufacturer"
                lstvItem.SubItems.Add(dd.Manufacturer.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MaxBlockSize"
                lstvItem.SubItems.Add(dd.MaxBlockSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MaxMediaSize"
                lstvItem.SubItems.Add(dd.MaxMediaSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MediaLoaded"
                lstvItem.SubItems.Add(dd.MediaLoaded.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MediaType"
                lstvItem.SubItems.Add(dd.MediaType.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MinBlockSize"
                lstvItem.SubItems.Add(dd.MinBlockSize.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Model"
                lstvItem.SubItems.Add(dd.Model.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "NeedsCleaning"
                lstvItem.SubItems.Add(dd.NeedsCleaning.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "NumberOfMediaSupported"
                lstvItem.SubItems.Add(dd.NumberOfMediaSupported.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Partitions"
                lstvItem.SubItems.Add(dd.Partitions.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PNPDeviceID"
                lstvItem.SubItems.Add(dd.PNPDeviceID.ToString)
                If dd.PowerManagementSupported = True Then
                    For l = 1 To dd.PowerManagementCapabilities.Count
                        lstvItem = lstDrive.Items.Add(New ListViewItem)
                        lstvItem.SubItems(0).Text = "PowerManagementCapabilities #" & l.ToString
                        lstvItem.SubItems.Add(dd.PowerManagementCapabilities(l - 1).ToString)
                    Next
                End If
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PowerManagementSupported"
                lstvItem.SubItems.Add(dd.PowerManagementSupported.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSIBus"
                lstvItem.SubItems.Add(dd.SCSIBus.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSILogicalUnit"
                lstvItem.SubItems.Add(dd.SCSILogicalUnit.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSIPort"
                lstvItem.SubItems.Add(dd.SCSIPort.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SCSITargetId"
                lstvItem.SubItems.Add(dd.SCSITargetId.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SectorsPerTrack"
                lstvItem.SubItems.Add(dd.SectorsPerTrack.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SerialNumber"
                lstvItem.SubItems(0).ForeColor = Color.Red
                lstvItem.SubItems.Add(dd.SerialNumber.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Signature"
                lstvItem.SubItems.Add(dd.Signature.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Size"
                lstvItem.SubItems.Add(dd.Size.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Status"
                lstvItem.SubItems.Add(dd.Status.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "StatusInfo"
                lstvItem.SubItems.Add(dd.StatusInfo.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemCreationClassName"
                lstvItem.SubItems.Add(dd.SystemCreationClassName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemName"
                lstvItem.SubItems.Add(dd.SystemName.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalCylinders"
                lstvItem.SubItems.Add(dd.TotalCylinders.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalHeads"
                lstvItem.SubItems.Add(dd.TotalHeads.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalSectors"
                lstvItem.SubItems.Add(dd.TotalSectors.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TotalTracks"
                lstvItem.SubItems.Add(dd.TotalTracks.ToString)
                lstvItem = lstDrive.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TracksPerCylinder"
                lstvItem.SubItems.Add(dd.TracksPerCylinder.ToString)
                Exit For
            End If

        Next

    End Sub
#End Region

#Region "DiskPartitions"
    Private dps As DiskPartitions

    Private Sub cmdPRead_Click(sender As Object, e As EventArgs) Handles cmdPRead.Click

        dps = New DiskPartitions

        CMPName.Items.Clear()
        Application.DoEvents()

        For Each dp As DiskPartition In dps
            CMPName.Items.Add(dp.DeviceID.ToString)
        Next

        CMPName.SelectedIndex = 0

    End Sub

    Private Sub CMPName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMPName.SelectedIndexChanged

        Dim lstvItem As ListViewItem

        lstPartition.Items.Clear()
        Application.DoEvents()

        For Each dp As DiskPartition In dps
            If dp.DeviceID.ToString = CMPName.Text Then
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Access"
                lstvItem.SubItems.Add(dp.Access.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Availability"
                lstvItem.SubItems.Add(dp.Availability.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "BlockSize"
                lstvItem.SubItems.Add(dp.BlockSize.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Bootable"
                lstvItem.SubItems.Add(dp.Bootable.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "BootPartition"
                lstvItem.SubItems.Add(dp.BootPartition.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Caption"
                lstvItem.SubItems.Add(dp.Caption.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerErrorCode"
                lstvItem.SubItems.Add(dp.ConfigManagerErrorCode.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ConfigManagerUserConfig"
                lstvItem.SubItems.Add(dp.ConfigManagerUserConfig.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CreationClassName"
                lstvItem.SubItems.Add(dp.CreationClassName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Description"
                lstvItem.SubItems.Add(dp.Description.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DeviceID"
                lstvItem.SubItems(0).ForeColor = Color.Red
                lstvItem.SubItems.Add(dp.DeviceID.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DiskIndex"
                lstvItem.SubItems.Add(dp.DiskIndex.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DiskName"
                lstvItem.SubItems.Add(dp.DiskName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorCleared"
                lstvItem.SubItems.Add(dp.ErrorCleared.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorDescription"
                lstvItem.SubItems.Add(dp.ErrorDescription.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorMethodology"
                lstvItem.SubItems.Add(dp.ErrorMethodology.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "HiddenSectors"
                lstvItem.SubItems.Add(dp.HiddenSectors.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InstallDate"
                lstvItem.SubItems.Add(dp.InstallDate.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "LastErrorCode"
                lstvItem.SubItems.Add(dp.LastErrorCode.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "NumberOfBlocks"
                lstvItem.SubItems.Add(dp.NumberOfBlocks.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PartitionIndex"
                lstvItem.SubItems.Add(dp.PartitionIndex.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PNPDeviceID"
                lstvItem.SubItems.Add(dp.PNPDeviceID.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PrimaryPartition"
                lstvItem.SubItems.Add(dp.PrimaryPartition.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Purpose"
                lstvItem.SubItems.Add(dp.Purpose.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "RewritePartition"
                lstvItem.SubItems.Add(dp.RewritePartition.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Size"
                lstvItem.SubItems.Add(dp.Size.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "StartingOffset"
                lstvItem.SubItems.Add(dp.StartingOffset.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Status"
                lstvItem.SubItems.Add(dp.Status.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemCreationClassName"
                lstvItem.SubItems.Add(dp.SystemCreationClassName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemName"
                lstvItem.SubItems.Add(dp.SystemName.ToString)
                lstvItem = lstPartition.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Type"
                lstvItem.SubItems.Add(dp.Type.ToString)
                Exit For
            End If
        Next

    End Sub
#End Region

#Region "OperatingSystem"
    Private Sub TabPage8_Enter(sender As Object, e As EventArgs) Handles TabPage8.Enter

        Dim cOS As New OperatingSystem
        Dim lstOSItem As ListViewItem
        Dim l As Long

        lstOS.Items.Clear()
        Application.DoEvents()

        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "BootDevice"
        lstOSItem.SubItems.Add(cOS.BootDevice.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "BuildNumber"
        lstOSItem.SubItems.Add(cOS.BuildNumber.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "BuildType"
        lstOSItem.SubItems.Add(cOS.BuildType.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Caption"
        lstOSItem.SubItems.Add(cOS.Caption.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CodeSet"
        lstOSItem.SubItems.Add(cOS.CodeSet.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CountryCode"
        lstOSItem.SubItems.Add(cOS.CountryCode.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CreationClassName"
        lstOSItem.SubItems.Add(cOS.CreationClassName.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CSCreationClassName"
        lstOSItem.SubItems.Add(cOS.CSCreationClassName.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CSDVersion"
        lstOSItem.SubItems.Add(cOS.CSDVersion.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CSName"
        lstOSItem.SubItems.Add(cOS.CSName.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "CurrentTimeZone"
        lstOSItem.SubItems.Add(cOS.CurrentTimeZone.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "DataExecutionPrevention_32BitApplications"
        lstOSItem.SubItems.Add(cOS.DataExecutionPrevention_32BitApplications.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "DataExecutionPrevention_Available"
        lstOSItem.SubItems.Add(cOS.DataExecutionPrevention_Available.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "DataExecutionPrevention_Drivers"
        lstOSItem.SubItems.Add(cOS.DataExecutionPrevention_Drivers.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "DataExecutionPrevention_SupportPolicy"
        lstOSItem.SubItems.Add(cOS.DataExecutionPrevention_SupportPolicy.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Debug"
        lstOSItem.SubItems.Add(cOS.Debug.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Description"
        lstOSItem.SubItems.Add(cOS.Description.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Distributed"
        lstOSItem.SubItems.Add(cOS.Distributed.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "EncryptionLevel"
        lstOSItem.SubItems.Add(cOS.EncryptionLevel.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "ForegroundApplicationBoost"
        lstOSItem.SubItems.Add(cOS.ForegroundApplicationBoost.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "FreePhysicalMemory"
        lstOSItem.SubItems.Add(cOS.FreePhysicalMemory.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "FreeSpaceInPagingFiles"
        lstOSItem.SubItems.Add(cOS.FreeSpaceInPagingFiles.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "FreeVirtualMemory"
        lstOSItem.SubItems.Add(cOS.FreeVirtualMemory.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "InstallDate"
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "LastBootUpTime"
        lstOSItem.SubItems.Add(cOS.LastBootUpTime.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "LocalDateTime"
        lstOSItem.SubItems.Add(cOS.LocalDateTime.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Locale"
        lstOSItem.SubItems.Add(cOS.Locale.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Manufacturer"
        lstOSItem.SubItems.Add(cOS.Manufacturer.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "MaxNumberOfProcesses"
        lstOSItem.SubItems.Add(cOS.MaxNumberOfProcesses.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "MaxProcessMemorySize"
        lstOSItem.SubItems.Add(cOS.MaxProcessMemorySize.ToString)
        For l = 1 To cOS.MUILanguages.Count
            lstOSItem = lstOS.Items.Add(New ListViewItem)
            lstOSItem.SubItems(0).Text = "MUILanguages #" & l.ToString
            lstOSItem.SubItems.Add(cOS.MUILanguages(l - 1).ToString)
        Next
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "NumberOfLicensedUsers"
        lstOSItem.SubItems.Add(cOS.NumberOfLicensedUsers.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "NumberOfProcesses"
        lstOSItem.SubItems.Add(cOS.NumberOfProcesses.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "NumberOfUsers"
        lstOSItem.SubItems.Add(cOS.NumberOfUsers.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OperatingSystemSKU"
        lstOSItem.SubItems.Add(cOS.OperatingSystemSKU.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Organization"
        lstOSItem.SubItems.Add(cOS.Organization.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OSArchitecture"
        lstOSItem.SubItems.Add(cOS.OSArchitecture.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OSLanguage"
        lstOSItem.SubItems.Add(cOS.OSLanguage.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OSName"
        lstOSItem.SubItems.Add(cOS.OSName.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OSProductSuite"
        lstOSItem.SubItems.Add(cOS.OSProductSuite.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OSType"
        lstOSItem.SubItems.Add(cOS.OSType.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "OtherTypeDescription"
        lstOSItem.SubItems.Add(cOS.OtherTypeDescription.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "PAEEnabled"
        lstOSItem.SubItems.Add(cOS.PAEEnabled.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "PortableOperatingSystem"
        lstOSItem.SubItems.Add(cOS.PortableOperatingSystem.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Primary"
        lstOSItem.SubItems.Add(cOS.Primary.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "ProductType"
        lstOSItem.SubItems.Add(cOS.ProductType.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "QuantumLength"
        lstOSItem.SubItems.Add(cOS.QuantumLength.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "QuantumType"
        lstOSItem.SubItems.Add(cOS.QuantumType.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "RegisteredUser"
        lstOSItem.SubItems.Add(cOS.RegisteredUser.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "SerialNumber"
        lstOSItem.SubItems.Add(cOS.SerialNumber.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "ServicePackMajorVersion"
        lstOSItem.SubItems.Add(cOS.ServicePackMajorVersion.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "ServicePackMinorVersion"
        lstOSItem.SubItems.Add(cOS.ServicePackMinorVersion.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "SizeStoredInPagingFiles"
        lstOSItem.SubItems.Add(cOS.SizeStoredInPagingFiles.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Status"
        lstOSItem.SubItems.Add(cOS.Status.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "SuiteMask"
        lstOSItem.SubItems.Add(cOS.SuiteMask.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "SystemDevice"
        lstOSItem.SubItems.Add(cOS.SystemDevice.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "SystemDirectory"
        lstOSItem.SubItems.Add(cOS.SystemDirectory.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "SystemDrive"
        lstOSItem.SubItems.Add(cOS.SystemDrive.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "TotalSwapSpaceSize"
        lstOSItem.SubItems.Add(cOS.TotalSwapSpaceSize.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "TotalVirtualMemorySize"
        lstOSItem.SubItems.Add(cOS.TotalVirtualMemorySize.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "TotalVisibleMemorySize"
        lstOSItem.SubItems.Add(cOS.TotalVisibleMemorySize.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "Version"
        lstOSItem.SubItems.Add(cOS.Version.ToString)
        lstOSItem = lstOS.Items.Add(New ListViewItem)
        lstOSItem.SubItems(0).Text = "WindowsDirectory"
        lstOSItem.SubItems.Add(cOS.WindowsDirectory.ToString)
    End Sub
#End Region

#Region "Processor"
    Private Sub TabPage5_Enter(sender As Object, e As EventArgs) Handles TabPage5.Enter

        Dim cP As New Processor
        Dim lstPItem As ListViewItem
        Dim l As Long

        lstProcessor.Items.Clear()
        Application.DoEvents()

        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "AddressWidth"
        lstPItem.SubItems.Add(cP.AddressWidth.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Architecture"
        lstPItem.SubItems.Add(cP.Architecture.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "AssetTag"
        lstPItem.SubItems.Add(cP.AssetTag.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Availability"
        lstPItem.SubItems.Add(cP.Availability.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Caption"
        lstPItem.SubItems.Add(cP.Caption.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Characteristics"
        lstPItem.SubItems.Add(cP.Characteristics.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ConfigManagerErrorCode"
        lstPItem.SubItems.Add(cP.ConfigManagerErrorCode.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ConfigManagerUserConfig"
        lstPItem.SubItems.Add(cP.ConfigManagerUserConfig.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "CpuStatus"
        lstPItem.SubItems.Add(cP.CpuStatus.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "CreationClassName"
        lstPItem.SubItems.Add(cP.CreationClassName.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "CurrentClockSpeed"
        lstPItem.SubItems.Add(cP.CurrentClockSpeed.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "CurrentVoltage"
        lstPItem.SubItems.Add(cP.CurrentVoltage.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "DataWidth"
        lstPItem.SubItems.Add(cP.DataWidth.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Description"
        lstPItem.SubItems.Add(cP.Description.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "DeviceID"
        lstPItem.SubItems.Add(cP.DeviceID.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ErrorCleared"
        lstPItem.SubItems.Add(cP.ErrorCleared.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ErrorDescription"
        lstPItem.SubItems.Add(cP.ErrorDescription.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ExtClock"
        lstPItem.SubItems.Add(cP.ExtClock.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Family"
        lstPItem.SubItems.Add(cP.Family.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "InstallDate"
        lstPItem.SubItems.Add(cP.InstallDate.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "L2CacheSize"
        lstPItem.SubItems.Add(cP.L2CacheSize.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "L2CacheSpeed"
        lstPItem.SubItems.Add(cP.L2CacheSpeed.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "L3CacheSize"
        lstPItem.SubItems.Add(cP.L3CacheSize.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "L3CacheSpeed"
        lstPItem.SubItems.Add(cP.L3CacheSpeed.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "LastErrorCode"
        lstPItem.SubItems.Add(cP.LastErrorCode.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Level"
        lstPItem.SubItems.Add(cP.Level.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "LoadPercentage"
        lstPItem.SubItems.Add(cP.LoadPercentage.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Manufacturer"
        lstPItem.SubItems.Add(cP.Manufacturer.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "MaxClockSpeed"
        lstPItem.SubItems.Add(cP.MaxClockSpeed.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "NumberOfCores"
        lstPItem.SubItems.Add(cP.NumberOfCores.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "NumberOfEnabledCore"
        lstPItem.SubItems.Add(cP.NumberOfEnabledCore.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "NumberOfLogicalProcessors"
        lstPItem.SubItems.Add(cP.NumberOfLogicalProcessors.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "OtherFamilyDescription"
        lstPItem.SubItems.Add(cP.OtherFamilyDescription.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "PartNumber"
        lstPItem.SubItems.Add(cP.PartNumber.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "PNPDeviceID"
        lstPItem.SubItems.Add(cP.PNPDeviceID.ToString)
        If cP.PowerManagementSupported = True Then
            For l = 1 To cP.PowerManagementCapabilities.Count
                lstPItem = lstProcessor.Items.Add(New ListViewItem)
                lstPItem.SubItems(0).Text = "PowerManagementCapabilities #" & l.ToString
                lstPItem.SubItems.Add(cP.PowerManagementCapabilities(l - 1).ToString)
            Next
        End If
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "PowerManagementSupported"
        lstPItem.SubItems.Add(cP.PowerManagementSupported.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ProcessorId"
        lstPItem.SubItems.Add(cP.ProcessorId.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ProcessorName"
        lstPItem.SubItems.Add(cP.ProcessorName.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ProcessorType"
        lstPItem.SubItems.Add(cP.ProcessorType.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Revision"
        lstPItem.SubItems.Add(cP.Revision.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Role"
        lstPItem.SubItems.Add(cP.Role.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "SecondLevelAddressTranslationExtensions"
        lstPItem.SubItems.Add(cP.SecondLevelAddressTranslationExtensions.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "SerialNumber"
        lstPItem.SubItems.Add(cP.SerialNumber.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "SocketDesignation"
        lstPItem.SubItems.Add(cP.SocketDesignation.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Status"
        lstPItem.SubItems.Add(cP.Status.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "StatusInfo"
        lstPItem.SubItems.Add(cP.StatusInfo.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Stepping"
        lstPItem.SubItems.Add(cP.Stepping.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "SystemCreationClassName"
        lstPItem.SubItems.Add(cP.SystemCreationClassName.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "SystemName"
        lstPItem.SubItems.Add(cP.SystemName.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "ThreadCount"
        lstPItem.SubItems.Add(cP.ThreadCount.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "UniqueId"
        lstPItem.SubItems.Add(cP.UniqueId.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "UpgradeMethod"
        lstPItem.SubItems.Add(cP.UpgradeMethod.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "Version"
        lstPItem.SubItems.Add(cP.Version.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "VirtualizationFirmwareEnabled"
        lstPItem.SubItems.Add(cP.VirtualizationFirmwareEnabled.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "VMMonitorModeExtensions"
        lstPItem.SubItems.Add(cP.VMMonitorModeExtensions.ToString)
        lstPItem = lstProcessor.Items.Add(New ListViewItem)
        lstPItem.SubItems(0).Text = "VoltageCaps"
        lstPItem.SubItems.Add(cP.VoltageCaps.ToString)
    End Sub
#End Region

#Region "Services"
    Private Ss As Services

    Private Sub cmdService_Click(sender As Object, e As EventArgs) Handles cmdService.Click

        Ss = New Services

        CBService.Items.Clear()
        Application.DoEvents()

        For Each S As Service In Ss
            CBService.Items.Add(S.ServiceName.ToString)
        Next

        CBService.SelectedIndex = 0

    End Sub

    Private Sub CBService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBService.SelectedIndexChanged

        Dim lstvItem As ListViewItem

        lstService.Items.Clear()
        Application.DoEvents()

        For Each S As Service In Ss
            If S.ServiceName.ToString = CBService.Text Then
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "AcceptPause"
                lstvItem.SubItems.Add(S.AcceptPause.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "AcceptStop"
                lstvItem.SubItems.Add(S.AcceptStop.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Caption"
                lstvItem.SubItems.Add(S.Caption.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CheckPoint"
                lstvItem.SubItems.Add(S.CheckPoint.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "CreationClassName"
                lstvItem.SubItems.Add(S.CreationClassName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DelayedAutoStart"
                lstvItem.SubItems.Add(S.DelayedAutoStart.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Description"
                lstvItem.SubItems.Add(S.Description.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DesktopInteract"
                lstvItem.SubItems.Add(S.DesktopInteract.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "DisplayName"
                lstvItem.SubItems.Add(S.DisplayName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ErrorControl"
                lstvItem.SubItems.Add(S.ErrorControl.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ExitCode"
                lstvItem.SubItems.Add(S.ExitCode.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InstallDate"
                lstvItem.SubItems.Add(S.InstallDate.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "PathName"
                lstvItem.SubItems.Add(S.PathName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ProcessId"
                lstvItem.SubItems.Add(S.ProcessId.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ServiceName"
                lstvItem.SubItems(0).ForeColor = Color.Red
                lstvItem.SubItems.Add(S.ServiceName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ServiceSpecificExitCode"
                lstvItem.SubItems.Add(S.ServiceSpecificExitCode.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ServiceType"
                lstvItem.SubItems.Add(S.ServiceType.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Started"
                lstvItem.SubItems.Add(S.Started.ToString)
                lstvItem.SubItems.Add(S.ServiceType.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "StartMode"
                lstvItem.SubItems.Add(S.StartMode.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "StartName"
                lstvItem.SubItems.Add(S.StartName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "State"
                lstvItem.SubItems.Add(S.State.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Status"
                lstvItem.SubItems.Add(S.Status.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemCreationClassName"
                lstvItem.SubItems.Add(S.SystemCreationClassName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "SystemName"
                lstvItem.SubItems.Add(S.SystemName.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "TagId"
                lstvItem.SubItems.Add(S.TagId.ToString)
                lstvItem = lstService.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "WaitHint"
                lstvItem.SubItems.Add(S.WaitHint.ToString)
                Exit For
            End If
        Next

    End Sub
#End Region

#Region "Share"
    Private SHs As Shares

    Private Sub cmdShare_Click(sender As Object, e As EventArgs) Handles cmdShare.Click

        SHs = New Shares

        CBShare.Items.Clear()
        Application.DoEvents()

        For Each sh As Share In SHs
            CBShare.Items.Add(sh.ShareName)
        Next

        CBShare.SelectedIndex = 0

    End Sub

    Private Sub CBShare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBShare.SelectedIndexChanged

        Dim lstvItem As ListViewItem

        lstShare.Items.Clear()
        Application.DoEvents()

        For Each sh As Share In SHs
            If sh.ShareName.ToString = CBShare.Text Then
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "AllowMaximum"
                lstvItem.SubItems.Add(sh.AllowMaximum.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Caption"
                lstvItem.SubItems.Add(sh.Caption.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Description"
                lstvItem.SubItems.Add(sh.Description.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "InstallDate"
                lstvItem.SubItems.Add(sh.InstallDate.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "MaximumAllowed"
                lstvItem.SubItems.Add(sh.MaximumAllowed.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Path"
                lstvItem.SubItems.Add(sh.Path.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "ShareName"
                lstvItem.SubItems.Add(sh.ShareName.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Status"
                lstvItem.SubItems.Add(sh.Status.ToString)
                lstvItem = lstShare.Items.Add(New ListViewItem)
                lstvItem.SubItems(0).Text = "Type"
                lstvItem.SubItems.Add(sh.Type.ToString)
                Exit For
            End If
        Next
    End Sub
#End Region



End Class

Option Infer On
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Math
Imports RuleStream
Imports RuleStream.Kernel
Imports RulestreamTCUtilities
Namespace APCTMP01
	Public Class APC_Scan_Configuration
	Inherits RuleStream.Kernel.Part
		Function Result(ByVal thisPart As IRsObject, ByVal thatPart as IRsObject, ByVal propertyName As String, ByVal context As String, ByVal Value as Object, ByVal OldValue as Object) As Object
			' Using AxEvaluator62
			Dim this as APC_Scan_Configuration = CType(thisPart, Part)
			Dim that as APC_Scan_Configuration = CType(thatPart, Part)
			Dim ctx as Object
			Dim __rsMyProp as PropertySF
			Dim __rsMyPropName as String
Result = 0.0

	'=IF(K105>0,K105,MAX(L89:L94))

For Each p As part In Me.Panel_Configs
	If P.Properties("Is_Scanned").Value = True Then
		If P.Properties("Min_Gap_Required").Value > Result Then
			Result = P.Properties("Min_Gap_Required").Value
		End If
	End If
Next p

If MinGapOverride_Vendor_Provider_IN > Result Then
	Result = MinGapOverRide_Vendor_Provider_IN
End If
		End Function
Public [AppType] as String
Public [BoxPanelsScanned] as Long
Public [CartonPresentation] as String
Public [FrontBack_Scanner_Count] as Long
Public [GapControlMethod] as String
Public [LaserOmniSideApp] as Boolean
Public [MinGapForScan_IN] as Double
Public [MinGapOverride_Vendor_Provider_IN] as Double
Public [MinGapOverride_Vendor_Provider_MM] as Double
Public [MinGapOverride_Vendor_Provider_User] as Double
Public [MinGapRequired_IN] as Double
Public [MinGapRequired_User] as Double
Public [MinGapRequired_User_UOM] as String
Public [PartNumber] as String
Public [ReadWindowSize_IN] as Double
Public [ReadWindowSize_MM] as Double
Public [ReadWindowSize_USER] as Double
Public [ReadWindowSize_Vendor_Supplied_IN] as Double
Public [ReadWindowSize_Vendor_Supplied_MM] as Double
Public [ReadWindowSize_Vendor_Supplied_USER] as Double
Public [ShadowingPotential] as Boolean
Public [ShadowingStatus] as String
Public [UsePandAMTBH] as Boolean
Public [User_UOM_System] as String

Public [My_PRD] as Connection
Public [MySetup] as Connection
Public [Panel_Config_Back] as Connection
Public [Panel_Config_Bottom] as Connection
Public [Panel_Config_Front] as Connection
Public [Panel_Config_Left] as Connection
Public [Panel_Config_Right] as Connection
Public [Panel_Config_Top] as Connection

Public [Panel_Configs] as Connection

	End Class
End Namespace

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

If MinGapOverRide_Venfor_Provided_IN > Result Then
	Result = MinGapOverRide_Venfor_Provided_IN
end if
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
'Error #BC40056:Namespace or type specified in the Imports 'TeamcenterDriver' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases. occurred on line#28 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42105:Function 'RemoveCommaStringDuplicates' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used. occurred on line#393 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC30451:'MinGapOverRide_Venfor_Provided_IN' is not declared. It may be inaccessible due to its protection level. occurred on line#36 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712102730.vb | iswarning=False 
'Error #BC30451:'MinGapOverRide_Venfor_Provided_IN' is not declared. It may be inaccessible due to its protection level. occurred on line#37 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712102730.vb | iswarning=False 
'Error #BC42024:Unused local variable: 'ctx'. occurred on line#21 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712102730.vb | iswarning=True 
'Error #BC42024:Unused local variable: '__rsMyProp'. occurred on line#22 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712102730.vb | iswarning=True 
'Error #BC42024:Unused local variable: '__rsMyPropName'. occurred on line#23 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712102730.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#238 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#240 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#242 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#244 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#247 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#258 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#269 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#271 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#273 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#275 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#296 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42104:Variable 'result' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1328 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'system' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1612 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sysDelta' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1654 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sys1' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1704 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sys2' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1705 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sysDelta' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1717 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sysDelta' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1749 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sys1' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1799 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sys2' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1800 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42104:Variable 'sysDelta' is used before it has been assigned a value. A null reference exception could result at runtime. occurred on line#1812 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4801 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4827 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4840 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4865 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4903 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4911 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4929 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4943 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4953 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4984 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4993 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#4999 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5009 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5015 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5051 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5060 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5071 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5084 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5094 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5107 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5119 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5133 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5159 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5173 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5185 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5197 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5207 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5221 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5230 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5241 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5244 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5257 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5265 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5279 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5285 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5299 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5310 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5318 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5333 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5343 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5354 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5365 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5376 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5393 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5403 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5420 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5431 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5439 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5452 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5463 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5476 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5489 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5503 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5527 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5539 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5565 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5578 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5587 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5622 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5642 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5654 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5665 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5677 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5685 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5697 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5706 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5720 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5764 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42353:Function 'RS_PLIDoubleCheckCheckOutStatus' doesn't return a value on all code paths. Are you missing a 'Return' statement? occurred on line#5765 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5774 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5783 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5794 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5803 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5813 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5825 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5834 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5846 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5857 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5881 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5891 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5899 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5909 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5921 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5930 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5943 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5953 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5966 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 
'Error #BC42025:Access of shared member, constant member, enum member or nested type through an instance; qualifying expression will not be evaluated. occurred on line#5980 of module C:\ProgramData\RuleStream\2412.0000\Modules\Common.vb | iswarning=True 

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
	Public Class APC_Scan_Panel_Configuration
	Inherits RuleStream.Kernel.Part
		Function Result(ByVal thisPart As IRsObject, ByVal thatPart as IRsObject, ByVal propertyName As String, ByVal context As String, ByVal Value as Object, ByVal OldValue as Object) As Object
			' Using AxEvaluator62
			Dim this as APC_Scan_Panel_Configuration = CType(thisPart, Part)
			Dim that as APC_Scan_Panel_Configuration = CType(thatPart, Part)
			Dim ctx as Object
			Dim __rsMyProp as PropertySF
			Dim __rsMyPropName as String
Result = 0.0

If Me.Is_Scanned Then
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_Underside As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Underside")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	
	Select Case Me.Panel_ID
		Case "Top"
			'T =If(C89="Yes",If(And(I89=45,C94="Yes",H93="Overhead"),3,If(I89=90,1,If(And(GapControlMethod="Passive",ScanConfigAUsePandAMTBH="No"),2,3))),"")
			If Me.Scan_Angle_Degrees = 45 And FrontScanned And FrontScanned_Overhead Then
				Result = 3
			Else
				If Me.Scan_Angle_Degrees = 90 Then
					Result = 1
				Else
					If Me.Parent.UsePandAMTBH = False AndAlso Me.Parent.GapControlMethod = "Passive" Then
						Result = 2
					Else
						Result = 3
					End If
				End If
			End If
		Case "Bottom"
			'BT =If(C90="Yes",If(And(Or(C93="Yes",C94="Yes"),H93="Underside"),3,1),"")
			If FrontScanned_Underside Or (FrontScanned Or BackScanned) Then
				Result = 3
			Else
				Result = 1
			End If

		Case "Left"
			'L =If(C91="Yes",If(I91=45,If(H93="1 Side",4,5),1),"")
			If Scan_Angle_Degrees = 45 Then
				If FrontScanned_1Side Then
					Result = 4
				Else
					Result = 5
				End If
			Else
				1	
			End If
		
		Case "Right"
			'R =If(C92="Yes",If(I92=45,If(H93="1 Side",4,5),1),"")
	
		Case "Front"
			'F =If(C93="Yes",If(And(H93="Overhead",GapControlMethod="Passive",ScanConfigAUsePandAMTBH="No"),2,If(Or(H93="Underside",And(H93="Overhead",Or(GapControlMethod="Active",ScanConfigAUsePandAMTBH="Yes"))),3,If(H93="1 Side",4,5))),"")
			
		Case "Back"
			'BK =If(C94="Yes",If(H93="Overhead",3,If(H93="Underside",3,If(H93="1 Side",4,5))),"")

			
	End Select

End If

		End Function
Public [Is_Scanned] as Boolean
Public [Min_Gap_Required] as Double
Public [Panel_ID] as String
Public [PartNumber] as String
Public [Product_Spacing_Category] as Double
Public [Scan_Angle_Degrees] as Double
Public [Scan_Head_Location] as String
Public [Scan_Type] as String
Public [Scanner_CCD_Position] as String
Public [Scanner_Selected] as String



	End Class
End Namespace
'Error #BC30801:Labels that are numbers must be followed by colons. occurred on line#66 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712070414.vb | iswarning=False 
'Error #BC40056:Namespace or type specified in the Imports 'TeamcenterDriver' doesn't contain any public member or cannot be found. Make sure the namespace or the type is defined and contains at least one public member. Make sure the imported element name doesn't use any aliases. occurred on line#28 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
'Error #BC42024:Unused local variable: 'ctx'. occurred on line#21 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712070414.vb | iswarning=True 
'Error #BC42024:Unused local variable: '__rsMyProp'. occurred on line#22 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712070414.vb | iswarning=True 
'Error #BC42024:Unused local variable: '__rsMyPropName'. occurred on line#23 of module C:\ProgramData\RuleStream\2412.0000\Temp\Snippets\Snippet20250712070414.vb | iswarning=True 
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
'Error #BC42105:Function 'RemoveCommaStringDuplicates' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used. occurred on line#393 of module R:\IGS\MasterDocs\Custom.vb | iswarning=True 
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

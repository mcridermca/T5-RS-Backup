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
	
	Select Case Me.Panel_ID
		Case "Top"
			'T =If(C89="Yes",If(And(I89=45,C94="Yes",H93="Overhead"),3,If(I89=90,1,If(And(GapControlMethod="Passive",ScanConfigAUsePandAMTBH="No"),2,3))),"")

		Case "Bottom"
			If FrontScanned_Underside Or (FrontScanned Or BackScanned) Then
				Result = 3
			Else
				Result = 1
			End If
			'BT =If(C90="Yes",If(And(Or(C93="Yes",C94="Yes"),H93="Underside"),3,1),"")
		Case "Left"
			'L =If(C91="Yes",If(I91=45,If(H93="1 Side",4,5),1),"")
		
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

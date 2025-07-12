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
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Select Case Me.Panel_ID
		Case  "Top"
			' =IF(AND(OR(C93="YES",C94="Yes"),H93="Overhead"),45,90)
				'C93 = Front Scanded
				'C94 = Back Scanned
			If (FrontScanned OrElse BackScanned ) AndAlso FrontScanned_Overhead Then
            	Return 45  ' Condition is true
        	Else
            	Return 90  ' Condition is false
        	End If
		Case  "Bottom"
			Result = 45
		Case "Left","Right"
			'=IF(OR(AND(C93="YES",OR(H93="1 Side",H93="2 Sides")),AND(C94="Yes",OR(H93="1 Side",H93="2 Sides"))),45,90)
			'=IF(OR(AND(FrontScanned=TRUE, OR(FrontScanned_1Side ,FrontScanned_2Side)),AND(BackScanned,OR(FrontScanned_1Side,FrontScanned_2Side))),45,90)
			 If ((FrontScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side)) OrElse _
            	(BackScanned AndAlso (FrontScanned_1Side Or FrontScanned_2Side))) Then
            	
            	Return 45  ' At least one condition is true
        	Else
            	Return 90  ' Both conditions are false
        	End If
		Case "Front", "Back"
					
			Result = 45
	 End Select

End If

		End Function
Public [Is_Scanned] as Boolean
Public [Panel_ID] as String
Public [PartNumber] as String
Public [Product_Spacing_Category] as Double
Public [Scan_Angle_Degrees] as Double
Public [Scan_Head_Location] as Double
Public [Scan_Type] as String
Public [Scanner_CCD_Position] as String
Public [Scanner_Selected] as String



	End Class
End Namespace

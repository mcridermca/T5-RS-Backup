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
If Me.Is_Scanned Then
	Select Case Me.SubpartID
		Case 1 
			Result = MakeValidValues(Array("Overhead")) ' "Overhead"
		Case 2 
			Result = MakeValidValues(Array("Underside"))  ' "Underside"
		Case 3 
			Result = MakeValidValues(Array("1 Side")) ' "1 Side"
		Case 4
			 Result = MakeValidValues(Array("1 Side")) ' "1 Side"
		 Case 5
			 Result = MakeValidValues(Array("Overhead")) ' "Please Select"
		 Case 6
			 Result = MakeValidValues(Array("Overhead", "Underside", "1 Side", "2 Sides")) '"Please Select"
		 Case Else
			 Result = MakeValidValues(Array(""))
	 End Select
 Else
	 Result = MakeValidValues(Array(""))
End If

		End Function
Public [Is_Scanned] as Boolean
Public [Min_Gap_Required] as Double
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

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
Result = 0

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
		Result = 30 ' Todo : Pull from Panda PF
	End If
End If

		End Function
Public [Is_Scanned] as Boolean
Public [Min_Gap_Required] as Double
Public [PandAAvgBoxHeight] as Double
Public [PandAAvgBoxWidth] as Double
Public [PandAMaxBoxHeight] as Double
Public [PandaMinBoxLength] as Double
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

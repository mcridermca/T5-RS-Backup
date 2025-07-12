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
	If Me.Parent.UsePandAMTBH Then
		'=IF($C89="Yes",IF(AND($G89="O",ScanConfigACartonPresentation="Edge Aligned"),PandAMaxBoxHeightWidthDim+6,IF(AND($G89="O",ScanConfigACartonPresentation="Random"),BP_ConvWidth+6,5)),"")
		'=If($C90="Yes",If(And($G90="O",ScanConfigACartonPresentation="Edge Aligned"),PandAMaxBoxHeightWidthDim+6,If(And($G90="O",ScanConfigACartonPresentation="Random"),BP_ConvWidth+6,5)),"")
		'=If($C91="Yes",If($G91="O",PandAMaxBoxHeightWidthDim+6,5),"")
		'=If($C92="Yes",If($G92="O",PandAMaxBoxHeightWidthDim+6,5),"")
		'=If($C93="Yes",If(Or($H93="Overhead",$H93="Underside"),PandAMaxBoxHeightWidthDim+6,$L93+6),"")
		'=If($C94="Yes",If(Or($H93="Overhead",$H93="Underside"),PandAMaxBoxHeightWidthDim+6,$L94+6),"")

		Select Case Me.Product_Spacing_Category 
			Case 1, 2
				'1 = PandaMinBoxLength
				'2 = PandaMinBoxLength
				Result = Me.PandaMinBoxLength
			Case 3
				'3 = If($K99="No",PandAMaxBoxHeight,If($K99="Partial",MAX(PandAAvgBoxHeight,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = Me.PandAMaxBoxHeight
					Case "Partial"
						If Me.PandAAvgBoxHeight >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxHeight
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Full"
						Result = PandaMinBoxLength 'Todo: Unhandled / Incorrectly (MPC 20250712)
				End Select
			Case 4
				'4 = If($K99="No",PandaMaxBoxWidth+1,If($K99="Partial",MAX(PandAAvgBoxWidth+1,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = Me.PandaMaxBoxWidth+1
					Case "Partial"
						If Me.PandAAvgBoxWidth+1 >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxWidth+1
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Full"
						Result = PandaMinBoxLength
				End Select
			Case 5
				'5 = If($K99="No",MAX((PandaMaxBoxWidth/2)+3,PandaMinBoxLength),If($K99="Partial",MAX((PandAAvgBoxWidth/2)+3,PandaMinBoxLength),PandaMinBoxLength))
				Select Case Parent.ShadowingStatus
					Case "No"
						If (Me.PandaMaxBoxWidth/2)+3 >= Me.PandaMinBoxLength Then
							Result = Me.PandAAvgBoxWidth+1
						Else
							Result = Me.PandaMinBoxLength
						End If
					Case "Partial"
						If (PandAAvgBoxWidth/2)+3 > Me.PandaMinBoxLength Then
							Result = (PandAAvgBoxWidth/2)+3
						Else
							Result = Me.PandaMinBoxLength
						End If
						
					Case "Full"
						Result = PandaMinBoxLength
				End Select
		End Select
	Else
		Dim BoxSize_Height_Min_IN As Double = Me.Parent.MySetup(1).BoxSize_Height_Min_IN
		Dim BoxSize_Length_Min_IN As Double = Me.Parent.MySetup(1).BoxSize_Length_Min_IN
		Dim BoxSize_Height_Avg_IN As Double = Me.Parent.MySetup(1).BoxSize_Height_Avg_IN
		Dim BoxSize_Width_Avg_IN As Double = Me.Parent.MySetup(1).BoxSize_Width_Avg_IN
		Dim BoxSize_Height_Max_IN As Double = Me.Parent.MySetup(1).BoxSize_Height_Max_IN
		Dim BoxSize_Width_Max_IN As Double = Me.Parent.MySetup(1).BoxSize_Width_Max_IN
		Dim MinGapForScan As Double = Me.Parent.MinGapForScan_IN
		
		'=If($C89="Yes",If(And($G89="O",ScanConfigACartonPresentation="Edge Aligned"),MaxBoxHeightWidthDim+6,If(And($G89="O",ScanConfigACartonPresentation="Random"),SorterWidth+6,5)),"")
		'=If($C90="Yes",If(And($G90="O",ScanConfigACartonPresentation="Edge Aligned"),MaxBoxHeightWidthDim+6,If(And($G90="O",ScanConfigACartonPresentation="Random"),SorterWidth+6,5)),"")
		'=If($C91="Yes",If($G91="O",MaxBoxHeightWidthDim+6,5),"")
		'=If($C92="Yes",If($G92="O",MaxBoxHeightWidthDim+6,5),"")
		'=If($C93="Yes",If(Or($H93="Overhead",$H93="Underside"),MaxBoxHeightWidthDim+6,$L93+6),"")
		'=If($C94="Yes",If(Or($H93="Overhead",$H93="Underside"),MaxBoxHeightWidthDim+6,$L94+6),"")

		'Please Note: Case Else was used below in many cases as the excel spreadsheet did not have formulas that specifically called out "Full" ShadowingStatus. (20250712)
		Select Case Me.Product_Spacing_Category 
			Case 1
				'1 = MinGapForScan
				Result = MinGapForScan
			Case 2
				'2 = If(K99<>"Full",If(BoxSize_Height_Min_IN<BoxSize_Length_Min_IN,MAX(BoxSize_Height_Min_IN,BoxSize_Length_Min_IN,MinGapForScan),BoxSize_Length_Min_IN),MinGapForScan)
		
				Select Case Parent.ShadowingStatus
					Case "Full"
						Result = MinGapForScan
						Case Else
						If  BoxSize_Height_Min_IN  < BoxSize_Length_Min_IN Then
							Result = MAX(BoxSize_Height_Min_IN, BoxSize_Length_Min_IN)
							Result = MAX(Result,MinGapForScan)
						Else
							Result = BoxSize_Length_Min_IN
						End If
				End Select
			Case 3
				'3 = If(K99="No",BoxSize_Height_Max_IN,If(K99="Partial",BoxSize_Height_Avg_IN,MinGapForScan))			
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = BoxSize_Height_Max_IN
					Case "Partial"
						Result = BoxSize_Height_Avg_IN				
					Case Else
						Result = MinGapForScan
				End Select
			Case 4
				'4 = If(K99="No",BoxSize_Width_Max_IN+1,If(K99="Partial",BoxSize_Width_Avg_IN+1,MinGapForScan))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = BoxSize_Width_Max_IN + 1
					Case "Partial"
						Result = BoxSize_Width_Avg_IN + 1					
					Case  Else
						Result = MinGapForScan
				End Select
			Case 5
				'5 = If(K99="No",(BoxSize_Width_Max_IN/2)+3,If(K99="Partial",(BoxSize_Width_Avg_IN/2)+3,MinGapForScan))
				Select Case Parent.ShadowingStatus
					Case "No"
						Result = (BoxSize_Width_Max_IN/2) + 3
					Case "Partial"
						Result = (BoxSize_Width_Avg_IN/2)+3						
					Case Else
						Result = MinGapForScan
				End Select
		End Select
	End If
End If

		End Function
Public [Is_Scanned] as Boolean
Public [Min_Gap_Required] as Double
Public [PandAAvgBoxHeight] as Double
Public [PandAAvgBoxWidth] as Double
Public [PandAMaxBoxHeight] as Double
Public [PandaMaxBoxWidth] as Double
Public [PandaMinBoxLength] as Double
Public [Panel_ID] as String
Public [PartNumber] as String
Public [Product_Spacing_Category] as Double
Public [Read_Window_Size] as Double
Public [Scan_Angle_Degrees] as Double
Public [Scan_Head_Location] as String
Public [Scan_Type] as String
Public [Scanner_CCD_Position] as String
Public [Scanner_Selected] as String



	End Class
End Namespace

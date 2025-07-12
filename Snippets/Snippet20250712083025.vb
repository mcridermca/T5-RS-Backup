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

'All the same
'T =If(C89="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K89,$W$99:$X$103,2,False),VLOOKUP(K89,$T$99:$U$103,2,False)),"")
'BT =If(C90="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K90,$W$99:$X$103,2,False),VLOOKUP(K90,$T$99:$U$103,2,False)),"")
'L =If(C91="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K91,$W$99:$X$103,2,False),VLOOKUP(K91,$T$99:$U$103,2,False)),"")
'R =If(C92="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K92,$W$99:$X$103,2,False),VLOOKUP(K92,$T$99:$U$103,2,False)),"")
'F =If(C93="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K93,$W$99:$X$103,2,False),VLOOKUP(K93,$T$99:$U$103,2,False)),"")
'BK =If(C94="Yes",If(ScanConfigAUsePandAMTBH="Yes",VLOOKUP(K94,$W$99:$X$103,2,False),VLOOKUP(K94,$T$99:$U$103,2,False)),"")

If Me.Is_Scanned Then
	If Me.Parent.UsePandAMTBH Then
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
		Select Case Me.Product_Spacing_Category 
			Case 1
				'1 = MinGapForScan
				
			Case 2
				'2 = If(K99<>"Full",If(BoxSize_Height_Min_IN<BoxSize_Length_Min_IN,MAX(BoxSize_Height_Min_IN,BoxSize_Length_Min_IN,MinGapForScan),BoxSize_Length_Min_IN),MinGapForScan)
				
			Case 3
				'3 = If(K99="No",BoxSize_Height_Max_IN,If(K99="Partial",BoxSize_Height_Avg_IN,MinGapForScan))

			Case 4
				'4 = If(K99="No",BoxSize_Width_Max_IN+1,If(K99="Partial",BoxSize_Width_Avg_IN+1,MinGapForScan))
				
			Case 5
				'5 = If(K99="No",(BoxSize_Width_Max_IN/2)+3,If(K99="Partial",(BoxSize_Width_Avg_IN/2)+3,MinGapForScan))
				
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
Public [Scan_Angle_Degrees] as Double
Public [Scan_Head_Location] as String
Public [Scan_Type] as String
Public [Scanner_CCD_Position] as String
Public [Scanner_Selected] as String



	End Class
End Namespace

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
	Dim BackScanned As Boolean = Me.Parent.Panel_Config_Back(1).Is_Scanned
	Dim LeftScanned As Boolean = Me.Parent.Panel_Config_Left(1).Is_Scanned
	Dim RightScanned As Boolean = Me.Parent.Panel_Config_Right(1).Is_Scanned
	Dim FrontScanned As Boolean = Me.Parent.Panel_Config_Front(1).Is_Scanned
	Dim BottomScanned As Boolean = Me.Parent.Panel_Config_Bottom(1).Is_Scanned
	 
	Dim FrontScanned_Overhead As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Overhead")
	Dim FrontScanned_Underside As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "Underside")
	Dim FrontScanned_1Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "1 Side")
	Dim FrontScanned_2Side As Boolean = (Me.Parent.Panel_Config_Front(1).Scanner_CCD_Position = "2 Sides")
	
	Dim LeftAngle  As Double = Me.Parent.Panel_Config_Left(1).Scan_Angle_Degrees
	Dim RightAngle As Double = Me.Parent.Panel_Config_Right(1).Scan_Angle_Degrees
	
	Select Case Me.Panel_ID
		Case  "Top"
			'=IF(Scan_Angle_Degrees_Top=90,"O2",IF(AND(FrontScanned="Yes",BackScanned="Yes"),"O1 & O3",IF(FrontScanned="Yes","O1","O3")))
			If Me.Scan_Angle_Degrees = 90 Then
				Result = "O2"
			Else
				If FrontScanned And BackScanned   Then
					Result = "O1 & O3"
				Else
					If FrontScanned Then
					Result = "O1"
					Else
						Result = "O3"
					End If
				End If
			End If
		Case  "Bottom"
			' LEFT  =IF(AND(FrontScanned="Yes",BackScanned="Yes",H93="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",H93="Underside"),"U1","U2"))
			' RIGHT =IF(AND(FrontScanned="Yes",BackScanned="Yes",FrontScanned_Underside="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",FrontScanned_Underside="Underside"),"U1","U2")) 
			If FrontScanned = True And BackScanned = True And FrontScanned_Underside = True
				Result = "U1 & U2"
			Else
				If FrontScanned_Underside Then 
					Result = "U1"
				Else
					Result = "U2"
				End If
			End If 
		Case "Left"
			'I91 = LeftAngle
			'I92 = RightAngle
			' LEFT  =IF(AND(FrontScanned="Yes",BackScanned="Yes",H93="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",H93="Underside"),"U1","U2"))
			' RIGHT =IF(AND(FrontScanned="Yes",BackScanned="Yes",FrontScanned_Underside="Underside"),"U1 & U2",IF(AND(BackScanned="Yes",FrontScanned_Underside="Underside"),"U1","U2"))
			If LeftAngle = 90 Then
				Result = "L2"
			Else
				If FrontScanned And BackScanned And FrontScanned_2Side Then
					Result = "L1 & L3"
				Else
				 	If	FrontScanned And BackScanned And FrontScanned_1Side	Then
						Result = "L1 or L3"
					Else
						If FrontScanned Then
							Result = "L3"
						Else
							Result = "L1"
						End If 
					End If
				End If
			End If
		Case "Right"
			'I91 = LeftAngle
			'I92 = RightAngle
			'=IF(I91=90,"L2",If(And(C93="Yes",C94="Yes",H93="2 Sides"),"L1 & L3",If(And(C93="Yes",C94="Yes",H93="1 Side"),"L1 or L3",If(C93="Yes","L3","L1"))))
			'=IF(I92=90,"R2",IF(AND(C93="Yes",C94="Yes",H93="2 Sides"),"R1 & R3",IF(AND(C93="Yes",C94="Yes",H93="1 Side"),"R1 or R3",IF(C94="Yes","R1","R3"))))
			If RightAngle = 90 Then
				Result = "R2"
			Else
				If FrontScanned And BackScanned And FrontScanned_2Side Then
					Result = "R1 & R3"
				Else
				 	If	FrontScanned And BackScanned And FrontScanned_1Side	Then
						Result = "R1 or R3"
					Else
						If FrontScanned Then
							Result = "R3"
						Else
							Result = "R1"
						End If 
					End If
				End If
			End If
		Case "Front"
			'FRONT = IF(H93="Overhead","O3",         IF(H93="Underside",         "U3",IF(AND(H93="1 Side",        OR(AND(C91="No",           C92="No"),                 AND(C91="Yes",           C92="Yes"))),            "R3 or L3", IF(AND(H93="1 Side",C91="Yes",C92="No"),                                "L3",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R3","R3 & L3")))))
			'BACK  = IF(H93="Overhead","O1",IF(H93="Underside","U1",IF(AND(H93="1 Side",OR(AND(C91="No",$C$92="No"),AND(C91="Yes",C92="Yes"))),"R1 or L1",IF(AND(H93="1 Side",C91="Yes",C92="No"),"L1",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R1","R1 & L1"))))) 
			'FRONT = IF(FrontSide_Overhead=True,"O3",IF(FrontSide_Underside=true,"U3",IF(AND(FrontSide_1Side=True,OR(AND(LeftSideScanned=False,RightSideScannede=False),AND(LeftSideScanned=True,RightSideScanned=True))),"R3 or L3", IF(AND(FrontSide_1Side=True,LeftSideScanned=True,RightSideScanned=False),"L3",IF(AND(FrontSide_1Side=True,LeftSideScanned=False,RighSideScanned=True),"R3","R3 & L3")))))
			If FrontScanned_Overhead Then
            	Return "O3"
        	ElseIf FrontScanned_Underside Then
            	Return "U3"
        	ElseIf FrontScanned_1Side AndAlso ((Not LeftScanned AndAlso Not RightScanned) OrElse (LeftScanned AndAlso RightScanned)) Then
            	Return "R3 or L3"
        	ElseIf FrontScanned_1Side AndAlso LeftScanned AndAlso Not RightScanned Then
            	Return "L3"
        	ElseIf FrontScanned_1Side AndAlso Not LeftScanned AndAlso RightScanned Then
            	Return "R3"
        	Else
            	Return "R3 & L3"
        	End If
		Case "Back"
			'FRONT = IF(H93="Overhead","O3",IF(H93="Underside","U3",IF(AND(H93="1 Side",OR(AND(C91="No",C92="No"),AND(C91="Yes",C92="Yes"))),"R3 or L3",IF(AND(H93="1 Side",C91="Yes",C92="No"),  "L3",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R3","R3 & L3")))))
			'BACK  = IF(H93="Overhead","O1",IF(H93="Underside","U1",IF(AND(H93="1 Side",OR(AND(C91="No",$C$92="No"),AND(C91="Yes",C92="Yes"))),"R1 or L1",IF(AND(H93="1 Side",C91="Yes",C92="No"),"L1",IF(AND(H93="1 Side",C91="No",C92="Yes"),"R1","R1 & L1"))))) 
			'FRONT = IF(FrontSide_Overhead=True,"O3",IF(FrontSide_Underside=true,"U3",IF(AND(FrontSide_1Side=True,OR(AND(LeftSideScanned=False,RightSideScannede=False),AND(LeftSideScanned=True,RightSideScanned=True))),"R3 or L3", IF(AND(FrontSide_1Side=True,LeftSideScanned=True,RightSideScanned=False),"L3",IF(AND(FrontSide_1Side=True,LeftSideScanned=False,RighSideScanned=True),"R3","R3 & L3")))))
			If FrontScanned_Overhead Then
            	Return "O1"
        	ElseIf FrontScanned_Underside Then
            	Return "U1"
        	ElseIf FrontScanned_1Side AndAlso ((Not LeftScanned AndAlso Not RightScanned) OrElse (LeftScanned AndAlso RightScanned)) Then
            	Return "R1 or L1"
        	ElseIf FrontScanned_1Side AndAlso LeftScanned AndAlso Not RightScanned Then
            	Return "L1"
        	ElseIf FrontScanned_1Side AndAlso Not LeftScanned AndAlso RightScanned Then
            	Return "R1"
        	Else
            	Return "R1 & L1"
        	End If
		End Select
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

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
	Public Class APC_Setup
	Inherits RuleStream.Kernel.Part
		Function Result(ByVal thisPart As IRsObject, ByVal thatPart as IRsObject, ByVal propertyName As String, ByVal context As String, ByVal Value as Object, ByVal OldValue as Object) As Object
			' Using AxEvaluator62
			Dim this as APC_Setup = CType(thisPart, Part)
			Dim that as APC_Setup = CType(thatPart, Part)
			Dim ctx as Object
			Dim __rsMyProp as PropertySF
			Dim __rsMyPropName as String
Result = ""

'Sampl Errors
'	EList.Add(0, "Info Message", "ERR000",Source)
'	EList.Add(1, "Warning Message", "ERR001", Source)
'	EList.Add(2, "Errror Message", "ERR002",Source)
'	EList.Add(3, "Critcal Message", "ERR003",Source)

Dim Source As String = "APC_SETUP"
Dim EList As New Custom.HWErrorList

' =IF(BoxSize_Length_Max_IN>48,"WARNING: LENGTHS IN EXCESS OF 48 INCH MAXIMUM MAY RESTRICT MAXIMUM WIDTHS POSSIBLE FOR A GIVEN B/F DIMENSION!","") 
If BoxSize_Length_Max_IN > 48 Then
	EList.Add(1, "WARNING: LENGTHS IN EXCESS OF 48 INCH MAXIMUM MAY RESTRICT MAXIMUM WIDTHS POSSIBLE FOR A GIVEN B/F DIMENSION!", "APC001", Source)
End If

'=IF(Conveyor_Product_Line_Used="Metric",IF(BoxSize_Width_Max_MM>(SorterWidthMetric-50),"ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!",""),IF(BoxSize_Width_Max_IN>(SorterWidth-2),"ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!",""))
'If Conveyor_Product_Line_Used = "Metric" Then
    'If BoxSize_Width_Max_MM > (SorterWidthMetric - 50) Then
     '   EList.Add(1, "ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!", "APC0020", Source)
    'End If
'Else
    'If BoxSize_Width_Max_IN > (SorterWidth - 2) Then
     '   EList.Add(1, "ERROR: MAX WIDTH CARTON EXCEEDS LIMIT FOR SELECTED SORTER/CONVEYOR B/F!", "APC0021", Source)
    'End If
'End If

'=IF(BoxSize_Height_Min_IN<1,"WARNING: SUB 1 INCH MIN. PRODUCT HEIGHT REQUIRES SPECIAL PHOTOCELL CONDSIDERATIONS TO CONVEY AND DETECT PRODUCT PROPERLY","")
If BoxSize_Height_Min_IN < 1 Then
	EList.Add(1,"WARNING: SUB 1 INCH MIN. PRODUCT HEIGHT REQUIRES SPECIAL PHOTOCELL CONDSIDERATIONS TO CONVEY AND DETECT PRODUCT PROPERLY!", "APC002", Source)
End If 

'IF(BoxSize_Length_Min_IN<9,IF(BoxSize_Length_Min_IN<6,"WARNING: SUB 6 INCH MINIMUM PRODUCT LENGTHS REQUIRE SPECIAL DESIGN CONSIDERATIONS SYSTEM WIDE!","WARNING: SUB 9 INCH MINIMUM PRODUCT LENGTHS WILL REQUIRE 2 INCH ROLLER CENTER SPACING TO CONVEY PROPERLY!"),"")
If BoxSize_Length_Min_IN < 9 Then
    If BoxSize_Length_Min_IN < 6 Then
        EList.Add(1, "WARNING: SUB 6 INCH MINIMUM PRODUCT LENGTHS REQUIRE SPECIAL DESIGN CONSIDERATIONS SYSTEM WIDE!", "APC0022", Source)
    Else
        EList.Add(1, "WARNING: SUB 9 INCH MINIMUM PRODUCT LENGTHS WILL REQUIRE 2 INCH ROLLER CENTER SPACING TO CONVEY PROPERLY!", "APC0023", Source)
    End If
End If

'=IF(OR(BoxSize_Length_Min_IN<9,BoxSize_Length_Max_IN>48,BoxSize_Height_Min_IN<1,BoxSize_Weight_Max_LBS>70),"**REFER TO THE LINK AT THE BOTTOM OF SHEET FOR MASTER OUT-OF-SPEC PRODUCT GUIDELINES**","")
If BoxSize_Length_Min_IN < 9 OrElse BoxSize_Length_Max_IN > 48 OrElse BoxSize_Height_Min_IN < 1 OrElse BoxSize_Weight_Max_LBS > 70 Then
     EList.Add(1, "**REFER TO THE LINK AT THE BOTTOM OF SHEET FOR MASTER OUT-OF-SPEC PRODUCT GUIDELINES**", "APC0030", Source)
End If
'IF(OR(BoxSize_Width_Min_IN>BoxSize_Length_Min_IN,BoxSize_Width_Max_IN>BoxSize_Length_Max_IN,BoxSize_Width_Avg_IN>BoxSize_Length_Avg),"ERROR - WIDTH CANNOT EXCEED LENGTH","")
If BoxSize_Width_Min_IN > BoxSize_Length_Min_IN OrElse BoxSize_Width_Max_IN > BoxSize_Length_Max_IN OrElse BoxSize_Width_Avg_IN > BoxSize_Length_Avg_IN Then
    EList.Add(1, "ERROR - WIDTH CANNOT EXCEED LENGTH", "APC0031", Source)
End If

'=IF(BoxSize_Weight_Max_LBS>70,"WARNING: CONVEYED PRODUCT WEIGHTS IN EXCESS OF 70 LBS MAY REQUIRE SPECIAL CONSIDERATION FOR SOME EQUIPMENT!","")
If BoxSize_Weight_Max_LBS > 70 Then
    EList.Add(1, "WARNING: CONVEYED PRODUCT WEIGHTS IN EXCESS OF 70 LBS MAY REQUIRE SPECIAL CONSIDERATION FOR SOME EQUIPMENT!", "APC003", Source)
End If

'=IF(AND(Live_Load_Avg_LBS>50,Live_Load_Avg_LBS<100),"WARNING: LIVE LOAD IS ABOVE THE TYPICAL RANGE FOR MOST EQUIPMENT TYPES","")
If Live_Load_Avg_LBSFT > 50 And Live_Load_Avg_LBSFT < 100 Then
      EList.Add(1,"WARNING: LIVE LOAD IS ABOVE THE TYPICAL RANGE FOR MOST EQUIPMENT TYPES", "APC004", Source)
End If

'=IF(OR(Selected_Sortation_Controls="BOSS",Selected_Sortation_Controls="ICW"),"WARNING: THE BOSS AND ICW CONTROLS PLATFORMS ARE IN SUNSET STATUS AND SHOULD ONLY BE USED FOR RETROFITS OF EXISTING SYSTEMS!","")

If Selected_Sortation_Controls = "BOSS" Or Selected_Sortation_Controls = "ICW" Then
    EList.Add(1, "WARNING: THE BOSS AND ICW CONTROLS PLATFORMS ARE IN SUNSET STATUS AND SHOULD ONLY BE USED FOR RETROFITS OF EXISTING SYSTEMS!", "APC005", Source)
End If


'MPC - 20250712 - Did a different check for BoxSize_Worst_Case_HL_Ratio to capture a string "Error" Error. 
					' The Original Spreadsheet had BoxSize_Worst_Case_HL_Ratio evaluating to a string
If Not isnumeric( BoxSize_Worst_Case_HL_Ratio) Then
	EList.Add(2, "ERROR: PRODUCT STABILITY TESTING/PROTOTYPING IS STRONGLY RECOMMENDED!", "APC0027", Source)
Else
	'=IF(OR($I$33="Yes",AND($I$30="Yes",$I$32<0.75)),"WARNING: PRODUCT STABILITY TESTING/PROTOTYPING IS STRONGLY RECOMMENDED!","")
	If BoxSize_Other_Known_Issues = True Or(BoxSize_Height_GRTR_Len_Possible = True And Double.parse(BoxSize_Worst_Case_HL_Ratio) < 0.75) Then
    	EList.Add(1, "WARNING:BoxSize_Worst_Case_HL_Ratio Evaluation has an error!", "APC0025", Source)
	End If
	'=IF(OR($I$33="Yes",AND($I$30="Yes",$I$32<0.75)),"REDUCED INCLINE/DECLINE BELT ANGLES AND/OR VFD's MAY BE REQUIRED!'","")
	If BoxSize_Other_Known_Issues = True Or (BoxSize_Height_GRTR_Len_Possible = True And Double.parse(BoxSize_Worst_Case_HL_Ratio) < 0.75) Then
  	 	EList.Add(1, "REDUCED INCLINE/DECLINE BELT ANGLES AND/OR VFD's MAY BE REQUIRED!'", "APC0026", Source)
	End If

End If

'=IF($I$40="Metric","WARNING: METRIC PERFORMANCE VALUES ARE ESTIMATES UNTIL TESTING CAN BE DONE BY PRODUCT ENGINEERING","")
If Conveyor_Product_Line_Used = "Metric" Then
    EList.Add(1, "WARNING: METRIC PERFORMANCE VALUES ARE ESTIMATES UNTIL TESTING CAN BE DONE BY PRODUCT ENGINEERING", "APC0024", Source)
End If

'=IF(Case_Length_Per_Ft_Minute_Target>216,IF(Case_Length_Per_Ft_Minute_Target>400,"SEEK PAE/ENGINEERING ASSISTANCE ON ANY APPLICATION EXCEEDING 400 CFPM","APPLICATIONS EXCEEDING 216 CFPM WILL LIKELY REQUIRE SOME FORM OF ACTIVE GAPPING INDUCTION TECHOLOGY"),"")
If Case_Length_Per_Minute_Target_FT > 216 Then
    If Case_Length_Per_Minute_Target_FT > 400 Then
      EList.Add(1, "SEEK PAE/ENGINEERING ASSISTANCE ON ANY APPLICATION EXCEEDING 400 CFPM", "APC006", Source)
    Else
      EList.Add(1, "APPLICATIONS EXCEEDING 216 CFPM WILL LIKELY REQUIRE SOME FORM OF ACTIVE GAPPING INDUCTION TECHOLOGY", "APC007", Source)
    End If
End If

'=IF(OverrideGap<>"","WARNING: GAP OVERRIDE IS ENABLED!","")
'If OverrideGap <> "" Then
 '   EList.Add(1, "WARNING: GAP OVERRIDE IS ENABLED!", "APC003", Source)
'End If

Result = EList.ErrorSummary(1)

		End Function
Public [Belt_InclineDecline_Max_Deg] as Double
Public [BoxSize_Height_Avg_IN] as Double
Public [BoxSize_Height_Avg_User] as Double
Public [BoxSize_Height_Avg_User_UOM] as String
Public [BoxSize_Height_GRTR_Len_Possible] as Boolean
Public [BoxSize_Height_Max_IN] as Double
Public [BoxSize_Height_Max_User] as Double
Public [BoxSize_Height_Max_User_UOM] as String
Public [BoxSize_Height_Min_IN] as Double
Public [BoxSize_Height_Min_User] as Double
Public [BoxSize_Height_Min_User_UOM] as String
Public [BoxSize_Length_Avg_IN] as Double
Public [BoxSize_Length_Avg_User] as Double
Public [BoxSize_Length_Avg_User_UOM] as String
Public [BoxSize_Length_Max_IN] as Double
Public [BoxSize_Length_Max_MM] as Double
Public [BoxSize_Length_Max_User] as Double
Public [BoxSize_Length_Max_User_UOM] as String
Public [BoxSize_Length_Min_IN] as Double
Public [BoxSize_Length_Min_MM] as Double
Public [BoxSize_Length_Min_User] as Double
Public [BoxSize_Length_Min_User_UOM] as String
Public [BoxSize_Other_Known_Issues] as Boolean
Public [BoxSize_User_UOM] as String
Public [BoxSize_Weight_Avg_LBS] as Double
Public [BoxSize_Weight_Avg_User] as Double
Public [BoxSize_Weight_Avg_User_UOM] as String
Public [BoxSize_Weight_Max_LBS] as Double
Public [BoxSize_Weight_Max_User] as Double
Public [BoxSize_Weight_Max_User_UOM] as String
Public [BoxSize_Weight_Min_LBS] as Double
Public [BoxSize_Weight_Min_User] as Double
Public [BoxSize_Weight_Min_User_UOM] as String
Public [BoxSize_Width_Avg_IN] as Double
Public [BoxSize_Width_Avg_User] as Double
Public [BoxSize_Width_Avg_User_UOM] as String
Public [BoxSize_Width_Max_IN] as Double
Public [BoxSize_Width_Max_MM] as Double
Public [BoxSize_Width_Max_User] as Double
Public [BoxSize_Width_Max_User_UOM] as String
Public [BoxSize_Width_Min_IN] as Double
Public [BoxSize_Width_Min_MM] as Double
Public [BoxSize_Width_Min_User] as Double
Public [BoxSize_Width_Min_User_UOM] as String
Public [BoxSize_Worst_Case_Height_IN] as Double
Public [BoxSize_Worst_Case_HL_Ratio] as String
Public [BoxSize_Worst_Case_Length_IN] as Double
Public [Case_Length_Per_Minute_Target_FT] as Double
Public [Case_Length_Per_Minute_Target_M] as Double
Public [Conveyor_BF_Selected_Min_IN] as Double
Public [Conveyor_BF_Selected_Min_User] as Double
Public [Conveyor_BF_Selected_Min_User_UOM] as String
Public [Conveyor_Curve_BF_Calc_Min_In] as Double
Public [Conveyor_Curve_BF_Calc_Rcmd_In] as Double
Public [Conveyor_Curve_OffSet_Guide_Viable] as Boolean
Public [Conveyor_Inside_Radius_Min_IN] as Double
Public [Conveyor_Product_Line_Used] as String
Public [Conveyor_Skew_Bed_Length_Min_Reqd_IN] as Double
Public [Conveyor_Skew_Bed_Length_MTBH_Width_IN] as Double
Public [Conveyor_Skew_Total_Length_MTBH_Width_IN] as Double
Public [Conveyor_Width_Min_IN] as Double
Public [Customer_Location_CityState] as String
Public [Customer_Name] as String
Public [Live_Load_Avg_KGM] as Double
Public [Live_Load_Avg_LBSFT] as Double
Public [Live_Load_Avg_User] as Double
Public [Live_Load_Avg_User_UOM] as String
Public [Material_Gap_Override_IN] as Double
Public [Material_Gap_Override_MM] as Double
Public [Material_Gap_Override_User] as Double
Public [Material_Gap_Override_User_UOM] as String
Public [PartNumber] as String
Public [Proposal_Date] as Date
Public [Proposal_No] as String
Public [Selected_Sortation_Controls] as String
Public [Sort_Dual_Sided] as Boolean
Public [Sort_Rate_Required_CPM] as Double
Public [Temp_Sort_Operating_Min_F] as Double
Public [Temp_Sort_Operating_Min_User] as Double
Public [Temp_Sort_Operating_Min_User_UOM] as String
Public [Temp_System_Operating_Min_F] as Double
Public [Temp_System_Operating_Min_UOM] as String
Public [Temp_System_Operating_Min_User] as Double
Public [Totes_Plastic] as Boolean
Public [Totes_Plastic_Type] as String
Public [User_UOM_System] as String
Public [Valid] as Boolean
Public [Valid_Message] as String

Public [My_PRD] as Connection


	End Class
End Namespace

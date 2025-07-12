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
	Public Class IGS_AppCalc_App
	Inherits RuleStream.Kernel.Part
		Function Result(ByVal thisPart As IRsObject, ByVal thatPart as IRsObject, ByVal propertyName As String, ByVal context As String, ByVal Value as Object, ByVal OldValue as Object) As Object
			' Using AxEvaluator62
			Dim this as IGS_AppCalc_App = CType(thisPart, Part)
			Dim that as IGS_AppCalc_App = CType(thatPart, Part)
			Dim ctx as Object
			Dim __rsMyProp as PropertySF
			Dim __rsMyPropName as String
result = String.Empty

		End Function
Public [App_Calc_Name] as String
Public [Approved_By] as String
Public [Approved_Date] as Date
Public [Customer_Name] as String
Public [Estimated_By] as String
Public [Facility_Location] as String
Public [PartNumber] as String
Public [Product_Identifier] as String
Public [Proposal_No] as String
Public [Revision_No] as String
Public [CreationDate] as Date
Public [CustomerName] as String
Public [UserID] as String
Public [UserName] as String
Public [UserEmail] as String
Public [ProjectID] as String
Public [LineItem] as Long
Public [Release] as Long
Public [ReleaseType] as Long
Public [ReleaseTypeName] as String
Public [NumberOfParts] as Long
Public [CurrentDateTime] as Date
Public [CurrentProcessStep] as String
Public [CurrentProcess] as String
Public [CurrentDrawing] as String
Public [__RSLocale] as String
Public [__TimeZone] as String
Public [__TEAMCENTER_SHARE_AUTHORIZATION_CODE] as String
Public [__TEAMCENTER_SHARE_CLIENT_STATE] as String

Public [My_PRD] as Connection

Public [Advanced_Calcs] as Connection
Public [Belted_PandA] as Connection
Public [Belted_PandA_Layout] as Connection
Public [Continuous_RA_Discharge] as Connection
Public [Induction] as Connection
Public [Instructions] as Connection
Public [Intellimerge_PSM] as Connection
Public [MDR_Misc] as Connection
Public [MDR_Sort] as Connection
Public [Pre_Merge] as Connection
Public [Project_Information] as Connection
Public [R_M_Merge] as Connection
Public [Scan_Belt] as Connection
Public [Scan_Config] as Connection
Public [Scan_Configurations] as Connection
Public [Setup] as Connection
Public [SFDC_PRD_Local] as Connection
Public [Sortation] as Connection
Public [Space_Avail_Merge] as Connection
Public [Std_Merge] as Connection
Public [ZFA_Applications] as Connection
Public [Zipper_Merge] as Connection

	End Class
End Namespace

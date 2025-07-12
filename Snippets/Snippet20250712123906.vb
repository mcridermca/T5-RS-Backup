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
	Public Class APC_Scan_Configuration
	Inherits RuleStream.Kernel.Part
		Function Result(ByVal thisPart As IRsObject, ByVal thatPart as IRsObject, ByVal propertyName As String, ByVal context As String, ByVal Value as Object, ByVal OldValue as Object) As Object
			' Using AxEvaluator62
			Dim this as APC_Scan_Configuration = CType(thisPart, Part)
			Dim that as APC_Scan_Configuration = CType(thatPart, Part)
			Dim ctx as Object
			Dim __rsMyProp as PropertySF
			Dim __rsMyPropName as String
result = false
'=IF(COUNTIF(FrontScanned:BackScanned,"Yes")>0,"Yes","No")

		End Function
Public [PartNumber] as String
Public [ShadowingPotential] as Boolean
Public [ShadowingStatus] as Boolean
Public [UsePandAMTBH] as Boolean

Public [Panel_Config_Back] as Connection
Public [Panel_Config_Bottom] as Connection
Public [Panel_Config_Front] as Connection
Public [Panel_Config_Left] as Connection
Public [Panel_Config_Right] as Connection
Public [Panel_Config_Top] as Connection

Public [Panel_Configs] as Connection

	End Class
End Namespace

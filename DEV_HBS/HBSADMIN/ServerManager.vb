Option Strict Off
Option Explicit On

Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.Diagnostics
Imports System.Runtime.Remoting.Lifetime
Imports RuleStream
Imports RuleStream.Kernel
Imports RuleStream.DocumentManager

<Serializable()> Public Class ServerManager 
	Inherits MarshalByRefObject
	Implements RuleStream.IRsApplicationManager 

	Public Overrides Function InitializeLifetimeService() As Object
		Dim lease As ILease = DirectCast(MyBase.InitializeLifetimeService(), ILease)

		If lease.CurrentState = LeaseState.Initial Then
			lease.InitialLeaseTime = TimeSpan.Zero
		End If
		Return lease
	End Function

#Region " IRsApplicationManager Interface Implementation "

	Public Function GetClassAssemblyName(ByVal strName as String) As String Implements RuleStream.IRsApplicationManager.GetClassAssemblyName
		Select Case strName.ToLower
			Case "adm_application_master" : Return "HBSADMIN"
			Case "adm_application_master_row" : Return "HBSADMIN"
			Case "adm_application_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_controller_family_master" : Return "HBSADMIN"
			Case "adm_controller_family_master_row" : Return "HBSADMIN"
			Case "adm_controller_family_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_controller_protocol_master" : Return "HBSADMIN"
			Case "adm_controller_protocol_master_row" : Return "HBSADMIN"
			Case "adm_controller_protocol_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_controller_spl_feature_master" : Return "HBSADMIN"
			Case "adm_controller_spl_feature_master_row" : Return "HBSADMIN"
			Case "adm_controller_spl_feature_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_cpu_io_master" : Return "HBSADMIN"
			Case "adm_cpu_io_master_row" : Return "HBSADMIN"
			Case "adm_cpu_io_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_data_master_app" : Return "HBSADMIN"
			Case "adm_device_type_master" : Return "HBSADMIN"
			Case "adm_device_type_master_row" : Return "HBSADMIN"
			Case "adm_device_type_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_engg_units_master" : Return "HBSADMIN"
			Case "adm_engg_units_master_row" : Return "HBSADMIN"
			Case "adm_engg_units_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_parameter_name_master" : Return "HBSADMIN"
			Case "adm_parameter_name_master_row" : Return "HBSADMIN"
			Case "adm_parameter_name_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_part_type_master" : Return "HBSADMIN"
			Case "adm_part_type_master_row" : Return "HBSADMIN"
			Case "adm_part_type_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_parts_accessory_mapping_master" : Return "HBSADMIN"
			Case "adm_parts_accessory_mapping_master_row" : Return "HBSADMIN"
			Case "adm_parts_accessory_mapping_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_plant_library_master" : Return "HBSADMIN"
			Case "adm_plant_library_master_row" : Return "HBSADMIN"
			Case "adm_plant_library_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_point_type_master" : Return "HBSADMIN"
			Case "adm_point_type_master_row" : Return "HBSADMIN"
			Case "adm_point_type_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_pole_master" : Return "HBSADMIN"
			Case "adm_pole_master_row" : Return "HBSADMIN"
			Case "adm_pole_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_process_variable_master" : Return "HBSADMIN"
			Case "adm_process_variable_master_row" : Return "HBSADMIN"
			Case "adm_process_variable_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_signal_type_master" : Return "HBSADMIN"
			Case "adm_signal_type_master_row" : Return "HBSADMIN"
			Case "adm_signal_type_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_sm_master" : Return "HBSADMIN"
			Case "adm_sm_master_row" : Return "HBSADMIN"
			Case "adm_sm_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_standards_master" : Return "HBSADMIN"
			Case "adm_standards_master_row" : Return "HBSADMIN"
			Case "adm_standards_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_std_wiring_detail_master" : Return "HBSADMIN"
			Case "adm_std_wiring_detail_master_row" : Return "HBSADMIN"
			Case "adm_std_wiring_detail_master_row_dbinfo" : Return "HBSADMIN"
			Case "adm_voltage_master" : Return "HBSADMIN"
			Case "adm_voltage_master_row" : Return "HBSADMIN"
			Case "adm_voltage_master_row_dbinfo" : Return "HBSADMIN"
			Case "rsxli_pli_search_data" : Return "HBSADMIN"
			Case "rsxli_pli_search_data_row" : Return "HBSADMIN"
			Case "rsxli_pli_search_data_row_dbinfo" : Return "HBSADMIN"

		End Select
	End Function

Public Function GetSpecMappings() As Collection Implements RuleStream.IRsApplicationManager.GetSpecMappings
	Dim shapeList As New Collection
	Return shapeList
End Function

	Public Function GetBOM() As DataSet Implements RuleStream.IRsApplicationManager.GetBOM
		Dim ds As New DataSet
		Dim xmlDataList As New ArrayList
		Dim xmlData As String = Nothing
		xmlDataList.Add("<NewDataSet />")
		xmlData = xmlDataList.Item(0).ToString
		ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader("<?xml version=""1.0"" encoding=""utf-16""?><xs:schema id=""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">  <xs:element name=""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">    <xs:complexType>      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">        <xs:element name=""Table"">          <xs:complexType>            <xs:sequence>              <xs:element name=""BOM_ID"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Name"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""App_Id"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Description"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""Transmit_Flag"" type=""xs:boolean"" minOccurs=""0"" />              <xs:element name=""Report_File_Name"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""Transmit_Format"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""Transmit_File_Name"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""Transmit_File_Ext"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""BOM_Type"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Extra_Project_Info"" type=""xs:boolean"" minOccurs=""0"" />            </xs:sequence>          </xs:complexType>        </xs:element>      </xs:choice>    </xs:complexType>  </xs:element></xs:schema>")))
		ds.ReadXml(New System.Xml.XmlTextReader(New System.IO.StringReader(xmlData)))
		Return ds
	End Function

	Public Function GetBOMColumn() As Dataset Implements RuleStream.IRsApplicationManager.GetBOMColumn
		Dim ds As New DataSet
		Dim xmlDataList As New ArrayList
		Dim xmlData As String = Nothing
		xmlDataList.Add("<NewDataSet />")
		xmlData = xmlDataList.Item(0).ToString
		ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader("<?xml version=""1.0"" encoding=""utf-16""?><xs:schema id=""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">  <xs:element name=""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">    <xs:complexType>      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">        <xs:element name=""Table"">          <xs:complexType>            <xs:sequence>              <xs:element name=""BOM_ID"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Property_Spec_Name"" type=""xs:string"" minOccurs=""0"" />              <xs:element name=""Column_Index"" type=""xs:int"" minOccurs=""0"" />            </xs:sequence>          </xs:complexType>        </xs:element>      </xs:choice>    </xs:complexType>  </xs:element></xs:schema>")))
		ds.ReadXml(New System.Xml.XmlTextReader(New System.IO.StringReader(xmlData)))
		Return ds
	End Function

	Public Function GetBOMConnPath() As DataSet Implements RuleStream.IRsApplicationManager.GetBOMConnPath
		Dim ds As New DataSet
		Dim xmlDataList As New ArrayList
		Dim xmlData As String = Nothing
		xmlDataList.Add("<NewDataSet />")
		xmlData = xmlDataList.Item(0).ToString
		ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader("<?xml version=""1.0"" encoding=""utf-16""?><xs:schema id=""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">  <xs:element name=""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">    <xs:complexType>      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">        <xs:element name=""Table"">          <xs:complexType>            <xs:sequence>              <xs:element name=""BOM_ID"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Conn_path"" type=""xs:string"" minOccurs=""0"" />            </xs:sequence>          </xs:complexType>        </xs:element>      </xs:choice>    </xs:complexType>  </xs:element></xs:schema>")))
		ds.ReadXml(New System.Xml.XmlTextReader(New System.IO.StringReader(xmlData)))
		Return ds
	End Function

	Public Function GetBOMPartFamily() As DataSet Implements RuleStream.IRsApplicationManager.GetBOMPartFamily
		Dim ds As New DataSet
		Dim xmlDataList As New ArrayList
		Dim xmlData As String = Nothing
		xmlDataList.Add("<NewDataSet />")
		xmlData = xmlDataList.Item(0).ToString
		ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader("<?xml version=""1.0"" encoding=""utf-16""?><xs:schema id=""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">  <xs:element name=""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">    <xs:complexType>      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">        <xs:element name=""Table"">          <xs:complexType>            <xs:sequence>              <xs:element name=""BOM_ID"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Part_Family_ID"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Suppress"" type=""xs:boolean"" minOccurs=""0"" />            </xs:sequence>          </xs:complexType>        </xs:element>      </xs:choice>    </xs:complexType>  </xs:element></xs:schema>")))
		ds.ReadXml(New System.Xml.XmlTextReader(New System.IO.StringReader(xmlData)))
		Return ds
	End Function

	Public Function GetBOMSubPath() As DataSet Implements RuleStream.IRsApplicationManager.GetBOMSubPath
		Dim ds As New DataSet
		Dim xmlDataList As New ArrayList
		Dim xmlData As String = Nothing
		xmlDataList.Add("<NewDataSet />")
		xmlData = xmlDataList.Item(0).ToString
		ds.ReadXmlSchema(New System.Xml.XmlTextReader(New System.IO.StringReader("<?xml version=""1.0"" encoding=""utf-16""?><xs:schema id=""NewDataSet"" xmlns="""" xmlns:xs=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">  <xs:element name=""NewDataSet"" msdata:IsDataSet=""true"" msdata:UseCurrentLocale=""true"">    <xs:complexType>      <xs:choice minOccurs=""0"" maxOccurs=""unbounded"">        <xs:element name=""Table"">          <xs:complexType>            <xs:sequence>              <xs:element name=""BOM_ID"" type=""xs:int"" minOccurs=""0"" />              <xs:element name=""Subpart_Path"" type=""xs:string"" minOccurs=""0"" />            </xs:sequence>          </xs:complexType>        </xs:element>      </xs:choice>    </xs:complexType>  </xs:element></xs:schema>")))
		ds.ReadXml(New System.Xml.XmlTextReader(New System.IO.StringReader(xmlData)))
		Return ds
	End Function

	Public Function GetPartFamilies() As String() Implements RuleStream.IRsApplicationManager.GetPartFamilies
		Dim arr(60) as String 
		arr(0) = "114ADM_Application_MasterADM_Application_Master"
		arr(1) = "115ADM_Application_Master_RowADM_Application_Master_Row"
		arr(2) = "116ADM_Application_Master_Row_dbInfoADM_Application_Master_Row_dbInfo"
		arr(3) = "81ADM_Controller_Family_MasterADM_Controller_Family_Master"
		arr(4) = "82ADM_Controller_Family_Master_RowADM_Controller_Family_Master_Row"
		arr(5) = "83ADM_Controller_Family_Master_Row_dbInfoADM_Controller_Family_Master_Row_dbInfo"
		arr(6) = "69ADM_Controller_Protocol_MasterADM_Controller_Protocol_Master"
		arr(7) = "70ADM_Controller_Protocol_Master_RowADM_Controller_Protocol_Master_Row"
		arr(8) = "71ADM_Controller_Protocol_Master_Row_dbInfoADM_Controller_Protocol_Master_Row_dbInfo"
		arr(9) = "72ADM_Controller_Spl_Feature_MasterADM_Controller_Spl_Feature_Master"
		arr(10) = "73ADM_Controller_Spl_Feature_Master_RowADM_Controller_Spl_Feature_Master_Row"
		arr(11) = "74ADM_Controller_Spl_Feature_Master_Row_dbInfoADM_Controller_Spl_Feature_Master_Row_dbInfo"
		arr(12) = "66ADM_CPU_IO_MasterADM_CPU_IO_Master"
		arr(13) = "67ADM_CPU_IO_Master_RowADM_CPU_IO_Master_Row"
		arr(14) = "68ADM_CPU_IO_Master_Row_dbInfoADM_CPU_IO_Master_Row_dbInfo"
		arr(15) = "54ADM_Data_Master_AppADM_Data_Master_App"
		arr(16) = "111ADM_Device_Type_MasterADM_Device_Type_Master"
		arr(17) = "112ADM_Device_Type_Master_RowADM_Device_Type_Master_Row"
		arr(18) = "113ADM_Device_Type_Master_Row_dbInfoADM_Device_Type_Master_Row_dbInfo"
		arr(19) = "93ADM_Engg_Units_MasterADM_Engg_Units_Master"
		arr(20) = "94ADM_Engg_Units_Master_RowADM_Engg_Units_Master_Row"
		arr(21) = "95ADM_Engg_Units_Master_Row_dbInfoADM_Engg_Units_Master_Row_dbInfo"
		arr(22) = "102ADM_Parameter_Name_MasterADM_Parameter_Name_Master"
		arr(23) = "103ADM_Parameter_Name_Master_RowADM_Parameter_Name_Master_Row"
		arr(24) = "104ADM_Parameter_Name_Master_Row_dbInfoADM_Parameter_Name_Master_Row_dbInfo"
		arr(25) = "105ADM_Part_Type_MasterADM_Part_Type_Master"
		arr(26) = "106ADM_Part_Type_Master_RowADM_Part_Type_Master_Row"
		arr(27) = "107ADM_Part_Type_Master_Row_dbInfoADM_Part_Type_Master_Row_dbInfo"
		arr(28) = "78ADM_Parts_Accessory_Mapping_MasterADM_Parts_Accessory_Mapping_Master"
		arr(29) = "79ADM_Parts_Accessory_Mapping_Master_RowADM_Parts_Accessory_Mapping_Master_Row"
		arr(30) = "80ADM_Parts_Accessory_Mapping_Master_Row_dbInfoADM_Parts_Accessory_Mapping_Master_Row_dbInfo"
		arr(31) = "84ADM_Plant_Library_MasterADM_Plant_Library_Master"
		arr(32) = "85ADM_Plant_Library_Master_RowADM_Plant_Library_Master_Row"
		arr(33) = "86ADM_Plant_Library_Master_Row_dbInfoADM_Plant_Library_Master_Row_dbInfo"
		arr(34) = "87ADM_Point_Type_MasterADM_Point_Type_Master"
		arr(35) = "88ADM_Point_Type_Master_RowADM_Point_Type_Master_Row"
		arr(36) = "89ADM_Point_Type_Master_Row_dbInfoADM_Point_Type_Master_Row_dbInfo"
		arr(37) = "50ADM_Pole_MasterADM_Pole_Master"
		arr(38) = "49ADM_Pole_Master_RowADM_Pole_Master_Row"
		arr(39) = "55ADM_Pole_Master_Row_dbInfoADM_Pole_Master_Row_dbInfo"
		arr(40) = "90ADM_Process_Variable_MasterADM_Process_Variable_Master"
		arr(41) = "91ADM_Process_Variable_Master_RowADM_Process_Variable_Master_Row"
		arr(42) = "92ADM_Process_Variable_Master_Row_dbInfoADM_Process_Variable_Master_Row_dbInfo"
		arr(43) = "60ADM_Signal_Type_MasterADM_Signal_Type_Master"
		arr(44) = "61ADM_Signal_Type_Master_RowADM_Signal_Type_Master_Row"
		arr(45) = "62ADM_Signal_Type_Master_Row_dbInfoADM_Signal_Type_Master_Row_dbInfo"
		arr(46) = "58ADM_sm_MasterADM_sm_Master"
		arr(47) = "57ADM_sm_Master_RowADM_sm_Master_Row"
		arr(48) = "56ADM_sm_Master_Row_dbInfoADM_sm_Master_Row_dbInfo"
		arr(49) = "108ADM_Standards_MasterADM_Standards_Master"
		arr(50) = "109ADM_Standards_Master_RowADM_Standards_Master_Row"
		arr(51) = "110ADM_Standards_Master_Row_dbInfoADM_Standards_Master_Row_dbInfo"
		arr(52) = "75ADM_Std_Wiring_Detail_MasterADM_Std_Wiring_Detail_Master"
		arr(53) = "76ADM_Std_Wiring_Detail_Master_RowADM_Std_Wiring_Detail_Master_Row"
		arr(54) = "77ADM_Std_Wiring_Detail_Master_Row_dbInfoADM_Std_Wiring_Detail_Master_Row_dbInfo"
		arr(55) = "51ADM_Voltage_MasterADM_Voltage_Master"
		arr(56) = "52ADM_Voltage_Master_RowADM_Voltage_Master_Row"
		arr(57) = "53ADM_Voltage_Master_Row_dbInfoADM_Voltage_Master_Row_dbInfo"
		arr(58) = "98RSXLI_PLI_Search_DataRSXLI_PLI_Search_Data"
		arr(59) = "99RSXLI_PLI_Search_Data_RowRSXLI_PLI_Search_Data_Row"
		arr(60) = "100RSXLI_PLI_Search_Data_Row_dbInfoRSXLI_PLI_Search_Data_Row_dbInfo"

		GetPartFamilies = arr 
	End Function

	Public Function GetProcessCategories() As String() Implements RuleStream.IRsApplicationManager.GetProcessCategories
		Dim arr(6) as String
		arr(0) = "1Input"
		arr(1) = "2Schedules"
		arr(2) = "3Analyze"
		arr(3) = "4Output"
		arr(4) = "95Cloaked"
		arr(5) = "99Debug"
		arr(6) = "100Delete"
		Return arr

	End Function

	Public Function GetProcesses() As String() Implements RuleStream.IRsApplicationManager.GetProcesses
		Dim arr(1) as String
		arr(0) = "26DefaultProcess5411101DD00000"
		arr(1) = "34DefaultProcess981110DD00000"
		Return arr

	End Function

	Public Function GetUIProcesses() As String() Implements RuleStream.IRsApplicationManager.GetUIProcesses
		Dim arr(-1) as String
		Return arr

	End Function

	Public Function GetTopLevelParts() As String() Implements RuleStream.IRsApplicationManager.GetTopLevelParts
		Dim arr(1) as String
		arr(0) = "54ADM_Data_Master_App57HBSADMINADM_Data_Master_App"
		arr(1) = "98RSXLI_PLI_Search_Data57HBSADMINRSXLI_PLI_Search_Data"
		Return arr

	End Function

	Public Function GetUnitsArray() As String() Implements RuleStream.IRsApplicationManager.GetUnitsArray
		Dim arr(69) as String
		arr(0) = "1millimetersmmBase Unit (Metric)2M100.03937007874015750True"
		arr(1) = "2centimeterscm2M1000.3937007874015750True"
		arr(2) = "3decimetersdm2M10003.937007874015750True"
		arr(3) = "4metersm2M1000039.37007874015750True"
		arr(4) = "5dekametersDM2M100000393.7007874015750True"
		arr(5) = "6kilometerskm2M1000000039370.07874015750True"
		arr(6) = "7inchesinBase Unit (Standard)2E25.4010True"
		arr(7) = "8feetft2E304.80120True"
		arr(8) = "9yardsyd2E914.40360True"
		arr(9) = "10statute milesmiFT * 52802E16093440633600True"
		arr(10) = "11nautical milesna. miFT * 6076.11552E1852000072913.38582677170True"
		arr(11) = "12nanosecondsns128X1E-0901E-090True"
		arr(12) = "13microsecondsms128X1E-0601E-060True"
		arr(13) = "14secondssecBase Unit128X1010True"
		arr(14) = "15minutesmin128X600600True"
		arr(15) = "16hourshr128X3600036000True"
		arr(16) = "17solar daysdayHR * 24.0128X864000864000True"
		arr(17) = "18sidereal dayss. daySEC * 86164.091128X86164.091086164.0910True"
		arr(18) = "19weekswkDAY * 7128X60480006048000True"
		arr(19) = "20yearsyrDAY * 365128X315360000315360000True"
		arr(20) = "21kelvin degreesKBase Unit8M101.80True"
		arr(21) = "22celsius degreesC8M1273.151.8273.15True"
		arr(22) = "23rankine degreesRBase Unit8E0.555555555555556010True"
		arr(23) = "24fahrenheit degreesF8E0.555555555555556459.671459.67True"
		arr(24) = "25radiansradAngular Measurement256X57.295779513057.2957795130True"
		arr(25) = "26degreesdegBase Unit256X1010True"
		arr(26) = "27Pound-mass per cubic inchlbm/in^31024E0.1345343267010False"
		arr(27) = "28Pound-mass per hourlbm/hr2048E0.000612395172700.0002777770False"
		arr(28) = "29feet per minuteft/min524288E5.0800.20False"
		arr(29) = "30feet per secondft/sec524288E304.80120False"
		arr(30) = "31feet per Second Squaredft/sec^24096E304.80120False"
		arr(31) = "33Foot Poundsft-lbs16384E304.801440False"
		arr(32) = "34HorsepowerHP8192E10792000False"
		arr(33) = "35pounds masslbm4E2.20462262185010False"
		arr(34) = "36Pound-mass per footlbm/ft6E0.007233013900.0833330False"
		arr(35) = "37Pound-force per Inchlbf/inMoment16384E0.086796166010False"
		arr(36) = "38inches^4in^4moment of inertia32768E416231.4256010False"
		arr(37) = "39inches^2in^216777216E645.16010False"
		arr(38) = "40Pound-forcelbflbm x g2097152E0.453592368010False"
		arr(39) = "41Pound-force per Square Inchlbf/in^2Stress8388608E0.0007030695765010False"
		arr(40) = "45gallons per minutegal/min8192E63090.1966603.849581150False"
		arr(41) = "46inches^3in^3262144E16387.064010False"
		arr(42) = "48acresacres16777216E4046856422.4062726400False"
		arr(43) = "49centimeters^2cm^216777216M10000.155000310False"
		arr(44) = "50inch poundsin-lbf8388608E11.521245182010False"
		arr(45) = "51centimeters^3cm^3262144M100000.0610237440False"
		arr(46) = "52miles per hourmph524288E447.04017.60False"
		arr(47) = "54feet^2ft^216777216E92903.0401440False"
		arr(48) = "55Accelerationin/sec^233554432E25.4010False"
		arr(49) = "56inches per secondin/sec524288E25.4010False"
		arr(50) = "57Kilometers per HourKPH524288M277.777778010.9361329830False"
		arr(51) = "58litrelitre262144M1000000061.0237438370False"
		arr(52) = "59kilo poundskips65536E2204.62262185010000False"
		arr(53) = "60foot - kilo poundsft- kips8388608E671968.97510120000False"
		arr(54) = "62millimeters^3mm^3262144M106.1024E-050False"
		arr(55) = "63cubic feet per minuteft^3/min8192E471947.4333028.80False"
		arr(56) = "64feet^3ft^3262144E28316846.592017280False"
		arr(57) = "65gallons (US, Liquid)gal262144E3785411.7890230.9748690False"
		arr(58) = "73Newton MetersNmAssumes the Base Metric Unit is millimeters and the Base English Unit is inches1048576M100008.84955750False"
		arr(59) = "75NewtonNThe force which gives an acceleration of 1m/s^2 to a mass of 1 kg.2097152M0.101971621300.22482010False"
		arr(60) = "76PascalsPaForce per unit area (N/m^2)12582912M1.02E-0700.0001450False"
		arr(61) = "77millimeters^2mm^216777216M100.0015500030False"
		arr(62) = "79Revolutions per MinuteRPM33554432X0.016666600.01666660False"
		arr(63) = "80Mega PascalsMPa8388608X0.1020145.0380False"
		arr(64) = "81metres^2m^216777216M100000001550.0031000060False"
		arr(65) = "82meters per secondm/s524288M1000039.370078740False"
		arr(66) = "83metres^3m^3262144M1000000000061023.74383680False"
		arr(67) = "84metres^3 per secondm^3/sVolumetric Flow, Rate of transfer of a volume67108992M1000000000035.31470False"
		arr(68) = "85kilograms per secondkg/sRate of mass transfer132M102.20460False"
		arr(69) = "86kilogramskgmass4M102.20460False"
		Return arr

	End Function

	Public Function GetManualModeCopyState() As String Implements RuleStream.IRsApplicationManager.GetManualModeCopyState
		Return ""

	End Function

	Public Function GetSubpartValidPartFamilies() As String() Implements RuleStream.IRsApplicationManager.GetSubpartValidPartFamilies
		Dim arr(57) as String
		arr(0) = "7755"
		arr(1) = "7956"
		arr(2) = "8360"
		arr(3) = "6949"
		arr(4) = "8049"
		arr(5) = "7650"
		arr(6) = "7451"
		arr(7) = "7052"
		arr(8) = "7153"
		arr(9) = "8161"
		arr(10) = "8262"
		arr(11) = "10975"
		arr(12) = "9076"
		arr(13) = "9177"
		arr(14) = "11293"
		arr(15) = "11094"
		arr(16) = "11195"
		arr(17) = "11598"
		arr(18) = "11399"
		arr(19) = "114100"
		arr(20) = "128111"
		arr(21) = "123112"
		arr(22) = "124113"
		arr(23) = "127114"
		arr(24) = "125115"
		arr(25) = "126116"
		arr(26) = "130105"
		arr(27) = "119106"
		arr(28) = "120107"
		arr(29) = "10666"
		arr(30) = "8467"
		arr(31) = "8568"
		arr(32) = "9469"
		arr(33) = "8670"
		arr(34) = "8771"
		arr(35) = "10572"
		arr(36) = "8873"
		arr(37) = "8974"
		arr(38) = "10878"
		arr(39) = "9279"
		arr(40) = "9380"
		arr(41) = "10481"
		arr(42) = "9582"
		arr(43) = "9683"
		arr(44) = "9785"
		arr(45) = "9886"
		arr(46) = "10787"
		arr(47) = "9988"
		arr(48) = "10089"
		arr(49) = "10390"
		arr(50) = "10191"
		arr(51) = "10292"
		arr(52) = "129102"
		arr(53) = "117103"
		arr(54) = "118104"
		arr(55) = "131108"
		arr(56) = "121109"
		arr(57) = "122110"
		Return arr

	End Function

	Public Function GetValueDataTypes() As String() Implements RuleStream.IRsApplicationManager.GetValueDataTypes
		Dim arr(8) as String
		arr(0) = "1Stringresult = """""
		arr(1) = "2Longresult = 0"
		arr(2) = "3Doubleresult = 0.0"
		arr(3) = "4Dateresult = Date.Today()"
		arr(4) = "5Booleanresult = True"
		arr(5) = "6Point2Dresult = ""0,0"""
		arr(6) = "7Point3Dresult = ""0,0,0"""
		arr(7) = "8Vectorresult = ""[0.0,0.0,0.0]"""
		arr(8) = "9Tensorresult = ""[[0.0, 0.0, 0.0][0.0, 0.0, 0.0][0.0, 0.0, 0.0]]"""
		Return arr

	End Function

	Public Sub Initialize(ByVal objectManager As Object, ByVal docAccess As RuleStream.DocumentManager.IRsDocumentManagerRunTime) Implements RuleStream.IRsApplicationManager.Initialize
		g_ObjectManager = DirectCast(objectManager, RuleStream.Kernel.ObjectManager)
		g_DocAccess = docAccess
		g_rsUser =  CType(System.Threading.Thread.CurrentPrincipal, RuleStream.UserProfile.RuleStreamUser)
		g_ComponentData = RuleStream.DataConnections.GetComponentDataReference
		g_ProjectData = RuleStream.DataConnections.GetProjectDataReference
		g_RulesData = RuleStream.DataConnections.GetRulesDataReference
		RsEngineer = g_ObjectManager.RSEngineer
	End Sub

	Public Function LastGenerated() As Date Implements RuleStream.IRsApplicationManager.LastGenerated
		Return "07/12/2025 14:08:18"
	End Function

	Public Function GetSpecPaths(ByVal intSYS as Integer) As String Implements RuleStream.IRsApplicationManager.GetSpecPaths
			Select Case intSYS
	End Select

	End Function

Public Property RsEngineer() As IRsEngineer Implements IRsApplicationManager.RsEngineer
                Get
                    Return g_RsEngineer
                End Get
                Set(value As IRsEngineer)
                    g_RsEngineer = value
                End Set
            End Property
        
#End Region

End Class

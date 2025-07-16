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
			Case "igs_project_top_app" : Return "IGSEST"
			Case "apc_scan_configuration" : Return "APCTMP01"
			Case "cae_app_calc_print_and_apply" : Return "IGSEST"
			Case "apc_setup" : Return "APCTMP01"
			Case "apc_scan_panel_configuration" : Return "APCTMP01"
			Case "cae_app_calc_print_and_apply_theoretical_max" : Return "IGSEST"
			Case "prd_output_test_01_line" : Return "IGSEST"
			Case "prd_output_test_01" : Return "IGSEST"
			Case "sfd_sm_prd_base_item" : Return "APCTMP01"
			Case "cae_mech_install_metrics" : Return "IGSEST"
			Case "cae_misc_constant" : Return "IGSEST"
			Case "sfd_salesforce_prd_header_mock" : Return "APCTMP01"
			Case "cae_conveyor_costing" : Return "IGSEST"
			Case "cae_ttcb_costing_mech" : Return "IGSEST"
			Case "cae_air_piping_control_panel" : Return "IGSEST"
			Case "cae_mei_hhs_hanger_types" : Return "IGSEST"
			Case "cae_mech_install_app" : Return "APCTMP01"
			Case "cae_chutes" : Return "IGSEST"
			Case "hhs_output_header" : Return "APCTMP01"
			Case "hhs_headerhanger_calc" : Return "APCTMP01"
			Case "hhs_grouping_matrix_controller" : Return "APCTMP01"
			Case "igs_tool_instance_mgr" : Return "IGSEST"
			Case "cae_mech_install_cp_comp" : Return "IGSEST"
			Case "cae_ehs350_data" : Return "IGSEST"
			Case "apc_induction" : Return "APCTMP01"
			Case "cae_app_calc" : Return "IGSEST"
			Case "apc_sortation" : Return "APCTMP01"
			Case "hhs_bom_report_header" : Return "APCTMP01"
			Case "hhs_component_item" : Return "APCTMP01"
			Case "hhs_hanger_item" : Return "APCTMP01"
			Case "hhs_sway_bracing" : Return "APCTMP01"
			Case "sm_hhs_group_calculator" : Return "APCTMP01"
			Case "hhs_bom_item" : Return "APCTMP01"
			Case "sm_generic_bom_item" : Return "APCTMP01"
			Case "hhs_dwgxlsx_importer" : Return "APCTMP01"
			Case "hhs_component_item_db_data" : Return "APCTMP01"
			Case "hhs_sway_bracing_db_data" : Return "APCTMP01"
			Case "cae_mei_pallet_conveyor" : Return "APCTMP01"
			Case "cae_mech_install_conveyor_hours" : Return "IGSEST"
			Case "cae_mei_package_flow_rates" : Return "APCTMP01"
			Case "cae_print_and_apply" : Return "IGSEST"
			Case "hhs_bom_report_line" : Return "APCTMP01"
			Case "hhs_output_line_db_data" : Return "APCTMP01"
			Case "hhs_hanger_item_db_data" : Return "APCTMP01"
			Case "cae_shuttle_mech" : Return "IGSEST"
			Case "cae_conveyor_costing_elec" : Return "IGSEST"
			Case "cae_elec_install_cp_comps" : Return "APCTMP01"
			Case "cae_elec_install_app" : Return "APCTMP01"
			Case "cae_ttcb_costing_elec" : Return "IGSEST"
			Case "cae_shuttle_elec" : Return "IGSEST"
			Case "cae_power_feed_control_panel" : Return "IGSEST"
			Case "cae_power_feeds" : Return "IGSEST"
			Case "cae_conveyor_installs_elec" : Return "IGSEST"
			Case "cae_control_panels_structures_platforms" : Return "IGSEST"
			Case "tmp_metrics_lookup_sample" : Return "IGSEST"
			Case "cae_structures_platform" : Return "IGSEST"
			Case "cae_structures_platforms" : Return "IGSEST"
			Case "cae_elec_install_metrics" : Return "IGSEST"
			Case "igs_opportunity" : Return "IGSEST"
			Case "igs_proposal_data" : Return "IGSEST"
			Case "sfd_salesforce_prd_product_item" : Return "APCTMP01"
			Case "hhs_dwgxlsx_import_line" : Return "APCTMP01"
			Case "hhs_output_line" : Return "APCTMP01"

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
		Dim arr(62) as String 
		arr(0) = "376IGS_Project_Top_AppIGS_Project_Top_App"
		arr(1) = "417APC_Scan_Configuration (APCTMP01)APC_Scan_Configuration"
		arr(2) = "416CAE_App_Calc_Print_And_ApplyCAE_App_Calc_Print_And_Apply"
		arr(3) = "119APC_Setup (APCTMP01)APC_Setup"
		arr(4) = "418APC_Scan_Panel_Configuration (APCTMP01)APC_Scan_Panel_Configuration"
		arr(5) = "422CAE_App_Calc_Print_And_Apply_Theoretical_MaxCAE_App_Calc_Print_And_Apply_Theoretical_Max"
		arr(6) = "426PRD_Output_Test_01_LinePRD_Output_Test_01_Line"
		arr(7) = "425PRD_Output_Test_01PRD_Output_Test_01"
		arr(8) = "371SFD_sm_PRD_Base_Item (APCTMP01)SubMst PRD Base Item"
		arr(9) = "382CAE_Mech_Install_MetricsCAE_Mech_Install_Metrics"
		arr(10) = "427CAE_Misc_ConstantCAE_Misc_Constant"
		arr(11) = "163SFD_Salesforce_PRD_Header_Mock (APCTMP01)SFD_Salesforce_PRD_Header_Mock"
		arr(12) = "389CAE_Conveyor_CostingCAE_Conveyor_Costing"
		arr(13) = "401CAE_TTCB_Costing_MechCAE_TTCB_Costing_Mech"
		arr(14) = "392CAE_Air_Piping_Control_PanelCAE_Air_Piping_Control_Panel"
		arr(15) = "424CAE_MEI_HHS_Hanger_TypesCAE_MEI_HHS_Hanger_Types"
		arr(16) = "360CAE_Mech_Install_App (APCTMP01)CAE Mech Install App"
		arr(17) = "409CAE_ChutesCAE_Chutes"
		arr(18) = "336HHS_Output_Header (APCTMP01)HHS Output Header"
		arr(19) = "333HHS_HeaderHanger_Calc (APCTMP01)Header Hanger Calculator"
		arr(20) = "339HHS_Grouping_Matrix_Controller (APCTMP01)HHS Grouping Matrix Controller"
		arr(21) = "377IGS_Tool_Instance_MgrIGS_Tool_Instance_Mgr"
		arr(22) = "399CAE_Mech_Install_CP_CompCAE_Mech_Install_CP_Comp"
		arr(23) = "419CAE_EHS350_DataCAE_EHS350_Data"
		arr(24) = "122APC_Induction (APCTMP01)APC_Induction"
		arr(25) = "411CAE_App_CalcCAE_App_Calc"
		arr(26) = "120APC_Sortation (APCTMP01)APC_Sortation"
		arr(27) = "407HHS_BOM_Report_Header (APCTMP01)HHS_BOM_Report_Header"
		arr(28) = "353HHS_Component_Item (APCTMP01)HHS Component Item"
		arr(29) = "356HHS_Hanger_Item (APCTMP01)HHS_Hanger_Item"
		arr(30) = "413HHS_Sway_Bracing (APCTMP01)HHS_Sway_Bracing"
		arr(31) = "340sm_HHS_Group_Calculator (APCTMP01)sm HHS Group Calculator"
		arr(32) = "358HHS_BOM_Item (APCTMP01)HHS BOM Item"
		arr(33) = "357sm_Generic_BOM_Item (APCTMP01)sm Generic BOM Item"
		arr(34) = "334HHS_DWGXLSX_Importer (APCTMP01)Header Hanger DWG Excel Importer"
		arr(35) = "354HHS_Component_Item_DB_Data (APCTMP01)HHS_Component_Item_DB_Data"
		arr(36) = "414HHS_Sway_Bracing_DB_Data (APCTMP01)HHS_Sway_Bracing_DB_Data"
		arr(37) = "415CAE_MEI_Pallet_Conveyor (APCTMP01)CAE_MEI_Pallet_Conveyor"
		arr(38) = "384CAE_Mech_Install_Conveyor_HoursCAE Mech Install Conveyor Hours"
		arr(39) = "410CAE_MEI_Package_Flow_Rates (APCTMP01)CAE_MEI_Package_Flow_Rates"
		arr(40) = "412CAE_Print_And_ApplyCAE_Print_And_Apply"
		arr(41) = "408HHS_BOM_Report_Line (APCTMP01)HHS_BOM_Report_Line"
		arr(42) = "338HHS_Output_Line_DB_Data (APCTMP01)HHS Output Line DB Data"
		arr(43) = "355HHS_Hanger_Item_DB_Data (APCTMP01)HHS Hanger Item DB Data"
		arr(44) = "398CAE_Shuttle_MechCAE_Shuttle_Mech"
		arr(45) = "394CAE_Conveyor_Costing_ElecCAE_Conveyor_Costing_Elec"
		arr(46) = "365CAE_Elec_Install_CP_Comps (APCTMP01)CAE Elec Install CP Comps"
		arr(47) = "361CAE_Elec_Install_App (APCTMP01)CAE_Elec_Install_App"
		arr(48) = "402CAE_TTCB_Costing_ElecCAE_TTCB_Costing_Elec"
		arr(49) = "397CAE_Shuttle_ElecCAE_Shuttle_Elec"
		arr(50) = "396CAE_Power_Feed_Control_PanelCAE_Power_Feed_Control_Panel"
		arr(51) = "395CAE_Power_FeedsCAE_Power_Feeds"
		arr(52) = "393CAE_Conveyor_Installs_ElecCAE_Conveyor_Installs_Elec"
		arr(53) = "387CAE_Control_Panels_Structures_PlatformsCAE_Control_Panels_Structures_Platforms"
		arr(54) = "388tmp_Metrics_Lookup_Sampletmp_Metrics_Lookup_Sample"
		arr(55) = "385CAE_Structures_PlatformCAE_Structures_Platform"
		arr(56) = "386CAE_Structures_PlatformsCAE_Structures_Platforms"
		arr(57) = "381CAE_Elec_Install_MetricsCAE_Elec_Install_Metrics"
		arr(58) = "374IGS_OpportunityIGS_Opportunity"
		arr(59) = "375IGS_Proposal_DataIGS_Proposal_Data"
		arr(60) = "164SFD_Salesforce_PRD_Product_Item (APCTMP01)SFD_Salesforce_PRD_Product_Item"
		arr(61) = "335HHS_DWGXLSX_Import_Line (APCTMP01)HHS Import Line"
		arr(62) = "337HHS_Output_Line (APCTMP01)HHS Output Line"

		GetPartFamilies = arr 
	End Function

	Public Function GetProcessCategories() As String() Implements RuleStream.IRsApplicationManager.GetProcessCategories
		Dim arr(10) as String
		arr(0) = "1Input"
		arr(1) = "103Salesforce"
		arr(2) = "104Tool Selection"
		arr(3) = "2Design"
		arr(4) = "3Analyze"
		arr(5) = "4Output"
		arr(6) = "95Cloaked"
		arr(7) = "106App Calc"
		arr(8) = "105Header Hanger"
		arr(9) = "101Mech Install"
		arr(10) = "102Elec Install"
		Return arr

	End Function

	Public Function GetProcesses() As String() Implements RuleStream.IRsApplicationManager.GetProcesses
		Dim arr(1) as String
		arr(0) = "51DefaultProcess37611101DD00000"
		arr(1) = "52DefaultProcess3881110DD00000"
		Return arr

	End Function

	Public Function GetUIProcesses() As String() Implements RuleStream.IRsApplicationManager.GetUIProcesses
		Dim arr(-1) as String
		Return arr

	End Function

	Public Function GetTopLevelParts() As String() Implements RuleStream.IRsApplicationManager.GetTopLevelParts
		Dim arr(1) as String
		arr(0) = "376IGS_Project_Top_App57IGSESTIGS_Project_Top_App"
		arr(1) = "388tmp_Metrics_Lookup_Sample57IGSESTtmp_Metrics_Lookup_Sample"
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
		Dim arr(33) as String
		arr(0) = "267384"
		arr(1) = "311392"
		arr(2) = "312392"
		arr(3) = "314411"
		arr(4) = "330416"
		arr(5) = "340422"
		arr(6) = "307409"
		arr(7) = "273387"
		arr(8) = "308389"
		arr(9) = "309389"
		arr(10) = "289394"
		arr(11) = "290394"
		arr(12) = "286393"
		arr(13) = "334419"
		arr(14) = "262381"
		arr(15) = "274381"
		arr(16) = "252399"
		arr(17) = "285399"
		arr(18) = "299399"
		arr(19) = "261382"
		arr(20) = "301427"
		arr(21) = "292396"
		arr(22) = "291395"
		arr(23) = "294397"
		arr(24) = "295398"
		arr(25) = "272385"
		arr(26) = "271386"
		arr(27) = "297402"
		arr(28) = "296401"
		arr(29) = "255374"
		arr(30) = "253375"
		arr(31) = "258377"
		arr(32) = "342425"
		arr(33) = "343426"
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
		Return "07/16/2025 20:14:51"
	End Function

	Public Function GetSpecPaths(ByVal intSYS as Integer) As String Implements RuleStream.IRsApplicationManager.GetSpecPaths
			Select Case intSYS
		Case 34
			Return "253,255,256,258,259,260"
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

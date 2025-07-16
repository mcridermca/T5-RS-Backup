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
			Case "apc_advanced_calcs" : Return "APCTMP01"
			Case "apc_belt_turn" : Return "APCTMP01"
			Case "apc_belt_turn_data" : Return "APCTMP01"
			Case "apc_belted_panda" : Return "APCTMP01"
			Case "apc_belted_panda_layout" : Return "APCTMP01"
			Case "apc_continuous_ra_discharge" : Return "APCTMP01"
			Case "apc_ehs350data" : Return "APCTMP01"
			Case "apc_induction" : Return "APCTMP01"
			Case "apc_instructions" : Return "APCTMP01"
			Case "apc_intellimerge_psm" : Return "APCTMP01"
			Case "apc_lists_1" : Return "APCTMP01"
			Case "apc_lists_2" : Return "APCTMP01"
			Case "apc_mdr_bw_divert" : Return "APCTMP01"
			Case "apc_mdr_misc" : Return "APCTMP01"
			Case "apc_mdr_rat" : Return "APCTMP01"
			Case "apc_mdr_rat_data" : Return "APCTMP01"
			Case "apc_mdr_sort" : Return "APCTMP01"
			Case "apc_opportunity_data" : Return "APCTMP01"
			Case "apc_pre_merge" : Return "APCTMP01"
			Case "apc_r_m_merge" : Return "APCTMP01"
			Case "apc_scan_belt" : Return "APCTMP01"
			Case "apc_scan_configuration" : Return "APCTMP01"
			Case "apc_scan_panel_configuration" : Return "APCTMP01"
			Case "apc_setup" : Return "APCTMP01"
			Case "apc_sortation" : Return "APCTMP01"
			Case "apc_sortchoices" : Return "APCTMP01"
			Case "apc_space_avail_merge" : Return "APCTMP01"
			Case "apc_std_merge" : Return "APCTMP01"
			Case "apc_std_mergesim" : Return "APCTMP01"
			Case "apc_zfa_applications" : Return "APCTMP01"
			Case "apc_zfachoices" : Return "APCTMP01"
			Case "apc_zipper_merge" : Return "APCTMP01"
			Case "apc_ziptable" : Return "APCTMP01"
			Case "apc_ziptest" : Return "APCTMP01"
			Case "cae_air_piping_control_panel" : Return "IGSEST"
			Case "cae_app_calc" : Return "IGSEST"
			Case "cae_app_calc_print_and_apply" : Return "IGSEST"
			Case "cae_app_calc_print_and_apply_theoretical_max" : Return "IGSEST"
			Case "cae_chutes" : Return "IGSEST"
			Case "cae_control_panels_structures_platforms" : Return "IGSEST"
			Case "cae_conveyor_costing" : Return "IGSEST"
			Case "cae_conveyor_costing_elec" : Return "IGSEST"
			Case "cae_conveyor_installs_elec" : Return "IGSEST"
			Case "cae_ehs350_data" : Return "IGSEST"
			Case "cae_elec_install_app" : Return "APCTMP01"
			Case "cae_elec_install_cp_comps" : Return "APCTMP01"
			Case "cae_elec_install_metrics" : Return "IGSEST"
			Case "cae_eqs_app" : Return "APCTMP01"
			Case "cae_me_asrs_hours" : Return "APCTMP01"
			Case "cae_me_hours" : Return "APCTMP01"
			Case "cae_me_hours_app" : Return "APCTMP01"
			Case "cae_me_system_hours" : Return "APCTMP01"
			Case "cae_mech_install_app" : Return "APCTMP01"
			Case "cae_mech_install_conveyor_hours" : Return "IGSEST"
			Case "cae_mech_install_cp_comp" : Return "IGSEST"
			Case "cae_mech_install_cp_comps" : Return "APCTMP01"
			Case "cae_mech_install_metrics" : Return "IGSEST"
			Case "cae_mei_package_flow_rates" : Return "APCTMP01"
			Case "cae_mei_pallet_conveyor" : Return "APCTMP01"
			Case "cae_misc_constant" : Return "IGSEST"
			Case "cae_netting_estimator_app" : Return "APCTMP01"
			Case "cae_pm_calc_app" : Return "APCTMP01"
			Case "cae_power_feed_control_panel" : Return "IGSEST"
			Case "cae_power_feeds" : Return "IGSEST"
			Case "cae_pqi_app" : Return "APCTMP01"
			Case "cae_shuttle_elec" : Return "IGSEST"
			Case "cae_shuttle_mech" : Return "IGSEST"
			Case "cae_structures_platform" : Return "IGSEST"
			Case "cae_structures_platforms" : Return "IGSEST"
			Case "cae_ttcb_costing_elec" : Return "IGSEST"
			Case "cae_ttcb_costing_mech" : Return "IGSEST"
			Case "cpm_cora_data_mock" : Return "APCTMP01"
			Case "cpm_dbdetails_cora" : Return "APCTMP01"
			Case "elec_install_metrics" : Return "APCTMP01"
			Case "excel_reader_test" : Return "APCTMP01"
			Case "freight_estimate_head" : Return "FrtEst01"
			Case "freight_estimate_item" : Return "FrtEst01"
			Case "freight_estimate_shipfrom_sum" : Return "FrtEst01"
			Case "gen_connection_path_list" : Return "FrtEst01"
			Case "hanger_type" : Return "APCTMP01"
			Case "hhs_bom_item" : Return "APCTMP01"
			Case "hhs_bom_report_header" : Return "APCTMP01"
			Case "hhs_bom_report_line" : Return "APCTMP01"
			Case "hhs_component_item" : Return "APCTMP01"
			Case "hhs_component_item_db_data" : Return "APCTMP01"
			Case "hhs_dwgxlsx_import_line" : Return "APCTMP01"
			Case "hhs_dwgxlsx_importer" : Return "APCTMP01"
			Case "hhs_group_calculator_a" : Return "APCTMP01"
			Case "hhs_group_calculator_b" : Return "APCTMP01"
			Case "hhs_group_calculator_c" : Return "APCTMP01"
			Case "hhs_group_calculator_d" : Return "APCTMP01"
			Case "hhs_group_calculator_e" : Return "APCTMP01"
			Case "hhs_group_calculator_f" : Return "APCTMP01"
			Case "hhs_group_calculator_g" : Return "APCTMP01"
			Case "hhs_group_calculator_k" : Return "APCTMP01"
			Case "hhs_group_calculator_m" : Return "APCTMP01"
			Case "hhs_group_calculator_n" : Return "APCTMP01"
			Case "hhs_group_calculator_p" : Return "APCTMP01"
			Case "hhs_group_calculator_r" : Return "APCTMP01"
			Case "hhs_grouping_matrix_controller" : Return "APCTMP01"
			Case "hhs_hanger_item" : Return "APCTMP01"
			Case "hhs_hanger_item_db_data" : Return "APCTMP01"
			Case "hhs_headerhanger_calc" : Return "APCTMP01"
			Case "hhs_output_header" : Return "APCTMP01"
			Case "hhs_output_line" : Return "APCTMP01"
			Case "hhs_output_line_db_data" : Return "APCTMP01"
			Case "hhs_sway_bracing" : Return "APCTMP01"
			Case "hhs_sway_bracing_db_data" : Return "APCTMP01"
			Case "igs_appcalc_app" : Return "APCTMP01"
			Case "igs_appcalc_app_tmp" : Return "APCTMP01"
			Case "igs_conveyance_component" : Return "APCTMP01"
			Case "igs_conveyance_product" : Return "APCTMP01"
			Case "igs_freight_app" : Return "FrtEst01"
			Case "igs_opportunity_data" : Return "APCTMP01"
			Case "igs_project_area" : Return "APCTMP01"
			Case "igs_project_control_panel" : Return "APCTMP01"
			Case "igs_project_facility" : Return "APCTMP01"
			Case "igs_project_header" : Return "APCTMP01"
			Case "igs_project_section" : Return "APCTMP01"
			Case "igs_project_top_app_test_01" : Return "APCTMP01"
			Case "igs_tool_instance_mgr" : Return "APCTMP01"
			Case "mech_install_metrics" : Return "APCTMP01"
			Case "misc_constant" : Return "APCTMP01"
			Case "prd_output_test_01" : Return "IGSEST"
			Case "prd_output_test_01_line" : Return "IGSEST"
			Case "sfd_salesforce_data_mock" : Return "APCTMP01"
			Case "sfd_salesforce_prd_header_mock" : Return "APCTMP01"
			Case "sfd_salesforce_prd_product_item" : Return "APCTMP01"
			Case "sfd_sm_prd_base_item" : Return "APCTMP01"
			Case "sm_gen_xml_output" : Return "APCTMP01"
			Case "sm_generic_bom_item" : Return "APCTMP01"
			Case "sm_hhs_group_calculator" : Return "APCTMP01"
			Case "sm_igs_prd_fed_tool" : Return "APCTMP01"
			Case "sm_status_warning_error" : Return "APCTMP01"

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
		Dim arr(133) as String 
		arr(0) = "162APC_Advanced_CalcsAPC_Advanced_Calcs"
		arr(1) = "296APC_Belt_TurnAPC_Belt_Turn"
		arr(2) = "194APC_Belt_Turn_DataAPC_Belt_Turn_Data"
		arr(3) = "129APC_Belted_PandAAPC_Belted_PandA"
		arr(4) = "130APC_Belted_PandA_LayoutAPC_Belted_PandA_Layout"
		arr(5) = "133APC_Continuous_RA_DischargeAPC_Continuous_RA_Discharge"
		arr(6) = "300APC_EHS350DataAPC_EHS350 Data"
		arr(7) = "122APC_InductionAPC_Induction"
		arr(8) = "118APC_InstructionsAPC_Instructions"
		arr(9) = "126APC_Intellimerge_PSMAPC_Intellimerge_PSM"
		arr(10) = "297APC_Lists_1APC_Lists_1"
		arr(11) = "298APC_Lists_2APC_Lists_2"
		arr(12) = "139APC_MDR_BW_DivertAPC_MDR_BW_Divert"
		arr(13) = "132APC_MDR_MiscAPC_MDR_Misc"
		arr(14) = "138APC_MDR_RATAPC_MDR_RAT"
		arr(15) = "155APC_MDR_RAT_DataAPC_MDR_RAT_Data"
		arr(16) = "131APC_MDR_SortAPC_MDR_Sort"
		arr(17) = "141APC_Opportunity_DataAPC_Opportunity_Data"
		arr(18) = "123APC_Pre_MergeAPC_Pre_Merge"
		arr(19) = "125APC_R_M_MergeAPC_R_M_Merge"
		arr(20) = "135APC_Scan_BeltAPC_Scan_Belt"
		arr(21) = "417APC_Scan_ConfigurationAPC_Scan_Configuration"
		arr(22) = "418APC_Scan_Panel_ConfigurationAPC_Scan_Panel_Configuration"
		arr(23) = "119APC_SetupAPC_Setup"
		arr(24) = "120APC_SortationAPC_Sortation"
		arr(25) = "299APC_SortChoicesAPC_Sort Choices"
		arr(26) = "128APC_Space_Avail_MergeAPC_Space_Avail_Merge"
		arr(27) = "124APC_Std_MergeAPC_Std_Merge"
		arr(28) = "136APC_STD_MergeSimAPC_STD_MergeSim"
		arr(29) = "134APC_ZFA_ApplicationsAPC_ZFA_Applications"
		arr(30) = "295APC_ZFAChoicesAPC_ZFA Choices"
		arr(31) = "127APC_Zipper_MergeAPC_Zipper_Merge"
		arr(32) = "301APC_ZipTableAPC_ZipTable"
		arr(33) = "137APC_ZipTestAPC_ZipTest"
		arr(34) = "392CAE_Air_Piping_Control_PanelCAE_Air_Piping_Control_Panel"
		arr(35) = "411CAE_App_CalcCAE_App_Calc"
		arr(36) = "416CAE_App_Calc_Print_And_ApplyCAE_App_Calc_Print_And_Apply"
		arr(37) = "422CAE_App_Calc_Print_And_Apply_Theoretical_MaxCAE_App_Calc_Print_And_Apply_Theoretical_Max"
		arr(38) = "409CAE_ChutesCAE_Chutes"
		arr(39) = "387CAE_Control_Panels_Structures_PlatformsCAE_Control_Panels_Structures_Platforms"
		arr(40) = "389CAE_Conveyor_CostingCAE_Conveyor_Costing"
		arr(41) = "394CAE_Conveyor_Costing_ElecCAE_Conveyor_Costing_Elec"
		arr(42) = "393CAE_Conveyor_Installs_ElecCAE_Conveyor_Installs_Elec"
		arr(43) = "419CAE_EHS350_DataCAE_EHS350_Data"
		arr(44) = "361CAE_Elec_Install_AppCAE_Elec_Install_App"
		arr(45) = "365CAE_Elec_Install_CP_CompsCAE Elec Install CP Comps"
		arr(46) = "381CAE_Elec_Install_MetricsCAE_Elec_Install_Metrics"
		arr(47) = "359CAE_EQS_AppCAE EQS App"
		arr(48) = "305CAE_ME_ASRS_HoursCAE_ME_ASRS_Hours"
		arr(49) = "304CAE_ME_HoursCAE_ME_Hours"
		arr(50) = "303CAE_ME_Hours_AppCAE_ME_Hours_App"
		arr(51) = "306CAE_ME_System_HoursCAE_ME_System_Hours"
		arr(52) = "360CAE_Mech_Install_AppCAE Mech Install App"
		arr(53) = "384CAE_Mech_Install_Conveyor_HoursCAE Mech Install Conveyor Hours"
		arr(54) = "399CAE_Mech_Install_CP_CompCAE_Mech_Install_CP_Comp"
		arr(55) = "370CAE_Mech_Install_CP_CompsCAE_Mech_Install_CP_Comps"
		arr(56) = "382CAE_Mech_Install_MetricsCAE_Mech_Install_Metrics"
		arr(57) = "410CAE_MEI_Package_Flow_RatesCAE_MEI_Package_Flow_Rates"
		arr(58) = "415CAE_MEI_Pallet_ConveyorCAE_MEI_Pallet_Conveyor"
		arr(59) = "427CAE_Misc_ConstantCAE_Misc_Constant"
		arr(60) = "364CAE_Netting_Estimator_AppCAE Netting Estimator App"
		arr(61) = "363CAE_PM_Calc_AppCAE PM Calc App"
		arr(62) = "396CAE_Power_Feed_Control_PanelCAE_Power_Feed_Control_Panel"
		arr(63) = "395CAE_Power_FeedsCAE_Power_Feeds"
		arr(64) = "362CAE_PQI_AppCAE PQI App"
		arr(65) = "397CAE_Shuttle_ElecCAE_Shuttle_Elec"
		arr(66) = "398CAE_Shuttle_MechCAE_Shuttle_Mech"
		arr(67) = "385CAE_Structures_PlatformCAE_Structures_Platform"
		arr(68) = "386CAE_Structures_PlatformsCAE_Structures_Platforms"
		arr(69) = "402CAE_TTCB_Costing_ElecCAE_TTCB_Costing_Elec"
		arr(70) = "401CAE_TTCB_Costing_MechCAE_TTCB_Costing_Mech"
		arr(71) = "142CPM_CORA_Data_MockCPM_CORA_Data_Mock"
		arr(72) = "144CPM_DBDetails_CORACPM_DBDetails_CORA"
		arr(73) = "379Elec_Install_MetricsElec_Install_Metrics"
		arr(74) = "366Excel_Reader_TestExce lReader Test"
		arr(75) = "22Freight_Estimate_HeadFreight_Estimate_Head"
		arr(76) = "21Freight_Estimate_ItemFreight_Estimate_Item"
		arr(77) = "35Freight_Estimate_ShipFrom_SumFreight_Estimate_ShipFrom_Sum"
		arr(78) = "308GEN_Connection_Path_ListGEN_Connection_Path_List"
		arr(79) = "404Hanger_TypeHanger_Type"
		arr(80) = "358HHS_BOM_ItemHHS BOM Item"
		arr(81) = "407HHS_BOM_Report_HeaderHHS_BOM_Report_Header"
		arr(82) = "408HHS_BOM_Report_LineHHS_BOM_Report_Line"
		arr(83) = "353HHS_Component_ItemHHS Component Item"
		arr(84) = "354HHS_Component_Item_DB_DataHHS_Component_Item_DB_Data"
		arr(85) = "335HHS_DWGXLSX_Import_LineHHS Import Line"
		arr(86) = "334HHS_DWGXLSX_ImporterHeader Hanger DWG Excel Importer"
		arr(87) = "341HHS_Group_Calculator_AHHS Group Calculator A"
		arr(88) = "342HHS_Group_Calculator_BHHS Group Calculator B"
		arr(89) = "343HHS_Group_Calculator_CHHS Group Calculator C"
		arr(90) = "344HHS_Group_Calculator_DHHS Group Calculator D"
		arr(91) = "345HHS_Group_Calculator_EHHS Group Calculator E"
		arr(92) = "346HHS_Group_Calculator_FHHS Group Calculator F"
		arr(93) = "347HHS_Group_Calculator_GHHS Group Calculator G"
		arr(94) = "348HHS_Group_Calculator_KHHS Group Calculator K"
		arr(95) = "349HHS_Group_Calculator_MHHS Group Calculator M"
		arr(96) = "350HHS_Group_Calculator_NHHS Group Calculator N"
		arr(97) = "351HHS_Group_Calculator_PHHS Group Calculator P"
		arr(98) = "352HHS_Group_Calculator_RHHS Group Calculator R"
		arr(99) = "339HHS_Grouping_Matrix_ControllerHHS Grouping Matrix Controller"
		arr(100) = "356HHS_Hanger_ItemHHS_Hanger_Item"
		arr(101) = "355HHS_Hanger_Item_DB_DataHHS Hanger Item DB Data"
		arr(102) = "333HHS_HeaderHanger_CalcHeader Hanger Calculator"
		arr(103) = "336HHS_Output_HeaderHHS Output Header"
		arr(104) = "337HHS_Output_LineHHS Output Line"
		arr(105) = "338HHS_Output_Line_DB_DataHHS Output Line DB Data"
		arr(106) = "413HHS_Sway_BracingHHS_Sway_Bracing"
		arr(107) = "414HHS_Sway_Bracing_DB_DataHHS_Sway_Bracing_DB_Data"
		arr(108) = "116IGS_AppCalc_AppIGS_AppCalc_App"
		arr(109) = "294IGS_AppCalc_App_TmpIGS_AppCalc_App_Tmp"
		arr(110) = "293IGS_Conveyance_ComponentIGS_Conveyance_Component"
		arr(111) = "292IGS_Conveyance_ProductIGS_Conveyance_Product"
		arr(112) = "18IGS_Freight_AppIGS_Freight_App"
		arr(113) = "302IGS_Opportunity_DataIGS_Opportunity_Data"
		arr(114) = "289IGS_Project_AreaIGS_Project_Area"
		arr(115) = "291IGS_Project_Control_PanelIGS_Project_Control_Panel"
		arr(116) = "287IGS_Project_FacilityIGS_Project_Facility"
		arr(117) = "286IGS_Project_HeaderIGS_Project_Header"
		arr(118) = "290IGS_Project_SectionIGS_Project_Section"
		arr(119) = "285IGS_Project_Top_App_Test_01IGS_Project_Top_App_Test_01"
		arr(120) = "288IGS_Tool_Instance_MgrIGS_Tool_Instance_Mgr"
		arr(121) = "378Mech_Install_MetricsMech_Install_Metrics"
		arr(122) = "405Misc_ConstantMisc_Constant"
		arr(123) = "425PRD_Output_Test_01PRD_Output_Test_01"
		arr(124) = "426PRD_Output_Test_01_LinePRD_Output_Test_01_Line"
		arr(125) = "143SFD_Salesforce_Data_MockSFD_Salesforce_Data_Mock"
		arr(126) = "163SFD_Salesforce_PRD_Header_MockSFD_Salesforce_PRD_Header_Mock"
		arr(127) = "164SFD_Salesforce_PRD_Product_ItemSFD_Salesforce_PRD_Product_Item"
		arr(128) = "371SFD_sm_PRD_Base_ItemSubMst PRD Base Item"
		arr(129) = "423sm_Gen_XML_Outputsm_Gen_XML_Output"
		arr(130) = "357sm_Generic_BOM_Itemsm Generic BOM Item"
		arr(131) = "340sm_HHS_Group_Calculatorsm HHS Group Calculator"
		arr(132) = "403sm_IGS_PRD_Fed_Toolsm_IGS_PRD_Fed_Tool"
		arr(133) = "421sm_Status_Warning_Errorsm_Status_Warning_Error"

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
		Dim arr(6) as String
		arr(0) = "45DefaultProcess1161110DD00000"
		arr(1) = "33DefaultProcess28511101DD00000"
		arr(2) = "34DefaultProcess29411101DD00000"
		arr(3) = "39DefaultProcess33311101DD00000"
		arr(4) = "46DefaultProcess3601110DD00000"
		arr(5) = "42DefaultProcess3611110DD00000"
		arr(6) = "41DefaultProcess3661110DD00000"
		Return arr

	End Function

	Public Function GetUIProcesses() As String() Implements RuleStream.IRsApplicationManager.GetUIProcesses
		Dim arr(-1) as String
		Return arr

	End Function

	Public Function GetTopLevelParts() As String() Implements RuleStream.IRsApplicationManager.GetTopLevelParts
		Dim arr(6) as String
		arr(0) = "360CAE_Mech_Install_App55APCTMP01CAE Mech Install App"
		arr(1) = "361CAE_Elec_Install_App55APCTMP01CAE_Elec_Install_App"
		arr(2) = "366Excel_Reader_Test55APCTMP01Exce lReader Test"
		arr(3) = "333HHS_HeaderHanger_Calc55APCTMP01Header Hanger Calculator"
		arr(4) = "116IGS_AppCalc_App55APCTMP01IGS_AppCalc_App"
		arr(5) = "294IGS_AppCalc_App_Tmp55APCTMP01IGS_AppCalc_App_Tmp"
		arr(6) = "285IGS_Project_Top_App_Test_0155APCTMP01IGS_Project_Top_App_Test_01"
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
		Dim arr(131) as String
		arr(0) = "156116"
		arr(1) = "32118"
		arr(2) = "33119"
		arr(3) = "336119"
		arr(4) = "34120"
		arr(5) = "337120"
		arr(6) = "338120"
		arr(7) = "36122"
		arr(8) = "339122"
		arr(9) = "37123"
		arr(10) = "38124"
		arr(11) = "39125"
		arr(12) = "40126"
		arr(13) = "41127"
		arr(14) = "42128"
		arr(15) = "43129"
		arr(16) = "44130"
		arr(17) = "45131"
		arr(18) = "46132"
		arr(19) = "47133"
		arr(20) = "48134"
		arr(21) = "49135"
		arr(22) = "50136"
		arr(23) = "51137"
		arr(24) = "52138"
		arr(25) = "53138"
		arr(26) = "55139"
		arr(27) = "162141"
		arr(28) = "15142"
		arr(29) = "164142"
		arr(30) = "16143"
		arr(31) = "165143"
		arr(32) = "17144"
		arr(33) = "18144"
		arr(34) = "54155"
		arr(35) = "60155"
		arr(36) = "56162"
		arr(37) = "57163"
		arr(38) = "59163"
		arr(39) = "256163"
		arr(40) = "58164"
		arr(41) = "163194"
		arr(42) = "152286"
		arr(43) = "153287"
		arr(44) = "154288"
		arr(45) = "155289"
		arr(46) = "158290"
		arr(47) = "159291"
		arr(48) = "160292"
		arr(49) = "19302"
		arr(50) = "151302"
		arr(51) = "172302"
		arr(52) = "166303"
		arr(53) = "167304"
		arr(54) = "168305"
		arr(55) = "169306"
		arr(56) = "234333"
		arr(57) = "341333"
		arr(58) = "201334"
		arr(59) = "198335"
		arr(60) = "200336"
		arr(61) = "199337"
		arr(62) = "202338"
		arr(63) = "203339"
		arr(64) = "204340"
		arr(65) = "205353"
		arr(66) = "206353"
		arr(67) = "207353"
		arr(68) = "208353"
		arr(69) = "209353"
		arr(70) = "210353"
		arr(71) = "211353"
		arr(72) = "212353"
		arr(73) = "213353"
		arr(74) = "214353"
		arr(75) = "215353"
		arr(76) = "216353"
		arr(77) = "217353"
		arr(78) = "218354"
		arr(79) = "232355"
		arr(80) = "219356"
		arr(81) = "220356"
		arr(82) = "221356"
		arr(83) = "222356"
		arr(84) = "223356"
		arr(85) = "224356"
		arr(86) = "225356"
		arr(87) = "226356"
		arr(88) = "227356"
		arr(89) = "228356"
		arr(90) = "229356"
		arr(91) = "230356"
		arr(92) = "231356"
		arr(93) = "233357"
		arr(94) = "233358"
		arr(95) = "237359"
		arr(96) = "235360"
		arr(97) = "260360"
		arr(98) = "236361"
		arr(99) = "259361"
		arr(100) = "238362"
		arr(101) = "239363"
		arr(102) = "240364"
		arr(103) = "241365"
		arr(104) = "284365"
		arr(105) = "245371"
		arr(106) = "247371"
		arr(107) = "248371"
		arr(108) = "249371"
		arr(109) = "250371"
		arr(110) = "251371"
		arr(111) = "302407"
		arr(112) = "303408"
		arr(113) = "313410"
		arr(114) = "316413"
		arr(115) = "317413"
		arr(116) = "318413"
		arr(117) = "319413"
		arr(118) = "320413"
		arr(119) = "321413"
		arr(120) = "322413"
		arr(121) = "323413"
		arr(122) = "324413"
		arr(123) = "325413"
		arr(124) = "326413"
		arr(125) = "327413"
		arr(126) = "328413"
		arr(127) = "315414"
		arr(128) = "329415"
		arr(129) = "332417"
		arr(130) = "335417"
		arr(131) = "333418"
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
		Return "07/16/2025 20:14:59"
	End Function

	Public Function GetSpecPaths(ByVal intSYS as Integer) As String Implements RuleStream.IRsApplicationManager.GetSpecPaths
			Select Case intSYS
		Case 34
			Return "16,19,57,59,151,152,154,156,157,162,165,172,235,236,258,259,260"
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

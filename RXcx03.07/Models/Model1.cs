namespace RXcx03._07.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CDQX> CDQX { get; set; }
        public virtual DbSet<CDWH> CDWH { get; set; }
        public virtual DbSet<CollectedInfoTable> CollectedInfoTable { get; set; }
        public virtual DbSet<COMPANYJKB> COMPANYJKB { get; set; }
        public virtual DbSet<COMPANYJKB_GLB> COMPANYJKB_GLB { get; set; }
        public virtual DbSet<CONTORL_DRIVER_INFO> CONTORL_DRIVER_INFO { get; set; }
        public virtual DbSet<DXFZ_DX> DXFZ_DX { get; set; }
        public virtual DbSet<DXFZB> DXFZB { get; set; }
        public virtual DbSet<EmailModel> EmailModel { get; set; }
        public virtual DbSet<FingerPrintTemplate> FingerPrintTemplate { get; set; }
        public virtual DbSet<GGWS_CYRYJBXX> GGWS_CYRYJBXX { get; set; }
        public virtual DbSet<GGWS_JHSYXX> GGWS_JHSYXX { get; set; }
        public virtual DbSet<GGWS_TJZM> GGWS_TJZM { get; set; }
        public virtual DbSet<GZRY> GZRY { get; set; }
        public virtual DbSet<HYDWDMB> HYDWDMB { get; set; }
        public virtual DbSet<Msgs> Msgs { get; set; }
        public virtual DbSet<MZ_XTCS> MZ_XTCS { get; set; }
        public virtual DbSet<OccupationalDiseaseOfSymptoms> OccupationalDiseaseOfSymptoms { get; set; }
        public virtual DbSet<OccupationalDiseaseSymptoms> OccupationalDiseaseSymptoms { get; set; }
        public virtual DbSet<P_OLPay_Back_F2FPayRecord> P_OLPay_Back_F2FPayRecord { get; set; }
        public virtual DbSet<P_OLPay_Back_HasPaymentRecord> P_OLPay_Back_HasPaymentRecord { get; set; }
        public virtual DbSet<P_OLPay_Back_SentPlatformRecord> P_OLPay_Back_SentPlatformRecord { get; set; }
        public virtual DbSet<PhysicalBase> PhysicalBase { get; set; }
        public virtual DbSet<PhysicalDepart> PhysicalDepart { get; set; }
        public virtual DbSet<PhysicalDetail> PhysicalDetail { get; set; }
        public virtual DbSet<PublishControl> PublishControl { get; set; }
        public virtual DbSet<PublishInfo> PublishInfo { get; set; }
        public virtual DbSet<QXKZ> QXKZ { get; set; }
        public virtual DbSet<REPORTINFO> REPORTINFO { get; set; }
        public virtual DbSet<REPORTINFO_HD> REPORTINFO_HD { get; set; }
        public virtual DbSet<REPORTTYPE> REPORTTYPE { get; set; }
        public virtual DbSet<RYLB> RYLB { get; set; }
        public virtual DbSet<RYXX> RYXX { get; set; }
        public virtual DbSet<SEND_DRDC> SEND_DRDC { get; set; }
        public virtual DbSet<SendEmail> SendEmail { get; set; }
        public virtual DbSet<SendEmailAttachments> SendEmailAttachments { get; set; }
        public virtual DbSet<SendMsg> SendMsg { get; set; }
        public virtual DbSet<ShortMessage> ShortMessage { get; set; }
        public virtual DbSet<ShortMessageRev> ShortMessageRev { get; set; }
        public virtual DbSet<ShortMsgModel> ShortMsgModel { get; set; }
        public virtual DbSet<SRFDZB> SRFDZB { get; set; }
        public virtual DbSet<SurveyPaperCategory> SurveyPaperCategory { get; set; }
        public virtual DbSet<SurveyPaperCategoryDetail> SurveyPaperCategoryDetail { get; set; }
        public virtual DbSet<SurveyPaperInfo> SurveyPaperInfo { get; set; }
        public virtual DbSet<SurveyPaperList> SurveyPaperList { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestion { get; set; }
        public virtual DbSet<SurveyQuestionOption> SurveyQuestionOption { get; set; }
        public virtual DbSet<SurveyReport> SurveyReport { get; set; }
        public virtual DbSet<SurveyReportFactors> SurveyReportFactors { get; set; }
        public virtual DbSet<SurveyUserAnswer> SurveyUserAnswer { get; set; }
        public virtual DbSet<SurveyUserRecord> SurveyUserRecord { get; set; }
        public virtual DbSet<TemplateType> TemplateType { get; set; }
        public virtual DbSet<TJ_BBDJB> TJ_BBDJB { get; set; }
        public virtual DbSet<TJ_BBDJMXB> TJ_BBDJMXB { get; set; }
        public virtual DbSet<TJ_BBQRB> TJ_BBQRB { get; set; }
        public virtual DbSet<TJ_BBTJ_BZ> TJ_BBTJ_BZ { get; set; }
        public virtual DbSet<TJ_BBTJ_CXTJ> TJ_BBTJ_CXTJ { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_DWFZJL> TJ_BBTJ_DWTJBG_DWFZJL { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_FKJCHZ> TJ_BBTJ_DWTJBG_FKJCHZ { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_GFBTJ> TJ_BBTJ_DWTJBG_GFBTJ { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_JBRYMD> TJ_BBTJ_DWTJBG_JBRYMD { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_JJRYQD> TJ_BBTJ_DWTJBG_JJRYQD { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_NXJBFBQKFX> TJ_BBTJ_DWTJBG_NXJBFBQKFX { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_SHXGJBTJFX> TJ_BBTJ_DWTJBG_SHXGJBTJFX { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_WJXMHZ> TJ_BBTJ_DWTJBG_WJXMHZ { get; set; }
        public virtual DbSet<TJ_BBTJ_DWTJBG_ZGFJBC> TJ_BBTJ_DWTJBG_ZGFJBC { get; set; }
        public virtual DbSet<TJ_BBTJ_FKZXTJ_FKJCJGHZ> TJ_BBTJ_FKZXTJ_FKJCJGHZ { get; set; }
        public virtual DbSet<TJ_BBTJ_FKZXTJ_ZGFJBC> TJ_BBTJ_FKZXTJ_ZGFJBC { get; set; }
        public virtual DbSet<TJ_BBTJ_TJSJ_DWBG_YXHZ> TJ_BBTJ_TJSJ_DWBG_YXHZ { get; set; }
        public virtual DbSet<TJ_BBTJ_TJSJ_TJRSTJ> TJ_BBTJ_TJSJ_TJRSTJ { get; set; }
        public virtual DbSet<TJ_BBTJ_TJSJ_TJXMHZ> TJ_BBTJ_TJSJ_TJXMHZ { get; set; }
        public virtual DbSet<TJ_BBTJ_TJSJ_YXJGHZ> TJ_BBTJ_TJSJ_YXJGHZ { get; set; }
        public virtual DbSet<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX> TJ_BBTJ_TJSJ_YXJGRYQD_RYXX { get; set; }
        public virtual DbSet<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB> TJ_BBTJ_TJSJ_YXJGRYQD_XMLB { get; set; }
        public virtual DbSet<TJ_BBTJ_ZGBB_DZB> TJ_BBTJ_ZGBB_DZB { get; set; }
        public virtual DbSet<TJ_CZFZ_DT> TJ_CZFZ_DT { get; set; }
        public virtual DbSet<TJ_CZFZ_HD> TJ_CZFZ_HD { get; set; }
        public virtual DbSet<TJ_CZRZB> TJ_CZRZB { get; set; }
        public virtual DbSet<TJ_DJ_XTCS> TJ_DJ_XTCS { get; set; }
        public virtual DbSet<TJ_DJYYXX> TJ_DJYYXX { get; set; }
        public virtual DbSet<TJ_DJYYXX_LOG> TJ_DJYYXX_LOG { get; set; }
        public virtual DbSet<TJ_DLB> TJ_DLB { get; set; }
        public virtual DbSet<TJ_DLB_LOG> TJ_DLB_LOG { get; set; }
        public virtual DbSet<TJ_DMB_INTERFACE> TJ_DMB_INTERFACE { get; set; }
        public virtual DbSet<TJ_DMB_ZDYJ> TJ_DMB_ZDYJ { get; set; }
        public virtual DbSet<TJ_DW_DJ> TJ_DW_DJ { get; set; }
        public virtual DbSet<TJ_DW_ZKB> TJ_DW_ZKB { get; set; }
        public virtual DbSet<TJ_DWBXX> TJ_DWBXX { get; set; }
        public virtual DbSet<TJ_DWFZ_DT> TJ_DWFZ_DT { get; set; }
        public virtual DbSet<TJ_DWFZ_HD> TJ_DWFZ_HD { get; set; }
        public virtual DbSet<TJ_DWFZ_HD_LOG> TJ_DWFZ_HD_LOG { get; set; }
        public virtual DbSet<TJ_DWLB> TJ_DWLB { get; set; }
        public virtual DbSet<TJ_DWTJBG> TJ_DWTJBG { get; set; }
        public virtual DbSet<TJ_DWTJBG_ML> TJ_DWTJBG_ML { get; set; }
        public virtual DbSet<TJ_DWTJJLB> TJ_DWTJJLB { get; set; }
        public virtual DbSet<TJ_DWTJJLB_LOG> TJ_DWTJJLB_LOG { get; set; }
        public virtual DbSet<TJ_DWTJYDDJB> TJ_DWTJYDDJB { get; set; }
        public virtual DbSet<TJ_DWTJYDDJB_LOG> TJ_DWTJYDDJB_LOG { get; set; }
        public virtual DbSet<TJ_DWTJYDDJB_ZYB> TJ_DWTJYDDJB_ZYB { get; set; }
        public virtual DbSet<TJ_DWTJYDDJB_ZYB_JWBS> TJ_DWTJYDDJB_ZYB_JWBS { get; set; }
        public virtual DbSet<TJ_DWTJYDDJB_ZYB_ZYS> TJ_DWTJYDDJB_ZYB_ZYS { get; set; }
        public virtual DbSet<TJ_DWTJYDDJB_ZYB_ZYS_FS> TJ_DWTJYDDJB_ZYB_ZYS_FS { get; set; }
        public virtual DbSet<TJ_ETYYZKPGB_NEW> TJ_ETYYZKPGB_NEW { get; set; }
        public virtual DbSet<TJ_FCXMB> TJ_FCXMB { get; set; }
        public virtual DbSet<TJ_FP_CZY> TJ_FP_CZY { get; set; }
        public virtual DbSet<TJ_FP_CZY_DT> TJ_FP_CZY_DT { get; set; }
        public virtual DbSet<TJ_FPXM> TJ_FPXM { get; set; }
        public virtual DbSet<TJ_FWHY> TJ_FWHY { get; set; }
        public virtual DbSet<TJ_FZJL> TJ_FZJL { get; set; }
        public virtual DbSet<TJ_FZJL_JCYS> TJ_FZJL_JCYS { get; set; }
        public virtual DbSet<TJ_FZMX> TJ_FZMX { get; set; }
        public virtual DbSet<TJ_FZMX_JCYS> TJ_FZMX_JCYS { get; set; }
        public virtual DbSet<TJ_FZTZDY> TJ_FZTZDY { get; set; }
        public virtual DbSet<TJ_FZTZXX> TJ_FZTZXX { get; set; }
        public virtual DbSet<TJ_GG> TJ_GG { get; set; }
        public virtual DbSet<TJ_GZRY_ZHXM_OPENFACE> TJ_GZRY_ZHXM_OPENFACE { get; set; }
        public virtual DbSet<TJ_HISJK_RYXX> TJ_HISJK_RYXX { get; set; }
        public virtual DbSet<TJ_HISJK_RZB> TJ_HISJK_RZB { get; set; }
        public virtual DbSet<TJ_HISJK_XMDZB> TJ_HISJK_XMDZB { get; set; }
        public virtual DbSet<TJ_HSB_DT> TJ_HSB_DT { get; set; }
        public virtual DbSet<TJ_HSB_HD> TJ_HSB_HD { get; set; }
        public virtual DbSet<TJ_HSB_HS_DETAIL> TJ_HSB_HS_DETAIL { get; set; }
        public virtual DbSet<TJ_HSB_XMDZ> TJ_HSB_XMDZ { get; set; }
        public virtual DbSet<TJ_HSB_ZDY_DT> TJ_HSB_ZDY_DT { get; set; }
        public virtual DbSet<TJ_HSB_ZDY_XMDZ> TJ_HSB_ZDY_XMDZ { get; set; }
        public virtual DbSet<TJ_HZKS> TJ_HZKS { get; set; }
        public virtual DbSet<TJ_INTERFACE> TJ_INTERFACE { get; set; }
        public virtual DbSet<TJ_INTERFACE_ZTHX> TJ_INTERFACE_ZTHX { get; set; }
        public virtual DbSet<TJ_JBFB_NL> TJ_JBFB_NL { get; set; }
        public virtual DbSet<TJ_JBFL_DT> TJ_JBFL_DT { get; set; }
        public virtual DbSet<TJ_JBFL_HD> TJ_JBFL_HD { get; set; }
        public virtual DbSet<TJ_JBJLB> TJ_JBJLB { get; set; }
        public virtual DbSet<TJ_JBMB_DT> TJ_JBMB_DT { get; set; }
        public virtual DbSet<TJ_JBMB_HD> TJ_JBMB_HD { get; set; }
        public virtual DbSet<TJ_JCB> TJ_JCB { get; set; }
        public virtual DbSet<TJ_JCXX_TS_LOG> TJ_JCXX_TS_LOG { get; set; }
        public virtual DbSet<TJ_JGXMDZB> TJ_JGXMDZB { get; set; }
        public virtual DbSet<TJ_JK_DZB> TJ_JK_DZB { get; set; }
        public virtual DbSet<TJ_JK_SELECTCOL> TJ_JK_SELECTCOL { get; set; }
        public virtual DbSet<TJ_JK_SELECTTAB> TJ_JK_SELECTTAB { get; set; }
        public virtual DbSet<TJ_JK_TJ> TJ_JK_TJ { get; set; }
        public virtual DbSet<TJ_JK_TSDZB_DT> TJ_JK_TSDZB_DT { get; set; }
        public virtual DbSet<TJ_JK_TSDZB_HD> TJ_JK_TSDZB_HD { get; set; }
        public virtual DbSet<TJ_JKLOG> TJ_JKLOG { get; set; }
        public virtual DbSet<TJ_JWBS> TJ_JWBS { get; set; }
        public virtual DbSet<TJ_JYDJB> TJ_JYDJB { get; set; }
        public virtual DbSet<TJ_JYJGB> TJ_JYJGB { get; set; }
        public virtual DbSet<TJ_JYLX> TJ_JYLX { get; set; }
        public virtual DbSet<TJ_JYNR> TJ_JYNR { get; set; }
        public virtual DbSet<TJ_JYSDJB> TJ_JYSDJB { get; set; }
        public virtual DbSet<TJ_KDJ_XMB> TJ_KDJ_XMB { get; set; }
        public virtual DbSet<TJ_KDJB> TJ_KDJB { get; set; }
        public virtual DbSet<TJ_KEYWORD> TJ_KEYWORD { get; set; }
        public virtual DbSet<TJ_KJL_XMB> TJ_KJL_XMB { get; set; }
        public virtual DbSet<TJ_KJLB> TJ_KJLB { get; set; }
        public virtual DbSet<TJ_KLB_DT> TJ_KLB_DT { get; set; }
        public virtual DbSet<TJ_KLB_HD> TJ_KLB_HD { get; set; }
        public virtual DbSet<TJ_KLB_XMB> TJ_KLB_XMB { get; set; }
        public virtual DbSet<TJ_KSDLB> TJ_KSDLB { get; set; }
        public virtual DbSet<TJ_KSTX> TJ_KSTX { get; set; }
        public virtual DbSet<TJ_KSX> TJ_KSX { get; set; }
        public virtual DbSet<TJ_KXX> TJ_KXX { get; set; }
        public virtual DbSet<TJ_LCLXB> TJ_LCLXB { get; set; }
        public virtual DbSet<TJ_LSSJ_DWBG_YXHZ_STR> TJ_LSSJ_DWBG_YXHZ_STR { get; set; }
        public virtual DbSet<TJ_LSSJ_YXJGHZ> TJ_LSSJ_YXJGHZ { get; set; }
        public virtual DbSet<TJ_LSSJ_YXJGRYQD_XMLB> TJ_LSSJ_YXJGRYQD_XMLB { get; set; }
        public virtual DbSet<TJ_MIES_RYXX> TJ_MIES_RYXX { get; set; }
        public virtual DbSet<TJ_MIES_XMXX> TJ_MIES_XMXX { get; set; }
        public virtual DbSet<TJ_MYPJB> TJ_MYPJB { get; set; }
        public virtual DbSet<TJ_PACS_TP> TJ_PACS_TP { get; set; }
        public virtual DbSet<TJ_PACSBG> TJ_PACSBG { get; set; }
        public virtual DbSet<TJ_PACSDT> TJ_PACSDT { get; set; }
        public virtual DbSet<TJ_PACSHD> TJ_PACSHD { get; set; }
        public virtual DbSet<TJ_PACSJGB> TJ_PACSJGB { get; set; }
        public virtual DbSet<TJ_QY_DT> TJ_QY_DT { get; set; }
        public virtual DbSet<TJ_QY_HD> TJ_QY_HD { get; set; }
        public virtual DbSet<tj_report_twxminfo> tj_report_twxminfo { get; set; }
        public virtual DbSet<TJ_RYLBQXB> TJ_RYLBQXB { get; set; }
        public virtual DbSet<TJ_SEED> TJ_SEED { get; set; }
        public virtual DbSet<TJ_SFCRJ> TJ_SFCRJ { get; set; }
        public virtual DbSet<TJ_SFCYJ> TJ_SFCYJ { get; set; }
        public virtual DbSet<TJ_SFD> TJ_SFD { get; set; }
        public virtual DbSet<TJ_SFJSZL> TJ_SFJSZL { get; set; }
        public virtual DbSet<TJ_SFLB> TJ_SFLB { get; set; }
        public virtual DbSet<TJ_SFYRJ> TJ_SFYRJ { get; set; }
        public virtual DbSet<TJ_SFYRJ_DT> TJ_SFYRJ_DT { get; set; }
        public virtual DbSet<TJ_SFYRJ_FPJL> TJ_SFYRJ_FPJL { get; set; }
        public virtual DbSet<TJ_SFYRJ_SFLB> TJ_SFYRJ_SFLB { get; set; }
        public virtual DbSet<TJ_SFYRJ_SFLX> TJ_SFYRJ_SFLX { get; set; }
        public virtual DbSet<TJ_SJH_FP> TJ_SJH_FP { get; set; }
        public virtual DbSet<TJ_SJH_FPXM> TJ_SJH_FPXM { get; set; }
        public virtual DbSet<TJ_SJH_LOG> TJ_SJH_LOG { get; set; }
        public virtual DbSet<TJ_SJH_SFLX> TJ_SJH_SFLX { get; set; }
        public virtual DbSet<TJ_SQDLX_DT> TJ_SQDLX_DT { get; set; }
        public virtual DbSet<TJ_SQDLX_HD> TJ_SQDLX_HD { get; set; }
        public virtual DbSet<TJ_SUGGESTION> TJ_SUGGESTION { get; set; }
        public virtual DbSet<TJ_TC_DT> TJ_TC_DT { get; set; }
        public virtual DbSet<TJ_TC_HD> TJ_TC_HD { get; set; }
        public virtual DbSet<TJ_TJBBLX> TJ_TJBBLX { get; set; }
        public virtual DbSet<TJ_TJBGJLMB> TJ_TJBGJLMB { get; set; }
        public virtual DbSet<TJ_TJDJB> TJ_TJDJB { get; set; }
        public virtual DbSet<TJ_TJDJB_JKB> TJ_TJDJB_JKB { get; set; }
        public virtual DbSet<TJ_TJDJB_KZ> TJ_TJDJB_KZ { get; set; }
        public virtual DbSet<TJ_TJDJB_LOG> TJ_TJDJB_LOG { get; set; }
        public virtual DbSet<TJ_TJDLRZB> TJ_TJDLRZB { get; set; }
        public virtual DbSet<TJ_TJDWBMWH> TJ_TJDWBMWH { get; set; }
        public virtual DbSet<TJ_TJDWDJB> TJ_TJDWDJB { get; set; }
        public virtual DbSet<TJ_TJJH_DT> TJ_TJJH_DT { get; set; }
        public virtual DbSet<TJ_TJJH_HD> TJ_TJJH_HD { get; set; }
        public virtual DbSet<TJ_TJJLB> TJ_TJJLB { get; set; }
        public virtual DbSet<TJ_TJJLB_LOG> TJ_TJJLB_LOG { get; set; }
        public virtual DbSet<TJ_TJJLMXB> TJ_TJJLMXB { get; set; }
        public virtual DbSet<TJ_TJJLMXB_LOG> TJ_TJJLMXB_LOG { get; set; }
        public virtual DbSet<TJ_TJLB> TJ_TJLB { get; set; }
        public virtual DbSet<TJ_TJQXB> TJ_TJQXB { get; set; }
        public virtual DbSet<TJ_TJRYLB> TJ_TJRYLB { get; set; }
        public virtual DbSet<TJ_TJXM_JKB> TJ_TJXM_JKB { get; set; }
        public virtual DbSet<TJ_TJXMB> TJ_TJXMB { get; set; }
        public virtual DbSet<TJ_TJYSGL> TJ_TJYSGL { get; set; }
        public virtual DbSet<TJ_TJYWLX> TJ_TJYWLX { get; set; }
        public virtual DbSet<TJ_TJZKB> TJ_TJZKB { get; set; }
        public virtual DbSet<TJ_TJZT_XJ> TJ_TJZT_XJ { get; set; }
        public virtual DbSet<TJ_TJZT_XJ_LOG> TJ_TJZT_XJ_LOG { get; set; }
        public virtual DbSet<TJ_TJZTB> TJ_TJZTB { get; set; }
        public virtual DbSet<TJ_TJZTB_DT> TJ_TJZTB_DT { get; set; }
        public virtual DbSet<TJ_TOPZD> TJ_TOPZD { get; set; }
        public virtual DbSet<TJ_TSDZB> TJ_TSDZB { get; set; }
        public virtual DbSet<TJ_TXZD> TJ_TXZD { get; set; }
        public virtual DbSet<TJ_TXZDJLB> TJ_TXZDJLB { get; set; }
        public virtual DbSet<TJ_WTMXB> TJ_WTMXB { get; set; }
        public virtual DbSet<TJ_WTZB> TJ_WTZB { get; set; }
        public virtual DbSet<TJ_XGSFXM> TJ_XGSFXM { get; set; }
        public virtual DbSet<TJ_XTSZ_SFZL> TJ_XTSZ_SFZL { get; set; }
        public virtual DbSet<TJ_YGYYDZB> TJ_YGYYDZB { get; set; }
        public virtual DbSet<TJ_YHPJ_YS> TJ_YHPJ_YS { get; set; }
        public virtual DbSet<TJ_YHPJDAB> TJ_YHPJDAB { get; set; }
        public virtual DbSet<TJ_YHPJJGB> TJ_YHPJJGB { get; set; }
        public virtual DbSet<TJ_YHPJWTB> TJ_YHPJWTB { get; set; }
        public virtual DbSet<TJ_YJSBB> TJ_YJSBB { get; set; }
        public virtual DbSet<TJ_YSXX> TJ_YSXX { get; set; }
        public virtual DbSet<TJ_YXXMCB> TJ_YXXMCB { get; set; }
        public virtual DbSet<TJ_YXXMZB> TJ_YXXMZB { get; set; }
        public virtual DbSet<TJ_ZDKS_DZB> TJ_ZDKS_DZB { get; set; }
        public virtual DbSet<TJ_ZHXM_DT> TJ_ZHXM_DT { get; set; }
        public virtual DbSet<TJ_ZHXM_HD> TJ_ZHXM_HD { get; set; }
        public virtual DbSet<TJ_ZHXMDZB> TJ_ZHXMDZB { get; set; }
        public virtual DbSet<TJ_ZJJL_JY> TJ_ZJJL_JY { get; set; }
        public virtual DbSet<TJ_ZJJL_JY_LOG> TJ_ZJJL_JY_LOG { get; set; }
        public virtual DbSet<TJ_ZJJL_ZS> TJ_ZJJL_ZS { get; set; }
        public virtual DbSet<TJ_ZJJL_ZS_LOG> TJ_ZJJL_ZS_LOG { get; set; }
        public virtual DbSet<TJ_ZJKS_DT> TJ_ZJKS_DT { get; set; }
        public virtual DbSet<TJ_ZJKS_HD> TJ_ZJKS_HD { get; set; }
        public virtual DbSet<TJ_ZJQXB> TJ_ZJQXB { get; set; }
        public virtual DbSet<TJ_ZUJJL_JY> TJ_ZUJJL_JY { get; set; }
        public virtual DbSet<TJ_ZUJJL_JY_LOG> TJ_ZUJJL_JY_LOG { get; set; }
        public virtual DbSet<TJ_ZUJJL_ZS> TJ_ZUJJL_ZS { get; set; }
        public virtual DbSet<TJ_ZUJJL_ZS_LOG> TJ_ZUJJL_ZS_LOG { get; set; }
        public virtual DbSet<TJ_ZUJJLB> TJ_ZUJJLB { get; set; }
        public virtual DbSet<TJ_ZY_TJJLMXB> TJ_ZY_TJJLMXB { get; set; }
        public virtual DbSet<TJ_ZYB_DYBG_DT> TJ_ZYB_DYBG_DT { get; set; }
        public virtual DbSet<TJ_ZYB_DYBG_HD> TJ_ZYB_DYBG_HD { get; set; }
        public virtual DbSet<TJ_ZYB_JCYHYS> TJ_ZYB_JCYHYS { get; set; }
        public virtual DbSet<TJ_ZYB_JWBS> TJ_ZYB_JWBS { get; set; }
        public virtual DbSet<TJ_ZYB_JWBS_Temp> TJ_ZYB_JWBS_Temp { get; set; }
        public virtual DbSet<TJ_ZYB_MBJBB> TJ_ZYB_MBJBB { get; set; }
        public virtual DbSet<TJ_ZYB_PJJLMX> TJ_ZYB_PJJLMX { get; set; }
        public virtual DbSet<TJ_ZYB_RYXX> TJ_ZYB_RYXX { get; set; }
        public virtual DbSet<TJ_ZYB_YHYS_BJXM_GLB> TJ_ZYB_YHYS_BJXM_GLB { get; set; }
        public virtual DbSet<TJ_ZYB_YHYS_MBJB_GLB> TJ_ZYB_YHYS_MBJB_GLB { get; set; }
        public virtual DbSet<TJ_ZYB_YHYS_TJLB_GLB> TJ_ZYB_YHYS_TJLB_GLB { get; set; }
        public virtual DbSet<TJ_ZYB_YHYS_XJXM_GLB> TJ_ZYB_YHYS_XJXM_GLB { get; set; }
        public virtual DbSet<TJ_ZYB_YHYS_ZZWX_GLB> TJ_ZYB_YHYS_ZZWX_GLB { get; set; }
        public virtual DbSet<TJ_ZYB_ZDJY> TJ_ZYB_ZDJY { get; set; }
        public virtual DbSet<TJ_ZYB_ZYS> TJ_ZYB_ZYS { get; set; }
        public virtual DbSet<TJ_ZYB_ZYS_FS> TJ_ZYB_ZYS_FS { get; set; }
        public virtual DbSet<TJ_ZYB_ZYS_FS_Temp> TJ_ZYB_ZYS_FS_Temp { get; set; }
        public virtual DbSet<TJ_ZYB_ZYS_TEMP> TJ_ZYB_ZYS_TEMP { get; set; }
        public virtual DbSet<TJ_ZYB_ZZ> TJ_ZYB_ZZ { get; set; }
        public virtual DbSet<TJ_ZYB_ZZ_HD> TJ_ZYB_ZZ_HD { get; set; }
        public virtual DbSet<TJ_ZYB_ZZZSB> TJ_ZYB_ZZZSB { get; set; }
        public virtual DbSet<TJ_ZYBYDDJB> TJ_ZYBYDDJB { get; set; }
        public virtual DbSet<TJ_ZYJKJCZJBG_BZB> TJ_ZYJKJCZJBG_BZB { get; set; }
        public virtual DbSet<TJ_ZYS_BM> TJ_ZYS_BM { get; set; }
        public virtual DbSet<TJ_ZYS_CJ> TJ_ZYS_CJ { get; set; }
        public virtual DbSet<TJ_ZYS_CSHY> TJ_ZYS_CSHY { get; set; }
        public virtual DbSet<TJ_ZYS_FHCS> TJ_ZYS_FHCS { get; set; }
        public virtual DbSet<TJ_ZYS_FSGZ> TJ_ZYS_FSGZ { get; set; }
        public virtual DbSet<TJ_ZYS_FSYZL> TJ_ZYS_FSYZL { get; set; }
        public virtual DbSet<TJ_ZYS_GZ> TJ_ZYS_GZ { get; set; }
        public virtual DbSet<TJ_ZYS_JBDW> TJ_ZYS_JBDW { get; set; }
        public virtual DbSet<TJ_ZYS_YHYS> TJ_ZYS_YHYS { get; set; }
        public virtual DbSet<TJ_ZYS_ZDBZ> TJ_ZYS_ZDBZ { get; set; }
        public virtual DbSet<TJ_ZYS_ZDDW> TJ_ZYS_ZDDW { get; set; }
        public virtual DbSet<TJ_ZYTJ_RYXX> TJ_ZYTJ_RYXX { get; set; }
        public virtual DbSet<TJ_ZYTJ_TZ> TJ_ZYTJ_TZ { get; set; }
        public virtual DbSet<TJ_ZYTJ_WT> TJ_ZYTJ_WT { get; set; }
        public virtual DbSet<TJ_ZYTJ_WTMX> TJ_ZYTJ_WTMX { get; set; }
        public virtual DbSet<TJLS_HYK> TJLS_HYK { get; set; }
        public virtual DbSet<TJLS_HYXX> TJLS_HYXX { get; set; }
        public virtual DbSet<TTXT_YJMB> TTXT_YJMB { get; set; }
        public virtual DbSet<tzfl_zdcf> tzfl_zdcf { get; set; }
        public virtual DbSet<USER_DEFINED_PBL> USER_DEFINED_PBL { get; set; }
        public virtual DbSet<USER_DEFINED_REPORT> USER_DEFINED_REPORT { get; set; }
        public virtual DbSet<USER_UPDATE_DATAWINDOW_DATETIME> USER_UPDATE_DATAWINDOW_DATETIME { get; set; }
        public virtual DbSet<WJ_DAB> WJ_DAB { get; set; }
        public virtual DbSet<WJ_DAGLXM> WJ_DAGLXM { get; set; }
        public virtual DbSet<WJ_DRDC_HD> WJ_DRDC_HD { get; set; }
        public virtual DbSet<WJ_LOADXML> WJ_LOADXML { get; set; }
        public virtual DbSet<WJ_QUESTIONTYPE> WJ_QUESTIONTYPE { get; set; }
        public virtual DbSet<WJ_TJDJB> WJ_TJDJB { get; set; }
        public virtual DbSet<WJ_TJJLB> WJ_TJJLB { get; set; }
        public virtual DbSet<WJ_TJJLMXB> WJ_TJJLMXB { get; set; }
        public virtual DbSet<WJ_TMGLKS> WJ_TMGLKS { get; set; }
        public virtual DbSet<WJ_WTB> WJ_WTB { get; set; }
        public virtual DbSet<WJ_XGRZ> WJ_XGRZ { get; set; }
        public virtual DbSet<XTGL_TJJGFD> XTGL_TJJGFD { get; set; }
        public virtual DbSet<XTSJ> XTSJ { get; set; }
        public virtual DbSet<YYXT_GRYDDJB> YYXT_GRYDDJB { get; set; }
        public virtual DbSet<YYXT_XTCS> YYXT_XTCS { get; set; }
        public virtual DbSet<ZC> ZC { get; set; }
        public virtual DbSet<ZKQXB> ZKQXB { get; set; }
        public virtual DbSet<ZW> ZW { get; set; }
        public virtual DbSet<always_function> always_function { get; set; }
        public virtual DbSet<data_hospital_fun_pbd> data_hospital_fun_pbd { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<GGWS_JDMC> GGWS_JDMC { get; set; }
        public virtual DbSet<hospital> hospital { get; set; }
        public virtual DbSet<LUOXIANG> LUOXIANG { get; set; }
        public virtual DbSet<menu_mbh> menu_mbh { get; set; }
        public virtual DbSet<menu_module> menu_module { get; set; }
        public virtual DbSet<messages> messages { get; set; }
        public virtual DbSet<MIES_CONFIG> MIES_CONFIG { get; set; }
        public virtual DbSet<MIES_JKXXB> MIES_JKXXB { get; set; }
        public virtual DbSet<mushortcut> mushortcut { get; set; }
        public virtual DbSet<pbcatedt> pbcatedt { get; set; }
        public virtual DbSet<pbcatfmt> pbcatfmt { get; set; }
        public virtual DbSet<pbcatvld> pbcatvld { get; set; }
        public virtual DbSet<QTXTZDB> QTXTZDB { get; set; }
        public virtual DbSet<rs_lastcommit> rs_lastcommit { get; set; }
        public virtual DbSet<rs_threads> rs_threads { get; set; }
        public virtual DbSet<security_apps> security_apps { get; set; }
        public virtual DbSet<security_groupings> security_groupings { get; set; }
        public virtual DbSet<security_info> security_info { get; set; }
        public virtual DbSet<security_template> security_template { get; set; }
        public virtual DbSet<security_users> security_users { get; set; }
        public virtual DbSet<sys_code> sys_code { get; set; }
        public virtual DbSet<sys_seq> sys_seq { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }
        public virtual DbSet<TJ_DRDCLOG> TJ_DRDCLOG { get; set; }
        public virtual DbSet<TJ_DWFZ_DT_LOG> TJ_DWFZ_DT_LOG { get; set; }
        public virtual DbSet<TJ_FCTZZYSX> TJ_FCTZZYSX { get; set; }
        public virtual DbSet<TJ_HSB_ZDY_HD> TJ_HSB_ZDY_HD { get; set; }
        public virtual DbSet<TJ_JKPG_DZB> TJ_JKPG_DZB { get; set; }
        public virtual DbSet<TJ_JYJGBUPDATE> TJ_JYJGBUPDATE { get; set; }
        public virtual DbSet<TJ_JYJGDR_CS> TJ_JYJGDR_CS { get; set; }
        public virtual DbSet<TJ_SFD_LOG> TJ_SFD_LOG { get; set; }
        public virtual DbSet<TJ_SJH> TJ_SJH { get; set; }
        public virtual DbSet<TJ_SZRMYY_JYK> TJ_SZRMYY_JYK { get; set; }
        public virtual DbSet<TJ_TABLESYNTAX> TJ_TABLESYNTAX { get; set; }
        public virtual DbSet<TJ_TJJL> TJ_TJJL { get; set; }
        public virtual DbSet<TJ_TJJLB_XGRZ> TJ_TJJLB_XGRZ { get; set; }
        public virtual DbSet<TJ_TJLXB> TJ_TJLXB { get; set; }
        public virtual DbSet<TJ_TMBQSZ> TJ_TMBQSZ { get; set; }
        public virtual DbSet<TJ_YDTJXMB> TJ_YDTJXMB { get; set; }
        public virtual DbSet<TJ_YDTJXMB_LOG> TJ_YDTJXMB_LOG { get; set; }
        public virtual DbSet<TJ_ZUJJLB_LOG> TJ_ZUJJLB_LOG { get; set; }
        public virtual DbSet<two_purview> two_purview { get; set; }
        public virtual DbSet<user_group> user_group { get; set; }
        public virtual DbSet<user_master> user_master { get; set; }
        public virtual DbSet<user_purview> user_purview { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }
        public virtual DbSet<user_station> user_station { get; set; }
        public virtual DbSet<WJ_DRDC_DT> WJ_DRDC_DT { get; set; }
        public virtual DbSet<结果> 结果 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CDQX>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CDQX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<CDWH>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CDWH>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<CDWH>()
                .Property(e => e.TAG)
                .IsUnicode(false);

            modelBuilder.Entity<CollectedInfoTable>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<CollectedInfoTable>()
                .Property(e => e.PublishId)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANYJKB>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANYJKB>()
                .Property(e => e.DZZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPANYJKB>()
                .Property(e => e.SCZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPANYJKB_GLB>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANYJKB_GLB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<COMPANYJKB_GLB>()
                .Property(e => e.DWMC)
                .IsUnicode(false);

            modelBuilder.Entity<CONTORL_DRIVER_INFO>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<CONTORL_DRIVER_INFO>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTORL_DRIVER_INFO>()
                .Property(e => e.WJLJ)
                .IsUnicode(false);

            modelBuilder.Entity<CONTORL_DRIVER_INFO>()
                .Property(e => e.WJMC32)
                .IsUnicode(false);

            modelBuilder.Entity<CONTORL_DRIVER_INFO>()
                .Property(e => e.WJMC64)
                .IsUnicode(false);

            modelBuilder.Entity<CONTORL_DRIVER_INFO>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<DXFZ_DX>()
                .Property(e => e.JC)
                .IsUnicode(false);

            modelBuilder.Entity<DXFZ_DX>()
                .Property(e => e.NR)
                .IsUnicode(false);

            modelBuilder.Entity<DXFZB>()
                .Property(e => e.FZMC)
                .IsUnicode(false);

            modelBuilder.Entity<EmailModel>()
                .Property(e => e.ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<EmailModel>()
                .Property(e => e.EmailTitle)
                .IsUnicode(false);

            modelBuilder.Entity<EmailModel>()
                .Property(e => e.EmailContent)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.KH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.SFZH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.HYZMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.XM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.FWHY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.GZDW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.YXQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.JD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.HJD)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.XZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.HCRXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_CYRYJBXX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.RQBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.JKZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.HY)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.HJD)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.XJD)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.BMZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.HYZMBH)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.FZDW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.DWMC)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JHSYXX>()
                .Property(e => e.BJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.JKZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.GZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.TJJG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.JKTJDW)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.YXQ)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.HY)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.FWDW)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.BZR)
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_TJZM>()
                .Property(e => e.BMZJHM)
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.DYSRM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.DESRM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.GKMM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.PYJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.WBJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.QTSRF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.XM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.SFZHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.CX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.QX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.GZKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.GZBQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.GZDZ)
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.BGSDH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZZ)
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZZDH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.CHHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.SRF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.JB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.DYZYD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.DYBQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.CAN_DEFINED_DATAWINDOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.DEFAULT_MODE)
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZJYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ADDZD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GZRY>()
                .Property(e => e.ZTBH)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.SJDWBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.DWFZR)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.CZDH)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.LXDZ)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.YZBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.QYXZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.YWYY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.YHZH)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.LB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.PYJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.WBJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.JZBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.JC)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.SFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.YFJE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.WFJE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.KHBH)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.ZZJGDM)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.QYGM)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.JJLX)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.HYFL)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.GYLC)
                .IsUnicode(false);

            modelBuilder.Entity<HYDWDMB>()
                .Property(e => e.DWJJ)
                .IsUnicode(false);

            modelBuilder.Entity<Msgs>()
                .Property(e => e.MSG)
                .IsUnicode(false);

            modelBuilder.Entity<Msgs>()
                .Property(e => e.IPAdress)
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.ZDM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.ZDLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.SZ)
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.XSFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.TSNR)
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.QX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.XSZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.DISP_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.FLMC)
                .IsUnicode(false);

            modelBuilder.Entity<MZ_XTCS>()
                .Property(e => e.SFWK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OccupationalDiseaseSymptoms>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<OccupationalDiseaseSymptoms>()
                .Property(e => e.CheckDoctor)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_F2FPayRecord>()
                .Property(e => e.onlyNum)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_F2FPayRecord>()
                .Property(e => e.orderNum)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_F2FPayRecord>()
                .Property(e => e.paymentType)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_F2FPayRecord>()
                .Property(e => e.TradeNo)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_HasPaymentRecord>()
                .Property(e => e.onlyNum)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_HasPaymentRecord>()
                .Property(e => e.orderNum_platform)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_HasPaymentRecord>()
                .Property(e => e.organizationNum)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_HasPaymentRecord>()
                .Property(e => e.paymentType)
                .IsUnicode(false);

            modelBuilder.Entity<P_OLPay_Back_SentPlatformRecord>()
                .Property(e => e.onlyNum)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.PublishId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.RefNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.PhysicalOrgan)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.PhysicalType)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.Conclusion)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.Advice)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalBase>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.PublishId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.DepartmentId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDepart>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.PublishId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.DepartmentId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.ItemId)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.Sample)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.ResultUnit)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.ResultValue)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.ResultNote)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.ResultExplain)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.RefRange)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<PhysicalDetail>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.PublishId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.PatientId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Age)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.PublishNote)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.ControlType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.Published)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.DEPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PublishControl>()
                .Property(e => e.DRDCBH)
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.MKBBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.DLSBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.MKJCRQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.MKSYZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.MKSFBS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<QXKZ>()
                .Property(e => e.JYM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REPORTINFO>()
                .Property(e => e.FILEPATH)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTINFO_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTINFO_HD>()
                .Property(e => e.JC)
                .IsUnicode(false);

            modelBuilder.Entity<REPORTINFO_HD>()
                .Property(e => e.TemplateNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REPORTTYPE>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REPORTTYPE>()
                .Property(e => e.LXMC)
                .IsUnicode(false);

            modelBuilder.Entity<RYLB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYLB>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYLB>()
                .Property(e => e.PYJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYLB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<RYLB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.TITLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.ZC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.YEARMONTH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.MARYYIED)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.NATIVE)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.JOB)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.ILL)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.ILL_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.COMPANY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.SICK)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.SICK_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.BRAIN_JOB)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.SLEEP)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.EAT)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.FAMILY_ILL)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.THEW_JOB)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.TJMC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.NATION)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.LABEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.DEPT)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.CHOSTID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.SMOKE)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.WINE)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.COFFEE)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.TEA)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.CUR_ILL)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.WAISHANG)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.ZY)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.YWGMS)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.BLOOD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.SPORT)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.QTXG)
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.XYSJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.XYSL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RYXX>()
                .Property(e => e.MZ)
                .IsUnicode(false);

            modelBuilder.Entity<SEND_DRDC>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<SEND_DRDC>()
                .Property(e => e.DRDCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEND_DRDC>()
                .Property(e => e.LY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEND_DRDC>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.EmailID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.PhysicalNo)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.Addressee)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.Sended)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.DEPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SendEmail>()
                .Property(e => e.DRDCBH)
                .IsUnicode(false);

            modelBuilder.Entity<SendEmailAttachments>()
                .Property(e => e.EmailID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SendEmailAttachments>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.PhysicalNo)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.SmContent)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.CreateUserName)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.Sended)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.DEPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessage>()
                .Property(e => e.DRDCBH)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessageRev>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessageRev>()
                .Property(e => e.SmContent)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMessageRev>()
                .Property(e => e.CreateTime)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMsgModel>()
                .Property(e => e.ModelName)
                .IsUnicode(false);

            modelBuilder.Entity<ShortMsgModel>()
                .Property(e => e.ModelContent)
                .IsUnicode(false);

            modelBuilder.Entity<SRFDZB>()
                .Property(e => e.HZNM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SRFDZB>()
                .Property(e => e.PYJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SRFDZB>()
                .Property(e => e.WBJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SRFDZB>()
                .Property(e => e.ZDYM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperCategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperInfo>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperInfo>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperInfo>()
                .Property(e => e.Mars)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperInfo>()
                .Property(e => e.Corp)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperList>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperList>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperList>()
                .Property(e => e.Gather)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperList>()
                .Property(e => e.Ill)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperList>()
                .Property(e => e.Last_Update)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyPaperList>()
                .Property(e => e.Descr)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Descr)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.File)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Valid_Upper)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Normal_Upper)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Normal_Lower)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Valid_Lower)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestion>()
                .Property(e => e.Unit1)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestionOption>()
                .Property(e => e.Option)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyQuestionOption>()
                .Property(e => e.OptionValue)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyReport>()
                .Property(e => e.Evaluator)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyReport>()
                .Property(e => e.Ill)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyReportFactors>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyReportFactors>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyReportFactors>()
                .Property(e => e.Medicine)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserAnswer>()
                .Property(e => e.Data)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.SID)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.Mars)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.Corp)
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SurveyUserRecord>()
                .Property(e => e.Sended)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TemplateType>()
                .Property(e => e.TemplateTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<TemplateType>()
                .Property(e => e.TemplateTypeNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.BBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.ZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.ZHXM_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.MC_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.BBLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.PRINTED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.SJCXXH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJB>()
                .Property(e => e.DYYJSB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.ZHXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.ZHXMBH_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.ZHXMMC_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.XMBH_TJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.XMMC_TJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.XMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBDJMXB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBQRB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBQRB>()
                .Property(e => e.X)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBQRB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBQRB>()
                .Property(e => e.DB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_BZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_BZ>()
                .Property(e => e.BBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_BZ>()
                .Property(e => e.KEYWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_BZ>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_CXTJ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_CXTJ>()
                .Property(e => e.BBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_CXTJ>()
                .Property(e => e.KEYWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_CXTJ>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_DWFZJL>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_DWFZJL>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_DWFZJL>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_DWFZJL>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_DWFZJL>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_DWFZJL>()
                .Property(e => e.FCXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_FKJCHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_FKJCHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_FKJCHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_FKJCHZ>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_FKJCHZ>()
                .Property(e => e.TJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_FKJCHZ>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_GFBTJ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_GFBTJ>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_GFBTJ>()
                .Property(e => e.YEAR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.TJCS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.RYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.FLBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JBRYMD>()
                .Property(e => e.FLMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JJRYQD>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JJRYQD>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JJRYQD>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JJRYQD>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JJRYQD>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_JJRYQD>()
                .Property(e => e.TJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_NXJBFBQKFX>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_NXJBFBQKFX>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_SHXGJBTJFX>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_SHXGJBTJFX>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_WJXMHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_WJXMHZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_WJXMHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_WJXMHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_WJXMHZ>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_WJXMHZ>()
                .Property(e => e.TJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.CSNYR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.HYZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_DWTJBG_ZGFJBC>()
                .Property(e => e.YWH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.CSNYR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.HYZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.ZHXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.ZHXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_FKJCJGHZ>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.CSNYR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.HYZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_FKZXTJ_ZGFJBC>()
                .Property(e => e.YWH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.RYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_DWBG_YXHZ>()
                .Property(e => e.YXHZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJRSTJ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJRSTJ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJRSTJ>()
                .Property(e => e.NLDMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.TJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_TJXMHZ>()
                .Property(e => e.JJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.RYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGHZ>()
                .Property(e => e.YXHZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.TJCS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.RYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.FLBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_RYXX>()
                .Property(e => e.FLMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB>()
                .Property(e => e.RS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB>()
                .Property(e => e.ZJRS)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TJ_BBTJ_TJSJ_YXJGRYQD_XMLB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_ZGBB_DZB>()
                .Property(e => e.ZD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_ZGBB_DZB>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_ZGBB_DZB>()
                .Property(e => e.XMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_ZGBB_DZB>()
                .Property(e => e.SFXSDW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_BBTJ_ZGBB_DZB>()
                .Property(e => e.REPORTTYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_DT>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_DT>()
                .Property(e => e.ZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_DT>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.FZMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.INC_BOTAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.INC_TOPAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.ZC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.ZW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZFZ_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.CZLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.CZYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.CZYXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.CZCK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.CZNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.CZDN)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_CZRZB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.SELECT_READER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.KEY_VALUE_INPUT1)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.KEY_VALUE_INPUT2)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.KEY_VALUE_INPUT3)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.KEY_VALUE_INPUT4)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.KEY_VALUE_INPUT5)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.KEY_VALUE_INPUT6)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJ_XTCS>()
                .Property(e => e.A_KEY_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX_LOG>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX_LOG>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX_LOG>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DJYYXX_LOG>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.DJDLH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.ZTMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.DJDLH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.ZTMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.TJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DLB_LOG>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DMB_INTERFACE>()
                .Property(e => e.FIELDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DMB_INTERFACE>()
                .Property(e => e.FIELDCHINANAME)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DMB_INTERFACE>()
                .Property(e => e.DATATYPE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DMB_INTERFACE>()
                .Property(e => e.FIELDFX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DMB_INTERFACE>()
                .Property(e => e.XXFL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DMB_ZDYJ>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.DJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.DJ)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.DJZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.CZYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.YSPZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_DJ>()
                .Property(e => e.RJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.DJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.DJ)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.YSJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.YSJE2)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.ZKJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DW_ZKB>()
                .Property(e => e.SKR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWBXX>()
                .Property(e => e.ZDM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWBXX>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWBXX>()
                .Property(e => e.NR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWBXX>()
                .Property(e => e.SFXS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWBXX>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWBXX>()
                .Property(e => e.DISP_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.FZMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.INC_BOTAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.INC_TOPAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.BZJG)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.DZBL)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JCYHYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JFJS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JSRS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.XMZK)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.DWGDJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JXXMZK)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.JXZFFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.SFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.FZLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD>()
                .Property(e => e.BJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.FZMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.INC_BOTAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.INC_TOPAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.JG)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TJ_DWFZ_HD_LOG>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWLB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWLB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWLB>()
                .Property(e => e.SFCZBK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWLB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWLB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG>()
                .Property(e => e.BGMLBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG>()
                .Property(e => e.NR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.JBMB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.SFXS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.NR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.BZ1)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.BZ2)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJBG_ML>()
                .Property(e => e.BZ3)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.WCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.ZDBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.WJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.DCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.ZKFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.ZK)
                .HasPrecision(4, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.ZKJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.ZKRYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.SFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.JSFS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.JLR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.DWYFJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.YFYE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.YFJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.YFJE2)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.DWGDJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.WJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.CSLB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.SFCF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.WFJE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.HTBH2)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.HTZRS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB>()
                .Property(e => e.HTZJE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB_LOG>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB_LOG>()
                .Property(e => e.WCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB_LOG>()
                .Property(e => e.ZDBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJJLB_LOG>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.FZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.DJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.SFZH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.RSDAH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.TJJSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.SFVIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.SYKH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.YHYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.JSGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.ZGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.PARENTSNAMES)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.ClASS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB>()
                .Property(e => e.CJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.FZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.DJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.SFZH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.RSDAH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.YHYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.JSGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_LOG>()
                .Property(e => e.ZGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.DHZL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.BM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.ZDDW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.SFQY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.YZBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.HYSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.SYSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.BYYYY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.ZNJKQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.SHSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.JZS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.WHCD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.CSD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.POJCFSXQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB>()
                .Property(e => e.CJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_JWBS>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_JWBS>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_JWBS>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_JWBS>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS_FS>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS_FS>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS_FS>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWTJYDDJB_ZYB_ZYS_FS>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.HEIGHT)
                .HasPrecision(16, 1);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.MDEIAN1)
                .HasPrecision(16, 1);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.MDEIAN2)
                .HasPrecision(16, 1);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.MDEIAN3)
                .HasPrecision(16, 1);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.MDEIAN4)
                .HasPrecision(16, 1);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.MDEIAN5)
                .HasPrecision(16, 1);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.SEX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ETYYZKPGB_NEW>()
                .Property(e => e.TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCXMB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCXMB>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCXMB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY>()
                .Property(e => e.CZYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY>()
                .Property(e => e.FPQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY>()
                .Property(e => e.FPQSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY>()
                .Property(e => e.FPZZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY>()
                .Property(e => e.QT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY_DT>()
                .Property(e => e.CZYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY_DT>()
                .Property(e => e.FPBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY_DT>()
                .Property(e => e.FPZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY_DT>()
                .Property(e => e.FPHM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FP_CZY_DT>()
                .Property(e => e.FPQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FPXM>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FPXM>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FPXM>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FPXM>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FPXM>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FWHY>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FWHY>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FWHY>()
                .Property(e => e.YQRQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FWHY>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FWHY>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.ZHTZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.JYYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.TJZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.TZBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL>()
                .Property(e => e.ZYSX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL_JCYS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL_JCYS>()
                .Property(e => e.ZHTZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL_JCYS>()
                .Property(e => e.JYYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL_JCYS>()
                .Property(e => e.TJZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL_JCYS>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZJL_JCYS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.ZHXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.TZFLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX>()
                .Property(e => e.ZJZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.ZHXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.TZFLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZMX_JCYS>()
                .Property(e => e.ZJZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZDY>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZDY>()
                .Property(e => e.DYRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZXX>()
                .Property(e => e.TZJG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZXX>()
                .Property(e => e.ZHTZRBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZXX>()
                .Property(e => e.ZHTZRName)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FZTZXX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_GG>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_GG>()
                .Property(e => e.GG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_GZRY_ZHXM_OPENFACE>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_GZRY_ZHXM_OPENFACE>()
                .Property(e => e.GZRYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RYXX>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RYXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RYXX>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RZB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RZB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RZB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_RZB>()
                .Property(e => e.RZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_XMDZB>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_XMDZB>()
                .Property(e => e.XMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_XMDZB>()
                .Property(e => e.HIS_SFDM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_XMDZB>()
                .Property(e => e.HIS_SFXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HISJK_XMDZB>()
                .Property(e => e.DJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_HISJK_XMDZB>()
                .Property(e => e.DZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.GJZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.CKZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.SFZSYM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.CKZ2)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_DT>()
                .Property(e => e.AGE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HD>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HD>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HD>()
                .Property(e => e.CKZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HD>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HS_DETAIL>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HS_DETAIL>()
                .Property(e => e.ZHXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HS_DETAIL>()
                .Property(e => e.BDS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HS_DETAIL>()
                .Property(e => e.BDS_LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_HS_DETAIL>()
                .Property(e => e.BDS_Z)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_XMDZ>()
                .Property(e => e.HSID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_XMDZ>()
                .Property(e => e.GJZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_XMDZ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_XMDZ>()
                .Property(e => e.DZM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_XMDZ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_XMDZ>()
                .Property(e => e.DZM1)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.CKZ_SX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.CKZ_XX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.DZM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.TJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_DT>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_XMDZ>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_XMDZ>()
                .Property(e => e.DZM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_XMDZ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_XMDZ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HZKS>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HZKS>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HZKS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HZKS>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.INTERFACE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.DBMS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.SERVER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.DBNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.LOGID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.LOGPASS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.PARM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.AUTOCOMMIT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.INTEGRATEDSECURITY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.SELECTTABLE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.SELECTFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.SELECTJOIN)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.FIELDOPP)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.FIELDOPP_XMXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.ARGOPP)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.ARGOPP_XMXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.REPORT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.REPORT_XMXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.MIES_XML_WYH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.RYDJ_TAB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.RYDJ_TABLEC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.RYDJ_COLUMN)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.RYDJ_SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.ZHXM_TAB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.ZHXM_TABLEC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.ZHXM_COLUMN)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.ZHXM_SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.IS_QY_XML)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.OPPOSING_CPBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.RYXX_PROC_SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.RYXX_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.XMXX_PROC_SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE>()
                .Property(e => e.XMXX_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_INTERFACE_ZTHX>()
                .Property(e => e.HXSQL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFB_NL>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_DT>()
                .Property(e => e.FLBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_DT>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_DT>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_DT>()
                .Property(e => e.ORDER_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.FLBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.FLMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.QYBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBFL_HD>()
                .Property(e => e.FLLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.JBXH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.TJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.ZJYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBJLB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_DT>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_DT>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_DT>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_HD>()
                .Property(e => e.MBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_HD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JBMB_HD>()
                .Property(e => e.QYBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCB>()
                .Property(e => e.DJDLH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCB>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCB>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCB>()
                .Property(e => e.XM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCB>()
                .Property(e => e.SFJC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCXX_TS_LOG>()
                .Property(e => e.DataType)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JCXX_TS_LOG>()
                .Property(e => e.DataNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JGXMDZB>()
                .Property(e => e.TJMXXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JGXMDZB>()
                .Property(e => e.TJMXXMMC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JGXMDZB>()
                .Property(e => e.GJC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JGXMDZB>()
                .Property(e => e.GJCMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JGXMDZB>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_DZB>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_DZB>()
                .Property(e => e.TAB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_DZB>()
                .Property(e => e.COL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_DZB>()
                .Property(e => e.DZM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_DZB>()
                .Property(e => e.PK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_SELECTCOL>()
                .Property(e => e.TAB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_SELECTCOL>()
                .Property(e => e.COL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_SELECTTAB>()
                .Property(e => e.TAB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_SELECTTAB>()
                .Property(e => e.TAB_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TJ>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TJ>()
                .Property(e => e.COL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TJ>()
                .Property(e => e.TJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TJ>()
                .Property(e => e.DZM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TSDZB_DT>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TSDZB_DT>()
                .Property(e => e.VAL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TSDZB_HD>()
                .Property(e => e.GJZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TSDZB_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JK_TSDZB_HD>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKLOG>()
                .Property(e => e.XTMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKLOG>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKLOG>()
                .Property(e => e.XMBH_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKLOG>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKLOG>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKLOG>()
                .Property(e => e.DZBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.TJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.XM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.JOB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.JWBS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.YWGMS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.ZLZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.MQHZBS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.GZQD_NL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.GZQD_TL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.SMZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.SMZK_SM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.YYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.WINE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.COFFEE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.TEA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JWBS>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.SJCXXH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYDJB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.ZHXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.ZHXMBH_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.ZHXMMC_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.XMBH_TJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.XMMC_TJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.XMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.CKFW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.SHR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.PROMPT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYLX>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYLX>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYLX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYLX>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYNR>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYNR>()
                .Property(e => e.JYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYNR>()
                .Property(e => e.JYNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYNR>()
                .Property(e => e.JYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYNR>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYSDJB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYSDJB>()
                .Property(e => e.JYSID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYSDJB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJ_XMB>()
                .Property(e => e.TJKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJ_XMB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.TJKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.GYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.LBBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.ZHXGRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.XSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.ZXR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.GMR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.GMDW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.TEL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KDJB>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.KEYWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.JBBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.INTO_XJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.SFYX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.XY)
                .HasPrecision(20, 3);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.DY)
                .HasPrecision(20, 3);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.JGLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.MCJRXJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.PYJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.WBJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.NLXX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.NLSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KEYWORD>()
                .Property(e => e.SFZC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJL_XMB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJL_XMB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJLB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJLB>()
                .Property(e => e.TJKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJLB>()
                .Property(e => e.GYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJLB>()
                .Property(e => e.TJKLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJLB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KJLB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_DT>()
                .Property(e => e.LBBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_DT>()
                .Property(e => e.SXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_DT>()
                .Property(e => e.ZL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_HD>()
                .Property(e => e.DISP_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_HD>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_XMB>()
                .Property(e => e.LBBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KLB_XMB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSDLB>()
                .Property(e => e.KSBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSDLB>()
                .Property(e => e.SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSDLB>()
                .Property(e => e.DJSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSTX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSTX>()
                .Property(e => e.YSGKH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSTX>()
                .Property(e => e.MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSX>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KSX>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KXX>()
                .Property(e => e.TJKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KXX>()
                .Property(e => e.GYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_KXX>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LCLXB>()
                .Property(e => e.LCLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LCLXB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LCLXB>()
                .Property(e => e.DISP_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LCLXB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LCLXB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LCLXB>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_DWBG_YXHZ_STR>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGHZ>()
                .Property(e => e.MCJG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGRYQD_XMLB>()
                .Property(e => e.TJID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGRYQD_XMLB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGRYQD_XMLB>()
                .Property(e => e.JBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGRYQD_XMLB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_LSSJ_YXJGRYQD_XMLB>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_RYXX>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_RYXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_RYXX>()
                .Property(e => e.LIS_SQBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_RYXX>()
                .Property(e => e.PACS_SQBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_XMXX>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_XMXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_XMXX>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MIES_XMXX>()
                .Property(e => e.ZHBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MYPJB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MYPJB>()
                .Property(e => e.PJJG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_MYPJB>()
                .Property(e => e.JY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACS_TP>()
                .Property(e => e.SQDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACS_TP>()
                .Property(e => e.TPMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSBG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.ZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.ZHXM_PACS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.MC_PACS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.MXXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSDT>()
                .Property(e => e.PACSDJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSHD>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSHD>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSHD>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSHD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSHD>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.ZHXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.ZHXMBH_PACS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.ZHXMMC_PACS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.PACSDJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.JL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.SHR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.TPZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.JCQKFZSM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.TPLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.CZY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_PACSJGB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_DT>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_DT>()
                .Property(e => e.ZTBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.SFVIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.SYXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.PMXSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.PMDLS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_QY_HD>()
                .Property(e => e.SFYYJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tj_report_twxminfo>()
                .Property(e => e.jsjmc)
                .IsUnicode(false);

            modelBuilder.Entity<tj_report_twxminfo>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<tj_report_twxminfo>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tj_report_twxminfo>()
                .Property(e => e.tw_type)
                .IsUnicode(false);

            modelBuilder.Entity<tj_report_twxminfo>()
                .Property(e => e.tpmcA)
                .IsUnicode(false);

            modelBuilder.Entity<tj_report_twxminfo>()
                .Property(e => e.tpmcB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_RYLBQXB>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_RYLBQXB>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_RYLBQXB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SEED>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SEED>()
                .Property(e => e.RQSTRING)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SEED>()
                .Property(e => e.XH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCRJ>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCRJ>()
                .Property(e => e.RJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCRJ>()
                .Property(e => e.RJSJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCRJ>()
                .Property(e => e.YJID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCRJ>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCYJ>()
                .Property(e => e.YF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCYJ>()
                .Property(e => e.RQFROM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCYJ>()
                .Property(e => e.RQTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFCYJ>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.YLKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.BRJSLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SFCK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.LY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.KDKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SFBZBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.DJ)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SJFY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SKYBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.MZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.TJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.ZRJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.LRFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.XMJCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.XMJCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.XMHDR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.TCBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.SFTF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.ZKBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SFD>()
                .Property(e => e.YSDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SFJSZL>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFJSZL>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFJSZL>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.HSLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.FPXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFLB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.RJSJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.SFCRJID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.SFCJZHT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.MINSJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.MAXSJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.ZJJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.ZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.JZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ>()
                .Property(e => e.TKJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_DT>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_DT>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_DT>()
                .Property(e => e.SFLBMC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_DT>()
                .Property(e => e.ZJJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_DT>()
                .Property(e => e.ZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_DT>()
                .Property(e => e.JZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_FPJL>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_FPJL>()
                .Property(e => e.FPHFROM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_FPJL>()
                .Property(e => e.FPHTO)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_FPJL>()
                .Property(e => e.FPQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_FPJL>()
                .Property(e => e.FPHMF)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_FPJL>()
                .Property(e => e.FPHMT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_SFLB>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_SFLB>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_SFLB>()
                .Property(e => e.SFLBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_SFLB>()
                .Property(e => e.ZJJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_SFLB>()
                .Property(e => e.ZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_SFLB>()
                .Property(e => e.JZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFYRJ_SFLX>()
                .Property(e => e.RJID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_SFLX>()
                .Property(e => e.SFLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFYRJ_SFLX>()
                .Property(e => e.JE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TJ_SJH_FP>()
                .Property(e => e.YLKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FP>()
                .Property(e => e.FPQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FP>()
                .Property(e => e.FPXH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FP>()
                .Property(e => e.FPHM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FP>()
                .Property(e => e.SFTF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FP>()
                .Property(e => e.SJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FPXM>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FPXM>()
                .Property(e => e.FPXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_FPXM>()
                .Property(e => e.JE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.YLKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.KB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.BRSFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.JSZL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.EKJS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.ZJJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.ZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.JZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.DYBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.YSSJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.SKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.SKYBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.RJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.YS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.YJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.JZBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.JZDHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.JZDH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.ZRJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.TCZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.GRZHZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.YLJZZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.TCJZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH_LOG>()
                .Property(e => e.HPBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_SFLX>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_SFLX>()
                .Property(e => e.SFLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_SFLX>()
                .Property(e => e.KH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_SFLX>()
                .Property(e => e.JE)
                .HasPrecision(9, 2);

            modelBuilder.Entity<TJ_SJH_SFLX>()
                .Property(e => e.SFTF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH_SFLX>()
                .Property(e => e.SFY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_DT>()
                .Property(e => e.FLBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_DT>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_DT>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.FLBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.FLMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.QYBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.JCJYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.BBLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.TMQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SQDLX_HD>()
                .Property(e => e.XH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.KEYWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.SECWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.BOTLIMIT)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.TOPLIMIT)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.JBBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.JGLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.ICD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.JYNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.SFCJB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.SJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.BHZF)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.EXPLAIN)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.LCLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.PYJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.WBJM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SUGGESTION>()
                .Property(e => e.OccupationalDiseaseSuggest)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_DT>()
                .Property(e => e.TCBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_DT>()
                .Property(e => e.ZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_DT>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.JG)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.TCLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.BZJG)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.JC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TC_HD>()
                .Property(e => e.SFQY_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBBLX>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBBLX>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBBLX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBBLX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBBLX>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.MBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.NR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.CJR)
                .IsFixedLength();

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength();

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.SFQY)
                .IsFixedLength();

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.SCBS)
                .IsFixedLength();

            modelBuilder.Entity<TJ_TJBGJLMB>()
                .Property(e => e.MBLXBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ZS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.JY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.GDYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.FZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SUMOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SJCXXH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.FZTZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.FZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJJL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.RSDAH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJJSR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SV_CALLBACK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SV_SMS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SV_EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SV_WEB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.BM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.YHYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.WHCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.FZDW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.BZR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SYKH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJSFZC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.KBSM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.HYID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SFKD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.GRZPBCLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ZDYJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.DJDLH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SFVIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.YSBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ZYDHSBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ZYDHSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJBGFFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.TJBGFFR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.DWTJGRSFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.LIS_SQBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.PACS_SQBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.RIS_SQBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.PARENTSNAMES)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.ClASS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB>()
                .Property(e => e.BS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.UniqueID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.YWLXBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.YYDW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.YGGH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.TJTCMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.YYM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.CJR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_JKB>()
                .Property(e => e.XGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_KZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_KZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.ZS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.JY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.GDYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.FZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SUMOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SJCXXH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.FZTZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.FZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJJL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.RSDAH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJJSR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SV_CALLBACK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SV_SMS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SV_EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.SV_WEB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.BM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.YHYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.WHCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.FZDW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.BZR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.ZYDHSBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.ZYDHSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJBGFFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.TJBGFFR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDJB_LOG>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDLRZB>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDLRZB>()
                .Property(e => e.ZTMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDLRZB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.SJBMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.BMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.BMFZR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.BMLXDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWBMWH>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.DJXH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.DWBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.JZZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.JZSJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.DWJZR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.JZJE)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJDWDJB>()
                .Property(e => e.JSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_DT>()
                .Property(e => e.JHH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_DT>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_DT>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_DT>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_DT>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_HD>()
                .Property(e => e.JHH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_HD>()
                .Property(e => e.WCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJH_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.XMDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.DZBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.ISOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.CHARGED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.SFJZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.DYYJSB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JYYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.SSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.TCBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.ZJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.XMBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.ZEBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.SSDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.TPZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.TPLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JCQKFZSM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.HBXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.MRBCLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.SQDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.DJISOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.YSBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.XMZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.JXR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB>()
                .Property(e => e.BARCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.XMDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.DZBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.ISOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.CHARGED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.SFJZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.DYYJSB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JYYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.SSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.TCBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.ZJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.XMBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.ZEBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.SSDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.TPZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.TPLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JCQKFZSM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.HBXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.MRBCLJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.SQDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.JXR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_LOG>()
                .Property(e => e.BARCODE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.TJZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.CKXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB>()
                .Property(e => e.CKZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.TJZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.CKXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLMXB_LOG>()
                .Property(e => e.CKZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.SFCZBK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.BGLX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.SFMRZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLB>()
                .Property(e => e.ZYBLX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJQXB>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJQXB>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJQXB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJRYLB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJRYLB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJRYLB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJRYLB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXM_JKB>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.CKXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.CKSX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.ZCTS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.PDTS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.PGTS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.CKJG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.JCJYXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.DJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.SXXZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.XXXZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.HAS_IMAGE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.IMAGE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.SFXJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.MCJRXJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.NXCKXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.NXCKSX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.QYBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.JGLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJXMB>()
                .Property(e => e.LCLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYSGL>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYSGL>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYSGL>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYSGL>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYWLX>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYWLX>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYWLX>()
                .Property(e => e.SFQY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJYWLX>()
                .Property(e => e.SFMRZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZKB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZKB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZKB>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.XJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.JGQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.XJTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.XJSM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.XJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.JGQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.XJTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.XJSM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZT_XJ_LOG>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.SYXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.DYPD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.SFQYDL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.PMSFXS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB>()
                .Property(e => e.JJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB_DT>()
                .Property(e => e.QYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB_DT>()
                .Property(e => e.ZTBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB_DT>()
                .Property(e => e.TJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJZTB_DT>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TOPZD>()
                .Property(e => e.LXBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TOPZD>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TOPZD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TSDZB>()
                .Property(e => e.XSNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TSDZB>()
                .Property(e => e.CSNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TSDZB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZD>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZD>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZD>()
                .Property(e => e.ORDER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.JBBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.TJLX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.ZHXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TXZDJLB>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTMXB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTMXB>()
                .Property(e => e.XH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTMXB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTMXB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.LB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.JGLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.XZLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.STEP)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_WTZB>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.JG)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XGSFXM>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XTSZ_SFZL>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XTSZ_SFZL>()
                .Property(e => e.ZKMS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XTSZ_SFZL>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_XTSZ_SFZL>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YGYYDZB>()
                .Property(e => e.YYXJG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YGYYDZB>()
                .Property(e => e.DZXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YGYYDZB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YGYYDZB>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJ_YS>()
                .Property(e => e.GKHM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJ_YS>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJ_YS>()
                .Property(e => e.ZTBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJ_YS>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJ_YS>()
                .Property(e => e.PJJG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJDAB>()
                .Property(e => e.WTBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJDAB>()
                .Property(e => e.XH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJDAB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJDAB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJJGB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJJGB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJJGB>()
                .Property(e => e.WTBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJJGB>()
                .Property(e => e.DAXH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJWTB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJWTB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJWTB>()
                .Property(e => e.JGLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YHPJWTB>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YJSBB>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YJSBB>()
                .Property(e => e.SBMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YJSBB>()
                .Property(e => e.JCJYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YJSBB>()
                .Property(e => e.BBLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YJSBB>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YJSBB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YSXX>()
                .Property(e => e.GKHM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YSXX>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YSXX>()
                .Property(e => e.ZTBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YSXX>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YSXX>()
                .Property(e => e.PJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMCB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMCB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMCB>()
                .Property(e => e.TCBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMCB>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.TJYWLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YXXMZB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZDKS_DZB>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZDKS_DZB>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZDKS_DZB>()
                .Property(e => e.LCLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_DT>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_DT>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_DT>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_DT>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.JCJYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.DJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.DZBL)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SFCX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SFXYBB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.BBLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.TSXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SFFCSQD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.DYYJSB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.YXBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.JGHQFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.PYJM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.WBJM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.ZDYM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.ZCXJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.BZDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SFCQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.LCYY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.LCLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.ZDZK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.CBDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.DJQZKS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SQD_JKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.BGD_JKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.SQDBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.GNLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXM_HD>()
                .Property(e => e.TPXSZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXMDZB>()
                .Property(e => e.TJZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXMDZB>()
                .Property(e => e.TJZHXMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXMDZB>()
                .Property(e => e.GJC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXMDZB>()
                .Property(e => e.GJCMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZHXMDZB>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY>()
                .Property(e => e.ZJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY>()
                .Property(e => e.JYTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY>()
                .Property(e => e.JYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY>()
                .Property(e => e.JYNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY_LOG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY_LOG>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY_LOG>()
                .Property(e => e.ZJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY_LOG>()
                .Property(e => e.JYTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY_LOG>()
                .Property(e => e.JYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_JY_LOG>()
                .Property(e => e.JYNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.JGQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.ZJTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.JGQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.ZJTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJJL_ZS_LOG>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_DT>()
                .Property(e => e.ZJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_DT>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_DT>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_DT>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_HD>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJKS_HD>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJQXB>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJQXB>()
                .Property(e => e.ZJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJQXB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZJQXB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.ZUJKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.ZSBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.JYTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.JYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY>()
                .Property(e => e.JYNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.ZUJKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.ZSBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.JYTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.JYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_JY_LOG>()
                .Property(e => e.JYNR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.JGQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.ZUJKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.ZJTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.ZDBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.ZHXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.JGQZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.ZUJKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.ZJTT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJL_ZS_LOG>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJLB>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJLB>()
                .Property(e => e.ZUJKSBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJLB>()
                .Property(e => e.ZUJYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZY_TJJLMXB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZY_TJJLMXB>()
                .Property(e => e.TJZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZY_TJJLMXB>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_DYBG_DT>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_DYBG_HD>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_DYBG_HD>()
                .Property(e => e.JC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_JCYHYS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_JCYHYS>()
                .Property(e => e.JCYHYSBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_JWBS_Temp>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_JWBS_Temp>()
                .Property(e => e.Clientip)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_JWBS_Temp>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_PJJLMX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_PJJLMX>()
                .Property(e => e.TJXMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.GH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.SFQY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.SFXY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XYNS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.SFYJ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.YJSJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.FSGZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.FSYZL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.FSQD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.SZJL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.YCQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.JTFY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.DHQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.JTBS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.DWDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.YGZDWJGZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZYBWHJCS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.HY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.JSGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.LCBX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XYSJCJG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZDBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZDJL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.CLYJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.WJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZDBZ2)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZDBZ3)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZYJCS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.JTDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.WHCD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.HXXT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XHXT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XHUAXT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZXXT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.NFMXT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.MLSZXT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.PF)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.POJCFSXQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.POZYJJKZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.ZNJKZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.XHBJZYZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.BYYYY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.PJ_WJYC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.PJ_FC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.PJ_YSZYB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.PJ_ZYJJZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.PJ_QTYC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.YZBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.HYSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.SYSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_RYXX>()
                .Property(e => e.CJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_YHYS_BJXM_GLB>()
                .Property(e => e.ExamItemID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_YHYS_BJXM_GLB>()
                .Property(e => e.DepartmentsID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_YHYS_TJLB_GLB>()
                .Property(e => e.Stage)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_YHYS_XJXM_GLB>()
                .Property(e => e.ExamItemID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_YHYS_XJXM_GLB>()
                .Property(e => e.DepartmentsID)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.JL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.JY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.DISPORDER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZDJY>()
                .Property(e => e.HarmfulFactors)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS>()
                .Property(e => e.GL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_FS>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_FS_Temp>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_FS_Temp>()
                .Property(e => e.Clientip)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_FS_Temp>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_TEMP>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_TEMP>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZYS_TEMP>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ01_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ02_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ03_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ04_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ05_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ06_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ07_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ08_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ09_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ10_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ11_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ12_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ13_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ14_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ15_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ16_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ17_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ18_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ19_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ20_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ21_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ22_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ23_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ24_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ25_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ26_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ27_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ28_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ29_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ30_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ31_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ32_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ33_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ34_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ35_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ36_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ37_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ38_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ39_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ40_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ41_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ42_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ43_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ44_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ45_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ46_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ47_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ48_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ49_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ50_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ51_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ52_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ53_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ54_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ55_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ56_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ57_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ58_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ59_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ60_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ61_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ62_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ63_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ64_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ65_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ66_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.ZZ67_)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.MC65)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.MC66)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.MC67)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYB_ZZ>()
                .Property(e => e.JCYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.DWMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.BMMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.FZMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.FZBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.GWGZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.XB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.TJLB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SJH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.HYZK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.JHGL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.DHZL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.YJS_CC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.YJS_JQ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.YJS_ZQ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.YJS_TJNL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYS_XYZV)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYS_LC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYS_ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYS_SC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYS_YCT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.JWS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZHXGR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.RYLB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.TJJSR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.JSFS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.MZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYKH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.BM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZDDW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SFQY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.HYSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SYSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.BYYYY)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.ZNJKQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.SHSBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.JZS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.WHCD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.CSD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.POJCFSXQK)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.YZBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYBYDDJB>()
                .Property(e => e.CJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.BGBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.BGMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.YRDW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.WHYS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.TJLB)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.TJRS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.TJXM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.TJJL)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.CLYJ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.YB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.PHONE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.TJDD)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.DWDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.LXR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYJKJCZJBG_BZB>()
                .Property(e => e.BGH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_BM>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_BM>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_BM>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_BM>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CJ>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CJ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CJ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CJ>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CSHY>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CSHY>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CSHY>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_CSHY>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FHCS>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FHCS>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FHCS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FHCS>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSGZ>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSGZ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSGZ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSGZ>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSYZL>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSYZL>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSYZL>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_FSYZL>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_GZ>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_GZ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_GZ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_GZ>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_JBDW>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_JBDW>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_JBDW>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_JBDW>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.YWMS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.SSJM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_YHYS>()
                .Property(e => e.XH)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TJ_ZYS_ZDBZ>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDBZ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDBZ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDBZ>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDDW>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDDW>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDDW>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYS_ZDDW>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.A)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.B)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.C)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.D)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.E)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.F)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.G)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.H)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.I)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.TBR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_RYXX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_TZ>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_TZ>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_TZ>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_TZ>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.TZLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.TZLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.SFTS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.DISP_ORDER)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WT>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WTMX>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WTMX>()
                .Property(e => e.TZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WTMX>()
                .Property(e => e.WTBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZYTJ_WTMX>()
                .Property(e => e.DABH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.KH)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.GYH)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.KLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.HYID)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.CBFD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYK>()
                .Property(e => e.KZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.HYID)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.LXDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.LXDZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<TJLS_HYXX>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<TTXT_YJMB>()
                .Property(e => e.STMP)
                .IsUnicode(false);

            modelBuilder.Entity<TTXT_YJMB>()
                .Property(e => e.STMP_PORT)
                .IsUnicode(false);

            modelBuilder.Entity<TTXT_YJMB>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TTXT_YJMB>()
                .Property(e => e.EMAILADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<tzfl_zdcf>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tzfl_zdcf>()
                .Property(e => e.zdmc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tzfl_zdcf>()
                .Property(e => e.zdnrcf)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_PBL>()
                .Property(e => e.PBL_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.DATAWINDOW_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.DATAWINDOW_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.REPORT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.IS_DEFAULT_DATAWINDOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.IS_SYS_DATAWINDOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.SYNTAX)
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.SYNTAX_BAK)
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.IS_NEW_DATAWINDOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.DATAWINDOW_OBJECT)
                .IsUnicode(false);

            modelBuilder.Entity<USER_DEFINED_REPORT>()
                .Property(e => e.IS_USED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USER_UPDATE_DATAWINDOW_DATETIME>()
                .Property(e => e.VOLUME_INFORMATION_ID)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAB>()
                .Property(e => e.DANR)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAB>()
                .Property(e => e.FS)
                .HasPrecision(6, 1);

            modelBuilder.Entity<WJ_DAB>()
                .Property(e => e.HCDA)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAB>()
                .Property(e => e.SFGL)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAB>()
                .Property(e => e.GLJCXM)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAGLXM>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAGLXM>()
                .Property(e => e.XMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DAGLXM>()
                .Property(e => e.XMMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_HD>()
                .Property(e => e.JSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_HD>()
                .Property(e => e.DRDCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_HD>()
                .Property(e => e.HS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_HD>()
                .Property(e => e.LY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_HD>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_LOADXML>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_LOADXML>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_LOADXML>()
                .Property(e => e.XMLWJ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.ZS)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.JY)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.GDYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.FZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SUMOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.DEPART)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.ADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SJCXXH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.FZTZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.FZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.TJJL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.RSDAH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SFBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.TJJSR)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SFZQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.JSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SV_CALLBACK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SV_SMS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SV_EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.SV_WEB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.BM)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.GZ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.YHYS)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.WHCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.TJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.FZDW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJDJB>()
                .Property(e => e.BZR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.XJ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.XMDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.DZBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.ISOVER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.CHARGED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JSR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.CZY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.SFJZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.DYYJSB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JYYS)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.SSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.TCBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.ZJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.XMBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.ZEBL)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.SSDJ)
                .HasPrecision(8, 2);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JCSJ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.TPZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.TPLJ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JCQKFZSM)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.SFZQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLB>()
                .Property(e => e.JSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.TJZHXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.TJLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.JCYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.CKXX)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.TS)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.CKZ)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.SFZQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TJJLMXB>()
                .Property(e => e.JSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_TMGLKS>()
                .Property(e => e.KSMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_WTB>()
                .Property(e => e.WTNR)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_WTB>()
                .Property(e => e.GLXGKS)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_WTB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_XGRZ>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_XGRZ>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_XGRZ>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_XGRZ>()
                .Property(e => e.LY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WJ_XGRZ>()
                .Property(e => e.DCBH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_XGRZ>()
                .Property(e => e.DRBH)
                .IsUnicode(false);

            modelBuilder.Entity<XTGL_TJJGFD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XTGL_TJJGFD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<XTGL_TJJGFD>()
                .Property(e => e.DZ)
                .IsUnicode(false);

            modelBuilder.Entity<XTGL_TJJGFD>()
                .Property(e => e.LXR)
                .IsUnicode(false);

            modelBuilder.Entity<XTGL_TJJGFD>()
                .Property(e => e.DH)
                .IsUnicode(false);

            modelBuilder.Entity<XTSJ>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_GRYDDJB>()
                .Property(e => e.YYBH)
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_GRYDDJB>()
                .Property(e => e.SFZH)
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_GRYDDJB>()
                .Property(e => e.SJHM)
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_GRYDDJB>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_GRYDDJB>()
                .Property(e => e.TCID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_GRYDDJB>()
                .Property(e => e.TCMC)
                .IsUnicode(false);

            modelBuilder.Entity<YYXT_XTCS>()
                .Property(e => e.ZDM)
                .IsFixedLength();

            modelBuilder.Entity<YYXT_XTCS>()
                .Property(e => e.MC)
                .IsFixedLength();

            modelBuilder.Entity<YYXT_XTCS>()
                .Property(e => e.SFXS)
                .IsUnicode(false);

            modelBuilder.Entity<ZC>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ZC>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<ZC>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<ZC>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ZKQXB>()
                .Property(e => e.GKHM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ZKQXB>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ZW>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ZW>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<ZW>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<ZW>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<always_function>()
                .Property(e => e.func_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<always_function>()
                .Property(e => e.func_name)
                .IsUnicode(false);

            modelBuilder.Entity<always_function>()
                .Property(e => e.func_desc)
                .IsUnicode(false);

            modelBuilder.Entity<data_hospital_fun_pbd>()
                .Property(e => e.Open_win_name)
                .IsUnicode(false);

            modelBuilder.Entity<data_hospital_fun_pbd>()
                .Property(e => e.file_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<data_hospital_fun_pbd>()
                .Property(e => e.hospital_id)
                .IsUnicode(false);

            modelBuilder.Entity<data_hospital_fun_pbd>()
                .Property(e => e.file_name)
                .IsUnicode(false);

            modelBuilder.Entity<data_hospital_fun_pbd>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<data_hospital_fun_pbd>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.emp_di)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.emp_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JDMC>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JDMC>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GGWS_JDMC>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<hospital>()
                .Property(e => e.hospital_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<hospital>()
                .Property(e => e.hospital_name)
                .IsUnicode(false);

            modelBuilder.Entity<LUOXIANG>()
                .Property(e => e.VALUE_1)
                .IsUnicode(false);

            modelBuilder.Entity<LUOXIANG>()
                .Property(e => e.VALUE_2)
                .IsUnicode(false);

            modelBuilder.Entity<LUOXIANG>()
                .Property(e => e.VALUE_3)
                .IsUnicode(false);

            modelBuilder.Entity<LUOXIANG>()
                .Property(e => e.VALUE_5)
                .IsUnicode(false);

            modelBuilder.Entity<menu_mbh>()
                .Property(e => e.station_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<menu_mbh>()
                .Property(e => e.mc)
                .IsUnicode(false);

            modelBuilder.Entity<menu_mbh>()
                .Property(e => e.zhxgr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_func_id)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_func_desc)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_fun)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_menu_id)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_order_no)
                .HasPrecision(4, 0);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_object_name)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_picture)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_parm)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_picture_for_jz)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_version)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_tips)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_initdat)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_onlydisplay)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_icon)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_transparentcolor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_textcolor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_textfont)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_event)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.mf_m_d)
                .IsUnicode(false);

            modelBuilder.Entity<menu_module>()
                .Property(e => e.station_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msgid)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msgtitle)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msgtext)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msgicon)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msgbutton)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msgprint)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.msguserinput)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.SVNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.DBNAME)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.DBUSER)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.DBPASS)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.CPMC)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.QYBZ)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_CONFIG>()
                .Property(e => e.CPLXMC)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.JKBH)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.JKMC)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.FBCPBH)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.FBCPMC)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.JKCPBH)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.JKCPMC)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.QYBZ)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.JKLXMC)
                .IsUnicode(false);

            modelBuilder.Entity<MIES_JKXXB>()
                .Property(e => e.FWIP)
                .IsUnicode(false);

            modelBuilder.Entity<mushortcut>()
                .Property(e => e.hospital_id)
                .IsUnicode(false);

            modelBuilder.Entity<mushortcut>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<mushortcut>()
                .Property(e => e.mf_func_id)
                .IsUnicode(false);

            modelBuilder.Entity<mushortcut>()
                .Property(e => e.mf_m_d)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatedt>()
                .Property(e => e.pbe_name)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatedt>()
                .Property(e => e.pbe_edit)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatedt>()
                .Property(e => e.pbe_work)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pbcatfmt>()
                .Property(e => e.pbf_name)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatfmt>()
                .Property(e => e.pbf_frmt)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatvld>()
                .Property(e => e.pbv_name)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatvld>()
                .Property(e => e.pbv_vald)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatvld>()
                .Property(e => e.pbv_msg)
                .IsUnicode(false);

            modelBuilder.Entity<QTXTZDB>()
                .Property(e => e.XTMC)
                .IsUnicode(false);

            modelBuilder.Entity<QTXTZDB>()
                .Property(e => e.LX)
                .IsUnicode(false);

            modelBuilder.Entity<QTXTZDB>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<QTXTZDB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<QTXTZDB>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<rs_lastcommit>()
                .Property(e => e.origin_qid)
                .IsFixedLength();

            modelBuilder.Entity<rs_lastcommit>()
                .Property(e => e.secondary_qid)
                .IsFixedLength();

            modelBuilder.Entity<security_apps>()
                .Property(e => e.application)
                .IsUnicode(false);

            modelBuilder.Entity<security_apps>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<security_groupings>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<security_groupings>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<security_info>()
                .Property(e => e.application)
                .IsUnicode(false);

            modelBuilder.Entity<security_info>()
                .Property(e => e.window)
                .IsUnicode(false);

            modelBuilder.Entity<security_info>()
                .Property(e => e.control)
                .IsUnicode(false);

            modelBuilder.Entity<security_info>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<security_info>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<security_template>()
                .Property(e => e.application)
                .IsUnicode(false);

            modelBuilder.Entity<security_template>()
                .Property(e => e.window)
                .IsUnicode(false);

            modelBuilder.Entity<security_template>()
                .Property(e => e.control)
                .IsUnicode(false);

            modelBuilder.Entity<security_template>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<security_template>()
                .Property(e => e.object_type)
                .IsUnicode(false);

            modelBuilder.Entity<security_users>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<security_users>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<sys_code>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_code>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<sys_code>()
                .Property(e => e.display)
                .IsUnicode(false);

            modelBuilder.Entity<sys_code>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_seq>()
                .Property(e => e.sq_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_seq>()
                .Property(e => e.sq_display)
                .IsUnicode(false);

            modelBuilder.Entity<sys_seq>()
                .Property(e => e.sq_currno)
                .IsUnicode(false);

            modelBuilder.Entity<sys_seq>()
                .Property(e => e.sq_remark)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.u_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.u_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.u_zjm)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.u_pwd)
                .IsFixedLength();

            modelBuilder.Entity<sys_user>()
                .Property(e => e.user_level)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DRDCLOG>()
                .Property(e => e.XTMC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DRDCLOG>()
                .Property(e => e.SFCG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DRDCLOG>()
                .Property(e => e.LX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT_LOG>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT_LOG>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT_LOG>()
                .Property(e => e.TJXM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT_LOG>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_DWFZ_DT_LOG>()
                .Property(e => e.FLAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCTZZYSX>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCTZZYSX>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCTZZYSX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_FCTZZYSX>()
                .Property(e => e.CJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_HD>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_HD>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_HD>()
                .Property(e => e.SYFX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_HD>()
                .Property(e => e.JGLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_HD>()
                .Property(e => e.GS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_HSB_ZDY_HD>()
                .Property(e => e.MS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKPG_DZB>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JKPG_DZB>()
                .Property(e => e.SM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.DJLSH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.ZHXMBH_LIS)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.XMBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.JG)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.CKFW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.SHR)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.PROMPT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGBUPDATE>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_JYJGDR_CS>()
                .Property(e => e.SFFG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.YLKH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.BRJSLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SFCK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.LY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.KDKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SFBZBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.DW)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.DJ)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SJFY)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.SKYBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.MZYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.TJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.ZXKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.ZRJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.LRFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.XMJCBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.XMJCR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SFD_LOG>()
                .Property(e => e.XMHDR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.SJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.YLKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.KB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.BRSFLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JSZL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.EKJS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.ZJJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.ZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.DYBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.YSSJH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.ZT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.SKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.SKYBM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.SFCRJID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.RJID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.RJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.YS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.YJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JZBZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JZDHM)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JZDH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.ZRJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.TCZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.GRZHZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.YLJZZFJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.TCJZJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.HPBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.SFTF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.KJLH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.DJJE)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.ZKBH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.TCZK)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.JZZK)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.ZEZK)
                .HasPrecision(8, 2);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.BCSS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.SSCE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.LJSS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.YSJE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SJH>()
                .Property(e => e.CZCE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.ZCODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.REPORTER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.RDAY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.rtime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_SZRMYY_JYK>()
                .Property(e => e.ASK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.SYNTAX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.WIDTH)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.HEIGHT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.CROSSSPACE)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TJ_TABLESYNTAX>()
                .Property(e => e.DOWNSPACE)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TJ_TJJL>()
                .Property(e => e.BH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJL>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJL>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJL>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJJLB_XGRZ>()
                .Property(e => e.DJLSH)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.LXBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.MC)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.XSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.JCJYLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.KSXX)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.BZ)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.ZHXGR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.DISP_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.TSFH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TJLXB>()
                .Property(e => e.HZKS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TMBQSZ>()
                .Property(e => e.FACENAME)
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TMBQSZ>()
                .Property(e => e.HEIGHT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TMBQSZ>()
                .Property(e => e.WEIGHT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_TMBQSZ>()
                .Property(e => e.ITALIC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB>()
                .Property(e => e.DWBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB>()
                .Property(e => e.SSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB_LOG>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB_LOG>()
                .Property(e => e.DWBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB_LOG>()
                .Property(e => e.TJXMBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB_LOG>()
                .Property(e => e.XMLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB_LOG>()
                .Property(e => e.SSLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_YDTJXMB_LOG>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJLB_LOG>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJLB_LOG>()
                .Property(e => e.ZUJKSBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TJ_ZUJJLB_LOG>()
                .Property(e => e.ZUJYS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<two_purview>()
                .Property(e => e.fun_code)
                .IsUnicode(false);

            modelBuilder.Entity<two_purview>()
                .Property(e => e.station_code)
                .IsUnicode(false);

            modelBuilder.Entity<two_purview>()
                .Property(e => e.ref_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<two_purview>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<two_purview>()
                .Property(e => e.fun_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<two_purview>()
                .Property(e => e.func_desc)
                .IsUnicode(false);

            modelBuilder.Entity<user_group>()
                .Property(e => e.ug_login_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_group>()
                .Property(e => e.ug_group_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_group>()
                .Property(e => e.ug_remark)
                .IsUnicode(false);

            modelBuilder.Entity<user_group>()
                .Property(e => e.user_password)
                .IsFixedLength();

            modelBuilder.Entity<user_master>()
                .Property(e => e.um_login_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_master>()
                .Property(e => e.um_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_master>()
                .Property(e => e.um_password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_master>()
                .Property(e => e.um_user_level)
                .HasPrecision(16, 0);

            modelBuilder.Entity<user_master>()
                .Property(e => e.um_group_or_user)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.uf_login_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.uf_func_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.uf_add)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.uf_delete)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.uf_edit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.uf_print)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.last_update_by)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.mf_version)
                .IsUnicode(false);

            modelBuilder.Entity<user_purview>()
                .Property(e => e.station_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_role>()
                .Property(e => e.um_role_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_role>()
                .Property(e => e.um_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_role>()
                .Property(e => e.um_user_level)
                .HasPrecision(16, 0);

            modelBuilder.Entity<user_station>()
                .Property(e => e.station_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_station>()
                .Property(e => e.hospital_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_station>()
                .Property(e => e.station_name)
                .IsUnicode(false);

            modelBuilder.Entity<user_station>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<user_station>()
                .Property(e => e.module_liblist)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_DT>()
                .Property(e => e.BH)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_DT>()
                .Property(e => e.JSJMC)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_DT>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_DT>()
                .Property(e => e.XM2)
                .IsUnicode(false);

            modelBuilder.Entity<WJ_DRDC_DT>()
                .Property(e => e.TJBH)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.DWBH)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.YYBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.RYBH)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.XM)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.XB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.ZC)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.ZW)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.HYZK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.TJLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.RYLB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.DJRY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.JSFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.FZFS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.DJBZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.FZBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.SFZH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.TJBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.BMBH)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.RSDAH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.MOBILE)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.SFVIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<结果>()
                .Property(e => e.SFWEB)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

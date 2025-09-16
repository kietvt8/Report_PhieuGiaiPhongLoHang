using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Threading;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ServerShared;

namespace Report_PhieuGiaiPhongLoHang;

public class rpt_PhieuGiaiPhongLoHang : XtraReport, IReport
{
	private DataSet dset = new DataSet();

	private IContainer components = null;

	private DetailBand Detail;

	private TopMarginBand TopMargin;

	private BottomMarginBand BottomMargin;

	private XRTable xrTable2;

	private XRTableRow xrTableRow2;

	private XRTableCell xrTableCell4;

	private XRTableCell xrTableCell16;

	private XRTableCell xrTableCell17;

	private XRTableCell xrTableCell18;

	private XRTableCell xrTableCell19;

	private XRTableCell xrTableCell20;

	private XRTableCell xrTableCell21;

	private XRTableCell xrTableCell22;

	private XRTableCell xrTableCell23;

	private XRTableCell xrTableCell24;

	private XRTableCell xrTableCell25;

	private XRTableCell xrTableCell26;

	private XRTableCell xrTableCell27;

	private XRTableCell xrTableCell28;

	private ReportHeaderBand ReportHeader;

	private XRLabel xrLabel25;

	private XRLabel xrLabel24;

	private XRLabel xrLabel23;

	private XRLabel xrLabel22;

	private XRLabel xrLabel21;

	private XRLabel xrLabel20;

	private XRLabel xrLabel19;

	private XRLabel xrLabel18;

	private XRLabel xrLabel17;

	private XRLabel xrLabel16;

	private XRLabel xrLabel15;

	private XRPictureBox xrPictureBox1;

	private XRTable xrTable1;

	private XRTableRow xrTableRow1;

	private XRTableCell xrTableCell14;

	private XRTableCell xrTableCell8;

	private XRTableCell xrTableCell15;

	private XRTableCell xrTableCell6;

	private XRTableCell xrTableCell9;

	private XRTableCell xrTableCell1;

	private XRTableCell xrTableCell10;

	private XRTableCell xrTableCell7;

	private XRTableCell xrTableCell11;

	private XRTableCell xrTableCell2;

	private XRTableCell xrTableCell12;

	private XRTableCell xrTableCell3;

	private XRTableCell xrTableCell13;

	private XRTableCell xrTableCell5;

	private XRLabel xrLabel14;

	private XRLabel xrLabel13;

	private XRLabel xrLabel12;

	private XRLabel xrLabel11;

	private XRLabel xrLabel10;

	private XRLabel xrLabel9;

	private XRLabel xrLabel8;

	private XRLabel xrLabel7;

	private XRLabel xrLabel6;

	private XRLabel xrLabel5;

	private XRLabel xrLabel4;

	private XRLabel xrLabel3;

	private XRLabel xrLabel2;

	private XRLabel xrLabel1;

	private ReportFooterBand ReportFooter;

	private XRLabel xrLabel34;

	private XRLabel xrLabel33;

	private XRLabel xrLabel30;

	private XRLabel xrLabel32;

	private XRLabel xrLabel31;

	private XRLabel xrLabel29;

	private XRLabel xrLabel28;

	private XRLabel xrLabel27;

	private XRTable xrTable3;

	private XRTableRow xrTableRow3;

	private XRTableCell xrTableCell33;

	private XRTableCell xrTableCell29;

	private XRTableCell xrTableCell34;

	private XRTableCell xrTableCell30;

	private XRTableCell xrTableCell32;

	private XRTableCell xrTableCell31;

	private XRLabel xrLabel26;

	private rep_PhieuXuatKhoKiemBaoLo_PDF rep_PhieuXuatKhoKiemBaoLo_PDF1;

	private XRLabel xrLabel36;

	private XRLabel xrLabel35;

	public rpt_PhieuGiaiPhongLoHang()
	{
		InitializeComponent();
		BeforePrint += rpt_PhieuXuatKhoKiemHanDung_BeforePrint;
	}

	public ReportResult Generate(DataSet ds, string type)
	{
		rep_PhieuXuatKhoKiemBaoLo_PDF rep_PhieuXuatKhoKiemBaoLo_PDF2 = new rep_PhieuXuatKhoKiemBaoLo_PDF();
		DataSetExtensions.ApplyDataSet((DataSet)rep_PhieuXuatKhoKiemBaoLo_PDF2, ds);
		dset = rep_PhieuXuatKhoKiemBaoLo_PDF2;
		((XtraReportBase)this).DataSource = rep_PhieuXuatKhoKiemBaoLo_PDF2;
		MemoryStream memoryStream = new MemoryStream();
		if (type.ToUpper() == "PDF")
		{
			((XtraReport)this).ExportToPdf((Stream)memoryStream);
		}
		if (type.ToUpper() == "XLS")
		{
			((XtraReport)this).ExportToXls((Stream)memoryStream);
		}
		if (type.ToUpper() == "HTML")
		{
			((XtraReport)this).ExportToHtml((Stream)memoryStream);
		}
		return new ReportResult(type, memoryStream.ToArray());
	}

	private void rpt_PhieuXuatKhoKiemHanDung_BeforePrint(object sender, PrintEventArgs e)
	{
		Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
		string s = DataExtensions.FirstRow(dset.Tables[0])["Logo"].ToString();
		byte[] buffer = Convert.FromBase64String(s);
		Stream stream = new MemoryStream(buffer);
		Image image = Image.FromStream(stream);
		xrPictureBox1.Image = image;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
			DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.rep_PhieuXuatKhoKiemBaoLo_PDF1 = new Report_PhieuGiaiPhongLoHang.rep_PhieuXuatKhoKiemBaoLo_PDF();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rep_PhieuXuatKhoKiemBaoLo_PDF1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
			this.Detail.HeightF = 28.12498F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			// 
			// xrTable2
			// 
			this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(1139F, 28.12498F);
			this.xrTable2.StylePriority.UseBorders = false;
			this.xrTable2.StylePriority.UseFont = false;
			this.xrTable2.StylePriority.UseTextAlignment = false;
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 1D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[STT]")});
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.StylePriority.UseTextAlignment = false;
			this.xrTableCell4.Text = "xrTableCell4";
			this.xrTableCell4.Weight = 0.16430801112725124D;
			// 
			// xrTableCell16
			// 
			this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[KhoXuat]")});
			this.xrTableCell16.Name = "xrTableCell16";
			this.xrTableCell16.Text = "xrTableCell16";
			this.xrTableCell16.Weight = 0.53537784741100714D;
			// 
			// xrTableCell17
			// 
			this.xrTableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HospitalCode]")});
			this.xrTableCell17.Name = "xrTableCell17";
			this.xrTableCell17.Text = "xrTableCell17";
			this.xrTableCell17.Weight = 0.40788722881208944D;
			// 
			// xrTableCell18
			// 
			this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HospitalName]")});
			this.xrTableCell18.Name = "xrTableCell18";
			this.xrTableCell18.Text = "xrTableCell18";
			this.xrTableCell18.Weight = 0.36609200006713039D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitName]")});
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell19.StylePriority.UsePadding = false;
			this.xrTableCell19.StylePriority.UseTextAlignment = false;
			this.xrTableCell19.Text = "xrTableCell19";
			this.xrTableCell19.Weight = 0.19771856549444808D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ApprovedQty]")});
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell20.StylePriority.UsePadding = false;
			this.xrTableCell20.StylePriority.UseTextAlignment = false;
			this.xrTableCell20.Text = "xrTableCell20";
			this.xrTableCell20.TextFormatString = "{0:n00}";
			this.xrTableCell20.Weight = 0.19903050234002606D;
			// 
			// xrTableCell21
			// 
			this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Batch]")});
			this.xrTableCell21.Name = "xrTableCell21";
			this.xrTableCell21.StylePriority.UseTextAlignment = false;
			this.xrTableCell21.Text = "xrTableCell21";
			this.xrTableCell21.Weight = 0.18383158409395089D;
			// 
			// xrTableCell22
			// 
			this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ExpDate]")});
			this.xrTableCell22.Name = "xrTableCell22";
			this.xrTableCell22.Text = "xrTableCell22";
			this.xrTableCell22.TextFormatString = "{0:dd/MM/yyyy}";
			this.xrTableCell22.Weight = 0.308984183842308D;
			// 
			// xrTableCell23
			// 
			this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")});
			this.xrTableCell23.Name = "xrTableCell23";
			this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell23.StylePriority.UsePadding = false;
			this.xrTableCell23.StylePriority.UseTextAlignment = false;
			this.xrTableCell23.Text = "xrTableCell23";
			this.xrTableCell23.TextFormatString = "{0:n00}";
			this.xrTableCell23.Weight = 0.24976578713775158D;
			// 
			// xrTableCell24
			// 
			this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[VAT]")});
			this.xrTableCell24.Name = "xrTableCell24";
			this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell24.StylePriority.UsePadding = false;
			this.xrTableCell24.StylePriority.UseTextAlignment = false;
			this.xrTableCell24.Text = "xrTableCell24";
			this.xrTableCell24.TextFormatString = "{0:n00}";
			this.xrTableCell24.Weight = 0.1789065046234154D;
			// 
			// xrTableCell25
			// 
			this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalMoney]")});
			this.xrTableCell25.Name = "xrTableCell25";
			this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell25.StylePriority.UsePadding = false;
			this.xrTableCell25.StylePriority.UseTextAlignment = false;
			this.xrTableCell25.Text = "xrTableCell25";
			this.xrTableCell25.TextFormatString = "{0:n00}";
			this.xrTableCell25.Weight = 0.41341372964285972D;
			// 
			// xrTableCell26
			// 
			this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThanhTienTruocThue]")});
			this.xrTableCell26.Name = "xrTableCell26";
			this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell26.StylePriority.UsePadding = false;
			this.xrTableCell26.StylePriority.UseTextAlignment = false;
			this.xrTableCell26.Text = "xrTableCell26";
			this.xrTableCell26.TextFormatString = "{0:n00}";
			this.xrTableCell26.Weight = 0.408706189952023D;
			// 
			// xrTableCell27
			// 
			this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThueVAT]")});
			this.xrTableCell27.Name = "xrTableCell27";
			this.xrTableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell27.StylePriority.UsePadding = false;
			this.xrTableCell27.StylePriority.UseTextAlignment = false;
			this.xrTableCell27.Text = "xrTableCell27";
			this.xrTableCell27.TextFormatString = "{0:n00}";
			this.xrTableCell27.Weight = 0.39444088970958191D;
			// 
			// xrTableCell28
			// 
			this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ViTriXuat]")});
			this.xrTableCell28.Name = "xrTableCell28";
			this.xrTableCell28.Text = "xrTableCell28";
			this.xrTableCell28.Weight = 0.28965073828801868D;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 29F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			// 
			// BottomMargin
			// 
			this.BottomMargin.HeightF = 73F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel36,
            this.xrLabel35,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrPictureBox1,
            this.xrTable1,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
			this.ReportHeader.HeightF = 406.25F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel36
			// 
			this.xrLabel36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.SoLDD]")});
			this.xrLabel36.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(849.409F, 219.75F);
			this.xrLabel36.Name = "xrLabel36";
			this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel36.SizeF = new System.Drawing.SizeF(222.6453F, 23F);
			this.xrLabel36.StylePriority.UseFont = false;
			this.xrLabel36.StylePriority.UseTextAlignment = false;
			this.xrLabel36.Text = "xrLabel36";
			// 
			// xrLabel35
			// 
			this.xrLabel35.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(650.3679F, 219.75F);
			this.xrLabel35.Name = "xrLabel35";
			this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel35.SizeF = new System.Drawing.SizeF(199.0406F, 23F);
			this.xrLabel35.StylePriority.UseFont = false;
			this.xrLabel35.StylePriority.UseTextAlignment = false;
			this.xrLabel35.Text = "Số LĐĐ: ";
			// 
			// xrLabel25
			// 
			this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.ApprovedOutNo]")});
			this.xrLabel25.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(586.339F, 25.99999F);
			this.xrLabel25.Name = "xrLabel25";
			this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel25.SizeF = new System.Drawing.SizeF(277.0835F, 23F);
			this.xrLabel25.StylePriority.UseFont = false;
			this.xrLabel25.StylePriority.UseTextAlignment = false;
			this.xrLabel25.Text = "xrLabel25";
			// 
			// xrLabel24
			// 
			this.xrLabel24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NgayReport]")});
			this.xrLabel24.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(586.339F, 60.37502F);
			this.xrLabel24.Name = "xrLabel24";
			this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel24.SizeF = new System.Drawing.SizeF(277.0836F, 23F);
			this.xrLabel24.StylePriority.UseFont = false;
			this.xrLabel24.StylePriority.UseTextAlignment = false;
			this.xrLabel24.Text = "xrLabel24";
			// 
			// xrLabel23
			// 
			this.xrLabel23.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(984.7157F, 60.37502F);
			this.xrLabel23.Multiline = true;
			this.xrLabel23.Name = "xrLabel23";
			this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel23.SizeF = new System.Drawing.SizeF(113.0002F, 23F);
			this.xrLabel23.StylePriority.UseFont = false;
			this.xrLabel23.StylePriority.UseTextAlignment = false;
			this.xrLabel23.Text = "\r\n";
			// 
			// xrLabel22
			// 
			this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.SoHoaDon]")});
			this.xrLabel22.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(984.7158F, 26.00004F);
			this.xrLabel22.Name = "xrLabel22";
			this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel22.SizeF = new System.Drawing.SizeF(113F, 23F);
			this.xrLabel22.StylePriority.UseFont = false;
			this.xrLabel22.StylePriority.UseTextAlignment = false;
			this.xrLabel22.Text = "xrLabel22";
			// 
			// xrLabel21
			// 
			this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NhietDoNhanHang]")});
			this.xrLabel21.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(849.4089F, 290.9584F);
			this.xrLabel21.Name = "xrLabel21";
			this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel21.SizeF = new System.Drawing.SizeF(222.6454F, 23F);
			this.xrLabel21.StylePriority.UseFont = false;
			this.xrLabel21.StylePriority.UseTextAlignment = false;
			this.xrLabel21.Text = "xrLabel21";
			// 
			// xrLabel20
			// 
			this.xrLabel20.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(849.4089F, 182.2501F);
			this.xrLabel20.Name = "xrLabel20";
			this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel20.SizeF = new System.Drawing.SizeF(222.6454F, 23F);
			this.xrLabel20.StylePriority.UseFont = false;
			this.xrLabel20.StylePriority.UseTextAlignment = false;
			// 
			// xrLabel19
			// 
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NhietDoGiaoHang]")});
			this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(208.0902F, 290.9583F);
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(395.2487F, 23F);
			this.xrLabel19.StylePriority.UseFont = false;
			this.xrLabel19.StylePriority.UseTextAlignment = false;
			this.xrLabel19.Text = "xrLabel19";
			// 
			// xrLabel18
			// 
			this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.NguoiVanChuyen]")});
			this.xrLabel18.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(208.0902F, 252.0417F);
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(395.2487F, 22.99997F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "xrLabel18";
			// 
			// xrLabel17
			// 
			this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(208.0902F, 217.6667F);
			this.xrLabel17.Name = "xrLabel17";
			this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel17.SizeF = new System.Drawing.SizeF(395.2487F, 23F);
			this.xrLabel17.StylePriority.UseFont = false;
			this.xrLabel17.StylePriority.UseTextAlignment = false;
			// 
			// xrLabel16
			// 
			this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.DiaChiGiaoHang]")});
			this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(208.0902F, 182.2501F);
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(395.2487F, 23F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.StylePriority.UseTextAlignment = false;
			this.xrLabel16.Text = "xrLabel16";
			// 
			// xrLabel15
			// 
			this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.KhachHang]")});
			this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(208.0902F, 147.875F);
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(395.2487F, 22.99998F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.StylePriority.UseTextAlignment = false;
			this.xrLabel15.Text = "xrLabel15";
			// 
			// xrPictureBox1
			// 
			this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.00002F);
			this.xrPictureBox1.Name = "xrPictureBox1";
			this.xrPictureBox1.SizeF = new System.Drawing.SizeF(63.41667F, 57.375F);
			// 
			// xrTable1
			// 
			this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 329.1667F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(1139F, 77.08331F);
			this.xrTable1.StylePriority.UseBorders = false;
			this.xrTable1.StylePriority.UseFont = false;
			this.xrTable1.StylePriority.UseTextAlignment = false;
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell8,
            this.xrTableCell15,
            this.xrTableCell6,
            this.xrTableCell9,
            this.xrTableCell1,
            this.xrTableCell10,
            this.xrTableCell7,
            this.xrTableCell11,
            this.xrTableCell2,
            this.xrTableCell12,
            this.xrTableCell3,
            this.xrTableCell13,
            this.xrTableCell5});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.Text = "STT (1)";
			this.xrTableCell14.Weight = 0.11655924882319911D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.Text = "Kho xuất (2)";
			this.xrTableCell8.Weight = 0.37979387869087006D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.Text = "Mã hàng (3)";
			this.xrTableCell15.Weight = 0.28935274424407248D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.Text = "Tên thuốc - quy cách (4)";
			this.xrTableCell6.Weight = 0.25970370718682589D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.Text = "Đơn vị tính (5)";
			this.xrTableCell9.Weight = 0.14026032766024107D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.Text = "Số lượng (6) ";
			this.xrTableCell1.Weight = 0.14119081868311917D;
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.Text = "Số lô (7)";
			this.xrTableCell10.Weight = 0.13040921228036942D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.Text = "Hạn dùng (8)";
			this.xrTableCell7.Weight = 0.2191919108657035D;
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.Text = "Đơn giá chưa VAT (9)";
			this.xrTableCell11.Weight = 0.1771819040059294D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.Text = "VAT (10)";
			this.xrTableCell2.Weight = 0.12691572682832283D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.Text = "Tổng cộng (11=6*9*10)";
			this.xrTableCell12.Weight = 0.29327328755543108D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.Text = "Tổng trước thuế (12=6*9)";
			this.xrTableCell3.Weight = 0.2899336244695826D;
			// 
			// xrTableCell13
			// 
			this.xrTableCell13.Name = "xrTableCell13";
			this.xrTableCell13.Text = "Tổng thuế (13=11-12)";
			this.xrTableCell13.Weight = 0.27981359906820769D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.Text = "Vị trí xuất";
			this.xrTableCell5.Weight = 0.20547684749933387D;
			// 
			// xrLabel14
			// 
			this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(650.3679F, 290.9584F);
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(199.0409F, 23F);
			this.xrLabel14.StylePriority.UseFont = false;
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "Nhiệt độ khi giao hàng (C):";
			// 
			// xrLabel13
			// 
			this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(650.3679F, 182.2501F);
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(199.0409F, 22.99998F);
			this.xrLabel13.StylePriority.UseFont = false;
			this.xrLabel13.StylePriority.UseTextAlignment = false;
			this.xrLabel13.Text = "Điện thoại liên lạc:";
			// 
			// xrLabel12
			// 
			this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(876.306F, 60.37502F);
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(108.4097F, 23F);
			this.xrLabel12.StylePriority.UseFont = false;
			this.xrLabel12.StylePriority.UseTextAlignment = false;
			this.xrLabel12.Text = "Ngày hóa đơn:";
			// 
			// xrLabel11
			// 
			this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 254.125F);
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(203.5764F, 23F);
			this.xrLabel11.StylePriority.UseFont = false;
			this.xrLabel11.StylePriority.UseTextAlignment = false;
			this.xrLabel11.Text = "4. Nhân viên giao hàng:";
			// 
			// xrLabel10
			// 
			this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 219.75F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(203.5764F, 22.99998F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.StylePriority.UseTextAlignment = false;
			this.xrLabel10.Text = "3. Thời gian giao hàng:";
			// 
			// xrLabel9
			// 
			this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 149.9584F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(203.5764F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "1. Tên khách hàng:";
			// 
			// xrLabel8
			// 
			this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 184.3334F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(203.5764F, 23F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "2. Địa chỉ giao hàng:";
			// 
			// xrLabel7
			// 
			this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 112.4999F);
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(1139F, 23F);
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "PHIẾU GIẢI PHÓNG LÔ HÀNG";
			// 
			// xrLabel6
			// 
			this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(876.3059F, 26.00004F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(108.4099F, 23F);
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "Số hóa đơn:";
			// 
			// xrLabel5
			// 
			this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 290.9583F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(208.0902F, 23.00006F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "5. Nhiệt độ khi khởi hành (C):";
			// 
			// xrLabel4
			// 
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.ADDRESS]")});
			this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(65.31258F, 60.37499F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(385.5555F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "xrLabel4";
			// 
			// xrLabel3
			// 
			this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Table1.FacName]")});
			this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(65.31258F, 26.00001F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(385.5555F, 23F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "xrLabel3";
			// 
			// xrLabel2
			// 
			this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(478.6596F, 60.37499F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(107.2149F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "Ngày xuất:";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(478.6596F, 25.99999F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(107.6793F, 23F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.Text = "Số phiếu xuất:";
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel34,
            this.xrLabel33,
            this.xrLabel30,
            this.xrLabel32,
            this.xrLabel31,
            this.xrLabel29,
            this.xrLabel28,
            this.xrLabel27,
            this.xrTable3,
            this.xrLabel26});
			this.ReportFooter.HeightF = 217.8819F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// xrLabel34
			// 
			this.xrLabel34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(848.1656F, 95.04865F);
			this.xrLabel34.Name = "xrLabel34";
			this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel34.SizeF = new System.Drawing.SizeF(171.9791F, 23F);
			this.xrLabel34.StylePriority.UseFont = false;
			this.xrLabel34.Text = "(Ký ghi rõ họ và tên)";
			// 
			// xrLabel33
			// 
			this.xrLabel33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(501.6377F, 95.04865F);
			this.xrLabel33.Name = "xrLabel33";
			this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel33.SizeF = new System.Drawing.SizeF(171.9791F, 23F);
			this.xrLabel33.StylePriority.UseFont = false;
			this.xrLabel33.Text = "(Ký ghi rõ họ và tên)";
			// 
			// xrLabel30
			// 
			this.xrLabel30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
			this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(108.7152F, 95.04858F);
			this.xrLabel30.Name = "xrLabel30";
			this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel30.SizeF = new System.Drawing.SizeF(171.9096F, 23F);
			this.xrLabel30.StylePriority.UseFont = false;
			this.xrLabel30.Text = "(Ký ghi rõ họ và tên)";
			// 
			// xrLabel32
			// 
			this.xrLabel32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(856.0406F, 72.04863F);
			this.xrLabel32.Name = "xrLabel32";
			this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel32.SizeF = new System.Drawing.SizeF(149.3472F, 23.00001F);
			this.xrLabel32.StylePriority.UseFont = false;
			this.xrLabel32.StylePriority.UseTextAlignment = false;
			this.xrLabel32.Text = "THỦ KHO";
			// 
			// xrLabel31
			// 
			this.xrLabel31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(505.0757F, 72.04863F);
			this.xrLabel31.Multiline = true;
			this.xrLabel31.Name = "xrLabel31";
			this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel31.SizeF = new System.Drawing.SizeF(149.6872F, 23.00001F);
			this.xrLabel31.StylePriority.UseFont = false;
			this.xrLabel31.StylePriority.UseTextAlignment = false;
			this.xrLabel31.Text = "KẾ TOÁN \r\n";
			// 
			// xrLabel29
			// 
			this.xrLabel29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(93.81944F, 72.04863F);
			this.xrLabel29.Name = "xrLabel29";
			this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel29.SizeF = new System.Drawing.SizeF(199.6874F, 23.00001F);
			this.xrLabel29.StylePriority.UseFont = false;
			this.xrLabel29.StylePriority.UseTextAlignment = false;
			this.xrLabel29.Text = "NGƯỜI NHẬN HÀNG";
			// 
			// xrLabel28
			// 
			this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThanhTienBangChu]")});
			this.xrLabel28.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(100.2916F, 29.51387F);
			this.xrLabel28.Name = "xrLabel28";
			this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel28.SizeF = new System.Drawing.SizeF(525.9644F, 23F);
			this.xrLabel28.StylePriority.UseFont = false;
			this.xrLabel28.StylePriority.UseTextAlignment = false;
			this.xrLabel28.Text = "xrLabel28";
			// 
			// xrLabel27
			// 
			this.xrLabel27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 29.51387F);
			this.xrLabel27.Name = "xrLabel27";
			this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel27.SizeF = new System.Drawing.SizeF(90.29154F, 23F);
			this.xrLabel27.StylePriority.UseFont = false;
			this.xrLabel27.StylePriority.UseTextAlignment = false;
			this.xrLabel27.Text = "Bằng chữ:";
			// 
			// xrTable3
			// 
			this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(626.2559F, 0F);
			this.xrTable3.Name = "xrTable3";
			this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
			this.xrTable3.SizeF = new System.Drawing.SizeF(512.7442F, 23F);
			this.xrTable3.StylePriority.UseBorders = false;
			this.xrTable3.StylePriority.UseFont = false;
			// 
			// xrTableRow3
			// 
			this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell33,
            this.xrTableCell29,
            this.xrTableCell34,
            this.xrTableCell30,
            this.xrTableCell32,
            this.xrTableCell31});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
			// 
			// xrTableCell33
			// 
			this.xrTableCell33.Name = "xrTableCell33";
			this.xrTableCell33.Weight = 0.47465396691112727D;
			// 
			// xrTableCell29
			// 
			this.xrTableCell29.Name = "xrTableCell29";
			this.xrTableCell29.Weight = 0.33999492174573187D;
			// 
			// xrTableCell34
			// 
			this.xrTableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalMoney]")});
			this.xrTableCell34.Name = "xrTableCell34";
			this.xrTableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell34.StylePriority.UsePadding = false;
			this.xrTableCell34.StylePriority.UseTextAlignment = false;
			xrSummary1.FormatString = "{0:n0}";
			this.xrTableCell34.Summary = xrSummary1;
			this.xrTableCell34.Text = "xrTableCell34";
			this.xrTableCell34.Weight = 0.78564930661830745D;
			// 
			// xrTableCell30
			// 
			this.xrTableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThanhTienTruocThue]")});
			this.xrTableCell30.Name = "xrTableCell30";
			this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell30.StylePriority.UsePadding = false;
			this.xrTableCell30.StylePriority.UseTextAlignment = false;
			xrSummary2.FormatString = "{0:n0}";
			this.xrTableCell30.Summary = xrSummary2;
			this.xrTableCell30.Text = "xrTableCell30";
			this.xrTableCell30.Weight = 0.77670484723597455D;
			// 
			// xrTableCell32
			// 
			this.xrTableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ThueVAT]")});
			this.xrTableCell32.Name = "xrTableCell32";
			this.xrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
			this.xrTableCell32.StylePriority.UsePadding = false;
			this.xrTableCell32.StylePriority.UseTextAlignment = false;
			xrSummary3.FormatString = "{0:n0}";
			this.xrTableCell32.Summary = xrSummary3;
			this.xrTableCell32.Text = "xrTableCell32";
			this.xrTableCell32.Weight = 0.74959403996847662D;
			// 
			// xrTableCell31
			// 
			this.xrTableCell31.Name = "xrTableCell31";
			this.xrTableCell31.Weight = 0.55045261518516764D;
			// 
			// xrLabel26
			// 
			this.xrLabel26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
			this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel26.Name = "xrLabel26";
			this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel26.SizeF = new System.Drawing.SizeF(626.2559F, 23F);
			this.xrLabel26.StylePriority.UseBorders = false;
			this.xrLabel26.StylePriority.UseFont = false;
			this.xrLabel26.StylePriority.UseTextAlignment = false;
			this.xrLabel26.Text = "Tổng";
			// 
			// rep_PhieuXuatKhoKiemBaoLo_PDF1
			// 
			this.rep_PhieuXuatKhoKiemBaoLo_PDF1.DataSetName = "rep_PhieuXuatKhoKiemBaoLo_PDF";
			this.rep_PhieuXuatKhoKiemBaoLo_PDF1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rpt_PhieuGiaiPhongLoHang
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
			this.DataMember = "Table2";
			this.DataSource = this.rep_PhieuXuatKhoKiemBaoLo_PDF1;
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(14, 16, 29, 73);
			this.PageHeight = 827;
			this.PageWidth = 1169;
			this.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.Version = "21.2";
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rep_PhieuXuatKhoKiemBaoLo_PDF1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}
}

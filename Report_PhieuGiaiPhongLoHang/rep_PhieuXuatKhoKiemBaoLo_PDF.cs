using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Report_PhieuGiaiPhongLoHang;

[Serializable]
[HelpKeyword("vs.data.DataSet")]
[XmlRoot("rep_PhieuXuatKhoKiemBaoLo_PDF")]
[ToolboxItem(true)]
[DesignerCategory("code")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
public class rep_PhieuXuatKhoKiemBaoLo_PDF : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table1RowChangeEventHandler(object sender, Table1RowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Table2RowChangeEventHandler(object sender, Table2RowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table1DataTable : TypedTableBase<Table1Row>
	{
		private DataColumn columnFacName;

		private DataColumn columnADDRESS;

		private DataColumn columnNgayReport;

		private DataColumn columnDoiTuongXuat;

		private DataColumn columnMST;

		private DataColumn columnDiaChiXuat;

		private DataColumn columnKhachHang;

		private DataColumn columnDonViVanChuyen;

		private DataColumn columnNhietDoGiaoHang;

		private DataColumn columnNhietDoNhanHang;

		private DataColumn columnKhoXuat;

		private DataColumn columnHinhThucThanhToan;

		private DataColumn columnDiaChiGiaoHang;

		private DataColumn columnHinhThucVanChuyen;

		private DataColumn columnLienHe;

		private DataColumn columnSoHoaDon;

		private DataColumn columnApprovedOutNo;

		private DataColumn columnLogo;

		private DataColumn columnNguoiVanChuyen;

		private DataColumn columnSoLDD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn FacNameColumn => columnFacName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ADDRESSColumn => columnADDRESS;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NgayReportColumn => columnNgayReport;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DoiTuongXuatColumn => columnDoiTuongXuat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn MSTColumn => columnMST;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiXuatColumn => columnDiaChiXuat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn KhachHangColumn => columnKhachHang;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DonViVanChuyenColumn => columnDonViVanChuyen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NhietDoGiaoHangColumn => columnNhietDoGiaoHang;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn NhietDoNhanHangColumn => columnNhietDoNhanHang;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn KhoXuatColumn => columnKhoXuat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HinhThucThanhToanColumn => columnHinhThucThanhToan;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DiaChiGiaoHangColumn => columnDiaChiGiaoHang;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HinhThucVanChuyenColumn => columnHinhThucVanChuyen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LienHeColumn => columnLienHe;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SoHoaDonColumn => columnSoHoaDon;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ApprovedOutNoColumn => columnApprovedOutNo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn LogoColumn => columnLogo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn NguoiVanChuyenColumn => columnNguoiVanChuyen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn SoLDDColumn => columnSoLDD;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row this[int index] => (Table1Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table1RowChangeEventHandler Table1RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1DataTable()
		{
			base.TableName = "Table1";
			BeginInit();
			InitClass();
			EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table1DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Table1DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void AddTable1Row(Table1Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row AddTable1Row(string FacName, string ADDRESS, string NgayReport, string DoiTuongXuat, string MST, string DiaChiXuat, string KhachHang, string DonViVanChuyen, string NhietDoGiaoHang, string NhietDoNhanHang, string KhoXuat, string HinhThucThanhToan, string DiaChiGiaoHang, string HinhThucVanChuyen, string LienHe, string SoHoaDon, string ApprovedOutNo, string Logo, string NguoiVanChuyen, string SoLDD)
		{
			Table1Row table1Row = (Table1Row)NewRow();
			object[] itemArray = new object[20]
			{
				FacName, ADDRESS, NgayReport, DoiTuongXuat, MST, DiaChiXuat, KhachHang, DonViVanChuyen, NhietDoGiaoHang, NhietDoNhanHang,
				KhoXuat, HinhThucThanhToan, DiaChiGiaoHang, HinhThucVanChuyen, LienHe, SoHoaDon, ApprovedOutNo, Logo, NguoiVanChuyen, SoLDD
			};
			table1Row.ItemArray = itemArray;
			base.Rows.Add(table1Row);
			return table1Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Table1DataTable table1DataTable = (Table1DataTable)base.Clone();
			table1DataTable.InitVars();
			return table1DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Table1DataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			columnFacName = base.Columns["FacName"];
			columnADDRESS = base.Columns["ADDRESS"];
			columnNgayReport = base.Columns["NgayReport"];
			columnDoiTuongXuat = base.Columns["DoiTuongXuat"];
			columnMST = base.Columns["MST"];
			columnDiaChiXuat = base.Columns["DiaChiXuat"];
			columnKhachHang = base.Columns["KhachHang"];
			columnDonViVanChuyen = base.Columns["DonViVanChuyen"];
			columnNhietDoGiaoHang = base.Columns["NhietDoGiaoHang"];
			columnNhietDoNhanHang = base.Columns["NhietDoNhanHang"];
			columnKhoXuat = base.Columns["KhoXuat"];
			columnHinhThucThanhToan = base.Columns["HinhThucThanhToan"];
			columnDiaChiGiaoHang = base.Columns["DiaChiGiaoHang"];
			columnHinhThucVanChuyen = base.Columns["HinhThucVanChuyen"];
			columnLienHe = base.Columns["LienHe"];
			columnSoHoaDon = base.Columns["SoHoaDon"];
			columnApprovedOutNo = base.Columns["ApprovedOutNo"];
			columnLogo = base.Columns["Logo"];
			columnNguoiVanChuyen = base.Columns["NguoiVanChuyen"];
			columnSoLDD = base.Columns["SoLDD"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnFacName = new DataColumn("FacName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFacName);
			columnADDRESS = new DataColumn("ADDRESS", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnADDRESS);
			columnNgayReport = new DataColumn("NgayReport", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayReport);
			columnDoiTuongXuat = new DataColumn("DoiTuongXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDoiTuongXuat);
			columnMST = new DataColumn("MST", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMST);
			columnDiaChiXuat = new DataColumn("DiaChiXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiXuat);
			columnKhachHang = new DataColumn("KhachHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnKhachHang);
			columnDonViVanChuyen = new DataColumn("DonViVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDonViVanChuyen);
			columnNhietDoGiaoHang = new DataColumn("NhietDoGiaoHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNhietDoGiaoHang);
			columnNhietDoNhanHang = new DataColumn("NhietDoNhanHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNhietDoNhanHang);
			columnKhoXuat = new DataColumn("KhoXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnKhoXuat);
			columnHinhThucThanhToan = new DataColumn("HinhThucThanhToan", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHinhThucThanhToan);
			columnDiaChiGiaoHang = new DataColumn("DiaChiGiaoHang", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDiaChiGiaoHang);
			columnHinhThucVanChuyen = new DataColumn("HinhThucVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHinhThucVanChuyen);
			columnLienHe = new DataColumn("LienHe", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLienHe);
			columnSoHoaDon = new DataColumn("SoHoaDon", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoHoaDon);
			columnApprovedOutNo = new DataColumn("ApprovedOutNo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnApprovedOutNo);
			columnLogo = new DataColumn("Logo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLogo);
			columnNguoiVanChuyen = new DataColumn("NguoiVanChuyen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiVanChuyen);
			columnSoLDD = new DataColumn("SoLDD", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoLDD);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table1Row NewTable1Row()
		{
			return (Table1Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table1Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Table1Row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table1RowChanged != null)
			{
				this.Table1RowChanged(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table1RowChanging != null)
			{
				this.Table1RowChanging(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table1RowDeleted != null)
			{
				this.Table1RowDeleted(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table1RowDeleting != null)
			{
				this.Table1RowDeleting(this, new Table1RowChangeEvent((Table1Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveTable1Row(Table1Row row)
		{
			base.Rows.Remove(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuXuatKhoKiemBaoLo_PDF rep_PhieuXuatKhoKiemBaoLo_PDF2 = new rep_PhieuXuatKhoKiemBaoLo_PDF();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuXuatKhoKiemBaoLo_PDF2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table1DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemBaoLo_PDF2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class Table2DataTable : TypedTableBase<Table2Row>
	{
		private DataColumn columnProductID;

		private DataColumn columnHospitalName;

		private DataColumn columnHospitalCode;

		private DataColumn columnUnitName;

		private DataColumn columnBatch;

		private DataColumn columnExpDate;

		private DataColumn columnAvgPrice;

		private DataColumn columnPrice;

		private DataColumn columnApprovedQty;

		private DataColumn columnTotalAvgMoney;

		private DataColumn columnTotalMoney;

		private DataColumn columnFormula;

		private DataColumn columnSTT;

		private DataColumn columnUnitID;

		private DataColumn columnImportID;

		private DataColumn columnImportDate;

		private DataColumn columnBSNgoai;

		private DataColumn columnYSNgoai;

		private DataColumn columnYSiID;

		private DataColumn columnBacSiID;

		private DataColumn columnMaDauThau;

		private DataColumn columnThueVAT;

		private DataColumn columnThanhTienTruocThue;

		private DataColumn columnThanhTienSauThue;

		private DataColumn columnKhoXuat;

		private DataColumn columnVAT;

		private DataColumn columnChietKhau;

		private DataColumn columnChietKhauBS;

		private DataColumn columnThanhTienBangChu;

		private DataColumn columnViTriXuat;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ProductIDColumn => columnProductID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn HospitalNameColumn => columnHospitalName;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn HospitalCodeColumn => columnHospitalCode;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn UnitNameColumn => columnUnitName;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn BatchColumn => columnBatch;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ExpDateColumn => columnExpDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn AvgPriceColumn => columnAvgPrice;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn PriceColumn => columnPrice;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ApprovedQtyColumn => columnApprovedQty;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TotalAvgMoneyColumn => columnTotalAvgMoney;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn TotalMoneyColumn => columnTotalMoney;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn FormulaColumn => columnFormula;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn STTColumn => columnSTT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn UnitIDColumn => columnUnitID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ImportIDColumn => columnImportID;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ImportDateColumn => columnImportDate;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BSNgoaiColumn => columnBSNgoai;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn YSNgoaiColumn => columnYSNgoai;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn YSiIDColumn => columnYSiID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn BacSiIDColumn => columnBacSiID;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn MaDauThauColumn => columnMaDauThau;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ThueVATColumn => columnThueVAT;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ThanhTienTruocThueColumn => columnThanhTienTruocThue;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ThanhTienSauThueColumn => columnThanhTienSauThue;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn KhoXuatColumn => columnKhoXuat;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn VATColumn => columnVAT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ChietKhauColumn => columnChietKhau;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ChietKhauBSColumn => columnChietKhauBS;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn ThanhTienBangChuColumn => columnThanhTienBangChu;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ViTriXuatColumn => columnViTriXuat;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2Row this[int index] => (Table2Row)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Table2RowChangeEventHandler Table2RowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2DataTable()
		{
			base.TableName = "Table2";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table2DataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Table2DataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void AddTable2Row(Table2Row row)
		{
			base.Rows.Add(row);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table2Row AddTable2Row(int ProductID, string HospitalName, string HospitalCode, string UnitName, string Batch, string ExpDate, decimal AvgPrice, decimal Price, decimal ApprovedQty, decimal TotalAvgMoney, decimal TotalMoney, string Formula, int STT, int UnitID, int ImportID, DateTime ImportDate, string BSNgoai, string YSNgoai, string YSiID, string BacSiID, string MaDauThau, decimal ThueVAT, decimal ThanhTienTruocThue, decimal ThanhTienSauThue, string KhoXuat, decimal VAT, decimal ChietKhau, decimal ChietKhauBS, string ThanhTienBangChu, string ViTriXuat)
		{
			Table2Row table2Row = (Table2Row)NewRow();
			object[] itemArray = new object[30]
			{
				ProductID, HospitalName, HospitalCode, UnitName, Batch, ExpDate, AvgPrice, Price, ApprovedQty, TotalAvgMoney,
				TotalMoney, Formula, STT, UnitID, ImportID, ImportDate, BSNgoai, YSNgoai, YSiID, BacSiID,
				MaDauThau, ThueVAT, ThanhTienTruocThue, ThanhTienSauThue, KhoXuat, VAT, ChietKhau, ChietKhauBS, ThanhTienBangChu, ViTriXuat
			};
			table2Row.ItemArray = itemArray;
			base.Rows.Add(table2Row);
			return table2Row;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Table2DataTable table2DataTable = (Table2DataTable)base.Clone();
			table2DataTable.InitVars();
			return table2DataTable;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Table2DataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			columnProductID = base.Columns["ProductID"];
			columnHospitalName = base.Columns["HospitalName"];
			columnHospitalCode = base.Columns["HospitalCode"];
			columnUnitName = base.Columns["UnitName"];
			columnBatch = base.Columns["Batch"];
			columnExpDate = base.Columns["ExpDate"];
			columnAvgPrice = base.Columns["AvgPrice"];
			columnPrice = base.Columns["Price"];
			columnApprovedQty = base.Columns["ApprovedQty"];
			columnTotalAvgMoney = base.Columns["TotalAvgMoney"];
			columnTotalMoney = base.Columns["TotalMoney"];
			columnFormula = base.Columns["Formula"];
			columnSTT = base.Columns["STT"];
			columnUnitID = base.Columns["UnitID"];
			columnImportID = base.Columns["ImportID"];
			columnImportDate = base.Columns["ImportDate"];
			columnBSNgoai = base.Columns["BSNgoai"];
			columnYSNgoai = base.Columns["YSNgoai"];
			columnYSiID = base.Columns["YSiID"];
			columnBacSiID = base.Columns["BacSiID"];
			columnMaDauThau = base.Columns["MaDauThau"];
			columnThueVAT = base.Columns["ThueVAT"];
			columnThanhTienTruocThue = base.Columns["ThanhTienTruocThue"];
			columnThanhTienSauThue = base.Columns["ThanhTienSauThue"];
			columnKhoXuat = base.Columns["KhoXuat"];
			columnVAT = base.Columns["VAT"];
			columnChietKhau = base.Columns["ChietKhau"];
			columnChietKhauBS = base.Columns["ChietKhauBS"];
			columnThanhTienBangChu = base.Columns["ThanhTienBangChu"];
			columnViTriXuat = base.Columns["ViTriXuat"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			columnProductID = new DataColumn("ProductID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnProductID);
			columnHospitalName = new DataColumn("HospitalName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHospitalName);
			columnHospitalCode = new DataColumn("HospitalCode", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHospitalCode);
			columnUnitName = new DataColumn("UnitName", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnUnitName);
			columnBatch = new DataColumn("Batch", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBatch);
			columnExpDate = new DataColumn("ExpDate", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnExpDate);
			columnAvgPrice = new DataColumn("AvgPrice", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnAvgPrice);
			columnPrice = new DataColumn("Price", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnPrice);
			columnApprovedQty = new DataColumn("ApprovedQty", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnApprovedQty);
			columnTotalAvgMoney = new DataColumn("TotalAvgMoney", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTotalAvgMoney);
			columnTotalMoney = new DataColumn("TotalMoney", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnTotalMoney);
			columnFormula = new DataColumn("Formula", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnFormula);
			columnSTT = new DataColumn("STT", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnSTT);
			columnUnitID = new DataColumn("UnitID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnUnitID);
			columnImportID = new DataColumn("ImportID", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnImportID);
			columnImportDate = new DataColumn("ImportDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnImportDate);
			columnBSNgoai = new DataColumn("BSNgoai", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBSNgoai);
			columnYSNgoai = new DataColumn("YSNgoai", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnYSNgoai);
			columnYSiID = new DataColumn("YSiID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnYSiID);
			columnBacSiID = new DataColumn("BacSiID", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnBacSiID);
			columnMaDauThau = new DataColumn("MaDauThau", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaDauThau);
			columnThueVAT = new DataColumn("ThueVAT", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnThueVAT);
			columnThanhTienTruocThue = new DataColumn("ThanhTienTruocThue", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnThanhTienTruocThue);
			columnThanhTienSauThue = new DataColumn("ThanhTienSauThue", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnThanhTienSauThue);
			columnKhoXuat = new DataColumn("KhoXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnKhoXuat);
			columnVAT = new DataColumn("VAT", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnVAT);
			columnChietKhau = new DataColumn("ChietKhau", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnChietKhau);
			columnChietKhauBS = new DataColumn("ChietKhauBS", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(columnChietKhauBS);
			columnThanhTienBangChu = new DataColumn("ThanhTienBangChu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnThanhTienBangChu);
			columnViTriXuat = new DataColumn("ViTriXuat", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnViTriXuat);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table2Row NewTable2Row()
		{
			return (Table2Row)NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Table2Row(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Table2Row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.Table2RowChanged != null)
			{
				this.Table2RowChanged(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.Table2RowChanging != null)
			{
				this.Table2RowChanging(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.Table2RowDeleted != null)
			{
				this.Table2RowDeleted(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.Table2RowDeleting != null)
			{
				this.Table2RowDeleting(this, new Table2RowChangeEvent((Table2Row)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void RemoveTable2Row(Table2Row row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			rep_PhieuXuatKhoKiemBaoLo_PDF rep_PhieuXuatKhoKiemBaoLo_PDF2 = new rep_PhieuXuatKhoKiemBaoLo_PDF();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = rep_PhieuXuatKhoKiemBaoLo_PDF2.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "Table2DataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemBaoLo_PDF2.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class Table1Row : DataRow
	{
		private Table1DataTable tableTable1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string FacName
		{
			get
			{
				try
				{
					return (string)base[tableTable1.FacNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FacName' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.FacNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ADDRESS
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ADDRESSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ADDRESS' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ADDRESSColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NgayReport
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NgayReportColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayReport' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NgayReportColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DoiTuongXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DoiTuongXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DoiTuongXuat' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DoiTuongXuatColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string MST
		{
			get
			{
				try
				{
					return (string)base[tableTable1.MSTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MST' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.MSTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiXuat' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiXuatColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string KhachHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.KhachHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'KhachHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.KhachHangColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DonViVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DonViVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DonViVanChuyen' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DonViVanChuyenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NhietDoGiaoHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NhietDoGiaoHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NhietDoGiaoHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NhietDoGiaoHangColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NhietDoNhanHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NhietDoNhanHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NhietDoNhanHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NhietDoNhanHangColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string KhoXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable1.KhoXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'KhoXuat' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.KhoXuatColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HinhThucThanhToan
		{
			get
			{
				try
				{
					return (string)base[tableTable1.HinhThucThanhToanColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HinhThucThanhToan' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.HinhThucThanhToanColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DiaChiGiaoHang
		{
			get
			{
				try
				{
					return (string)base[tableTable1.DiaChiGiaoHangColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DiaChiGiaoHang' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.DiaChiGiaoHangColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HinhThucVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableTable1.HinhThucVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HinhThucVanChuyen' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.HinhThucVanChuyenColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string LienHe
		{
			get
			{
				try
				{
					return (string)base[tableTable1.LienHeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LienHe' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.LienHeColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SoHoaDon
		{
			get
			{
				try
				{
					return (string)base[tableTable1.SoHoaDonColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoHoaDon' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.SoHoaDonColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ApprovedOutNo
		{
			get
			{
				try
				{
					return (string)base[tableTable1.ApprovedOutNoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ApprovedOutNo' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.ApprovedOutNoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Logo
		{
			get
			{
				try
				{
					return (string)base[tableTable1.LogoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Logo' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.LogoColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NguoiVanChuyen
		{
			get
			{
				try
				{
					return (string)base[tableTable1.NguoiVanChuyenColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiVanChuyen' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.NguoiVanChuyenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string SoLDD
		{
			get
			{
				try
				{
					return (string)base[tableTable1.SoLDDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoLDD' in table 'Table1' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable1.SoLDDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Table1Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable1 = (Table1DataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFacNameNull()
		{
			return IsNull(tableTable1.FacNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetFacNameNull()
		{
			base[tableTable1.FacNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsADDRESSNull()
		{
			return IsNull(tableTable1.ADDRESSColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetADDRESSNull()
		{
			base[tableTable1.ADDRESSColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNgayReportNull()
		{
			return IsNull(tableTable1.NgayReportColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNgayReportNull()
		{
			base[tableTable1.NgayReportColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDoiTuongXuatNull()
		{
			return IsNull(tableTable1.DoiTuongXuatColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDoiTuongXuatNull()
		{
			base[tableTable1.DoiTuongXuatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsMSTNull()
		{
			return IsNull(tableTable1.MSTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMSTNull()
		{
			base[tableTable1.MSTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsDiaChiXuatNull()
		{
			return IsNull(tableTable1.DiaChiXuatColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDiaChiXuatNull()
		{
			base[tableTable1.DiaChiXuatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsKhachHangNull()
		{
			return IsNull(tableTable1.KhachHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetKhachHangNull()
		{
			base[tableTable1.KhachHangColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDonViVanChuyenNull()
		{
			return IsNull(tableTable1.DonViVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetDonViVanChuyenNull()
		{
			base[tableTable1.DonViVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsNhietDoGiaoHangNull()
		{
			return IsNull(tableTable1.NhietDoGiaoHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNhietDoGiaoHangNull()
		{
			base[tableTable1.NhietDoGiaoHangColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNhietDoNhanHangNull()
		{
			return IsNull(tableTable1.NhietDoNhanHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetNhietDoNhanHangNull()
		{
			base[tableTable1.NhietDoNhanHangColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsKhoXuatNull()
		{
			return IsNull(tableTable1.KhoXuatColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetKhoXuatNull()
		{
			base[tableTable1.KhoXuatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHinhThucThanhToanNull()
		{
			return IsNull(tableTable1.HinhThucThanhToanColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHinhThucThanhToanNull()
		{
			base[tableTable1.HinhThucThanhToanColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsDiaChiGiaoHangNull()
		{
			return IsNull(tableTable1.DiaChiGiaoHangColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetDiaChiGiaoHangNull()
		{
			base[tableTable1.DiaChiGiaoHangColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsHinhThucVanChuyenNull()
		{
			return IsNull(tableTable1.HinhThucVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHinhThucVanChuyenNull()
		{
			base[tableTable1.HinhThucVanChuyenColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLienHeNull()
		{
			return IsNull(tableTable1.LienHeColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetLienHeNull()
		{
			base[tableTable1.LienHeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSoHoaDonNull()
		{
			return IsNull(tableTable1.SoHoaDonColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSoHoaDonNull()
		{
			base[tableTable1.SoHoaDonColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApprovedOutNoNull()
		{
			return IsNull(tableTable1.ApprovedOutNoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetApprovedOutNoNull()
		{
			base[tableTable1.ApprovedOutNoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsLogoNull()
		{
			return IsNull(tableTable1.LogoColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetLogoNull()
		{
			base[tableTable1.LogoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsNguoiVanChuyenNull()
		{
			return IsNull(tableTable1.NguoiVanChuyenColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetNguoiVanChuyenNull()
		{
			base[tableTable1.NguoiVanChuyenColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsSoLDDNull()
		{
			return IsNull(tableTable1.SoLDDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetSoLDDNull()
		{
			base[tableTable1.SoLDDColumn] = Convert.DBNull;
		}
	}

	public class Table2Row : DataRow
	{
		private Table2DataTable tableTable2;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int ProductID
		{
			get
			{
				try
				{
					return (int)base[tableTable2.ProductIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ProductID' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ProductIDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string HospitalName
		{
			get
			{
				try
				{
					return (string)base[tableTable2.HospitalNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HospitalName' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.HospitalNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HospitalCode
		{
			get
			{
				try
				{
					return (string)base[tableTable2.HospitalCodeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HospitalCode' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.HospitalCodeColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string UnitName
		{
			get
			{
				try
				{
					return (string)base[tableTable2.UnitNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'UnitName' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.UnitNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Batch
		{
			get
			{
				try
				{
					return (string)base[tableTable2.BatchColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Batch' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.BatchColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ExpDate
		{
			get
			{
				try
				{
					return (string)base[tableTable2.ExpDateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ExpDate' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ExpDateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal AvgPrice
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.AvgPriceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AvgPrice' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.AvgPriceColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal Price
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.PriceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Price' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.PriceColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal ApprovedQty
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.ApprovedQtyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ApprovedQty' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ApprovedQtyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal TotalAvgMoney
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.TotalAvgMoneyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TotalAvgMoney' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.TotalAvgMoneyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal TotalMoney
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.TotalMoneyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TotalMoney' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.TotalMoneyColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Formula
		{
			get
			{
				try
				{
					return (string)base[tableTable2.FormulaColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Formula' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.FormulaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int STT
		{
			get
			{
				try
				{
					return (int)base[tableTable2.STTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'STT' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.STTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int UnitID
		{
			get
			{
				try
				{
					return (int)base[tableTable2.UnitIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'UnitID' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.UnitIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int ImportID
		{
			get
			{
				try
				{
					return (int)base[tableTable2.ImportIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ImportID' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ImportIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime ImportDate
		{
			get
			{
				try
				{
					return (DateTime)base[tableTable2.ImportDateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ImportDate' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ImportDateColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string BSNgoai
		{
			get
			{
				try
				{
					return (string)base[tableTable2.BSNgoaiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'BSNgoai' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.BSNgoaiColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string YSNgoai
		{
			get
			{
				try
				{
					return (string)base[tableTable2.YSNgoaiColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'YSNgoai' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.YSNgoaiColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string YSiID
		{
			get
			{
				try
				{
					return (string)base[tableTable2.YSiIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'YSiID' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.YSiIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string BacSiID
		{
			get
			{
				try
				{
					return (string)base[tableTable2.BacSiIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'BacSiID' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.BacSiIDColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string MaDauThau
		{
			get
			{
				try
				{
					return (string)base[tableTable2.MaDauThauColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaDauThau' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.MaDauThauColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal ThueVAT
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.ThueVATColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThueVAT' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ThueVATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal ThanhTienTruocThue
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.ThanhTienTruocThueColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThanhTienTruocThue' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ThanhTienTruocThueColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal ThanhTienSauThue
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.ThanhTienSauThueColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThanhTienSauThue' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ThanhTienSauThueColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string KhoXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable2.KhoXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'KhoXuat' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.KhoXuatColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal VAT
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.VATColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'VAT' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.VATColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal ChietKhau
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.ChietKhauColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ChietKhau' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ChietKhauColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public decimal ChietKhauBS
		{
			get
			{
				try
				{
					return (decimal)base[tableTable2.ChietKhauBSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ChietKhauBS' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ChietKhauBSColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ThanhTienBangChu
		{
			get
			{
				try
				{
					return (string)base[tableTable2.ThanhTienBangChuColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ThanhTienBangChu' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ThanhTienBangChuColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string ViTriXuat
		{
			get
			{
				try
				{
					return (string)base[tableTable2.ViTriXuatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ViTriXuat' in table 'Table2' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableTable2.ViTriXuatColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Table2Row(DataRowBuilder rb)
			: base(rb)
		{
			tableTable2 = (Table2DataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsProductIDNull()
		{
			return IsNull(tableTable2.ProductIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetProductIDNull()
		{
			base[tableTable2.ProductIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHospitalNameNull()
		{
			return IsNull(tableTable2.HospitalNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHospitalNameNull()
		{
			base[tableTable2.HospitalNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHospitalCodeNull()
		{
			return IsNull(tableTable2.HospitalCodeColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetHospitalCodeNull()
		{
			base[tableTable2.HospitalCodeColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsUnitNameNull()
		{
			return IsNull(tableTable2.UnitNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetUnitNameNull()
		{
			base[tableTable2.UnitNameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBatchNull()
		{
			return IsNull(tableTable2.BatchColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBatchNull()
		{
			base[tableTable2.BatchColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsExpDateNull()
		{
			return IsNull(tableTable2.ExpDateColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetExpDateNull()
		{
			base[tableTable2.ExpDateColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsAvgPriceNull()
		{
			return IsNull(tableTable2.AvgPriceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetAvgPriceNull()
		{
			base[tableTable2.AvgPriceColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsPriceNull()
		{
			return IsNull(tableTable2.PriceColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetPriceNull()
		{
			base[tableTable2.PriceColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsApprovedQtyNull()
		{
			return IsNull(tableTable2.ApprovedQtyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetApprovedQtyNull()
		{
			base[tableTable2.ApprovedQtyColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsTotalAvgMoneyNull()
		{
			return IsNull(tableTable2.TotalAvgMoneyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTotalAvgMoneyNull()
		{
			base[tableTable2.TotalAvgMoneyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsTotalMoneyNull()
		{
			return IsNull(tableTable2.TotalMoneyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetTotalMoneyNull()
		{
			base[tableTable2.TotalMoneyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsFormulaNull()
		{
			return IsNull(tableTable2.FormulaColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetFormulaNull()
		{
			base[tableTable2.FormulaColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsSTTNull()
		{
			return IsNull(tableTable2.STTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetSTTNull()
		{
			base[tableTable2.STTColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsUnitIDNull()
		{
			return IsNull(tableTable2.UnitIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetUnitIDNull()
		{
			base[tableTable2.UnitIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsImportIDNull()
		{
			return IsNull(tableTable2.ImportIDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetImportIDNull()
		{
			base[tableTable2.ImportIDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsImportDateNull()
		{
			return IsNull(tableTable2.ImportDateColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetImportDateNull()
		{
			base[tableTable2.ImportDateColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsBSNgoaiNull()
		{
			return IsNull(tableTable2.BSNgoaiColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBSNgoaiNull()
		{
			base[tableTable2.BSNgoaiColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsYSNgoaiNull()
		{
			return IsNull(tableTable2.YSNgoaiColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetYSNgoaiNull()
		{
			base[tableTable2.YSNgoaiColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsYSiIDNull()
		{
			return IsNull(tableTable2.YSiIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetYSiIDNull()
		{
			base[tableTable2.YSiIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsBacSiIDNull()
		{
			return IsNull(tableTable2.BacSiIDColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetBacSiIDNull()
		{
			base[tableTable2.BacSiIDColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsMaDauThauNull()
		{
			return IsNull(tableTable2.MaDauThauColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetMaDauThauNull()
		{
			base[tableTable2.MaDauThauColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThueVATNull()
		{
			return IsNull(tableTable2.ThueVATColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetThueVATNull()
		{
			base[tableTable2.ThueVATColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThanhTienTruocThueNull()
		{
			return IsNull(tableTable2.ThanhTienTruocThueColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetThanhTienTruocThueNull()
		{
			base[tableTable2.ThanhTienTruocThueColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThanhTienSauThueNull()
		{
			return IsNull(tableTable2.ThanhTienSauThueColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetThanhTienSauThueNull()
		{
			base[tableTable2.ThanhTienSauThueColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsKhoXuatNull()
		{
			return IsNull(tableTable2.KhoXuatColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetKhoXuatNull()
		{
			base[tableTable2.KhoXuatColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsVATNull()
		{
			return IsNull(tableTable2.VATColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetVATNull()
		{
			base[tableTable2.VATColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsChietKhauNull()
		{
			return IsNull(tableTable2.ChietKhauColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetChietKhauNull()
		{
			base[tableTable2.ChietKhauColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool IsChietKhauBSNull()
		{
			return IsNull(tableTable2.ChietKhauBSColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetChietKhauBSNull()
		{
			base[tableTable2.ChietKhauBSColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsThanhTienBangChuNull()
		{
			return IsNull(tableTable2.ThanhTienBangChuColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void SetThanhTienBangChuNull()
		{
			base[tableTable2.ThanhTienBangChuColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsViTriXuatNull()
		{
			return IsNull(tableTable2.ViTriXuatColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void SetViTriXuatNull()
		{
			base[tableTable2.ViTriXuatColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table1RowChangeEvent : EventArgs
	{
		private Table1Row eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1Row Row => eventRow;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table1RowChangeEvent(Table1Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class Table2RowChangeEvent : EventArgs
	{
		private Table2Row eventRow;

		private DataRowAction eventAction;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Table2Row Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Table2RowChangeEvent(Table2Row row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private Table1DataTable tableTable1;

	private Table2DataTable tableTable2;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Table1DataTable Table1 => tableTable1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public Table2DataTable Table2 => tableTable2;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public rep_PhieuXuatKhoKiemBaoLo_PDF()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected rep_PhieuXuatKhoKiemBaoLo_PDF(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table2"] != null)
			{
				base.Tables.Add(new Table2DataTable(dataSet.Tables["Table2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public override DataSet Clone()
	{
		rep_PhieuXuatKhoKiemBaoLo_PDF rep_PhieuXuatKhoKiemBaoLo_PDF2 = (rep_PhieuXuatKhoKiemBaoLo_PDF)base.Clone();
		rep_PhieuXuatKhoKiemBaoLo_PDF2.InitVars();
		rep_PhieuXuatKhoKiemBaoLo_PDF2.SchemaSerializationMode = SchemaSerializationMode;
		return rep_PhieuXuatKhoKiemBaoLo_PDF2;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["Table1"] != null)
			{
				base.Tables.Add(new Table1DataTable(dataSet.Tables["Table1"]));
			}
			if (dataSet.Tables["Table2"] != null)
			{
				base.Tables.Add(new Table2DataTable(dataSet.Tables["Table2"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableTable1 = (Table1DataTable)base.Tables["Table1"];
		if (initTable && tableTable1 != null)
		{
			tableTable1.InitVars();
		}
		tableTable2 = (Table2DataTable)base.Tables["Table2"];
		if (initTable && tableTable2 != null)
		{
			tableTable2.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "rep_PhieuXuatKhoKiemBaoLo_PDF";
		base.Prefix = "";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableTable1 = new Table1DataTable();
		base.Tables.Add(tableTable1);
		tableTable2 = new Table2DataTable();
		base.Tables.Add(tableTable2);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeTable1()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool ShouldSerializeTable2()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		rep_PhieuXuatKhoKiemBaoLo_PDF rep_PhieuXuatKhoKiemBaoLo_PDF2 = new rep_PhieuXuatKhoKiemBaoLo_PDF();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = rep_PhieuXuatKhoKiemBaoLo_PDF2.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = rep_PhieuXuatKhoKiemBaoLo_PDF2.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}

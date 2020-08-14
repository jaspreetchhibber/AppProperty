using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyDB.Migrations
{
    public partial class UnitSectionAndUnitInOut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Unit_CssUnitCode",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Building_CssBuildingCode",
                table: "Unit");

            migrationBuilder.AlterColumn<int>(
                name: "CssBuildingCode",
                table: "Unit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Item",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CssItemCode",
                table: "BuildPic",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CssTicketCode",
                table: "BuildPic",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CssUnitCode",
                table: "Amenities",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AsignedTo",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AsignedKindCode = table.Column<int>(nullable: true),
                    AsignedCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignedTo", x => x.Code);
                    table.ForeignKey(
                        name: "FK_AsignedTo_Person_AsignedCode",
                        column: x => x.AsignedCode,
                        principalTable: "Person",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AsignedTo_General_AsignedKindCode",
                        column: x => x.AsignedKindCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CUENTA = table.Column<string>(nullable: true),
                    DESCRIPCION = table.Column<string>(nullable: true),
                    CUENTATIPO = table.Column<int>(nullable: false),
                    CTACONTROL = table.Column<int>(nullable: false),
                    SUPERCUENTA = table.Column<string>(nullable: true),
                    BALANCE = table.Column<decimal>(nullable: false),
                    ABALANCE = table.Column<decimal>(nullable: false),
                    DEBITO = table.Column<decimal>(nullable: false),
                    CREDITO = table.Column<decimal>(nullable: false),
                    DRMENSUAL = table.Column<decimal>(nullable: false),
                    CRMENSUAL = table.Column<decimal>(nullable: false),
                    FECHA = table.Column<string>(nullable: true),
                    RESULTADO = table.Column<int>(nullable: false),
                    SITUACION = table.Column<int>(nullable: false),
                    ANALITICO = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Company = table.Column<string>(type: "varchar(75)", nullable: true),
                    AddressCode = table.Column<int>(nullable: true),
                    PhoneCode = table.Column<int>(nullable: true),
                    LegalRegiter = table.Column<string>(type: "varchar(35)", nullable: true),
                    CFNNumer = table.Column<string>(type: "varchar(75)", nullable: true),
                    CFNSecuencia = table.Column<string>(type: "varchar(75)", nullable: true),
                    DateStart = table.Column<DateTime>(nullable: false),
                    DatePay = table.Column<DateTime>(nullable: false),
                    DateLastPay = table.Column<DateTime>(nullable: false),
                    StatusCode = table.Column<int>(nullable: true),
                    Logo = table.Column<string>(type: "varchar(255)", nullable: true),
                    Contact = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Company_Address_AddressCode",
                        column: x => x.AddressCode,
                        principalTable: "Address",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_Phone_PhoneCode",
                        column: x => x.PhoneCode,
                        principalTable: "Phone",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfferContext",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PathLogo = table.Column<string>(nullable: true),
                    Desctription = table.Column<string>(type: "Varchar(75)", nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PageToGoCode = table.Column<int>(nullable: true),
                    PathPic = table.Column<string>(nullable: true),
                    StatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferContext", x => x.Code);
                    table.ForeignKey(
                        name: "FK_OfferContext_Item_PageToGoCode",
                        column: x => x.PageToGoCode,
                        principalTable: "Item",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OfferContext_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    EmployeeCode = table.Column<int>(nullable: true),
                    BuildingCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Section_Building_BuildingCode",
                        column: x => x.BuildingCode,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Section_Employee_EmployeeCode",
                        column: x => x.EmployeeCode,
                        principalTable: "Employee",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierCode = table.Column<int>(nullable: true),
                    CategoryCode = table.Column<int>(nullable: true),
                    LineCredit = table.Column<decimal>(nullable: false),
                    NameContact = table.Column<string>(type: "varchar(50)", nullable: true),
                    PhoneContact = table.Column<string>(type: "varchar(15)", nullable: true),
                    EmailContact = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Supplier_General_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Supplier_Person_SupplierCode",
                        column: x => x.SupplierCode,
                        principalTable: "Person",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitInOut",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnitCodeCode = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    PeriodTime = table.Column<int>(nullable: false),
                    Plate = table.Column<string>(nullable: true),
                    UserCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitInOut", x => x.Code);
                    table.ForeignKey(
                        name: "FK_UnitInOut_Unit_UnitCodeCode",
                        column: x => x.UnitCodeCode,
                        principalTable: "Unit",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitInOut_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PriorityCode = table.Column<int>(nullable: true),
                    Requested = table.Column<DateTime>(nullable: false),
                    Assigned = table.Column<DateTime>(nullable: false),
                    Resolved = table.Column<DateTime>(nullable: false),
                    UnitNumberCode = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Detail = table.Column<string>(type: "Varchar(255)", nullable: false),
                    Resolution = table.Column<string>(type: "Varchar(255)", nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    StatusCode = table.Column<int>(nullable: true),
                    AsignedToCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Ticket_AsignedTo_AsignedToCode",
                        column: x => x.AsignedToCode,
                        principalTable: "AsignedTo",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_General_PriorityCode",
                        column: x => x.PriorityCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Unit_UnitNumberCode",
                        column: x => x.UnitNumberCode,
                        principalTable: "Unit",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyCodigo = table.Column<int>(nullable: true),
                    SupplierCode = table.Column<int>(nullable: true),
                    PODate = table.Column<DateTime>(nullable: false),
                    POTotal = table.Column<decimal>(nullable: false),
                    PODescuent = table.Column<decimal>(nullable: false),
                    Itbis = table.Column<decimal>(nullable: false),
                    PayKindCode = table.Column<int>(nullable: true),
                    ConditionCode = table.Column<int>(nullable: true),
                    Balance = table.Column<decimal>(nullable: false),
                    EmployeeIDCode = table.Column<int>(nullable: true),
                    Flete = table.Column<decimal>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    IdTransportista = table.Column<int>(nullable: false),
                    TaxReceipt = table.Column<string>(nullable: true),
                    Create = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Code);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Company_CompanyCodigo",
                        column: x => x.CompanyCodigo,
                        principalTable: "Company",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_General_ConditionCode",
                        column: x => x.ConditionCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Employee_EmployeeIDCode",
                        column: x => x.EmployeeIDCode,
                        principalTable: "Employee",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_General_PayKindCode",
                        column: x => x.PayKindCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Supplier_SupplierCode",
                        column: x => x.SupplierCode,
                        principalTable: "Supplier",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderDetail",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CompanyCodigo = table.Column<int>(nullable: true),
                    PurchaseOrderCode = table.Column<int>(nullable: true),
                    ProductIDCode = table.Column<int>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Descuent = table.Column<decimal>(nullable: false),
                    NetPrice = table.Column<decimal>(nullable: false),
                    LoteId = table.Column<string>(type: "Varchar(30)", nullable: true),
                    ZoneCode = table.Column<int>(nullable: true),
                    StretchCode = table.Column<int>(nullable: true),
                    UndFactor = table.Column<decimal>(nullable: false),
                    BestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderDetail", x => x.Code);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_Company_CompanyCodigo",
                        column: x => x.CompanyCodigo,
                        principalTable: "Company",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_Item_ProductIDCode",
                        column: x => x.ProductIDCode,
                        principalTable: "Item",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_PurchaseOrder_PurchaseOrderCode",
                        column: x => x.PurchaseOrderCode,
                        principalTable: "PurchaseOrder",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_General_StretchCode",
                        column: x => x.StretchCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrderDetail_General_ZoneCode",
                        column: x => x.ZoneCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildPic_CssTicketCode",
                table: "BuildPic",
                column: "CssTicketCode");

            migrationBuilder.CreateIndex(
                name: "IX_AsignedTo_AsignedCode",
                table: "AsignedTo",
                column: "AsignedCode");

            migrationBuilder.CreateIndex(
                name: "IX_AsignedTo_AsignedKindCode",
                table: "AsignedTo",
                column: "AsignedKindCode");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressCode",
                table: "Company",
                column: "AddressCode");

            migrationBuilder.CreateIndex(
                name: "IX_Company_PhoneCode",
                table: "Company",
                column: "PhoneCode");

            migrationBuilder.CreateIndex(
                name: "IX_Company_StatusCode",
                table: "Company",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_OfferContext_PageToGoCode",
                table: "OfferContext",
                column: "PageToGoCode");

            migrationBuilder.CreateIndex(
                name: "IX_OfferContext_StatusCode",
                table: "OfferContext",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_CompanyCodigo",
                table: "PurchaseOrder",
                column: "CompanyCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ConditionCode",
                table: "PurchaseOrder",
                column: "ConditionCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_EmployeeIDCode",
                table: "PurchaseOrder",
                column: "EmployeeIDCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PayKindCode",
                table: "PurchaseOrder",
                column: "PayKindCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_SupplierCode",
                table: "PurchaseOrder",
                column: "SupplierCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_CompanyCodigo",
                table: "PurchaseOrderDetail",
                column: "CompanyCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_ProductIDCode",
                table: "PurchaseOrderDetail",
                column: "ProductIDCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_PurchaseOrderCode",
                table: "PurchaseOrderDetail",
                column: "PurchaseOrderCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_StretchCode",
                table: "PurchaseOrderDetail",
                column: "StretchCode");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderDetail_ZoneCode",
                table: "PurchaseOrderDetail",
                column: "ZoneCode");

            migrationBuilder.CreateIndex(
                name: "IX_Section_BuildingCode",
                table: "Section",
                column: "BuildingCode");

            migrationBuilder.CreateIndex(
                name: "IX_Section_EmployeeCode",
                table: "Section",
                column: "EmployeeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CategoryCode",
                table: "Supplier",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_SupplierCode",
                table: "Supplier",
                column: "SupplierCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_AsignedToCode",
                table: "Ticket",
                column: "AsignedToCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PriorityCode",
                table: "Ticket",
                column: "PriorityCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_StatusCode",
                table: "Ticket",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UnitNumberCode",
                table: "Ticket",
                column: "UnitNumberCode");

            migrationBuilder.CreateIndex(
                name: "IX_UnitInOut_UnitCodeCode",
                table: "UnitInOut",
                column: "UnitCodeCode");

            migrationBuilder.CreateIndex(
                name: "IX_UnitInOut_UserCode",
                table: "UnitInOut",
                column: "UserCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Unit_CssUnitCode",
                table: "Amenities",
                column: "CssUnitCode",
                principalTable: "Unit",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BuildPic_Ticket_CssTicketCode",
                table: "BuildPic",
                column: "CssTicketCode",
                principalTable: "Ticket",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Building_CssBuildingCode",
                table: "Unit",
                column: "CssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Unit_CssUnitCode",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_BuildPic_Ticket_CssTicketCode",
                table: "BuildPic");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Building_CssBuildingCode",
                table: "Unit");

            migrationBuilder.DropTable(
                name: "Catalog");

            migrationBuilder.DropTable(
                name: "OfferContext");

            migrationBuilder.DropTable(
                name: "PurchaseOrderDetail");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "UnitInOut");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "AsignedTo");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_BuildPic_CssTicketCode",
                table: "BuildPic");

            migrationBuilder.DropColumn(
                name: "CssTicketCode",
                table: "BuildPic");

            migrationBuilder.AlterColumn<int>(
                name: "CssBuildingCode",
                table: "Unit",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Item",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "CssItemCode",
                table: "BuildPic",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CssUnitCode",
                table: "Amenities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Unit_CssUnitCode",
                table: "Amenities",
                column: "CssUnitCode",
                principalTable: "Unit",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Building_CssBuildingCode",
                table: "Unit",
                column: "CssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

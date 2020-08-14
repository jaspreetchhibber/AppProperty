using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyDB.Migrations
{
    public partial class PropertyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CountryAbr = table.Column<string>(type: "Varchar(3)", nullable: true),
                    Country = table.Column<string>(type: "Varchar(100)", nullable: true),
                    Region = table.Column<string>(type: "Varchar(75)", nullable: true),
                    Continent = table.Column<string>(type: "Varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "Varchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Kind",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "Varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kind", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PhoneType = table.Column<string>(type: "Varchar(15)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "Varchar(16)", nullable: true),
                    Provider = table.Column<string>(type: "Varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Role = table.Column<string>(nullable: true),
                    Kind = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    State = table.Column<string>(type: "Varchar(100)", nullable: true),
                    CountryCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Code);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "Country",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "Varchar(100)", nullable: true),
                    StateCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Code);
                    table.ForeignKey(
                        name: "FK_City_State_StateCode",
                        column: x => x.StateCode,
                        principalTable: "State",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "Varchar(200)", nullable: true),
                    CityCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Address_City_CityCode",
                        column: x => x.CityCode,
                        principalTable: "City",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    BuldingName = table.Column<string>(nullable: false),
                    BuldingTypeCode = table.Column<int>(nullable: true),
                    AddressCode = table.Column<int>(nullable: true),
                    PhoneCode = table.Column<int>(nullable: true),
                    YearBuilt = table.Column<int>(nullable: false),
                    LotSize = table.Column<string>(nullable: true),
                    SquareFoot = table.Column<string>(nullable: true),
                    RentalAmount = table.Column<decimal>(nullable: false),
                    LevelNumber = table.Column<int>(nullable: false),
                    Elvator = table.Column<bool>(nullable: false),
                    StatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Building_Address_AddressCode",
                        column: x => x.AddressCode,
                        principalTable: "Address",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Building_Phone_PhoneCode",
                        column: x => x.PhoneCode,
                        principalTable: "Phone",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "General",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KindCode = table.Column<int>(nullable: true),
                    Description = table.Column<string>(type: "Varchar(100)", nullable: true),
                    DependsOn = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Start = table.Column<string>(type: "Varchar(20)", nullable: true),
                    End = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Used = table.Column<bool>(nullable: false),
                    cssBuildingCode = table.Column<int>(nullable: true),
                    cssBuildingCode1 = table.Column<int>(nullable: true),
                    cssBuildingCode2 = table.Column<int>(nullable: true),
                    cssBuildingCode3 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_General", x => x.Code);
                    table.ForeignKey(
                        name: "FK_General_Kind_KindCode",
                        column: x => x.KindCode,
                        principalTable: "Kind",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_General_Building_cssBuildingCode",
                        column: x => x.cssBuildingCode,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_General_Building_cssBuildingCode1",
                        column: x => x.cssBuildingCode1,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_General_Building_cssBuildingCode2",
                        column: x => x.cssBuildingCode2,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_General_Building_cssBuildingCode3",
                        column: x => x.cssBuildingCode3,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnitNumber = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    RentalAmount = table.Column<decimal>(nullable: false),
                    LotSize = table.Column<string>(nullable: true),
                    SquareFoot = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    cssBuildingCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Unit_Building_cssBuildingCode",
                        column: x => x.cssBuildingCode,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    UPC = table.Column<string>(nullable: true),
                    BarCode = table.Column<string>(nullable: true),
                    MaxCant = table.Column<string>(nullable: true),
                    MinCant = table.Column<string>(nullable: true),
                    ReOrderPoint = table.Column<string>(nullable: true),
                    Tax = table.Column<bool>(nullable: false),
                    Belong = table.Column<string>(nullable: true),
                    BrandName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    StoreUnitCode = table.Column<int>(nullable: true),
                    ItemCost = table.Column<string>(nullable: false),
                    StatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Item_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_General_StoreUnitCode",
                        column: x => x.StoreUnitCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildPic",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    CssItemCode = table.Column<string>(nullable: true),
                    cssBuildingCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildPic", x => x.Code);
                    table.ForeignKey(
                        name: "FK_BuildPic_Item_CssItemCode",
                        column: x => x.CssItemCode,
                        principalTable: "Item",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildPic_Building_cssBuildingCode",
                        column: x => x.cssBuildingCode,
                        principalTable: "Building",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnitHas",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RentalAmountCode = table.Column<string>(nullable: true),
                    StatusCode = table.Column<int>(nullable: true),
                    CssUnitCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitHas", x => x.Code);
                    table.ForeignKey(
                        name: "FK_UnitHas_Unit_CssUnitCode",
                        column: x => x.CssUnitCode,
                        principalTable: "Unit",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitHas_Item_RentalAmountCode",
                        column: x => x.RentalAmountCode,
                        principalTable: "Item",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnitHas_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    AddressCode = table.Column<int>(nullable: true),
                    PhoneCode = table.Column<int>(nullable: true),
                    EmailCode = table.Column<int>(nullable: true),
                    SocialNetworkCode = table.Column<int>(nullable: true),
                    PicCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Person_Address_AddressCode",
                        column: x => x.AddressCode,
                        principalTable: "Address",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Email_EmailCode",
                        column: x => x.EmailCode,
                        principalTable: "Email",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Phone_PhoneCode",
                        column: x => x.PhoneCode,
                        principalTable: "Phone",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_BuildPic_PicCode",
                        column: x => x.PicCode,
                        principalTable: "BuildPic",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_General_SocialNetworkCode",
                        column: x => x.SocialNetworkCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CityCode",
                table: "Address",
                column: "CityCode");

            migrationBuilder.CreateIndex(
                name: "IX_Building_AddressCode",
                table: "Building",
                column: "AddressCode");

            migrationBuilder.CreateIndex(
                name: "IX_Building_BuldingTypeCode",
                table: "Building",
                column: "BuldingTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Building_PhoneCode",
                table: "Building",
                column: "PhoneCode");

            migrationBuilder.CreateIndex(
                name: "IX_Building_StatusCode",
                table: "Building",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_BuildPic_CssItemCode",
                table: "BuildPic",
                column: "CssItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_BuildPic_cssBuildingCode",
                table: "BuildPic",
                column: "cssBuildingCode");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateCode",
                table: "City",
                column: "StateCode");

            migrationBuilder.CreateIndex(
                name: "IX_General_KindCode",
                table: "General",
                column: "KindCode");

            migrationBuilder.CreateIndex(
                name: "IX_General_cssBuildingCode",
                table: "General",
                column: "cssBuildingCode");

            migrationBuilder.CreateIndex(
                name: "IX_General_cssBuildingCode1",
                table: "General",
                column: "cssBuildingCode1");

            migrationBuilder.CreateIndex(
                name: "IX_General_cssBuildingCode2",
                table: "General",
                column: "cssBuildingCode2");

            migrationBuilder.CreateIndex(
                name: "IX_General_cssBuildingCode3",
                table: "General",
                column: "cssBuildingCode3");

            migrationBuilder.CreateIndex(
                name: "IX_Item_StatusCode",
                table: "Item",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Item_StoreUnitCode",
                table: "Item",
                column: "StoreUnitCode");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AddressCode",
                table: "Person",
                column: "AddressCode");

            migrationBuilder.CreateIndex(
                name: "IX_Person_EmailCode",
                table: "Person",
                column: "EmailCode");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PhoneCode",
                table: "Person",
                column: "PhoneCode");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PicCode",
                table: "Person",
                column: "PicCode");

            migrationBuilder.CreateIndex(
                name: "IX_Person_SocialNetworkCode",
                table: "Person",
                column: "SocialNetworkCode");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryCode",
                table: "State",
                column: "CountryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_cssBuildingCode",
                table: "Unit",
                column: "cssBuildingCode");

            migrationBuilder.CreateIndex(
                name: "IX_UnitHas_CssUnitCode",
                table: "UnitHas",
                column: "CssUnitCode");

            migrationBuilder.CreateIndex(
                name: "IX_UnitHas_RentalAmountCode",
                table: "UnitHas",
                column: "RentalAmountCode");

            migrationBuilder.CreateIndex(
                name: "IX_UnitHas_StatusCode",
                table: "UnitHas",
                column: "StatusCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_General_BuldingTypeCode",
                table: "Building",
                column: "BuldingTypeCode",
                principalTable: "General",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Building_General_StatusCode",
                table: "Building",
                column: "StatusCode",
                principalTable: "General",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_City_CityCode",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_Address_AddressCode",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_General_BuldingTypeCode",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_General_StatusCode",
                table: "Building");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UnitHas");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "BuildPic");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "General");

            migrationBuilder.DropTable(
                name: "Kind");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Phone");
        }
    }
}

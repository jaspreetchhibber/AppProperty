using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyDB.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildPic_Building_cssBuildingCode",
                table: "BuildPic");

            migrationBuilder.DropForeignKey(
                name: "FK_General_Building_cssBuildingCode",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_General_Building_cssBuildingCode1",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_General_Building_cssBuildingCode2",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_General_Building_cssBuildingCode3",
                table: "General");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Building_cssBuildingCode",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_UnitHas_Item_RentalAmountCode",
                table: "UnitHas");

            migrationBuilder.DropIndex(
                name: "IX_UnitHas_RentalAmountCode",
                table: "UnitHas");

            migrationBuilder.DropIndex(
                name: "IX_General_cssBuildingCode",
                table: "General");

            migrationBuilder.DropIndex(
                name: "IX_General_cssBuildingCode1",
                table: "General");

            migrationBuilder.DropIndex(
                name: "IX_General_cssBuildingCode2",
                table: "General");

            migrationBuilder.DropIndex(
                name: "IX_General_cssBuildingCode3",
                table: "General");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "User");

            migrationBuilder.DropColumn(
                name: "User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RentalAmountCode",
                table: "UnitHas");

            migrationBuilder.DropColumn(
                name: "Kind",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "cssBuildingCode",
                table: "General");

            migrationBuilder.DropColumn(
                name: "cssBuildingCode1",
                table: "General");

            migrationBuilder.DropColumn(
                name: "cssBuildingCode2",
                table: "General");

            migrationBuilder.DropColumn(
                name: "cssBuildingCode3",
                table: "General");

            migrationBuilder.RenameColumn(
                name: "cssBuildingCode",
                table: "Unit",
                newName: "CssBuildingCode");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_cssBuildingCode",
                table: "Unit",
                newName: "IX_Unit_CssBuildingCode");

            migrationBuilder.RenameColumn(
                name: "cssBuildingCode",
                table: "BuildPic",
                newName: "CssBuildingCode");

            migrationBuilder.RenameIndex(
                name: "IX_BuildPic_cssBuildingCode",
                table: "BuildPic",
                newName: "IX_BuildPic_CssBuildingCode");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleCode",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "User",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "StatusCode",
                table: "Unit",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Role",
                type: "Varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KindCode",
                table: "Role",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Role",
                type: "Varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CssUnitHasCode",
                table: "Item",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KindAmenitiesCode = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatusCode = table.Column<int>(nullable: true),
                    CssUnitCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Amenities_Unit_CssUnitCode",
                        column: x => x.CssUnitCode,
                        principalTable: "Unit",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Amenities_General_KindAmenitiesCode",
                        column: x => x.KindAmenitiesCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Amenities_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleCode",
                table: "User",
                column: "RoleCode");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_StatusCode",
                table: "Unit",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Role_KindCode",
                table: "Role",
                column: "KindCode");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CssUnitHasCode",
                table: "Item",
                column: "CssUnitHasCode");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_CssUnitCode",
                table: "Amenities",
                column: "CssUnitCode");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_KindAmenitiesCode",
                table: "Amenities",
                column: "KindAmenitiesCode");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_StatusCode",
                table: "Amenities",
                column: "StatusCode");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildPic_Building_CssBuildingCode",
                table: "BuildPic",
                column: "CssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_UnitHas_CssUnitHasCode",
                table: "Item",
                column: "CssUnitHasCode",
                principalTable: "UnitHas",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_General_KindCode",
                table: "Role",
                column: "KindCode",
                principalTable: "General",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Building_CssBuildingCode",
                table: "Unit",
                column: "CssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_General_StatusCode",
                table: "Unit",
                column: "StatusCode",
                principalTable: "General",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleCode",
                table: "User",
                column: "RoleCode",
                principalTable: "Role",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildPic_Building_CssBuildingCode",
                table: "BuildPic");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_UnitHas_CssUnitHasCode",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_General_KindCode",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Building_CssBuildingCode",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_General_StatusCode",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleCode",
                table: "User");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleCode",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Unit_StatusCode",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_Role_KindCode",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Item_CssUnitHasCode",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoleCode",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "StatusCode",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "KindCode",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CssUnitHasCode",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "CssBuildingCode",
                table: "Unit",
                newName: "cssBuildingCode");

            migrationBuilder.RenameIndex(
                name: "IX_Unit_CssBuildingCode",
                table: "Unit",
                newName: "IX_Unit_cssBuildingCode");

            migrationBuilder.RenameColumn(
                name: "CssBuildingCode",
                table: "BuildPic",
                newName: "cssBuildingCode");

            migrationBuilder.RenameIndex(
                name: "IX_BuildPic_CssBuildingCode",
                table: "BuildPic",
                newName: "IX_BuildPic_cssBuildingCode");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "User",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RentalAmountCode",
                table: "UnitHas",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Role",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(100)");

            migrationBuilder.AddColumn<int>(
                name: "Kind",
                table: "Role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cssBuildingCode",
                table: "General",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cssBuildingCode1",
                table: "General",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cssBuildingCode2",
                table: "General",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cssBuildingCode3",
                table: "General",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnitHas_RentalAmountCode",
                table: "UnitHas",
                column: "RentalAmountCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BuildPic_Building_cssBuildingCode",
                table: "BuildPic",
                column: "cssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_General_Building_cssBuildingCode",
                table: "General",
                column: "cssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_General_Building_cssBuildingCode1",
                table: "General",
                column: "cssBuildingCode1",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_General_Building_cssBuildingCode2",
                table: "General",
                column: "cssBuildingCode2",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_General_Building_cssBuildingCode3",
                table: "General",
                column: "cssBuildingCode3",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Building_cssBuildingCode",
                table: "Unit",
                column: "cssBuildingCode",
                principalTable: "Building",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnitHas_Item_RentalAmountCode",
                table: "UnitHas",
                column: "RentalAmountCode",
                principalTable: "Item",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

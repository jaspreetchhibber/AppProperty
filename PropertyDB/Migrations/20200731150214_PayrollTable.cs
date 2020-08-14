using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyDB.Migrations
{
    public partial class PayrollTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BeneficioCode = table.Column<int>(nullable: true),
                    DesdeFecha = table.Column<DateTime>(nullable: false),
                    HastaFecha = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Observacion = table.Column<string>(type: "Varchar(255)", nullable: true),
                    EstatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Benefit_General_BeneficioCode",
                        column: x => x.BeneficioCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Benefit_General_EstatusCode",
                        column: x => x.EstatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compensation",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    CompensationKindCode = table.Column<int>(nullable: true),
                    CompensationAmount = table.Column<decimal>(nullable: false),
                    DatePay = table.Column<decimal>(nullable: false),
                    EstatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compensation", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Compensation_General_CompensationKindCode",
                        column: x => x.CompensationKindCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compensation_General_EstatusCode",
                        column: x => x.EstatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reponsability",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    ResponsabilityKindCode = table.Column<int>(nullable: true),
                    OriginalAmount = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    PayAmount = table.Column<decimal>(nullable: false),
                    DealAmount = table.Column<decimal>(nullable: false),
                    DateResponsability = table.Column<DateTime>(nullable: false),
                    FrequencyCode = table.Column<int>(nullable: true),
                    StatusCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reponsability", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Reponsability_General_FrequencyCode",
                        column: x => x.FrequencyCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reponsability_General_ResponsabilityKindCode",
                        column: x => x.ResponsabilityKindCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reponsability_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserCode = table.Column<int>(nullable: true),
                    PayrollKindCode = table.Column<int>(nullable: true),
                    PositionCode = table.Column<int>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    SalaryHistoryCode = table.Column<int>(nullable: true),
                    StatusCode = table.Column<int>(nullable: true),
                    Pic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Employee_General_PayrollKindCode",
                        column: x => x.PayrollKindCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_General_PositionCode",
                        column: x => x.PositionCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Salary_SalaryHistoryCode",
                        column: x => x.SalaryHistoryCode,
                        principalTable: "Salary",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_General_StatusCode",
                        column: x => x.StatusCode,
                        principalTable: "General",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_User_UserCode",
                        column: x => x.UserCode,
                        principalTable: "User",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_BeneficioCode",
                table: "Benefit",
                column: "BeneficioCode");

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_EstatusCode",
                table: "Benefit",
                column: "EstatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Compensation_CompensationKindCode",
                table: "Compensation",
                column: "CompensationKindCode");

            migrationBuilder.CreateIndex(
                name: "IX_Compensation_EstatusCode",
                table: "Compensation",
                column: "EstatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PayrollKindCode",
                table: "Employee",
                column: "PayrollKindCode");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionCode",
                table: "Employee",
                column: "PositionCode");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_SalaryHistoryCode",
                table: "Employee",
                column: "SalaryHistoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_StatusCode",
                table: "Employee",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserCode",
                table: "Employee",
                column: "UserCode");

            migrationBuilder.CreateIndex(
                name: "IX_Reponsability_FrequencyCode",
                table: "Reponsability",
                column: "FrequencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Reponsability_ResponsabilityKindCode",
                table: "Reponsability",
                column: "ResponsabilityKindCode");

            migrationBuilder.CreateIndex(
                name: "IX_Reponsability_StatusCode",
                table: "Reponsability",
                column: "StatusCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Benefit");

            migrationBuilder.DropTable(
                name: "Compensation");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Reponsability");

            migrationBuilder.DropTable(
                name: "Salary");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolidCP.EnterpriseServer.Data.Migrations.SqlServer
{
    /// <inheritdoc />
    public partial class AddedMailDomainQuotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageServices_Packages",
                table: "PackageServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageServices_Services",
                table: "PackageServices");

            migrationBuilder.DeleteData(
                table: "Providers",
                keyColumn: "ProviderID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ResourceGroups",
                keyColumn: "GroupID",
                keyValue: 42);

            migrationBuilder.AlterColumn<double>(
                name: "QuotaOrder",
                table: "Quotas",
                type: "float",
                nullable: false,
                defaultValue: 1.0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 2,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 3,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 4,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 12,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 13,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 14,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 15,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 18,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 19,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 20,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 24,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 25,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 26,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 27,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 28,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 29,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 30,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 31,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 32,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 33,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 34,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 35,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 36,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 37,
                column: "QuotaOrder",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 38,
                column: "QuotaOrder",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 39,
                column: "QuotaOrder",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 40,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 41,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 42,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 43,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 44,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 45,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 47,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 48,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 49,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 50,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 51,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 52,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 53,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 54,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 55,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 57,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 58,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 59,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 60,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 61,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 62,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 63,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 64,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 65,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 66,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 67,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 68,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 69,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 70,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 71,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 72,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 73,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 74,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 75,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 77,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 78,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 79,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 80,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 81,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 83,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 84,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 85,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 86,
                column: "QuotaOrder",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 87,
                column: "QuotaOrder",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 88,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 94,
                column: "QuotaOrder",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 96,
                column: "QuotaOrder",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 97,
                column: "QuotaOrder",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 100,
                column: "QuotaOrder",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 102,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 103,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 104,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 105,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 106,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 107,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 108,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 110,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 111,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 112,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 113,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 114,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 115,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 120,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 121,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 122,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 123,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 124,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 125,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 200,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 203,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 204,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 205,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 206,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 207,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 208,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 209,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 210,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 211,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 212,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 213,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 214,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 215,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 216,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 217,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 218,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 219,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 220,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 221,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 222,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 223,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 224,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 225,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 230,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 300,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 301,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 302,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 303,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 304,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 305,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 306,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 307,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 308,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 309,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 310,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 311,
                column: "QuotaOrder",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 312,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 313,
                column: "QuotaOrder",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 314,
                column: "QuotaOrder",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 315,
                column: "QuotaOrder",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 316,
                column: "QuotaOrder",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 317,
                column: "QuotaOrder",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 318,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 319,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 320,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 321,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 322,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 323,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 324,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 325,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 326,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 327,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 328,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 329,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 330,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 331,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 332,
                column: "QuotaOrder",
                value: 21.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 333,
                column: "QuotaOrder",
                value: 22.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 334,
                column: "QuotaOrder",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 344,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 345,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 346,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 347,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 348,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 349,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 350,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 351,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 352,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 353,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 354,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 355,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 356,
                column: "QuotaOrder",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 357,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 358,
                column: "QuotaOrder",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 359,
                column: "QuotaOrder",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 360,
                column: "QuotaOrder",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 361,
                column: "QuotaOrder",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 362,
                column: "QuotaOrder",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 363,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 364,
                column: "QuotaOrder",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 365,
                column: "QuotaOrder",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 366,
                column: "QuotaOrder",
                value: 21.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 367,
                column: "QuotaOrder",
                value: 22.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 368,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 369,
                column: "QuotaOrder",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 370,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 371,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 372,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 373,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 374,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 375,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 376,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 377,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 378,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 379,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 380,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 381,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 400,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 409,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 410,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 411,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 420,
                column: "QuotaOrder",
                value: 24.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 421,
                column: "QuotaOrder",
                value: 25.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 422,
                column: "QuotaOrder",
                value: 26.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 423,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 424,
                column: "QuotaOrder",
                value: 27.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 425,
                column: "QuotaOrder",
                value: 29.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 426,
                column: "QuotaOrder",
                value: 28.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 428,
                column: "QuotaOrder",
                value: 31.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 429,
                column: "QuotaOrder",
                value: 30.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 430,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 431,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 447,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 448,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 450,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 451,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 452,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 453,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 460,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 461,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 462,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 463,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 464,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 465,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 466,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 467,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 468,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 470,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 471,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 472,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 473,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 474,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 475,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 476,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 491,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 495,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 496,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 550,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 551,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 552,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 553,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 554,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 555,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 556,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 557,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 558,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 559,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 560,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 561,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 562,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 563,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 564,
                column: "QuotaOrder",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 565,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 566,
                column: "QuotaOrder",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 567,
                column: "QuotaOrder",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 568,
                column: "QuotaOrder",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 569,
                column: "QuotaOrder",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 570,
                column: "QuotaOrder",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 571,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 572,
                column: "QuotaOrder",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 573,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 574,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 575,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 576,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 577,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 578,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 579,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 581,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 582,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 583,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 584,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 585,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 586,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 587,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 588,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 589,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 590,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 591,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 592,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 673,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 674,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 675,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 676,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 677,
                column: "QuotaOrder",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 678,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 679,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 680,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 681,
                column: "QuotaOrder",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 682,
                column: "QuotaOrder",
                value: 11.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 683,
                column: "QuotaOrder",
                value: 13.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 684,
                column: "QuotaOrder",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 685,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 686,
                column: "QuotaOrder",
                value: 15.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 687,
                column: "QuotaOrder",
                value: 16.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 688,
                column: "QuotaOrder",
                value: 17.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 689,
                column: "QuotaOrder",
                value: 18.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 690,
                column: "QuotaOrder",
                value: 19.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 691,
                column: "QuotaOrder",
                value: 12.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 692,
                column: "QuotaOrder",
                value: 20.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 701,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 702,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 703,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 704,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 705,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 706,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 707,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 711,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 712,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 713,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 714,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 715,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 716,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 717,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 721,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 722,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 723,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 724,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 725,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 726,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 727,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 728,
                column: "QuotaOrder",
                value: 14.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 729,
                column: "QuotaOrder",
                value: 32.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 730,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 731,
                column: "QuotaOrder",
                value: 31.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 732,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 733,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 734,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 735,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 736,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 737,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 738,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 750,
                column: "QuotaOrder",
                value: 22.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 751,
                column: "QuotaOrder",
                value: 23.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 752,
                column: "QuotaOrder",
                value: 24.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 753,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 754,
                column: "QuotaOrder",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 760,
                column: "QuotaOrder",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 761,
                column: "QuotaOrder",
                value: 2.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 762,
                column: "QuotaOrder",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 763,
                column: "QuotaOrder",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 764,
                column: "QuotaOrder",
                value: 6.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 765,
                column: "QuotaOrder",
                value: 7.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 766,
                column: "QuotaOrder",
                value: 4.0);

            migrationBuilder.InsertData(
                table: "Quotas",
                columns: new[] { "QuotaID", "GroupID", "HideQuota", "ItemTypeID", "PerOrganization", "QuotaDescription", "QuotaName", "QuotaOrder", "QuotaTypeID", "ServiceQuota" },
                values: new object[,]
                {
                    { 770, 4, null, 11, null, "Mail Domains", "Mail.Domains", 2.1000000000000001, 2, true },
                    { 771, 4, null, null, null, "Mail Accounts per Domain", "Mail.Accounts.per.Domains", 2.2000000000000002, 2, true }
                });

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "PublishingProfile", "WebPolicy", 1 },
                column: "PropertyValue",
                value: "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<publishData>\r\n<ad:if test=\"#WebSite.WebDeploySitePublishingEnabled#\">\r\n	<publishProfile\r\n		profileName=\"#WebSite.Name# - Web Deploy\"\r\n		publishMethod=\"MSDeploy\"\r\n		publishUrl=\"#WebSite[\"WmSvcServiceUrl\"]#:#WebSite[\"WmSvcServicePort\"]#\"\r\n		msdeploySite=\"#WebSite.Name#\"\r\n		userName=\"#WebSite.WebDeployPublishingAccount#\"\r\n		userPWD=\"#WebSite.WebDeployPublishingPassword#\"\r\n		destinationAppUrl=\"http://#WebSite.Name#/\"\r\n		<ad:if test=\"#Not(IsNull(MsSqlDatabase)) and Not(IsNull(MsSqlUser))#\">SQLServerDBConnectionString=\"server=#MsSqlServerExternalAddress#;Initial Catalog=#MsSqlDatabase.Name#;uid=#MsSqlUser.Name#;pwd=#MsSqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MySqlDatabase)) and Not(IsNull(MySqlUser))#\">mySQLDBConnectionString=\"server=#MySqlAddress#;database=#MySqlDatabase.Name#;uid=#MySqlUser.Name#;pwd=#MySqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MariaDBDatabase)) and Not(IsNull(MariaDBUser))#\">MariaDBDBConnectionString=\"server=#MariaDBAddress#;database=#MariaDBDatabase.Name#;uid=#MariaDBUser.Name#;pwd=#MariaDBUser.Password#\"</ad:if>\r\n		hostingProviderForumLink=\"https://solidcp.com/support\"\r\n		controlPanelLink=\"https://panel.solidcp.com/\"\r\n	/>\r\n</ad:if>\r\n<ad:if test=\"#IsDefined(\"FtpAccount\")#\">\r\n	<publishProfile\r\n		profileName=\"#WebSite.Name# - FTP\"\r\n		publishMethod=\"FTP\"\r\n		publishUrl=\"ftp://#FtpServiceAddress#\"\r\n		ftpPassiveMode=\"True\"\r\n		userName=\"#FtpAccount.Name#\"\r\n		userPWD=\"#FtpAccount.Password#\"\r\n		destinationAppUrl=\"http://#WebSite.Name#/\"\r\n		<ad:if test=\"#Not(IsNull(MsSqlDatabase)) and Not(IsNull(MsSqlUser))#\">SQLServerDBConnectionString=\"server=#MsSqlServerExternalAddress#;Initial Catalog=#MsSqlDatabase.Name#;uid=#MsSqlUser.Name#;pwd=#MsSqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MySqlDatabase)) and Not(IsNull(MySqlUser))#\">mySQLDBConnectionString=\"server=#MySqlAddress#;database=#MySqlDatabase.Name#;uid=#MySqlUser.Name#;pwd=#MySqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MariaDBDatabase)) and Not(IsNull(MariaDBUser))#\">MariaDBDBConnectionString=\"server=#MariaDBAddress#;database=#MariaDBDatabase.Name#;uid=#MariaDBUser.Name#;pwd=#MariaDBUser.Password#\"</ad:if>\r\n		hostingProviderForumLink=\"https://solidcp.com/support\"\r\n		controlPanelLink=\"https://panel.solidcp.com/\"\r\n    />\r\n</ad:if>\r\n</publishData>\r\n\r\n<!--\r\nControl Panel:\r\nUsername: #User.Username#\r\nPassword: #User.Password#\r\n\r\nTechnical Contact:\r\nsupport@solidcp.com\r\n-->");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageServices_Packages",
                table: "PackageServices",
                column: "PackageID",
                principalTable: "Packages",
                principalColumn: "PackageID");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageServices_Services",
                table: "PackageServices",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "ServiceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageServices_Packages",
                table: "PackageServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PackageServices_Services",
                table: "PackageServices");

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 771);

            migrationBuilder.AlterColumn<int>(
                name: "QuotaOrder",
                table: "Quotas",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(double),
                oldType: "float",
                oldDefaultValue: 1.0);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 2,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 3,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 4,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 12,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 13,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 14,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 15,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 18,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 19,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 20,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 24,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 25,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 26,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 27,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 28,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 29,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 30,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 31,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 32,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 33,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 34,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 35,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 36,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 37,
                column: "QuotaOrder",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 38,
                column: "QuotaOrder",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 39,
                column: "QuotaOrder",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 40,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 41,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 42,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 43,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 44,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 45,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 47,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 48,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 49,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 50,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 51,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 52,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 53,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 54,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 55,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 57,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 58,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 59,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 60,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 61,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 62,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 63,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 64,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 65,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 66,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 67,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 68,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 69,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 70,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 71,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 72,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 73,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 74,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 75,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 77,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 78,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 79,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 80,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 81,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 83,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 84,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 85,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 86,
                column: "QuotaOrder",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 87,
                column: "QuotaOrder",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 88,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 94,
                column: "QuotaOrder",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 96,
                column: "QuotaOrder",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 97,
                column: "QuotaOrder",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 100,
                column: "QuotaOrder",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 102,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 103,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 104,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 105,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 106,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 107,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 108,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 110,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 111,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 112,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 113,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 114,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 115,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 120,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 121,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 122,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 123,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 124,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 125,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 200,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 203,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 204,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 205,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 206,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 207,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 208,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 209,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 210,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 211,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 212,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 213,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 214,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 215,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 216,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 217,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 218,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 219,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 220,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 221,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 222,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 223,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 224,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 225,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 230,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 300,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 301,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 302,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 303,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 304,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 305,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 306,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 307,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 308,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 309,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 310,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 311,
                column: "QuotaOrder",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 312,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 313,
                column: "QuotaOrder",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 314,
                column: "QuotaOrder",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 315,
                column: "QuotaOrder",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 316,
                column: "QuotaOrder",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 317,
                column: "QuotaOrder",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 318,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 319,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 320,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 321,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 322,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 323,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 324,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 325,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 326,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 327,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 328,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 329,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 330,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 331,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 332,
                column: "QuotaOrder",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 333,
                column: "QuotaOrder",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 334,
                column: "QuotaOrder",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 344,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 345,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 346,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 347,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 348,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 349,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 350,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 351,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 352,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 353,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 354,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 355,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 356,
                column: "QuotaOrder",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 357,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 358,
                column: "QuotaOrder",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 359,
                column: "QuotaOrder",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 360,
                column: "QuotaOrder",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 361,
                column: "QuotaOrder",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 362,
                column: "QuotaOrder",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 363,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 364,
                column: "QuotaOrder",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 365,
                column: "QuotaOrder",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 366,
                column: "QuotaOrder",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 367,
                column: "QuotaOrder",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 368,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 369,
                column: "QuotaOrder",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 370,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 371,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 372,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 373,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 374,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 375,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 376,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 377,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 378,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 379,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 380,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 381,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 400,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 409,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 410,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 411,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 420,
                column: "QuotaOrder",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 421,
                column: "QuotaOrder",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 422,
                column: "QuotaOrder",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 423,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 424,
                column: "QuotaOrder",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 425,
                column: "QuotaOrder",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 426,
                column: "QuotaOrder",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 428,
                column: "QuotaOrder",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 429,
                column: "QuotaOrder",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 430,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 431,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 447,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 448,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 450,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 451,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 452,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 453,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 460,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 461,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 462,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 463,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 464,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 465,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 466,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 467,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 468,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 470,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 471,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 472,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 473,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 474,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 475,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 476,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 491,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 495,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 496,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 550,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 551,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 552,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 553,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 554,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 555,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 556,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 557,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 558,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 559,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 560,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 561,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 562,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 563,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 564,
                column: "QuotaOrder",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 565,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 566,
                column: "QuotaOrder",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 567,
                column: "QuotaOrder",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 568,
                column: "QuotaOrder",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 569,
                column: "QuotaOrder",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 570,
                column: "QuotaOrder",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 571,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 572,
                column: "QuotaOrder",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 573,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 574,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 575,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 576,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 577,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 578,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 579,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 581,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 582,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 583,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 584,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 585,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 586,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 587,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 588,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 589,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 590,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 591,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 592,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 673,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 674,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 675,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 676,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 677,
                column: "QuotaOrder",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 678,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 679,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 680,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 681,
                column: "QuotaOrder",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 682,
                column: "QuotaOrder",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 683,
                column: "QuotaOrder",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 684,
                column: "QuotaOrder",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 685,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 686,
                column: "QuotaOrder",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 687,
                column: "QuotaOrder",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 688,
                column: "QuotaOrder",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 689,
                column: "QuotaOrder",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 690,
                column: "QuotaOrder",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 691,
                column: "QuotaOrder",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 692,
                column: "QuotaOrder",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 701,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 702,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 703,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 704,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 705,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 706,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 707,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 711,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 712,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 713,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 714,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 715,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 716,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 717,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 721,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 722,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 723,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 724,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 725,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 726,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 727,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 728,
                column: "QuotaOrder",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 729,
                column: "QuotaOrder",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 730,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 731,
                column: "QuotaOrder",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 732,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 733,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 734,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 735,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 736,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 737,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 738,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 750,
                column: "QuotaOrder",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 751,
                column: "QuotaOrder",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 752,
                column: "QuotaOrder",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 753,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 754,
                column: "QuotaOrder",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 760,
                column: "QuotaOrder",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 761,
                column: "QuotaOrder",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 762,
                column: "QuotaOrder",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 763,
                column: "QuotaOrder",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 764,
                column: "QuotaOrder",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 765,
                column: "QuotaOrder",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Quotas",
                keyColumn: "QuotaID",
                keyValue: 766,
                column: "QuotaOrder",
                value: 4);

            migrationBuilder.InsertData(
                table: "Quotas",
                columns: new[] { "QuotaID", "GroupID", "HideQuota", "ItemTypeID", "PerOrganization", "QuotaDescription", "QuotaName", "QuotaOrder", "QuotaTypeID", "ServiceQuota" },
                values: new object[] { 95, 2, null, null, null, "Web Application Gallery", "Web.WebAppGallery", 1, 1, false });

            migrationBuilder.InsertData(
                table: "ResourceGroups",
                columns: new[] { "GroupID", "GroupController", "GroupName", "GroupOrder", "ShowGroup" },
                values: new object[] { 42, "SolidCP.EnterpriseServer.HeliconZooController", "HeliconZoo", 2, true });

            migrationBuilder.UpdateData(
                table: "UserSettings",
                keyColumns: new[] { "PropertyName", "SettingsName", "UserID" },
                keyValues: new object[] { "PublishingProfile", "WebPolicy", 1 },
                column: "PropertyValue",
                value: "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<publishData>\r\n<ad:if test=\"#WebSite.WebDeploySitePublishingEnabled#\">\r\n	<publishProfile\r\n		profileName=\"#WebSite.Name# - Web Deploy\"\r\n		publishMethod=\"MSDeploy\"\r\n		publishUrl=\"#WebSite[\"WmSvcServiceUrl\"]#:#WebSite[\"WmSvcServicePort\"]#\"\r\n		msdeploySite=\"#WebSite.Name#\"\r\n		userName=\"#WebSite.WebDeployPublishingAccount#\"\r\n		userPWD=\"#WebSite.WebDeployPublishingPassword#\"\r\n		destinationAppUrl=\"http://#WebSite.Name#/\"\r\n		<ad:if test=\"#Not(IsNull(MsSqlDatabase)) and Not(IsNull(MsSqlUser))#\">SQLServerDBConnectionString=\"server=#MsSqlServerExternalAddress#;database=#MsSqlDatabase.Name#;uid=#MsSqlUser.Name#;pwd=#MsSqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MySqlDatabase)) and Not(IsNull(MySqlUser))#\">mySQLDBConnectionString=\"server=#MySqlAddress#;database=#MySqlDatabase.Name#;uid=#MySqlUser.Name#;pwd=#MySqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MariaDBDatabase)) and Not(IsNull(MariaDBUser))#\">MariaDBDBConnectionString=\"server=#MariaDBAddress#;database=#MariaDBDatabase.Name#;uid=#MariaDBUser.Name#;pwd=#MariaDBUser.Password#\"</ad:if>\r\n		hostingProviderForumLink=\"https://solidcp.com/support\"\r\n		controlPanelLink=\"https://panel.solidcp.com/\"\r\n	/>\r\n</ad:if>\r\n<ad:if test=\"#IsDefined(\"FtpAccount\")#\">\r\n	<publishProfile\r\n		profileName=\"#WebSite.Name# - FTP\"\r\n		publishMethod=\"FTP\"\r\n		publishUrl=\"ftp://#FtpServiceAddress#\"\r\n		ftpPassiveMode=\"True\"\r\n		userName=\"#FtpAccount.Name#\"\r\n		userPWD=\"#FtpAccount.Password#\"\r\n		destinationAppUrl=\"http://#WebSite.Name#/\"\r\n		<ad:if test=\"#Not(IsNull(MsSqlDatabase)) and Not(IsNull(MsSqlUser))#\">SQLServerDBConnectionString=\"server=#MsSqlServerExternalAddress#;database=#MsSqlDatabase.Name#;uid=#MsSqlUser.Name#;pwd=#MsSqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MySqlDatabase)) and Not(IsNull(MySqlUser))#\">mySQLDBConnectionString=\"server=#MySqlAddress#;database=#MySqlDatabase.Name#;uid=#MySqlUser.Name#;pwd=#MySqlUser.Password#\"</ad:if>\r\n		<ad:if test=\"#Not(IsNull(MariaDBDatabase)) and Not(IsNull(MariaDBUser))#\">MariaDBDBConnectionString=\"server=#MariaDBAddress#;database=#MariaDBDatabase.Name#;uid=#MariaDBUser.Name#;pwd=#MariaDBUser.Password#\"</ad:if>\r\n		hostingProviderForumLink=\"https://solidcp.com/support\"\r\n		controlPanelLink=\"https://panel.solidcp.com/\"\r\n    />\r\n</ad:if>\r\n</publishData>\r\n\r\n<!--\r\nControl Panel:\r\nUsername: #User.Username#\r\nPassword: #User.Password#\r\n\r\nTechnical Contact:\r\nsupport@solidcp.com\r\n-->");

            migrationBuilder.InsertData(
                table: "Providers",
                columns: new[] { "ProviderID", "DisableAutoDiscovery", "DisplayName", "EditorControl", "GroupID", "ProviderName", "ProviderType" },
                values: new object[] { 135, true, "Web Application Engines", "HeliconZoo", 42, "HeliconZoo", "SolidCP.Providers.Web.HeliconZoo.HeliconZoo, SolidCP.Providers.Web.HeliconZoo" });

            migrationBuilder.AddForeignKey(
                name: "FK_PackageServices_Packages",
                table: "PackageServices",
                column: "PackageID",
                principalTable: "Packages",
                principalColumn: "PackageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PackageServices_Services",
                table: "PackageServices",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

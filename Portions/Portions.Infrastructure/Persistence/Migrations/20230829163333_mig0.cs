using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portions.Infrastructure.Migrations;

/// <inheritdoc />
public partial class mig0 : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Portions",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                VerseText = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Portions", x => x.Id);
            });

        migrationBuilder.InsertData(
            table: "Portions",
            columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "VerseText" },
            values: new object[,]
            {
                { new Guid("0beea15d-a687-4a01-b53b-72bd246f141a"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(8990), "0beea15d-a687-4a01-b53b-72bd246f141a - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                { new Guid("26e53cb4-4d06-4fd9-8b52-ec3cb8e6d3b5"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9079), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9082), "26e53cb4-4d06-4fd9-8b52-ec3cb8e6d3b5 - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                { new Guid("2984a841-7df6-4500-ac7a-b89e430acd1a"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9068), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9071), "2984a841-7df6-4500-ac7a-b89e430acd1a - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                { new Guid("2ee27b01-4921-4f6b-b544-1c5a1847c390"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9276), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9278), "2ee27b01-4921-4f6b-b544-1c5a1847c390 - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                { new Guid("9472365c-b7ce-4a05-bf86-4e514f8e00e8"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9199), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9203), "9472365c-b7ce-4a05-bf86-4e514f8e00e8 - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                { new Guid("c416e5b7-fdbb-4ee4-8d87-4101b527f895"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9054), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9057), "c416e5b7-fdbb-4ee4-8d87-4101b527f895 - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." },
                { new Guid("c4e8ed88-28ff-4001-8df4-001dfc82d502"), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9264), new DateTime(2023, 8, 29, 11, 33, 33, 802, DateTimeKind.Local).AddTicks(9267), "c4e8ed88-28ff-4001-8df4-001dfc82d502 - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Portions");
    }
}

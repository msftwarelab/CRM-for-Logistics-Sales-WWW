using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.EntityFrameworkPersistence.Migrations.Shared
{
    /// <inheritdoc />
    public partial class AddLinkGlobalUserToStripeCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LinkSubscriberToStripeCustomer",
                columns: table => new
                {
                    SubscriberId = table.Column<int>(type: "int", nullable: false),
                    StripeCustomerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LinkSubscriberToStripeCustomer", x => x.SubscriberId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LinkSubscriberToStripeCustomer_GlobalUserId",
                table: "LinkSubscriberToStripeCustomer",
                column: "SubscriberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LinkSubscriberToStripeCustomer");
        }
    }
}

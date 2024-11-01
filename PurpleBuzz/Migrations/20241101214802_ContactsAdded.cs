using Microsoft.EntityFrameworkCore.Migrations;

public partial class AddContactsTable : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Contacts",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Role = table.Column<string>(type: "nvarchar(100)", nullable: false),
                Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                Phone = table.Column<string>(type: "nvarchar(50)", nullable: false),
                IconClass = table.Column<string>(type: "nvarchar(50)", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Contacts", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Contacts");
    }
}

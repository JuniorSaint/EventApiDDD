using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Events_EventId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Events_EventId1",
                table: "SocialMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Speakers_SpeakerId1",
                table: "SocialMedias");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dda95fde-f240-4ff9-8fa8-6237f717de23"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "Password", "UpdatedAt", "UserName", "UserType" },
                values: new object[] { new Guid("416ec1c0-2945-4bf3-80a1-6b0f6ee978bd"), new DateTime(2021, 10, 1, 8, 46, 3, 928, DateTimeKind.Local).AddTicks(240), "junior.saint@gmail.com", true, "123456", new DateTime(2021, 10, 1, 8, 46, 3, 949, DateTimeKind.Local).AddTicks(3000), "Junior", "administrator" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Events_EventId",
                table: "Lots",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Events_EventId1",
                table: "SocialMedias",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Speakers_SpeakerId1",
                table: "SocialMedias",
                column: "SpeakerId1",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lots_Events_EventId",
                table: "Lots");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Events_EventId1",
                table: "SocialMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Speakers_SpeakerId1",
                table: "SocialMedias");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("416ec1c0-2945-4bf3-80a1-6b0f6ee978bd"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsActive", "Password", "UpdatedAt", "UserName", "UserType" },
                values: new object[] { new Guid("dda95fde-f240-4ff9-8fa8-6237f717de23"), new DateTime(2021, 9, 27, 16, 42, 15, 253, DateTimeKind.Local).AddTicks(4640), "junior.saint@gmail.com", true, "123456", new DateTime(2021, 9, 27, 16, 42, 15, 272, DateTimeKind.Local).AddTicks(750), "Junior", "administrator" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lots_Events_EventId",
                table: "Lots",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Events_EventId1",
                table: "SocialMedias",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Speakers_SpeakerId1",
                table: "SocialMedias",
                column: "SpeakerId1",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

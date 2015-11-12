using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace BreakFasts.Migrations
{
    public partial class Diego1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "Address", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "City", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "PostalCode", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "State", table: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SamurailApp.Data.Migrations
{
    public partial class SamuraiBattleState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION[dbo].[EarliestBattleFoughtBySamurai](@samuraiId int)
                RETURNS char(30) AS
                BEGIN
                  DECLARE @ret char(30)
                  SELECT TOP 1 @ret = Name
                  FROM Battles
                  WHERE Battles.BattleId IN(SELECT BattleId
                                     FROM BattleSamurais
                                    WHERE SamuraiId = @samuraiId)
                  RETURN @ret
                END");

            //--------------------
            migrationBuilder.Sql(@" CREATE VIEW dbo.SamuraiBattleStats
              AS
              SELECT dbo.Samurais.Name,
              COUNT(dbo.BattleSamurais.BattleId) AS NumberOfBattles,
                      dbo.EarliestBattleFoughtBySamurai(MIN(dbo.Samurais.Id)) 
		  	     AS EarliestBattle
              FROM dbo.BattleSamurais INNER JOIN
                   dbo.Samurais ON dbo.BattleSamurais.SamuraiId = dbo.Samurais.Id
              GROUP BY dbo.Samurais.Name, dbo.BattleSamurais.SamuraiId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW adb.SamuraiBattleStats");
            migrationBuilder.Sql("DROP FUNCTION adb.EarliestBattleFoughtBySamurai");

        }
    }
}

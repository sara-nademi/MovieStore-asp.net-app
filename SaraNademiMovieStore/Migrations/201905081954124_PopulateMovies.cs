namespace SaraNademiMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[Movies]([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES(N'PJ Masks', 1, N'2015-01-01 00:00:00', N'2014-05-05 00:00:00', 5, 2)");
            Sql("INSERT INTO[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES(N'The Very Hungry Caterpillar', 2, N'1999-04-04 00:00:00', N'1998-01-02 00:00:00', 3, 1)");
            Sql("INSERT INTO[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES(N'Paw Patrol', 3, N'2018-03-03 00:00:00', N'2018-02-03 00:00:00', 4, 2)");

            Sql("INSERT INTO[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES(N'The Pets', 1, N'2017-01-01 00:00:00', N'2014-05-05 00:00:00', 5, 2)");
            Sql("INSERT INTO[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES(N'Coco', 2, N'2018-04-04 00:00:00', N'2018-01-02 00:00:00', 3, 1)");
            Sql("INSERT INTO[Movies] ([Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock], [NumberAvailable]) VALUES(N'Panda', 3, N'2018-03-03 00:00:00', N'2018-02-03 00:00:00', 4, 2)");

        }

        public override void Down()
        {
        }
    }
}

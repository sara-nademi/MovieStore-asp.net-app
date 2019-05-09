namespace SaraNademiMovieStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomer : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Sara', 'True', 1, '1989-04-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Ario', 'False', 3, '1979-05-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Samand', 'False', 2, '1991-06-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Saman', 'False',1,'1959-04-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Roshan','True',4, '1979-04-07 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Smith','True', 4, '1944-04-08 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Lili','True', 2, '1987-09-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Amir','True',1, '1988-02-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Nazi', 'False', 1, '1983-03-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Yona','False', 3, '1999-04-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Yasna', 'False', 1, '1989-01-04 00:00:00')");
            Sql("INSERT INTO Customers (Name, IsSubscribedToNewsletter, MembershipTypeId, Birthdate) VALUES ('Myna', 'False', 2, '1999-04-01 00:00:00')");
        }
        

        public override void Down()
        {
        }
    }
}

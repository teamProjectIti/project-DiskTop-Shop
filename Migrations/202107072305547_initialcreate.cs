namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phone = c.String(),
                        address = c.String(),
                        client_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clients", t => t.client_id, cascadeDelete: true)
                .Index(t => t.client_id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        id_client = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phone = c.String(),
                        address = c.String(),
                        mail = c.String(),
                        image = c.Binary(),
                        other_details = c.String(),
                    })
                .PrimaryKey(t => t.id_client);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID_Order = c.Int(nullable: false),
                        createTime = c.DateTime(nullable: false),
                        Update_Time = c.DateTime(nullable: false),
                        descripation = c.String(),
                        selasman = c.String(),
                        id_client = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Order)
                .ForeignKey("dbo.Clients", t => t.id_client, cascadeDelete: true)
                .Index(t => t.id_client);
            
            CreateTable(
                "dbo.cats",
                c => new
                    {
                        ID_CAt = c.Int(nullable: false, identity: true),
                        Name_cat = c.String(),
                        des = c.String(),
                        OtherDetails = c.String(),
                    })
                .PrimaryKey(t => t.ID_CAt);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        ID_pro = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Qount = c.Double(nullable: false),
                        priceBuy_one = c.Double(nullable: false),
                        priceBuyOrgnal_all = c.Double(nullable: false),
                        price_Sall_one = c.Double(nullable: false),
                        price_Sall_all = c.Double(nullable: false),
                        earn_Money = c.Double(nullable: false),
                        Date_attach = c.DateTime(nullable: false),
                        Date_Experied = c.DateTime(nullable: false),
                        comment = c.String(),
                        Image = c.Binary(),
                        Id_cat = c.Int(nullable: false),
                        ID_sub = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_pro)
                .ForeignKey("dbo.cats", t => t.Id_cat, cascadeDelete: false)
                .ForeignKey("dbo.Sub_Cat", t => t.ID_sub, cascadeDelete: false)
                .Index(t => t.Id_cat)
                .Index(t => t.ID_sub);
            
            CreateTable(
                "dbo.expireDAtas",
                c => new
                    {
                        ID_expire = c.Int(nullable: false, identity: true),
                        check = c.Boolean(nullable: false),
                        date_expir_last_month = c.DateTime(nullable: false),
                        ID_pro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_expire)
                .ForeignKey("dbo.products", t => t.ID_pro, cascadeDelete: true)
                .Index(t => t.ID_pro);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodeCopone = c.String(),
                        Details = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        id_user = c.Int(nullable: false),
                        ID_pro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.products", t => t.ID_pro, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: false)
                .Index(t => t.CompanyId)
                .Index(t => t.id_user)
                .Index(t => t.ID_pro);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phone = c.String(),
                        address = c.String(),
                        mail = c.String(),
                        other_details = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                        State_User = c.String(),
                        id_Distrubation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: false)
                .ForeignKey("dbo.Distributions", t => t.id_Distrubation, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.CompanyId)
                .Index(t => t.id_Distrubation);
            
            CreateTable(
                "dbo.Distributions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Mail = c.String(),
                        User_ID = c.Int(nullable: false),
                        User_id_user = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_id_user)
                .Index(t => t.User_id_user);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id_user = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        password = c.String(),
                        phone = c.String(),
                        address = c.String(),
                        Salary = c.Double(nullable: false),
                        mail = c.String(),
                        Updated_Date = c.DateTime(nullable: false),
                        Bithdate = c.DateTime(nullable: false),
                        permissions = c.String(),
                        user_type = c.String(),
                    })
                .PrimaryKey(t => t.id_user);
            
            CreateTable(
                "dbo.Depatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        id_user = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        FinshedDate = c.DateTime(nullable: false),
                        State = c.String(),
                        Others = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.id_user, cascadeDelete: true)
                .Index(t => t.id_user);
            
            CreateTable(
                "dbo.orderDetails",
                c => new
                    {
                        orderDetails_ID = c.Int(nullable: false, identity: true),
                        ID_Order = c.Int(nullable: false),
                        ID_pro = c.Int(nullable: false),
                        totalPrice = c.Double(nullable: false),
                        amount = c.Double(nullable: false),
                        DisCount = c.Double(nullable: false),
                        quentity = c.Double(nullable: false),
                        totalAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.orderDetails_ID)
                .ForeignKey("dbo.Orders", t => t.ID_Order, cascadeDelete: false)
                .ForeignKey("dbo.products", t => t.ID_pro, cascadeDelete: false)
                .Index(t => t.ID_Order)
                .Index(t => t.ID_pro);
            
            CreateTable(
                "dbo.Sub_Cat",
                c => new
                    {
                        ID_sub = c.Int(nullable: false, identity: true),
                        Name_Sub = c.String(),
                        Desc = c.String(),
                        Other_Details = c.String(),
                        ID_CAt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_sub)
                .ForeignKey("dbo.cats", t => t.ID_CAt, cascadeDelete: true)
                .Index(t => t.ID_CAt);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "ID_sub", "dbo.Sub_Cat");
            DropForeignKey("dbo.Sub_Cat", "ID_CAt", "dbo.cats");
            DropForeignKey("dbo.orderDetails", "ID_pro", "dbo.products");
            DropForeignKey("dbo.orderDetails", "ID_Order", "dbo.Orders");
            DropForeignKey("dbo.Offers", "id_user", "dbo.Users");
            DropForeignKey("dbo.Offers", "ID_pro", "dbo.products");
            DropForeignKey("dbo.Offers", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.stores", "UserId", "dbo.Users");
            DropForeignKey("dbo.stores", "id_Distrubation", "dbo.Distributions");
            DropForeignKey("dbo.Distributions", "User_id_user", "dbo.Users");
            DropForeignKey("dbo.Depatures", "id_user", "dbo.Users");
            DropForeignKey("dbo.stores", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Payments", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.expireDAtas", "ID_pro", "dbo.products");
            DropForeignKey("dbo.products", "Id_cat", "dbo.cats");
            DropForeignKey("dbo.Orders", "id_client", "dbo.Clients");
            DropForeignKey("dbo.Branches", "client_id", "dbo.Clients");
            DropIndex("dbo.Sub_Cat", new[] { "ID_CAt" });
            DropIndex("dbo.orderDetails", new[] { "ID_pro" });
            DropIndex("dbo.orderDetails", new[] { "ID_Order" });
            DropIndex("dbo.Depatures", new[] { "id_user" });
            DropIndex("dbo.Distributions", new[] { "User_id_user" });
            DropIndex("dbo.stores", new[] { "id_Distrubation" });
            DropIndex("dbo.stores", new[] { "CompanyId" });
            DropIndex("dbo.stores", new[] { "UserId" });
            DropIndex("dbo.Payments", new[] { "CompanyId" });
            DropIndex("dbo.Offers", new[] { "ID_pro" });
            DropIndex("dbo.Offers", new[] { "id_user" });
            DropIndex("dbo.Offers", new[] { "CompanyId" });
            DropIndex("dbo.expireDAtas", new[] { "ID_pro" });
            DropIndex("dbo.products", new[] { "ID_sub" });
            DropIndex("dbo.products", new[] { "Id_cat" });
            DropIndex("dbo.Orders", new[] { "id_client" });
            DropIndex("dbo.Branches", new[] { "client_id" });
            DropTable("dbo.Sub_Cat");
            DropTable("dbo.orderDetails");
            DropTable("dbo.Depatures");
            DropTable("dbo.Users");
            DropTable("dbo.Distributions");
            DropTable("dbo.stores");
            DropTable("dbo.Payments");
            DropTable("dbo.Companies");
            DropTable("dbo.Offers");
            DropTable("dbo.expireDAtas");
            DropTable("dbo.products");
            DropTable("dbo.cats");
            DropTable("dbo.Orders");
            DropTable("dbo.Clients");
            DropTable("dbo.Branches");
        }
    }
}

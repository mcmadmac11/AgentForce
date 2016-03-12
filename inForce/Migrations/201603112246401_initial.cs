namespace inForce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProducerNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LineOfInsurance = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PolicyNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        IsDeleted = c.Boolean(nullable: false),
                        MasterRecordId = c.String(),
                        AccountId = c.String(),
                        LastName = c.String(maxLength: 80),
                        FirstName = c.String(maxLength: 40),
                        Salutation = c.String(),
                        Name = c.String(maxLength: 121),
                        OtherStreet = c.String(),
                        OtherCity = c.String(maxLength: 40),
                        OtherState = c.String(maxLength: 80),
                        OtherPostalCode = c.String(maxLength: 20),
                        OtherCountry = c.String(maxLength: 80),
                        OtherLatitude = c.Double(),
                        OtherLongitude = c.Double(),
                        MailingStreet = c.String(),
                        MailingCity = c.String(maxLength: 40),
                        MailingState = c.String(maxLength: 80),
                        MailingPostalCode = c.String(maxLength: 20),
                        MailingCountry = c.String(maxLength: 80),
                        MailingLatitude = c.Double(),
                        MailingLongitude = c.Double(),
                        Phone = c.String(),
                        Fax = c.String(),
                        MobilePhone = c.String(),
                        HomePhone = c.String(),
                        OtherPhone = c.String(),
                        AssistantPhone = c.String(),
                        ReportsToId = c.String(),
                        Email = c.String(),
                        Title = c.String(maxLength: 128),
                        Department = c.String(maxLength: 80),
                        AssistantName = c.String(maxLength: 40),
                        LeadSource = c.String(),
                        Birthdate = c.DateTimeOffset(precision: 7),
                        Description = c.String(),
                        OwnerId = c.String(),
                        CreatedDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreatedById = c.String(),
                        LastModifiedDate = c.DateTimeOffset(nullable: false, precision: 7),
                        LastModifiedById = c.String(),
                        SystemModstamp = c.DateTimeOffset(nullable: false, precision: 7),
                        LastActivityDate = c.DateTimeOffset(precision: 7),
                        LastCURequestDate = c.DateTimeOffset(precision: 7),
                        LastCUUpdateDate = c.DateTimeOffset(precision: 7),
                        LastViewedDate = c.DateTimeOffset(precision: 7),
                        LastReferencedDate = c.DateTimeOffset(precision: 7),
                        EmailBouncedReason = c.String(maxLength: 255),
                        EmailBouncedDate = c.DateTimeOffset(precision: 7),
                        IsEmailBounced = c.Boolean(nullable: false),
                        PhotoUrl = c.String(),
                        Jigsaw = c.String(maxLength: 20),
                        JigsawContactId = c.String(maxLength: 20),
                        CleanStatus = c.String(),
                        Level__c = c.String(),
                        Languages__c = c.String(maxLength: 100),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.GlobalUsers",
                c => new
                    {
                        GlobalUserId = c.Int(nullable: false, identity: true),
                        GlobalAgentId_Id = c.Int(),
                        GlobalClientId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.GlobalUserId)
                .ForeignKey("dbo.Agents", t => t.GlobalAgentId_Id)
                .ForeignKey("dbo.Clients", t => t.GlobalClientId_Id)
                .Index(t => t.GlobalAgentId_Id)
                .Index(t => t.GlobalClientId_Id);
            
            CreateTable(
                "dbo.CompanyAgents",
                c => new
                    {
                        Company_Id = c.Int(nullable: false),
                        Agent_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Company_Id, t.Agent_Id })
                .ForeignKey("dbo.Companies", t => t.Company_Id, cascadeDelete: true)
                .ForeignKey("dbo.Agents", t => t.Agent_Id, cascadeDelete: true)
                .Index(t => t.Company_Id)
                .Index(t => t.Agent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GlobalUsers", "GlobalClientId_Id", "dbo.Clients");
            DropForeignKey("dbo.GlobalUsers", "GlobalAgentId_Id", "dbo.Agents");
            DropForeignKey("dbo.Contacts", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.CompanyAgents", "Agent_Id", "dbo.Agents");
            DropForeignKey("dbo.CompanyAgents", "Company_Id", "dbo.Companies");
            DropIndex("dbo.CompanyAgents", new[] { "Agent_Id" });
            DropIndex("dbo.CompanyAgents", new[] { "Company_Id" });
            DropIndex("dbo.GlobalUsers", new[] { "GlobalClientId_Id" });
            DropIndex("dbo.GlobalUsers", new[] { "GlobalAgentId_Id" });
            DropIndex("dbo.Contacts", new[] { "Client_Id" });
            DropTable("dbo.CompanyAgents");
            DropTable("dbo.GlobalUsers");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clients");
            DropTable("dbo.Companies");
            DropTable("dbo.Agents");
        }
    }
}

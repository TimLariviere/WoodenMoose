using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WoodenMoose.Api.Models;

namespace WoodenMoose.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20160425061805_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WoodenMoose.Api.Models.Application", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("BackgroundColor");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });
        }
    }
}

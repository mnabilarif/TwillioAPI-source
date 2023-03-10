using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Texter.Models;

namespace Texter.Migrations
{
    [DbContext(typeof(TexterDbContext))]
    [Migration("20180122234926_StringNumber")]
    partial class StringNumber
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("Texter.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });
        }
    }
}

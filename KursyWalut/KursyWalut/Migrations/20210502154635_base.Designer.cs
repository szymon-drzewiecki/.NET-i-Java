// <auto-generated />
using KursyWalut.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KursyWalut.Migrations
{
    [DbContext(typeof(KursyWalutContext))]
    [Migration("20210502154635_base")]
    partial class @base
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KursyWalut.Models.Dane", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BTC")
                        .HasColumnType("real");

                    b.Property<float>("COP")
                        .HasColumnType("real");

                    b.Property<float>("EUR")
                        .HasColumnType("real");

                    b.Property<float>("PLN")
                        .HasColumnType("real");

                    b.Property<string>("date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("timestamp")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Dane");
                });
#pragma warning restore 612, 618
        }
    }
}

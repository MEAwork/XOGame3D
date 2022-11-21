﻿// <auto-generated />
using System;
using GameStreamer.Backend.Storage.GameStreamerDbase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GameStreamer.Backend.Migrations.GameStreamerContextMigrations
{
    [DbContext(typeof(GameStreamerContext))]
    [Migration("20220623202436_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("game_streamer")
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GameStreamer.Backend.Persistance.GameStreamerDbase.Entities.ConnectedPlayerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientType")
                        .HasColumnType("integer")
                        .HasColumnName("client_type");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("connection_id");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nick_name");

                    b.Property<Guid>("RoomGuid")
                        .HasColumnType("uuid")
                        .HasColumnName("room_guid");

                    b.HasKey("Id");

                    b.ToTable("connected_players", "game_streamer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientType = 0,
                            ConnectionId = "qwerty123",
                            IsActive = false,
                            NickName = "noob1",
                            RoomGuid = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 2,
                            ClientType = 1,
                            ConnectionId = "qwerty456",
                            IsActive = false,
                            NickName = "noob2",
                            RoomGuid = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 3,
                            ClientType = 2,
                            ConnectionId = "qwerty789",
                            IsActive = false,
                            NickName = "noob3",
                            RoomGuid = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

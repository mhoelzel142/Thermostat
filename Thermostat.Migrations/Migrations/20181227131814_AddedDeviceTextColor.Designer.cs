﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Thermostat.Migrations;

namespace Thermostat.Migrations.Migrations
{
    [DbContext(typeof(NewContext))]
    [Migration("20181227131814_AddedDeviceTextColor")]
    partial class AddedDeviceTextColor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("Thermostat.Model.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceHumidity");

                    b.Property<string>("DeviceIp");

                    b.Property<string>("DeviceMac");

                    b.Property<string>("DeviceName");

                    b.Property<string>("DeviceTemperature");

                    b.Property<string>("DeviceTextColor");

                    b.Property<string>("DeviceTileColor");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}

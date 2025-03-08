using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeCarApi.DAL.Entity;
using SeCarApi.Models;

namespace SeCarApi.DAL.Context
{
    public class ApplicationDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the ApplicationDbContext class.
    /// </summary>
    /// <param name="options">The options to be used by the DbContext.</param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    /// <summary>
    /// Gets or sets the DbSet for Test models.
    /// This property represents a collection of Test entities in the database.
    /// </summary>
    public DbSet<Demo> DemoModels { get; set; }
        //public DbSet<SeCarApi.Models.DemoModel> DemoModel { get; set; } = default!;
}}
        
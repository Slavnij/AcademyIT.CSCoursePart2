﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Grades.DataModel
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class SchoolGradesDBEntities : DbContext
{
    public SchoolGradesDBEntities()
        : base("name=SchoolGradesDBEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Grade> Grades { get; set; }

    public DbSet<Student> Students { get; set; }

    public DbSet<Subject> Subjects { get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    public DbSet<User> Users { get; set; }

}

}


﻿using TransplantedProj.Databases;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using TransplantedProj.Databases;

namespace Bookstore.Repositories;

public class CourseRepository
{
    public DbSet<Course> Courses;
    public DbContext Context;
    public CourseRepository(MySQLDatabase context)
    {
        this.Context = context;
        this.Courses = context.Courses;
    }
    public async Task<IEnumerable<Course>> GetAll() { return await this.Courses.ToArrayAsync(); }
    
}
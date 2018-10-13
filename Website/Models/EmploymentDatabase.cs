﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class EmploymentDatabase : DbContext
    {
        public DbSet<SkillType> SkillsType { get; set; }
        public DbSet<SkillCategory> SkillsCategory { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }
        public DbSet<BusinessProfile> BusinessProfiles { get; set; }

        public DbSet<Resume> Resumes { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
    }
}
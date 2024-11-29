﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using study_center_ef.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_center_ef.Data.Config
{
    public class TeacherDetailConfiguration :IEntityTypeConfiguration<TeacherDetail>
    {
        public void Configure(EntityTypeBuilder<TeacherDetail> builder)
        {
            builder.HasNoKey();

            builder.ToView("TeachersDetails");

        }
    }
}
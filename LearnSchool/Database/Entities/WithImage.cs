﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.Database.Entities
{
    public abstract class WithImage : BaseEntity
    {
        public string ImagePath { get; set; }

        protected virtual string Folder => "./Услуги школы";

        [NotMapped]
        public byte[] Image
        {
            get
            {
                try
                {
                    return File.ReadAllBytes($"{Folder}/" + ImagePath.Split(@"\"[0], '/')[1]);
                }
                catch { return Properties.Resources._default; }
            }
            set
            {
                string name = $"{Folder}/{value.GetHashCode()}.kurwa";
                File.WriteAllBytes($"{Folder}/{name}", value);
            }
        }
    }
}

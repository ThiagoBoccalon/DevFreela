﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.DTOs
{
    public class SkillDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public SkillDTO(int id, string description) 
        {
            Id = id;
            Description = description;
        }
    }
}

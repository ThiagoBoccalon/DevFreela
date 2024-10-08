﻿using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id, string title,
            string description, decimal totalCost,
            DateTime? startedAt, DateTime? finishedAt,
            string clientFullName, string freelancerFullname)
        {
            Id = id;
            Title = title;
            ClientFullName = clientFullName;
            FreelancerFullName = freelancerFullname;
            Description = description;
            TotalCost = totalCost;
            StartedAt = startedAt;
            FinishAt = finishedAt;
        }
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string ClientFullName { get; private set; }
        public string FreelancerFullName { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishAt { get; private set; }        
    }
}

﻿using DevFreela.Application.Commands.CreateProject;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Description)
                .MaximumLength(300)
                .WithMessage("Maximium lenght of description should have less than 255 character");

            RuleFor(p => p.Title)
                .MaximumLength(30)
                .WithMessage("Maximium lenght of title should have less than 30 character");
        }
    }
}

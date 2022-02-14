﻿using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace SeaPublicWebsite.Models.EnergyEfficiency.QuestionOptions
{
    public enum QuestionTheme
    {
        [Display(Name = "Section 1: Is this service right for you?")]
        Suitability,
        [Display(Name = "Section 2: Getting the most out of this service")] 
        UserNeeds,
        [Display(Name = "Section 3: Your property")]
        YourHome,
        [Display(Name = "Section 4: Heating")]
        Heating,
        [Display(Name = "Section 5: Behaviour")]
        Behaviour
    }
}
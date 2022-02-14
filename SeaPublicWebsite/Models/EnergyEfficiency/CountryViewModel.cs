﻿using GovUkDesignSystem;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using SeaPublicWebsite.Models.EnergyEfficiency.QuestionOptions;

namespace SeaPublicWebsite.Models.EnergyEfficiency
{
    public class CountryViewModel : GovUkViewModel
    {
        public string Title = "Which country is your property located in?";
        public string Description = "";
        public QuestionTheme Theme = QuestionTheme.Suitability;

        [GovUkValidateRequired(ErrorMessageIfMissing = "Please let us know which country you live in")]
        public Country? Answer { get; set; }
    }
}
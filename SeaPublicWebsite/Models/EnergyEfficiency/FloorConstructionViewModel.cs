﻿using GovUkDesignSystem;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using SeaPublicWebsite.Models.EnergyEfficiency.QuestionOptions;

namespace SeaPublicWebsite.Models.EnergyEfficiency
{
    public class FloorConstructionViewModel : GovUkViewModel
    {
        [GovUkValidateRequired(ErrorMessageIfMissing = "Select how your floor is built")]
        public FloorConstruction? FloorConstruction { get; set; }

        public string Reference { get; set; }
        public bool Change { get; set; }
        public int? YearBuilt { get; set; }
        public WallConstruction? WallConstruction { get; set; }
        public Epc Epc { get; set; }
    }
}
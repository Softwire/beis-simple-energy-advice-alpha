﻿using GovUkDesignSystem.Attributes;

namespace SeaPublicWebsite.Models.EnergyEfficiency.QuestionOptions
{
    public enum OwnershipStatus
    {
        [GovUkRadioCheckboxLabelText(Text = "Yes, I own my property and live in it")]
        OwnerOccupancy,
        [GovUkRadioCheckboxLabelText(Text = "No, I am a tenant")]
        PrivateTenancy,
        [GovUkRadioCheckboxLabelText(Text = "I am the property owner but lease my property to one or more tenants")]
        Landlord,
    }
}         
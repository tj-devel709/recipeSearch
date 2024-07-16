﻿using Recipes.Services;
using Recipes.ViewModels;

namespace Recipes.Views
{
    public partial class EditRecipePage : ContentPage
    {
        public EditRecipePage()
        {
            InitializeComponent();
            BindingContext = new EditRecipeViewModel();
        }

        private async void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            string increasedOrDecreased = "";

            if (e.NewValue > e.OldValue)
                increasedOrDecreased = "Rating increased to ";
            else
				increasedOrDecreased = "Rating decreased to ";

            await AnnouncementHelper.Announce(increasedOrDecreased + SemanticProperties.GetDescription(ratingLabel));
		}
    }
}
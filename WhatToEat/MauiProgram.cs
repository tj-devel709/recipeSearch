﻿using Recipes.Services;

namespace Recipes
{
    public class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers(_ =>
                {
                    Microsoft.Maui.Controls.Handlers.Items.CollectionViewHandler.Mapper.AppendToMapping("KeyboardAccessibleCollectionView", (handler, view) =>
                    {
#if WINDOWS
                        handler.PlatformView.SingleSelectionFollowsFocus = false;
#endif
                    });
                });

            builder.Services.AddSingleton<IAsyncAnnouncement, SemanticScreenReaderAsyncImplementation>();
            return builder.Build();
        }
    }
}

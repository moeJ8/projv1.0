﻿using MauiSQLite.DataTransactions;
using MauiSQLite.Models;
using Microsoft.Extensions.Logging;

namespace MauiSQLite
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "Studet.db");

            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<DBTrans>(s, _dbPath));

            builder.Services.AddSingleton<UniversityClass>();
            builder.Services.AddSingleton<MajorClass>();

            return builder.Build();
        }
    }
}

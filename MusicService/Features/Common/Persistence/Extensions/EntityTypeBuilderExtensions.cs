using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MusicService.Features.Common.Persistence.Extensions
{
    public static class EntityTypeBuilderExtensions
    {
        public static void Configure<T>(this EntityTypeBuilder<T> modelBuilder, params Action<EntityTypeBuilder<T>>[] builders) where T : class
        {
            builders
                .ToList()
                .ForEach(builder => builder(modelBuilder));
        }
    }
}

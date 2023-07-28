using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDrawingJourney.Data.Models.Songs;
using MyDrawingJourney.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Configuration
{
    public class SongEntityConfiguration : IEntityTypeConfiguration<Song>
    {
        private readonly SongSeeder songSeeder;
        public SongEntityConfiguration()
        {
            this.songSeeder = new SongSeeder();

        }
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.HasData(this.songSeeder.GenerateSongs().ToArray());
        }
    }
}

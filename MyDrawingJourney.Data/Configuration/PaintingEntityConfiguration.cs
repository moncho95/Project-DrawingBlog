using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDrawingJourney.Data.Models.Paintings;
using MyDrawingJourney.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrawingJourney.Data.Configuration
{
    public class PaintingEntityConfiguration : IEntityTypeConfiguration<Painting>
    {
        private readonly PaintingSeeder postSeeder;
        public PaintingEntityConfiguration()
        {
            this.postSeeder = new PaintingSeeder();

        }
        public void Configure(EntityTypeBuilder<Painting> builder)
        {
            builder.HasData(this.postSeeder.GeneratePaintings().ToArray());
        }

      
    }
}

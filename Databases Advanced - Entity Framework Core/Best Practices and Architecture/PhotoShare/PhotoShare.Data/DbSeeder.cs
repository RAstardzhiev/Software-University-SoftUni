namespace PhotoShare.Data
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using PhotoShare.Models;

    public class DbSeeder
    {
        private const string TownsFilePath = @"..\PhotoShare.Data\TestData\Towns.txt";
        private const string AlbumsFilePath = @"..\PhotoShare.Data\TestData\Album names.txt";

        private PhotoShareContext context;
        private Random random;

        public DbSeeder(PhotoShareContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public void SeedTestData()
        {
            var towns = this.GetTowns();
            var albums = this.GetAlbums();

            context.Albums.AddRange(albums);
            context.Towns.AddRange(towns);
            context.SaveChanges();
        }

        private IEnumerable<Album> GetAlbums() => File.ReadAllLines(AlbumsFilePath)
            .Select(a => new Album(a, this.random.Next(100) % 2 == 0));

        private IEnumerable<Town> GetTowns() => File.ReadAllLines(TownsFilePath)
            .Select(t =>
            {
                var townData = t.Split(", ");
                var country = townData[0];
                var townName = townData[1];
                var town = new Town(townName);
                town.Country = country;
                return town;
            });
    }
}

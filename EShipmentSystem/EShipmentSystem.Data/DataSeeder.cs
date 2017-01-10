namespace EShipmentSystem.Data
{
    using System.Linq;
    using Models;

    public static class DataSeeder
    {
        public static void SeedData(this EShipmentSystemDbContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            SeedReceivers(context);
        }

        internal static void SeedUsers(EShipmentSystemDbContext context)
        {

        }

        internal static void SeedReceivers(EShipmentSystemDbContext context)
        {
            var data = new Receiver
            {
                Name = "Test name",
                Phone = "088 888 8888",
                Country = "Bulgaria",
                City = "Sofia",
                Address = "block 2",
                Neighborhood = "Student City",
                ZipCode = "1000",
                Email = "some@mail.com"
            };

            context.Receivers.Add(data);
            context.SaveChanges();
        }
    }
}

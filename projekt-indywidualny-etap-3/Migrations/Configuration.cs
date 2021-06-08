namespace projekt_indywidualny_etap_3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Types.AddOrUpdate(new EventTypeModel { Name = "Face to Face" });
            context.Types.AddOrUpdate(new EventTypeModel { Name = "Remote" });

            context.Categories.AddOrUpdate(new EventCategoryModel { Name = "Computer Science" });
            context.Categories.AddOrUpdate(new EventCategoryModel { Name = "Personal Health" });
            context.Categories.AddOrUpdate(new EventCategoryModel { Name = "Games" });
            context.Categories.AddOrUpdate(new EventCategoryModel { Name = "Books" });


            /*  context.Events.AddOrUpdate(
                    new EventModel
                    {
                        Title = "Test Event 1",
                        Description = "Lorem Ipsum Lorem Ipsum...",
                        OrganizedBy = "marcin.osiadacz",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddHours(3),
                        Location = "Warsaw",
                      EventTypeId = context.Types.FirstOrDefault(t => t.Name == "Face to Face").Id,
                        EventType = context.Types.FirstOrDefault(t => t.Name == "Face to Face"),
                        EventCategoryId = context.Categories.FirstOrDefault(c => c.Name == "Books").Id,
                        EventCategory = context.Categories.FirstOrDefault(c => c.Name == "Books"), 
            AvailableSlots = 10
                    }
                );*/

        }
    }
}

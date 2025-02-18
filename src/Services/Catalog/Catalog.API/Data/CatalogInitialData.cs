using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync())
            return;

        // Marten UPSERT will cater for existing records
        session.Store<Product>(GetProductfiguredProducts());
        await session.SaveChangesAsync();
        
    }

    private static IEnumerable<Product> GetProductfiguredProducts() =>
        [
            new Product(){
                Id = new Guid("06031f57-9578-4adb-995c-de7076278f4f"),
                Name = "IPhone 16",
                Description = "This phone is the company's change to its photo and CPU",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = ["Smart Phone","Video Phone"]
            },
            new Product(){
                Id = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                Name = "Samsung Galaxy S24 Ultra",
                Description = "The latest flagship smartphone with an advanced camera system and powerful processor.",
                ImageFile = "product-2.png",
                Price = 1199.99M,
                Category = ["Smart Phone", "High-End Phone"]
            },
            new Product(){
                Id = new Guid("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                Name = "Google Pixel 8 Pro",
                Description = "A premium Android phone known for its excellent camera quality and software updates.",
                ImageFile = "product-3.png",
                Price = 899.00M,
                Category = ["Smart Phone", "Android Phone"]
            },
            new Product(){
                Id = new Guid("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                Name = "IPhone 16 Pro Max",
                Description = "Apple's top-of-the-line smartphone featuring a dynamic display and A18 Bionic chip.",
                ImageFile = "product-4.png",
                Price = 1299.99M,
                Category = ["Smart Phone", "Video Phone"]
            },
            new Product(){
                Id = new Guid("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9g"),
                Name = "OnePlus 12T",
                Description = "A budget-friendly yet powerful smartphone with fast charging capabilities.",
                ImageFile = "product-5.png",
                Price = 699.99M,
                Category = ["Smart Phone", "Budget Phone"]
            },
            new Product(){
                Id = new Guid("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9g0h"),
                Name = "Xiaomi Mi 14",
                Description = "An affordable smartphone with cutting-edge technology and impressive performance.",
                ImageFile = "product-6.png",
                Price = 599.00M,
                Category = ["Smart Phone", "Mid-Range Phone"]
            },
            new Product(){
                Id = new Guid("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9g0h1i"),
                Name = "Sony Xperia 1 VI",
                Description = "A unique smartphone designed for multimedia enthusiasts with a focus on display quality.",
                ImageFile = "product-7.png",
                Price = 1099.99M,
                Category = ["Smart Phone", "Cinema Phone"]
            },
            new Product(){
                Id = new Guid("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9g0h1i2j"),
                Name = "Nokia G300",
                Description = "A durable and reliable smartphone with long-lasting battery life.",
                ImageFile = "product-8.png",
                Price = 299.99M,
                Category = ["Smart Phone", "Entry-Level Phone"]
            }
        ];
}



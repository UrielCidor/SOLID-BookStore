# SOLID-BookStore
DIAMOND project 1: reprogramming Book-Store project with SOLID principles

## Changes and new code:

I divid the work to two issues:
  - the project's new requirements (MVVM, DB) and old ones that weren't done (finish/improve UI, unit testing and exception handling)   
  - reprogrmming my code following SOLID princeples

Looking at the original project, it's actually not that bad... Starting with reprograming my classes in aim to get SQL DB going. 

**S**ingle Responsibility Princple: Classes responsible on single "change" - only on thier fields properties.

**O**pen-Closed Princple: Classes are open to extention (simply adding a derived product class to product base for having a new product category) and closed to modification.

ProductBase Class and ProductCategory Class:

```
abstract public class ProductBase
    {
        public int Id { get; private set; }
        public string ProductName { get; set; }
        public ProductCategory Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }

    public class ProductCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public IList<ProductBase> Products { get; set; }
    }
```
Derived BookProduct and JournalProduct Classes:
```
public class BookProduct : ProductBase
    {  
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Publisher { get; private set; }
        public int ISBN { get; private set; }
        public int Edition { get; private set; }
        public DateTime PublishDate { get; private set; }
        public IList<Genre> Genres{ get; set; }
    }

public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public IList<BookProduct> Books { get; set; } 
    }

public class JournalProduct : ProductBase
    {
        public string JournalName { get; private set; }
        public string Publisher { get; private set; }
        public DateTime PublishDate { get; private set; }
        public JournalCategory JournalCategory{ get; set; }
        public IList<JournalTopic> Topics { get; set; }
    }
public class JournalCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<JournalProduct> Journals { get; set; }
    }
    
public class JournalTopic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<JournalProduct> Journals { get; set; }
    }
```
DAL layer, DataContext class:
```
class DataContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<JournalCategory> JournalCategories { get; set; }
        public DbSet<JournalTopic> Topics { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<ProductBase> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookStoreDb;Trusted_Connection=True;");
        }
    }
```
DAL layer, Repository class. The repo pattern is another expample of **SRP** as dataContext class is responsible of creating context only and the repo for the context functionality. In adition to the **L**iskov substitution princple - *Functions* (`AddProduct()`, `DeleteProduct()`) *that reference to base classes must be able to use objects of derived classes without knowing it*. 
```
public class Repository
    {
        private readonly DataContext data = new();
        
        public IEnumerable<ProductBase> Products => data.Products;

        public void AddProduct(ProductBase product)
        {
            data.Products.Add(product);
            data.SaveChanges();
        }
        public void DeleteProduct(ProductBase product)
        {
            data.Products.Remove(product);
            data.SaveChanges();
        }
    }
```


To do: 
- upload orginal project V
- find original srs  V
- write new srs.
- create DAL layer for dataContext and Repository pattern. V
- TDD: create unit tests for:
    1. Writing data to db.
    2. Getting data from db.
    3. object-entity creation.
    4. Repository pattern.
- Create UI project to program.

## SRS:
*Original SRS*

1. Program will manage books and journals for book store:
    1. Books info: Title, Author, ISBN, Publisher, Publishe date, Edition, Ganere, Price, Quantity, Discount.
    2. Journals info: Journal Name, Publisher, Publish date, Journal Type, Journal Topic, Price, Quantity, Discount.
2. Create, update and view items.
3. Data about books and journals items will be saved - no db. only save to binary file.
4. Preform search by items or by properties.
5. User Interface:
    1. Landing Page:
        1. Include navigation bar for Inventory page, Employee page, Sales Page, Manager Page
        2. Logo and or front page image.
        3. Add login stage for manager/employee identification?

    2. Inventory page:
        1. Search Panel:
            1. clear fields from text button
            2. reset search button
            3. free text global search text box + search button

            *search fields:*

            4. select item type (book/journal) + search button
            
            *book fields:*
            
            5. Title text box + search button
            6. Author text box + search button
            7. Publisher text box + search button
            8. ISBN text box + search button
            9. Publish date picker + search button
            10. Edition text box + search button
            11. Ganere comboBox + search button
            *journal fields:*
            12. Name text box + search button
            13. Publisher text box + search button
            14. Publish date picker + search button
            15. Type comboBox + search button
            16. Topic comboBox + search button
            *shared fields:*
            17. Price text box + search button
            18. Quantity text box + search button
            19. Discount text box + search button
        2. Excute Panel:
            1. Add item to inventory button - validate data in fields and create new item
        3. View Panel:
            1. list view of inventory and search results
            2. click on item to open detail dialog box

    3. Employee Page:
        1. info panel
        2. info panel
        3. Excute panel

    4. Sales Page:

    5. Manager Page:

*Revised SRS*
1. Product entity - PrroductBase. Properties:
  - Derived Classes:
    1. BookProduct: Properties:
    2. JournalProduct: Propertes: 
2. Services: DataService


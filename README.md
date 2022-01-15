# SOLID-BookStore
DIAMOND project 1: reprogramming Book-Store project with SOLID principles

## Changes and new code:

To do: 
- upload orginal project V
- find original srs  V
- write new srs.
- 

I divid the work to two issues:
  - the project's new requirements (MVVM, DB) and old ones that weren't done (finish/improve UI, unite testing and exception handling)   
  - reprogrmming my code following SOLID princeples

Looking at the original project, it's actually not that bad... Starting with reprograming my classes in aim to get SQL DB going. 

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


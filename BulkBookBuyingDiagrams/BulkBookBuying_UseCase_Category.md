# ISTA422
**Arnold Burnley**  
*September 27thth, 2020*  
## Use Cases 
A use case is a written description of how users will perform tasks on your website. It outlines, from a user’s point of view, a system’s behavior as it responds to a request. Each use case is represented as a sequence of simple steps, beginning with a user's goal and ending when that goal is fulfilled.  
## Use Case Name: Software Development Fundamentals Test
**Actors**
* Admin

**Triggers**
* Administrator wants to add a new category (genere) to the list of categories and uses their admin role to add a new category. They also want to make other changes.  

**Preconditions**  
* The only area and role is admin and the only objects are category. Categories aren't attached to books. However, the Categories interface is fully functional  
so Admin can perform full CRUD operations  on category objects with validation. Databse already contains Fiction, Mystery, Non-Fiction.

**Postconditions**
* Database will have Mystery removed, Fantasy added, and Fiction changed to Make Believe.

## Normal Flow 
1.  Admin launches App
2.  Admin goes to dropdown on NavBar
3.  Admin selects Category
4.  Upsert View Rendered with table
5.  Admin clicks delete icon
6.  Toastr validation message confirms delete
7.  Admin confirms
8.  Delete Successful Message Appears
9.  Admin clicks edit  button next to Fiction
10.  Admin enters new name and clicks update
11. Admin clicks Back to List
12.  Admin clicks create new category
13.  Admin types category name and create and gets directed back to list

## Alternate Flow
1.  Admin launches App
2.  Admin goes to dropdown on NavBar
3.  Admin selects Category
4.  Upsert View Rendered with table
5.  Admin clicks delete icon
6.  Toastr validation message confirms delete
7.  Admin confirms
8.  Delete Successful Message Appears
9.  Admin clicks edit  button next to Fiction
10. Admin does not enter new name but clicks update
11. Red validation message appears
12. Admin enters new name and clicks update
13. Admin clicks Back to List
14. Admin clicks create new category
15. Admin types category name and create and gets directed back to list





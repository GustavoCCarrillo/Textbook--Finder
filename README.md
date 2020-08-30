# Textbook-Finder

## Concept
## This project consist of a Web Application design to be hosted on a server and makes use of an existing API to pull descriptive data about textbooks. It includes an ERD diagram, class diagram, several wire-frame sketches that illustrate the basic concept and useability of the application. In the simplest form, the application will retrieve a list of textbooks to be displayed to the user with descriptive information and direct link to the publisher/retailer. 

*** 
# <a name="tcontent"></a>
# Table of Content 

- [Basic Connectivity](#bconnect)
- [Database Diagrams](#dbdia)
- [Wire-Frames](#wf)
- [UML Diagram](#umldia)
- [User Stories](#userstory)
- [Use Cases](#usecase)
- [Requirements](#reqlist)

***

# <a name="bconnect"></a>
## Basic Connectivity <h2>
[table of content](#tcontent)

![Process](https://user-images.githubusercontent.com/20195657/89743180-62a0c480-da55-11ea-964e-86f0f3a718f7.png)

***

<a name="dbdia"></a>
## Database Diagrams <h2>
[table of content](#tcontent)

![ERDDiagram](https://user-images.githubusercontent.com/20195657/89742739-74806880-da51-11ea-91dc-3aaa54e16cf8.png)

---

![BooksDB pdf (1)](https://user-images.githubusercontent.com/20195657/89743017-fffaf900-da53-11ea-9fb1-be9eec73c353.png)

*** 

<a name="wf"></a>
## Wire-Frames: DRAFT <h2> 
[table of content](#tcontent)

## 1) 
![Sketch2](https://user-images.githubusercontent.com/20195657/89742744-7c400d00-da51-11ea-8c4c-fd2be526c949.png)

## 2) 
![Sketch3](https://user-images.githubusercontent.com/20195657/89742747-819d5780-da51-11ea-89aa-7379ab14118b.png)

## 3)
![Sketch4](https://user-images.githubusercontent.com/20195657/89742751-85c97500-da51-11ea-8482-b5930437c8e5.png)

***

<a name="umldia"></a>
## UML Diagram <h2>
[table of content](#tcontent)

![UML Diagram(1)](https://user-images.githubusercontent.com/20195657/90574316-79d66500-e16d-11ea-8fa4-e4e169a4a160.png)

***

                Actors: College student, Professor, Staff and Other users (non-students or faculty or Staff)
<a name="userstory"></a>
## User-Stories <h2>
[table of content](#tcontent)
  
1)	As a college student, I want to be able to search for books by Name or ISBN number so that I can get a list of relevant results and links with option to click and visit the publisher’s/retailer’s website.
2)	As a professor, I need to be able to enter the name or ISBN number of a textbook into a search mechanism so that I can see a list of books to choose from to aid in future assignments.
3)	As an everyday user, I need to be able to search for any kind of book or publication with links to other resources such as ReadMyBook (Richard Lee’s project) for the visually impaired and/or store locator (using google maps).

***

<a name="usecase"></a>
## Use Cases <h2>
  
### Use Case – Actor: College Student – Search for assigned textbook
-	Given I have a textbook to search for and I have the name and/or ISBN number, when I attempt to search for the name or number of the textbook, a list of results should be displayed with descriptive information, external links for purchasing options and a map to locate nearby retailers.

### Use Case – Actor: College professor – Search for reference material 
-	As a professor, given I have a list of required textbooks passed down by the department chair, when I attempt to search for reference material through the use category filters, a list of relevant textbooks is displayed with descriptive information based on the category selected. (this should be a list of results of free material to use as reference) 

### Use Case – Actor:  Everyday user (staff) – Searching for a book to share
-	Given I have a book in mind to search for, and I search for the title by a specific name or ISBN number, I get a list of results that I can scroll through so that I can select a title and share it with social media such as Facebook, Tweeter or Instagram. 

### Use Case – Actor:  Everyday user (non-student) – Search for a book to read
-	Given I have a book in mind that I want to find for purchase, and I attempt to search for the book by name or ISBN number, a list of relevant results is displayed in which I can make a selection to display the location of a retailer, or use links to other applications such as: application that read text outloud. 

***

<a name="reqlist"></a>
## Requirements <h2>
[table of content](#tcontent)

| ID |  Requirement List - System shall..                                             |Test Method|Test ID|
|----|--------------------------------------------------------------------------------|-----------|-------|
|1.0 |	Prompt the user to search for textbooks                                       |Inspection |T1     |
|1.1 |	Allow user to enter a query into a search mechanism                           |Test       |T2     |
|1.2 |	Allow user to select filters against the query to limit the number of results |Demo       |T3     |
|1.3 |	Filter by category, subject or Title                                          |Test       |T4     |
|2.0 |	Display a list of results in a scroll-down or scroll-up fashion               |Inspection |T5     |
|2.1 |	Allow user to select a book to see description and retailer link              |Demo       |T6     |
|2.2 |	Description tab opens a separate popup window with product description        |Demo       |T7     |
|2.3 |	Allow user to select description and retailer hyperlinks                      |Test       |T8     |
|2.4 |	Redirect user to retailers’ site                                              |Demo       |T9     |
|3.0 |	Display a map with the location of nearby retailers                           |Inspection |T10    |
|3.1 |	Let the user select a retailer from the map                                   |Demo       |T11    |
|3.2 |	Display retailer geographical location, phone, and hours of operation         |Inspection |T12    |


***


| ID |  Test Table                                                                    |Status     |
|----|--------------------------------------------------------------------------------|-----------|
|T1  |	Verify search mechanism is active. Blinking cursor                            |Not Tested |
|T2  |	Check the search box. Enter text                                              |Not Tested |
|T3  |	Check filter boxes are selectable                                             |Not Tested |
|T4  |	Verify category box is selectable                                             |Not Tested |
|T5  |	Verify search result populate on display area                                 |Not Tested |
|T6  |	Check item results are selectable                                             |Not Tested |
|T7  |	Check that a second window pops up                                            |Not Tested |
|T8  |	Verify hyperlinks and description items are valid                             |Not Tested |
|T9  |	Verify hyperlink redirects to retailer site                                   |Not Tested |
|T10 |	Verify retailers are showing up on the map                                    |Not Tested |
|T11 |	Verify that each item selected populates on the map                           |Not Tested |
|T12 |	Check the retialer's business information is accurate                         |Not Tested |


## Functional Requirements: The application must…
-	Search for books using web resources such as an external API
-	Allow user to enter query into a search mechanism
-	Allow user to select filters against the query to limit the number of results
-	Display a list of results in a scroll-down or scroll-up fashion
-	Allow to select a book to see description and retailer link
-	Display the location of a retailer nearby (map)
## Non-functional Requirements: The application should be…
-	Simple to use with few filtering options
-	Accessed through a web-browser
-	Able to search thru any category, name or ISBN number
-	Available 24/7 
-	Working in cohesion with an external API to render data to user.
-	A one- or two-page application, one: to display results, two: to display a bigger view of the selected result with product description, links and map.

***







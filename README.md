# Restaurant Rater/Menus - March 16, 2020. 

### Created by: Brandan Sayarath & Jamie Cozart

## Description

This purpose of this project is to create a aggregator website where users can enter a restaurant name and add menu items along with their corresponding prices.  The idea for this website came from the our frustrations from not being able to find current prices for a certain restaurant. 

## Behavior Driven Development Specifications

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
|If user visits '/' root route, display splash page with link to '/restaurants' | user visits '/' route | display home|
| If user visits '/restaurants' display list of all resaurants, each with 'view menu' button, and 'add new rant' button | user visits '/restaurants' | display list of restaurants|
| If user clicks 'Add new rant' button, redirect to restaurant form | clicks 'add new rant' | redirect to '/restaurants/new'|
| If user visits '/restaurants/new' show new restaurants form with field for "Name" | user visits '/restaurants/new' | show restaurant form |
| If user clicks submit on restaurant form, add new restaurant to DB and redirect to '/restaurants' | clicks submit | Add newRestaurant to DB, redirect to '/restaurants' |
| If user visits '/restaurants/{id}', they will see the details of the resaurant, including the menu items and buttons for 'Add new menu item' and 'go back'. | user visits restaurant page | show restaurant info and menu |
| User clicks 'add new menu item' button, redirect to '/restaurants/{id}/food/new' | clicks 'add menu item button'| 
| User adds new menu item name and price for Applebees | Margaritas, $1.00 | Menu item and price gets saved into database and page redirects back to Menu items | 
|If user clicks 'goback', redirect user to list of restaurants.|clicks 'goback'|show restaurants page|

/ - GET
/restaurants - GET
/restaurants - POST
/restaurants/new - GET
/restaurants/{id} - GET
/restaurants/{id} - POST
/retaurants/{id}/food/new - GET


## Setup/Installation Requirements

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/jamisoncozart/Restaurant-Rater/```
* ```$ cd Restaurant-Rater```

To run the program, navigate to the RestaurantRater production folder by typing the following into the terminal: 

* ```$ cd Restaurant-Rater```

Then run the program by typing:
* ```$ dotnet run```


## Support and Contact

Please email Brandan Sayarath or Jamie Cozart for any questions:

* brandan@brandan.tech
* jamisoncozart@gmail.com

## Technologies Used

This program was created with:

* C#
* .NET
* MySQL
* MySQL Workbench

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 Brandan Sayarath & Jamison Cozart
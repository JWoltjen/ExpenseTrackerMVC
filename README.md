# ExpenseTrackerMVC Tutorial Follow Along
![Expense Tracker Final](http://g.recordit.co/mmdy8VWTMd.gif)
This is a project I built following a tutorial online: https://www.youtube.com/watch?v=zQ5eijfpuu8&ab_channel=CodAffection. The purpose of this readme is to review the concepts covered during the tutorial to solidify the knowledge gained.

## Overview

This is an expense tracking applciation that is built with the .NET MVC design pattern, which uses C# and Razor syntax. Razor syntax allows you to embed server-side code within HTML markup to dynamically generate the content of the page. The project also makes use of a component library maintained by Syncfusion. These components can be used to enhance the user interface and functionality of applications. These controls cover a broad spectrum of features, such as grids, charts, gauges, calendars, editors, and more. Syncfusion's UI controls are designed to be customizable, feature-rich, and easy to integrate into different development environments and frameworks.

## Progression

### MVC Design Pattern

In the Model-View-Controller (MVC) architectural pattern, the responsibility of deciding what to display in a view lies primarily with the controller. The controller's role is to receive requests from the user, handle the business logic, and determine the appropriate data to pass to the view.

Here's a general overview of how MVC decides what to display in a view:

1. User interaction: The user initiates an action, such as submitting a form or clicking a link, which triggers a request to the controller.

2. Routing: The request is directed to a specific controller action based on the configured routes in the application. The action method is responsible for processing the request.

3. Data retrieval: The controller action retrieves the necessary data from the model or other data sources. This may involve querying a database, calling external APIs, or performing any other necessary data operations.

4. Data preparation: The controller action prepares the data by creating an instance of the appropriate view model or by populating dynamic properties on the ViewBag or ViewData objects. The view model is an object specifically designed to hold the data required by the view.

5. View selection: The controller action determines which view should be rendered based on the requested action and the corresponding view template. The view template is typically an HTML file containing the necessary placeholders and logic for rendering the data.

6. Data passing: The controller action passes the prepared data (view model or dynamic properties) to the selected view template.

7. Rendering: The view template receives the data and uses the appropriate HTML markup, Razor syntax (in ASP.NET MVC), or other view templating languages to display the data dynamically. The view may utilize loops, conditionals, and other logic to iterate through collections or conditionally render specific elements.

8. Response: The rendered view is returned as the response to the user's request.

By following this pattern, MVC separates the concerns of data retrieval, business logic, and rendering, allowing for modular and maintainable code. The controller acts as an intermediary, coordinating the interaction between the model (data), the view (presentation), and the user.

### Database Design and Models

The project used Entity Framework Core for database design. It had two entities, Category and Transaction. On of the things that I did not know about before this project was that I could use the "Not Mapped" attribute in a model class to combine two pieces of that model's  state in a more useful way. This project wanted to display the user-selected emoji icon next to the category name, and so creating a "Not Mapped" property, "public string? CategoryTitleWithIcon" made sense. The Transaction model also made use of navigation fields for Category, so that it would be easier to fetch a given Transactions associated category, hence the relational part of a relational database.

### Category and Transaction Views

Category and Transaction each had two views, index and AddOrEdit. Index was designed to display a list of categories/transactions using the SyncFusion component, ejs-grid and its various elements.The AddOrEdit view combines Post and Put methods into a single Post method from the controller. If the CategoryId or TransactionId == 0, the view will understand that we are adding something entirely new, else, it will understand that we are editing an existing Category or Transaction. The POST method is used for both actions because we are dealing with forms.

### Dashboard View

The Dashboard has one view, which is index. It makes use of two SyncFusion components, Spline Chart and Doughnut Chart. These components are highly configurable and so the Dashboard Controller takes advantage of the ViewBag to pass these custom components pieces of information without having to rely on strong-typed models. The Dashboard Controller creates several calculations, such as total income, total expenses, and balance, which it puts into the ViewBag to be displayed by the view at the appropriate area. The design of th Dashboard is broken down into several widgets, which are arranged with css bootstrap classes.

### Sidebar View


## Key Concepts and Challenges

1. Razor Syntax

The poster class stored in poster.js was the key to updating data for current poster before pushing that data into the various arrays: title array, quote array, images array, and saved poster array. To update current poster, we created functions that would randomly select one element from each of these arrays to become properties of the currentPoster object, an instantiation of the poster class. Once we had acquired values for each of currentPoster's keys, we could run a function that would return the currentPoster to the main section of the page.  This also allowed us to dynamically update the values of the currentPoster class when working with related concepts such as making custom posters.

2. SyncFusion Component Library

Using a new library for the first time is always daunting, especiallyh if it's for a one-off project like a tutorial. Nevertheless, it's good to get into the practice of opening up the documentation, grabbing some templates that look promising and getting your hands dirty. I was impressed with the wide range of components and the use of the spline chart and doughnut chart is something that I'd like to integrate into my personal projects like Contracted Logistics Tracking, which needs a dashboard.

3. 

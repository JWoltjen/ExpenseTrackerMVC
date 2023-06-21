# ExpenseTrackerMVC Tutorial Follow Along
(http://g.recordit.co/a13zsBbwCf.gif)
This is a project I built following a tutorial online: https://www.youtube.com/watch?v=zQ5eijfpuu8&ab_channel=CodAffection. The purpose of this readme is to review the concepts covered during the tutorial to solidify the knowledge gained.

## Overview

This is an expense tracking applciation that is built with the .NET MVC design pattern, which uses C# and Razor syntax. Razor syntax allows you to embed server-side code within HTML markup to dynamically generate the content of the page. The project also makes use of a component library maintained by Syncfusion. These components can be used to enhance the user interface and functionality of applications. These controls cover a broad spectrum of features, such as grids, charts, gauges, calendars, editors, and more. Syncfusion's UI controls are designed to be customizable, feature-rich, and easy to integrate into different development environments and frameworks.

## Progression

### Database Design and Models

The project used Entity Framework Core for database design. It had two entities, Category and Transaction. On of the things that I did not know about before this project was that I could use the "Not Mapped" attribute in a model class to combine two pieces of that model's  state in a more useful way. This project wanted to display the user-selected emoji icon next to the category name, and so creating a "Not Mapped" property, "public string? CategoryTitleWithIcon" made sense. The Transaction model also made use of navigation fields for Category, so that it would be easier to fetch a given Transactions associated category, hence the relational part of a relational database.

### Category and Transaction Views



### Dashboard View

### Sidebar View

Objectives

From the saved posters view, if a user double clicks a saved poster, it will be deleted.

![alt image: functionality of Iteration 4](http://g.recordit.co/NWO5fqkKuS.gif)


## Key Concepts and Challenges

1. Razor Syntax

The poster class stored in poster.js was the key to updating data for current poster before pushing that data into the various arrays: title array, quote array, images array, and saved poster array. To update current poster, we created functions that would randomly select one element from each of these arrays to become properties of the currentPoster object, an instantiation of the poster class. Once we had acquired values for each of currentPoster's keys, we could run a function that would return the currentPoster to the main section of the page.  This also allowed us to dynamically update the values of the currentPoster class when working with related concepts such as making custom posters.

2. SyncFusion Component Library

Using a new library for the first time is always daunting, especiallyh if it's for a one-off project like a tutorial. Nevertheless, it's good to get into the practice of opening up the documentation, grabbing some templates that look promising and getting your hands dirty. I was impressed with the wide range of components and the use of the spline chart and doughnut chart is something that I'd like to integrate into my personal projects like Contracted Logistics Tracking, which needs a dashboard.

3. 

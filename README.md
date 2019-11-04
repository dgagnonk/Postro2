# Postro2
Inventory management system for movie posters at cinemas.

## Why?
Ever wonder where cinemas get their movie posters? They're ordered directly from film distributors. Most cinemas hold on to their posters - every place has a system that works, or doesn't, for them. Most of the time these "systems" are just piles of posters in a basement. Postro aims to change that.

## What?
Postro was designed to allow cinema workers to keep track of which posters they have in stock and basic information about the film (Postro uses the [TMDb API](https://www.themoviedb.org/documentation/api?language=en-US) to gather information). Because these posters are now property of the receiving cinema, it's up to them what to do with them. Sometimes, they'll hold on to them in case the film screens again in the future. Or, they could sell them to collectors. So, Postro accounts for that. There are options to add pricing to different posters entered into the local database.

## The Tech
Postro was designed with touchscreens in mind. It's still a traditional desktop application at its core, but has been tested on Microsoft Surface tablets with touch enabled. It runs well on either the traditional desktop environment (Windows, keyboard, mouse), or with a Windows touch device.

Postro was developed using C# and Winforms. As long as the system is running .NET 4.5 and above, it'll run just fine.

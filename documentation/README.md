# Documentation

The main purpose behind this module is to provide the user with a map that has the ability to search for directions between two places, and show suggested routes if exists. It also shows the estimated time for every route, plus directions in details. 

The input boxes that enables the user to enter the source and destination are autocomplete boxes. This gives the flexibility for the user to determine the exact location he is looking for.

There is also a functionality that enables the user to set the “Source” field to his current location by clicking on “Use My Current Location”. 

The module is based on Google Maps APIs, so the user has the ability also to view the map in several views (Traffic, Map, Satellite).

## Summary

**Category:** SXA

## Pre-requisites

Does your module rely on other Sitecore modules or frameworks?

- Sitecore Experience Accelerator 1.6 rev. 180103 
- Sitecore PowerShell Extensions-4.7.2


## Usage

In order for the user to be able to use our module, he has to specify a key for the map which should be stored under the following path:

[Your site path] /Settings/Maps Provider

After that, he can simply drag and drop the Directions Map from the SXA toolbox that resides under the “Interactive Maps” category and select the Maps Provider as data source.
 
Screenshots:

Setting the key for the google maps API is the first step the user should do. 
Below is a screenshot of the location of the Map Provider setting that would have this key. It would be located at the following path:

[Your site path] /Settings/Maps Provider

![p1](images/p1.png?raw=true "p1")

You can find our Directions Map under the Sitecore Experience Accelerator toolbox under “Interactive Maps” tab. Below is a screenshot that shows you the popup that would appear after you drag and drop the Directions Map into your placeholder. This popup allows the user to select the Map Provider item as a data source.

![p2](images/p2.png?raw=true "p2")

Below is a look and feel of the Directions Map in the experience editor mode:

![p3](images/p3.png?raw=true "p3")

After saving and publishing your item, you can start using our control, by setting the source and destination in the autocomplete fields, and click on “Get Directions”. You can collapse the Directions Input Control on the side by clicking on the top right arrow. “Clear All” button clears out the fields and the directions in order to start a new search.

![p4](images/p4.png?raw=true "p4")

What’s Next:
- Improve the code and ajax calls to follow the best practice.
- Add variant to the render.
- Inject the css in the theme.
- Design modifications.

## Video

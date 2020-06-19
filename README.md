# COVID-19 Testing Locations Finder.
Website to help people find nearest COVID-19 testing locations in the U.S. Simply select a state and enter your zip code to see testing locations near you.

I believe testing for COVID-19 is one of the most important things we can be doing right now. By testing resources and funding can be allocated as needed and hotspots for the virus can be detected early before an outbreak becomes unmanageable. 

I hope my site can be a quick and easy way for someone to get the information and locations of testing locations near them in what may be a stressful time.


**Link to website:** [Find Testing Locations](http://find-covid-testing-locations.azurewebsites.net/)

**This prototype site is for the Girls in Tech 2020 Hackathon.** [Link to Hackathon](https://girls-in-tech-hackathon.devpost.com/)



## Features

This website allows people to conveniently access all the information needed to find the best testing site for their needs.

All a person has to do is select their state and enter their zip code. 

## Tools used 

Build using C# and asp.net this application is hosted on Azure and calls 2 APIS

By building on Azure and will be able to expand and scale the website as needed.

Main Tools used
* Azure cloud platform

* API to get locations information: [COVID-19 API Testing Locations](https://documenter.getpostman.com/view/8854915/SzS7PR3t?version=latest)

* API to get distance between zip codes: [Zip Code Distance](https://www.zipcodeapi.com/)

## Challenges + What I learned

I found setting up the APIs to be most challenging as there wasn't a lot of documentation on how they work.

I spend a lot of time trying to find a good way to get the distance from a person to each testing location, unfortunately, I wasn't able to find anything that worked well or that didn't cost money. I settled on an API that gets the distance base on zip code but I would like to find something more accurate than that.

I learned a lot of little things throughout the project, this tech stack is still new to me, so I found myself stuck and needed to figure out how to work a solution. I also gained more knowledge of how to build Azure applications as well as how to work with and call different types of APIs.

## Future Improvements

* Add more states
* Add more information about availability (days of the week and times each location is open)
* Find a more accurate way to get distance from locations (sorting by zip code distance isn't a great estimate and current API being used limits calls)

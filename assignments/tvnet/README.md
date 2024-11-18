### Front-end:

Assessment task for the frontend developer
Here is the description and assets needed for the assessment task.
The goal of this is to see how well you can learn new technologies.
We'd like to see the task done using: nuxt.js and vue.js.
Short description of the task is to build a small application to display 5 articles from a given endpoint. The articles do not have to open in the application and can link to Postimees site.
Here are the backend data endpoints and assets you could use
RestAPI endpoints needed for this task:
- SectionData: https://services.postimees.ee/rest/v1/sections/81
- Articles: https://services.postimees.ee/rest/v1/sections/81/editorsChoice/articles?limit=5
  Frontend Assets:
  5-uudist-frontend.zip

---

### Back-end:

  Assessment task for the backend developer
  Please build a URL shortener service using any technologies You'd like to achieve desired results.

As You probably know, a URL shortener is a service where You can provide a full long URL and it returns a shortened version of the URL that can be used to redirect the user to the full URL site.
For instance https://sport.postimees.ee/7293298/rally-estonia-liidrikohal-kihutanud-tanakul-purunes-rehv#_ga=2.64536491.565247913.1626420778-860827607.1614683494 could be translated to https://s.pmo.ee/Gh6x!5 etc (the latter link does not actually work)

The API should have 2 endpoints:
- one for generating short URL
- second for retrieving full URL with short URL or the shortened key

This task involves having You deciding whatever way You think is best for encoding the URLs and retrieving them (full URL, or key only etc)
The shortened url key/hash length should be no more than 11 characters.

Please bear in mind that the service should be scalable, should be able to handle 100000 encoding requests per day and 100 concurrent requests. You may consider machine resources infinite. Speed and efficiency are always important, and it's better if the shortened URLs are not scrapable, although that's not a requirement.

---

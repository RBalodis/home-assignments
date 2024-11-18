# Test task: Weather Poll App

### **User story**

As a client of the API service, i want to be able to query a service with a name of known location and get a hourly forecast of the temperature for a whole day in this location. The API service is using a https://open-meteo.com/ API to gather the data for each specific location. I want to send a GET request to a following URI:

```
https://localhost:8080/weather-api/locations/riga/temperature
https://localhost:8080/weather-api/locations/liepaja/temperature
```

And as a response from this endpoint, i want to get a following data:

```
{
	"alias": "riga",
	"latitude": 56.95,
	"longitude": 24.11,
	"hourly_temperature": {
	{
		"00:00": 5,
		"01:00": 4.5,
		"02:00": 4,
		...
		"18:00": 15,
		...
		"23:00": 8
	}
}
```

In the service configuration (appsettings.json) i want to specify which locations are queryable by their alias and coords:

```
// appsettings.json
{
	...,
	Locations: [
		{
			"alias": "riga",
			"latitude": 56.95,
			"longitude": 24.11,
			// "poll-interval": 600 - additional requirement
		},
		{
			"alias": "liepaja",
			"latitude": 56.50,
			"longitude": 21.01,
			// "poll-interval": 1200 - additional requirement
		}
	]
}
```

### **Minimal acceptance criteria:**

- .NET Core 6 or later
- Service can run and API can be queried for defined locations
- Swagger with a list of endpoints as a index page of service

### **Additional requirements (will count as bonus):**

- There is two API versions (v1 and v2) and v2 provides additional field in output (for example, “timezone”: “GMT”)
- Dockerfile to be able to run service in container
- Each location specified have it’s own background worker to gather data and store it in the in-memory cache or in distributed cache (Redis). Each location definition have an additional field “poll-interval” which specify the interval between polling. When the request from Weather Poll API client come, the data is taken from cache, not from open-meteo API HTTP response
- After each polling, the data is being dumped to MongoDB database in following model:

```
{
	"alias": "riga",
	"latitude": 56.95,
	"longitude": 24.11,
	"hourly_temperature": {
			"00:00": 5,
			"01:00": 4.5,
			"02:00": 4,
			...
			"18:00": 15,
			...
			"23:00": 8
	},
	"created": "2023-04-30T14:00:12"
}
```

### **Other info:**

- Minimal requirements should fit in 2.5 hours. Additional requirements are not necessary to be implemented and you can spend as much as you need, but the deadline to send the solution is 24h after interview;
- Project sources should be hosted in GitHub or Gitlab repo and the link to repository should be sent to example@example.com not later than 24h after interview.

Thanks for attention and good luck! 😉

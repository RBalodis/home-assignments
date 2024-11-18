
We expect to get "skeleton" of an app. Some functionality could also be implemented as example.



Language: PHP 7+

Framework, libraries, database: on your choice

Time: ~3-4 hours, it's ok if code will be unfinished.

TODO comments are highly welcome.



We need scientific application, which stores weather data from two weather stations.

Both stations send you statistic once per 24 hours, ignore question of delivery - let's say files appear in ./data directory once per 24 hours.

Each report should contain 24 records, for each hour, with weather details.



Station 1: you receive data in .json
files, file name YYYY-DD-MM, data:

Time: unix timestamp

Temperature: farengheit

Humidity: percent

Rain, inches per hour

Wind, miles per hour

Battery level, percent



Station 2: you receive data in .csv
files, file name DD-MM-YYYY, data:

Time: dd:mm:yyyy, hh:mm:ss

Temperature: celsius

Humidity: percent

Wind, km per hour

Rain, mm per hour

Light, lux

Battery level, enum (low, medium, high, full)



Application should be able to load this data, and provide api for internal clients (i.e. no exposure to the world) to answer following questions:

1) Information about temperature, humidity and wind from station 1, for given date and time

2) Information about temperature, humidity and wind from station 2, for given date and time

3) Averaged information about temperature, humidity and wind from both stations, for given date

4) Last available date/time

Application should write it's activity to the log file(s), logging level should be enough to understand app activities



Application should be done with those in mind (development not required, but architecture should mind this):

1) Multiple stations of both types can be added later

2) API could be exposed to the world for external clients, i.e. authorization will required

3) Weather stations in future could be located in different cities, and averaged info will be required for defined city


4) API could be extended no return more data positions
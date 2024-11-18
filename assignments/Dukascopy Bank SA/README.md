### CLI WEB Parser
As input argument we pass URL.
Script must find all values of attributes href/src for next tags:

- а href links
- img href images
- script src scripts
- link href styles

Output all data in JSON format - where each TAG has a list of all values

Exclude empty values
Script must runs out from command line
Provide link to your GIT repository

---

### Input (example)
php index.php https://www.php.net/manual/en/pdo.drivers.php

Output (example)

{
"a": [
"/",
"/downloads”,
],

"img": [
"/images/logos/php-logo.svg",
"/images/php8/logo_php8.svg",
],

"script": [
"//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js",
"/cached.php?t=1421837618&f=/js/ext/modernizr.js",
],

"link": [
"https://www.php.net/favicon.ico",
"http://php.net/phpnetimprovedsearch.src",
]
}

---
P.S: We advice to solve this task that show us your responsibility and quality level of code and solution.
You can use any tools that you want, libraries, frameworks e.t.c..

BONUS: If you can some how use framework - it will be great.
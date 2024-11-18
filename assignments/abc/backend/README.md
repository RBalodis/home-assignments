# Practical task "Reddit API"

Reddit is a social network that provides users with internet’s most popular content. The content is provided in “threads” that are cataloged into “subreddits”. Each thread has comments and a rating.

Reddit exposes a public API that is documented here: https://www.reddit.com/dev/api/

## Goal

To make a “proxy” WEB API that returns the current best 5 threads and 5 best comments for each of the threads. Your API should return the data in following JSON format:

```
{
    "threads": [
        {
            "title": "first threads title",
            "comments": [
                "first threads first comment",
                "first threads second comment"
            ]
        },
        {
            "title": "second threads title",
            "comments": [
                "second threads first comment",
                "second threads second comment"
            ]
        }
    ]
}
```
## Requirements

- To gain this data you must use the following reddit API methods:
    - https://www.reddit.com/dev/api/#GET_best for retrieving best threads (full url: https://oauth.reddit.com/best)
    - https://www.reddit.com/dev/api/#GET_comments_{article} for retrieving comments for a thread (full url: https://oauth.reddit.com/r/{subreddit}/comments/{thread_id})
- For authentication reddit requires OAuth 2 (and for you to create a user) and for this specific task you must use the “client credentials” flow as described in https://github.com/reddit-archive/reddit/wiki/OAuth2 at “Application Only OAuth” section.
- The solution must include full source code and instruction on how to build.


# JAVA task

Darba uzdevums

Izveidot REST API (Java vai Node.js) ar datubāzes izmantošanu (PostgreSQL vai MongoDB), kur realizēt loģikas implementēšanu priekš “Vēlmju saraksts” pārklāt to arunit testiem. Lūdzu, izveidojiet arī projekta struktūru ar visiem nepieciešamiem slāņiem, sekojot labām praksēm, tas arī tiks vērtēts.

 

Nepieciešams realizēt:

Pievienot vēlmi 
Atjaunot vēlmi
Dzēst vēlmi
Saņemt vēlmi 
Saņemt sarakstu ar vēlmēm
Papildu uzdevums: 
Izveidot atsevišķu ceļu, kurā pieņemt JSON request:

{

                "users": [{

                                                "type": "user",

                                                "id": 150709,

                                                "name": "johnsmith",

                                                "email": "jsmith@example.com"

                                }, {

                                                "type": "user",

                                                "id": 150710,

                                                "name": "angelinasmith",

                                                "email": "asmith@example.com"

                                },

                                // <…>

                                {

                                                "type": "user",

                                                "id": 150910,

                                                "name": "adamivanov",

                                                "email": "aivanov@another.org"

                                }

                ]

}

 

Jūsu mērķis ir apkopot visus “name” laukus un savienot tos ar komatu kā atdalītāju. API response jābūt: johnsmith, angelinasmith,…;

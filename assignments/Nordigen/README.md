***Task***

As the next step of the interview process, I'd like you to complete a take-home assignment.

The goal of the task is to get the list of bank transactions, first in Postman, then in Python code.

Bank to work with - Svenska Handelsbanken AB

Bank developer portal - https://developer.handelsbanken.com/

The bank's Sandbox environment must be used. The bank supports two authentication methods - redirect and decoupled. For this task, you must use the redirect method.

Here is the task step-by-step:

1. Register on the bank's developer portal and research the API documentation.

2. Create a Postman collection that contains all the necessary requests to get access token for authorization and retrieve transactions from the Sandbox environment.

3. Write the Python code in which the necessary requests are made to be able to get access token for authorization and to get transactions from the Sandbox environment (here you do not have to use the Postman collection itself, but create such or similar requests). Definitely need to use ready-made Python libraries, I recommend Requests. The code should output bank transaction list in a structured form - so it's easy to read for a human.

4. Final result - Postman collection (exported from Postman) as a .json file and Python code as a .py file sent as a reply to this email.

Notes:

1. There is a mistake in the bank's documentation at Step 3 - this step is testable and must be present in your solution. Do NOT use Access tokens provided in section "Accounts Test Data" as hard-coded values, instead you have to go through the flow to gain your access tokens programmatically.

2. Use Postman variables for values that come from previous responses, such as access tokens and consent IDs. These values must not be hard-coded.

Tips:

1. When prompted for the OAuth Redirection URL while creating your app on the bank's developer portal, feel free to use anything, such as "https://example.com".

2. Double check your Postman collection by exporting and then importing it back, to see if it still works.

I expect, that you are able to complete the task independently within one week's time.



***Task***

The goal of the task is to get the bank transactions, first in Postman, then in Python code.

Bank to work with - ICA Banken Sweden.
Bank developer portal - https://apim-icabanken.ica.se/store
The bank's Sandbox environment must be used.

Here is the task step-by-step:

1. Register on the bank's dev portal and research the API documentation.
2. Create a Postman collection that contains all the necessary requests to retrieve transactions from the Sandbox environment.
3. Write the Python code in which the necessary requests are made to be able to get transactions from the Sandbox environment (here you do not have to use the Postman collection itself, but create such or similar requests). Definitely need to use ready-made Python libraries, I recommend Requests.
4. Final result - Postman collection (exported from Postman) and Python code sent as a reply to this email.
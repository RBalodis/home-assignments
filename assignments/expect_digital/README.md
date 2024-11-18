# Technical test

Please interpret the requirements as you wish but keep it simple. The primary goal of the test is to evaluate your design skills, code quality and how well your code communicates with other software engineers. We accept incomplete technical tests, readability is #1 in our evaluation.

Choose any language, libraries and frameworks you feel comfortable with.

Nice to haves:

    Unit or integration tests
    Lint (static code analysis)

Description

The objective is to build a simple CRUD API to process Receipt (payment) resources. You can use either the REST API or any RPC (gRPC and so on) model. How the data is stored is up to you.

Please create the following API endpoints:

    Create a new Receipt
    Delete the Receipt by its id
    Get the Receipt by its id
    Get the list of Receipts

    Get all Receipts
    Get filtered Receipts by creation date range
    Get filtered Receipts by product name - find all Receipts containing an item with the name containing text

“Receipt” Fields

    Id - a unique identifier
    CreatedOn - the date when the given Receipt was created on
    Items - list of Receipt Items. Each item contains the following fields:
    -ProductName



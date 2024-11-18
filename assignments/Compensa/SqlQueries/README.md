Assume there are two tables in the database: person and personAddress.

person:

id

lastName

firstName

personalCode




personAddress:

id

personId (FK person.id) – foreign key to person table

type (values currently in use: CA, A, E) – CA – contact address, A – address, E - email

value (textual value depending on the type – for instance, in case of addresses, contain full address)

status (possible values: valid, invalid)


Please provide:

1.1 List for sending e-mails (data columns required: first name, last name, e-mail address) of all the
people for whom we have a valid e-mail address

1.2 List of all the people for whom there is no valid e-mail address (data columns required: first name,
last name, address). In case person has a valid Contact address specified, please use that in the
output.

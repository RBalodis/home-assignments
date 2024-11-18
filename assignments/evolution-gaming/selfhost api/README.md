# Integration Task

## Create C# Self-Hosted Web-App with REST Endpoints

**Example for use:** [Self-hosted Template on GitHub](https://github.com/NetCoreTemplates/selfhost)

### Main Functionalities to be Developed

1. **Integrate API:** `https://jsonplaceholder.typicode.com/users`
   - Create a database schema/structure for users and their relevant data.
   - Implement an action for synchronization from Remote to Local:
     - Read and save entries from the API into a database (options include SQLITE, MSSQL, PSQL, MySQL; in production, Azure SQL will be used).
     - Upon saving, an additional column should be added for each entry with the value formed using the pattern `#first letter of firstname# + #lastname# + #@ibsat.com#`.
     - On repeat execution, data should be:
       - Inserted if not present.
       - Updated if present.

2. **Action for Sync Local -> Remote:**
   - Read entries from the DB and check them against the API endpoint `https://jsonplaceholder.typicode.com/users`.
   - Prepare insert and update call methods that output prepared HTTP calls in the console (without actually executing them against the API).

3. **Action to Update a Field in User Data:**
   - Implement to make it differ from the value returned by the API.
   - A simple preset action will be okay, with a predefined change value.

4. **Action to Remove a User from the DB:**
   - Implement for the purpose of the API having one extra user that is missing in the local DB.
   - A simple preset action will be okay, displaying that the user was present before the delete event and is not afterward.

### Bonus Points for:

- Writing unit tests.
- Using bulk insert/merge techniques.

### Not Allowed to Use:

- Commercial or paid frameworks.

---
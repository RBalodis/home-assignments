# Test task for full stack developer

## Introduction

Dear candidates, please respect your time and the time of the reviewers. If, for any reason, you are unable to complete the task (not having enough time/being unable to do it, etc.), please inform us. Please check your project's functionality before submitting it ([checklist](https://www.notion.so/Test-task-for-full-stack-developer-53fd356b9e89499abe8d48cdbec427b6)).

Please take the time to complete the task carefully. Think about the project's architecture and use the "perks" of frameworks (Laravel/VueJs) to make your code high-quality. Organize your code as best as possible. If you can extract something into a service, do so. If you can use eloquent scopes somewhere, use them (show your knowledge). Write your code so that you're not ashamed to show it to others.

D**on't hesitate to ask questions if you don't understand the task.**

## Description

You need to implement a small website. The design is not important. The important thing is that all of the components listed below are present on the pages and the logic is described.

Average execution time: 5-6 hours.

It is necessary to implement all back-end logic using Laravel built-in functionality and, accordingly, implement all front-end logic using VueJS functionality.

The result must be uploaded to a public GitHub repository.

## Stack

- PHP 7.2+
- Laravel 6+
- VueJS 2+ (TypeScript will be a plus)

## Database description

```
users
    id - integer
    name - string
		email - string
		created_at - datetime
		updated_at - datetime

courses
    id - integer
    title - string
		created_at - datetime
		updated_at - datetime

enrollments
    id - integer
    course_id - integer
    user_id - integer
		status - integer
		created_at - datetime
		updated_at - datetime

```

## Home page description

Introduction: the main page is a blade file with an embedded VueJS component that makes requests to the back-end.

VueJS components:

- Table with 20 latest course records (with pagination) (Course name, User name, Status, Date of joining course, Date of course completion)
- Sorting - by completion date, by joining date, by alphabet
- Course name filter
- User email/name filter
- Enrollment status filter (in progress, complete)

## Back-end methods

- **Get a paginated list of course enrollments**

Introduction: there are only 2 enrollment statuses (in progress, complete). Sorting and filtering from the above points are performed on this same route.

- **Create a course enrollment**
- **Update a course enrollment**

Introduction: only the course status is updated. User_id/course_id fields are not edited.

- **Delete a course enrollment**

## Testing

- UserSeed - should generate 50 users with random data. CourseSeed - should generate 100 courses with random data. EnrollmentSeed - should create enrollment for 20 to 40 users with random statuses for each course.
- PHPUnit tests for all back-end methods

## Deployment

Deployment should be performed through standard mechanisms:

- git clone ...
- php artisan migrate
- php artisan db:seed
- php artisan serve

That is, importing SQL files or downloading zip archives is not acceptable.

## Project Checklist

- Delete the vendor and node_modules directories
- Delete all tables from the database (or recreate the database)
- Delete the .env file from the project root
- Create the .env file by copying .env.example
- Run composer install
- Run npm install && npm run build
- Generate a key (php artisan key:generate)
- Run migrations (php artisan migrate)
- Run seeds (php artisan db:seed)
- Run tests (php artisan test)
- Run the local server (php artisan serve)
- Check all written functionality
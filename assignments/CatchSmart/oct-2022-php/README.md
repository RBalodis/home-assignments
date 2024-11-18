# PHP (LARAVEL) developer – test task

## Main task goal

You are selling your services (you decide what kind of services) to many companies, but problem is – that you use only pen and paper. Each day there are more and more partners, and less time to write everything down.

You decide to create basic but useful web-app that will get rid of pen and paperwork.

1. Application functionality:

   - Your application should contain partner-organization profiles (only company name, address, some basic info).
   - Your application, have product warehouse (2-3 services/products – name, type, some basic info).
   - You can open organization profile and register successfully provided service (registered action should have date when service was provided, and price, maybe qt. – depending on product/service).
   - After, you can open product profile, and see – when, and to what organizations it was sold/provided.
   - You can open Organization and see when and what services was provided.
   - Products/Organizations summary pages (same as 3,4 – but for ALL products/organizations).

1. Your application should not be very complex (it can be done, with 3-5 controllers, 2 repositories, 2-3 services, 2-5 models (depends on if you use pivot for ER or not, and how you store entity data (see 3.g.).

1. Frontend does not matter at all, but if you decide to make Headless API (see 3.b.) – than probably you will end up using Vue/react/angular.

1. This should not take more than 8 hours but take as much time as you need.

## Strict task requirements:

1. Laravel should be used as main project foundation.
1. PgSQL/MySQL/MariaDB should be used as main database solution.
1. All DB tables should have migrations.

## Non-strict requirements (but nice to have):

1. All code flow follows Service-Repository pattern
1. Laravel foundation, serves as Headless API Gateway
1. CRUD pattern uses Resources (also in routes)
1. For request payload validation, FormRequest is used to do all validation BEFORE entering controller method.
1. For CRUD responses, data is returned always using same prebuilt/extended response structure (only msg and data differs).
1. For CRUD responses – returned data is extended JsonResource.
1. DB have at least 1 pivot table, properly used in Eloquent models.
1. Eloquent models use Traits
1. All code is written with “Code once, after only reuse” in mind.
1. Less composer packages – better.
1. Some usage of Laravel Commands and Scheduler.

_Dont worry, Take your time – and do your best!_

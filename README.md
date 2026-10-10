# School Directory Dashboard

## Description
A Blazor web application that consumes the Edutots School API and shows schools
in a searchable, sortable directory with a details panel.

## Features
- Fetches schools with `HttpClient` and deserializes JSON into C# models
- Search by school name (live, `@bind:event="oninput"`)
- Reusable `SchoolCard` component using `[Parameter]` and `EventCallback<School>`
- `SchoolDetails` component for the selected school
- Loading state and error handling
- Bonus: sorting (A-Z / Z-A), refresh button, Bootstrap layout

## Technologies
- .NET 8 (or later), C#
- Blazor Web App (Interactive Server)
- Bootstrap 5

## API endpoint
`GET https://edutots.net/api/school`

## Run
```bash
git clone <your-repo-url>
cd SchoolDirectoryApp
dotnet restore
dotnet run
```
Open the URL shown in the terminal and go to `/schools`.

## Screenshots
Add: school list, search, details view, loading state, error state.

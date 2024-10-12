<!-- Summary, Features, Frameworks/Libraries/Components -->

# **CatchUpPlatform News API** 

# Members - Aplicaciones Web - WX53

- Rodrigo Alcántara
- Daniel Chávarri
- Gianfranco Durand

# Contents
- [Summary](#summary)
- [Project Structure](#project-structure)
- [Features](#features)
- [Frameworks/Libraries/Components](#frameworkslibrariescomponents)


# Summary
The CatchUpPlatform News API is a service designed to allow users to manage their favorite news sources. The platform integrates with third-party news APIs, enabling users to create, update, delete, and query their preferred sources of news. This system is built using a simple in-memory repository for storing users’ favorite news sources, but it can be extended to work with a database or other persistent storage.

# Project Structure
The project follows a clean architecture that separates concerns into distinct layers:

- **Domain Layer:** Contains the core business logic and domain models, including commands and queries related to favorite news sources.
- **Application Layer:** Manages command handling and application services that coordinate between the domain and repository layers.
- **Infrastructure Layer:** (In this project, the in-memory repository) stores the favorite news sources and provides methods to query, update, and delete the data.

# Features
- **Create Favorite Source**: Allows users to add new sources to their favorites list.
- **Update Favorite Source**: Enables users to update their existing favorite sources.
- **Delete Favorite Source**: Lets users remove a source from their favorites.
- **Query Favorite Sources**: Users can search for their favorite sources by ID or by the combination of API key and source ID.

# Frameworks/Libraries/Components
- C# (.NET 8.0)
- CQRS (Command Query Responsibility Segregation)
- Clean Architecture: Organized into layers (Domain, Application, Infrastructure)
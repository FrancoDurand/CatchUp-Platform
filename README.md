# Aplicaciones Web - WX53
# **Members** 
- Rodrigo Alcántara
- Daniel Chávarri
- Gianfranco Durand

---------

**CatchUpPlatform News API**

**Overview**
The CatchUpPlatform News API is a service designed to allow users to manage their favorite news sources. The platform integrates with third-party news APIs, enabling users to create, update, delete, and query their preferred sources of news. This system is built using a simple in-memory repository for storing users’ favorite news sources, but it can be extended to work with a database or other persistent storage.

**Project Structure**
The project follows a clean architecture that separates concerns into distinct layers:

**Domain Layer:** Contains the core business logic and domain models, including commands and queries related to favorite news sources.
**Application Layer:** Manages command handling and application services that coordinate between the domain and repository layers.
**Infrastructure Layer:** (In this project, the in-memory repository) stores the favorite news sources and provides methods to query, update, and delete the data.

**Key Features**
**Favorite Source Management:** Users can create, update, delete, and query their favorite news sources.
**Query Support:** The system supports querying favorite sources by ID and by the combination of NewsApiKey and SourceId.
**In-Memory Repository:** For simplicity, the current implementation uses an in-memory repository to store and manage favorite news sources.

**Important Code Files**
**FavoriteSource (Domain Model):** Represents a user's favorite news source.

**Properties:** Id, NewsApiKey, SourceId.
**Methods:** Update() to modify the source details.

**Command Handlers:**
**CreateFavoriteSourceCommandHandler:** Handles the creation of a new favorite news source.
**UpdateFavoriteSourceCommandHandler:** Updates an existing favorite source.
**DeleteFavoriteSourceCommandHandler:** Deletes a favorite source by ID.

**Queries:**
**GetFavoriteSourceByIdQuery:** Retrieves a favorite source by its unique ID.
**GetFavoriteSourceByNewsApiKeyAndSourceIdQuery:** Retrieves a favorite source using the combination of NewsApiKey and SourceId.
**Repository:** IFavoriteSourceRepository defines the contract for storing and retrieving favorite sources. The current implementation is in-memory **(FavoriteSourceRepository)**, but it can be swapped with a database implementation.

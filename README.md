# Repository Pattern With Unit of Work
## Repository
Mediates between domian and data mapping layer, acting like a in-memory collection of domain objects.

## Unit of Work
Maintains a list of objects affected by a business transaction and coordinates the writinfg out of changes.

## Benefits
- Minimizes duplicate query logic
- Decouples the pattern from persistance frameworks
- Promotes testability

## Disadvantages
- It is violating Open/Closed Principle, as it is not really extendable. Also if we add a new repository, we need to modify the UoW class to include the new Repository. 
- It is violating Interface-Segregation Principle. ISP states that clients should not be forced to implement interfaces they don't use. This UoW contains an implementation of all the repositories, but then a consuming client does not need all these implementation, the client would probably just need one of them. 
- It is also violating Single Responsibility Principle, as the UoW is responsible for so many repositories.


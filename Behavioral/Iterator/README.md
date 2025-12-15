# Iterator (Behavioral)

Iterator allows sequential access to elements of a collection
without exposing how the collection is implemented.

This example uses a small book library with a custom iterator
instead of C#'s built-in foreach.

## Roles
- Iterator: IIterator
- Concrete Iterator: BookIterator
- Aggregate (Collection): BookCollection
- Item: Book

## Key idea
The client uses the iterator interface and does not know
how the collection stores or traverses its data.

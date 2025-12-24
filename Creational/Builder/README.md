# Builder (Creational)

Builder separates the construction of a complex object from its representation.
It allows building objects step by step with optional parts.

This example builds an HttpRequest with:
- method + url
- headers
- query parameters
- optional JSON body
- optional bearer auth

## Roles
- Product: HttpRequest
- Builder: HttpRequestBuilder
- Client: uses the builder to assemble the product

## When to use
- Many optional parameters (avoid telescoping constructors)
- You want readable construction code
- You want to ensure a valid object before creation

## Key idea
The builder collects parts, validates, then produces the final object.

# Interpreter (Behavioral)

Interpreter defines a representation for a grammar and an interpreter
that uses the representation to interpret sentences in the language.

This example interprets simple boolean rules over a context:
- comparisons (==, >=)
- logical composition (AND, OR)

## Roles
- Abstract Expression: common interface (IExpression)
- Terminal Expressions: leaf nodes (EqualsExpression, GreaterOrEqualExpression)
- Non-terminal Expressions: compose other expressions (AndExpression, OrExpression)
- Context: provides external data for interpretation

## When to use
- Simple DSLs (rules, filters, permissions)
- Expressions that can be represented as trees
- You need to add new operations by adding new expression classes

## Key idea
Expressions form a tree.
Evaluating the root evaluates the whole rule.

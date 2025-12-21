using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Interpreter.Expressions;

// Build expression:
// role == "admin" OR (country == "US" AND age >= 18)

IExpression rule =
    new OrExpression(
        new EqualsExpression("role", "admin"),
        new AndExpression(
            new EqualsExpression("country", "US"),
            new GreaterOrEqualExpression("age", 18)
        )
    );

// Context 1
var ctx1 = new Context();
ctx1.Set("role", "user");
ctx1.Set("country", "US");
ctx1.Set("age", 20);

// Context 2
var ctx2 = new Context();
ctx2.Set("role", "admin");
ctx2.Set("country", "DE");
ctx2.Set("age", 15);

// Context 3
var ctx3 = new Context();
ctx3.Set("role", "user");
ctx3.Set("country", "DE");
ctx3.Set("age", 30);

Console.WriteLine(rule.Interpret(ctx1)); // true
Console.WriteLine(rule.Interpret(ctx2)); // true
Console.WriteLine(rule.Interpret(ctx3)); // false
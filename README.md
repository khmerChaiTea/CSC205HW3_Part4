CSC205 Homework #3 Part 4

Static Methods

Pros:

Easier to Call: Static methods can be called directly with the class name
without needing to create an object first. This makes them simpler to use
when you just need to perform a task without worrying about specific objects.

Good for Utilities: They're great for utility functions that don't need to
work with specific objects' data. For example, a method to convert temperatures
between Fahrenheit and Celsius doesn't need to know about a particular thermometer object.

Help with Organization: They can help organize code by grouping related functions that
don't depend on instance variables together in one place.

Cons:

No Access to Object Data: Static methods can't directly access or change
instance variables (the data specific to an object) unless passed as parameters.
This limits their usefulness when you need to work with object-specific information.

Testing Challenges: Testing static methods in isolation can be harder because
they often rely on other static methods or external resources. This can make unit testing more complex.

Instance Methods

Pros:

Access to Object Data: Instance methods can freely access and modify instance variables,
which are the data that's unique to each object. This makes them ideal for tasks
that involve the specific state of an object.

Natural Object-Oriented Design: They fit naturally with object-oriented principles
like encapsulation (combining data and behavior in a single unit) and inheritance
(defining behavior that can be customized by subclasses).

Easier Testing: Instance methods are generally easier to test because they operate
within the context of a specific object, making it simpler to set up and verify expected behavior.

Cons:

Requires Object Creation: You need to create an object (an instance of a class)
before you can use its instance methods. This adds a small overhead in terms of
memory and performance compared to static methods.

Potential for State Issues: Instance methods can accidentally modify shared state
(data that's the same across multiple objects of the same class), leading to
unexpected behavior if not managed carefully.

Natural Expression of Computation
Simple Tasks: Use static methods for simple tasks that don't need to deal with
specific objects, like basic calculations or conversions.

Object Interactions: Use instance methods when you need to work with the data
specific to an object, such as updating properties or performing actions based on the object's current state.

Code Clarity: Instance methods often lead to clearer and more organized code
when you're working with classes and objects in an object-oriented way.
